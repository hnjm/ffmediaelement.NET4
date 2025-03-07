﻿namespace Unosquare.FFME.Core
{
    using FFmpeg.AutoGen;
    using Shared;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;

    /// <summary>
    /// Provides a set of utilities to perfrom logging, text formatting,
    /// conversion and other handy calculations.
    /// </summary>
    internal static class FFInterop
    {
        #region Private Declarations

        private static readonly object SyncLock = new object();
        private static bool m_IsInitialized = false;
        private static string m_LibrariesPath = string.Empty;
        private static int m_LibraryIdentifiers = 0;

        #endregion

        #region Properties

        /// <summary>
        /// True when libraries were initialized correctly.
        /// </summary>
        public static bool IsInitialized
        {
            get { lock (SyncLock) { return m_IsInitialized; } }
        }

        /// <summary>
        /// Gets the libraries path. Only filled when initialized correctly.
        /// </summary>
        public static string LibrariesPath
        {
            get { lock (SyncLock) { return m_LibrariesPath; } }
        }

        /// <summary>
        /// Gets the bitwise FFmpeg library identifiers that were loaded.
        /// </summary>
        public static int LibraryIdentifiers
        {
            get { lock (SyncLock) { return m_LibraryIdentifiers; } }
        }

        #endregion

        #region FFmpeg Registration

        /// <summary>
        /// Registers FFmpeg library and initializes its components.
        /// It only needs to be called once but calling it more than once
        /// has no effect. Returns the path that FFmpeg was registered from.
        /// This method is thread-safe.
        /// </summary>
        /// <param name="overridePath">The override path.</param>
        /// <param name="libIdentifiers">The bitwaise flag identifiers corresponding to the libraries.</param>
        /// <returns>
        /// Returns true if it was a new initialization and it succeeded. False if there was no need to initialize
        /// as there is already a valid initialization.
        /// </returns>
        /// <exception cref="FileNotFoundException">When ffmpeg libraries are not found</exception>
        public static unsafe bool Initialize(string overridePath, int libIdentifiers)
        {
            lock (SyncLock)
            {
                if (m_IsInitialized)
                    return false;

                try
                {
                    // Get the temporary path where FFmpeg binaries are located
                    var ffmpegPath = string.IsNullOrWhiteSpace(overridePath) == false ?
                        Path.GetFullPath(overridePath) : Constants.FFmpegSearchPath;

                    var registrationIds = 0;

                    // Sometimes we need to set the DLL directory even if we try to load the
                    // library from the full path. In some Windows systems we get error 126 if we don't
                    MediaEngine.Platform.NativeMethods.SetDllDirectory(ffmpegPath);

                    // Load the minimum set of FFmpeg binaries
                    foreach (var lib in FFLibrary.All)
                    {
                        if ((lib.FlagId & libIdentifiers) != 0 && lib.Load(ffmpegPath))
                                registrationIds |= lib.FlagId;
                    }

                    // Check if libraries were loaded correctly
                    if (FFLibrary.All.All(lib => lib.IsLoaded == false))
                    {
                        // Reset the search path
                        MediaEngine.Platform.NativeMethods.SetDllDirectory(null);
                        throw new FileNotFoundException($"Unable to load FFmpeg binaries from folder '{ffmpegPath}'.");
                    }

                    // Additional library initialization
                    if (FFLibrary.LibAVDevice.IsLoaded) ffmpeg.avdevice_register_all();
                    if (FFLibrary.LibAVFilter.IsLoaded) ffmpeg.avfilter_register_all();

                    // Standard set initialization
                    ffmpeg.av_register_all();
                    ffmpeg.avcodec_register_all();
                    ffmpeg.avformat_network_init();

                    // Logging and locking
                    LoggingWorker.ConnectToFFmpeg();
                    FFLockManager.Register();

                    // set the static environment properties
                    m_LibrariesPath = ffmpegPath;
                    m_LibraryIdentifiers = registrationIds;
                    m_IsInitialized = true;
                }
                catch
                {
                    m_LibrariesPath = string.Empty;
                    m_LibraryIdentifiers = 0;
                    m_IsInitialized = false;

                    // rethrow the exception with the original stack trace.
                    throw;
                }
                finally
                {
                    // Reset the search path after registration
                    MediaEngine.Platform.NativeMethods.SetDllDirectory(null);
                }

                return m_IsInitialized;
            }
        }

        #endregion

        #region Interop Helper Methods

        /// <summary>
        /// Gets the FFmpeg error mesage based on the error code
        /// </summary>
        /// <param name="errorCode">The code.</param>
        /// <returns>The decoded error message</returns>
        public static unsafe string DecodeMessage(int errorCode)
        {
            var bufferSize = 1024;
            var buffer = stackalloc byte[bufferSize];
            ffmpeg.av_strerror(errorCode, buffer, (ulong)bufferSize);
            var message = Marshal.PtrToStringAuto((IntPtr)buffer);
            return message;
        }

        /// <summary>
        /// Converts a byte pointer to a string
        /// </summary>
        /// <param name="bytePtr">The byte PTR.</param>
        /// <returns>The string</returns>
        public static unsafe string PtrToString(byte* bytePtr)
        {
            return Marshal.PtrToStringAuto(new IntPtr(bytePtr));
        }

        /// <summary>
        /// Converts a byte pointer to a UTF8 encoded string.
        /// </summary>
        /// <param name="bytePtr">The byte PTR.</param>
        /// <returns>The string</returns>
        public static unsafe string PtrToStringUTF8(byte* bytePtr)
        {
            if (bytePtr == null) return null;
            if (*bytePtr == 0) return string.Empty;

            var byteBuffer = new List<byte>(1024);
            var currentByte = default(byte);

            while (true)
            {
                currentByte = *bytePtr;
                if (currentByte == 0)
                    break;

                byteBuffer.Add(currentByte);
                bytePtr++;
            }

            return Encoding.UTF8.GetString(byteBuffer.ToArray());
        }

        public static IntPtr NativeUtf8FromString(string managedString)
        {
            int len = Encoding.UTF8.GetByteCount(managedString);
            byte[] buffer = new byte[len + 1];
            Encoding.UTF8.GetBytes(managedString, 0, managedString.Length, buffer, 0);
            IntPtr nativeUtf8 = Marshal.AllocHGlobal(buffer.Length);
            Marshal.Copy(buffer, 0, nativeUtf8, buffer.Length);
            return nativeUtf8;
        }
        #endregion
    }
}
