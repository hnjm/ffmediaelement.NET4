﻿namespace Unosquare.FFME
{
    using Shared;
    using System;
    using System.Runtime.CompilerServices;

    public partial class MediaEngine
    {
        #region Connector Signals

        /// <summary>
        /// Raises the MessageLogged event
        /// </summary>
        /// <param name="message">The <see cref="MediaLogMessage" /> instance containing the message.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnMessageLogged(MediaLogMessage message)
        {
            Connector?.OnMessageLogged(this, message);
        }

        /// <summary>
        /// Raises the media failed event.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnMediaFailed(Exception ex)
        {
            Log(MediaLogMessageType.Error, $"Media Failure - {ex?.GetType()}: {ex?.Message}");
            Connector?.OnMediaFailed(this, ex);
        }

        /// <summary>
        /// Raises the media closed event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnMediaClosed()
        {
            Connector?.OnMediaClosed(this);
        }

        /// <summary>
        /// Raises the media opened event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnMediaOpened()
        {
            Connector?.OnMediaOpened(this);
        }

        /// <summary>
        /// Raises the media opening event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnMediaOpening()
        {
            Connector?.OnMediaOpening(this, Container.MediaOptions, Container.MediaInfo);
        }

        /// <summary>
        /// Raises the buffering started event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnBufferingStarted()
        {
            Connector?.OnBufferingStarted(this);
        }

        /// <summary>
        /// Raises the buffering ended event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnBufferingEnded()
        {
            Connector?.OnBufferingEnded(this);
        }

        /// <summary>
        /// Raises the Seeking started event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnSeekingStarted()
        {
            Connector?.OnSeekingStarted(this);
        }

        /// <summary>
        /// Raises the Seeking ended event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnSeekingEnded()
        {
            Connector?.OnSeekingEnded(this);
        }

        /// <summary>
        /// Raises the media ended event.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnMediaEnded()
        {
            Connector?.OnMediaEnded(this);
        }

        /// <summary>
        /// Raises the Position Changed event
        /// </summary>
        /// <param name="position">The position.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal void SendOnPositionChanged(TimeSpan position)
        {
            Connector?.OnPositionChanged(this, position);
        }

        /// <summary>
        /// Notifies the platform connector that a property value has changed.
        /// </summary>
        /// <param name="propertyName">Name of the property used to notify listeners.  This
        /// value is optional and can be provided automatically when invoked from compilers
        /// that support <see cref="CallerMemberNameAttribute"/>.</param>
        private void SendOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Connector?.OnPropertyChanged(this, propertyName);
        }

        #endregion
    }
}