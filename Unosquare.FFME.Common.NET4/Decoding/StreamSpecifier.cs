﻿namespace Unosquare.FFME.Decoding
{
    using Shared;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;

    /// <summary>
    /// A managed representation of an FFmpeg stream specifier
    /// </summary>
    internal class StreamSpecifier
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSpecifier"/> class.
        /// </summary>
        public StreamSpecifier()
        {
            StreamSuffix = string.Empty;
            StreamId = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSpecifier"/> class.
        /// </summary>
        /// <param name="streamId">The stream identifier.</param>
        /// <exception cref="ArgumentException">streamId</exception>
        public StreamSpecifier(int streamId)
        {
            if (streamId < 0)
                throw new ArgumentException($"{nameof(streamId)} must be greater than or equal to 0");

            StreamSuffix = string.Empty;
            StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSpecifier"/> class.
        /// </summary>
        /// <param name="mediaType">Type of the media.</param>
        /// <exception cref="ArgumentException">streamType</exception>
        public StreamSpecifier(MediaType mediaType)
        {
            var streamType = Types[mediaType];
            if (streamType != 'a' && streamType != 'v' && streamType != 's')
                throw new ArgumentException($"{nameof(streamType)} must be either a, v, or s");

            StreamSuffix = new string(streamType, 1);
            StreamId = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSpecifier"/> class.
        /// </summary>
        /// <param name="mediaType">Type of the media.</param>
        /// <param name="streamId">The stream identifier.</param>
        /// <exception cref="ArgumentException">
        /// streamType
        /// or
        /// streamId
        /// </exception>
        public StreamSpecifier(MediaType mediaType, int streamId)
        {
            var streamType = Types[mediaType];
            if (streamType != 'a' && streamType != 'v' && streamType != 's')
                throw new ArgumentException($"{nameof(streamType)} must be either a, v, or s");

            if (streamId < 0)
                throw new ArgumentException($"{nameof(streamId)} must be greater than or equal to 0");

            StreamSuffix = new string(streamType, 1);
            StreamId = streamId;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Provides suffixes for the different media types.
        /// </summary>
        public static Dictionary<MediaType, char> Types { get; }
            = new Dictionary<MediaType, char>(new Dictionary<MediaType, char>
            {
                { MediaType.Audio, 'a' },
                { MediaType.Video, 'v' },
                { MediaType.Subtitle, 's' },
            });

        /// <summary>
        /// Gets the stream identifier.
        /// </summary>
        public int StreamId { get; }

        /// <summary>
        /// Gets the stream suffix.
        /// </summary>
        public string StreamSuffix { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a <see cref="string" /> that represents this stream specifier.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(StreamSuffix) == false && StreamId >= 0)
                return $"{StreamSuffix}:{StreamId}";

            if (string.IsNullOrWhiteSpace(StreamSuffix) == false)
                return StreamSuffix;

            if (StreamId >= 0)
                return StreamId.ToString(CultureInfo.InvariantCulture);

            return string.Empty;
        }

        #endregion
    }
}
