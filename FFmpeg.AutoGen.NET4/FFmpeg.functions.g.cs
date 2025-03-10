using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen
{
    public unsafe static partial class ffmpeg
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int audio_resample_delegate(ReSampleContext* @s, short* @output, short* @input, int @nb_samples);
        private static audio_resample_delegate audio_resample_fptr = (ReSampleContext* @s, short* @output, short* @input, int @nb_samples) =>
        {
            audio_resample_fptr = GetFunctionDelegate<audio_resample_delegate>(GetOrLoadLibrary("avcodec", 57), "audio_resample");
            if (audio_resample_fptr == null)
            {
                audio_resample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("audio_resample is not supported on this platform.");
                };
            }
            return audio_resample_fptr(@s, @output, @input, @nb_samples);
        };
        [Obsolete("")]
        public static int audio_resample(ReSampleContext* @s, short* @output, short* @input, int @nb_samples)
        {
            return audio_resample_fptr(@s, @output, @input, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void audio_resample_close_delegate(ReSampleContext* @s);
        private static audio_resample_close_delegate audio_resample_close_fptr = (ReSampleContext* @s) =>
        {
            audio_resample_close_fptr = GetFunctionDelegate<audio_resample_close_delegate>(GetOrLoadLibrary("avcodec", 57), "audio_resample_close");
            if (audio_resample_close_fptr == null)
            {
                audio_resample_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("audio_resample_close is not supported on this platform.");
                };
            }
            audio_resample_close_fptr(@s);
        };
        /// <summary>Free resample context.</summary>
        /// <param name="s">a non-NULL pointer to a resample context previously created with av_audio_resample_init()</param>
        [Obsolete("")]
        public static void audio_resample_close(ReSampleContext* @s)
        {
            audio_resample_close_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ReSampleContext* av_audio_resample_init_delegate(int @output_channels, int @input_channels, int @output_rate, int @input_rate, AVSampleFormat @sample_fmt_out, AVSampleFormat @sample_fmt_in, int @filter_length, int @log2_phase_count, int @linear, double @cutoff);
        private static av_audio_resample_init_delegate av_audio_resample_init_fptr = (int @output_channels, int @input_channels, int @output_rate, int @input_rate, AVSampleFormat @sample_fmt_out, AVSampleFormat @sample_fmt_in, int @filter_length, int @log2_phase_count, int @linear, double @cutoff) =>
        {
            av_audio_resample_init_fptr = GetFunctionDelegate<av_audio_resample_init_delegate>(GetOrLoadLibrary("avcodec", 57), "av_audio_resample_init");
            if (av_audio_resample_init_fptr == null)
            {
                av_audio_resample_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_resample_init is not supported on this platform.");
                };
            }
            return av_audio_resample_init_fptr(@output_channels, @input_channels, @output_rate, @input_rate, @sample_fmt_out, @sample_fmt_in, @filter_length, @log2_phase_count, @linear, @cutoff);
        };
        /// <summary>Initialize audio resampling context.</summary>
        /// <param name="output_channels">number of output channels</param>
        /// <param name="input_channels">number of input channels</param>
        /// <param name="output_rate">output sample rate</param>
        /// <param name="input_rate">input sample rate</param>
        /// <param name="sample_fmt_out">requested output sample format</param>
        /// <param name="sample_fmt_in">input sample format</param>
        /// <param name="filter_length">length of each FIR filter in the filterbank relative to the cutoff frequency</param>
        /// <param name="log2_phase_count">log2 of the number of entries in the polyphase filterbank</param>
        /// <param name="linear">if 1 then the used FIR filter will be linearly interpolated between the 2 closest, if 0 the closest will be used</param>
        /// <param name="cutoff">cutoff frequency, 1.0 corresponds to half the output sampling rate</param>
        [Obsolete("")]
        public static ReSampleContext* av_audio_resample_init(int @output_channels, int @input_channels, int @output_rate, int @input_rate, AVSampleFormat @sample_fmt_out, AVSampleFormat @sample_fmt_in, int @filter_length, int @log2_phase_count, int @linear, double @cutoff)
        {
            return av_audio_resample_init_fptr(@output_channels, @input_channels, @output_rate, @input_rate, @sample_fmt_out, @sample_fmt_in, @filter_length, @log2_phase_count, @linear, @cutoff);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_bitstream_filter_close_delegate(AVBitStreamFilterContext* @bsf);
        private static av_bitstream_filter_close_delegate av_bitstream_filter_close_fptr = (AVBitStreamFilterContext* @bsf) =>
        {
            av_bitstream_filter_close_fptr = GetFunctionDelegate<av_bitstream_filter_close_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bitstream_filter_close");
            if (av_bitstream_filter_close_fptr == null)
            {
                av_bitstream_filter_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bitstream_filter_close is not supported on this platform.");
                };
            }
            av_bitstream_filter_close_fptr(@bsf);
        };
        /// <summary>Release bitstream filter context.</summary>
        /// <param name="bsf">the bitstream filter context created with av_bitstream_filter_init(), can be NULL</param>
        [Obsolete("")]
        public static void av_bitstream_filter_close(AVBitStreamFilterContext* @bsf)
        {
            av_bitstream_filter_close_fptr(@bsf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bitstream_filter_filter_delegate(AVBitStreamFilterContext* @bsfc, AVCodecContext* @avctx, [MarshalAs(UnmanagedType.LPStr)] string @args, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe);
        private static av_bitstream_filter_filter_delegate av_bitstream_filter_filter_fptr = (AVBitStreamFilterContext* @bsfc, AVCodecContext* @avctx, string @args, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe) =>
        {
            av_bitstream_filter_filter_fptr = GetFunctionDelegate<av_bitstream_filter_filter_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bitstream_filter_filter");
            if (av_bitstream_filter_filter_fptr == null)
            {
                av_bitstream_filter_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bitstream_filter_filter is not supported on this platform.");
                };
            }
            return av_bitstream_filter_filter_fptr(@bsfc, @avctx, @args, @poutbuf, @poutbuf_size, @buf, @buf_size, @keyframe);
        };
        /// <summary>Filter bitstream.</summary>
        /// <param name="bsfc">bitstream filter context created by av_bitstream_filter_init()</param>
        /// <param name="avctx">AVCodecContext accessed by the filter, may be NULL. If specified, this must point to the encoder context of the output stream the packet is sent to.</param>
        /// <param name="args">arguments which specify the filter configuration, may be NULL</param>
        /// <param name="poutbuf">pointer which is updated to point to the filtered buffer</param>
        /// <param name="poutbuf_size">pointer which is updated to the filtered buffer size in bytes</param>
        /// <param name="buf">buffer containing the data to filter</param>
        /// <param name="buf_size">size in bytes of buf</param>
        /// <param name="keyframe">set to non-zero if the buffer to filter corresponds to a key-frame packet data</param>
        [Obsolete("")]
        public static int av_bitstream_filter_filter(AVBitStreamFilterContext* @bsfc, AVCodecContext* @avctx, [MarshalAs(UnmanagedType.LPStr)] string @args, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe)
        {
            return av_bitstream_filter_filter_fptr(@bsfc, @avctx, @args, @poutbuf, @poutbuf_size, @buf, @buf_size, @keyframe);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBitStreamFilterContext* av_bitstream_filter_init_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_bitstream_filter_init_delegate av_bitstream_filter_init_fptr = (string @name) =>
        {
            av_bitstream_filter_init_fptr = GetFunctionDelegate<av_bitstream_filter_init_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bitstream_filter_init");
            if (av_bitstream_filter_init_fptr == null)
            {
                av_bitstream_filter_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bitstream_filter_init is not supported on this platform.");
                };
            }
            return av_bitstream_filter_init_fptr(@name);
        };
        /// <summary>Create and initialize a bitstream filter context given a bitstream filter name.</summary>
        /// <param name="name">the name of the bitstream filter</param>
        [Obsolete("")]
        public static AVBitStreamFilterContext* av_bitstream_filter_init([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_bitstream_filter_init_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBitStreamFilter* av_bitstream_filter_next_delegate(AVBitStreamFilter* @f);
        private static av_bitstream_filter_next_delegate av_bitstream_filter_next_fptr = (AVBitStreamFilter* @f) =>
        {
            av_bitstream_filter_next_fptr = GetFunctionDelegate<av_bitstream_filter_next_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bitstream_filter_next");
            if (av_bitstream_filter_next_fptr == null)
            {
                av_bitstream_filter_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bitstream_filter_next is not supported on this platform.");
                };
            }
            return av_bitstream_filter_next_fptr(@f);
        };
        /// <summary>If f is NULL, return the first registered bitstream filter, if f is non-NULL, return the next registered bitstream filter after f, or NULL if f is the last one.</summary>
        [Obsolete("")]
        public static AVBitStreamFilter* av_bitstream_filter_next(AVBitStreamFilter* @f)
        {
            return av_bitstream_filter_next_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_alloc_delegate(AVBitStreamFilter* @filter, AVBSFContext** @ctx);
        private static av_bsf_alloc_delegate av_bsf_alloc_fptr = (AVBitStreamFilter* @filter, AVBSFContext** @ctx) =>
        {
            av_bsf_alloc_fptr = GetFunctionDelegate<av_bsf_alloc_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_alloc");
            if (av_bsf_alloc_fptr == null)
            {
                av_bsf_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_alloc is not supported on this platform.");
                };
            }
            return av_bsf_alloc_fptr(@filter, @ctx);
        };
        /// <summary>Allocate a context for a given bitstream filter. The caller must fill in the context parameters as described in the documentation and then call av_bsf_init() before sending any data to the filter.</summary>
        /// <param name="filter">the filter for which to allocate an instance.</param>
        /// <param name="ctx">a pointer into which the pointer to the newly-allocated context will be written. It must be freed with av_bsf_free() after the filtering is done.</param>
        public static int av_bsf_alloc(AVBitStreamFilter* @filter, AVBSFContext** @ctx)
        {
            return av_bsf_alloc_fptr(@filter, @ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_bsf_free_delegate(AVBSFContext** @ctx);
        private static av_bsf_free_delegate av_bsf_free_fptr = (AVBSFContext** @ctx) =>
        {
            av_bsf_free_fptr = GetFunctionDelegate<av_bsf_free_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_free");
            if (av_bsf_free_fptr == null)
            {
                av_bsf_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_free is not supported on this platform.");
                };
            }
            av_bsf_free_fptr(@ctx);
        };
        /// <summary>Free a bitstream filter context and everything associated with it; write NULL into the supplied pointer.</summary>
        public static void av_bsf_free(AVBSFContext** @ctx)
        {
            av_bsf_free_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBitStreamFilter* av_bsf_get_by_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_bsf_get_by_name_delegate av_bsf_get_by_name_fptr = (string @name) =>
        {
            av_bsf_get_by_name_fptr = GetFunctionDelegate<av_bsf_get_by_name_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_get_by_name");
            if (av_bsf_get_by_name_fptr == null)
            {
                av_bsf_get_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_get_by_name is not supported on this platform.");
                };
            }
            return av_bsf_get_by_name_fptr(@name);
        };
        /// <summary>Returns a bitstream filter with the specified name or NULL if no such bitstream filter exists.</summary>
        public static AVBitStreamFilter* av_bsf_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_bsf_get_by_name_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* av_bsf_get_class_delegate();
        private static av_bsf_get_class_delegate av_bsf_get_class_fptr = () =>
        {
            av_bsf_get_class_fptr = GetFunctionDelegate<av_bsf_get_class_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_get_class");
            if (av_bsf_get_class_fptr == null)
            {
                av_bsf_get_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_get_class is not supported on this platform.");
                };
            }
            return av_bsf_get_class_fptr();
        };
        /// <summary>Get the AVClass for AVBSFContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* av_bsf_get_class()
        {
            return av_bsf_get_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_get_null_filter_delegate(AVBSFContext** @bsf);
        private static av_bsf_get_null_filter_delegate av_bsf_get_null_filter_fptr = (AVBSFContext** @bsf) =>
        {
            av_bsf_get_null_filter_fptr = GetFunctionDelegate<av_bsf_get_null_filter_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_get_null_filter");
            if (av_bsf_get_null_filter_fptr == null)
            {
                av_bsf_get_null_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_get_null_filter is not supported on this platform.");
                };
            }
            return av_bsf_get_null_filter_fptr(@bsf);
        };
        /// <summary>Get null/pass-through bitstream filter.</summary>
        /// <param name="bsf">Pointer to be set to new instance of pass-through bitstream filter</param>
        public static int av_bsf_get_null_filter(AVBSFContext** @bsf)
        {
            return av_bsf_get_null_filter_fptr(@bsf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_init_delegate(AVBSFContext* @ctx);
        private static av_bsf_init_delegate av_bsf_init_fptr = (AVBSFContext* @ctx) =>
        {
            av_bsf_init_fptr = GetFunctionDelegate<av_bsf_init_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_init");
            if (av_bsf_init_fptr == null)
            {
                av_bsf_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_init is not supported on this platform.");
                };
            }
            return av_bsf_init_fptr(@ctx);
        };
        /// <summary>Prepare the filter for use, after all the parameters and options have been set.</summary>
        public static int av_bsf_init(AVBSFContext* @ctx)
        {
            return av_bsf_init_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBSFList* av_bsf_list_alloc_delegate();
        private static av_bsf_list_alloc_delegate av_bsf_list_alloc_fptr = () =>
        {
            av_bsf_list_alloc_fptr = GetFunctionDelegate<av_bsf_list_alloc_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_list_alloc");
            if (av_bsf_list_alloc_fptr == null)
            {
                av_bsf_list_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_list_alloc is not supported on this platform.");
                };
            }
            return av_bsf_list_alloc_fptr();
        };
        /// <summary>Allocate empty list of bitstream filters. The list must be later freed by av_bsf_list_free() or finalized by av_bsf_list_finalize().</summary>
        public static AVBSFList* av_bsf_list_alloc()
        {
            return av_bsf_list_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_list_append_delegate(AVBSFList* @lst, AVBSFContext* @bsf);
        private static av_bsf_list_append_delegate av_bsf_list_append_fptr = (AVBSFList* @lst, AVBSFContext* @bsf) =>
        {
            av_bsf_list_append_fptr = GetFunctionDelegate<av_bsf_list_append_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_list_append");
            if (av_bsf_list_append_fptr == null)
            {
                av_bsf_list_append_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_list_append is not supported on this platform.");
                };
            }
            return av_bsf_list_append_fptr(@lst, @bsf);
        };
        /// <summary>Append bitstream filter to the list of bitstream filters.</summary>
        /// <param name="lst">List to append to</param>
        /// <param name="bsf">Filter context to be appended</param>
        public static int av_bsf_list_append(AVBSFList* @lst, AVBSFContext* @bsf)
        {
            return av_bsf_list_append_fptr(@lst, @bsf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_list_append2_delegate(AVBSFList* @lst, [MarshalAs(UnmanagedType.LPStr)] string @bsf_name, AVDictionary** @options);
        private static av_bsf_list_append2_delegate av_bsf_list_append2_fptr = (AVBSFList* @lst, string @bsf_name, AVDictionary** @options) =>
        {
            av_bsf_list_append2_fptr = GetFunctionDelegate<av_bsf_list_append2_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_list_append2");
            if (av_bsf_list_append2_fptr == null)
            {
                av_bsf_list_append2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_list_append2 is not supported on this platform.");
                };
            }
            return av_bsf_list_append2_fptr(@lst, @bsf_name, @options);
        };
        /// <summary>Construct new bitstream filter context given it&apos;s name and options and append it to the list of bitstream filters.</summary>
        /// <param name="lst">List to append to</param>
        /// <param name="bsf_name">Name of the bitstream filter</param>
        /// <param name="options">Options for the bitstream filter, can be set to NULL</param>
        public static int av_bsf_list_append2(AVBSFList* @lst, [MarshalAs(UnmanagedType.LPStr)] string @bsf_name, AVDictionary** @options)
        {
            return av_bsf_list_append2_fptr(@lst, @bsf_name, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_list_finalize_delegate(AVBSFList** @lst, AVBSFContext** @bsf);
        private static av_bsf_list_finalize_delegate av_bsf_list_finalize_fptr = (AVBSFList** @lst, AVBSFContext** @bsf) =>
        {
            av_bsf_list_finalize_fptr = GetFunctionDelegate<av_bsf_list_finalize_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_list_finalize");
            if (av_bsf_list_finalize_fptr == null)
            {
                av_bsf_list_finalize_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_list_finalize is not supported on this platform.");
                };
            }
            return av_bsf_list_finalize_fptr(@lst, @bsf);
        };
        /// <summary>Finalize list of bitstream filters.</summary>
        /// <param name="lst">Filter list structure to be transformed</param>
        /// <param name="bsf">Pointer to be set to newly created</param>
        public static int av_bsf_list_finalize(AVBSFList** @lst, AVBSFContext** @bsf)
        {
            return av_bsf_list_finalize_fptr(@lst, @bsf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_bsf_list_free_delegate(AVBSFList** @lst);
        private static av_bsf_list_free_delegate av_bsf_list_free_fptr = (AVBSFList** @lst) =>
        {
            av_bsf_list_free_fptr = GetFunctionDelegate<av_bsf_list_free_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_list_free");
            if (av_bsf_list_free_fptr == null)
            {
                av_bsf_list_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_list_free is not supported on this platform.");
                };
            }
            av_bsf_list_free_fptr(@lst);
        };
        /// <summary>Free list of bitstream filters.</summary>
        /// <param name="lst">Pointer to pointer returned by av_bsf_list_alloc()</param>
        public static void av_bsf_list_free(AVBSFList** @lst)
        {
            av_bsf_list_free_fptr(@lst);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_list_parse_str_delegate([MarshalAs(UnmanagedType.LPStr)] string @str, AVBSFContext** @bsf);
        private static av_bsf_list_parse_str_delegate av_bsf_list_parse_str_fptr = (string @str, AVBSFContext** @bsf) =>
        {
            av_bsf_list_parse_str_fptr = GetFunctionDelegate<av_bsf_list_parse_str_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_list_parse_str");
            if (av_bsf_list_parse_str_fptr == null)
            {
                av_bsf_list_parse_str_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_list_parse_str is not supported on this platform.");
                };
            }
            return av_bsf_list_parse_str_fptr(@str, @bsf);
        };
        /// <summary>Parse string describing list of bitstream filters and create single Resulting allocated by av_bsf_alloc().</summary>
        /// <param name="str">String describing chain of bitstream filters in format `bsf1[=opt1=val1:opt2=val2][,bsf2]`</param>
        /// <param name="bsf">Pointer to be set to newly created</param>
        public static int av_bsf_list_parse_str([MarshalAs(UnmanagedType.LPStr)] string @str, AVBSFContext** @bsf)
        {
            return av_bsf_list_parse_str_fptr(@str, @bsf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBitStreamFilter* av_bsf_next_delegate(void** @opaque);
        private static av_bsf_next_delegate av_bsf_next_fptr = (void** @opaque) =>
        {
            av_bsf_next_fptr = GetFunctionDelegate<av_bsf_next_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_next");
            if (av_bsf_next_fptr == null)
            {
                av_bsf_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_next is not supported on this platform.");
                };
            }
            return av_bsf_next_fptr(@opaque);
        };
        /// <summary>Iterate over all registered bitstream filters.</summary>
        /// <param name="opaque">a pointer where libavcodec will store the iteration state. Must point to NULL to start the iteration.</param>
        public static AVBitStreamFilter* av_bsf_next(void** @opaque)
        {
            return av_bsf_next_fptr(@opaque);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_receive_packet_delegate(AVBSFContext* @ctx, AVPacket* @pkt);
        private static av_bsf_receive_packet_delegate av_bsf_receive_packet_fptr = (AVBSFContext* @ctx, AVPacket* @pkt) =>
        {
            av_bsf_receive_packet_fptr = GetFunctionDelegate<av_bsf_receive_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_receive_packet");
            if (av_bsf_receive_packet_fptr == null)
            {
                av_bsf_receive_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_receive_packet is not supported on this platform.");
                };
            }
            return av_bsf_receive_packet_fptr(@ctx, @pkt);
        };
        /// <summary>Retrieve a filtered packet.</summary>
        /// <param name="pkt">this struct will be filled with the contents of the filtered packet. It is owned by the caller and must be freed using av_packet_unref() when it is no longer needed. This parameter should be &quot;clean&quot; (i.e. freshly allocated with av_packet_alloc() or unreffed with av_packet_unref()) when this function is called. If this function returns successfully, the contents of pkt will be completely overwritten by the returned data. On failure, pkt is not touched.</param>
        public static int av_bsf_receive_packet(AVBSFContext* @ctx, AVPacket* @pkt)
        {
            return av_bsf_receive_packet_fptr(@ctx, @pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_bsf_send_packet_delegate(AVBSFContext* @ctx, AVPacket* @pkt);
        private static av_bsf_send_packet_delegate av_bsf_send_packet_fptr = (AVBSFContext* @ctx, AVPacket* @pkt) =>
        {
            av_bsf_send_packet_fptr = GetFunctionDelegate<av_bsf_send_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_bsf_send_packet");
            if (av_bsf_send_packet_fptr == null)
            {
                av_bsf_send_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bsf_send_packet is not supported on this platform.");
                };
            }
            return av_bsf_send_packet_fptr(@ctx, @pkt);
        };
        /// <summary>Submit a packet for filtering.</summary>
        /// <param name="pkt">the packet to filter. The bitstream filter will take ownership of the packet and reset the contents of pkt. pkt is not touched if an error occurs. This parameter may be NULL, which signals the end of the stream (i.e. no more packets will be sent). That will cause the filter to output any packets it may have buffered internally.</param>
        public static int av_bsf_send_packet(AVBSFContext* @ctx, AVPacket* @pkt)
        {
            return av_bsf_send_packet_fptr(@ctx, @pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ushort* av_codec_get_chroma_intra_matrix_delegate(AVCodecContext* @avctx);
        private static av_codec_get_chroma_intra_matrix_delegate av_codec_get_chroma_intra_matrix_fptr = (AVCodecContext* @avctx) =>
        {
            av_codec_get_chroma_intra_matrix_fptr = GetFunctionDelegate<av_codec_get_chroma_intra_matrix_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_chroma_intra_matrix");
            if (av_codec_get_chroma_intra_matrix_fptr == null)
            {
                av_codec_get_chroma_intra_matrix_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_chroma_intra_matrix is not supported on this platform.");
                };
            }
            return av_codec_get_chroma_intra_matrix_fptr(@avctx);
        };
        public static ushort* av_codec_get_chroma_intra_matrix(AVCodecContext* @avctx)
        {
            return av_codec_get_chroma_intra_matrix_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecDescriptor* av_codec_get_codec_descriptor_delegate(AVCodecContext* @avctx);
        private static av_codec_get_codec_descriptor_delegate av_codec_get_codec_descriptor_fptr = (AVCodecContext* @avctx) =>
        {
            av_codec_get_codec_descriptor_fptr = GetFunctionDelegate<av_codec_get_codec_descriptor_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_codec_descriptor");
            if (av_codec_get_codec_descriptor_fptr == null)
            {
                av_codec_get_codec_descriptor_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_codec_descriptor is not supported on this platform.");
                };
            }
            return av_codec_get_codec_descriptor_fptr(@avctx);
        };
        public static AVCodecDescriptor* av_codec_get_codec_descriptor(AVCodecContext* @avctx)
        {
            return av_codec_get_codec_descriptor_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_codec_get_codec_properties_delegate(AVCodecContext* @avctx);
        private static av_codec_get_codec_properties_delegate av_codec_get_codec_properties_fptr = (AVCodecContext* @avctx) =>
        {
            av_codec_get_codec_properties_fptr = GetFunctionDelegate<av_codec_get_codec_properties_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_codec_properties");
            if (av_codec_get_codec_properties_fptr == null)
            {
                av_codec_get_codec_properties_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_codec_properties is not supported on this platform.");
                };
            }
            return av_codec_get_codec_properties_fptr(@avctx);
        };
        public static uint av_codec_get_codec_properties(AVCodecContext* @avctx)
        {
            return av_codec_get_codec_properties_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_codec_get_lowres_delegate(AVCodecContext* @avctx);
        private static av_codec_get_lowres_delegate av_codec_get_lowres_fptr = (AVCodecContext* @avctx) =>
        {
            av_codec_get_lowres_fptr = GetFunctionDelegate<av_codec_get_lowres_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_lowres");
            if (av_codec_get_lowres_fptr == null)
            {
                av_codec_get_lowres_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_lowres is not supported on this platform.");
                };
            }
            return av_codec_get_lowres_fptr(@avctx);
        };
        public static int av_codec_get_lowres(AVCodecContext* @avctx)
        {
            return av_codec_get_lowres_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_codec_get_max_lowres_delegate(AVCodec* @codec);
        private static av_codec_get_max_lowres_delegate av_codec_get_max_lowres_fptr = (AVCodec* @codec) =>
        {
            av_codec_get_max_lowres_fptr = GetFunctionDelegate<av_codec_get_max_lowres_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_max_lowres");
            if (av_codec_get_max_lowres_fptr == null)
            {
                av_codec_get_max_lowres_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_max_lowres is not supported on this platform.");
                };
            }
            return av_codec_get_max_lowres_fptr(@codec);
        };
        public static int av_codec_get_max_lowres(AVCodec* @codec)
        {
            return av_codec_get_max_lowres_fptr(@codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_codec_get_pkt_timebase_delegate(AVCodecContext* @avctx);
        private static av_codec_get_pkt_timebase_delegate av_codec_get_pkt_timebase_fptr = (AVCodecContext* @avctx) =>
        {
            av_codec_get_pkt_timebase_fptr = GetFunctionDelegate<av_codec_get_pkt_timebase_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_pkt_timebase");
            if (av_codec_get_pkt_timebase_fptr == null)
            {
                av_codec_get_pkt_timebase_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_pkt_timebase is not supported on this platform.");
                };
            }
            return av_codec_get_pkt_timebase_fptr(@avctx);
        };
        public static AVRational av_codec_get_pkt_timebase(AVCodecContext* @avctx)
        {
            return av_codec_get_pkt_timebase_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_codec_get_seek_preroll_delegate(AVCodecContext* @avctx);
        private static av_codec_get_seek_preroll_delegate av_codec_get_seek_preroll_fptr = (AVCodecContext* @avctx) =>
        {
            av_codec_get_seek_preroll_fptr = GetFunctionDelegate<av_codec_get_seek_preroll_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_get_seek_preroll");
            if (av_codec_get_seek_preroll_fptr == null)
            {
                av_codec_get_seek_preroll_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_seek_preroll is not supported on this platform.");
                };
            }
            return av_codec_get_seek_preroll_fptr(@avctx);
        };
        public static int av_codec_get_seek_preroll(AVCodecContext* @avctx)
        {
            return av_codec_get_seek_preroll_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_codec_is_decoder_delegate(AVCodec* @codec);
        private static av_codec_is_decoder_delegate av_codec_is_decoder_fptr = (AVCodec* @codec) =>
        {
            av_codec_is_decoder_fptr = GetFunctionDelegate<av_codec_is_decoder_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_is_decoder");
            if (av_codec_is_decoder_fptr == null)
            {
                av_codec_is_decoder_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_is_decoder is not supported on this platform.");
                };
            }
            return av_codec_is_decoder_fptr(@codec);
        };
        /// <summary>Returns a non-zero number if codec is a decoder, zero otherwise</summary>
        public static int av_codec_is_decoder(AVCodec* @codec)
        {
            return av_codec_is_decoder_fptr(@codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_codec_is_encoder_delegate(AVCodec* @codec);
        private static av_codec_is_encoder_delegate av_codec_is_encoder_fptr = (AVCodec* @codec) =>
        {
            av_codec_is_encoder_fptr = GetFunctionDelegate<av_codec_is_encoder_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_is_encoder");
            if (av_codec_is_encoder_fptr == null)
            {
                av_codec_is_encoder_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_is_encoder is not supported on this platform.");
                };
            }
            return av_codec_is_encoder_fptr(@codec);
        };
        /// <summary>Returns a non-zero number if codec is an encoder, zero otherwise</summary>
        public static int av_codec_is_encoder(AVCodec* @codec)
        {
            return av_codec_is_encoder_fptr(@codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* av_codec_next_delegate(AVCodec* @c);
        private static av_codec_next_delegate av_codec_next_fptr = (AVCodec* @c) =>
        {
            av_codec_next_fptr = GetFunctionDelegate<av_codec_next_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_next");
            if (av_codec_next_fptr == null)
            {
                av_codec_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_next is not supported on this platform.");
                };
            }
            return av_codec_next_fptr(@c);
        };
        /// <summary>If c is NULL, returns the first registered codec, if c is non-NULL, returns the next registered codec after c, or NULL if c is the last one.</summary>
        public static AVCodec* av_codec_next(AVCodec* @c)
        {
            return av_codec_next_fptr(@c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_codec_set_chroma_intra_matrix_delegate(AVCodecContext* @avctx, ushort* @val);
        private static av_codec_set_chroma_intra_matrix_delegate av_codec_set_chroma_intra_matrix_fptr = (AVCodecContext* @avctx, ushort* @val) =>
        {
            av_codec_set_chroma_intra_matrix_fptr = GetFunctionDelegate<av_codec_set_chroma_intra_matrix_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_set_chroma_intra_matrix");
            if (av_codec_set_chroma_intra_matrix_fptr == null)
            {
                av_codec_set_chroma_intra_matrix_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_set_chroma_intra_matrix is not supported on this platform.");
                };
            }
            av_codec_set_chroma_intra_matrix_fptr(@avctx, @val);
        };
        public static void av_codec_set_chroma_intra_matrix(AVCodecContext* @avctx, ushort* @val)
        {
            av_codec_set_chroma_intra_matrix_fptr(@avctx, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_codec_set_codec_descriptor_delegate(AVCodecContext* @avctx, AVCodecDescriptor* @desc);
        private static av_codec_set_codec_descriptor_delegate av_codec_set_codec_descriptor_fptr = (AVCodecContext* @avctx, AVCodecDescriptor* @desc) =>
        {
            av_codec_set_codec_descriptor_fptr = GetFunctionDelegate<av_codec_set_codec_descriptor_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_set_codec_descriptor");
            if (av_codec_set_codec_descriptor_fptr == null)
            {
                av_codec_set_codec_descriptor_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_set_codec_descriptor is not supported on this platform.");
                };
            }
            av_codec_set_codec_descriptor_fptr(@avctx, @desc);
        };
        public static void av_codec_set_codec_descriptor(AVCodecContext* @avctx, AVCodecDescriptor* @desc)
        {
            av_codec_set_codec_descriptor_fptr(@avctx, @desc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_codec_set_lowres_delegate(AVCodecContext* @avctx, int @val);
        private static av_codec_set_lowres_delegate av_codec_set_lowres_fptr = (AVCodecContext* @avctx, int @val) =>
        {
            av_codec_set_lowres_fptr = GetFunctionDelegate<av_codec_set_lowres_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_set_lowres");
            if (av_codec_set_lowres_fptr == null)
            {
                av_codec_set_lowres_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_set_lowres is not supported on this platform.");
                };
            }
            av_codec_set_lowres_fptr(@avctx, @val);
        };
        public static void av_codec_set_lowres(AVCodecContext* @avctx, int @val)
        {
            av_codec_set_lowres_fptr(@avctx, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_codec_set_pkt_timebase_delegate(AVCodecContext* @avctx, AVRational @val);
        private static av_codec_set_pkt_timebase_delegate av_codec_set_pkt_timebase_fptr = (AVCodecContext* @avctx, AVRational @val) =>
        {
            av_codec_set_pkt_timebase_fptr = GetFunctionDelegate<av_codec_set_pkt_timebase_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_set_pkt_timebase");
            if (av_codec_set_pkt_timebase_fptr == null)
            {
                av_codec_set_pkt_timebase_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_set_pkt_timebase is not supported on this platform.");
                };
            }
            av_codec_set_pkt_timebase_fptr(@avctx, @val);
        };
        public static void av_codec_set_pkt_timebase(AVCodecContext* @avctx, AVRational @val)
        {
            av_codec_set_pkt_timebase_fptr(@avctx, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_codec_set_seek_preroll_delegate(AVCodecContext* @avctx, int @val);
        private static av_codec_set_seek_preroll_delegate av_codec_set_seek_preroll_fptr = (AVCodecContext* @avctx, int @val) =>
        {
            av_codec_set_seek_preroll_fptr = GetFunctionDelegate<av_codec_set_seek_preroll_delegate>(GetOrLoadLibrary("avcodec", 57), "av_codec_set_seek_preroll");
            if (av_codec_set_seek_preroll_fptr == null)
            {
                av_codec_set_seek_preroll_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_set_seek_preroll is not supported on this platform.");
                };
            }
            av_codec_set_seek_preroll_fptr(@avctx, @val);
        };
        public static void av_codec_set_seek_preroll(AVCodecContext* @avctx, int @val)
        {
            av_codec_set_seek_preroll_fptr(@avctx, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_copy_packet_delegate(AVPacket* @dst, AVPacket* @src);
        private static av_copy_packet_delegate av_copy_packet_fptr = (AVPacket* @dst, AVPacket* @src) =>
        {
            av_copy_packet_fptr = GetFunctionDelegate<av_copy_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_copy_packet");
            if (av_copy_packet_fptr == null)
            {
                av_copy_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_copy_packet is not supported on this platform.");
                };
            }
            return av_copy_packet_fptr(@dst, @src);
        };
        /// <summary>Copy packet, including contents</summary>
        [Obsolete("Use av_packet_ref")]
        public static int av_copy_packet(AVPacket* @dst, AVPacket* @src)
        {
            return av_copy_packet_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_copy_packet_side_data_delegate(AVPacket* @dst, AVPacket* @src);
        private static av_copy_packet_side_data_delegate av_copy_packet_side_data_fptr = (AVPacket* @dst, AVPacket* @src) =>
        {
            av_copy_packet_side_data_fptr = GetFunctionDelegate<av_copy_packet_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_copy_packet_side_data");
            if (av_copy_packet_side_data_fptr == null)
            {
                av_copy_packet_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_copy_packet_side_data is not supported on this platform.");
                };
            }
            return av_copy_packet_side_data_fptr(@dst, @src);
        };
        /// <summary>Copy packet side data</summary>
        [Obsolete("Use av_packet_copy_props")]
        public static int av_copy_packet_side_data(AVPacket* @dst, AVPacket* @src)
        {
            return av_copy_packet_side_data_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCPBProperties* av_cpb_properties_alloc_delegate(ulong* @size);
        private static av_cpb_properties_alloc_delegate av_cpb_properties_alloc_fptr = (ulong* @size) =>
        {
            av_cpb_properties_alloc_fptr = GetFunctionDelegate<av_cpb_properties_alloc_delegate>(GetOrLoadLibrary("avcodec", 57), "av_cpb_properties_alloc");
            if (av_cpb_properties_alloc_fptr == null)
            {
                av_cpb_properties_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_cpb_properties_alloc is not supported on this platform.");
                };
            }
            return av_cpb_properties_alloc_fptr(@size);
        };
        /// <summary>Allocate a CPB properties structure and initialize its fields to default values.</summary>
        /// <param name="size">if non-NULL, the size of the allocated struct will be written here. This is useful for embedding it in side data.</param>
        public static AVCPBProperties* av_cpb_properties_alloc(ulong* @size)
        {
            return av_cpb_properties_alloc_fptr(@size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVD3D11VAContext* av_d3d11va_alloc_context_delegate();
        private static av_d3d11va_alloc_context_delegate av_d3d11va_alloc_context_fptr = () =>
        {
            av_d3d11va_alloc_context_fptr = GetFunctionDelegate<av_d3d11va_alloc_context_delegate>(GetOrLoadLibrary("avcodec", 57), "av_d3d11va_alloc_context");
            if (av_d3d11va_alloc_context_fptr == null)
            {
                av_d3d11va_alloc_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_d3d11va_alloc_context is not supported on this platform.");
                };
            }
            return av_d3d11va_alloc_context_fptr();
        };
        /// <summary>Allocate an AVD3D11VAContext.</summary>
        public static AVD3D11VAContext* av_d3d11va_alloc_context()
        {
            return av_d3d11va_alloc_context_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dup_packet_delegate(AVPacket* @pkt);
        private static av_dup_packet_delegate av_dup_packet_fptr = (AVPacket* @pkt) =>
        {
            av_dup_packet_fptr = GetFunctionDelegate<av_dup_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_dup_packet");
            if (av_dup_packet_fptr == null)
            {
                av_dup_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dup_packet is not supported on this platform.");
                };
            }
            return av_dup_packet_fptr(@pkt);
        };
        [Obsolete("Use av_packet_ref")]
        public static int av_dup_packet(AVPacket* @pkt)
        {
            return av_dup_packet_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fast_padded_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);
        private static av_fast_padded_malloc_delegate av_fast_padded_malloc_fptr = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            av_fast_padded_malloc_fptr = GetFunctionDelegate<av_fast_padded_malloc_delegate>(GetOrLoadLibrary("avcodec", 57), "av_fast_padded_malloc");
            if (av_fast_padded_malloc_fptr == null)
            {
                av_fast_padded_malloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fast_padded_malloc is not supported on this platform.");
                };
            }
            av_fast_padded_malloc_fptr(@ptr, @size, @min_size);
        };
        /// <summary>Same behaviour av_fast_malloc but the buffer has additional AV_INPUT_BUFFER_PADDING_SIZE at the end which will always be 0.</summary>
        public static void av_fast_padded_malloc(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_padded_malloc_fptr(@ptr, @size, @min_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fast_padded_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);
        private static av_fast_padded_mallocz_delegate av_fast_padded_mallocz_fptr = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            av_fast_padded_mallocz_fptr = GetFunctionDelegate<av_fast_padded_mallocz_delegate>(GetOrLoadLibrary("avcodec", 57), "av_fast_padded_mallocz");
            if (av_fast_padded_mallocz_fptr == null)
            {
                av_fast_padded_mallocz_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fast_padded_mallocz is not supported on this platform.");
                };
            }
            av_fast_padded_mallocz_fptr(@ptr, @size, @min_size);
        };
        /// <summary>Same behaviour av_fast_padded_malloc except that buffer will always be 0-initialized after call.</summary>
        public static void av_fast_padded_mallocz(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_padded_mallocz_fptr(@ptr, @size, @min_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_free_packet_delegate(AVPacket* @pkt);
        private static av_free_packet_delegate av_free_packet_fptr = (AVPacket* @pkt) =>
        {
            av_free_packet_fptr = GetFunctionDelegate<av_free_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_free_packet");
            if (av_free_packet_fptr == null)
            {
                av_free_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_free_packet is not supported on this platform.");
                };
            }
            av_free_packet_fptr(@pkt);
        };
        /// <summary>Free a packet.</summary>
        /// <param name="pkt">packet to free</param>
        [Obsolete("Use av_packet_unref")]
        public static void av_free_packet(AVPacket* @pkt)
        {
            av_free_packet_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_audio_frame_duration_delegate(AVCodecContext* @avctx, int @frame_bytes);
        private static av_get_audio_frame_duration_delegate av_get_audio_frame_duration_fptr = (AVCodecContext* @avctx, int @frame_bytes) =>
        {
            av_get_audio_frame_duration_fptr = GetFunctionDelegate<av_get_audio_frame_duration_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_audio_frame_duration");
            if (av_get_audio_frame_duration_fptr == null)
            {
                av_get_audio_frame_duration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_audio_frame_duration is not supported on this platform.");
                };
            }
            return av_get_audio_frame_duration_fptr(@avctx, @frame_bytes);
        };
        /// <summary>Return audio frame duration.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame_bytes">size of the frame, or 0 if unknown</param>
        public static int av_get_audio_frame_duration(AVCodecContext* @avctx, int @frame_bytes)
        {
            return av_get_audio_frame_duration_fptr(@avctx, @frame_bytes);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_audio_frame_duration2_delegate(AVCodecParameters* @par, int @frame_bytes);
        private static av_get_audio_frame_duration2_delegate av_get_audio_frame_duration2_fptr = (AVCodecParameters* @par, int @frame_bytes) =>
        {
            av_get_audio_frame_duration2_fptr = GetFunctionDelegate<av_get_audio_frame_duration2_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_audio_frame_duration2");
            if (av_get_audio_frame_duration2_fptr == null)
            {
                av_get_audio_frame_duration2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_audio_frame_duration2 is not supported on this platform.");
                };
            }
            return av_get_audio_frame_duration2_fptr(@par, @frame_bytes);
        };
        /// <summary>This function is the same as av_get_audio_frame_duration(), except it works with AVCodecParameters instead of an AVCodecContext.</summary>
        public static int av_get_audio_frame_duration2(AVCodecParameters* @par, int @frame_bytes)
        {
            return av_get_audio_frame_duration2_fptr(@par, @frame_bytes);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_bits_per_sample_delegate(AVCodecID @codec_id);
        private static av_get_bits_per_sample_delegate av_get_bits_per_sample_fptr = (AVCodecID @codec_id) =>
        {
            av_get_bits_per_sample_fptr = GetFunctionDelegate<av_get_bits_per_sample_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_bits_per_sample");
            if (av_get_bits_per_sample_fptr == null)
            {
                av_get_bits_per_sample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_bits_per_sample is not supported on this platform.");
                };
            }
            return av_get_bits_per_sample_fptr(@codec_id);
        };
        /// <summary>Return codec bits per sample.</summary>
        /// <param name="codec_id">the codec</param>
        public static int av_get_bits_per_sample(AVCodecID @codec_id)
        {
            return av_get_bits_per_sample_fptr(@codec_id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong av_get_codec_tag_string_delegate(byte* @buf, ulong @buf_size, uint @codec_tag);
        private static av_get_codec_tag_string_delegate av_get_codec_tag_string_fptr = (byte* @buf, ulong @buf_size, uint @codec_tag) =>
        {
            av_get_codec_tag_string_fptr = GetFunctionDelegate<av_get_codec_tag_string_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_codec_tag_string");
            if (av_get_codec_tag_string_fptr == null)
            {
                av_get_codec_tag_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_codec_tag_string is not supported on this platform.");
                };
            }
            return av_get_codec_tag_string_fptr(@buf, @buf_size, @codec_tag);
        };
        /// <summary>Put a string representing the codec tag codec_tag in buf.</summary>
        /// <param name="buf">buffer to place codec tag in</param>
        /// <param name="buf_size">size in bytes of buf</param>
        /// <param name="codec_tag">codec tag to assign</param>
        [Obsolete("see av_fourcc_make_string() and av_fourcc2str().")]
        public static ulong av_get_codec_tag_string(byte* @buf, ulong @buf_size, uint @codec_tag)
        {
            return av_get_codec_tag_string_fptr(@buf, @buf_size, @codec_tag);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_exact_bits_per_sample_delegate(AVCodecID @codec_id);
        private static av_get_exact_bits_per_sample_delegate av_get_exact_bits_per_sample_fptr = (AVCodecID @codec_id) =>
        {
            av_get_exact_bits_per_sample_fptr = GetFunctionDelegate<av_get_exact_bits_per_sample_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_exact_bits_per_sample");
            if (av_get_exact_bits_per_sample_fptr == null)
            {
                av_get_exact_bits_per_sample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_exact_bits_per_sample is not supported on this platform.");
                };
            }
            return av_get_exact_bits_per_sample_fptr(@codec_id);
        };
        /// <summary>Return codec bits per sample. Only return non-zero if the bits per sample is exactly correct, not an approximation.</summary>
        /// <param name="codec_id">the codec</param>
        public static int av_get_exact_bits_per_sample(AVCodecID @codec_id)
        {
            return av_get_exact_bits_per_sample_fptr(@codec_id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecID av_get_pcm_codec_delegate(AVSampleFormat @fmt, int @be);
        private static av_get_pcm_codec_delegate av_get_pcm_codec_fptr = (AVSampleFormat @fmt, int @be) =>
        {
            av_get_pcm_codec_fptr = GetFunctionDelegate<av_get_pcm_codec_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_pcm_codec");
            if (av_get_pcm_codec_fptr == null)
            {
                av_get_pcm_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_pcm_codec is not supported on this platform.");
                };
            }
            return av_get_pcm_codec_fptr(@fmt, @be);
        };
        /// <summary>Return the PCM codec associated with a sample format.</summary>
        /// <param name="be">endianness, 0 for little, 1 for big, -1 (or anything else) for native</param>
        public static AVCodecID av_get_pcm_codec(AVSampleFormat @fmt, int @be)
        {
            return av_get_pcm_codec_fptr(@fmt, @be);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_profile_name_delegate(AVCodec* @codec, int @profile);
        private static av_get_profile_name_delegate av_get_profile_name_fptr = (AVCodec* @codec, int @profile) =>
        {
            av_get_profile_name_fptr = GetFunctionDelegate<av_get_profile_name_delegate>(GetOrLoadLibrary("avcodec", 57), "av_get_profile_name");
            if (av_get_profile_name_fptr == null)
            {
                av_get_profile_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_profile_name is not supported on this platform.");
                };
            }
            return av_get_profile_name_fptr(@codec, @profile);
        };
        /// <summary>Return a name for the specified profile, if available.</summary>
        /// <param name="codec">the codec that is searched for the given profile</param>
        /// <param name="profile">the profile value for which a name is requested</param>
        public static string av_get_profile_name(AVCodec* @codec, int @profile)
        {
            return av_get_profile_name_fptr(@codec, @profile);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_grow_packet_delegate(AVPacket* @pkt, int @grow_by);
        private static av_grow_packet_delegate av_grow_packet_fptr = (AVPacket* @pkt, int @grow_by) =>
        {
            av_grow_packet_fptr = GetFunctionDelegate<av_grow_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_grow_packet");
            if (av_grow_packet_fptr == null)
            {
                av_grow_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_grow_packet is not supported on this platform.");
                };
            }
            return av_grow_packet_fptr(@pkt, @grow_by);
        };
        /// <summary>Increase packet size, correctly zeroing padding</summary>
        /// <param name="pkt">packet</param>
        /// <param name="grow_by">number of bytes by which to increase the size of the packet</param>
        public static int av_grow_packet(AVPacket* @pkt, int @grow_by)
        {
            return av_grow_packet_fptr(@pkt, @grow_by);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVHWAccel* av_hwaccel_next_delegate(AVHWAccel* @hwaccel);
        private static av_hwaccel_next_delegate av_hwaccel_next_fptr = (AVHWAccel* @hwaccel) =>
        {
            av_hwaccel_next_fptr = GetFunctionDelegate<av_hwaccel_next_delegate>(GetOrLoadLibrary("avcodec", 57), "av_hwaccel_next");
            if (av_hwaccel_next_fptr == null)
            {
                av_hwaccel_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwaccel_next is not supported on this platform.");
                };
            }
            return av_hwaccel_next_fptr(@hwaccel);
        };
        /// <summary>If hwaccel is NULL, returns the first registered hardware accelerator, if hwaccel is non-NULL, returns the next registered hardware accelerator after hwaccel, or NULL if hwaccel is the last one.</summary>
        public static AVHWAccel* av_hwaccel_next(AVHWAccel* @hwaccel)
        {
            return av_hwaccel_next_fptr(@hwaccel);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_init_packet_delegate(AVPacket* @pkt);
        private static av_init_packet_delegate av_init_packet_fptr = (AVPacket* @pkt) =>
        {
            av_init_packet_fptr = GetFunctionDelegate<av_init_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_init_packet");
            if (av_init_packet_fptr == null)
            {
                av_init_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_init_packet is not supported on this platform.");
                };
            }
            av_init_packet_fptr(@pkt);
        };
        /// <summary>Initialize optional fields of a packet with default values.</summary>
        /// <param name="pkt">packet</param>
        public static void av_init_packet(AVPacket* @pkt)
        {
            av_init_packet_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_lockmgr_register_delegate(av_lockmgr_register_cb_func @cb);
        private static av_lockmgr_register_delegate av_lockmgr_register_fptr = (av_lockmgr_register_cb_func @cb) =>
        {
            av_lockmgr_register_fptr = GetFunctionDelegate<av_lockmgr_register_delegate>(GetOrLoadLibrary("avcodec", 57), "av_lockmgr_register");
            if (av_lockmgr_register_fptr == null)
            {
                av_lockmgr_register_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_lockmgr_register is not supported on this platform.");
                };
            }
            return av_lockmgr_register_fptr(@cb);
        };
        /// <summary>Register a user provided lock manager supporting the operations specified by AVLockOp. The &quot;mutex&quot; argument to the function points to a (void *) where the lockmgr should store/get a pointer to a user allocated mutex. It is NULL upon AV_LOCK_CREATE and equal to the value left by the last call for all other ops. If the lock manager is unable to perform the op then it should leave the mutex in the same state as when it was called and return a non-zero value. However, when called with AV_LOCK_DESTROY the mutex will always be assumed to have been successfully destroyed. If av_lockmgr_register succeeds it will return a non-negative value, if it fails it will return a negative value and destroy all mutex and unregister all callbacks. av_lockmgr_register is not thread-safe, it must be called from a single thread before any calls which make use of locking are used.</summary>
        /// <param name="cb">User defined callback. av_lockmgr_register invokes calls to this callback and the previously registered callback. The callback will be used to create more than one mutex each of which must be backed by its own underlying locking mechanism (i.e. do not use a single static object to implement your lock manager). If cb is set to NULL the lockmgr will be unregistered.</param>
        public static int av_lockmgr_register(av_lockmgr_register_cb_func @cb)
        {
            return av_lockmgr_register_fptr(@cb);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_ask_for_sample_delegate(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @msg);
        private static av_log_ask_for_sample_delegate av_log_ask_for_sample_fptr = (void* @avc, string @msg) =>
        {
            av_log_ask_for_sample_fptr = GetFunctionDelegate<av_log_ask_for_sample_delegate>(GetOrLoadLibrary("avcodec", 57), "av_log_ask_for_sample");
            if (av_log_ask_for_sample_fptr == null)
            {
                av_log_ask_for_sample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_ask_for_sample is not supported on this platform.");
                };
            }
            av_log_ask_for_sample_fptr(@avc, @msg);
        };
        /// <summary>Log a generic warning message asking for a sample. This function is intended to be used internally by FFmpeg (libavcodec, libavformat, etc.) only, and would normally not be used by applications.</summary>
        /// <param name="avc">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct</param>
        /// <param name="msg">string containing an optional message, or NULL if no message</param>
        [Obsolete("Use avpriv_request_sample() instead.")]
        public static void av_log_ask_for_sample(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @msg)
        {
            av_log_ask_for_sample_fptr(@avc, @msg);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_missing_feature_delegate(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @feature, int @want_sample);
        private static av_log_missing_feature_delegate av_log_missing_feature_fptr = (void* @avc, string @feature, int @want_sample) =>
        {
            av_log_missing_feature_fptr = GetFunctionDelegate<av_log_missing_feature_delegate>(GetOrLoadLibrary("avcodec", 57), "av_log_missing_feature");
            if (av_log_missing_feature_fptr == null)
            {
                av_log_missing_feature_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_missing_feature is not supported on this platform.");
                };
            }
            av_log_missing_feature_fptr(@avc, @feature, @want_sample);
        };
        /// <summary>Log a generic warning message about a missing feature. This function is intended to be used internally by FFmpeg (libavcodec, libavformat, etc.) only, and would normally not be used by applications.</summary>
        /// <param name="avc">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct</param>
        /// <param name="feature">string containing the name of the missing feature</param>
        /// <param name="want_sample">indicates if samples are wanted which exhibit this feature. If want_sample is non-zero, additional verbiage will be added to the log message which tells the user how to report samples to the development mailing list.</param>
        [Obsolete("Use avpriv_report_missing_feature() instead.")]
        public static void av_log_missing_feature(void* @avc, [MarshalAs(UnmanagedType.LPStr)] string @feature, int @want_sample)
        {
            av_log_missing_feature_fptr(@avc, @feature, @want_sample);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_new_packet_delegate(AVPacket* @pkt, int @size);
        private static av_new_packet_delegate av_new_packet_fptr = (AVPacket* @pkt, int @size) =>
        {
            av_new_packet_fptr = GetFunctionDelegate<av_new_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_new_packet");
            if (av_new_packet_fptr == null)
            {
                av_new_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_new_packet is not supported on this platform.");
                };
            }
            return av_new_packet_fptr(@pkt, @size);
        };
        /// <summary>Allocate the payload of a packet and initialize its fields with default values.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="size">wanted payload size</param>
        public static int av_new_packet(AVPacket* @pkt, int @size)
        {
            return av_new_packet_fptr(@pkt, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_add_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size);
        private static av_packet_add_side_data_delegate av_packet_add_side_data_fptr = (AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size) =>
        {
            av_packet_add_side_data_fptr = GetFunctionDelegate<av_packet_add_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_add_side_data");
            if (av_packet_add_side_data_fptr == null)
            {
                av_packet_add_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_add_side_data is not supported on this platform.");
                };
            }
            return av_packet_add_side_data_fptr(@pkt, @type, @data, @size);
        };
        /// <summary>Wrap an existing array as a packet side data.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to pkt.</param>
        /// <param name="size">side information size</param>
        public static int av_packet_add_side_data(AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size)
        {
            return av_packet_add_side_data_fptr(@pkt, @type, @data, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPacket* av_packet_alloc_delegate();
        private static av_packet_alloc_delegate av_packet_alloc_fptr = () =>
        {
            av_packet_alloc_fptr = GetFunctionDelegate<av_packet_alloc_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_alloc");
            if (av_packet_alloc_fptr == null)
            {
                av_packet_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_alloc is not supported on this platform.");
                };
            }
            return av_packet_alloc_fptr();
        };
        /// <summary>Allocate an AVPacket and set its fields to default values. The resulting struct must be freed using av_packet_free().</summary>
        public static AVPacket* av_packet_alloc()
        {
            return av_packet_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPacket* av_packet_clone_delegate(AVPacket* @src);
        private static av_packet_clone_delegate av_packet_clone_fptr = (AVPacket* @src) =>
        {
            av_packet_clone_fptr = GetFunctionDelegate<av_packet_clone_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_clone");
            if (av_packet_clone_fptr == null)
            {
                av_packet_clone_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_clone is not supported on this platform.");
                };
            }
            return av_packet_clone_fptr(@src);
        };
        /// <summary>Create a new packet that references the same data as src.</summary>
        public static AVPacket* av_packet_clone(AVPacket* @src)
        {
            return av_packet_clone_fptr(@src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_copy_props_delegate(AVPacket* @dst, AVPacket* @src);
        private static av_packet_copy_props_delegate av_packet_copy_props_fptr = (AVPacket* @dst, AVPacket* @src) =>
        {
            av_packet_copy_props_fptr = GetFunctionDelegate<av_packet_copy_props_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_copy_props");
            if (av_packet_copy_props_fptr == null)
            {
                av_packet_copy_props_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_copy_props is not supported on this platform.");
                };
            }
            return av_packet_copy_props_fptr(@dst, @src);
        };
        /// <summary>Copy only &quot;properties&quot; fields from src to dst.</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet</param>
        public static int av_packet_copy_props(AVPacket* @dst, AVPacket* @src)
        {
            return av_packet_copy_props_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_packet_free_delegate(AVPacket** @pkt);
        private static av_packet_free_delegate av_packet_free_fptr = (AVPacket** @pkt) =>
        {
            av_packet_free_fptr = GetFunctionDelegate<av_packet_free_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_free");
            if (av_packet_free_fptr == null)
            {
                av_packet_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_free is not supported on this platform.");
                };
            }
            av_packet_free_fptr(@pkt);
        };
        /// <summary>Free the packet, if the packet is reference counted, it will be unreferenced first.</summary>
        /// <param name="pkt">packet to be freed. The pointer will be set to NULL.</param>
        public static void av_packet_free(AVPacket** @pkt)
        {
            av_packet_free_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_packet_free_side_data_delegate(AVPacket* @pkt);
        private static av_packet_free_side_data_delegate av_packet_free_side_data_fptr = (AVPacket* @pkt) =>
        {
            av_packet_free_side_data_fptr = GetFunctionDelegate<av_packet_free_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_free_side_data");
            if (av_packet_free_side_data_fptr == null)
            {
                av_packet_free_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_free_side_data is not supported on this platform.");
                };
            }
            av_packet_free_side_data_fptr(@pkt);
        };
        /// <summary>Convenience function to free all the side data stored. All the other fields stay untouched.</summary>
        /// <param name="pkt">packet</param>
        public static void av_packet_free_side_data(AVPacket* @pkt)
        {
            av_packet_free_side_data_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_from_data_delegate(AVPacket* @pkt, byte* @data, int @size);
        private static av_packet_from_data_delegate av_packet_from_data_fptr = (AVPacket* @pkt, byte* @data, int @size) =>
        {
            av_packet_from_data_fptr = GetFunctionDelegate<av_packet_from_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_from_data");
            if (av_packet_from_data_fptr == null)
            {
                av_packet_from_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_from_data is not supported on this platform.");
                };
            }
            return av_packet_from_data_fptr(@pkt, @data, @size);
        };
        /// <summary>Initialize a reference-counted packet from av_malloc()ed data.</summary>
        /// <param name="pkt">packet to be initialized. This function will set the data, size, buf and destruct fields, all others are left untouched.</param>
        /// <param name="data">Data allocated by av_malloc() to be used as packet data. If this function returns successfully, the data is owned by the underlying AVBuffer. The caller may not access the data through other means.</param>
        /// <param name="size">size of data in bytes, without the padding. I.e. the full buffer size is assumed to be size + AV_INPUT_BUFFER_PADDING_SIZE.</param>
        public static int av_packet_from_data(AVPacket* @pkt, byte* @data, int @size)
        {
            return av_packet_from_data_fptr(@pkt, @data, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_packet_get_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, int* @size);
        private static av_packet_get_side_data_delegate av_packet_get_side_data_fptr = (AVPacket* @pkt, AVPacketSideDataType @type, int* @size) =>
        {
            av_packet_get_side_data_fptr = GetFunctionDelegate<av_packet_get_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_get_side_data");
            if (av_packet_get_side_data_fptr == null)
            {
                av_packet_get_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_get_side_data is not supported on this platform.");
                };
            }
            return av_packet_get_side_data_fptr(@pkt, @type, @size);
        };
        /// <summary>Get side information from packet.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">pointer for side information size to store (optional)</param>
        public static byte* av_packet_get_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int* @size)
        {
            return av_packet_get_side_data_fptr(@pkt, @type, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_merge_side_data_delegate(AVPacket* @pkt);
        private static av_packet_merge_side_data_delegate av_packet_merge_side_data_fptr = (AVPacket* @pkt) =>
        {
            av_packet_merge_side_data_fptr = GetFunctionDelegate<av_packet_merge_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_merge_side_data");
            if (av_packet_merge_side_data_fptr == null)
            {
                av_packet_merge_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_merge_side_data is not supported on this platform.");
                };
            }
            return av_packet_merge_side_data_fptr(@pkt);
        };
        [Obsolete("")]
        public static int av_packet_merge_side_data(AVPacket* @pkt)
        {
            return av_packet_merge_side_data_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_packet_move_ref_delegate(AVPacket* @dst, AVPacket* @src);
        private static av_packet_move_ref_delegate av_packet_move_ref_fptr = (AVPacket* @dst, AVPacket* @src) =>
        {
            av_packet_move_ref_fptr = GetFunctionDelegate<av_packet_move_ref_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_move_ref");
            if (av_packet_move_ref_fptr == null)
            {
                av_packet_move_ref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_move_ref is not supported on this platform.");
                };
            }
            av_packet_move_ref_fptr(@dst, @src);
        };
        /// <summary>Move every field in src to dst and reset src.</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet, will be reset</param>
        public static void av_packet_move_ref(AVPacket* @dst, AVPacket* @src)
        {
            av_packet_move_ref_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_packet_new_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        private static av_packet_new_side_data_delegate av_packet_new_side_data_fptr = (AVPacket* @pkt, AVPacketSideDataType @type, int @size) =>
        {
            av_packet_new_side_data_fptr = GetFunctionDelegate<av_packet_new_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_new_side_data");
            if (av_packet_new_side_data_fptr == null)
            {
                av_packet_new_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_new_side_data is not supported on this platform.");
                };
            }
            return av_packet_new_side_data_fptr(@pkt, @type, @size);
        };
        /// <summary>Allocate new information of a packet.</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="size">side information size</param>
        public static byte* av_packet_new_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size)
        {
            return av_packet_new_side_data_fptr(@pkt, @type, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_packet_pack_dictionary_delegate(AVDictionary* @dict, int* @size);
        private static av_packet_pack_dictionary_delegate av_packet_pack_dictionary_fptr = (AVDictionary* @dict, int* @size) =>
        {
            av_packet_pack_dictionary_fptr = GetFunctionDelegate<av_packet_pack_dictionary_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_pack_dictionary");
            if (av_packet_pack_dictionary_fptr == null)
            {
                av_packet_pack_dictionary_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_pack_dictionary is not supported on this platform.");
                };
            }
            return av_packet_pack_dictionary_fptr(@dict, @size);
        };
        /// <summary>Pack a dictionary for use in side_data.</summary>
        /// <param name="dict">The dictionary to pack.</param>
        /// <param name="size">pointer to store the size of the returned data</param>
        public static byte* av_packet_pack_dictionary(AVDictionary* @dict, int* @size)
        {
            return av_packet_pack_dictionary_fptr(@dict, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_ref_delegate(AVPacket* @dst, AVPacket* @src);
        private static av_packet_ref_delegate av_packet_ref_fptr = (AVPacket* @dst, AVPacket* @src) =>
        {
            av_packet_ref_fptr = GetFunctionDelegate<av_packet_ref_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_ref");
            if (av_packet_ref_fptr == null)
            {
                av_packet_ref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_ref is not supported on this platform.");
                };
            }
            return av_packet_ref_fptr(@dst, @src);
        };
        /// <summary>Setup a new reference to the data described by a given packet</summary>
        /// <param name="dst">Destination packet</param>
        /// <param name="src">Source packet</param>
        public static int av_packet_ref(AVPacket* @dst, AVPacket* @src)
        {
            return av_packet_ref_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_packet_rescale_ts_delegate(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst);
        private static av_packet_rescale_ts_delegate av_packet_rescale_ts_fptr = (AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst) =>
        {
            av_packet_rescale_ts_fptr = GetFunctionDelegate<av_packet_rescale_ts_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_rescale_ts");
            if (av_packet_rescale_ts_fptr == null)
            {
                av_packet_rescale_ts_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_rescale_ts is not supported on this platform.");
                };
            }
            av_packet_rescale_ts_fptr(@pkt, @tb_src, @tb_dst);
        };
        /// <summary>Convert valid timing fields (timestamps / durations) in a packet from one timebase to another. Timestamps with unknown values (AV_NOPTS_VALUE) will be ignored.</summary>
        /// <param name="pkt">packet on which the conversion will be performed</param>
        /// <param name="tb_src">source timebase, in which the timing fields in pkt are expressed</param>
        /// <param name="tb_dst">destination timebase, to which the timing fields will be converted</param>
        public static void av_packet_rescale_ts(AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst)
        {
            av_packet_rescale_ts_fptr(@pkt, @tb_src, @tb_dst);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_shrink_side_data_delegate(AVPacket* @pkt, AVPacketSideDataType @type, int @size);
        private static av_packet_shrink_side_data_delegate av_packet_shrink_side_data_fptr = (AVPacket* @pkt, AVPacketSideDataType @type, int @size) =>
        {
            av_packet_shrink_side_data_fptr = GetFunctionDelegate<av_packet_shrink_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_shrink_side_data");
            if (av_packet_shrink_side_data_fptr == null)
            {
                av_packet_shrink_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_shrink_side_data is not supported on this platform.");
                };
            }
            return av_packet_shrink_side_data_fptr(@pkt, @type, @size);
        };
        /// <summary>Shrink the already allocated side data buffer</summary>
        /// <param name="pkt">packet</param>
        /// <param name="type">side information type</param>
        /// <param name="size">new side information size</param>
        public static int av_packet_shrink_side_data(AVPacket* @pkt, AVPacketSideDataType @type, int @size)
        {
            return av_packet_shrink_side_data_fptr(@pkt, @type, @size);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_packet_side_data_name_delegate(AVPacketSideDataType @type);
        private static av_packet_side_data_name_delegate av_packet_side_data_name_fptr = (AVPacketSideDataType @type) =>
        {
            av_packet_side_data_name_fptr = GetFunctionDelegate<av_packet_side_data_name_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_side_data_name");
            if (av_packet_side_data_name_fptr == null)
            {
                av_packet_side_data_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_side_data_name is not supported on this platform.");
                };
            }
            return av_packet_side_data_name_fptr(@type);
        };
        public static string av_packet_side_data_name(AVPacketSideDataType @type)
        {
            return av_packet_side_data_name_fptr(@type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_split_side_data_delegate(AVPacket* @pkt);
        private static av_packet_split_side_data_delegate av_packet_split_side_data_fptr = (AVPacket* @pkt) =>
        {
            av_packet_split_side_data_fptr = GetFunctionDelegate<av_packet_split_side_data_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_split_side_data");
            if (av_packet_split_side_data_fptr == null)
            {
                av_packet_split_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_split_side_data is not supported on this platform.");
                };
            }
            return av_packet_split_side_data_fptr(@pkt);
        };
        [Obsolete("")]
        public static int av_packet_split_side_data(AVPacket* @pkt)
        {
            return av_packet_split_side_data_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_packet_unpack_dictionary_delegate(byte* @data, int @size, AVDictionary** @dict);
        private static av_packet_unpack_dictionary_delegate av_packet_unpack_dictionary_fptr = (byte* @data, int @size, AVDictionary** @dict) =>
        {
            av_packet_unpack_dictionary_fptr = GetFunctionDelegate<av_packet_unpack_dictionary_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_unpack_dictionary");
            if (av_packet_unpack_dictionary_fptr == null)
            {
                av_packet_unpack_dictionary_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_unpack_dictionary is not supported on this platform.");
                };
            }
            return av_packet_unpack_dictionary_fptr(@data, @size, @dict);
        };
        /// <summary>Unpack a dictionary from side_data.</summary>
        /// <param name="data">data from side_data</param>
        /// <param name="size">size of the data</param>
        /// <param name="dict">the metadata storage dictionary</param>
        public static int av_packet_unpack_dictionary(byte* @data, int @size, AVDictionary** @dict)
        {
            return av_packet_unpack_dictionary_fptr(@data, @size, @dict);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_packet_unref_delegate(AVPacket* @pkt);
        private static av_packet_unref_delegate av_packet_unref_fptr = (AVPacket* @pkt) =>
        {
            av_packet_unref_fptr = GetFunctionDelegate<av_packet_unref_delegate>(GetOrLoadLibrary("avcodec", 57), "av_packet_unref");
            if (av_packet_unref_fptr == null)
            {
                av_packet_unref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_packet_unref is not supported on this platform.");
                };
            }
            av_packet_unref_fptr(@pkt);
        };
        /// <summary>Wipe the packet.</summary>
        /// <param name="pkt">The packet to be unreferenced.</param>
        public static void av_packet_unref(AVPacket* @pkt)
        {
            av_packet_unref_fptr(@pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_parser_change_delegate(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe);
        private static av_parser_change_delegate av_parser_change_fptr = (AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe) =>
        {
            av_parser_change_fptr = GetFunctionDelegate<av_parser_change_delegate>(GetOrLoadLibrary("avcodec", 57), "av_parser_change");
            if (av_parser_change_fptr == null)
            {
                av_parser_change_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parser_change is not supported on this platform.");
                };
            }
            return av_parser_change_fptr(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @keyframe);
        };
        /// <summary>Returns 0 if the output buffer is a subset of the input, 1 if it is allocated and must be freed use AVBitStreamFilter</summary>
        public static int av_parser_change(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, int @keyframe)
        {
            return av_parser_change_fptr(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @keyframe);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_parser_close_delegate(AVCodecParserContext* @s);
        private static av_parser_close_delegate av_parser_close_fptr = (AVCodecParserContext* @s) =>
        {
            av_parser_close_fptr = GetFunctionDelegate<av_parser_close_delegate>(GetOrLoadLibrary("avcodec", 57), "av_parser_close");
            if (av_parser_close_fptr == null)
            {
                av_parser_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parser_close is not supported on this platform.");
                };
            }
            av_parser_close_fptr(@s);
        };
        public static void av_parser_close(AVCodecParserContext* @s)
        {
            av_parser_close_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecParserContext* av_parser_init_delegate(int @codec_id);
        private static av_parser_init_delegate av_parser_init_fptr = (int @codec_id) =>
        {
            av_parser_init_fptr = GetFunctionDelegate<av_parser_init_delegate>(GetOrLoadLibrary("avcodec", 57), "av_parser_init");
            if (av_parser_init_fptr == null)
            {
                av_parser_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parser_init is not supported on this platform.");
                };
            }
            return av_parser_init_fptr(@codec_id);
        };
        public static AVCodecParserContext* av_parser_init(int @codec_id)
        {
            return av_parser_init_fptr(@codec_id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecParser* av_parser_next_delegate(AVCodecParser* @c);
        private static av_parser_next_delegate av_parser_next_fptr = (AVCodecParser* @c) =>
        {
            av_parser_next_fptr = GetFunctionDelegate<av_parser_next_delegate>(GetOrLoadLibrary("avcodec", 57), "av_parser_next");
            if (av_parser_next_fptr == null)
            {
                av_parser_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parser_next is not supported on this platform.");
                };
            }
            return av_parser_next_fptr(@c);
        };
        public static AVCodecParser* av_parser_next(AVCodecParser* @c)
        {
            return av_parser_next_fptr(@c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_parser_parse2_delegate(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos);
        private static av_parser_parse2_delegate av_parser_parse2_fptr = (AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos) =>
        {
            av_parser_parse2_fptr = GetFunctionDelegate<av_parser_parse2_delegate>(GetOrLoadLibrary("avcodec", 57), "av_parser_parse2");
            if (av_parser_parse2_fptr == null)
            {
                av_parser_parse2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parser_parse2 is not supported on this platform.");
                };
            }
            return av_parser_parse2_fptr(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
        };
        /// <summary>Parse a packet.</summary>
        /// <param name="s">parser context.</param>
        /// <param name="avctx">codec context.</param>
        /// <param name="poutbuf">set to pointer to parsed buffer or NULL if not yet finished.</param>
        /// <param name="poutbuf_size">set to size of parsed buffer or zero if not yet finished.</param>
        /// <param name="buf">input buffer.</param>
        /// <param name="buf_size">buffer size in bytes without the padding. I.e. the full buffer size is assumed to be buf_size + AV_INPUT_BUFFER_PADDING_SIZE. To signal EOF, this should be 0 (so that the last frame can be output).</param>
        /// <param name="pts">input presentation timestamp.</param>
        /// <param name="dts">input decoding timestamp.</param>
        /// <param name="pos">input byte position in stream.</param>
        public static int av_parser_parse2(AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos)
        {
            return av_parser_parse2_fptr(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_picture_copy_delegate(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height);
        private static av_picture_copy_delegate av_picture_copy_fptr = (AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            av_picture_copy_fptr = GetFunctionDelegate<av_picture_copy_delegate>(GetOrLoadLibrary("avcodec", 57), "av_picture_copy");
            if (av_picture_copy_fptr == null)
            {
                av_picture_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_picture_copy is not supported on this platform.");
                };
            }
            av_picture_copy_fptr(@dst, @src, @pix_fmt, @width, @height);
        };
        [Obsolete("av_image_copy() instead.")]
        public static void av_picture_copy(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            av_picture_copy_fptr(@dst, @src, @pix_fmt, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_picture_crop_delegate(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @top_band, int @left_band);
        private static av_picture_crop_delegate av_picture_crop_fptr = (AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @top_band, int @left_band) =>
        {
            av_picture_crop_fptr = GetFunctionDelegate<av_picture_crop_delegate>(GetOrLoadLibrary("avcodec", 57), "av_picture_crop");
            if (av_picture_crop_fptr == null)
            {
                av_picture_crop_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_picture_crop is not supported on this platform.");
                };
            }
            return av_picture_crop_fptr(@dst, @src, @pix_fmt, @top_band, @left_band);
        };
        [Obsolete("unused")]
        public static int av_picture_crop(AVPicture* @dst, AVPicture* @src, AVPixelFormat @pix_fmt, int @top_band, int @left_band)
        {
            return av_picture_crop_fptr(@dst, @src, @pix_fmt, @top_band, @left_band);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_picture_pad_delegate(AVPicture* @dst, AVPicture* @src, int @height, int @width, AVPixelFormat @pix_fmt, int @padtop, int @padbottom, int @padleft, int @padright, int* @color);
        private static av_picture_pad_delegate av_picture_pad_fptr = (AVPicture* @dst, AVPicture* @src, int @height, int @width, AVPixelFormat @pix_fmt, int @padtop, int @padbottom, int @padleft, int @padright, int* @color) =>
        {
            av_picture_pad_fptr = GetFunctionDelegate<av_picture_pad_delegate>(GetOrLoadLibrary("avcodec", 57), "av_picture_pad");
            if (av_picture_pad_fptr == null)
            {
                av_picture_pad_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_picture_pad is not supported on this platform.");
                };
            }
            return av_picture_pad_fptr(@dst, @src, @height, @width, @pix_fmt, @padtop, @padbottom, @padleft, @padright, @color);
        };
        [Obsolete("unused")]
        public static int av_picture_pad(AVPicture* @dst, AVPicture* @src, int @height, int @width, AVPixelFormat @pix_fmt, int @padtop, int @padbottom, int @padleft, int @padright, int* @color)
        {
            return av_picture_pad_fptr(@dst, @src, @height, @width, @pix_fmt, @padtop, @padbottom, @padleft, @padright, @color);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_register_bitstream_filter_delegate(AVBitStreamFilter* @bsf);
        private static av_register_bitstream_filter_delegate av_register_bitstream_filter_fptr = (AVBitStreamFilter* @bsf) =>
        {
            av_register_bitstream_filter_fptr = GetFunctionDelegate<av_register_bitstream_filter_delegate>(GetOrLoadLibrary("avcodec", 57), "av_register_bitstream_filter");
            if (av_register_bitstream_filter_fptr == null)
            {
                av_register_bitstream_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_register_bitstream_filter is not supported on this platform.");
                };
            }
            av_register_bitstream_filter_fptr(@bsf);
        };
        /// <summary>Register a bitstream filter.</summary>
        [Obsolete("")]
        public static void av_register_bitstream_filter(AVBitStreamFilter* @bsf)
        {
            av_register_bitstream_filter_fptr(@bsf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_register_codec_parser_delegate(AVCodecParser* @parser);
        private static av_register_codec_parser_delegate av_register_codec_parser_fptr = (AVCodecParser* @parser) =>
        {
            av_register_codec_parser_fptr = GetFunctionDelegate<av_register_codec_parser_delegate>(GetOrLoadLibrary("avcodec", 57), "av_register_codec_parser");
            if (av_register_codec_parser_fptr == null)
            {
                av_register_codec_parser_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_register_codec_parser is not supported on this platform.");
                };
            }
            av_register_codec_parser_fptr(@parser);
        };
        public static void av_register_codec_parser(AVCodecParser* @parser)
        {
            av_register_codec_parser_fptr(@parser);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_register_hwaccel_delegate(AVHWAccel* @hwaccel);
        private static av_register_hwaccel_delegate av_register_hwaccel_fptr = (AVHWAccel* @hwaccel) =>
        {
            av_register_hwaccel_fptr = GetFunctionDelegate<av_register_hwaccel_delegate>(GetOrLoadLibrary("avcodec", 57), "av_register_hwaccel");
            if (av_register_hwaccel_fptr == null)
            {
                av_register_hwaccel_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_register_hwaccel is not supported on this platform.");
                };
            }
            av_register_hwaccel_fptr(@hwaccel);
        };
        /// <summary>Register the hardware accelerator hwaccel.</summary>
        public static void av_register_hwaccel(AVHWAccel* @hwaccel)
        {
            av_register_hwaccel_fptr(@hwaccel);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_resample_delegate(AVResampleContext* @c, short* @dst, short* @src, int* @consumed, int @src_size, int @dst_size, int @update_ctx);
        private static av_resample_delegate av_resample_fptr = (AVResampleContext* @c, short* @dst, short* @src, int* @consumed, int @src_size, int @dst_size, int @update_ctx) =>
        {
            av_resample_fptr = GetFunctionDelegate<av_resample_delegate>(GetOrLoadLibrary("avcodec", 57), "av_resample");
            if (av_resample_fptr == null)
            {
                av_resample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_resample is not supported on this platform.");
                };
            }
            return av_resample_fptr(@c, @dst, @src, @consumed, @src_size, @dst_size, @update_ctx);
        };
        /// <summary>Resample an array of samples using a previously configured context.</summary>
        /// <param name="src">an array of unconsumed samples</param>
        /// <param name="consumed">the number of samples of src which have been consumed are returned here</param>
        /// <param name="src_size">the number of unconsumed samples available</param>
        /// <param name="dst_size">the amount of space in samples available in dst</param>
        /// <param name="update_ctx">If this is 0 then the context will not be modified, that way several channels can be resampled with the same context.</param>
        [Obsolete("")]
        public static int av_resample(AVResampleContext* @c, short* @dst, short* @src, int* @consumed, int @src_size, int @dst_size, int @update_ctx)
        {
            return av_resample_fptr(@c, @dst, @src, @consumed, @src_size, @dst_size, @update_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_resample_close_delegate(AVResampleContext* @c);
        private static av_resample_close_delegate av_resample_close_fptr = (AVResampleContext* @c) =>
        {
            av_resample_close_fptr = GetFunctionDelegate<av_resample_close_delegate>(GetOrLoadLibrary("avcodec", 57), "av_resample_close");
            if (av_resample_close_fptr == null)
            {
                av_resample_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_resample_close is not supported on this platform.");
                };
            }
            av_resample_close_fptr(@c);
        };
        [Obsolete("")]
        public static void av_resample_close(AVResampleContext* @c)
        {
            av_resample_close_fptr(@c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_resample_compensate_delegate(AVResampleContext* @c, int @sample_delta, int @compensation_distance);
        private static av_resample_compensate_delegate av_resample_compensate_fptr = (AVResampleContext* @c, int @sample_delta, int @compensation_distance) =>
        {
            av_resample_compensate_fptr = GetFunctionDelegate<av_resample_compensate_delegate>(GetOrLoadLibrary("avcodec", 57), "av_resample_compensate");
            if (av_resample_compensate_fptr == null)
            {
                av_resample_compensate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_resample_compensate is not supported on this platform.");
                };
            }
            av_resample_compensate_fptr(@c, @sample_delta, @compensation_distance);
        };
        /// <summary>Compensate samplerate/timestamp drift. The compensation is done by changing the resampler parameters, so no audible clicks or similar distortions occur</summary>
        /// <param name="sample_delta">number of output samples which should be output less</param>
        /// <param name="compensation_distance">distance in output samples over which the compensation should be performed</param>
        [Obsolete("")]
        public static void av_resample_compensate(AVResampleContext* @c, int @sample_delta, int @compensation_distance)
        {
            av_resample_compensate_fptr(@c, @sample_delta, @compensation_distance);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVResampleContext* av_resample_init_delegate(int @out_rate, int @in_rate, int @filter_length, int @log2_phase_count, int @linear, double @cutoff);
        private static av_resample_init_delegate av_resample_init_fptr = (int @out_rate, int @in_rate, int @filter_length, int @log2_phase_count, int @linear, double @cutoff) =>
        {
            av_resample_init_fptr = GetFunctionDelegate<av_resample_init_delegate>(GetOrLoadLibrary("avcodec", 57), "av_resample_init");
            if (av_resample_init_fptr == null)
            {
                av_resample_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_resample_init is not supported on this platform.");
                };
            }
            return av_resample_init_fptr(@out_rate, @in_rate, @filter_length, @log2_phase_count, @linear, @cutoff);
        };
        /// <summary>Initialize an audio resampler. Note, if either rate is not an integer then simply scale both rates up so they are.</summary>
        /// <param name="filter_length">length of each FIR filter in the filterbank relative to the cutoff freq</param>
        /// <param name="log2_phase_count">log2 of the number of entries in the polyphase filterbank</param>
        /// <param name="linear">If 1 then the used FIR filter will be linearly interpolated between the 2 closest, if 0 the closest will be used</param>
        /// <param name="cutoff">cutoff frequency, 1.0 corresponds to half the output sampling rate</param>
        [Obsolete("")]
        public static AVResampleContext* av_resample_init(int @out_rate, int @in_rate, int @filter_length, int @log2_phase_count, int @linear, double @cutoff)
        {
            return av_resample_init_fptr(@out_rate, @in_rate, @filter_length, @log2_phase_count, @linear, @cutoff);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_shrink_packet_delegate(AVPacket* @pkt, int @size);
        private static av_shrink_packet_delegate av_shrink_packet_fptr = (AVPacket* @pkt, int @size) =>
        {
            av_shrink_packet_fptr = GetFunctionDelegate<av_shrink_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "av_shrink_packet");
            if (av_shrink_packet_fptr == null)
            {
                av_shrink_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_shrink_packet is not supported on this platform.");
                };
            }
            av_shrink_packet_fptr(@pkt, @size);
        };
        /// <summary>Reduce packet size, correctly zeroing padding</summary>
        /// <param name="pkt">packet</param>
        /// <param name="size">new size</param>
        public static void av_shrink_packet(AVPacket* @pkt, int @size)
        {
            av_shrink_packet_fptr(@pkt, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_xiphlacing_delegate(byte* @s, uint @v);
        private static av_xiphlacing_delegate av_xiphlacing_fptr = (byte* @s, uint @v) =>
        {
            av_xiphlacing_fptr = GetFunctionDelegate<av_xiphlacing_delegate>(GetOrLoadLibrary("avcodec", 57), "av_xiphlacing");
            if (av_xiphlacing_fptr == null)
            {
                av_xiphlacing_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_xiphlacing is not supported on this platform.");
                };
            }
            return av_xiphlacing_fptr(@s, @v);
        };
        /// <summary>Encode extradata length to a buffer. Used by xiph codecs.</summary>
        /// <param name="s">buffer to write to; must be at least (v/255+1) bytes long</param>
        /// <param name="v">size of extradata in bytes</param>
        public static uint av_xiphlacing(byte* @s, uint @v)
        {
            return av_xiphlacing_fptr(@s, @v);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_align_dimensions_delegate(AVCodecContext* @s, int* @width, int* @height);
        private static avcodec_align_dimensions_delegate avcodec_align_dimensions_fptr = (AVCodecContext* @s, int* @width, int* @height) =>
        {
            avcodec_align_dimensions_fptr = GetFunctionDelegate<avcodec_align_dimensions_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_align_dimensions");
            if (avcodec_align_dimensions_fptr == null)
            {
                avcodec_align_dimensions_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_align_dimensions is not supported on this platform.");
                };
            }
            avcodec_align_dimensions_fptr(@s, @width, @height);
        };
        /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you do not use any horizontal padding.</summary>
        public static void avcodec_align_dimensions(AVCodecContext* @s, int* @width, int* @height)
        {
            avcodec_align_dimensions_fptr(@s, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_align_dimensions2_delegate(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align);
        private static avcodec_align_dimensions2_delegate avcodec_align_dimensions2_fptr = (AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align) =>
        {
            avcodec_align_dimensions2_fptr = GetFunctionDelegate<avcodec_align_dimensions2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_align_dimensions2");
            if (avcodec_align_dimensions2_fptr == null)
            {
                avcodec_align_dimensions2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_align_dimensions2 is not supported on this platform.");
                };
            }
            avcodec_align_dimensions2_fptr(@s, @width, @height, ref @linesize_align);
        };
        /// <summary>Modify width and height values so that they will result in a memory buffer that is acceptable for the codec if you also ensure that all line sizes are a multiple of the respective linesize_align[i].</summary>
        public static void avcodec_align_dimensions2(AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align)
        {
            avcodec_align_dimensions2_fptr(@s, @width, @height, ref @linesize_align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecContext* avcodec_alloc_context3_delegate(AVCodec* @codec);
        private static avcodec_alloc_context3_delegate avcodec_alloc_context3_fptr = (AVCodec* @codec) =>
        {
            avcodec_alloc_context3_fptr = GetFunctionDelegate<avcodec_alloc_context3_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_alloc_context3");
            if (avcodec_alloc_context3_fptr == null)
            {
                avcodec_alloc_context3_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_alloc_context3 is not supported on this platform.");
                };
            }
            return avcodec_alloc_context3_fptr(@codec);
        };
        /// <summary>Allocate an AVCodecContext and set its fields to default values. The resulting struct should be freed with avcodec_free_context().</summary>
        /// <param name="codec">if non-NULL, allocate private data and initialize defaults for the given codec. It is illegal to then call avcodec_open2() with a different codec. If NULL, then the codec-specific defaults won&apos;t be initialized, which may result in suboptimal default settings (this is important mainly for encoders, e.g. libx264).</param>
        public static AVCodecContext* avcodec_alloc_context3(AVCodec* @codec)
        {
            return avcodec_alloc_context3_fptr(@codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVChromaLocation avcodec_chroma_pos_to_enum_delegate(int @xpos, int @ypos);
        private static avcodec_chroma_pos_to_enum_delegate avcodec_chroma_pos_to_enum_fptr = (int @xpos, int @ypos) =>
        {
            avcodec_chroma_pos_to_enum_fptr = GetFunctionDelegate<avcodec_chroma_pos_to_enum_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_chroma_pos_to_enum");
            if (avcodec_chroma_pos_to_enum_fptr == null)
            {
                avcodec_chroma_pos_to_enum_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_chroma_pos_to_enum is not supported on this platform.");
                };
            }
            return avcodec_chroma_pos_to_enum_fptr(@xpos, @ypos);
        };
        /// <summary>Converts swscale x/y chroma position to AVChromaLocation.</summary>
        /// <param name="xpos">horizontal chroma sample position</param>
        /// <param name="ypos">vertical   chroma sample position</param>
        public static AVChromaLocation avcodec_chroma_pos_to_enum(int @xpos, int @ypos)
        {
            return avcodec_chroma_pos_to_enum_fptr(@xpos, @ypos);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_close_delegate(AVCodecContext* @avctx);
        private static avcodec_close_delegate avcodec_close_fptr = (AVCodecContext* @avctx) =>
        {
            avcodec_close_fptr = GetFunctionDelegate<avcodec_close_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_close");
            if (avcodec_close_fptr == null)
            {
                avcodec_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_close is not supported on this platform.");
                };
            }
            return avcodec_close_fptr(@avctx);
        };
        /// <summary>Close a given AVCodecContext and free all the data associated with it (but not the AVCodecContext itself).</summary>
        public static int avcodec_close(AVCodecContext* @avctx)
        {
            return avcodec_close_fptr(@avctx);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avcodec_configuration_delegate();
        private static avcodec_configuration_delegate avcodec_configuration_fptr = () =>
        {
            avcodec_configuration_fptr = GetFunctionDelegate<avcodec_configuration_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_configuration");
            if (avcodec_configuration_fptr == null)
            {
                avcodec_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_configuration is not supported on this platform.");
                };
            }
            return avcodec_configuration_fptr();
        };
        /// <summary>Return the libavcodec build-time configuration.</summary>
        public static string avcodec_configuration()
        {
            return avcodec_configuration_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_copy_context_delegate(AVCodecContext* @dest, AVCodecContext* @src);
        private static avcodec_copy_context_delegate avcodec_copy_context_fptr = (AVCodecContext* @dest, AVCodecContext* @src) =>
        {
            avcodec_copy_context_fptr = GetFunctionDelegate<avcodec_copy_context_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_copy_context");
            if (avcodec_copy_context_fptr == null)
            {
                avcodec_copy_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_copy_context is not supported on this platform.");
                };
            }
            return avcodec_copy_context_fptr(@dest, @src);
        };
        /// <summary>Copy the settings of the source AVCodecContext into the destination AVCodecContext. The resulting destination codec context will be unopened, i.e. you are required to call avcodec_open2() before you can use this AVCodecContext to decode/encode video/audio data.</summary>
        /// <param name="dest">target codec context, should be initialized with avcodec_alloc_context3(NULL), but otherwise uninitialized</param>
        /// <param name="src">source codec context</param>
        [Obsolete("The semantics of this function are ill-defined and it should not be used. If you need to transfer the stream parameters from one codec context to another, use an intermediate AVCodecParameters instance and the avcodec_parameters_from_context() / avcodec_parameters_to_context() functions.")]
        public static int avcodec_copy_context(AVCodecContext* @dest, AVCodecContext* @src)
        {
            return avcodec_copy_context_fptr(@dest, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_decode_audio4_delegate(AVCodecContext* @avctx, AVFrame* @frame, int* @got_frame_ptr, AVPacket* @avpkt);
        private static avcodec_decode_audio4_delegate avcodec_decode_audio4_fptr = (AVCodecContext* @avctx, AVFrame* @frame, int* @got_frame_ptr, AVPacket* @avpkt) =>
        {
            avcodec_decode_audio4_fptr = GetFunctionDelegate<avcodec_decode_audio4_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_decode_audio4");
            if (avcodec_decode_audio4_fptr == null)
            {
                avcodec_decode_audio4_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_decode_audio4 is not supported on this platform.");
                };
            }
            return avcodec_decode_audio4_fptr(@avctx, @frame, @got_frame_ptr, @avpkt);
        };
        /// <summary>Decode the audio frame of size avpkt-&gt;size from avpkt-&gt;data into frame.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="frame">The AVFrame in which to store decoded audio samples. The decoder will allocate a buffer for the decoded frame by calling the AVCodecContext.get_buffer2() callback. When AVCodecContext.refcounted_frames is set to 1, the frame is reference counted and the returned reference belongs to the caller. The caller must release the frame using av_frame_unref() when the frame is no longer needed. The caller may safely write to the frame if av_frame_is_writable() returns 1. When AVCodecContext.refcounted_frames is set to 0, the returned reference belongs to the decoder and is valid only until the next call to this function or until closing or flushing the decoder. The caller may not write to it.</param>
        /// <param name="got_frame_ptr">Zero if no frame could be decoded, otherwise it is non-zero. Note that this field being set to zero does not mean that an error has occurred. For decoders with AV_CODEC_CAP_DELAY set, no given decode call is guaranteed to produce a frame.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer. At least avpkt-&gt;data and avpkt-&gt;size should be set. Some decoders might also require additional fields to be set.</param>
        [Obsolete("Use avcodec_send_packet() and avcodec_receive_frame().")]
        public static int avcodec_decode_audio4(AVCodecContext* @avctx, AVFrame* @frame, int* @got_frame_ptr, AVPacket* @avpkt)
        {
            return avcodec_decode_audio4_fptr(@avctx, @frame, @got_frame_ptr, @avpkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_decode_subtitle2_delegate(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt);
        private static avcodec_decode_subtitle2_delegate avcodec_decode_subtitle2_fptr = (AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt) =>
        {
            avcodec_decode_subtitle2_fptr = GetFunctionDelegate<avcodec_decode_subtitle2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_decode_subtitle2");
            if (avcodec_decode_subtitle2_fptr == null)
            {
                avcodec_decode_subtitle2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_decode_subtitle2 is not supported on this platform.");
                };
            }
            return avcodec_decode_subtitle2_fptr(@avctx, @sub, @got_sub_ptr, @avpkt);
        };
        /// <summary>Decode a subtitle message. Return a negative value on error, otherwise return the number of bytes used. If no subtitle could be decompressed, got_sub_ptr is zero. Otherwise, the subtitle is stored in *sub. Note that AV_CODEC_CAP_DR1 is not available for subtitle codecs. This is for simplicity, because the performance difference is expect to be negligible and reusing a get_buffer written for video codecs would probably perform badly due to a potentially very different allocation pattern.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="sub">The Preallocated AVSubtitle in which the decoded subtitle will be stored, must be freed with avsubtitle_free if *got_sub_ptr is set.</param>
        /// <param name="got_sub_ptr">Zero if no subtitle could be decompressed, otherwise, it is nonzero.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer.</param>
        public static int avcodec_decode_subtitle2(AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt)
        {
            return avcodec_decode_subtitle2_fptr(@avctx, @sub, @got_sub_ptr, @avpkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_decode_video2_delegate(AVCodecContext* @avctx, AVFrame* @picture, int* @got_picture_ptr, AVPacket* @avpkt);
        private static avcodec_decode_video2_delegate avcodec_decode_video2_fptr = (AVCodecContext* @avctx, AVFrame* @picture, int* @got_picture_ptr, AVPacket* @avpkt) =>
        {
            avcodec_decode_video2_fptr = GetFunctionDelegate<avcodec_decode_video2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_decode_video2");
            if (avcodec_decode_video2_fptr == null)
            {
                avcodec_decode_video2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_decode_video2 is not supported on this platform.");
                };
            }
            return avcodec_decode_video2_fptr(@avctx, @picture, @got_picture_ptr, @avpkt);
        };
        /// <summary>Decode the video frame of size avpkt-&gt;size from avpkt-&gt;data into picture. Some decoders may support multiple frames in a single AVPacket, such decoders would then just decode the first frame.</summary>
        /// <param name="avctx">the codec context</param>
        /// <param name="picture">The AVFrame in which the decoded video frame will be stored. Use av_frame_alloc() to get an AVFrame. The codec will allocate memory for the actual bitmap by calling the AVCodecContext.get_buffer2() callback. When AVCodecContext.refcounted_frames is set to 1, the frame is reference counted and the returned reference belongs to the caller. The caller must release the frame using av_frame_unref() when the frame is no longer needed. The caller may safely write to the frame if av_frame_is_writable() returns 1. When AVCodecContext.refcounted_frames is set to 0, the returned reference belongs to the decoder and is valid only until the next call to this function or until closing or flushing the decoder. The caller may not write to it.</param>
        /// <param name="got_picture_ptr">Zero if no frame could be decompressed, otherwise, it is nonzero.</param>
        /// <param name="avpkt">The input AVPacket containing the input buffer. You can create such packet with av_init_packet() and by then setting data and size, some decoders might in addition need other fields like flags &amp;AV _PKT_FLAG_KEY. All decoders are designed to use the least fields possible.</param>
        [Obsolete("Use avcodec_send_packet() and avcodec_receive_frame().")]
        public static int avcodec_decode_video2(AVCodecContext* @avctx, AVFrame* @picture, int* @got_picture_ptr, AVPacket* @avpkt)
        {
            return avcodec_decode_video2_fptr(@avctx, @picture, @got_picture_ptr, @avpkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_default_execute_delegate(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size);
        private static avcodec_default_execute_delegate avcodec_default_execute_fptr = (AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size) =>
        {
            avcodec_default_execute_fptr = GetFunctionDelegate<avcodec_default_execute_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_default_execute");
            if (avcodec_default_execute_fptr == null)
            {
                avcodec_default_execute_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_default_execute is not supported on this platform.");
                };
            }
            return avcodec_default_execute_fptr(@c, @func, @arg, @ret, @count, @size);
        };
        public static int avcodec_default_execute(AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size)
        {
            return avcodec_default_execute_fptr(@c, @func, @arg, @ret, @count, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_default_execute2_delegate(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count);
        private static avcodec_default_execute2_delegate avcodec_default_execute2_fptr = (AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count) =>
        {
            avcodec_default_execute2_fptr = GetFunctionDelegate<avcodec_default_execute2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_default_execute2");
            if (avcodec_default_execute2_fptr == null)
            {
                avcodec_default_execute2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_default_execute2 is not supported on this platform.");
                };
            }
            return avcodec_default_execute2_fptr(@c, @func, @arg, @ret, @count);
        };
        public static int avcodec_default_execute2(AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count)
        {
            return avcodec_default_execute2_fptr(@c, @func, @arg, @ret, @count);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_default_get_buffer2_delegate(AVCodecContext* @s, AVFrame* @frame, int @flags);
        private static avcodec_default_get_buffer2_delegate avcodec_default_get_buffer2_fptr = (AVCodecContext* @s, AVFrame* @frame, int @flags) =>
        {
            avcodec_default_get_buffer2_fptr = GetFunctionDelegate<avcodec_default_get_buffer2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_default_get_buffer2");
            if (avcodec_default_get_buffer2_fptr == null)
            {
                avcodec_default_get_buffer2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_default_get_buffer2 is not supported on this platform.");
                };
            }
            return avcodec_default_get_buffer2_fptr(@s, @frame, @flags);
        };
        /// <summary>The default callback for AVCodecContext.get_buffer2(). It is made public so it can be called by custom get_buffer2() implementations for decoders without AV_CODEC_CAP_DR1 set.</summary>
        public static int avcodec_default_get_buffer2(AVCodecContext* @s, AVFrame* @frame, int @flags)
        {
            return avcodec_default_get_buffer2_fptr(@s, @frame, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat avcodec_default_get_format_delegate(AVCodecContext* @s, AVPixelFormat* @fmt);
        private static avcodec_default_get_format_delegate avcodec_default_get_format_fptr = (AVCodecContext* @s, AVPixelFormat* @fmt) =>
        {
            avcodec_default_get_format_fptr = GetFunctionDelegate<avcodec_default_get_format_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_default_get_format");
            if (avcodec_default_get_format_fptr == null)
            {
                avcodec_default_get_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_default_get_format is not supported on this platform.");
                };
            }
            return avcodec_default_get_format_fptr(@s, @fmt);
        };
        public static AVPixelFormat avcodec_default_get_format(AVCodecContext* @s, AVPixelFormat* @fmt)
        {
            return avcodec_default_get_format_fptr(@s, @fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecDescriptor* avcodec_descriptor_get_delegate(AVCodecID @id);
        private static avcodec_descriptor_get_delegate avcodec_descriptor_get_fptr = (AVCodecID @id) =>
        {
            avcodec_descriptor_get_fptr = GetFunctionDelegate<avcodec_descriptor_get_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_descriptor_get");
            if (avcodec_descriptor_get_fptr == null)
            {
                avcodec_descriptor_get_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_descriptor_get is not supported on this platform.");
                };
            }
            return avcodec_descriptor_get_fptr(@id);
        };
        /// <summary>Returns descriptor for given codec ID or NULL if no descriptor exists.</summary>
        public static AVCodecDescriptor* avcodec_descriptor_get(AVCodecID @id)
        {
            return avcodec_descriptor_get_fptr(@id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecDescriptor* avcodec_descriptor_get_by_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static avcodec_descriptor_get_by_name_delegate avcodec_descriptor_get_by_name_fptr = (string @name) =>
        {
            avcodec_descriptor_get_by_name_fptr = GetFunctionDelegate<avcodec_descriptor_get_by_name_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_descriptor_get_by_name");
            if (avcodec_descriptor_get_by_name_fptr == null)
            {
                avcodec_descriptor_get_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_descriptor_get_by_name is not supported on this platform.");
                };
            }
            return avcodec_descriptor_get_by_name_fptr(@name);
        };
        /// <summary>Returns codec descriptor with the given name or NULL if no such descriptor exists.</summary>
        public static AVCodecDescriptor* avcodec_descriptor_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return avcodec_descriptor_get_by_name_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecDescriptor* avcodec_descriptor_next_delegate(AVCodecDescriptor* @prev);
        private static avcodec_descriptor_next_delegate avcodec_descriptor_next_fptr = (AVCodecDescriptor* @prev) =>
        {
            avcodec_descriptor_next_fptr = GetFunctionDelegate<avcodec_descriptor_next_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_descriptor_next");
            if (avcodec_descriptor_next_fptr == null)
            {
                avcodec_descriptor_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_descriptor_next is not supported on this platform.");
                };
            }
            return avcodec_descriptor_next_fptr(@prev);
        };
        /// <summary>Iterate over all codec descriptors known to libavcodec.</summary>
        /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
        public static AVCodecDescriptor* avcodec_descriptor_next(AVCodecDescriptor* @prev)
        {
            return avcodec_descriptor_next_fptr(@prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_encode_audio2_delegate(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        private static avcodec_encode_audio2_delegate avcodec_encode_audio2_fptr = (AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr) =>
        {
            avcodec_encode_audio2_fptr = GetFunctionDelegate<avcodec_encode_audio2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_encode_audio2");
            if (avcodec_encode_audio2_fptr == null)
            {
                avcodec_encode_audio2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_encode_audio2 is not supported on this platform.");
                };
            }
            return avcodec_encode_audio2_fptr(@avctx, @avpkt, @frame, @got_packet_ptr);
        };
        /// <summary>Encode a frame of audio.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">output AVPacket. The user can supply an output buffer by setting avpkt-&gt;data and avpkt-&gt;size prior to calling the function, but if the size of the user-provided data is not large enough, encoding will fail. If avpkt-&gt;data and avpkt-&gt;size are set, avpkt-&gt;destruct must also be set. All other AVPacket fields will be reset by the encoder using av_init_packet(). If avpkt-&gt;data is NULL, the encoder will allocate it. The encoder will set avpkt-&gt;size to the size of the output packet.</param>
        /// <param name="frame">AVFrame containing the raw audio data to be encoded. May be NULL when flushing an encoder that has the AV_CODEC_CAP_DELAY capability set. If AV_CODEC_CAP_VARIABLE_FRAME_SIZE is set, then each frame can have any number of samples. If it is not set, frame-&gt;nb_samples must be equal to avctx-&gt;frame_size for all frames except the last. The final frame may be smaller than avctx-&gt;frame_size.</param>
        /// <param name="got_packet_ptr">This field is set to 1 by libavcodec if the output packet is non-empty, and to 0 if it is empty. If the function returns an error, the packet can be assumed to be invalid, and the value of got_packet_ptr is undefined and should not be used.</param>
        [Obsolete("use avcodec_send_frame()/avcodec_receive_packet() instead")]
        public static int avcodec_encode_audio2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr)
        {
            return avcodec_encode_audio2_fptr(@avctx, @avpkt, @frame, @got_packet_ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_encode_subtitle_delegate(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub);
        private static avcodec_encode_subtitle_delegate avcodec_encode_subtitle_fptr = (AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub) =>
        {
            avcodec_encode_subtitle_fptr = GetFunctionDelegate<avcodec_encode_subtitle_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_encode_subtitle");
            if (avcodec_encode_subtitle_fptr == null)
            {
                avcodec_encode_subtitle_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_encode_subtitle is not supported on this platform.");
                };
            }
            return avcodec_encode_subtitle_fptr(@avctx, @buf, @buf_size, @sub);
        };
        public static int avcodec_encode_subtitle(AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub)
        {
            return avcodec_encode_subtitle_fptr(@avctx, @buf, @buf_size, @sub);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_encode_video2_delegate(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr);
        private static avcodec_encode_video2_delegate avcodec_encode_video2_fptr = (AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr) =>
        {
            avcodec_encode_video2_fptr = GetFunctionDelegate<avcodec_encode_video2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_encode_video2");
            if (avcodec_encode_video2_fptr == null)
            {
                avcodec_encode_video2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_encode_video2 is not supported on this platform.");
                };
            }
            return avcodec_encode_video2_fptr(@avctx, @avpkt, @frame, @got_packet_ptr);
        };
        /// <summary>Encode a frame of video.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">output AVPacket. The user can supply an output buffer by setting avpkt-&gt;data and avpkt-&gt;size prior to calling the function, but if the size of the user-provided data is not large enough, encoding will fail. All other AVPacket fields will be reset by the encoder using av_init_packet(). If avpkt-&gt;data is NULL, the encoder will allocate it. The encoder will set avpkt-&gt;size to the size of the output packet. The returned data (if any) belongs to the caller, he is responsible for freeing it.</param>
        /// <param name="frame">AVFrame containing the raw video data to be encoded. May be NULL when flushing an encoder that has the AV_CODEC_CAP_DELAY capability set.</param>
        /// <param name="got_packet_ptr">This field is set to 1 by libavcodec if the output packet is non-empty, and to 0 if it is empty. If the function returns an error, the packet can be assumed to be invalid, and the value of got_packet_ptr is undefined and should not be used.</param>
        [Obsolete("use avcodec_send_frame()/avcodec_receive_packet() instead")]
        public static int avcodec_encode_video2(AVCodecContext* @avctx, AVPacket* @avpkt, AVFrame* @frame, int* @got_packet_ptr)
        {
            return avcodec_encode_video2_fptr(@avctx, @avpkt, @frame, @got_packet_ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_enum_to_chroma_pos_delegate(int* @xpos, int* @ypos, AVChromaLocation @pos);
        private static avcodec_enum_to_chroma_pos_delegate avcodec_enum_to_chroma_pos_fptr = (int* @xpos, int* @ypos, AVChromaLocation @pos) =>
        {
            avcodec_enum_to_chroma_pos_fptr = GetFunctionDelegate<avcodec_enum_to_chroma_pos_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_enum_to_chroma_pos");
            if (avcodec_enum_to_chroma_pos_fptr == null)
            {
                avcodec_enum_to_chroma_pos_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_enum_to_chroma_pos is not supported on this platform.");
                };
            }
            return avcodec_enum_to_chroma_pos_fptr(@xpos, @ypos, @pos);
        };
        /// <summary>Converts AVChromaLocation to swscale x/y chroma position.</summary>
        /// <param name="xpos">horizontal chroma sample position</param>
        /// <param name="ypos">vertical   chroma sample position</param>
        public static int avcodec_enum_to_chroma_pos(int* @xpos, int* @ypos, AVChromaLocation @pos)
        {
            return avcodec_enum_to_chroma_pos_fptr(@xpos, @ypos, @pos);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_fill_audio_frame_delegate(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align);
        private static avcodec_fill_audio_frame_delegate avcodec_fill_audio_frame_fptr = (AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align) =>
        {
            avcodec_fill_audio_frame_fptr = GetFunctionDelegate<avcodec_fill_audio_frame_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_fill_audio_frame");
            if (avcodec_fill_audio_frame_fptr == null)
            {
                avcodec_fill_audio_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_fill_audio_frame is not supported on this platform.");
                };
            }
            return avcodec_fill_audio_frame_fptr(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
        };
        /// <summary>Fill AVFrame audio data and linesize pointers.</summary>
        /// <param name="frame">the AVFrame frame-&gt;nb_samples must be set prior to calling the function. This function fills in frame-&gt;data, frame-&gt;extended_data, frame-&gt;linesize[0].</param>
        /// <param name="nb_channels">channel count</param>
        /// <param name="sample_fmt">sample format</param>
        /// <param name="buf">buffer to use for frame data</param>
        /// <param name="buf_size">size of buffer</param>
        /// <param name="align">plane size sample alignment (0 = default)</param>
        public static int avcodec_fill_audio_frame(AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align)
        {
            return avcodec_fill_audio_frame_fptr(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat avcodec_find_best_pix_fmt_of_2_delegate(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        private static avcodec_find_best_pix_fmt_of_2_delegate avcodec_find_best_pix_fmt_of_2_fptr = (AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
        {
            avcodec_find_best_pix_fmt_of_2_fptr = GetFunctionDelegate<avcodec_find_best_pix_fmt_of_2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_best_pix_fmt_of_2");
            if (avcodec_find_best_pix_fmt_of_2_fptr == null)
            {
                avcodec_find_best_pix_fmt_of_2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_best_pix_fmt_of_2 is not supported on this platform.");
                };
            }
            return avcodec_find_best_pix_fmt_of_2_fptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        };
        public static AVPixelFormat avcodec_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
        {
            return avcodec_find_best_pix_fmt_of_2_fptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat avcodec_find_best_pix_fmt_of_list_delegate(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        private static avcodec_find_best_pix_fmt_of_list_delegate avcodec_find_best_pix_fmt_of_list_fptr = (AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
        {
            avcodec_find_best_pix_fmt_of_list_fptr = GetFunctionDelegate<avcodec_find_best_pix_fmt_of_list_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_best_pix_fmt_of_list");
            if (avcodec_find_best_pix_fmt_of_list_fptr == null)
            {
                avcodec_find_best_pix_fmt_of_list_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_best_pix_fmt_of_list is not supported on this platform.");
                };
            }
            return avcodec_find_best_pix_fmt_of_list_fptr(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
        };
        /// <summary>Find the best pixel format to convert to given a certain source pixel format. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. avcodec_find_best_pix_fmt_of_2() searches which of the given pixel formats should be used to suffer the least amount of loss. The pixel formats from which it chooses one, are determined by the pix_fmt_list parameter.</summary>
        /// <param name="pix_fmt_list">AV_PIX_FMT_NONE terminated array of pixel formats to choose from</param>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        /// <param name="loss_ptr">Combination of flags informing you what kind of losses will occur.</param>
        public static AVPixelFormat avcodec_find_best_pix_fmt_of_list(AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
        {
            return avcodec_find_best_pix_fmt_of_list_fptr(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat avcodec_find_best_pix_fmt2_delegate(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        private static avcodec_find_best_pix_fmt2_delegate avcodec_find_best_pix_fmt2_fptr = (AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
        {
            avcodec_find_best_pix_fmt2_fptr = GetFunctionDelegate<avcodec_find_best_pix_fmt2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_best_pix_fmt2");
            if (avcodec_find_best_pix_fmt2_fptr == null)
            {
                avcodec_find_best_pix_fmt2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_best_pix_fmt2 is not supported on this platform.");
                };
            }
            return avcodec_find_best_pix_fmt2_fptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        };
        [Obsolete("")]
        public static AVPixelFormat avcodec_find_best_pix_fmt2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
        {
            return avcodec_find_best_pix_fmt2_fptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* avcodec_find_decoder_delegate(AVCodecID @id);
        private static avcodec_find_decoder_delegate avcodec_find_decoder_fptr = (AVCodecID @id) =>
        {
            avcodec_find_decoder_fptr = GetFunctionDelegate<avcodec_find_decoder_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_decoder");
            if (avcodec_find_decoder_fptr == null)
            {
                avcodec_find_decoder_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_decoder is not supported on this platform.");
                };
            }
            return avcodec_find_decoder_fptr(@id);
        };
        /// <summary>Find a registered decoder with a matching codec ID.</summary>
        /// <param name="id">AVCodecID of the requested decoder</param>
        public static AVCodec* avcodec_find_decoder(AVCodecID @id)
        {
            return avcodec_find_decoder_fptr(@id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* avcodec_find_decoder_by_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static avcodec_find_decoder_by_name_delegate avcodec_find_decoder_by_name_fptr = (string @name) =>
        {
            avcodec_find_decoder_by_name_fptr = GetFunctionDelegate<avcodec_find_decoder_by_name_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_decoder_by_name");
            if (avcodec_find_decoder_by_name_fptr == null)
            {
                avcodec_find_decoder_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_decoder_by_name is not supported on this platform.");
                };
            }
            return avcodec_find_decoder_by_name_fptr(@name);
        };
        /// <summary>Find a registered decoder with the specified name.</summary>
        /// <param name="name">name of the requested decoder</param>
        public static AVCodec* avcodec_find_decoder_by_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return avcodec_find_decoder_by_name_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* avcodec_find_encoder_delegate(AVCodecID @id);
        private static avcodec_find_encoder_delegate avcodec_find_encoder_fptr = (AVCodecID @id) =>
        {
            avcodec_find_encoder_fptr = GetFunctionDelegate<avcodec_find_encoder_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_encoder");
            if (avcodec_find_encoder_fptr == null)
            {
                avcodec_find_encoder_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_encoder is not supported on this platform.");
                };
            }
            return avcodec_find_encoder_fptr(@id);
        };
        /// <summary>Find a registered encoder with a matching codec ID.</summary>
        /// <param name="id">AVCodecID of the requested encoder</param>
        public static AVCodec* avcodec_find_encoder(AVCodecID @id)
        {
            return avcodec_find_encoder_fptr(@id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* avcodec_find_encoder_by_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static avcodec_find_encoder_by_name_delegate avcodec_find_encoder_by_name_fptr = (string @name) =>
        {
            avcodec_find_encoder_by_name_fptr = GetFunctionDelegate<avcodec_find_encoder_by_name_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_find_encoder_by_name");
            if (avcodec_find_encoder_by_name_fptr == null)
            {
                avcodec_find_encoder_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_find_encoder_by_name is not supported on this platform.");
                };
            }
            return avcodec_find_encoder_by_name_fptr(@name);
        };
        /// <summary>Find a registered encoder with the specified name.</summary>
        /// <param name="name">name of the requested encoder</param>
        public static AVCodec* avcodec_find_encoder_by_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return avcodec_find_encoder_by_name_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_flush_buffers_delegate(AVCodecContext* @avctx);
        private static avcodec_flush_buffers_delegate avcodec_flush_buffers_fptr = (AVCodecContext* @avctx) =>
        {
            avcodec_flush_buffers_fptr = GetFunctionDelegate<avcodec_flush_buffers_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_flush_buffers");
            if (avcodec_flush_buffers_fptr == null)
            {
                avcodec_flush_buffers_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_flush_buffers is not supported on this platform.");
                };
            }
            avcodec_flush_buffers_fptr(@avctx);
        };
        /// <summary>Reset the internal decoder state / flush internal buffers. Should be called e.g. when seeking or when switching to a different stream.</summary>
        public static void avcodec_flush_buffers(AVCodecContext* @avctx)
        {
            avcodec_flush_buffers_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_free_context_delegate(AVCodecContext** @avctx);
        private static avcodec_free_context_delegate avcodec_free_context_fptr = (AVCodecContext** @avctx) =>
        {
            avcodec_free_context_fptr = GetFunctionDelegate<avcodec_free_context_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_free_context");
            if (avcodec_free_context_fptr == null)
            {
                avcodec_free_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_free_context is not supported on this platform.");
                };
            }
            avcodec_free_context_fptr(@avctx);
        };
        /// <summary>Free the codec context and everything associated with it and write NULL to the provided pointer.</summary>
        public static void avcodec_free_context(AVCodecContext** @avctx)
        {
            avcodec_free_context_fptr(@avctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_get_chroma_sub_sample_delegate(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        private static avcodec_get_chroma_sub_sample_delegate avcodec_get_chroma_sub_sample_fptr = (AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift) =>
        {
            avcodec_get_chroma_sub_sample_fptr = GetFunctionDelegate<avcodec_get_chroma_sub_sample_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_chroma_sub_sample");
            if (avcodec_get_chroma_sub_sample_fptr == null)
            {
                avcodec_get_chroma_sub_sample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_chroma_sub_sample is not supported on this platform.");
                };
            }
            avcodec_get_chroma_sub_sample_fptr(@pix_fmt, @h_shift, @v_shift);
        };
        [Obsolete("Use av_pix_fmt_get_chroma_sub_sample")]
        public static void avcodec_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift)
        {
            avcodec_get_chroma_sub_sample_fptr(@pix_fmt, @h_shift, @v_shift);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* avcodec_get_class_delegate();
        private static avcodec_get_class_delegate avcodec_get_class_fptr = () =>
        {
            avcodec_get_class_fptr = GetFunctionDelegate<avcodec_get_class_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_class");
            if (avcodec_get_class_fptr == null)
            {
                avcodec_get_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_class is not supported on this platform.");
                };
            }
            return avcodec_get_class_fptr();
        };
        /// <summary>Get the AVClass for AVCodecContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* avcodec_get_class()
        {
            return avcodec_get_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_get_context_defaults3_delegate(AVCodecContext* @s, AVCodec* @codec);
        private static avcodec_get_context_defaults3_delegate avcodec_get_context_defaults3_fptr = (AVCodecContext* @s, AVCodec* @codec) =>
        {
            avcodec_get_context_defaults3_fptr = GetFunctionDelegate<avcodec_get_context_defaults3_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_context_defaults3");
            if (avcodec_get_context_defaults3_fptr == null)
            {
                avcodec_get_context_defaults3_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_context_defaults3 is not supported on this platform.");
                };
            }
            return avcodec_get_context_defaults3_fptr(@s, @codec);
        };
        public static int avcodec_get_context_defaults3(AVCodecContext* @s, AVCodec* @codec)
        {
            return avcodec_get_context_defaults3_fptr(@s, @codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avcodec_get_edge_width_delegate();
        private static avcodec_get_edge_width_delegate avcodec_get_edge_width_fptr = () =>
        {
            avcodec_get_edge_width_fptr = GetFunctionDelegate<avcodec_get_edge_width_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_edge_width");
            if (avcodec_get_edge_width_fptr == null)
            {
                avcodec_get_edge_width_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_edge_width is not supported on this platform.");
                };
            }
            return avcodec_get_edge_width_fptr();
        };
        /// <summary>Return the amount of padding in pixels which the get_buffer callback must provide around the edge of the image for codecs which do not have the CODEC_FLAG_EMU_EDGE flag.</summary>
        [Obsolete("CODEC_FLAG_EMU_EDGE is deprecated, so this function is no longer needed")]
        public static uint avcodec_get_edge_width()
        {
            return avcodec_get_edge_width_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* avcodec_get_frame_class_delegate();
        private static avcodec_get_frame_class_delegate avcodec_get_frame_class_fptr = () =>
        {
            avcodec_get_frame_class_fptr = GetFunctionDelegate<avcodec_get_frame_class_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_frame_class");
            if (avcodec_get_frame_class_fptr == null)
            {
                avcodec_get_frame_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_frame_class is not supported on this platform.");
                };
            }
            return avcodec_get_frame_class_fptr();
        };
        /// <summary>Get the AVClass for AVFrame. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* avcodec_get_frame_class()
        {
            return avcodec_get_frame_class_fptr();
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avcodec_get_name_delegate(AVCodecID @id);
        private static avcodec_get_name_delegate avcodec_get_name_fptr = (AVCodecID @id) =>
        {
            avcodec_get_name_fptr = GetFunctionDelegate<avcodec_get_name_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_name");
            if (avcodec_get_name_fptr == null)
            {
                avcodec_get_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_name is not supported on this platform.");
                };
            }
            return avcodec_get_name_fptr(@id);
        };
        /// <summary>Get the name of a codec.</summary>
        public static string avcodec_get_name(AVCodecID @id)
        {
            return avcodec_get_name_fptr(@id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_get_pix_fmt_loss_delegate(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        private static avcodec_get_pix_fmt_loss_delegate avcodec_get_pix_fmt_loss_fptr = (AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha) =>
        {
            avcodec_get_pix_fmt_loss_fptr = GetFunctionDelegate<avcodec_get_pix_fmt_loss_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_pix_fmt_loss");
            if (avcodec_get_pix_fmt_loss_fptr == null)
            {
                avcodec_get_pix_fmt_loss_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_pix_fmt_loss is not supported on this platform.");
                };
            }
            return avcodec_get_pix_fmt_loss_fptr(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        };
        public static int avcodec_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha)
        {
            return avcodec_get_pix_fmt_loss_fptr(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* avcodec_get_subtitle_rect_class_delegate();
        private static avcodec_get_subtitle_rect_class_delegate avcodec_get_subtitle_rect_class_fptr = () =>
        {
            avcodec_get_subtitle_rect_class_fptr = GetFunctionDelegate<avcodec_get_subtitle_rect_class_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_subtitle_rect_class");
            if (avcodec_get_subtitle_rect_class_fptr == null)
            {
                avcodec_get_subtitle_rect_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_subtitle_rect_class is not supported on this platform.");
                };
            }
            return avcodec_get_subtitle_rect_class_fptr();
        };
        /// <summary>Get the AVClass for AVSubtitleRect. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* avcodec_get_subtitle_rect_class()
        {
            return avcodec_get_subtitle_rect_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVMediaType avcodec_get_type_delegate(AVCodecID @codec_id);
        private static avcodec_get_type_delegate avcodec_get_type_fptr = (AVCodecID @codec_id) =>
        {
            avcodec_get_type_fptr = GetFunctionDelegate<avcodec_get_type_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_get_type");
            if (avcodec_get_type_fptr == null)
            {
                avcodec_get_type_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_get_type is not supported on this platform.");
                };
            }
            return avcodec_get_type_fptr(@codec_id);
        };
        /// <summary>Get the type of the given codec.</summary>
        public static AVMediaType avcodec_get_type(AVCodecID @codec_id)
        {
            return avcodec_get_type_fptr(@codec_id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_is_open_delegate(AVCodecContext* @s);
        private static avcodec_is_open_delegate avcodec_is_open_fptr = (AVCodecContext* @s) =>
        {
            avcodec_is_open_fptr = GetFunctionDelegate<avcodec_is_open_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_is_open");
            if (avcodec_is_open_fptr == null)
            {
                avcodec_is_open_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_is_open is not supported on this platform.");
                };
            }
            return avcodec_is_open_fptr(@s);
        };
        /// <summary>Returns a positive value if s is open (i.e. avcodec_open2() was called on it with no corresponding avcodec_close()), 0 otherwise.</summary>
        public static int avcodec_is_open(AVCodecContext* @s)
        {
            return avcodec_is_open_fptr(@s);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avcodec_license_delegate();
        private static avcodec_license_delegate avcodec_license_fptr = () =>
        {
            avcodec_license_fptr = GetFunctionDelegate<avcodec_license_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_license");
            if (avcodec_license_fptr == null)
            {
                avcodec_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_license is not supported on this platform.");
                };
            }
            return avcodec_license_fptr();
        };
        /// <summary>Return the libavcodec license.</summary>
        public static string avcodec_license()
        {
            return avcodec_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_open2_delegate(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options);
        private static avcodec_open2_delegate avcodec_open2_fptr = (AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options) =>
        {
            avcodec_open2_fptr = GetFunctionDelegate<avcodec_open2_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_open2");
            if (avcodec_open2_fptr == null)
            {
                avcodec_open2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_open2 is not supported on this platform.");
                };
            }
            return avcodec_open2_fptr(@avctx, @codec, @options);
        };
        /// <summary>Initialize the AVCodecContext to use the given AVCodec. Prior to using this function the context has to be allocated with avcodec_alloc_context3().</summary>
        /// <param name="avctx">The context to initialize.</param>
        /// <param name="codec">The codec to open this context for. If a non-NULL codec has been previously passed to avcodec_alloc_context3() or for this context, then this parameter MUST be either NULL or equal to the previously passed codec.</param>
        /// <param name="options">A dictionary filled with AVCodecContext and codec-private options. On return this object will be filled with options that were not found.</param>
        public static int avcodec_open2(AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options)
        {
            return avcodec_open2_fptr(@avctx, @codec, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecParameters* avcodec_parameters_alloc_delegate();
        private static avcodec_parameters_alloc_delegate avcodec_parameters_alloc_fptr = () =>
        {
            avcodec_parameters_alloc_fptr = GetFunctionDelegate<avcodec_parameters_alloc_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_parameters_alloc");
            if (avcodec_parameters_alloc_fptr == null)
            {
                avcodec_parameters_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_parameters_alloc is not supported on this platform.");
                };
            }
            return avcodec_parameters_alloc_fptr();
        };
        /// <summary>Allocate a new AVCodecParameters and set its fields to default values (unknown/invalid/0). The returned struct must be freed with avcodec_parameters_free().</summary>
        public static AVCodecParameters* avcodec_parameters_alloc()
        {
            return avcodec_parameters_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_parameters_copy_delegate(AVCodecParameters* @dst, AVCodecParameters* @src);
        private static avcodec_parameters_copy_delegate avcodec_parameters_copy_fptr = (AVCodecParameters* @dst, AVCodecParameters* @src) =>
        {
            avcodec_parameters_copy_fptr = GetFunctionDelegate<avcodec_parameters_copy_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_parameters_copy");
            if (avcodec_parameters_copy_fptr == null)
            {
                avcodec_parameters_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_parameters_copy is not supported on this platform.");
                };
            }
            return avcodec_parameters_copy_fptr(@dst, @src);
        };
        /// <summary>Copy the contents of src to dst. Any allocated fields in dst are freed and replaced with newly allocated duplicates of the corresponding fields in src.</summary>
        public static int avcodec_parameters_copy(AVCodecParameters* @dst, AVCodecParameters* @src)
        {
            return avcodec_parameters_copy_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_parameters_free_delegate(AVCodecParameters** @par);
        private static avcodec_parameters_free_delegate avcodec_parameters_free_fptr = (AVCodecParameters** @par) =>
        {
            avcodec_parameters_free_fptr = GetFunctionDelegate<avcodec_parameters_free_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_parameters_free");
            if (avcodec_parameters_free_fptr == null)
            {
                avcodec_parameters_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_parameters_free is not supported on this platform.");
                };
            }
            avcodec_parameters_free_fptr(@par);
        };
        /// <summary>Free an AVCodecParameters instance and everything associated with it and write NULL to the supplied pointer.</summary>
        public static void avcodec_parameters_free(AVCodecParameters** @par)
        {
            avcodec_parameters_free_fptr(@par);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_parameters_from_context_delegate(AVCodecParameters* @par, AVCodecContext* @codec);
        private static avcodec_parameters_from_context_delegate avcodec_parameters_from_context_fptr = (AVCodecParameters* @par, AVCodecContext* @codec) =>
        {
            avcodec_parameters_from_context_fptr = GetFunctionDelegate<avcodec_parameters_from_context_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_parameters_from_context");
            if (avcodec_parameters_from_context_fptr == null)
            {
                avcodec_parameters_from_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_parameters_from_context is not supported on this platform.");
                };
            }
            return avcodec_parameters_from_context_fptr(@par, @codec);
        };
        /// <summary>Fill the parameters struct based on the values from the supplied codec context. Any allocated fields in par are freed and replaced with duplicates of the corresponding fields in codec.</summary>
        public static int avcodec_parameters_from_context(AVCodecParameters* @par, AVCodecContext* @codec)
        {
            return avcodec_parameters_from_context_fptr(@par, @codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_parameters_to_context_delegate(AVCodecContext* @codec, AVCodecParameters* @par);
        private static avcodec_parameters_to_context_delegate avcodec_parameters_to_context_fptr = (AVCodecContext* @codec, AVCodecParameters* @par) =>
        {
            avcodec_parameters_to_context_fptr = GetFunctionDelegate<avcodec_parameters_to_context_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_parameters_to_context");
            if (avcodec_parameters_to_context_fptr == null)
            {
                avcodec_parameters_to_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_parameters_to_context is not supported on this platform.");
                };
            }
            return avcodec_parameters_to_context_fptr(@codec, @par);
        };
        /// <summary>Fill the codec context based on the values from the supplied codec parameters. Any allocated fields in codec that have a corresponding field in par are freed and replaced with duplicates of the corresponding field in par. Fields in codec that do not have a counterpart in par are not touched.</summary>
        public static int avcodec_parameters_to_context(AVCodecContext* @codec, AVCodecParameters* @par)
        {
            return avcodec_parameters_to_context_fptr(@codec, @par);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avcodec_pix_fmt_to_codec_tag_delegate(AVPixelFormat @pix_fmt);
        private static avcodec_pix_fmt_to_codec_tag_delegate avcodec_pix_fmt_to_codec_tag_fptr = (AVPixelFormat @pix_fmt) =>
        {
            avcodec_pix_fmt_to_codec_tag_fptr = GetFunctionDelegate<avcodec_pix_fmt_to_codec_tag_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_pix_fmt_to_codec_tag");
            if (avcodec_pix_fmt_to_codec_tag_fptr == null)
            {
                avcodec_pix_fmt_to_codec_tag_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_pix_fmt_to_codec_tag is not supported on this platform.");
                };
            }
            return avcodec_pix_fmt_to_codec_tag_fptr(@pix_fmt);
        };
        /// <summary>Return a value representing the fourCC code associated to the pixel format pix_fmt, or 0 if no associated fourCC code can be found.</summary>
        public static uint avcodec_pix_fmt_to_codec_tag(AVPixelFormat @pix_fmt)
        {
            return avcodec_pix_fmt_to_codec_tag_fptr(@pix_fmt);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avcodec_profile_name_delegate(AVCodecID @codec_id, int @profile);
        private static avcodec_profile_name_delegate avcodec_profile_name_fptr = (AVCodecID @codec_id, int @profile) =>
        {
            avcodec_profile_name_fptr = GetFunctionDelegate<avcodec_profile_name_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_profile_name");
            if (avcodec_profile_name_fptr == null)
            {
                avcodec_profile_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_profile_name is not supported on this platform.");
                };
            }
            return avcodec_profile_name_fptr(@codec_id, @profile);
        };
        /// <summary>Return a name for the specified profile, if available.</summary>
        /// <param name="codec_id">the ID of the codec to which the requested profile belongs</param>
        /// <param name="profile">the profile value for which a name is requested</param>
        public static string avcodec_profile_name(AVCodecID @codec_id, int @profile)
        {
            return avcodec_profile_name_fptr(@codec_id, @profile);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_receive_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);
        private static avcodec_receive_frame_delegate avcodec_receive_frame_fptr = (AVCodecContext* @avctx, AVFrame* @frame) =>
        {
            avcodec_receive_frame_fptr = GetFunctionDelegate<avcodec_receive_frame_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_receive_frame");
            if (avcodec_receive_frame_fptr == null)
            {
                avcodec_receive_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_receive_frame is not supported on this platform.");
                };
            }
            return avcodec_receive_frame_fptr(@avctx, @frame);
        };
        /// <summary>Return decoded output data from a decoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame">This will be set to a reference-counted video or audio frame (depending on the decoder type) allocated by the decoder. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
        public static int avcodec_receive_frame(AVCodecContext* @avctx, AVFrame* @frame)
        {
            return avcodec_receive_frame_fptr(@avctx, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_receive_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);
        private static avcodec_receive_packet_delegate avcodec_receive_packet_fptr = (AVCodecContext* @avctx, AVPacket* @avpkt) =>
        {
            avcodec_receive_packet_fptr = GetFunctionDelegate<avcodec_receive_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_receive_packet");
            if (avcodec_receive_packet_fptr == null)
            {
                avcodec_receive_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_receive_packet is not supported on this platform.");
                };
            }
            return avcodec_receive_packet_fptr(@avctx, @avpkt);
        };
        /// <summary>Read encoded data from the encoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">This will be set to a reference-counted packet allocated by the encoder. Note that the function will always call av_frame_unref(frame) before doing anything else.</param>
        public static int avcodec_receive_packet(AVCodecContext* @avctx, AVPacket* @avpkt)
        {
            return avcodec_receive_packet_fptr(@avctx, @avpkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_register_delegate(AVCodec* @codec);
        private static avcodec_register_delegate avcodec_register_fptr = (AVCodec* @codec) =>
        {
            avcodec_register_fptr = GetFunctionDelegate<avcodec_register_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_register");
            if (avcodec_register_fptr == null)
            {
                avcodec_register_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_register is not supported on this platform.");
                };
            }
            avcodec_register_fptr(@codec);
        };
        /// <summary>Register the codec codec and initialize libavcodec.</summary>
        public static void avcodec_register(AVCodec* @codec)
        {
            avcodec_register_fptr(@codec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_register_all_delegate();
        private static avcodec_register_all_delegate avcodec_register_all_fptr = () =>
        {
            avcodec_register_all_fptr = GetFunctionDelegate<avcodec_register_all_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_register_all");
            if (avcodec_register_all_fptr == null)
            {
                avcodec_register_all_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_register_all is not supported on this platform.");
                };
            }
            avcodec_register_all_fptr();
        };
        /// <summary>Register all the codecs, parsers and bitstream filters which were enabled at configuration time. If you do not call this function you can select exactly which formats you want to support, by using the individual registration functions.</summary>
        public static void avcodec_register_all()
        {
            avcodec_register_all_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_send_frame_delegate(AVCodecContext* @avctx, AVFrame* @frame);
        private static avcodec_send_frame_delegate avcodec_send_frame_fptr = (AVCodecContext* @avctx, AVFrame* @frame) =>
        {
            avcodec_send_frame_fptr = GetFunctionDelegate<avcodec_send_frame_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_send_frame");
            if (avcodec_send_frame_fptr == null)
            {
                avcodec_send_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_send_frame is not supported on this platform.");
                };
            }
            return avcodec_send_frame_fptr(@avctx, @frame);
        };
        /// <summary>Supply a raw video or audio frame to the encoder. Use avcodec_receive_packet() to retrieve buffered output packets.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="frame">AVFrame containing the raw audio or video frame to be encoded. Ownership of the frame remains with the caller, and the encoder will not write to the frame. The encoder may create a reference to the frame data (or copy it if the frame is not reference-counted). It can be NULL, in which case it is considered a flush packet.  This signals the end of the stream. If the encoder still has packets buffered, it will return them after this call. Once flushing mode has been entered, additional flush packets are ignored, and sending frames will return AVERROR_EOF.</param>
        public static int avcodec_send_frame(AVCodecContext* @avctx, AVFrame* @frame)
        {
            return avcodec_send_frame_fptr(@avctx, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avcodec_send_packet_delegate(AVCodecContext* @avctx, AVPacket* @avpkt);
        private static avcodec_send_packet_delegate avcodec_send_packet_fptr = (AVCodecContext* @avctx, AVPacket* @avpkt) =>
        {
            avcodec_send_packet_fptr = GetFunctionDelegate<avcodec_send_packet_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_send_packet");
            if (avcodec_send_packet_fptr == null)
            {
                avcodec_send_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_send_packet is not supported on this platform.");
                };
            }
            return avcodec_send_packet_fptr(@avctx, @avpkt);
        };
        /// <summary>Supply raw packet data as input to a decoder.</summary>
        /// <param name="avctx">codec context</param>
        /// <param name="avpkt">The input AVPacket. Usually, this will be a single video frame, or several complete audio frames. Ownership of the packet remains with the caller, and the decoder will not write to the packet. The decoder may create a reference to the packet data (or copy it if the packet is not reference-counted). Unlike with older APIs, the packet is always fully consumed, and if it contains multiple frames (e.g. some audio codecs), will require you to call avcodec_receive_frame() multiple times afterwards before you can send a new packet. It can be NULL (or an AVPacket with data set to NULL and size set to 0); in this case, it is considered a flush packet, which signals the end of the stream. Sending the first flush packet will return success. Subsequent ones are unnecessary and will return AVERROR_EOF. If the decoder still has frames buffered, it will return them after sending a flush packet.</param>
        public static int avcodec_send_packet(AVCodecContext* @avctx, AVPacket* @avpkt)
        {
            return avcodec_send_packet_fptr(@avctx, @avpkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_set_dimensions_delegate(AVCodecContext* @s, int @width, int @height);
        private static avcodec_set_dimensions_delegate avcodec_set_dimensions_fptr = (AVCodecContext* @s, int @width, int @height) =>
        {
            avcodec_set_dimensions_fptr = GetFunctionDelegate<avcodec_set_dimensions_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_set_dimensions");
            if (avcodec_set_dimensions_fptr == null)
            {
                avcodec_set_dimensions_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_set_dimensions is not supported on this platform.");
                };
            }
            avcodec_set_dimensions_fptr(@s, @width, @height);
        };
        [Obsolete("this function is not supposed to be used from outside of lavc")]
        public static void avcodec_set_dimensions(AVCodecContext* @s, int @width, int @height)
        {
            avcodec_set_dimensions_fptr(@s, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avcodec_string_delegate(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode);
        private static avcodec_string_delegate avcodec_string_fptr = (byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode) =>
        {
            avcodec_string_fptr = GetFunctionDelegate<avcodec_string_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_string");
            if (avcodec_string_fptr == null)
            {
                avcodec_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_string is not supported on this platform.");
                };
            }
            avcodec_string_fptr(@buf, @buf_size, @enc, @encode);
        };
        public static void avcodec_string(byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode)
        {
            avcodec_string_fptr(@buf, @buf_size, @enc, @encode);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avcodec_version_delegate();
        private static avcodec_version_delegate avcodec_version_fptr = () =>
        {
            avcodec_version_fptr = GetFunctionDelegate<avcodec_version_delegate>(GetOrLoadLibrary("avcodec", 57), "avcodec_version");
            if (avcodec_version_fptr == null)
            {
                avcodec_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avcodec_version is not supported on this platform.");
                };
            }
            return avcodec_version_fptr();
        };
        /// <summary>Return the LIBAVCODEC_VERSION_INT constant.</summary>
        public static uint avcodec_version()
        {
            return avcodec_version_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avpicture_alloc_delegate(AVPicture* @picture, AVPixelFormat @pix_fmt, int @width, int @height);
        private static avpicture_alloc_delegate avpicture_alloc_fptr = (AVPicture* @picture, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            avpicture_alloc_fptr = GetFunctionDelegate<avpicture_alloc_delegate>(GetOrLoadLibrary("avcodec", 57), "avpicture_alloc");
            if (avpicture_alloc_fptr == null)
            {
                avpicture_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpicture_alloc is not supported on this platform.");
                };
            }
            return avpicture_alloc_fptr(@picture, @pix_fmt, @width, @height);
        };
        [Obsolete("unused")]
        public static int avpicture_alloc(AVPicture* @picture, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            return avpicture_alloc_fptr(@picture, @pix_fmt, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avpicture_fill_delegate(AVPicture* @picture, byte* @ptr, AVPixelFormat @pix_fmt, int @width, int @height);
        private static avpicture_fill_delegate avpicture_fill_fptr = (AVPicture* @picture, byte* @ptr, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            avpicture_fill_fptr = GetFunctionDelegate<avpicture_fill_delegate>(GetOrLoadLibrary("avcodec", 57), "avpicture_fill");
            if (avpicture_fill_fptr == null)
            {
                avpicture_fill_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpicture_fill is not supported on this platform.");
                };
            }
            return avpicture_fill_fptr(@picture, @ptr, @pix_fmt, @width, @height);
        };
        [Obsolete("use av_image_fill_arrays() instead.")]
        public static int avpicture_fill(AVPicture* @picture, byte* @ptr, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            return avpicture_fill_fptr(@picture, @ptr, @pix_fmt, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avpicture_free_delegate(AVPicture* @picture);
        private static avpicture_free_delegate avpicture_free_fptr = (AVPicture* @picture) =>
        {
            avpicture_free_fptr = GetFunctionDelegate<avpicture_free_delegate>(GetOrLoadLibrary("avcodec", 57), "avpicture_free");
            if (avpicture_free_fptr == null)
            {
                avpicture_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpicture_free is not supported on this platform.");
                };
            }
            avpicture_free_fptr(@picture);
        };
        [Obsolete("unused")]
        public static void avpicture_free(AVPicture* @picture)
        {
            avpicture_free_fptr(@picture);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avpicture_get_size_delegate(AVPixelFormat @pix_fmt, int @width, int @height);
        private static avpicture_get_size_delegate avpicture_get_size_fptr = (AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            avpicture_get_size_fptr = GetFunctionDelegate<avpicture_get_size_delegate>(GetOrLoadLibrary("avcodec", 57), "avpicture_get_size");
            if (avpicture_get_size_fptr == null)
            {
                avpicture_get_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpicture_get_size is not supported on this platform.");
                };
            }
            return avpicture_get_size_fptr(@pix_fmt, @width, @height);
        };
        [Obsolete("use av_image_get_buffer_size() instead.")]
        public static int avpicture_get_size(AVPixelFormat @pix_fmt, int @width, int @height)
        {
            return avpicture_get_size_fptr(@pix_fmt, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avpicture_layout_delegate(AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height, byte* @dest, int @dest_size);
        private static avpicture_layout_delegate avpicture_layout_fptr = (AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height, byte* @dest, int @dest_size) =>
        {
            avpicture_layout_fptr = GetFunctionDelegate<avpicture_layout_delegate>(GetOrLoadLibrary("avcodec", 57), "avpicture_layout");
            if (avpicture_layout_fptr == null)
            {
                avpicture_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpicture_layout is not supported on this platform.");
                };
            }
            return avpicture_layout_fptr(@src, @pix_fmt, @width, @height, @dest, @dest_size);
        };
        [Obsolete("use av_image_copy_to_buffer() instead.")]
        public static int avpicture_layout(AVPicture* @src, AVPixelFormat @pix_fmt, int @width, int @height, byte* @dest, int @dest_size)
        {
            return avpicture_layout_fptr(@src, @pix_fmt, @width, @height, @dest, @dest_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avsubtitle_free_delegate(AVSubtitle* @sub);
        private static avsubtitle_free_delegate avsubtitle_free_fptr = (AVSubtitle* @sub) =>
        {
            avsubtitle_free_fptr = GetFunctionDelegate<avsubtitle_free_delegate>(GetOrLoadLibrary("avcodec", 57), "avsubtitle_free");
            if (avsubtitle_free_fptr == null)
            {
                avsubtitle_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avsubtitle_free is not supported on this platform.");
                };
            }
            avsubtitle_free_fptr(@sub);
        };
        /// <summary>Free all allocated data in the given subtitle struct.</summary>
        /// <param name="sub">AVSubtitle to free.</param>
        public static void avsubtitle_free(AVSubtitle* @sub)
        {
            avsubtitle_free_fptr(@sub);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_input_audio_device_next_delegate(AVInputFormat* @d);
        private static av_input_audio_device_next_delegate av_input_audio_device_next_fptr = (AVInputFormat* @d) =>
        {
            av_input_audio_device_next_fptr = GetFunctionDelegate<av_input_audio_device_next_delegate>(GetOrLoadLibrary("avdevice", 57), "av_input_audio_device_next");
            if (av_input_audio_device_next_fptr == null)
            {
                av_input_audio_device_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_input_audio_device_next is not supported on this platform.");
                };
            }
            return av_input_audio_device_next_fptr(@d);
        };
        /// <summary>Audio input devices iterator.</summary>
        public static AVInputFormat* av_input_audio_device_next(AVInputFormat* @d)
        {
            return av_input_audio_device_next_fptr(@d);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_input_video_device_next_delegate(AVInputFormat* @d);
        private static av_input_video_device_next_delegate av_input_video_device_next_fptr = (AVInputFormat* @d) =>
        {
            av_input_video_device_next_fptr = GetFunctionDelegate<av_input_video_device_next_delegate>(GetOrLoadLibrary("avdevice", 57), "av_input_video_device_next");
            if (av_input_video_device_next_fptr == null)
            {
                av_input_video_device_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_input_video_device_next is not supported on this platform.");
                };
            }
            return av_input_video_device_next_fptr(@d);
        };
        /// <summary>Video input devices iterator.</summary>
        public static AVInputFormat* av_input_video_device_next(AVInputFormat* @d)
        {
            return av_input_video_device_next_fptr(@d);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOutputFormat* av_output_audio_device_next_delegate(AVOutputFormat* @d);
        private static av_output_audio_device_next_delegate av_output_audio_device_next_fptr = (AVOutputFormat* @d) =>
        {
            av_output_audio_device_next_fptr = GetFunctionDelegate<av_output_audio_device_next_delegate>(GetOrLoadLibrary("avdevice", 57), "av_output_audio_device_next");
            if (av_output_audio_device_next_fptr == null)
            {
                av_output_audio_device_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_output_audio_device_next is not supported on this platform.");
                };
            }
            return av_output_audio_device_next_fptr(@d);
        };
        /// <summary>Audio output devices iterator.</summary>
        public static AVOutputFormat* av_output_audio_device_next(AVOutputFormat* @d)
        {
            return av_output_audio_device_next_fptr(@d);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOutputFormat* av_output_video_device_next_delegate(AVOutputFormat* @d);
        private static av_output_video_device_next_delegate av_output_video_device_next_fptr = (AVOutputFormat* @d) =>
        {
            av_output_video_device_next_fptr = GetFunctionDelegate<av_output_video_device_next_delegate>(GetOrLoadLibrary("avdevice", 57), "av_output_video_device_next");
            if (av_output_video_device_next_fptr == null)
            {
                av_output_video_device_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_output_video_device_next is not supported on this platform.");
                };
            }
            return av_output_video_device_next_fptr(@d);
        };
        /// <summary>Video output devices iterator.</summary>
        public static AVOutputFormat* av_output_video_device_next(AVOutputFormat* @d)
        {
            return av_output_video_device_next_fptr(@d);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avdevice_app_to_dev_control_message_delegate(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size);
        private static avdevice_app_to_dev_control_message_delegate avdevice_app_to_dev_control_message_fptr = (AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size) =>
        {
            avdevice_app_to_dev_control_message_fptr = GetFunctionDelegate<avdevice_app_to_dev_control_message_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_app_to_dev_control_message");
            if (avdevice_app_to_dev_control_message_fptr == null)
            {
                avdevice_app_to_dev_control_message_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_app_to_dev_control_message is not supported on this platform.");
                };
            }
            return avdevice_app_to_dev_control_message_fptr(@s, @type, @data, @data_size);
        };
        /// <summary>Send control message from application to device.</summary>
        /// <param name="s">device context.</param>
        /// <param name="type">message type.</param>
        /// <param name="data">message data. Exact type depends on message type.</param>
        /// <param name="data_size">size of message data.</param>
        public static int avdevice_app_to_dev_control_message(AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size)
        {
            return avdevice_app_to_dev_control_message_fptr(@s, @type, @data, @data_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avdevice_capabilities_create_delegate(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options);
        private static avdevice_capabilities_create_delegate avdevice_capabilities_create_fptr = (AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options) =>
        {
            avdevice_capabilities_create_fptr = GetFunctionDelegate<avdevice_capabilities_create_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_capabilities_create");
            if (avdevice_capabilities_create_fptr == null)
            {
                avdevice_capabilities_create_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_capabilities_create is not supported on this platform.");
                };
            }
            return avdevice_capabilities_create_fptr(@caps, @s, @device_options);
        };
        /// <summary>Initialize capabilities probing API based on AVOption API.</summary>
        /// <param name="caps">Device capabilities data. Pointer to a NULL pointer must be passed.</param>
        /// <param name="s">Context of the device.</param>
        /// <param name="device_options">An AVDictionary filled with device-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
        public static int avdevice_capabilities_create(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s, AVDictionary** @device_options)
        {
            return avdevice_capabilities_create_fptr(@caps, @s, @device_options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avdevice_capabilities_free_delegate(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s);
        private static avdevice_capabilities_free_delegate avdevice_capabilities_free_fptr = (AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s) =>
        {
            avdevice_capabilities_free_fptr = GetFunctionDelegate<avdevice_capabilities_free_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_capabilities_free");
            if (avdevice_capabilities_free_fptr == null)
            {
                avdevice_capabilities_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_capabilities_free is not supported on this platform.");
                };
            }
            avdevice_capabilities_free_fptr(@caps, @s);
        };
        /// <summary>Free resources created by avdevice_capabilities_create()</summary>
        /// <param name="caps">Device capabilities data to be freed.</param>
        /// <param name="s">Context of the device.</param>
        public static void avdevice_capabilities_free(AVDeviceCapabilitiesQuery** @caps, AVFormatContext* @s)
        {
            avdevice_capabilities_free_fptr(@caps, @s);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avdevice_configuration_delegate();
        private static avdevice_configuration_delegate avdevice_configuration_fptr = () =>
        {
            avdevice_configuration_fptr = GetFunctionDelegate<avdevice_configuration_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_configuration");
            if (avdevice_configuration_fptr == null)
            {
                avdevice_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_configuration is not supported on this platform.");
                };
            }
            return avdevice_configuration_fptr();
        };
        /// <summary>Return the libavdevice build-time configuration.</summary>
        public static string avdevice_configuration()
        {
            return avdevice_configuration_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avdevice_dev_to_app_control_message_delegate(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size);
        private static avdevice_dev_to_app_control_message_delegate avdevice_dev_to_app_control_message_fptr = (AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size) =>
        {
            avdevice_dev_to_app_control_message_fptr = GetFunctionDelegate<avdevice_dev_to_app_control_message_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_dev_to_app_control_message");
            if (avdevice_dev_to_app_control_message_fptr == null)
            {
                avdevice_dev_to_app_control_message_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_dev_to_app_control_message is not supported on this platform.");
                };
            }
            return avdevice_dev_to_app_control_message_fptr(@s, @type, @data, @data_size);
        };
        /// <summary>Send control message from device to application.</summary>
        /// <param name="s">device context.</param>
        /// <param name="type">message type.</param>
        /// <param name="data">message data. Can be NULL.</param>
        /// <param name="data_size">size of message data.</param>
        public static int avdevice_dev_to_app_control_message(AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size)
        {
            return avdevice_dev_to_app_control_message_fptr(@s, @type, @data, @data_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avdevice_free_list_devices_delegate(AVDeviceInfoList** @device_list);
        private static avdevice_free_list_devices_delegate avdevice_free_list_devices_fptr = (AVDeviceInfoList** @device_list) =>
        {
            avdevice_free_list_devices_fptr = GetFunctionDelegate<avdevice_free_list_devices_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_free_list_devices");
            if (avdevice_free_list_devices_fptr == null)
            {
                avdevice_free_list_devices_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_free_list_devices is not supported on this platform.");
                };
            }
            avdevice_free_list_devices_fptr(@device_list);
        };
        /// <summary>Convenient function to free result of avdevice_list_devices().</summary>
        public static void avdevice_free_list_devices(AVDeviceInfoList** @device_list)
        {
            avdevice_free_list_devices_fptr(@device_list);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avdevice_license_delegate();
        private static avdevice_license_delegate avdevice_license_fptr = () =>
        {
            avdevice_license_fptr = GetFunctionDelegate<avdevice_license_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_license");
            if (avdevice_license_fptr == null)
            {
                avdevice_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_license is not supported on this platform.");
                };
            }
            return avdevice_license_fptr();
        };
        /// <summary>Return the libavdevice license.</summary>
        public static string avdevice_license()
        {
            return avdevice_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avdevice_list_devices_delegate(AVFormatContext* @s, AVDeviceInfoList** @device_list);
        private static avdevice_list_devices_delegate avdevice_list_devices_fptr = (AVFormatContext* @s, AVDeviceInfoList** @device_list) =>
        {
            avdevice_list_devices_fptr = GetFunctionDelegate<avdevice_list_devices_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_list_devices");
            if (avdevice_list_devices_fptr == null)
            {
                avdevice_list_devices_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_list_devices is not supported on this platform.");
                };
            }
            return avdevice_list_devices_fptr(@s, @device_list);
        };
        /// <summary>List devices.</summary>
        /// <param name="s">device context.</param>
        /// <param name="device_list">list of autodetected devices.</param>
        public static int avdevice_list_devices(AVFormatContext* @s, AVDeviceInfoList** @device_list)
        {
            return avdevice_list_devices_fptr(@s, @device_list);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avdevice_list_input_sources_delegate(AVInputFormat* @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        private static avdevice_list_input_sources_delegate avdevice_list_input_sources_fptr = (AVInputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) =>
        {
            avdevice_list_input_sources_fptr = GetFunctionDelegate<avdevice_list_input_sources_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_list_input_sources");
            if (avdevice_list_input_sources_fptr == null)
            {
                avdevice_list_input_sources_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_list_input_sources is not supported on this platform.");
                };
            }
            return avdevice_list_input_sources_fptr(@device, @device_name, @device_options, @device_list);
        };
        /// <summary>List devices.</summary>
        /// <param name="device">device format. May be NULL if device name is set.</param>
        /// <param name="device_name">device name. May be NULL if device format is set.</param>
        /// <param name="device_options">An AVDictionary filled with device-private options. May be NULL. The same options must be passed later to avformat_write_header() for output devices or avformat_open_input() for input devices, or at any other place that affects device-private options.</param>
        /// <param name="device_list">list of autodetected devices</param>
        public static int avdevice_list_input_sources(AVInputFormat* @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list)
        {
            return avdevice_list_input_sources_fptr(@device, @device_name, @device_options, @device_list);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avdevice_list_output_sinks_delegate(AVOutputFormat* @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list);
        private static avdevice_list_output_sinks_delegate avdevice_list_output_sinks_fptr = (AVOutputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) =>
        {
            avdevice_list_output_sinks_fptr = GetFunctionDelegate<avdevice_list_output_sinks_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_list_output_sinks");
            if (avdevice_list_output_sinks_fptr == null)
            {
                avdevice_list_output_sinks_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_list_output_sinks is not supported on this platform.");
                };
            }
            return avdevice_list_output_sinks_fptr(@device, @device_name, @device_options, @device_list);
        };
        public static int avdevice_list_output_sinks(AVOutputFormat* @device, [MarshalAs(UnmanagedType.LPStr)] string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list)
        {
            return avdevice_list_output_sinks_fptr(@device, @device_name, @device_options, @device_list);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avdevice_register_all_delegate();
        private static avdevice_register_all_delegate avdevice_register_all_fptr = () =>
        {
            avdevice_register_all_fptr = GetFunctionDelegate<avdevice_register_all_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_register_all");
            if (avdevice_register_all_fptr == null)
            {
                avdevice_register_all_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_register_all is not supported on this platform.");
                };
            }
            avdevice_register_all_fptr();
        };
        /// <summary>Initialize libavdevice and register all the input and output devices.</summary>
        public static void avdevice_register_all()
        {
            avdevice_register_all_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avdevice_version_delegate();
        private static avdevice_version_delegate avdevice_version_fptr = () =>
        {
            avdevice_version_fptr = GetFunctionDelegate<avdevice_version_delegate>(GetOrLoadLibrary("avdevice", 57), "avdevice_version");
            if (avdevice_version_fptr == null)
            {
                avdevice_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avdevice_version is not supported on this platform.");
                };
            }
            return avdevice_version_fptr();
        };
        /// <summary>Return the LIBAVDEVICE_VERSION_INT constant.</summary>
        public static uint avdevice_version()
        {
            return avdevice_version_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVABufferSinkParams* av_abuffersink_params_alloc_delegate();
        private static av_abuffersink_params_alloc_delegate av_abuffersink_params_alloc_fptr = () =>
        {
            av_abuffersink_params_alloc_fptr = GetFunctionDelegate<av_abuffersink_params_alloc_delegate>(GetOrLoadLibrary("avfilter", 6), "av_abuffersink_params_alloc");
            if (av_abuffersink_params_alloc_fptr == null)
            {
                av_abuffersink_params_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_abuffersink_params_alloc is not supported on this platform.");
                };
            }
            return av_abuffersink_params_alloc_fptr();
        };
        /// <summary>Create an AVABufferSinkParams structure.</summary>
        public static AVABufferSinkParams* av_abuffersink_params_alloc()
        {
            return av_abuffersink_params_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong av_buffersink_get_channel_layout_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_channel_layout_delegate av_buffersink_get_channel_layout_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_channel_layout_fptr = GetFunctionDelegate<av_buffersink_get_channel_layout_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_channel_layout");
            if (av_buffersink_get_channel_layout_fptr == null)
            {
                av_buffersink_get_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_channel_layout is not supported on this platform.");
                };
            }
            return av_buffersink_get_channel_layout_fptr(@ctx);
        };
        public static ulong av_buffersink_get_channel_layout(AVFilterContext* @ctx)
        {
            return av_buffersink_get_channel_layout_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_channels_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_channels_delegate av_buffersink_get_channels_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_channels_fptr = GetFunctionDelegate<av_buffersink_get_channels_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_channels");
            if (av_buffersink_get_channels_fptr == null)
            {
                av_buffersink_get_channels_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_channels is not supported on this platform.");
                };
            }
            return av_buffersink_get_channels_fptr(@ctx);
        };
        public static int av_buffersink_get_channels(AVFilterContext* @ctx)
        {
            return av_buffersink_get_channels_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_format_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_format_delegate av_buffersink_get_format_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_format_fptr = GetFunctionDelegate<av_buffersink_get_format_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_format");
            if (av_buffersink_get_format_fptr == null)
            {
                av_buffersink_get_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_format is not supported on this platform.");
                };
            }
            return av_buffersink_get_format_fptr(@ctx);
        };
        public static int av_buffersink_get_format(AVFilterContext* @ctx)
        {
            return av_buffersink_get_format_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
        private static av_buffersink_get_frame_delegate av_buffersink_get_frame_fptr = (AVFilterContext* @ctx, AVFrame* @frame) =>
        {
            av_buffersink_get_frame_fptr = GetFunctionDelegate<av_buffersink_get_frame_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_frame");
            if (av_buffersink_get_frame_fptr == null)
            {
                av_buffersink_get_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_frame is not supported on this platform.");
                };
            }
            return av_buffersink_get_frame_fptr(@ctx, @frame);
        };
        /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
        /// <param name="ctx">pointer to a context of a buffersink or abuffersink AVFilter.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
        public static int av_buffersink_get_frame(AVFilterContext* @ctx, AVFrame* @frame)
        {
            return av_buffersink_get_frame_fptr(@ctx, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_frame_flags_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @flags);
        private static av_buffersink_get_frame_flags_delegate av_buffersink_get_frame_flags_fptr = (AVFilterContext* @ctx, AVFrame* @frame, int @flags) =>
        {
            av_buffersink_get_frame_flags_fptr = GetFunctionDelegate<av_buffersink_get_frame_flags_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_frame_flags");
            if (av_buffersink_get_frame_flags_fptr == null)
            {
                av_buffersink_get_frame_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_frame_flags is not supported on this platform.");
                };
            }
            return av_buffersink_get_frame_flags_fptr(@ctx, @frame, @flags);
        };
        /// <summary>Get a frame with filtered data from sink and put it in frame.</summary>
        /// <param name="ctx">pointer to a buffersink or abuffersink filter context.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free()</param>
        /// <param name="flags">a combination of AV_BUFFERSINK_FLAG_* flags</param>
        public static int av_buffersink_get_frame_flags(AVFilterContext* @ctx, AVFrame* @frame, int @flags)
        {
            return av_buffersink_get_frame_flags_fptr(@ctx, @frame, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_buffersink_get_frame_rate_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_frame_rate_delegate av_buffersink_get_frame_rate_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_frame_rate_fptr = GetFunctionDelegate<av_buffersink_get_frame_rate_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_frame_rate");
            if (av_buffersink_get_frame_rate_fptr == null)
            {
                av_buffersink_get_frame_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_frame_rate is not supported on this platform.");
                };
            }
            return av_buffersink_get_frame_rate_fptr(@ctx);
        };
        public static AVRational av_buffersink_get_frame_rate(AVFilterContext* @ctx)
        {
            return av_buffersink_get_frame_rate_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_h_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_h_delegate av_buffersink_get_h_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_h_fptr = GetFunctionDelegate<av_buffersink_get_h_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_h");
            if (av_buffersink_get_h_fptr == null)
            {
                av_buffersink_get_h_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_h is not supported on this platform.");
                };
            }
            return av_buffersink_get_h_fptr(@ctx);
        };
        public static int av_buffersink_get_h(AVFilterContext* @ctx)
        {
            return av_buffersink_get_h_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_buffersink_get_hw_frames_ctx_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_hw_frames_ctx_delegate av_buffersink_get_hw_frames_ctx_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_hw_frames_ctx_fptr = GetFunctionDelegate<av_buffersink_get_hw_frames_ctx_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_hw_frames_ctx");
            if (av_buffersink_get_hw_frames_ctx_fptr == null)
            {
                av_buffersink_get_hw_frames_ctx_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_hw_frames_ctx is not supported on this platform.");
                };
            }
            return av_buffersink_get_hw_frames_ctx_fptr(@ctx);
        };
        public static AVBufferRef* av_buffersink_get_hw_frames_ctx(AVFilterContext* @ctx)
        {
            return av_buffersink_get_hw_frames_ctx_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_buffersink_get_sample_aspect_ratio_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_sample_aspect_ratio_delegate av_buffersink_get_sample_aspect_ratio_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_sample_aspect_ratio_fptr = GetFunctionDelegate<av_buffersink_get_sample_aspect_ratio_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_sample_aspect_ratio");
            if (av_buffersink_get_sample_aspect_ratio_fptr == null)
            {
                av_buffersink_get_sample_aspect_ratio_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_sample_aspect_ratio is not supported on this platform.");
                };
            }
            return av_buffersink_get_sample_aspect_ratio_fptr(@ctx);
        };
        public static AVRational av_buffersink_get_sample_aspect_ratio(AVFilterContext* @ctx)
        {
            return av_buffersink_get_sample_aspect_ratio_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_sample_rate_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_sample_rate_delegate av_buffersink_get_sample_rate_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_sample_rate_fptr = GetFunctionDelegate<av_buffersink_get_sample_rate_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_sample_rate");
            if (av_buffersink_get_sample_rate_fptr == null)
            {
                av_buffersink_get_sample_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_sample_rate is not supported on this platform.");
                };
            }
            return av_buffersink_get_sample_rate_fptr(@ctx);
        };
        public static int av_buffersink_get_sample_rate(AVFilterContext* @ctx)
        {
            return av_buffersink_get_sample_rate_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_samples_delegate(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples);
        private static av_buffersink_get_samples_delegate av_buffersink_get_samples_fptr = (AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples) =>
        {
            av_buffersink_get_samples_fptr = GetFunctionDelegate<av_buffersink_get_samples_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_samples");
            if (av_buffersink_get_samples_fptr == null)
            {
                av_buffersink_get_samples_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_samples is not supported on this platform.");
                };
            }
            return av_buffersink_get_samples_fptr(@ctx, @frame, @nb_samples);
        };
        /// <summary>Same as av_buffersink_get_frame(), but with the ability to specify the number of samples read. This function is less efficient than av_buffersink_get_frame(), because it copies the data around.</summary>
        /// <param name="ctx">pointer to a context of the abuffersink AVFilter.</param>
        /// <param name="frame">pointer to an allocated frame that will be filled with data. The data must be freed using av_frame_unref() / av_frame_free() frame will contain exactly nb_samples audio samples, except at the end of stream, when it can contain less than nb_samples.</param>
        public static int av_buffersink_get_samples(AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples)
        {
            return av_buffersink_get_samples_fptr(@ctx, @frame, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_buffersink_get_time_base_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_time_base_delegate av_buffersink_get_time_base_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_time_base_fptr = GetFunctionDelegate<av_buffersink_get_time_base_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_time_base");
            if (av_buffersink_get_time_base_fptr == null)
            {
                av_buffersink_get_time_base_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_time_base is not supported on this platform.");
                };
            }
            return av_buffersink_get_time_base_fptr(@ctx);
        };
        public static AVRational av_buffersink_get_time_base(AVFilterContext* @ctx)
        {
            return av_buffersink_get_time_base_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVMediaType av_buffersink_get_type_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_type_delegate av_buffersink_get_type_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_type_fptr = GetFunctionDelegate<av_buffersink_get_type_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_type");
            if (av_buffersink_get_type_fptr == null)
            {
                av_buffersink_get_type_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_type is not supported on this platform.");
                };
            }
            return av_buffersink_get_type_fptr(@ctx);
        };
        /// <summary>Get the properties of the stream @{</summary>
        public static AVMediaType av_buffersink_get_type(AVFilterContext* @ctx)
        {
            return av_buffersink_get_type_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersink_get_w_delegate(AVFilterContext* @ctx);
        private static av_buffersink_get_w_delegate av_buffersink_get_w_fptr = (AVFilterContext* @ctx) =>
        {
            av_buffersink_get_w_fptr = GetFunctionDelegate<av_buffersink_get_w_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_get_w");
            if (av_buffersink_get_w_fptr == null)
            {
                av_buffersink_get_w_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_get_w is not supported on this platform.");
                };
            }
            return av_buffersink_get_w_fptr(@ctx);
        };
        public static int av_buffersink_get_w(AVFilterContext* @ctx)
        {
            return av_buffersink_get_w_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferSinkParams* av_buffersink_params_alloc_delegate();
        private static av_buffersink_params_alloc_delegate av_buffersink_params_alloc_fptr = () =>
        {
            av_buffersink_params_alloc_fptr = GetFunctionDelegate<av_buffersink_params_alloc_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_params_alloc");
            if (av_buffersink_params_alloc_fptr == null)
            {
                av_buffersink_params_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_params_alloc is not supported on this platform.");
                };
            }
            return av_buffersink_params_alloc_fptr();
        };
        /// <summary>Create an AVBufferSinkParams structure.</summary>
        public static AVBufferSinkParams* av_buffersink_params_alloc()
        {
            return av_buffersink_params_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_buffersink_set_frame_size_delegate(AVFilterContext* @ctx, uint @frame_size);
        private static av_buffersink_set_frame_size_delegate av_buffersink_set_frame_size_fptr = (AVFilterContext* @ctx, uint @frame_size) =>
        {
            av_buffersink_set_frame_size_fptr = GetFunctionDelegate<av_buffersink_set_frame_size_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersink_set_frame_size");
            if (av_buffersink_set_frame_size_fptr == null)
            {
                av_buffersink_set_frame_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersink_set_frame_size is not supported on this platform.");
                };
            }
            av_buffersink_set_frame_size_fptr(@ctx, @frame_size);
        };
        /// <summary>Set the frame size for an audio buffer sink.</summary>
        public static void av_buffersink_set_frame_size(AVFilterContext* @ctx, uint @frame_size)
        {
            av_buffersink_set_frame_size_fptr(@ctx, @frame_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersrc_add_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
        private static av_buffersrc_add_frame_delegate av_buffersrc_add_frame_fptr = (AVFilterContext* @ctx, AVFrame* @frame) =>
        {
            av_buffersrc_add_frame_fptr = GetFunctionDelegate<av_buffersrc_add_frame_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_add_frame");
            if (av_buffersrc_add_frame_fptr == null)
            {
                av_buffersrc_add_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_add_frame is not supported on this platform.");
                };
            }
            return av_buffersrc_add_frame_fptr(@ctx, @frame);
        };
        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="ctx">an instance of the buffersrc filter</param>
        /// <param name="frame">frame to be added. If the frame is reference counted, this function will take ownership of the reference(s) and reset the frame. Otherwise the frame data will be copied. If this function returns an error, the input frame is not touched.</param>
        public static int av_buffersrc_add_frame(AVFilterContext* @ctx, AVFrame* @frame)
        {
            return av_buffersrc_add_frame_fptr(@ctx, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersrc_add_frame_flags_delegate(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags);
        private static av_buffersrc_add_frame_flags_delegate av_buffersrc_add_frame_flags_fptr = (AVFilterContext* @buffer_src, AVFrame* @frame, int @flags) =>
        {
            av_buffersrc_add_frame_flags_fptr = GetFunctionDelegate<av_buffersrc_add_frame_flags_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_add_frame_flags");
            if (av_buffersrc_add_frame_flags_fptr == null)
            {
                av_buffersrc_add_frame_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_add_frame_flags is not supported on this platform.");
                };
            }
            return av_buffersrc_add_frame_flags_fptr(@buffer_src, @frame, @flags);
        };
        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="buffer_src">pointer to a buffer source context</param>
        /// <param name="frame">a frame, or NULL to mark EOF</param>
        /// <param name="flags">a combination of AV_BUFFERSRC_FLAG_*</param>
        public static int av_buffersrc_add_frame_flags(AVFilterContext* @buffer_src, AVFrame* @frame, int @flags)
        {
            return av_buffersrc_add_frame_flags_fptr(@buffer_src, @frame, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersrc_close_delegate(AVFilterContext* @ctx, long @pts, uint @flags);
        private static av_buffersrc_close_delegate av_buffersrc_close_fptr = (AVFilterContext* @ctx, long @pts, uint @flags) =>
        {
            av_buffersrc_close_fptr = GetFunctionDelegate<av_buffersrc_close_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_close");
            if (av_buffersrc_close_fptr == null)
            {
                av_buffersrc_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_close is not supported on this platform.");
                };
            }
            return av_buffersrc_close_fptr(@ctx, @pts, @flags);
        };
        /// <summary>Close the buffer source after EOF.</summary>
        public static int av_buffersrc_close(AVFilterContext* @ctx, long @pts, uint @flags)
        {
            return av_buffersrc_close_fptr(@ctx, @pts, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_buffersrc_get_nb_failed_requests_delegate(AVFilterContext* @buffer_src);
        private static av_buffersrc_get_nb_failed_requests_delegate av_buffersrc_get_nb_failed_requests_fptr = (AVFilterContext* @buffer_src) =>
        {
            av_buffersrc_get_nb_failed_requests_fptr = GetFunctionDelegate<av_buffersrc_get_nb_failed_requests_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_get_nb_failed_requests");
            if (av_buffersrc_get_nb_failed_requests_fptr == null)
            {
                av_buffersrc_get_nb_failed_requests_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_get_nb_failed_requests is not supported on this platform.");
                };
            }
            return av_buffersrc_get_nb_failed_requests_fptr(@buffer_src);
        };
        /// <summary>Get the number of failed requests.</summary>
        public static uint av_buffersrc_get_nb_failed_requests(AVFilterContext* @buffer_src)
        {
            return av_buffersrc_get_nb_failed_requests_fptr(@buffer_src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferSrcParameters* av_buffersrc_parameters_alloc_delegate();
        private static av_buffersrc_parameters_alloc_delegate av_buffersrc_parameters_alloc_fptr = () =>
        {
            av_buffersrc_parameters_alloc_fptr = GetFunctionDelegate<av_buffersrc_parameters_alloc_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_parameters_alloc");
            if (av_buffersrc_parameters_alloc_fptr == null)
            {
                av_buffersrc_parameters_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_parameters_alloc is not supported on this platform.");
                };
            }
            return av_buffersrc_parameters_alloc_fptr();
        };
        /// <summary>Allocate a new AVBufferSrcParameters instance. It should be freed by the caller with av_free().</summary>
        public static AVBufferSrcParameters* av_buffersrc_parameters_alloc()
        {
            return av_buffersrc_parameters_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersrc_parameters_set_delegate(AVFilterContext* @ctx, AVBufferSrcParameters* @param);
        private static av_buffersrc_parameters_set_delegate av_buffersrc_parameters_set_fptr = (AVFilterContext* @ctx, AVBufferSrcParameters* @param) =>
        {
            av_buffersrc_parameters_set_fptr = GetFunctionDelegate<av_buffersrc_parameters_set_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_parameters_set");
            if (av_buffersrc_parameters_set_fptr == null)
            {
                av_buffersrc_parameters_set_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_parameters_set is not supported on this platform.");
                };
            }
            return av_buffersrc_parameters_set_fptr(@ctx, @param);
        };
        /// <summary>Initialize the buffersrc or abuffersrc filter with the provided parameters. This function may be called multiple times, the later calls override the previous ones. Some of the parameters may also be set through AVOptions, then whatever method is used last takes precedence.</summary>
        /// <param name="ctx">an instance of the buffersrc or abuffersrc filter</param>
        /// <param name="param">the stream parameters. The frames later passed to this filter must conform to those parameters. All the allocated fields in param remain owned by the caller, libavfilter will make internal copies or references when necessary.</param>
        public static int av_buffersrc_parameters_set(AVFilterContext* @ctx, AVBufferSrcParameters* @param)
        {
            return av_buffersrc_parameters_set_fptr(@ctx, @param);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffersrc_write_frame_delegate(AVFilterContext* @ctx, AVFrame* @frame);
        private static av_buffersrc_write_frame_delegate av_buffersrc_write_frame_fptr = (AVFilterContext* @ctx, AVFrame* @frame) =>
        {
            av_buffersrc_write_frame_fptr = GetFunctionDelegate<av_buffersrc_write_frame_delegate>(GetOrLoadLibrary("avfilter", 6), "av_buffersrc_write_frame");
            if (av_buffersrc_write_frame_fptr == null)
            {
                av_buffersrc_write_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffersrc_write_frame is not supported on this platform.");
                };
            }
            return av_buffersrc_write_frame_fptr(@ctx, @frame);
        };
        /// <summary>Add a frame to the buffer source.</summary>
        /// <param name="ctx">an instance of the buffersrc filter</param>
        /// <param name="frame">frame to be added. If the frame is reference counted, this function will make a new reference to it. Otherwise the frame data will be copied.</param>
        public static int av_buffersrc_write_frame(AVFilterContext* @ctx, AVFrame* @frame)
        {
            return av_buffersrc_write_frame_fptr(@ctx, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilter** av_filter_next_delegate(AVFilter** @filter);
        private static av_filter_next_delegate av_filter_next_fptr = (AVFilter** @filter) =>
        {
            av_filter_next_fptr = GetFunctionDelegate<av_filter_next_delegate>(GetOrLoadLibrary("avfilter", 6), "av_filter_next");
            if (av_filter_next_fptr == null)
            {
                av_filter_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_filter_next is not supported on this platform.");
                };
            }
            return av_filter_next_fptr(@filter);
        };
        /// <summary>If filter is NULL, returns a pointer to the first registered filter pointer, if filter is non-NULL, returns the next pointer after filter. If the returned pointer points to NULL, the last registered filter was already reached.</summary>
        [Obsolete("use avfilter_next()")]
        public static AVFilter** av_filter_next(AVFilter** @filter)
        {
            return av_filter_next_fptr(@filter);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_config_links_delegate(AVFilterContext* @filter);
        private static avfilter_config_links_delegate avfilter_config_links_fptr = (AVFilterContext* @filter) =>
        {
            avfilter_config_links_fptr = GetFunctionDelegate<avfilter_config_links_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_config_links");
            if (avfilter_config_links_fptr == null)
            {
                avfilter_config_links_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_config_links is not supported on this platform.");
                };
            }
            return avfilter_config_links_fptr(@filter);
        };
        /// <summary>Negotiate the media format, dimensions, etc of all inputs to a filter.</summary>
        /// <param name="filter">the filter to negotiate the properties for its inputs</param>
        public static int avfilter_config_links(AVFilterContext* @filter)
        {
            return avfilter_config_links_fptr(@filter);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avfilter_configuration_delegate();
        private static avfilter_configuration_delegate avfilter_configuration_fptr = () =>
        {
            avfilter_configuration_fptr = GetFunctionDelegate<avfilter_configuration_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_configuration");
            if (avfilter_configuration_fptr == null)
            {
                avfilter_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_configuration is not supported on this platform.");
                };
            }
            return avfilter_configuration_fptr();
        };
        /// <summary>Return the libavfilter build-time configuration.</summary>
        public static string avfilter_configuration()
        {
            return avfilter_configuration_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_free_delegate(AVFilterContext* @filter);
        private static avfilter_free_delegate avfilter_free_fptr = (AVFilterContext* @filter) =>
        {
            avfilter_free_fptr = GetFunctionDelegate<avfilter_free_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_free");
            if (avfilter_free_fptr == null)
            {
                avfilter_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_free is not supported on this platform.");
                };
            }
            avfilter_free_fptr(@filter);
        };
        /// <summary>Free a filter context. This will also remove the filter from its filtergraph&apos;s list of filters.</summary>
        /// <param name="filter">the filter to free</param>
        public static void avfilter_free(AVFilterContext* @filter)
        {
            avfilter_free_fptr(@filter);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilter* avfilter_get_by_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static avfilter_get_by_name_delegate avfilter_get_by_name_fptr = (string @name) =>
        {
            avfilter_get_by_name_fptr = GetFunctionDelegate<avfilter_get_by_name_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_get_by_name");
            if (avfilter_get_by_name_fptr == null)
            {
                avfilter_get_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_get_by_name is not supported on this platform.");
                };
            }
            return avfilter_get_by_name_fptr(@name);
        };
        public static AVFilter* avfilter_get_by_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return avfilter_get_by_name_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* avfilter_get_class_delegate();
        private static avfilter_get_class_delegate avfilter_get_class_fptr = () =>
        {
            avfilter_get_class_fptr = GetFunctionDelegate<avfilter_get_class_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_get_class");
            if (avfilter_get_class_fptr == null)
            {
                avfilter_get_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_get_class is not supported on this platform.");
                };
            }
            return avfilter_get_class_fptr();
        };
        /// <summary>Returns AVClass for AVFilterContext.</summary>
        public static AVClass* avfilter_get_class()
        {
            return avfilter_get_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_add_filter_delegate(AVFilterGraph* @graphctx, AVFilterContext* @filter);
        private static avfilter_graph_add_filter_delegate avfilter_graph_add_filter_fptr = (AVFilterGraph* @graphctx, AVFilterContext* @filter) =>
        {
            avfilter_graph_add_filter_fptr = GetFunctionDelegate<avfilter_graph_add_filter_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_add_filter");
            if (avfilter_graph_add_filter_fptr == null)
            {
                avfilter_graph_add_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_add_filter is not supported on this platform.");
                };
            }
            return avfilter_graph_add_filter_fptr(@graphctx, @filter);
        };
        /// <summary>Add an existing filter instance to a filter graph.</summary>
        /// <param name="graphctx">the filter graph</param>
        /// <param name="filter">the filter to be added</param>
        [Obsolete("use avfilter_graph_alloc_filter() to allocate a filter in a filter graph")]
        public static int avfilter_graph_add_filter(AVFilterGraph* @graphctx, AVFilterContext* @filter)
        {
            return avfilter_graph_add_filter_fptr(@graphctx, @filter);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilterGraph* avfilter_graph_alloc_delegate();
        private static avfilter_graph_alloc_delegate avfilter_graph_alloc_fptr = () =>
        {
            avfilter_graph_alloc_fptr = GetFunctionDelegate<avfilter_graph_alloc_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_alloc");
            if (avfilter_graph_alloc_fptr == null)
            {
                avfilter_graph_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_alloc is not supported on this platform.");
                };
            }
            return avfilter_graph_alloc_fptr();
        };
        /// <summary>Allocate a filter graph.</summary>
        public static AVFilterGraph* avfilter_graph_alloc()
        {
            return avfilter_graph_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilterContext* avfilter_graph_alloc_filter_delegate(AVFilterGraph* @graph, AVFilter* @filter, [MarshalAs(UnmanagedType.LPStr)] string @name);
        private static avfilter_graph_alloc_filter_delegate avfilter_graph_alloc_filter_fptr = (AVFilterGraph* @graph, AVFilter* @filter, string @name) =>
        {
            avfilter_graph_alloc_filter_fptr = GetFunctionDelegate<avfilter_graph_alloc_filter_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_alloc_filter");
            if (avfilter_graph_alloc_filter_fptr == null)
            {
                avfilter_graph_alloc_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_alloc_filter is not supported on this platform.");
                };
            }
            return avfilter_graph_alloc_filter_fptr(@graph, @filter, @name);
        };
        /// <summary>Create a new filter instance in a filter graph.</summary>
        /// <param name="graph">graph in which the new filter will be used</param>
        /// <param name="filter">the filter to create an instance of</param>
        /// <param name="name">Name to give to the new instance (will be copied to AVFilterContext.name). This may be used by the caller to identify different filters, libavfilter itself assigns no semantics to this parameter. May be NULL.</param>
        public static AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* @graph, AVFilter* @filter, [MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return avfilter_graph_alloc_filter_fptr(@graph, @filter, @name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_config_delegate(AVFilterGraph* @graphctx, void* @log_ctx);
        private static avfilter_graph_config_delegate avfilter_graph_config_fptr = (AVFilterGraph* @graphctx, void* @log_ctx) =>
        {
            avfilter_graph_config_fptr = GetFunctionDelegate<avfilter_graph_config_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_config");
            if (avfilter_graph_config_fptr == null)
            {
                avfilter_graph_config_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_config is not supported on this platform.");
                };
            }
            return avfilter_graph_config_fptr(@graphctx, @log_ctx);
        };
        /// <summary>Check validity and configure all the links and formats in the graph.</summary>
        /// <param name="graphctx">the filter graph</param>
        /// <param name="log_ctx">context used for logging</param>
        public static int avfilter_graph_config(AVFilterGraph* @graphctx, void* @log_ctx)
        {
            return avfilter_graph_config_fptr(@graphctx, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_create_filter_delegate(AVFilterContext** @filt_ctx, AVFilter* @filt, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @args, void* @opaque, AVFilterGraph* @graph_ctx);
        private static avfilter_graph_create_filter_delegate avfilter_graph_create_filter_fptr = (AVFilterContext** @filt_ctx, AVFilter* @filt, string @name, string @args, void* @opaque, AVFilterGraph* @graph_ctx) =>
        {
            avfilter_graph_create_filter_fptr = GetFunctionDelegate<avfilter_graph_create_filter_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_create_filter");
            if (avfilter_graph_create_filter_fptr == null)
            {
                avfilter_graph_create_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_create_filter is not supported on this platform.");
                };
            }
            return avfilter_graph_create_filter_fptr(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
        };
        /// <summary>Create and add a filter instance into an existing graph. The filter instance is created from the filter filt and inited with the parameters args and opaque.</summary>
        /// <param name="name">the instance name to give to the created filter instance</param>
        /// <param name="graph_ctx">the filter graph</param>
        public static int avfilter_graph_create_filter(AVFilterContext** @filt_ctx, AVFilter* @filt, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @args, void* @opaque, AVFilterGraph* @graph_ctx)
        {
            return avfilter_graph_create_filter_fptr(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* avfilter_graph_dump_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @options);
        private static avfilter_graph_dump_delegate avfilter_graph_dump_fptr = (AVFilterGraph* @graph, string @options) =>
        {
            avfilter_graph_dump_fptr = GetFunctionDelegate<avfilter_graph_dump_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_dump");
            if (avfilter_graph_dump_fptr == null)
            {
                avfilter_graph_dump_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_dump is not supported on this platform.");
                };
            }
            return avfilter_graph_dump_fptr(@graph, @options);
        };
        /// <summary>Dump a graph into a human-readable string representation.</summary>
        /// <param name="graph">the graph to dump</param>
        /// <param name="options">formatting options; currently ignored</param>
        public static byte* avfilter_graph_dump(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @options)
        {
            return avfilter_graph_dump_fptr(@graph, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_graph_free_delegate(AVFilterGraph** @graph);
        private static avfilter_graph_free_delegate avfilter_graph_free_fptr = (AVFilterGraph** @graph) =>
        {
            avfilter_graph_free_fptr = GetFunctionDelegate<avfilter_graph_free_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_free");
            if (avfilter_graph_free_fptr == null)
            {
                avfilter_graph_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_free is not supported on this platform.");
                };
            }
            avfilter_graph_free_fptr(@graph);
        };
        /// <summary>Free a graph, destroy its links, and set *graph to NULL. If *graph is NULL, do nothing.</summary>
        public static void avfilter_graph_free(AVFilterGraph** @graph)
        {
            avfilter_graph_free_fptr(@graph);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilterContext* avfilter_graph_get_filter_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @name);
        private static avfilter_graph_get_filter_delegate avfilter_graph_get_filter_fptr = (AVFilterGraph* @graph, string @name) =>
        {
            avfilter_graph_get_filter_fptr = GetFunctionDelegate<avfilter_graph_get_filter_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_get_filter");
            if (avfilter_graph_get_filter_fptr == null)
            {
                avfilter_graph_get_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_get_filter is not supported on this platform.");
                };
            }
            return avfilter_graph_get_filter_fptr(@graph, @name);
        };
        /// <summary>Get a filter instance identified by instance name from graph.</summary>
        /// <param name="graph">filter graph to search through.</param>
        /// <param name="name">filter instance name (should be unique in the graph).</param>
        public static AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return avfilter_graph_get_filter_fptr(@graph, @name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_parse_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx);
        private static avfilter_graph_parse_delegate avfilter_graph_parse_fptr = (AVFilterGraph* @graph, string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx) =>
        {
            avfilter_graph_parse_fptr = GetFunctionDelegate<avfilter_graph_parse_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_parse");
            if (avfilter_graph_parse_fptr == null)
            {
                avfilter_graph_parse_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_parse is not supported on this platform.");
                };
            }
            return avfilter_graph_parse_fptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        };
        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">linked list to the inputs of the graph</param>
        /// <param name="outputs">linked list to the outputs of the graph</param>
        public static int avfilter_graph_parse(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx)
        {
            return avfilter_graph_parse_fptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_parse_ptr_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx);
        private static avfilter_graph_parse_ptr_delegate avfilter_graph_parse_ptr_fptr = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx) =>
        {
            avfilter_graph_parse_ptr_fptr = GetFunctionDelegate<avfilter_graph_parse_ptr_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_parse_ptr");
            if (avfilter_graph_parse_ptr_fptr == null)
            {
                avfilter_graph_parse_ptr_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_parse_ptr is not supported on this platform.");
                };
            }
            return avfilter_graph_parse_ptr_fptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        };
        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">pointer to a linked list to the inputs of the graph, may be NULL. If non-NULL, *inputs is updated to contain the list of open inputs after the parsing, should be freed with avfilter_inout_free().</param>
        /// <param name="outputs">pointer to a linked list to the outputs of the graph, may be NULL. If non-NULL, *outputs is updated to contain the list of open outputs after the parsing, should be freed with avfilter_inout_free().</param>
        public static int avfilter_graph_parse_ptr(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx)
        {
            return avfilter_graph_parse_ptr_fptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_parse2_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs);
        private static avfilter_graph_parse2_delegate avfilter_graph_parse2_fptr = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs) =>
        {
            avfilter_graph_parse2_fptr = GetFunctionDelegate<avfilter_graph_parse2_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_parse2");
            if (avfilter_graph_parse2_fptr == null)
            {
                avfilter_graph_parse2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_parse2 is not supported on this platform.");
                };
            }
            return avfilter_graph_parse2_fptr(@graph, @filters, @inputs, @outputs);
        };
        /// <summary>Add a graph described by a string to a graph.</summary>
        /// <param name="graph">the filter graph where to link the parsed graph context</param>
        /// <param name="filters">string to be parsed</param>
        /// <param name="inputs">a linked list of all free (unlinked) inputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
        /// <param name="outputs">a linked list of all free (unlinked) outputs of the parsed graph will be returned here. It is to be freed by the caller using avfilter_inout_free().</param>
        public static int avfilter_graph_parse2(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs)
        {
            return avfilter_graph_parse2_fptr(@graph, @filters, @inputs, @outputs);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_queue_command_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @target, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, int @flags, double @ts);
        private static avfilter_graph_queue_command_delegate avfilter_graph_queue_command_fptr = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, int @flags, double @ts) =>
        {
            avfilter_graph_queue_command_fptr = GetFunctionDelegate<avfilter_graph_queue_command_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_queue_command");
            if (avfilter_graph_queue_command_fptr == null)
            {
                avfilter_graph_queue_command_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_queue_command is not supported on this platform.");
                };
            }
            return avfilter_graph_queue_command_fptr(@graph, @target, @cmd, @arg, @flags, @ts);
        };
        /// <summary>Queue a command for one or more filter instances.</summary>
        /// <param name="graph">the filter graph</param>
        /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
        /// <param name="cmd">the command to sent, for handling simplicity all commands must be alphanumeric only</param>
        /// <param name="arg">the argument for the command</param>
        /// <param name="ts">time at which the command should be sent to the filter</param>
        public static int avfilter_graph_queue_command(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @target, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, int @flags, double @ts)
        {
            return avfilter_graph_queue_command_fptr(@graph, @target, @cmd, @arg, @flags, @ts);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_request_oldest_delegate(AVFilterGraph* @graph);
        private static avfilter_graph_request_oldest_delegate avfilter_graph_request_oldest_fptr = (AVFilterGraph* @graph) =>
        {
            avfilter_graph_request_oldest_fptr = GetFunctionDelegate<avfilter_graph_request_oldest_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_request_oldest");
            if (avfilter_graph_request_oldest_fptr == null)
            {
                avfilter_graph_request_oldest_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_request_oldest is not supported on this platform.");
                };
            }
            return avfilter_graph_request_oldest_fptr(@graph);
        };
        /// <summary>Request a frame on the oldest sink link.</summary>
        public static int avfilter_graph_request_oldest(AVFilterGraph* @graph)
        {
            return avfilter_graph_request_oldest_fptr(@graph);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_graph_send_command_delegate(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @target, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, byte* @res, int @res_len, int @flags);
        private static avfilter_graph_send_command_delegate avfilter_graph_send_command_fptr = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, byte* @res, int @res_len, int @flags) =>
        {
            avfilter_graph_send_command_fptr = GetFunctionDelegate<avfilter_graph_send_command_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_send_command");
            if (avfilter_graph_send_command_fptr == null)
            {
                avfilter_graph_send_command_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_send_command is not supported on this platform.");
                };
            }
            return avfilter_graph_send_command_fptr(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
        };
        /// <summary>Send a command to one or more filter instances.</summary>
        /// <param name="graph">the filter graph</param>
        /// <param name="target">the filter(s) to which the command should be sent &quot;all&quot; sends to all filters otherwise it can be a filter or filter instance name which will send the command to all matching filters.</param>
        /// <param name="cmd">the command to send, for handling simplicity all commands must be alphanumeric only</param>
        /// <param name="arg">the argument for the command</param>
        /// <param name="res">a buffer with size res_size where the filter(s) can return a response.</param>
        public static int avfilter_graph_send_command(AVFilterGraph* @graph, [MarshalAs(UnmanagedType.LPStr)] string @target, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, byte* @res, int @res_len, int @flags)
        {
            return avfilter_graph_send_command_fptr(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_graph_set_auto_convert_delegate(AVFilterGraph* @graph, uint @flags);
        private static avfilter_graph_set_auto_convert_delegate avfilter_graph_set_auto_convert_fptr = (AVFilterGraph* @graph, uint @flags) =>
        {
            avfilter_graph_set_auto_convert_fptr = GetFunctionDelegate<avfilter_graph_set_auto_convert_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_graph_set_auto_convert");
            if (avfilter_graph_set_auto_convert_fptr == null)
            {
                avfilter_graph_set_auto_convert_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_graph_set_auto_convert is not supported on this platform.");
                };
            }
            avfilter_graph_set_auto_convert_fptr(@graph, @flags);
        };
        /// <summary>Enable or disable automatic format conversion inside the graph.</summary>
        /// <param name="flags">any of the AVFILTER_AUTO_CONVERT_* constants</param>
        public static void avfilter_graph_set_auto_convert(AVFilterGraph* @graph, uint @flags)
        {
            avfilter_graph_set_auto_convert_fptr(@graph, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_init_dict_delegate(AVFilterContext* @ctx, AVDictionary** @options);
        private static avfilter_init_dict_delegate avfilter_init_dict_fptr = (AVFilterContext* @ctx, AVDictionary** @options) =>
        {
            avfilter_init_dict_fptr = GetFunctionDelegate<avfilter_init_dict_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_init_dict");
            if (avfilter_init_dict_fptr == null)
            {
                avfilter_init_dict_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_init_dict is not supported on this platform.");
                };
            }
            return avfilter_init_dict_fptr(@ctx, @options);
        };
        /// <summary>Initialize a filter with the supplied dictionary of options.</summary>
        /// <param name="ctx">uninitialized filter context to initialize</param>
        /// <param name="options">An AVDictionary filled with options for this filter. On return this parameter will be destroyed and replaced with a dict containing options that were not found. This dictionary must be freed by the caller. May be NULL, then this function is equivalent to avfilter_init_str() with the second parameter set to NULL.</param>
        public static int avfilter_init_dict(AVFilterContext* @ctx, AVDictionary** @options)
        {
            return avfilter_init_dict_fptr(@ctx, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_init_filter_delegate(AVFilterContext* @filter, [MarshalAs(UnmanagedType.LPStr)] string @args, void* @opaque);
        private static avfilter_init_filter_delegate avfilter_init_filter_fptr = (AVFilterContext* @filter, string @args, void* @opaque) =>
        {
            avfilter_init_filter_fptr = GetFunctionDelegate<avfilter_init_filter_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_init_filter");
            if (avfilter_init_filter_fptr == null)
            {
                avfilter_init_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_init_filter is not supported on this platform.");
                };
            }
            return avfilter_init_filter_fptr(@filter, @args, @opaque);
        };
        /// <summary>Initialize a filter.</summary>
        /// <param name="filter">the filter to initialize</param>
        /// <param name="args">A string of parameters to use when initializing the filter. The format and meaning of this string varies by filter.</param>
        /// <param name="opaque">Any extra non-string data needed by the filter. The meaning of this parameter varies by filter.</param>
        [Obsolete("")]
        public static int avfilter_init_filter(AVFilterContext* @filter, [MarshalAs(UnmanagedType.LPStr)] string @args, void* @opaque)
        {
            return avfilter_init_filter_fptr(@filter, @args, @opaque);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_init_str_delegate(AVFilterContext* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @args);
        private static avfilter_init_str_delegate avfilter_init_str_fptr = (AVFilterContext* @ctx, string @args) =>
        {
            avfilter_init_str_fptr = GetFunctionDelegate<avfilter_init_str_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_init_str");
            if (avfilter_init_str_fptr == null)
            {
                avfilter_init_str_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_init_str is not supported on this platform.");
                };
            }
            return avfilter_init_str_fptr(@ctx, @args);
        };
        /// <summary>Initialize a filter with the supplied parameters.</summary>
        /// <param name="ctx">uninitialized filter context to initialize</param>
        /// <param name="args">Options to initialize the filter with. This must be a &apos;:&apos;-separated list of options in the &apos;key=value&apos; form. May be NULL if the options have been set directly using the AVOptions API or there are no options that need to be set.</param>
        public static int avfilter_init_str(AVFilterContext* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @args)
        {
            return avfilter_init_str_fptr(@ctx, @args);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilterInOut* avfilter_inout_alloc_delegate();
        private static avfilter_inout_alloc_delegate avfilter_inout_alloc_fptr = () =>
        {
            avfilter_inout_alloc_fptr = GetFunctionDelegate<avfilter_inout_alloc_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_inout_alloc");
            if (avfilter_inout_alloc_fptr == null)
            {
                avfilter_inout_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_inout_alloc is not supported on this platform.");
                };
            }
            return avfilter_inout_alloc_fptr();
        };
        /// <summary>Allocate a single AVFilterInOut entry. Must be freed with avfilter_inout_free().</summary>
        public static AVFilterInOut* avfilter_inout_alloc()
        {
            return avfilter_inout_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_inout_free_delegate(AVFilterInOut** @inout);
        private static avfilter_inout_free_delegate avfilter_inout_free_fptr = (AVFilterInOut** @inout) =>
        {
            avfilter_inout_free_fptr = GetFunctionDelegate<avfilter_inout_free_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_inout_free");
            if (avfilter_inout_free_fptr == null)
            {
                avfilter_inout_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_inout_free is not supported on this platform.");
                };
            }
            avfilter_inout_free_fptr(@inout);
        };
        /// <summary>Free the supplied list of AVFilterInOut and set *inout to NULL. If *inout is NULL, do nothing.</summary>
        public static void avfilter_inout_free(AVFilterInOut** @inout)
        {
            avfilter_inout_free_fptr(@inout);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_insert_filter_delegate(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx);
        private static avfilter_insert_filter_delegate avfilter_insert_filter_fptr = (AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx) =>
        {
            avfilter_insert_filter_fptr = GetFunctionDelegate<avfilter_insert_filter_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_insert_filter");
            if (avfilter_insert_filter_fptr == null)
            {
                avfilter_insert_filter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_insert_filter is not supported on this platform.");
                };
            }
            return avfilter_insert_filter_fptr(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
        };
        /// <summary>Insert a filter in the middle of an existing link.</summary>
        /// <param name="link">the link into which the filter should be inserted</param>
        /// <param name="filt">the filter to be inserted</param>
        /// <param name="filt_srcpad_idx">the input pad on the filter to connect</param>
        /// <param name="filt_dstpad_idx">the output pad on the filter to connect</param>
        public static int avfilter_insert_filter(AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx)
        {
            return avfilter_insert_filter_fptr(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avfilter_license_delegate();
        private static avfilter_license_delegate avfilter_license_fptr = () =>
        {
            avfilter_license_fptr = GetFunctionDelegate<avfilter_license_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_license");
            if (avfilter_license_fptr == null)
            {
                avfilter_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_license is not supported on this platform.");
                };
            }
            return avfilter_license_fptr();
        };
        /// <summary>Return the libavfilter license.</summary>
        public static string avfilter_license()
        {
            return avfilter_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_link_delegate(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad);
        private static avfilter_link_delegate avfilter_link_fptr = (AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad) =>
        {
            avfilter_link_fptr = GetFunctionDelegate<avfilter_link_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_link");
            if (avfilter_link_fptr == null)
            {
                avfilter_link_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_link is not supported on this platform.");
                };
            }
            return avfilter_link_fptr(@src, @srcpad, @dst, @dstpad);
        };
        /// <summary>Link two filters together.</summary>
        /// <param name="src">the source filter</param>
        /// <param name="srcpad">index of the output pad on the source filter</param>
        /// <param name="dst">the destination filter</param>
        /// <param name="dstpad">index of the input pad on the destination filter</param>
        public static int avfilter_link(AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad)
        {
            return avfilter_link_fptr(@src, @srcpad, @dst, @dstpad);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_link_free_delegate(AVFilterLink** @link);
        private static avfilter_link_free_delegate avfilter_link_free_fptr = (AVFilterLink** @link) =>
        {
            avfilter_link_free_fptr = GetFunctionDelegate<avfilter_link_free_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_link_free");
            if (avfilter_link_free_fptr == null)
            {
                avfilter_link_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_link_free is not supported on this platform.");
                };
            }
            avfilter_link_free_fptr(@link);
        };
        /// <summary>Free the link in *link, and set its pointer to NULL.</summary>
        public static void avfilter_link_free(AVFilterLink** @link)
        {
            avfilter_link_free_fptr(@link);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_link_get_channels_delegate(AVFilterLink* @link);
        private static avfilter_link_get_channels_delegate avfilter_link_get_channels_fptr = (AVFilterLink* @link) =>
        {
            avfilter_link_get_channels_fptr = GetFunctionDelegate<avfilter_link_get_channels_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_link_get_channels");
            if (avfilter_link_get_channels_fptr == null)
            {
                avfilter_link_get_channels_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_link_get_channels is not supported on this platform.");
                };
            }
            return avfilter_link_get_channels_fptr(@link);
        };
        /// <summary>Get the number of channels of a link.</summary>
        public static int avfilter_link_get_channels(AVFilterLink* @link)
        {
            return avfilter_link_get_channels_fptr(@link);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_link_set_closed_delegate(AVFilterLink* @link, int @closed);
        private static avfilter_link_set_closed_delegate avfilter_link_set_closed_fptr = (AVFilterLink* @link, int @closed) =>
        {
            avfilter_link_set_closed_fptr = GetFunctionDelegate<avfilter_link_set_closed_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_link_set_closed");
            if (avfilter_link_set_closed_fptr == null)
            {
                avfilter_link_set_closed_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_link_set_closed is not supported on this platform.");
                };
            }
            avfilter_link_set_closed_fptr(@link, @closed);
        };
        /// <summary>Set the closed field of a link.</summary>
        [Obsolete("applications are not supposed to mess with links, they should close the sinks.")]
        public static void avfilter_link_set_closed(AVFilterLink* @link, int @closed)
        {
            avfilter_link_set_closed_fptr(@link, @closed);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFilter* avfilter_next_delegate(AVFilter* @prev);
        private static avfilter_next_delegate avfilter_next_fptr = (AVFilter* @prev) =>
        {
            avfilter_next_fptr = GetFunctionDelegate<avfilter_next_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_next");
            if (avfilter_next_fptr == null)
            {
                avfilter_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_next is not supported on this platform.");
                };
            }
            return avfilter_next_fptr(@prev);
        };
        /// <summary>Iterate over all registered filters.</summary>
        public static AVFilter* avfilter_next(AVFilter* @prev)
        {
            return avfilter_next_fptr(@prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_open_delegate(AVFilterContext** @filter_ctx, AVFilter* @filter, [MarshalAs(UnmanagedType.LPStr)] string @inst_name);
        private static avfilter_open_delegate avfilter_open_fptr = (AVFilterContext** @filter_ctx, AVFilter* @filter, string @inst_name) =>
        {
            avfilter_open_fptr = GetFunctionDelegate<avfilter_open_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_open");
            if (avfilter_open_fptr == null)
            {
                avfilter_open_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_open is not supported on this platform.");
                };
            }
            return avfilter_open_fptr(@filter_ctx, @filter, @inst_name);
        };
        /// <summary>Create a filter instance.</summary>
        /// <param name="filter_ctx">put here a pointer to the created filter context on success, NULL on failure</param>
        /// <param name="filter">the filter to create an instance of</param>
        /// <param name="inst_name">Name to give to the new instance. Can be NULL for none.</param>
        [Obsolete("use avfilter_graph_alloc_filter() instead")]
        public static int avfilter_open(AVFilterContext** @filter_ctx, AVFilter* @filter, [MarshalAs(UnmanagedType.LPStr)] string @inst_name)
        {
            return avfilter_open_fptr(@filter_ctx, @filter, @inst_name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_pad_count_delegate(AVFilterPad* @pads);
        private static avfilter_pad_count_delegate avfilter_pad_count_fptr = (AVFilterPad* @pads) =>
        {
            avfilter_pad_count_fptr = GetFunctionDelegate<avfilter_pad_count_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_pad_count");
            if (avfilter_pad_count_fptr == null)
            {
                avfilter_pad_count_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_pad_count is not supported on this platform.");
                };
            }
            return avfilter_pad_count_fptr(@pads);
        };
        /// <summary>Get the number of elements in a NULL-terminated array of AVFilterPads (e.g. AVFilter.inputs/outputs).</summary>
        public static int avfilter_pad_count(AVFilterPad* @pads)
        {
            return avfilter_pad_count_fptr(@pads);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avfilter_pad_get_name_delegate(AVFilterPad* @pads, int @pad_idx);
        private static avfilter_pad_get_name_delegate avfilter_pad_get_name_fptr = (AVFilterPad* @pads, int @pad_idx) =>
        {
            avfilter_pad_get_name_fptr = GetFunctionDelegate<avfilter_pad_get_name_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_pad_get_name");
            if (avfilter_pad_get_name_fptr == null)
            {
                avfilter_pad_get_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_pad_get_name is not supported on this platform.");
                };
            }
            return avfilter_pad_get_name_fptr(@pads, @pad_idx);
        };
        /// <summary>Get the name of an AVFilterPad.</summary>
        /// <param name="pads">an array of AVFilterPads</param>
        /// <param name="pad_idx">index of the pad in the array it; is the caller&apos;s responsibility to ensure the index is valid</param>
        public static string avfilter_pad_get_name(AVFilterPad* @pads, int @pad_idx)
        {
            return avfilter_pad_get_name_fptr(@pads, @pad_idx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVMediaType avfilter_pad_get_type_delegate(AVFilterPad* @pads, int @pad_idx);
        private static avfilter_pad_get_type_delegate avfilter_pad_get_type_fptr = (AVFilterPad* @pads, int @pad_idx) =>
        {
            avfilter_pad_get_type_fptr = GetFunctionDelegate<avfilter_pad_get_type_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_pad_get_type");
            if (avfilter_pad_get_type_fptr == null)
            {
                avfilter_pad_get_type_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_pad_get_type is not supported on this platform.");
                };
            }
            return avfilter_pad_get_type_fptr(@pads, @pad_idx);
        };
        /// <summary>Get the type of an AVFilterPad.</summary>
        /// <param name="pads">an array of AVFilterPads</param>
        /// <param name="pad_idx">index of the pad in the array; it is the caller&apos;s responsibility to ensure the index is valid</param>
        public static AVMediaType avfilter_pad_get_type(AVFilterPad* @pads, int @pad_idx)
        {
            return avfilter_pad_get_type_fptr(@pads, @pad_idx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_process_command_delegate(AVFilterContext* @filter, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, byte* @res, int @res_len, int @flags);
        private static avfilter_process_command_delegate avfilter_process_command_fptr = (AVFilterContext* @filter, string @cmd, string @arg, byte* @res, int @res_len, int @flags) =>
        {
            avfilter_process_command_fptr = GetFunctionDelegate<avfilter_process_command_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_process_command");
            if (avfilter_process_command_fptr == null)
            {
                avfilter_process_command_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_process_command is not supported on this platform.");
                };
            }
            return avfilter_process_command_fptr(@filter, @cmd, @arg, @res, @res_len, @flags);
        };
        /// <summary>Make the filter instance process a command. It is recommended to use avfilter_graph_send_command().</summary>
        public static int avfilter_process_command(AVFilterContext* @filter, [MarshalAs(UnmanagedType.LPStr)] string @cmd, [MarshalAs(UnmanagedType.LPStr)] string @arg, byte* @res, int @res_len, int @flags)
        {
            return avfilter_process_command_fptr(@filter, @cmd, @arg, @res, @res_len, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avfilter_register_delegate(AVFilter* @filter);
        private static avfilter_register_delegate avfilter_register_fptr = (AVFilter* @filter) =>
        {
            avfilter_register_fptr = GetFunctionDelegate<avfilter_register_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_register");
            if (avfilter_register_fptr == null)
            {
                avfilter_register_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_register is not supported on this platform.");
                };
            }
            return avfilter_register_fptr(@filter);
        };
        /// <summary>Register a filter. This is only needed if you plan to use avfilter_get_by_name later to lookup the AVFilter structure by name. A filter can still by instantiated with avfilter_graph_alloc_filter even if it is not registered.</summary>
        /// <param name="filter">the filter to register</param>
        public static int avfilter_register(AVFilter* @filter)
        {
            return avfilter_register_fptr(@filter);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_register_all_delegate();
        private static avfilter_register_all_delegate avfilter_register_all_fptr = () =>
        {
            avfilter_register_all_fptr = GetFunctionDelegate<avfilter_register_all_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_register_all");
            if (avfilter_register_all_fptr == null)
            {
                avfilter_register_all_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_register_all is not supported on this platform.");
                };
            }
            avfilter_register_all_fptr();
        };
        /// <summary>Initialize the filter system. Register all builtin filters.</summary>
        public static void avfilter_register_all()
        {
            avfilter_register_all_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avfilter_uninit_delegate();
        private static avfilter_uninit_delegate avfilter_uninit_fptr = () =>
        {
            avfilter_uninit_fptr = GetFunctionDelegate<avfilter_uninit_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_uninit");
            if (avfilter_uninit_fptr == null)
            {
                avfilter_uninit_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_uninit is not supported on this platform.");
                };
            }
            avfilter_uninit_fptr();
        };
        /// <summary>Uninitialize the filter system. Unregister all filters.</summary>
        [Obsolete("")]
        public static void avfilter_uninit()
        {
            avfilter_uninit_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avfilter_version_delegate();
        private static avfilter_version_delegate avfilter_version_fptr = () =>
        {
            avfilter_version_fptr = GetFunctionDelegate<avfilter_version_delegate>(GetOrLoadLibrary("avfilter", 6), "avfilter_version");
            if (avfilter_version_fptr == null)
            {
                avfilter_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avfilter_version is not supported on this platform.");
                };
            }
            return avfilter_version_fptr();
        };
        /// <summary>Return the LIBAVFILTER_VERSION_INT constant.</summary>
        public static uint avfilter_version()
        {
            return avfilter_version_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_add_index_entry_delegate(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags);
        private static av_add_index_entry_delegate av_add_index_entry_fptr = (AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags) =>
        {
            av_add_index_entry_fptr = GetFunctionDelegate<av_add_index_entry_delegate>(GetOrLoadLibrary("avformat", 57), "av_add_index_entry");
            if (av_add_index_entry_fptr == null)
            {
                av_add_index_entry_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_add_index_entry is not supported on this platform.");
                };
            }
            return av_add_index_entry_fptr(@st, @pos, @timestamp, @size, @distance, @flags);
        };
        /// <summary>Add an index entry into a sorted list. Update the entry if the list already contains it.</summary>
        /// <param name="timestamp">timestamp in the time base of the given stream</param>
        public static int av_add_index_entry(AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags)
        {
            return av_add_index_entry_fptr(@st, @pos, @timestamp, @size, @distance, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_append_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);
        private static av_append_packet_delegate av_append_packet_fptr = (AVIOContext* @s, AVPacket* @pkt, int @size) =>
        {
            av_append_packet_fptr = GetFunctionDelegate<av_append_packet_delegate>(GetOrLoadLibrary("avformat", 57), "av_append_packet");
            if (av_append_packet_fptr == null)
            {
                av_append_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_append_packet is not supported on this platform.");
                };
            }
            return av_append_packet_fptr(@s, @pkt, @size);
        };
        /// <summary>Read data and append it to the current content of the AVPacket. If pkt-&gt;size is 0 this is identical to av_get_packet. Note that this uses av_grow_packet and thus involves a realloc which is inefficient. Thus this function should only be used when there is no reasonable way to know (an upper bound of) the final size.</summary>
        /// <param name="s">associated IO context</param>
        /// <param name="pkt">packet</param>
        /// <param name="size">amount of data to read</param>
        public static int av_append_packet(AVIOContext* @s, AVPacket* @pkt, int @size)
        {
            return av_append_packet_fptr(@s, @pkt, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_apply_bitstream_filters_delegate(AVCodecContext* @codec, AVPacket* @pkt, AVBitStreamFilterContext* @bsfc);
        private static av_apply_bitstream_filters_delegate av_apply_bitstream_filters_fptr = (AVCodecContext* @codec, AVPacket* @pkt, AVBitStreamFilterContext* @bsfc) =>
        {
            av_apply_bitstream_filters_fptr = GetFunctionDelegate<av_apply_bitstream_filters_delegate>(GetOrLoadLibrary("avformat", 57), "av_apply_bitstream_filters");
            if (av_apply_bitstream_filters_fptr == null)
            {
                av_apply_bitstream_filters_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_apply_bitstream_filters is not supported on this platform.");
                };
            }
            return av_apply_bitstream_filters_fptr(@codec, @pkt, @bsfc);
        };
        /// <summary>Apply a list of bitstream filters to a packet.</summary>
        /// <param name="codec">AVCodecContext, usually from an AVStream</param>
        /// <param name="pkt">the packet to apply filters to. If, on success, the returned packet has size == 0 and side_data_elems == 0, it indicates that the packet should be dropped</param>
        /// <param name="bsfc">a NULL-terminated list of filters to apply</param>
        [Obsolete("")]
        public static int av_apply_bitstream_filters(AVCodecContext* @codec, AVPacket* @pkt, AVBitStreamFilterContext* @bsfc)
        {
            return av_apply_bitstream_filters_fptr(@codec, @pkt, @bsfc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecID av_codec_get_id_delegate(AVCodecTag** @tags, uint @tag);
        private static av_codec_get_id_delegate av_codec_get_id_fptr = (AVCodecTag** @tags, uint @tag) =>
        {
            av_codec_get_id_fptr = GetFunctionDelegate<av_codec_get_id_delegate>(GetOrLoadLibrary("avformat", 57), "av_codec_get_id");
            if (av_codec_get_id_fptr == null)
            {
                av_codec_get_id_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_id is not supported on this platform.");
                };
            }
            return av_codec_get_id_fptr(@tags, @tag);
        };
        /// <summary>Get the AVCodecID for the given codec tag tag. If no codec id is found returns AV_CODEC_ID_NONE.</summary>
        /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="tag">codec tag to match to a codec ID</param>
        public static AVCodecID av_codec_get_id(AVCodecTag** @tags, uint @tag)
        {
            return av_codec_get_id_fptr(@tags, @tag);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_codec_get_tag_delegate(AVCodecTag** @tags, AVCodecID @id);
        private static av_codec_get_tag_delegate av_codec_get_tag_fptr = (AVCodecTag** @tags, AVCodecID @id) =>
        {
            av_codec_get_tag_fptr = GetFunctionDelegate<av_codec_get_tag_delegate>(GetOrLoadLibrary("avformat", 57), "av_codec_get_tag");
            if (av_codec_get_tag_fptr == null)
            {
                av_codec_get_tag_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_tag is not supported on this platform.");
                };
            }
            return av_codec_get_tag_fptr(@tags, @id);
        };
        /// <summary>Get the codec tag for the given codec id id. If no codec tag is found returns 0.</summary>
        /// <param name="tags">list of supported codec_id-codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="id">codec ID to match to a codec tag</param>
        public static uint av_codec_get_tag(AVCodecTag** @tags, AVCodecID @id)
        {
            return av_codec_get_tag_fptr(@tags, @id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_codec_get_tag2_delegate(AVCodecTag** @tags, AVCodecID @id, uint* @tag);
        private static av_codec_get_tag2_delegate av_codec_get_tag2_fptr = (AVCodecTag** @tags, AVCodecID @id, uint* @tag) =>
        {
            av_codec_get_tag2_fptr = GetFunctionDelegate<av_codec_get_tag2_delegate>(GetOrLoadLibrary("avformat", 57), "av_codec_get_tag2");
            if (av_codec_get_tag2_fptr == null)
            {
                av_codec_get_tag2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_codec_get_tag2 is not supported on this platform.");
                };
            }
            return av_codec_get_tag2_fptr(@tags, @id, @tag);
        };
        /// <summary>Get the codec tag for the given codec id.</summary>
        /// <param name="tags">list of supported codec_id - codec_tag pairs, as stored in AVInputFormat.codec_tag and AVOutputFormat.codec_tag</param>
        /// <param name="id">codec id that should be searched for in the list</param>
        /// <param name="tag">A pointer to the found tag</param>
        public static int av_codec_get_tag2(AVCodecTag** @tags, AVCodecID @id, uint* @tag)
        {
            return av_codec_get_tag2_fptr(@tags, @id, @tag);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_demuxer_open_delegate(AVFormatContext* @ic);
        private static av_demuxer_open_delegate av_demuxer_open_fptr = (AVFormatContext* @ic) =>
        {
            av_demuxer_open_fptr = GetFunctionDelegate<av_demuxer_open_delegate>(GetOrLoadLibrary("avformat", 57), "av_demuxer_open");
            if (av_demuxer_open_fptr == null)
            {
                av_demuxer_open_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_demuxer_open is not supported on this platform.");
                };
            }
            return av_demuxer_open_fptr(@ic);
        };
        [Obsolete("")]
        public static int av_demuxer_open(AVFormatContext* @ic)
        {
            return av_demuxer_open_fptr(@ic);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_dump_format_delegate(AVFormatContext* @ic, int @index, [MarshalAs(UnmanagedType.LPStr)] string @url, int @is_output);
        private static av_dump_format_delegate av_dump_format_fptr = (AVFormatContext* @ic, int @index, string @url, int @is_output) =>
        {
            av_dump_format_fptr = GetFunctionDelegate<av_dump_format_delegate>(GetOrLoadLibrary("avformat", 57), "av_dump_format");
            if (av_dump_format_fptr == null)
            {
                av_dump_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dump_format is not supported on this platform.");
                };
            }
            av_dump_format_fptr(@ic, @index, @url, @is_output);
        };
        /// <summary>Print detailed information about the input or output format, such as duration, bitrate, streams, container, programs, metadata, side data, codec and time base.</summary>
        /// <param name="ic">the context to analyze</param>
        /// <param name="index">index of the stream to dump information about</param>
        /// <param name="url">the URL to print, such as source or destination file</param>
        /// <param name="is_output">Select whether the specified context is an input(0) or output(1)</param>
        public static void av_dump_format(AVFormatContext* @ic, int @index, [MarshalAs(UnmanagedType.LPStr)] string @url, int @is_output)
        {
            av_dump_format_fptr(@ic, @index, @url, @is_output);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_filename_number_test_delegate([MarshalAs(UnmanagedType.LPStr)] string @filename);
        private static av_filename_number_test_delegate av_filename_number_test_fptr = (string @filename) =>
        {
            av_filename_number_test_fptr = GetFunctionDelegate<av_filename_number_test_delegate>(GetOrLoadLibrary("avformat", 57), "av_filename_number_test");
            if (av_filename_number_test_fptr == null)
            {
                av_filename_number_test_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_filename_number_test is not supported on this platform.");
                };
            }
            return av_filename_number_test_fptr(@filename);
        };
        /// <summary>Check whether filename actually is a numbered sequence generator.</summary>
        /// <param name="filename">possible numbered sequence string</param>
        public static int av_filename_number_test([MarshalAs(UnmanagedType.LPStr)] string @filename)
        {
            return av_filename_number_test_fptr(@filename);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_find_best_stream_delegate(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags);
        private static av_find_best_stream_delegate av_find_best_stream_fptr = (AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags) =>
        {
            av_find_best_stream_fptr = GetFunctionDelegate<av_find_best_stream_delegate>(GetOrLoadLibrary("avformat", 57), "av_find_best_stream");
            if (av_find_best_stream_fptr == null)
            {
                av_find_best_stream_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_find_best_stream is not supported on this platform.");
                };
            }
            return av_find_best_stream_fptr(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
        };
        /// <summary>Find the &quot;best&quot; stream in the file. The best stream is determined according to various heuristics as the most likely to be what the user expects. If the decoder parameter is non-NULL, av_find_best_stream will find the default decoder for the stream&apos;s codec; streams for which no decoder can be found are ignored.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="type">stream type: video, audio, subtitles, etc.</param>
        /// <param name="wanted_stream_nb">user-requested stream number, or -1 for automatic selection</param>
        /// <param name="related_stream">try to find a stream related (eg. in the same program) to this one, or -1 if none</param>
        /// <param name="decoder_ret">if non-NULL, returns the decoder for the selected stream</param>
        /// <param name="flags">flags; none are currently defined</param>
        public static int av_find_best_stream(AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags)
        {
            return av_find_best_stream_fptr(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_find_default_stream_index_delegate(AVFormatContext* @s);
        private static av_find_default_stream_index_delegate av_find_default_stream_index_fptr = (AVFormatContext* @s) =>
        {
            av_find_default_stream_index_fptr = GetFunctionDelegate<av_find_default_stream_index_delegate>(GetOrLoadLibrary("avformat", 57), "av_find_default_stream_index");
            if (av_find_default_stream_index_fptr == null)
            {
                av_find_default_stream_index_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_find_default_stream_index is not supported on this platform.");
                };
            }
            return av_find_default_stream_index_fptr(@s);
        };
        public static int av_find_default_stream_index(AVFormatContext* @s)
        {
            return av_find_default_stream_index_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_find_input_format_delegate([MarshalAs(UnmanagedType.LPStr)] string @short_name);
        private static av_find_input_format_delegate av_find_input_format_fptr = (string @short_name) =>
        {
            av_find_input_format_fptr = GetFunctionDelegate<av_find_input_format_delegate>(GetOrLoadLibrary("avformat", 57), "av_find_input_format");
            if (av_find_input_format_fptr == null)
            {
                av_find_input_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_find_input_format is not supported on this platform.");
                };
            }
            return av_find_input_format_fptr(@short_name);
        };
        /// <summary>Find AVInputFormat based on the short name of the input format.</summary>
        public static AVInputFormat* av_find_input_format([MarshalAs(UnmanagedType.LPStr)] string @short_name)
        {
            return av_find_input_format_fptr(@short_name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVProgram* av_find_program_from_stream_delegate(AVFormatContext* @ic, AVProgram* @last, int @s);
        private static av_find_program_from_stream_delegate av_find_program_from_stream_fptr = (AVFormatContext* @ic, AVProgram* @last, int @s) =>
        {
            av_find_program_from_stream_fptr = GetFunctionDelegate<av_find_program_from_stream_delegate>(GetOrLoadLibrary("avformat", 57), "av_find_program_from_stream");
            if (av_find_program_from_stream_fptr == null)
            {
                av_find_program_from_stream_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_find_program_from_stream is not supported on this platform.");
                };
            }
            return av_find_program_from_stream_fptr(@ic, @last, @s);
        };
        /// <summary>Find the programs which belong to a given stream.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="last">the last found program, the search will start after this program, or from the beginning if it is NULL</param>
        /// <param name="s">stream index</param>
        public static AVProgram* av_find_program_from_stream(AVFormatContext* @ic, AVProgram* @last, int @s)
        {
            return av_find_program_from_stream_fptr(@ic, @last, @s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method_delegate(AVFormatContext* @ctx);
        private static av_fmt_ctx_get_duration_estimation_method_delegate av_fmt_ctx_get_duration_estimation_method_fptr = (AVFormatContext* @ctx) =>
        {
            av_fmt_ctx_get_duration_estimation_method_fptr = GetFunctionDelegate<av_fmt_ctx_get_duration_estimation_method_delegate>(GetOrLoadLibrary("avformat", 57), "av_fmt_ctx_get_duration_estimation_method");
            if (av_fmt_ctx_get_duration_estimation_method_fptr == null)
            {
                av_fmt_ctx_get_duration_estimation_method_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fmt_ctx_get_duration_estimation_method is not supported on this platform.");
                };
            }
            return av_fmt_ctx_get_duration_estimation_method_fptr(@ctx);
        };
        /// <summary>Returns the method used to set ctx-&gt;duration.</summary>
        public static AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method(AVFormatContext* @ctx)
        {
            return av_fmt_ctx_get_duration_estimation_method_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* av_format_get_audio_codec_delegate(AVFormatContext* @s);
        private static av_format_get_audio_codec_delegate av_format_get_audio_codec_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_audio_codec_fptr = GetFunctionDelegate<av_format_get_audio_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_audio_codec");
            if (av_format_get_audio_codec_fptr == null)
            {
                av_format_get_audio_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_audio_codec is not supported on this platform.");
                };
            }
            return av_format_get_audio_codec_fptr(@s);
        };
        public static AVCodec* av_format_get_audio_codec(AVFormatContext* @s)
        {
            return av_format_get_audio_codec_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate av_format_get_control_message_cb_func av_format_get_control_message_cb_delegate(AVFormatContext* @s);
        private static av_format_get_control_message_cb_delegate av_format_get_control_message_cb_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_control_message_cb_fptr = GetFunctionDelegate<av_format_get_control_message_cb_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_control_message_cb");
            if (av_format_get_control_message_cb_fptr == null)
            {
                av_format_get_control_message_cb_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_control_message_cb is not supported on this platform.");
                };
            }
            return av_format_get_control_message_cb_fptr(@s);
        };
        public static av_format_get_control_message_cb_func av_format_get_control_message_cb(AVFormatContext* @s)
        {
            return av_format_get_control_message_cb_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* av_format_get_data_codec_delegate(AVFormatContext* @s);
        private static av_format_get_data_codec_delegate av_format_get_data_codec_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_data_codec_fptr = GetFunctionDelegate<av_format_get_data_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_data_codec");
            if (av_format_get_data_codec_fptr == null)
            {
                av_format_get_data_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_data_codec is not supported on this platform.");
                };
            }
            return av_format_get_data_codec_fptr(@s);
        };
        public static AVCodec* av_format_get_data_codec(AVFormatContext* @s)
        {
            return av_format_get_data_codec_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_format_get_metadata_header_padding_delegate(AVFormatContext* @s);
        private static av_format_get_metadata_header_padding_delegate av_format_get_metadata_header_padding_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_metadata_header_padding_fptr = GetFunctionDelegate<av_format_get_metadata_header_padding_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_metadata_header_padding");
            if (av_format_get_metadata_header_padding_fptr == null)
            {
                av_format_get_metadata_header_padding_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_metadata_header_padding is not supported on this platform.");
                };
            }
            return av_format_get_metadata_header_padding_fptr(@s);
        };
        public static int av_format_get_metadata_header_padding(AVFormatContext* @s)
        {
            return av_format_get_metadata_header_padding_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_format_get_opaque_delegate(AVFormatContext* @s);
        private static av_format_get_opaque_delegate av_format_get_opaque_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_opaque_fptr = GetFunctionDelegate<av_format_get_opaque_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_opaque");
            if (av_format_get_opaque_fptr == null)
            {
                av_format_get_opaque_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_opaque is not supported on this platform.");
                };
            }
            return av_format_get_opaque_fptr(@s);
        };
        public static void* av_format_get_opaque(AVFormatContext* @s)
        {
            return av_format_get_opaque_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate av_format_get_open_cb_func av_format_get_open_cb_delegate(AVFormatContext* @s);
        private static av_format_get_open_cb_delegate av_format_get_open_cb_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_open_cb_fptr = GetFunctionDelegate<av_format_get_open_cb_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_open_cb");
            if (av_format_get_open_cb_fptr == null)
            {
                av_format_get_open_cb_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_open_cb is not supported on this platform.");
                };
            }
            return av_format_get_open_cb_fptr(@s);
        };
        [Obsolete("")]
        public static av_format_get_open_cb_func av_format_get_open_cb(AVFormatContext* @s)
        {
            return av_format_get_open_cb_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_format_get_probe_score_delegate(AVFormatContext* @s);
        private static av_format_get_probe_score_delegate av_format_get_probe_score_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_probe_score_fptr = GetFunctionDelegate<av_format_get_probe_score_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_probe_score");
            if (av_format_get_probe_score_fptr == null)
            {
                av_format_get_probe_score_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_probe_score is not supported on this platform.");
                };
            }
            return av_format_get_probe_score_fptr(@s);
        };
        /// <summary>Accessors for some AVFormatContext fields. These used to be provided for ABI compatibility, and do not need to be used anymore.</summary>
        public static int av_format_get_probe_score(AVFormatContext* @s)
        {
            return av_format_get_probe_score_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* av_format_get_subtitle_codec_delegate(AVFormatContext* @s);
        private static av_format_get_subtitle_codec_delegate av_format_get_subtitle_codec_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_subtitle_codec_fptr = GetFunctionDelegate<av_format_get_subtitle_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_subtitle_codec");
            if (av_format_get_subtitle_codec_fptr == null)
            {
                av_format_get_subtitle_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_subtitle_codec is not supported on this platform.");
                };
            }
            return av_format_get_subtitle_codec_fptr(@s);
        };
        public static AVCodec* av_format_get_subtitle_codec(AVFormatContext* @s)
        {
            return av_format_get_subtitle_codec_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodec* av_format_get_video_codec_delegate(AVFormatContext* @s);
        private static av_format_get_video_codec_delegate av_format_get_video_codec_fptr = (AVFormatContext* @s) =>
        {
            av_format_get_video_codec_fptr = GetFunctionDelegate<av_format_get_video_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_get_video_codec");
            if (av_format_get_video_codec_fptr == null)
            {
                av_format_get_video_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_get_video_codec is not supported on this platform.");
                };
            }
            return av_format_get_video_codec_fptr(@s);
        };
        public static AVCodec* av_format_get_video_codec(AVFormatContext* @s)
        {
            return av_format_get_video_codec_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_inject_global_side_data_delegate(AVFormatContext* @s);
        private static av_format_inject_global_side_data_delegate av_format_inject_global_side_data_fptr = (AVFormatContext* @s) =>
        {
            av_format_inject_global_side_data_fptr = GetFunctionDelegate<av_format_inject_global_side_data_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_inject_global_side_data");
            if (av_format_inject_global_side_data_fptr == null)
            {
                av_format_inject_global_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_inject_global_side_data is not supported on this platform.");
                };
            }
            av_format_inject_global_side_data_fptr(@s);
        };
        /// <summary>This function will cause global side data to be injected in the next packet of each stream as well as after any subsequent seek.</summary>
        public static void av_format_inject_global_side_data(AVFormatContext* @s)
        {
            av_format_inject_global_side_data_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_audio_codec_delegate(AVFormatContext* @s, AVCodec* @c);
        private static av_format_set_audio_codec_delegate av_format_set_audio_codec_fptr = (AVFormatContext* @s, AVCodec* @c) =>
        {
            av_format_set_audio_codec_fptr = GetFunctionDelegate<av_format_set_audio_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_audio_codec");
            if (av_format_set_audio_codec_fptr == null)
            {
                av_format_set_audio_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_audio_codec is not supported on this platform.");
                };
            }
            av_format_set_audio_codec_fptr(@s, @c);
        };
        public static void av_format_set_audio_codec(AVFormatContext* @s, AVCodec* @c)
        {
            av_format_set_audio_codec_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_control_message_cb_delegate(AVFormatContext* @s, av_format_set_control_message_cb_callback_func @callback);
        private static av_format_set_control_message_cb_delegate av_format_set_control_message_cb_fptr = (AVFormatContext* @s, av_format_set_control_message_cb_callback_func @callback) =>
        {
            av_format_set_control_message_cb_fptr = GetFunctionDelegate<av_format_set_control_message_cb_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_control_message_cb");
            if (av_format_set_control_message_cb_fptr == null)
            {
                av_format_set_control_message_cb_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_control_message_cb is not supported on this platform.");
                };
            }
            av_format_set_control_message_cb_fptr(@s, @callback);
        };
        public static void av_format_set_control_message_cb(AVFormatContext* @s, av_format_set_control_message_cb_callback_func @callback)
        {
            av_format_set_control_message_cb_fptr(@s, @callback);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_data_codec_delegate(AVFormatContext* @s, AVCodec* @c);
        private static av_format_set_data_codec_delegate av_format_set_data_codec_fptr = (AVFormatContext* @s, AVCodec* @c) =>
        {
            av_format_set_data_codec_fptr = GetFunctionDelegate<av_format_set_data_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_data_codec");
            if (av_format_set_data_codec_fptr == null)
            {
                av_format_set_data_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_data_codec is not supported on this platform.");
                };
            }
            av_format_set_data_codec_fptr(@s, @c);
        };
        public static void av_format_set_data_codec(AVFormatContext* @s, AVCodec* @c)
        {
            av_format_set_data_codec_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_metadata_header_padding_delegate(AVFormatContext* @s, int @c);
        private static av_format_set_metadata_header_padding_delegate av_format_set_metadata_header_padding_fptr = (AVFormatContext* @s, int @c) =>
        {
            av_format_set_metadata_header_padding_fptr = GetFunctionDelegate<av_format_set_metadata_header_padding_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_metadata_header_padding");
            if (av_format_set_metadata_header_padding_fptr == null)
            {
                av_format_set_metadata_header_padding_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_metadata_header_padding is not supported on this platform.");
                };
            }
            av_format_set_metadata_header_padding_fptr(@s, @c);
        };
        public static void av_format_set_metadata_header_padding(AVFormatContext* @s, int @c)
        {
            av_format_set_metadata_header_padding_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_opaque_delegate(AVFormatContext* @s, void* @opaque);
        private static av_format_set_opaque_delegate av_format_set_opaque_fptr = (AVFormatContext* @s, void* @opaque) =>
        {
            av_format_set_opaque_fptr = GetFunctionDelegate<av_format_set_opaque_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_opaque");
            if (av_format_set_opaque_fptr == null)
            {
                av_format_set_opaque_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_opaque is not supported on this platform.");
                };
            }
            av_format_set_opaque_fptr(@s, @opaque);
        };
        public static void av_format_set_opaque(AVFormatContext* @s, void* @opaque)
        {
            av_format_set_opaque_fptr(@s, @opaque);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_open_cb_delegate(AVFormatContext* @s, av_format_set_open_cb_callback_func @callback);
        private static av_format_set_open_cb_delegate av_format_set_open_cb_fptr = (AVFormatContext* @s, av_format_set_open_cb_callback_func @callback) =>
        {
            av_format_set_open_cb_fptr = GetFunctionDelegate<av_format_set_open_cb_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_open_cb");
            if (av_format_set_open_cb_fptr == null)
            {
                av_format_set_open_cb_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_open_cb is not supported on this platform.");
                };
            }
            av_format_set_open_cb_fptr(@s, @callback);
        };
        [Obsolete("")]
        public static void av_format_set_open_cb(AVFormatContext* @s, av_format_set_open_cb_callback_func @callback)
        {
            av_format_set_open_cb_fptr(@s, @callback);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_subtitle_codec_delegate(AVFormatContext* @s, AVCodec* @c);
        private static av_format_set_subtitle_codec_delegate av_format_set_subtitle_codec_fptr = (AVFormatContext* @s, AVCodec* @c) =>
        {
            av_format_set_subtitle_codec_fptr = GetFunctionDelegate<av_format_set_subtitle_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_subtitle_codec");
            if (av_format_set_subtitle_codec_fptr == null)
            {
                av_format_set_subtitle_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_subtitle_codec is not supported on this platform.");
                };
            }
            av_format_set_subtitle_codec_fptr(@s, @c);
        };
        public static void av_format_set_subtitle_codec(AVFormatContext* @s, AVCodec* @c)
        {
            av_format_set_subtitle_codec_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_format_set_video_codec_delegate(AVFormatContext* @s, AVCodec* @c);
        private static av_format_set_video_codec_delegate av_format_set_video_codec_fptr = (AVFormatContext* @s, AVCodec* @c) =>
        {
            av_format_set_video_codec_fptr = GetFunctionDelegate<av_format_set_video_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_format_set_video_codec");
            if (av_format_set_video_codec_fptr == null)
            {
                av_format_set_video_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_format_set_video_codec is not supported on this platform.");
                };
            }
            av_format_set_video_codec_fptr(@s, @c);
        };
        public static void av_format_set_video_codec(AVFormatContext* @s, AVCodec* @c)
        {
            av_format_set_video_codec_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_frame_filename_delegate(byte* @buf, int @buf_size, [MarshalAs(UnmanagedType.LPStr)] string @path, int @number);
        private static av_get_frame_filename_delegate av_get_frame_filename_fptr = (byte* @buf, int @buf_size, string @path, int @number) =>
        {
            av_get_frame_filename_fptr = GetFunctionDelegate<av_get_frame_filename_delegate>(GetOrLoadLibrary("avformat", 57), "av_get_frame_filename");
            if (av_get_frame_filename_fptr == null)
            {
                av_get_frame_filename_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_frame_filename is not supported on this platform.");
                };
            }
            return av_get_frame_filename_fptr(@buf, @buf_size, @path, @number);
        };
        public static int av_get_frame_filename(byte* @buf, int @buf_size, [MarshalAs(UnmanagedType.LPStr)] string @path, int @number)
        {
            return av_get_frame_filename_fptr(@buf, @buf_size, @path, @number);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_frame_filename2_delegate(byte* @buf, int @buf_size, [MarshalAs(UnmanagedType.LPStr)] string @path, int @number, int @flags);
        private static av_get_frame_filename2_delegate av_get_frame_filename2_fptr = (byte* @buf, int @buf_size, string @path, int @number, int @flags) =>
        {
            av_get_frame_filename2_fptr = GetFunctionDelegate<av_get_frame_filename2_delegate>(GetOrLoadLibrary("avformat", 57), "av_get_frame_filename2");
            if (av_get_frame_filename2_fptr == null)
            {
                av_get_frame_filename2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_frame_filename2 is not supported on this platform.");
                };
            }
            return av_get_frame_filename2_fptr(@buf, @buf_size, @path, @number, @flags);
        };
        /// <summary>Return in &apos;buf&apos; the path with &apos;%d&apos; replaced by a number.</summary>
        /// <param name="buf">destination buffer</param>
        /// <param name="buf_size">destination buffer size</param>
        /// <param name="path">numbered sequence string</param>
        /// <param name="number">frame number</param>
        /// <param name="flags">AV_FRAME_FILENAME_FLAGS_*</param>
        public static int av_get_frame_filename2(byte* @buf, int @buf_size, [MarshalAs(UnmanagedType.LPStr)] string @path, int @number, int @flags)
        {
            return av_get_frame_filename2_fptr(@buf, @buf_size, @path, @number, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_output_timestamp_delegate(AVFormatContext* @s, int @stream, long* @dts, long* @wall);
        private static av_get_output_timestamp_delegate av_get_output_timestamp_fptr = (AVFormatContext* @s, int @stream, long* @dts, long* @wall) =>
        {
            av_get_output_timestamp_fptr = GetFunctionDelegate<av_get_output_timestamp_delegate>(GetOrLoadLibrary("avformat", 57), "av_get_output_timestamp");
            if (av_get_output_timestamp_fptr == null)
            {
                av_get_output_timestamp_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_output_timestamp is not supported on this platform.");
                };
            }
            return av_get_output_timestamp_fptr(@s, @stream, @dts, @wall);
        };
        /// <summary>Get timing information for the data currently output. The exact meaning of &quot;currently output&quot; depends on the format. It is mostly relevant for devices that have an internal buffer and/or work in real time.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream">stream in the media file</param>
        /// <param name="dts">DTS of the last packet output for the stream, in stream time_base units</param>
        /// <param name="wall">absolute time when that packet whas output, in microsecond</param>
        public static int av_get_output_timestamp(AVFormatContext* @s, int @stream, long* @dts, long* @wall)
        {
            return av_get_output_timestamp_fptr(@s, @stream, @dts, @wall);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_packet_delegate(AVIOContext* @s, AVPacket* @pkt, int @size);
        private static av_get_packet_delegate av_get_packet_fptr = (AVIOContext* @s, AVPacket* @pkt, int @size) =>
        {
            av_get_packet_fptr = GetFunctionDelegate<av_get_packet_delegate>(GetOrLoadLibrary("avformat", 57), "av_get_packet");
            if (av_get_packet_fptr == null)
            {
                av_get_packet_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_packet is not supported on this platform.");
                };
            }
            return av_get_packet_fptr(@s, @pkt, @size);
        };
        /// <summary>Allocate and read the payload of a packet and initialize its fields with default values.</summary>
        /// <param name="s">associated IO context</param>
        /// <param name="pkt">packet</param>
        /// <param name="size">desired payload size</param>
        public static int av_get_packet(AVIOContext* @s, AVPacket* @pkt, int @size)
        {
            return av_get_packet_fptr(@s, @pkt, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecID av_guess_codec_delegate(AVOutputFormat* @fmt, [MarshalAs(UnmanagedType.LPStr)] string @short_name, [MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @mime_type, AVMediaType @type);
        private static av_guess_codec_delegate av_guess_codec_fptr = (AVOutputFormat* @fmt, string @short_name, string @filename, string @mime_type, AVMediaType @type) =>
        {
            av_guess_codec_fptr = GetFunctionDelegate<av_guess_codec_delegate>(GetOrLoadLibrary("avformat", 57), "av_guess_codec");
            if (av_guess_codec_fptr == null)
            {
                av_guess_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_guess_codec is not supported on this platform.");
                };
            }
            return av_guess_codec_fptr(@fmt, @short_name, @filename, @mime_type, @type);
        };
        /// <summary>Guess the codec ID based upon muxer and filename.</summary>
        public static AVCodecID av_guess_codec(AVOutputFormat* @fmt, [MarshalAs(UnmanagedType.LPStr)] string @short_name, [MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @mime_type, AVMediaType @type)
        {
            return av_guess_codec_fptr(@fmt, @short_name, @filename, @mime_type, @type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOutputFormat* av_guess_format_delegate([MarshalAs(UnmanagedType.LPStr)] string @short_name, [MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @mime_type);
        private static av_guess_format_delegate av_guess_format_fptr = (string @short_name, string @filename, string @mime_type) =>
        {
            av_guess_format_fptr = GetFunctionDelegate<av_guess_format_delegate>(GetOrLoadLibrary("avformat", 57), "av_guess_format");
            if (av_guess_format_fptr == null)
            {
                av_guess_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_guess_format is not supported on this platform.");
                };
            }
            return av_guess_format_fptr(@short_name, @filename, @mime_type);
        };
        /// <summary>Return the output format in the list of registered output formats which best matches the provided parameters, or return NULL if there is no match.</summary>
        /// <param name="short_name">if non-NULL checks if short_name matches with the names of the registered formats</param>
        /// <param name="filename">if non-NULL checks if filename terminates with the extensions of the registered formats</param>
        /// <param name="mime_type">if non-NULL checks if mime_type matches with the MIME type of the registered formats</param>
        public static AVOutputFormat* av_guess_format([MarshalAs(UnmanagedType.LPStr)] string @short_name, [MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @mime_type)
        {
            return av_guess_format_fptr(@short_name, @filename, @mime_type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_guess_frame_rate_delegate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame);
        private static av_guess_frame_rate_delegate av_guess_frame_rate_fptr = (AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame) =>
        {
            av_guess_frame_rate_fptr = GetFunctionDelegate<av_guess_frame_rate_delegate>(GetOrLoadLibrary("avformat", 57), "av_guess_frame_rate");
            if (av_guess_frame_rate_fptr == null)
            {
                av_guess_frame_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_guess_frame_rate is not supported on this platform.");
                };
            }
            return av_guess_frame_rate_fptr(@ctx, @stream, @frame);
        };
        /// <summary>Guess the frame rate, based on both the container and codec information.</summary>
        /// <param name="ctx">the format context which the stream is part of</param>
        /// <param name="stream">the stream which the frame is part of</param>
        /// <param name="frame">the frame for which the frame rate should be determined, may be NULL</param>
        public static AVRational av_guess_frame_rate(AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame)
        {
            return av_guess_frame_rate_fptr(@ctx, @stream, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_guess_sample_aspect_ratio_delegate(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame);
        private static av_guess_sample_aspect_ratio_delegate av_guess_sample_aspect_ratio_fptr = (AVFormatContext* @format, AVStream* @stream, AVFrame* @frame) =>
        {
            av_guess_sample_aspect_ratio_fptr = GetFunctionDelegate<av_guess_sample_aspect_ratio_delegate>(GetOrLoadLibrary("avformat", 57), "av_guess_sample_aspect_ratio");
            if (av_guess_sample_aspect_ratio_fptr == null)
            {
                av_guess_sample_aspect_ratio_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_guess_sample_aspect_ratio is not supported on this platform.");
                };
            }
            return av_guess_sample_aspect_ratio_fptr(@format, @stream, @frame);
        };
        /// <summary>Guess the sample aspect ratio of a frame, based on both the stream and the frame aspect ratio.</summary>
        /// <param name="format">the format context which the stream is part of</param>
        /// <param name="stream">the stream which the frame is part of</param>
        /// <param name="frame">the frame with the aspect ratio to be determined</param>
        public static AVRational av_guess_sample_aspect_ratio(AVFormatContext* @format, AVStream* @stream, AVFrame* @frame)
        {
            return av_guess_sample_aspect_ratio_fptr(@format, @stream, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_hex_dump_delegate(_iobuf* @f, byte* @buf, int @size);
        private static av_hex_dump_delegate av_hex_dump_fptr = (_iobuf* @f, byte* @buf, int @size) =>
        {
            av_hex_dump_fptr = GetFunctionDelegate<av_hex_dump_delegate>(GetOrLoadLibrary("avformat", 57), "av_hex_dump");
            if (av_hex_dump_fptr == null)
            {
                av_hex_dump_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hex_dump is not supported on this platform.");
                };
            }
            av_hex_dump_fptr(@f, @buf, @size);
        };
        /// <summary>Send a nice hexadecimal dump of a buffer to the specified file stream.</summary>
        /// <param name="f">The file stream pointer where the dump should be sent to.</param>
        /// <param name="buf">buffer</param>
        /// <param name="size">buffer size</param>
        public static void av_hex_dump(_iobuf* @f, byte* @buf, int @size)
        {
            av_hex_dump_fptr(@f, @buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_hex_dump_log_delegate(void* @avcl, int @level, byte* @buf, int @size);
        private static av_hex_dump_log_delegate av_hex_dump_log_fptr = (void* @avcl, int @level, byte* @buf, int @size) =>
        {
            av_hex_dump_log_fptr = GetFunctionDelegate<av_hex_dump_log_delegate>(GetOrLoadLibrary("avformat", 57), "av_hex_dump_log");
            if (av_hex_dump_log_fptr == null)
            {
                av_hex_dump_log_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hex_dump_log is not supported on this platform.");
                };
            }
            av_hex_dump_log_fptr(@avcl, @level, @buf, @size);
        };
        /// <summary>Send a nice hexadecimal dump of a buffer to the log.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
        /// <param name="buf">buffer</param>
        /// <param name="size">buffer size</param>
        public static void av_hex_dump_log(void* @avcl, int @level, byte* @buf, int @size)
        {
            av_hex_dump_log_fptr(@avcl, @level, @buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_iformat_next_delegate(AVInputFormat* @f);
        private static av_iformat_next_delegate av_iformat_next_fptr = (AVInputFormat* @f) =>
        {
            av_iformat_next_fptr = GetFunctionDelegate<av_iformat_next_delegate>(GetOrLoadLibrary("avformat", 57), "av_iformat_next");
            if (av_iformat_next_fptr == null)
            {
                av_iformat_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_iformat_next is not supported on this platform.");
                };
            }
            return av_iformat_next_fptr(@f);
        };
        /// <summary>If f is NULL, returns the first registered input format, if f is non-NULL, returns the next registered input format after f or NULL if f is the last one.</summary>
        public static AVInputFormat* av_iformat_next(AVInputFormat* @f)
        {
            return av_iformat_next_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_index_search_timestamp_delegate(AVStream* @st, long @timestamp, int @flags);
        private static av_index_search_timestamp_delegate av_index_search_timestamp_fptr = (AVStream* @st, long @timestamp, int @flags) =>
        {
            av_index_search_timestamp_fptr = GetFunctionDelegate<av_index_search_timestamp_delegate>(GetOrLoadLibrary("avformat", 57), "av_index_search_timestamp");
            if (av_index_search_timestamp_fptr == null)
            {
                av_index_search_timestamp_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_index_search_timestamp is not supported on this platform.");
                };
            }
            return av_index_search_timestamp_fptr(@st, @timestamp, @flags);
        };
        /// <summary>Get the index for a specific timestamp.</summary>
        /// <param name="st">stream that the timestamp belongs to</param>
        /// <param name="timestamp">timestamp to retrieve the index for</param>
        /// <param name="flags">if AVSEEK_FLAG_BACKWARD then the returned index will correspond to the timestamp which is &lt; = the requested one, if backward is 0, then it will be &gt;= if AVSEEK_FLAG_ANY seek to any frame, only keyframes otherwise</param>
        public static int av_index_search_timestamp(AVStream* @st, long @timestamp, int @flags)
        {
            return av_index_search_timestamp_fptr(@st, @timestamp, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_interleaved_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
        private static av_interleaved_write_frame_delegate av_interleaved_write_frame_fptr = (AVFormatContext* @s, AVPacket* @pkt) =>
        {
            av_interleaved_write_frame_fptr = GetFunctionDelegate<av_interleaved_write_frame_delegate>(GetOrLoadLibrary("avformat", 57), "av_interleaved_write_frame");
            if (av_interleaved_write_frame_fptr == null)
            {
                av_interleaved_write_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_interleaved_write_frame is not supported on this platform.");
                };
            }
            return av_interleaved_write_frame_fptr(@s, @pkt);
        };
        /// <summary>Write a packet to an output media file ensuring correct interleaving.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written.  If the packet is reference-counted, this function will take ownership of this reference and unreference it later when it sees fit. The caller must not access the data through this reference after this function returns. If the packet is not reference-counted, libavformat will make a copy.  This parameter can be NULL (at any time, not just at the end), to flush the interleaving queues.  Packet&apos;s</param>
        public static int av_interleaved_write_frame(AVFormatContext* @s, AVPacket* @pkt)
        {
            return av_interleaved_write_frame_fptr(@s, @pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_interleaved_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
        private static av_interleaved_write_uncoded_frame_delegate av_interleaved_write_uncoded_frame_fptr = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) =>
        {
            av_interleaved_write_uncoded_frame_fptr = GetFunctionDelegate<av_interleaved_write_uncoded_frame_delegate>(GetOrLoadLibrary("avformat", 57), "av_interleaved_write_uncoded_frame");
            if (av_interleaved_write_uncoded_frame_fptr == null)
            {
                av_interleaved_write_uncoded_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_interleaved_write_uncoded_frame is not supported on this platform.");
                };
            }
            return av_interleaved_write_uncoded_frame_fptr(@s, @stream_index, @frame);
        };
        /// <summary>Write an uncoded frame to an output media file.</summary>
        public static int av_interleaved_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame)
        {
            return av_interleaved_write_uncoded_frame_fptr(@s, @stream_index, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_match_ext_delegate([MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @extensions);
        private static av_match_ext_delegate av_match_ext_fptr = (string @filename, string @extensions) =>
        {
            av_match_ext_fptr = GetFunctionDelegate<av_match_ext_delegate>(GetOrLoadLibrary("avformat", 57), "av_match_ext");
            if (av_match_ext_fptr == null)
            {
                av_match_ext_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_match_ext is not supported on this platform.");
                };
            }
            return av_match_ext_fptr(@filename, @extensions);
        };
        /// <summary>Return a positive value if the given filename has one of the given extensions, 0 otherwise.</summary>
        /// <param name="filename">file name to check against the given extensions</param>
        /// <param name="extensions">a comma-separated list of filename extensions</param>
        public static int av_match_ext([MarshalAs(UnmanagedType.LPStr)] string @filename, [MarshalAs(UnmanagedType.LPStr)] string @extensions)
        {
            return av_match_ext_fptr(@filename, @extensions);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVProgram* av_new_program_delegate(AVFormatContext* @s, int @id);
        private static av_new_program_delegate av_new_program_fptr = (AVFormatContext* @s, int @id) =>
        {
            av_new_program_fptr = GetFunctionDelegate<av_new_program_delegate>(GetOrLoadLibrary("avformat", 57), "av_new_program");
            if (av_new_program_fptr == null)
            {
                av_new_program_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_new_program is not supported on this platform.");
                };
            }
            return av_new_program_fptr(@s, @id);
        };
        public static AVProgram* av_new_program(AVFormatContext* @s, int @id)
        {
            return av_new_program_fptr(@s, @id);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOutputFormat* av_oformat_next_delegate(AVOutputFormat* @f);
        private static av_oformat_next_delegate av_oformat_next_fptr = (AVOutputFormat* @f) =>
        {
            av_oformat_next_fptr = GetFunctionDelegate<av_oformat_next_delegate>(GetOrLoadLibrary("avformat", 57), "av_oformat_next");
            if (av_oformat_next_fptr == null)
            {
                av_oformat_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_oformat_next is not supported on this platform.");
                };
            }
            return av_oformat_next_fptr(@f);
        };
        /// <summary>If f is NULL, returns the first registered output format, if f is non-NULL, returns the next registered output format after f or NULL if f is the last one.</summary>
        public static AVOutputFormat* av_oformat_next(AVOutputFormat* @f)
        {
            return av_oformat_next_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_pkt_dump_log2_delegate(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st);
        private static av_pkt_dump_log2_delegate av_pkt_dump_log2_fptr = (void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st) =>
        {
            av_pkt_dump_log2_fptr = GetFunctionDelegate<av_pkt_dump_log2_delegate>(GetOrLoadLibrary("avformat", 57), "av_pkt_dump_log2");
            if (av_pkt_dump_log2_fptr == null)
            {
                av_pkt_dump_log2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pkt_dump_log2 is not supported on this platform.");
                };
            }
            av_pkt_dump_log2_fptr(@avcl, @level, @pkt, @dump_payload, @st);
        };
        /// <summary>Send a nice dump of a packet to the log.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message, lower values signifying higher importance.</param>
        /// <param name="pkt">packet to dump</param>
        /// <param name="dump_payload">True if the payload must be displayed, too.</param>
        /// <param name="st">AVStream that the packet belongs to</param>
        public static void av_pkt_dump_log2(void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st)
        {
            av_pkt_dump_log2_fptr(@avcl, @level, @pkt, @dump_payload, @st);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_pkt_dump2_delegate(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st);
        private static av_pkt_dump2_delegate av_pkt_dump2_fptr = (_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st) =>
        {
            av_pkt_dump2_fptr = GetFunctionDelegate<av_pkt_dump2_delegate>(GetOrLoadLibrary("avformat", 57), "av_pkt_dump2");
            if (av_pkt_dump2_fptr == null)
            {
                av_pkt_dump2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pkt_dump2 is not supported on this platform.");
                };
            }
            av_pkt_dump2_fptr(@f, @pkt, @dump_payload, @st);
        };
        /// <summary>Send a nice dump of a packet to the specified file stream.</summary>
        /// <param name="f">The file stream pointer where the dump should be sent to.</param>
        /// <param name="pkt">packet to dump</param>
        /// <param name="dump_payload">True if the payload must be displayed, too.</param>
        /// <param name="st">AVStream that the packet belongs to</param>
        public static void av_pkt_dump2(_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st)
        {
            av_pkt_dump2_fptr(@f, @pkt, @dump_payload, @st);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_probe_input_buffer_delegate(AVIOContext* @pb, AVInputFormat** @fmt, [MarshalAs(UnmanagedType.LPStr)] string @url, void* @logctx, uint @offset, uint @max_probe_size);
        private static av_probe_input_buffer_delegate av_probe_input_buffer_fptr = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) =>
        {
            av_probe_input_buffer_fptr = GetFunctionDelegate<av_probe_input_buffer_delegate>(GetOrLoadLibrary("avformat", 57), "av_probe_input_buffer");
            if (av_probe_input_buffer_fptr == null)
            {
                av_probe_input_buffer_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_probe_input_buffer is not supported on this platform.");
                };
            }
            return av_probe_input_buffer_fptr(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        };
        /// <summary>Like av_probe_input_buffer2() but returns 0 on success</summary>
        public static int av_probe_input_buffer(AVIOContext* @pb, AVInputFormat** @fmt, [MarshalAs(UnmanagedType.LPStr)] string @url, void* @logctx, uint @offset, uint @max_probe_size)
        {
            return av_probe_input_buffer_fptr(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_probe_input_buffer2_delegate(AVIOContext* @pb, AVInputFormat** @fmt, [MarshalAs(UnmanagedType.LPStr)] string @url, void* @logctx, uint @offset, uint @max_probe_size);
        private static av_probe_input_buffer2_delegate av_probe_input_buffer2_fptr = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) =>
        {
            av_probe_input_buffer2_fptr = GetFunctionDelegate<av_probe_input_buffer2_delegate>(GetOrLoadLibrary("avformat", 57), "av_probe_input_buffer2");
            if (av_probe_input_buffer2_fptr == null)
            {
                av_probe_input_buffer2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_probe_input_buffer2 is not supported on this platform.");
                };
            }
            return av_probe_input_buffer2_fptr(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        };
        /// <summary>Probe a bytestream to determine the input format. Each time a probe returns with a score that is too low, the probe buffer size is increased and another attempt is made. When the maximum probe size is reached, the input format with the highest score is returned.</summary>
        /// <param name="pb">the bytestream to probe</param>
        /// <param name="fmt">the input format is put here</param>
        /// <param name="url">the url of the stream</param>
        /// <param name="logctx">the log context</param>
        /// <param name="offset">the offset within the bytestream to probe from</param>
        /// <param name="max_probe_size">the maximum probe buffer size (zero for default)</param>
        public static int av_probe_input_buffer2(AVIOContext* @pb, AVInputFormat** @fmt, [MarshalAs(UnmanagedType.LPStr)] string @url, void* @logctx, uint @offset, uint @max_probe_size)
        {
            return av_probe_input_buffer2_fptr(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_probe_input_format_delegate(AVProbeData* @pd, int @is_opened);
        private static av_probe_input_format_delegate av_probe_input_format_fptr = (AVProbeData* @pd, int @is_opened) =>
        {
            av_probe_input_format_fptr = GetFunctionDelegate<av_probe_input_format_delegate>(GetOrLoadLibrary("avformat", 57), "av_probe_input_format");
            if (av_probe_input_format_fptr == null)
            {
                av_probe_input_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_probe_input_format is not supported on this platform.");
                };
            }
            return av_probe_input_format_fptr(@pd, @is_opened);
        };
        /// <summary>Guess the file format.</summary>
        /// <param name="pd">data to be probed</param>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        public static AVInputFormat* av_probe_input_format(AVProbeData* @pd, int @is_opened)
        {
            return av_probe_input_format_fptr(@pd, @is_opened);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_probe_input_format2_delegate(AVProbeData* @pd, int @is_opened, int* @score_max);
        private static av_probe_input_format2_delegate av_probe_input_format2_fptr = (AVProbeData* @pd, int @is_opened, int* @score_max) =>
        {
            av_probe_input_format2_fptr = GetFunctionDelegate<av_probe_input_format2_delegate>(GetOrLoadLibrary("avformat", 57), "av_probe_input_format2");
            if (av_probe_input_format2_fptr == null)
            {
                av_probe_input_format2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_probe_input_format2 is not supported on this platform.");
                };
            }
            return av_probe_input_format2_fptr(@pd, @is_opened, @score_max);
        };
        /// <summary>Guess the file format.</summary>
        /// <param name="pd">data to be probed</param>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        /// <param name="score_max">A probe score larger that this is required to accept a detection, the variable is set to the actual detection score afterwards. If the score is &lt; = AVPROBE_SCORE_MAX / 4 it is recommended to retry with a larger probe buffer.</param>
        public static AVInputFormat* av_probe_input_format2(AVProbeData* @pd, int @is_opened, int* @score_max)
        {
            return av_probe_input_format2_fptr(@pd, @is_opened, @score_max);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVInputFormat* av_probe_input_format3_delegate(AVProbeData* @pd, int @is_opened, int* @score_ret);
        private static av_probe_input_format3_delegate av_probe_input_format3_fptr = (AVProbeData* @pd, int @is_opened, int* @score_ret) =>
        {
            av_probe_input_format3_fptr = GetFunctionDelegate<av_probe_input_format3_delegate>(GetOrLoadLibrary("avformat", 57), "av_probe_input_format3");
            if (av_probe_input_format3_fptr == null)
            {
                av_probe_input_format3_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_probe_input_format3 is not supported on this platform.");
                };
            }
            return av_probe_input_format3_fptr(@pd, @is_opened, @score_ret);
        };
        /// <summary>Guess the file format.</summary>
        /// <param name="is_opened">Whether the file is already opened; determines whether demuxers with or without AVFMT_NOFILE are probed.</param>
        /// <param name="score_ret">The score of the best detection.</param>
        public static AVInputFormat* av_probe_input_format3(AVProbeData* @pd, int @is_opened, int* @score_ret)
        {
            return av_probe_input_format3_fptr(@pd, @is_opened, @score_ret);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_program_add_stream_index_delegate(AVFormatContext* @ac, int @progid, uint @idx);
        private static av_program_add_stream_index_delegate av_program_add_stream_index_fptr = (AVFormatContext* @ac, int @progid, uint @idx) =>
        {
            av_program_add_stream_index_fptr = GetFunctionDelegate<av_program_add_stream_index_delegate>(GetOrLoadLibrary("avformat", 57), "av_program_add_stream_index");
            if (av_program_add_stream_index_fptr == null)
            {
                av_program_add_stream_index_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_program_add_stream_index is not supported on this platform.");
                };
            }
            av_program_add_stream_index_fptr(@ac, @progid, @idx);
        };
        public static void av_program_add_stream_index(AVFormatContext* @ac, int @progid, uint @idx)
        {
            av_program_add_stream_index_fptr(@ac, @progid, @idx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_read_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
        private static av_read_frame_delegate av_read_frame_fptr = (AVFormatContext* @s, AVPacket* @pkt) =>
        {
            av_read_frame_fptr = GetFunctionDelegate<av_read_frame_delegate>(GetOrLoadLibrary("avformat", 57), "av_read_frame");
            if (av_read_frame_fptr == null)
            {
                av_read_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_read_frame is not supported on this platform.");
                };
            }
            return av_read_frame_fptr(@s, @pkt);
        };
        /// <summary>Return the next frame of a stream. This function returns what is stored in the file, and does not validate that what is there are valid frames for the decoder. It will split what is stored in the file into frames and return one for each call. It will not omit invalid data between valid frames so as to give the decoder the maximum information possible for decoding.</summary>
        public static int av_read_frame(AVFormatContext* @s, AVPacket* @pkt)
        {
            return av_read_frame_fptr(@s, @pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_read_pause_delegate(AVFormatContext* @s);
        private static av_read_pause_delegate av_read_pause_fptr = (AVFormatContext* @s) =>
        {
            av_read_pause_fptr = GetFunctionDelegate<av_read_pause_delegate>(GetOrLoadLibrary("avformat", 57), "av_read_pause");
            if (av_read_pause_fptr == null)
            {
                av_read_pause_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_read_pause is not supported on this platform.");
                };
            }
            return av_read_pause_fptr(@s);
        };
        /// <summary>Pause a network-based stream (e.g. RTSP stream).</summary>
        public static int av_read_pause(AVFormatContext* @s)
        {
            return av_read_pause_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_read_play_delegate(AVFormatContext* @s);
        private static av_read_play_delegate av_read_play_fptr = (AVFormatContext* @s) =>
        {
            av_read_play_fptr = GetFunctionDelegate<av_read_play_delegate>(GetOrLoadLibrary("avformat", 57), "av_read_play");
            if (av_read_play_fptr == null)
            {
                av_read_play_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_read_play is not supported on this platform.");
                };
            }
            return av_read_play_fptr(@s);
        };
        /// <summary>Start playing a network-based stream (e.g. RTSP stream) at the current position.</summary>
        public static int av_read_play(AVFormatContext* @s)
        {
            return av_read_play_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_register_all_delegate();
        private static av_register_all_delegate av_register_all_fptr = () =>
        {
            av_register_all_fptr = GetFunctionDelegate<av_register_all_delegate>(GetOrLoadLibrary("avformat", 57), "av_register_all");
            if (av_register_all_fptr == null)
            {
                av_register_all_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_register_all is not supported on this platform.");
                };
            }
            av_register_all_fptr();
        };
        /// <summary>Initialize libavformat and register all the muxers, demuxers and protocols. If you do not call this function, then you can select exactly which formats you want to support.</summary>
        public static void av_register_all()
        {
            av_register_all_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_register_input_format_delegate(AVInputFormat* @format);
        private static av_register_input_format_delegate av_register_input_format_fptr = (AVInputFormat* @format) =>
        {
            av_register_input_format_fptr = GetFunctionDelegate<av_register_input_format_delegate>(GetOrLoadLibrary("avformat", 57), "av_register_input_format");
            if (av_register_input_format_fptr == null)
            {
                av_register_input_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_register_input_format is not supported on this platform.");
                };
            }
            av_register_input_format_fptr(@format);
        };
        public static void av_register_input_format(AVInputFormat* @format)
        {
            av_register_input_format_fptr(@format);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_register_output_format_delegate(AVOutputFormat* @format);
        private static av_register_output_format_delegate av_register_output_format_fptr = (AVOutputFormat* @format) =>
        {
            av_register_output_format_fptr = GetFunctionDelegate<av_register_output_format_delegate>(GetOrLoadLibrary("avformat", 57), "av_register_output_format");
            if (av_register_output_format_fptr == null)
            {
                av_register_output_format_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_register_output_format is not supported on this platform.");
                };
            }
            av_register_output_format_fptr(@format);
        };
        public static void av_register_output_format(AVOutputFormat* @format)
        {
            av_register_output_format_fptr(@format);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_sdp_create_delegate(AVFormatContext*[] @ac, int @n_files, byte* @buf, int @size);
        private static av_sdp_create_delegate av_sdp_create_fptr = (AVFormatContext*[] @ac, int @n_files, byte* @buf, int @size) =>
        {
            av_sdp_create_fptr = GetFunctionDelegate<av_sdp_create_delegate>(GetOrLoadLibrary("avformat", 57), "av_sdp_create");
            if (av_sdp_create_fptr == null)
            {
                av_sdp_create_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_sdp_create is not supported on this platform.");
                };
            }
            return av_sdp_create_fptr(@ac, @n_files, @buf, @size);
        };
        /// <summary>Generate an SDP for an RTP session.</summary>
        /// <param name="ac">array of AVFormatContexts describing the RTP streams. If the array is composed by only one context, such context can contain multiple AVStreams (one AVStream per RTP stream). Otherwise, all the contexts in the array (an AVCodecContext per RTP stream) must contain only one AVStream.</param>
        /// <param name="n_files">number of AVCodecContexts contained in ac</param>
        /// <param name="buf">buffer where the SDP will be stored (must be allocated by the caller)</param>
        /// <param name="size">the size of the buffer</param>
        public static int av_sdp_create(AVFormatContext*[] @ac, int @n_files, byte* @buf, int @size)
        {
            return av_sdp_create_fptr(@ac, @n_files, @buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_seek_frame_delegate(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags);
        private static av_seek_frame_delegate av_seek_frame_fptr = (AVFormatContext* @s, int @stream_index, long @timestamp, int @flags) =>
        {
            av_seek_frame_fptr = GetFunctionDelegate<av_seek_frame_delegate>(GetOrLoadLibrary("avformat", 57), "av_seek_frame");
            if (av_seek_frame_fptr == null)
            {
                av_seek_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_seek_frame is not supported on this platform.");
                };
            }
            return av_seek_frame_fptr(@s, @stream_index, @timestamp, @flags);
        };
        /// <summary>Seek to the keyframe at timestamp. &apos;timestamp&apos; in &apos;stream_index&apos;.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">If stream_index is (-1), a default stream is selected, and timestamp is automatically converted from AV_TIME_BASE units to the stream specific time_base.</param>
        /// <param name="timestamp">Timestamp in AVStream.time_base units or, if no stream is specified, in AV_TIME_BASE units.</param>
        /// <param name="flags">flags which select direction and seeking mode</param>
        public static int av_seek_frame(AVFormatContext* @s, int @stream_index, long @timestamp, int @flags)
        {
            return av_seek_frame_fptr(@s, @stream_index, @timestamp, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_stream_add_side_data_delegate(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size);
        private static av_stream_add_side_data_delegate av_stream_add_side_data_fptr = (AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size) =>
        {
            av_stream_add_side_data_fptr = GetFunctionDelegate<av_stream_add_side_data_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_add_side_data");
            if (av_stream_add_side_data_fptr == null)
            {
                av_stream_add_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_add_side_data is not supported on this platform.");
                };
            }
            return av_stream_add_side_data_fptr(@st, @type, @data, @size);
        };
        /// <summary>Wrap an existing array as stream side data.</summary>
        /// <param name="st">stream</param>
        /// <param name="type">side information type</param>
        /// <param name="data">the side data array. It must be allocated with the av_malloc() family of functions. The ownership of the data is transferred to st.</param>
        /// <param name="size">side information size</param>
        public static int av_stream_add_side_data(AVStream* @st, AVPacketSideDataType @type, byte* @data, ulong @size)
        {
            return av_stream_add_side_data_fptr(@st, @type, @data, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_stream_get_codec_timebase_delegate(AVStream* @st);
        private static av_stream_get_codec_timebase_delegate av_stream_get_codec_timebase_fptr = (AVStream* @st) =>
        {
            av_stream_get_codec_timebase_fptr = GetFunctionDelegate<av_stream_get_codec_timebase_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_get_codec_timebase");
            if (av_stream_get_codec_timebase_fptr == null)
            {
                av_stream_get_codec_timebase_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_get_codec_timebase is not supported on this platform.");
                };
            }
            return av_stream_get_codec_timebase_fptr(@st);
        };
        /// <summary>Get the internal codec timebase from a stream.</summary>
        /// <param name="st">input stream to extract the timebase from</param>
        public static AVRational av_stream_get_codec_timebase(AVStream* @st)
        {
            return av_stream_get_codec_timebase_fptr(@st);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_stream_get_end_pts_delegate(AVStream* @st);
        private static av_stream_get_end_pts_delegate av_stream_get_end_pts_fptr = (AVStream* @st) =>
        {
            av_stream_get_end_pts_fptr = GetFunctionDelegate<av_stream_get_end_pts_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_get_end_pts");
            if (av_stream_get_end_pts_fptr == null)
            {
                av_stream_get_end_pts_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_get_end_pts is not supported on this platform.");
                };
            }
            return av_stream_get_end_pts_fptr(@st);
        };
        /// <summary>Returns the pts of the last muxed packet + its duration</summary>
        public static long av_stream_get_end_pts(AVStream* @st)
        {
            return av_stream_get_end_pts_fptr(@st);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecParserContext* av_stream_get_parser_delegate(AVStream* @s);
        private static av_stream_get_parser_delegate av_stream_get_parser_fptr = (AVStream* @s) =>
        {
            av_stream_get_parser_fptr = GetFunctionDelegate<av_stream_get_parser_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_get_parser");
            if (av_stream_get_parser_fptr == null)
            {
                av_stream_get_parser_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_get_parser is not supported on this platform.");
                };
            }
            return av_stream_get_parser_fptr(@s);
        };
        public static AVCodecParserContext* av_stream_get_parser(AVStream* @s)
        {
            return av_stream_get_parser_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_stream_get_r_frame_rate_delegate(AVStream* @s);
        private static av_stream_get_r_frame_rate_delegate av_stream_get_r_frame_rate_fptr = (AVStream* @s) =>
        {
            av_stream_get_r_frame_rate_fptr = GetFunctionDelegate<av_stream_get_r_frame_rate_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_get_r_frame_rate");
            if (av_stream_get_r_frame_rate_fptr == null)
            {
                av_stream_get_r_frame_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_get_r_frame_rate is not supported on this platform.");
                };
            }
            return av_stream_get_r_frame_rate_fptr(@s);
        };
        public static AVRational av_stream_get_r_frame_rate(AVStream* @s)
        {
            return av_stream_get_r_frame_rate_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_stream_get_recommended_encoder_configuration_delegate(AVStream* @s);
        private static av_stream_get_recommended_encoder_configuration_delegate av_stream_get_recommended_encoder_configuration_fptr = (AVStream* @s) =>
        {
            av_stream_get_recommended_encoder_configuration_fptr = GetFunctionDelegate<av_stream_get_recommended_encoder_configuration_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_get_recommended_encoder_configuration");
            if (av_stream_get_recommended_encoder_configuration_fptr == null)
            {
                av_stream_get_recommended_encoder_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_get_recommended_encoder_configuration is not supported on this platform.");
                };
            }
            return av_stream_get_recommended_encoder_configuration_fptr(@s);
        };
        public static byte* av_stream_get_recommended_encoder_configuration(AVStream* @s)
        {
            return av_stream_get_recommended_encoder_configuration_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_stream_get_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, int* @size);
        private static av_stream_get_side_data_delegate av_stream_get_side_data_fptr = (AVStream* @stream, AVPacketSideDataType @type, int* @size) =>
        {
            av_stream_get_side_data_fptr = GetFunctionDelegate<av_stream_get_side_data_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_get_side_data");
            if (av_stream_get_side_data_fptr == null)
            {
                av_stream_get_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_get_side_data is not supported on this platform.");
                };
            }
            return av_stream_get_side_data_fptr(@stream, @type, @size);
        };
        public static byte* av_stream_get_side_data(AVStream* @stream, AVPacketSideDataType @type, int* @size)
        {
            return av_stream_get_side_data_fptr(@stream, @type, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_stream_new_side_data_delegate(AVStream* @stream, AVPacketSideDataType @type, int @size);
        private static av_stream_new_side_data_delegate av_stream_new_side_data_fptr = (AVStream* @stream, AVPacketSideDataType @type, int @size) =>
        {
            av_stream_new_side_data_fptr = GetFunctionDelegate<av_stream_new_side_data_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_new_side_data");
            if (av_stream_new_side_data_fptr == null)
            {
                av_stream_new_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_new_side_data is not supported on this platform.");
                };
            }
            return av_stream_new_side_data_fptr(@stream, @type, @size);
        };
        /// <summary>Allocate new information from stream.</summary>
        /// <param name="stream">stream</param>
        /// <param name="type">desired side information type</param>
        /// <param name="size">side information size</param>
        public static byte* av_stream_new_side_data(AVStream* @stream, AVPacketSideDataType @type, int @size)
        {
            return av_stream_new_side_data_fptr(@stream, @type, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_stream_set_r_frame_rate_delegate(AVStream* @s, AVRational @r);
        private static av_stream_set_r_frame_rate_delegate av_stream_set_r_frame_rate_fptr = (AVStream* @s, AVRational @r) =>
        {
            av_stream_set_r_frame_rate_fptr = GetFunctionDelegate<av_stream_set_r_frame_rate_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_set_r_frame_rate");
            if (av_stream_set_r_frame_rate_fptr == null)
            {
                av_stream_set_r_frame_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_set_r_frame_rate is not supported on this platform.");
                };
            }
            av_stream_set_r_frame_rate_fptr(@s, @r);
        };
        public static void av_stream_set_r_frame_rate(AVStream* @s, AVRational @r)
        {
            av_stream_set_r_frame_rate_fptr(@s, @r);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_stream_set_recommended_encoder_configuration_delegate(AVStream* @s, byte* @configuration);
        private static av_stream_set_recommended_encoder_configuration_delegate av_stream_set_recommended_encoder_configuration_fptr = (AVStream* @s, byte* @configuration) =>
        {
            av_stream_set_recommended_encoder_configuration_fptr = GetFunctionDelegate<av_stream_set_recommended_encoder_configuration_delegate>(GetOrLoadLibrary("avformat", 57), "av_stream_set_recommended_encoder_configuration");
            if (av_stream_set_recommended_encoder_configuration_fptr == null)
            {
                av_stream_set_recommended_encoder_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_stream_set_recommended_encoder_configuration is not supported on this platform.");
                };
            }
            av_stream_set_recommended_encoder_configuration_fptr(@s, @configuration);
        };
        public static void av_stream_set_recommended_encoder_configuration(AVStream* @s, byte* @configuration)
        {
            av_stream_set_recommended_encoder_configuration_fptr(@s, @configuration);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_url_split_delegate(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, [MarshalAs(UnmanagedType.LPStr)] string @url);
        private static av_url_split_delegate av_url_split_fptr = (byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, string @url) =>
        {
            av_url_split_fptr = GetFunctionDelegate<av_url_split_delegate>(GetOrLoadLibrary("avformat", 57), "av_url_split");
            if (av_url_split_fptr == null)
            {
                av_url_split_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_url_split is not supported on this platform.");
                };
            }
            av_url_split_fptr(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
        };
        /// <summary>Split a URL string into components.</summary>
        /// <param name="proto">the buffer for the protocol</param>
        /// <param name="proto_size">the size of the proto buffer</param>
        /// <param name="authorization">the buffer for the authorization</param>
        /// <param name="authorization_size">the size of the authorization buffer</param>
        /// <param name="hostname">the buffer for the host name</param>
        /// <param name="hostname_size">the size of the hostname buffer</param>
        /// <param name="port_ptr">a pointer to store the port number in</param>
        /// <param name="path">the buffer for the path</param>
        /// <param name="path_size">the size of the path buffer</param>
        /// <param name="url">the URL to split</param>
        public static void av_url_split(byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, [MarshalAs(UnmanagedType.LPStr)] string @url)
        {
            av_url_split_fptr(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_write_frame_delegate(AVFormatContext* @s, AVPacket* @pkt);
        private static av_write_frame_delegate av_write_frame_fptr = (AVFormatContext* @s, AVPacket* @pkt) =>
        {
            av_write_frame_fptr = GetFunctionDelegate<av_write_frame_delegate>(GetOrLoadLibrary("avformat", 57), "av_write_frame");
            if (av_write_frame_fptr == null)
            {
                av_write_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_write_frame is not supported on this platform.");
                };
            }
            return av_write_frame_fptr(@s, @pkt);
        };
        /// <summary>Write a packet to an output media file.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="pkt">The packet containing the data to be written. Note that unlike av_interleaved_write_frame(), this function does not take ownership of the packet passed to it (though some muxers may make an internal reference to the input packet).  This parameter can be NULL (at any time, not just at the end), in order to immediately flush data buffered within the muxer, for muxers that buffer up data internally before writing it to the output.  Packet&apos;s</param>
        public static int av_write_frame(AVFormatContext* @s, AVPacket* @pkt)
        {
            return av_write_frame_fptr(@s, @pkt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_write_trailer_delegate(AVFormatContext* @s);
        private static av_write_trailer_delegate av_write_trailer_fptr = (AVFormatContext* @s) =>
        {
            av_write_trailer_fptr = GetFunctionDelegate<av_write_trailer_delegate>(GetOrLoadLibrary("avformat", 57), "av_write_trailer");
            if (av_write_trailer_fptr == null)
            {
                av_write_trailer_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_write_trailer is not supported on this platform.");
                };
            }
            return av_write_trailer_fptr(@s);
        };
        /// <summary>Write the stream trailer to an output media file and free the file private data.</summary>
        /// <param name="s">media file handle</param>
        public static int av_write_trailer(AVFormatContext* @s)
        {
            return av_write_trailer_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_write_uncoded_frame_delegate(AVFormatContext* @s, int @stream_index, AVFrame* @frame);
        private static av_write_uncoded_frame_delegate av_write_uncoded_frame_fptr = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) =>
        {
            av_write_uncoded_frame_fptr = GetFunctionDelegate<av_write_uncoded_frame_delegate>(GetOrLoadLibrary("avformat", 57), "av_write_uncoded_frame");
            if (av_write_uncoded_frame_fptr == null)
            {
                av_write_uncoded_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_write_uncoded_frame is not supported on this platform.");
                };
            }
            return av_write_uncoded_frame_fptr(@s, @stream_index, @frame);
        };
        /// <summary>Write an uncoded frame to an output media file.</summary>
        public static int av_write_uncoded_frame(AVFormatContext* @s, int @stream_index, AVFrame* @frame)
        {
            return av_write_uncoded_frame_fptr(@s, @stream_index, @frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_write_uncoded_frame_query_delegate(AVFormatContext* @s, int @stream_index);
        private static av_write_uncoded_frame_query_delegate av_write_uncoded_frame_query_fptr = (AVFormatContext* @s, int @stream_index) =>
        {
            av_write_uncoded_frame_query_fptr = GetFunctionDelegate<av_write_uncoded_frame_query_delegate>(GetOrLoadLibrary("avformat", 57), "av_write_uncoded_frame_query");
            if (av_write_uncoded_frame_query_fptr == null)
            {
                av_write_uncoded_frame_query_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_write_uncoded_frame_query is not supported on this platform.");
                };
            }
            return av_write_uncoded_frame_query_fptr(@s, @stream_index);
        };
        /// <summary>Test whether a muxer supports uncoded frame.</summary>
        public static int av_write_uncoded_frame_query(AVFormatContext* @s, int @stream_index)
        {
            return av_write_uncoded_frame_query_fptr(@s, @stream_index);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFormatContext* avformat_alloc_context_delegate();
        private static avformat_alloc_context_delegate avformat_alloc_context_fptr = () =>
        {
            avformat_alloc_context_fptr = GetFunctionDelegate<avformat_alloc_context_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_alloc_context");
            if (avformat_alloc_context_fptr == null)
            {
                avformat_alloc_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_alloc_context is not supported on this platform.");
                };
            }
            return avformat_alloc_context_fptr();
        };
        /// <summary>Allocate an AVFormatContext. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
        public static AVFormatContext* avformat_alloc_context()
        {
            return avformat_alloc_context_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_alloc_output_context2_delegate(AVFormatContext** @ctx, AVOutputFormat* @oformat, [MarshalAs(UnmanagedType.LPStr)] string @format_name, [MarshalAs(UnmanagedType.LPStr)] string @filename);
        private static avformat_alloc_output_context2_delegate avformat_alloc_output_context2_fptr = (AVFormatContext** @ctx, AVOutputFormat* @oformat, string @format_name, string @filename) =>
        {
            avformat_alloc_output_context2_fptr = GetFunctionDelegate<avformat_alloc_output_context2_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_alloc_output_context2");
            if (avformat_alloc_output_context2_fptr == null)
            {
                avformat_alloc_output_context2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_alloc_output_context2 is not supported on this platform.");
                };
            }
            return avformat_alloc_output_context2_fptr(@ctx, @oformat, @format_name, @filename);
        };
        /// <summary>Allocate an AVFormatContext for an output format. avformat_free_context() can be used to free the context and everything allocated by the framework within it.</summary>
        /// <param name="oformat">format to use for allocating the context, if NULL format_name and filename are used instead</param>
        /// <param name="format_name">the name of output format to use for allocating the context, if NULL filename is used instead</param>
        /// <param name="filename">the name of the filename to use for allocating the context, may be NULL</param>
        public static int avformat_alloc_output_context2(AVFormatContext** @ctx, AVOutputFormat* @oformat, [MarshalAs(UnmanagedType.LPStr)] string @format_name, [MarshalAs(UnmanagedType.LPStr)] string @filename)
        {
            return avformat_alloc_output_context2_fptr(@ctx, @oformat, @format_name, @filename);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avformat_close_input_delegate(AVFormatContext** @s);
        private static avformat_close_input_delegate avformat_close_input_fptr = (AVFormatContext** @s) =>
        {
            avformat_close_input_fptr = GetFunctionDelegate<avformat_close_input_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_close_input");
            if (avformat_close_input_fptr == null)
            {
                avformat_close_input_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_close_input is not supported on this platform.");
                };
            }
            avformat_close_input_fptr(@s);
        };
        /// <summary>Close an opened input AVFormatContext. Free it and all its contents and set *s to NULL.</summary>
        public static void avformat_close_input(AVFormatContext** @s)
        {
            avformat_close_input_fptr(@s);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avformat_configuration_delegate();
        private static avformat_configuration_delegate avformat_configuration_fptr = () =>
        {
            avformat_configuration_fptr = GetFunctionDelegate<avformat_configuration_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_configuration");
            if (avformat_configuration_fptr == null)
            {
                avformat_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_configuration is not supported on this platform.");
                };
            }
            return avformat_configuration_fptr();
        };
        /// <summary>Return the libavformat build-time configuration.</summary>
        public static string avformat_configuration()
        {
            return avformat_configuration_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_find_stream_info_delegate(AVFormatContext* @ic, AVDictionary** @options);
        private static avformat_find_stream_info_delegate avformat_find_stream_info_fptr = (AVFormatContext* @ic, AVDictionary** @options) =>
        {
            avformat_find_stream_info_fptr = GetFunctionDelegate<avformat_find_stream_info_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_find_stream_info");
            if (avformat_find_stream_info_fptr == null)
            {
                avformat_find_stream_info_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_find_stream_info is not supported on this platform.");
                };
            }
            return avformat_find_stream_info_fptr(@ic, @options);
        };
        /// <summary>Read packets of a media file to get stream information. This is useful for file formats with no headers such as MPEG. This function also computes the real framerate in case of MPEG-2 repeat frame mode. The logical file position is not changed by this function; examined packets may be buffered for later processing.</summary>
        /// <param name="ic">media file handle</param>
        /// <param name="options">If non-NULL, an ic.nb_streams long array of pointers to dictionaries, where i-th member contains options for codec corresponding to i-th stream. On return each dictionary will be filled with options that were not found.</param>
        public static int avformat_find_stream_info(AVFormatContext* @ic, AVDictionary** @options)
        {
            return avformat_find_stream_info_fptr(@ic, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_flush_delegate(AVFormatContext* @s);
        private static avformat_flush_delegate avformat_flush_fptr = (AVFormatContext* @s) =>
        {
            avformat_flush_fptr = GetFunctionDelegate<avformat_flush_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_flush");
            if (avformat_flush_fptr == null)
            {
                avformat_flush_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_flush is not supported on this platform.");
                };
            }
            return avformat_flush_fptr(@s);
        };
        /// <summary>Discard all internally buffered data. This can be useful when dealing with discontinuities in the byte stream. Generally works only with formats that can resync. This includes headerless formats like MPEG-TS/TS but should also work with NUT, Ogg and in a limited way AVI for example.</summary>
        /// <param name="s">media file handle</param>
        public static int avformat_flush(AVFormatContext* @s)
        {
            return avformat_flush_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avformat_free_context_delegate(AVFormatContext* @s);
        private static avformat_free_context_delegate avformat_free_context_fptr = (AVFormatContext* @s) =>
        {
            avformat_free_context_fptr = GetFunctionDelegate<avformat_free_context_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_free_context");
            if (avformat_free_context_fptr == null)
            {
                avformat_free_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_free_context is not supported on this platform.");
                };
            }
            avformat_free_context_fptr(@s);
        };
        /// <summary>Free an AVFormatContext and all its streams.</summary>
        /// <param name="s">context to free</param>
        public static void avformat_free_context(AVFormatContext* @s)
        {
            avformat_free_context_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* avformat_get_class_delegate();
        private static avformat_get_class_delegate avformat_get_class_fptr = () =>
        {
            avformat_get_class_fptr = GetFunctionDelegate<avformat_get_class_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_get_class");
            if (avformat_get_class_fptr == null)
            {
                avformat_get_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_get_class is not supported on this platform.");
                };
            }
            return avformat_get_class_fptr();
        };
        /// <summary>Get the AVClass for AVFormatContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* avformat_get_class()
        {
            return avformat_get_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecTag* avformat_get_mov_audio_tags_delegate();
        private static avformat_get_mov_audio_tags_delegate avformat_get_mov_audio_tags_fptr = () =>
        {
            avformat_get_mov_audio_tags_fptr = GetFunctionDelegate<avformat_get_mov_audio_tags_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_get_mov_audio_tags");
            if (avformat_get_mov_audio_tags_fptr == null)
            {
                avformat_get_mov_audio_tags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_get_mov_audio_tags is not supported on this platform.");
                };
            }
            return avformat_get_mov_audio_tags_fptr();
        };
        /// <summary>Returns the table mapping MOV FourCCs for audio to AVCodecID.</summary>
        public static AVCodecTag* avformat_get_mov_audio_tags()
        {
            return avformat_get_mov_audio_tags_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecTag* avformat_get_mov_video_tags_delegate();
        private static avformat_get_mov_video_tags_delegate avformat_get_mov_video_tags_fptr = () =>
        {
            avformat_get_mov_video_tags_fptr = GetFunctionDelegate<avformat_get_mov_video_tags_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_get_mov_video_tags");
            if (avformat_get_mov_video_tags_fptr == null)
            {
                avformat_get_mov_video_tags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_get_mov_video_tags is not supported on this platform.");
                };
            }
            return avformat_get_mov_video_tags_fptr();
        };
        /// <summary>Returns the table mapping MOV FourCCs for video to libavcodec AVCodecID.</summary>
        public static AVCodecTag* avformat_get_mov_video_tags()
        {
            return avformat_get_mov_video_tags_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecTag* avformat_get_riff_audio_tags_delegate();
        private static avformat_get_riff_audio_tags_delegate avformat_get_riff_audio_tags_fptr = () =>
        {
            avformat_get_riff_audio_tags_fptr = GetFunctionDelegate<avformat_get_riff_audio_tags_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_get_riff_audio_tags");
            if (avformat_get_riff_audio_tags_fptr == null)
            {
                avformat_get_riff_audio_tags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_get_riff_audio_tags is not supported on this platform.");
                };
            }
            return avformat_get_riff_audio_tags_fptr();
        };
        /// <summary>Returns the table mapping RIFF FourCCs for audio to AVCodecID.</summary>
        public static AVCodecTag* avformat_get_riff_audio_tags()
        {
            return avformat_get_riff_audio_tags_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVCodecTag* avformat_get_riff_video_tags_delegate();
        private static avformat_get_riff_video_tags_delegate avformat_get_riff_video_tags_fptr = () =>
        {
            avformat_get_riff_video_tags_fptr = GetFunctionDelegate<avformat_get_riff_video_tags_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_get_riff_video_tags");
            if (avformat_get_riff_video_tags_fptr == null)
            {
                avformat_get_riff_video_tags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_get_riff_video_tags is not supported on this platform.");
                };
            }
            return avformat_get_riff_video_tags_fptr();
        };
        /// <summary>@{ Get the tables mapping RIFF FourCCs to libavcodec AVCodecIDs. The tables are meant to be passed to av_codec_get_id()/av_codec_get_tag() as in the following code:</summary>
        public static AVCodecTag* avformat_get_riff_video_tags()
        {
            return avformat_get_riff_video_tags_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_init_output_delegate(AVFormatContext* @s, AVDictionary** @options);
        private static avformat_init_output_delegate avformat_init_output_fptr = (AVFormatContext* @s, AVDictionary** @options) =>
        {
            avformat_init_output_fptr = GetFunctionDelegate<avformat_init_output_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_init_output");
            if (avformat_init_output_fptr == null)
            {
                avformat_init_output_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_init_output is not supported on this platform.");
                };
            }
            return avformat_init_output_fptr(@s, @options);
        };
        /// <summary>Allocate the stream private data and initialize the codec, but do not write the header. May optionally be used before avformat_write_header to initialize stream parameters before actually writing the header. If using this function, do not pass the same options to avformat_write_header.</summary>
        /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its oformat field must be set to the desired output format; Its pb field must be set to an already opened AVIOContext.</param>
        /// <param name="options">An AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        public static int avformat_init_output(AVFormatContext* @s, AVDictionary** @options)
        {
            return avformat_init_output_fptr(@s, @options);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avformat_license_delegate();
        private static avformat_license_delegate avformat_license_fptr = () =>
        {
            avformat_license_fptr = GetFunctionDelegate<avformat_license_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_license");
            if (avformat_license_fptr == null)
            {
                avformat_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_license is not supported on this platform.");
                };
            }
            return avformat_license_fptr();
        };
        /// <summary>Return the libavformat license.</summary>
        public static string avformat_license()
        {
            return avformat_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_match_stream_specifier_delegate(AVFormatContext* @s, AVStream* @st, [MarshalAs(UnmanagedType.LPStr)] string @spec);
        private static avformat_match_stream_specifier_delegate avformat_match_stream_specifier_fptr = (AVFormatContext* @s, AVStream* @st, string @spec) =>
        {
            avformat_match_stream_specifier_fptr = GetFunctionDelegate<avformat_match_stream_specifier_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_match_stream_specifier");
            if (avformat_match_stream_specifier_fptr == null)
            {
                avformat_match_stream_specifier_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_match_stream_specifier is not supported on this platform.");
                };
            }
            return avformat_match_stream_specifier_fptr(@s, @st, @spec);
        };
        /// <summary>Check if the stream st contained in s is matched by the stream specifier spec.</summary>
        public static int avformat_match_stream_specifier(AVFormatContext* @s, AVStream* @st, [MarshalAs(UnmanagedType.LPStr)] string @spec)
        {
            return avformat_match_stream_specifier_fptr(@s, @st, @spec);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_network_deinit_delegate();
        private static avformat_network_deinit_delegate avformat_network_deinit_fptr = () =>
        {
            avformat_network_deinit_fptr = GetFunctionDelegate<avformat_network_deinit_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_network_deinit");
            if (avformat_network_deinit_fptr == null)
            {
                avformat_network_deinit_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_network_deinit is not supported on this platform.");
                };
            }
            return avformat_network_deinit_fptr();
        };
        /// <summary>Undo the initialization done by avformat_network_init.</summary>
        public static int avformat_network_deinit()
        {
            return avformat_network_deinit_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_network_init_delegate();
        private static avformat_network_init_delegate avformat_network_init_fptr = () =>
        {
            avformat_network_init_fptr = GetFunctionDelegate<avformat_network_init_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_network_init");
            if (avformat_network_init_fptr == null)
            {
                avformat_network_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_network_init is not supported on this platform.");
                };
            }
            return avformat_network_init_fptr();
        };
        /// <summary>Do global initialization of network components. This is optional, but recommended, since it avoids the overhead of implicitly doing the setup for each session.</summary>
        public static int avformat_network_init()
        {
            return avformat_network_init_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVStream* avformat_new_stream_delegate(AVFormatContext* @s, AVCodec* @c);
        private static avformat_new_stream_delegate avformat_new_stream_fptr = (AVFormatContext* @s, AVCodec* @c) =>
        {
            avformat_new_stream_fptr = GetFunctionDelegate<avformat_new_stream_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_new_stream");
            if (avformat_new_stream_fptr == null)
            {
                avformat_new_stream_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_new_stream is not supported on this platform.");
                };
            }
            return avformat_new_stream_fptr(@s, @c);
        };
        /// <summary>Add a new stream to a media file.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="c">If non-NULL, the AVCodecContext corresponding to the new stream will be initialized to use this codec. This is needed for e.g. codec-specific defaults to be set, so codec should be provided if it is known.</param>
        public static AVStream* avformat_new_stream(AVFormatContext* @s, AVCodec* @c)
        {
            return avformat_new_stream_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_open_input_delegate(AVFormatContext** @ps, IntPtr @url, AVInputFormat* @fmt, AVDictionary** @options);
        private static avformat_open_input_delegate avformat_open_input_fptr = (AVFormatContext** @ps, IntPtr @url, AVInputFormat* @fmt, AVDictionary** @options) =>
        {
            avformat_open_input_fptr = GetFunctionDelegate<avformat_open_input_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_open_input");
            if (avformat_open_input_fptr == null)
            {
                avformat_open_input_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_open_input is not supported on this platform.");
                };
            }
            return avformat_open_input_fptr(@ps, @url, @fmt, @options);
        };
        /// <summary>Open an input stream and read the header. The codecs are not opened. The stream must be closed with avformat_close_input().</summary>
        /// <param name="ps">Pointer to user-supplied AVFormatContext (allocated by avformat_alloc_context). May be a pointer to NULL, in which case an AVFormatContext is allocated by this function and written into ps. Note that a user-supplied AVFormatContext will be freed on failure.</param>
        /// <param name="url">URL of the stream to open.</param>
        /// <param name="fmt">If non-NULL, this parameter forces a specific input format. Otherwise the format is autodetected.</param>
        /// <param name="options">A dictionary filled with AVFormatContext and demuxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        public static int avformat_open_input(AVFormatContext** @ps, IntPtr @url, AVInputFormat* @fmt, AVDictionary** @options)
        {
            return avformat_open_input_fptr(@ps, @url, @fmt, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_query_codec_delegate(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance);
        private static avformat_query_codec_delegate avformat_query_codec_fptr = (AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance) =>
        {
            avformat_query_codec_fptr = GetFunctionDelegate<avformat_query_codec_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_query_codec");
            if (avformat_query_codec_fptr == null)
            {
                avformat_query_codec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_query_codec is not supported on this platform.");
                };
            }
            return avformat_query_codec_fptr(@ofmt, @codec_id, @std_compliance);
        };
        /// <summary>Test if the given container can store a codec.</summary>
        /// <param name="ofmt">container to check for compatibility</param>
        /// <param name="codec_id">codec to potentially store in container</param>
        /// <param name="std_compliance">standards compliance level, one of FF_COMPLIANCE_*</param>
        public static int avformat_query_codec(AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance)
        {
            return avformat_query_codec_fptr(@ofmt, @codec_id, @std_compliance);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_queue_attached_pictures_delegate(AVFormatContext* @s);
        private static avformat_queue_attached_pictures_delegate avformat_queue_attached_pictures_fptr = (AVFormatContext* @s) =>
        {
            avformat_queue_attached_pictures_fptr = GetFunctionDelegate<avformat_queue_attached_pictures_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_queue_attached_pictures");
            if (avformat_queue_attached_pictures_fptr == null)
            {
                avformat_queue_attached_pictures_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_queue_attached_pictures is not supported on this platform.");
                };
            }
            return avformat_queue_attached_pictures_fptr(@s);
        };
        public static int avformat_queue_attached_pictures(AVFormatContext* @s)
        {
            return avformat_queue_attached_pictures_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_seek_file_delegate(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags);
        private static avformat_seek_file_delegate avformat_seek_file_fptr = (AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags) =>
        {
            avformat_seek_file_fptr = GetFunctionDelegate<avformat_seek_file_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_seek_file");
            if (avformat_seek_file_fptr == null)
            {
                avformat_seek_file_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_seek_file is not supported on this platform.");
                };
            }
            return avformat_seek_file_fptr(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
        };
        /// <summary>Seek to timestamp ts. Seeking will be done so that the point from which all active streams can be presented successfully will be closest to ts and within min/max_ts. Active streams are all streams that have AVStream.discard &lt; AVDISCARD_ALL.</summary>
        /// <param name="s">media file handle</param>
        /// <param name="stream_index">index of the stream which is used as time base reference</param>
        /// <param name="min_ts">smallest acceptable timestamp</param>
        /// <param name="ts">target timestamp</param>
        /// <param name="max_ts">largest acceptable timestamp</param>
        /// <param name="flags">flags</param>
        public static int avformat_seek_file(AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags)
        {
            return avformat_seek_file_fptr(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_transfer_internal_stream_timing_info_delegate(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb);
        private static avformat_transfer_internal_stream_timing_info_delegate avformat_transfer_internal_stream_timing_info_fptr = (AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb) =>
        {
            avformat_transfer_internal_stream_timing_info_fptr = GetFunctionDelegate<avformat_transfer_internal_stream_timing_info_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_transfer_internal_stream_timing_info");
            if (avformat_transfer_internal_stream_timing_info_fptr == null)
            {
                avformat_transfer_internal_stream_timing_info_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_transfer_internal_stream_timing_info is not supported on this platform.");
                };
            }
            return avformat_transfer_internal_stream_timing_info_fptr(@ofmt, @ost, @ist, @copy_tb);
        };
        /// <summary>Transfer internal timing information from one stream to another.</summary>
        /// <param name="ofmt">target output format for ost</param>
        /// <param name="ost">output stream which needs timings copy and adjustments</param>
        /// <param name="ist">reference input stream to copy timings from</param>
        /// <param name="copy_tb">define from where the stream codec timebase needs to be imported</param>
        public static int avformat_transfer_internal_stream_timing_info(AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb)
        {
            return avformat_transfer_internal_stream_timing_info_fptr(@ofmt, @ost, @ist, @copy_tb);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avformat_version_delegate();
        private static avformat_version_delegate avformat_version_fptr = () =>
        {
            avformat_version_fptr = GetFunctionDelegate<avformat_version_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_version");
            if (avformat_version_fptr == null)
            {
                avformat_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_version is not supported on this platform.");
                };
            }
            return avformat_version_fptr();
        };
        /// <summary>Return the LIBAVFORMAT_VERSION_INT constant.</summary>
        public static uint avformat_version()
        {
            return avformat_version_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avformat_write_header_delegate(AVFormatContext* @s, AVDictionary** @options);
        private static avformat_write_header_delegate avformat_write_header_fptr = (AVFormatContext* @s, AVDictionary** @options) =>
        {
            avformat_write_header_fptr = GetFunctionDelegate<avformat_write_header_delegate>(GetOrLoadLibrary("avformat", 57), "avformat_write_header");
            if (avformat_write_header_fptr == null)
            {
                avformat_write_header_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avformat_write_header is not supported on this platform.");
                };
            }
            return avformat_write_header_fptr(@s, @options);
        };
        /// <summary>Allocate the stream private data and write the stream header to an output media file.</summary>
        /// <param name="s">Media file handle, must be allocated with avformat_alloc_context(). Its oformat field must be set to the desired output format; Its pb field must be set to an already opened AVIOContext.</param>
        /// <param name="options">An AVDictionary filled with AVFormatContext and muxer-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        public static int avformat_write_header(AVFormatContext* @s, AVDictionary** @options)
        {
            return avformat_write_header_fptr(@s, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_accept_delegate(AVIOContext* @s, AVIOContext** @c);
        private static avio_accept_delegate avio_accept_fptr = (AVIOContext* @s, AVIOContext** @c) =>
        {
            avio_accept_fptr = GetFunctionDelegate<avio_accept_delegate>(GetOrLoadLibrary("avformat", 57), "avio_accept");
            if (avio_accept_fptr == null)
            {
                avio_accept_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_accept is not supported on this platform.");
                };
            }
            return avio_accept_fptr(@s, @c);
        };
        /// <summary>Accept and allocate a client context on a server context.</summary>
        /// <param name="s">the server context</param>
        /// <param name="c">the client context, must be unallocated</param>
        public static int avio_accept(AVIOContext* @s, AVIOContext** @c)
        {
            return avio_accept_fptr(@s, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVIOContext* avio_alloc_context_delegate(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek);
        private static avio_alloc_context_delegate avio_alloc_context_fptr = (byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek) =>
        {
            avio_alloc_context_fptr = GetFunctionDelegate<avio_alloc_context_delegate>(GetOrLoadLibrary("avformat", 57), "avio_alloc_context");
            if (avio_alloc_context_fptr == null)
            {
                avio_alloc_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_alloc_context is not supported on this platform.");
                };
            }
            return avio_alloc_context_fptr(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
        };
        /// <summary>Allocate and initialize an AVIOContext for buffered I/O. It must be later freed with avio_context_free().</summary>
        /// <param name="buffer">Memory block for input/output operations via AVIOContext. The buffer must be allocated with av_malloc() and friends. It may be freed and replaced with a new buffer by libavformat. AVIOContext.buffer holds the buffer currently in use, which must be later freed with av_free().</param>
        /// <param name="buffer_size">The buffer size is very important for performance. For protocols with fixed blocksize it should be set to this blocksize. For others a typical size is a cache page, e.g. 4kb.</param>
        /// <param name="write_flag">Set to 1 if the buffer should be writable, 0 otherwise.</param>
        /// <param name="opaque">An opaque pointer to user-specific data.</param>
        /// <param name="read_packet">A function for refilling the buffer, may be NULL.</param>
        /// <param name="write_packet">A function for writing the buffer contents, may be NULL. The function may not change the input buffers content.</param>
        /// <param name="seek">A function for seeking to specified byte position, may be NULL.</param>
        public static AVIOContext* avio_alloc_context(byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek)
        {
            return avio_alloc_context_fptr(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_check_delegate([MarshalAs(UnmanagedType.LPStr)] string @url, int @flags);
        private static avio_check_delegate avio_check_fptr = (string @url, int @flags) =>
        {
            avio_check_fptr = GetFunctionDelegate<avio_check_delegate>(GetOrLoadLibrary("avformat", 57), "avio_check");
            if (avio_check_fptr == null)
            {
                avio_check_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_check is not supported on this platform.");
                };
            }
            return avio_check_fptr(@url, @flags);
        };
        /// <summary>Return AVIO_FLAG_* access flags corresponding to the access permissions of the resource in url, or a negative value corresponding to an AVERROR code in case of failure. The returned access flags are masked by the value in flags.</summary>
        public static int avio_check([MarshalAs(UnmanagedType.LPStr)] string @url, int @flags)
        {
            return avio_check_fptr(@url, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_close_delegate(AVIOContext* @s);
        private static avio_close_delegate avio_close_fptr = (AVIOContext* @s) =>
        {
            avio_close_fptr = GetFunctionDelegate<avio_close_delegate>(GetOrLoadLibrary("avformat", 57), "avio_close");
            if (avio_close_fptr == null)
            {
                avio_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_close is not supported on this platform.");
                };
            }
            return avio_close_fptr(@s);
        };
        /// <summary>Close the resource accessed by the AVIOContext s and free it. This function can only be used if s was opened by avio_open().</summary>
        public static int avio_close(AVIOContext* @s)
        {
            return avio_close_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_close_dir_delegate(AVIODirContext** @s);
        private static avio_close_dir_delegate avio_close_dir_fptr = (AVIODirContext** @s) =>
        {
            avio_close_dir_fptr = GetFunctionDelegate<avio_close_dir_delegate>(GetOrLoadLibrary("avformat", 57), "avio_close_dir");
            if (avio_close_dir_fptr == null)
            {
                avio_close_dir_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_close_dir is not supported on this platform.");
                };
            }
            return avio_close_dir_fptr(@s);
        };
        /// <summary>Close directory.</summary>
        /// <param name="s">directory read context.</param>
        public static int avio_close_dir(AVIODirContext** @s)
        {
            return avio_close_dir_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_close_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);
        private static avio_close_dyn_buf_delegate avio_close_dyn_buf_fptr = (AVIOContext* @s, byte** @pbuffer) =>
        {
            avio_close_dyn_buf_fptr = GetFunctionDelegate<avio_close_dyn_buf_delegate>(GetOrLoadLibrary("avformat", 57), "avio_close_dyn_buf");
            if (avio_close_dyn_buf_fptr == null)
            {
                avio_close_dyn_buf_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_close_dyn_buf is not supported on this platform.");
                };
            }
            return avio_close_dyn_buf_fptr(@s, @pbuffer);
        };
        /// <summary>Return the written size and a pointer to the buffer. The buffer must be freed with av_free(). Padding of AV_INPUT_BUFFER_PADDING_SIZE is added to the buffer.</summary>
        /// <param name="s">IO context</param>
        /// <param name="pbuffer">pointer to a byte buffer</param>
        public static int avio_close_dyn_buf(AVIOContext* @s, byte** @pbuffer)
        {
            return avio_close_dyn_buf_fptr(@s, @pbuffer);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_closep_delegate(AVIOContext** @s);
        private static avio_closep_delegate avio_closep_fptr = (AVIOContext** @s) =>
        {
            avio_closep_fptr = GetFunctionDelegate<avio_closep_delegate>(GetOrLoadLibrary("avformat", 57), "avio_closep");
            if (avio_closep_fptr == null)
            {
                avio_closep_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_closep is not supported on this platform.");
                };
            }
            return avio_closep_fptr(@s);
        };
        /// <summary>Close the resource accessed by the AVIOContext *s, free it and set the pointer pointing to it to NULL. This function can only be used if s was opened by avio_open().</summary>
        public static int avio_closep(AVIOContext** @s)
        {
            return avio_closep_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_context_free_delegate(AVIOContext** @s);
        private static avio_context_free_delegate avio_context_free_fptr = (AVIOContext** @s) =>
        {
            avio_context_free_fptr = GetFunctionDelegate<avio_context_free_delegate>(GetOrLoadLibrary("avformat", 57), "avio_context_free");
            if (avio_context_free_fptr == null)
            {
                avio_context_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_context_free is not supported on this platform.");
                };
            }
            avio_context_free_fptr(@s);
        };
        /// <summary>Free the supplied IO context and everything associated with it.</summary>
        /// <param name="s">Double pointer to the IO context. This function will write NULL into s.</param>
        public static void avio_context_free(AVIOContext** @s)
        {
            avio_context_free_fptr(@s);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avio_enum_protocols_delegate(void** @opaque, int @output);
        private static avio_enum_protocols_delegate avio_enum_protocols_fptr = (void** @opaque, int @output) =>
        {
            avio_enum_protocols_fptr = GetFunctionDelegate<avio_enum_protocols_delegate>(GetOrLoadLibrary("avformat", 57), "avio_enum_protocols");
            if (avio_enum_protocols_fptr == null)
            {
                avio_enum_protocols_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_enum_protocols is not supported on this platform.");
                };
            }
            return avio_enum_protocols_fptr(@opaque, @output);
        };
        /// <summary>Iterate through names of available protocols.</summary>
        /// <param name="opaque">A private pointer representing current protocol. It must be a pointer to NULL on first iteration and will be updated by successive calls to avio_enum_protocols.</param>
        /// <param name="output">If set to 1, iterate over output protocols, otherwise over input protocols.</param>
        public static string avio_enum_protocols(void** @opaque, int @output)
        {
            return avio_enum_protocols_fptr(@opaque, @output);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_feof_delegate(AVIOContext* @s);
        private static avio_feof_delegate avio_feof_fptr = (AVIOContext* @s) =>
        {
            avio_feof_fptr = GetFunctionDelegate<avio_feof_delegate>(GetOrLoadLibrary("avformat", 57), "avio_feof");
            if (avio_feof_fptr == null)
            {
                avio_feof_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_feof is not supported on this platform.");
                };
            }
            return avio_feof_fptr(@s);
        };
        /// <summary>feof() equivalent for AVIOContext.</summary>
        public static int avio_feof(AVIOContext* @s)
        {
            return avio_feof_fptr(@s);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avio_find_protocol_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @url);
        private static avio_find_protocol_name_delegate avio_find_protocol_name_fptr = (string @url) =>
        {
            avio_find_protocol_name_fptr = GetFunctionDelegate<avio_find_protocol_name_delegate>(GetOrLoadLibrary("avformat", 57), "avio_find_protocol_name");
            if (avio_find_protocol_name_fptr == null)
            {
                avio_find_protocol_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_find_protocol_name is not supported on this platform.");
                };
            }
            return avio_find_protocol_name_fptr(@url);
        };
        /// <summary>Return the name of the protocol that will handle the passed URL.</summary>
        public static string avio_find_protocol_name([MarshalAs(UnmanagedType.LPStr)] string @url)
        {
            return avio_find_protocol_name_fptr(@url);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_flush_delegate(AVIOContext* @s);
        private static avio_flush_delegate avio_flush_fptr = (AVIOContext* @s) =>
        {
            avio_flush_fptr = GetFunctionDelegate<avio_flush_delegate>(GetOrLoadLibrary("avformat", 57), "avio_flush");
            if (avio_flush_fptr == null)
            {
                avio_flush_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_flush is not supported on this platform.");
                };
            }
            avio_flush_fptr(@s);
        };
        /// <summary>Force flushing of buffered data.</summary>
        public static void avio_flush(AVIOContext* @s)
        {
            avio_flush_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_free_directory_entry_delegate(AVIODirEntry** @entry);
        private static avio_free_directory_entry_delegate avio_free_directory_entry_fptr = (AVIODirEntry** @entry) =>
        {
            avio_free_directory_entry_fptr = GetFunctionDelegate<avio_free_directory_entry_delegate>(GetOrLoadLibrary("avformat", 57), "avio_free_directory_entry");
            if (avio_free_directory_entry_fptr == null)
            {
                avio_free_directory_entry_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_free_directory_entry is not supported on this platform.");
                };
            }
            avio_free_directory_entry_fptr(@entry);
        };
        /// <summary>Free entry allocated by avio_read_dir().</summary>
        /// <param name="entry">entry to be freed.</param>
        public static void avio_free_directory_entry(AVIODirEntry** @entry)
        {
            avio_free_directory_entry_fptr(@entry);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_get_dyn_buf_delegate(AVIOContext* @s, byte** @pbuffer);
        private static avio_get_dyn_buf_delegate avio_get_dyn_buf_fptr = (AVIOContext* @s, byte** @pbuffer) =>
        {
            avio_get_dyn_buf_fptr = GetFunctionDelegate<avio_get_dyn_buf_delegate>(GetOrLoadLibrary("avformat", 57), "avio_get_dyn_buf");
            if (avio_get_dyn_buf_fptr == null)
            {
                avio_get_dyn_buf_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_get_dyn_buf is not supported on this platform.");
                };
            }
            return avio_get_dyn_buf_fptr(@s, @pbuffer);
        };
        /// <summary>Return the written size and a pointer to the buffer. The AVIOContext stream is left intact. The buffer must NOT be freed. No padding is added to the buffer.</summary>
        /// <param name="s">IO context</param>
        /// <param name="pbuffer">pointer to a byte buffer</param>
        public static int avio_get_dyn_buf(AVIOContext* @s, byte** @pbuffer)
        {
            return avio_get_dyn_buf_fptr(@s, @pbuffer);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_get_str_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        private static avio_get_str_delegate avio_get_str_fptr = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
        {
            avio_get_str_fptr = GetFunctionDelegate<avio_get_str_delegate>(GetOrLoadLibrary("avformat", 57), "avio_get_str");
            if (avio_get_str_fptr == null)
            {
                avio_get_str_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_get_str is not supported on this platform.");
                };
            }
            return avio_get_str_fptr(@pb, @maxlen, @buf, @buflen);
        };
        /// <summary>Read a string from pb into buf. The reading will terminate when either a NULL character was encountered, maxlen bytes have been read, or nothing more can be read from pb. The result is guaranteed to be NULL-terminated, it will be truncated if buf is too small. Note that the string is not interpreted or validated in any way, it might get truncated in the middle of a sequence for multi-byte encodings.</summary>
        public static int avio_get_str(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
        {
            return avio_get_str_fptr(@pb, @maxlen, @buf, @buflen);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_get_str16be_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        private static avio_get_str16be_delegate avio_get_str16be_fptr = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
        {
            avio_get_str16be_fptr = GetFunctionDelegate<avio_get_str16be_delegate>(GetOrLoadLibrary("avformat", 57), "avio_get_str16be");
            if (avio_get_str16be_fptr == null)
            {
                avio_get_str16be_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_get_str16be is not supported on this platform.");
                };
            }
            return avio_get_str16be_fptr(@pb, @maxlen, @buf, @buflen);
        };
        public static int avio_get_str16be(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
        {
            return avio_get_str16be_fptr(@pb, @maxlen, @buf, @buflen);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_get_str16le_delegate(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen);
        private static avio_get_str16le_delegate avio_get_str16le_fptr = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
        {
            avio_get_str16le_fptr = GetFunctionDelegate<avio_get_str16le_delegate>(GetOrLoadLibrary("avformat", 57), "avio_get_str16le");
            if (avio_get_str16le_fptr == null)
            {
                avio_get_str16le_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_get_str16le is not supported on this platform.");
                };
            }
            return avio_get_str16le_fptr(@pb, @maxlen, @buf, @buflen);
        };
        /// <summary>Read a UTF-16 string from pb and convert it to UTF-8. The reading will terminate when either a null or invalid character was encountered or maxlen bytes have been read.</summary>
        public static int avio_get_str16le(AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen)
        {
            return avio_get_str16le_fptr(@pb, @maxlen, @buf, @buflen);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_handshake_delegate(AVIOContext* @c);
        private static avio_handshake_delegate avio_handshake_fptr = (AVIOContext* @c) =>
        {
            avio_handshake_fptr = GetFunctionDelegate<avio_handshake_delegate>(GetOrLoadLibrary("avformat", 57), "avio_handshake");
            if (avio_handshake_fptr == null)
            {
                avio_handshake_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_handshake is not supported on this platform.");
                };
            }
            return avio_handshake_fptr(@c);
        };
        /// <summary>Perform one step of the protocol handshake to accept a new client. This function must be called on a client returned by avio_accept() before using it as a read/write context. It is separate from avio_accept() because it may block. A step of the handshake is defined by places where the application may decide to change the proceedings. For example, on a protocol with a request header and a reply header, each one can constitute a step because the application may use the parameters from the request to change parameters in the reply; or each individual chunk of the request can constitute a step. If the handshake is already finished, avio_handshake() does nothing and returns 0 immediately.</summary>
        /// <param name="c">the client context to perform the handshake on</param>
        public static int avio_handshake(AVIOContext* @c)
        {
            return avio_handshake_fptr(@c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_open_delegate(AVIOContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags);
        private static avio_open_delegate avio_open_fptr = (AVIOContext** @s, string @url, int @flags) =>
        {
            avio_open_fptr = GetFunctionDelegate<avio_open_delegate>(GetOrLoadLibrary("avformat", 57), "avio_open");
            if (avio_open_fptr == null)
            {
                avio_open_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_open is not supported on this platform.");
                };
            }
            return avio_open_fptr(@s, @url, @flags);
        };
        /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
        /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
        /// <param name="url">resource to access</param>
        /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
        public static int avio_open(AVIOContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags)
        {
            return avio_open_fptr(@s, @url, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_open_dir_delegate(AVIODirContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, AVDictionary** @options);
        private static avio_open_dir_delegate avio_open_dir_fptr = (AVIODirContext** @s, string @url, AVDictionary** @options) =>
        {
            avio_open_dir_fptr = GetFunctionDelegate<avio_open_dir_delegate>(GetOrLoadLibrary("avformat", 57), "avio_open_dir");
            if (avio_open_dir_fptr == null)
            {
                avio_open_dir_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_open_dir is not supported on this platform.");
                };
            }
            return avio_open_dir_fptr(@s, @url, @options);
        };
        /// <summary>Open directory for reading.</summary>
        /// <param name="s">directory read context. Pointer to a NULL pointer must be passed.</param>
        /// <param name="url">directory to be listed.</param>
        /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dictionary containing options that were not found. May be NULL.</param>
        public static int avio_open_dir(AVIODirContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, AVDictionary** @options)
        {
            return avio_open_dir_fptr(@s, @url, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_open_dyn_buf_delegate(AVIOContext** @s);
        private static avio_open_dyn_buf_delegate avio_open_dyn_buf_fptr = (AVIOContext** @s) =>
        {
            avio_open_dyn_buf_fptr = GetFunctionDelegate<avio_open_dyn_buf_delegate>(GetOrLoadLibrary("avformat", 57), "avio_open_dyn_buf");
            if (avio_open_dyn_buf_fptr == null)
            {
                avio_open_dyn_buf_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_open_dyn_buf is not supported on this platform.");
                };
            }
            return avio_open_dyn_buf_fptr(@s);
        };
        /// <summary>Open a write only memory stream.</summary>
        /// <param name="s">new IO context</param>
        public static int avio_open_dyn_buf(AVIOContext** @s)
        {
            return avio_open_dyn_buf_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_open2_delegate(AVIOContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options);
        private static avio_open2_delegate avio_open2_fptr = (AVIOContext** @s, string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options) =>
        {
            avio_open2_fptr = GetFunctionDelegate<avio_open2_delegate>(GetOrLoadLibrary("avformat", 57), "avio_open2");
            if (avio_open2_fptr == null)
            {
                avio_open2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_open2 is not supported on this platform.");
                };
            }
            return avio_open2_fptr(@s, @url, @flags, @int_cb, @options);
        };
        /// <summary>Create and initialize a AVIOContext for accessing the resource indicated by url.</summary>
        /// <param name="s">Used to return the pointer to the created AVIOContext. In case of failure the pointed to value is set to NULL.</param>
        /// <param name="url">resource to access</param>
        /// <param name="flags">flags which control how the resource indicated by url is to be opened</param>
        /// <param name="int_cb">an interrupt callback to be used at the protocols level</param>
        /// <param name="options">A dictionary filled with protocol-private options. On return this parameter will be destroyed and replaced with a dict containing options that were not found. May be NULL.</param>
        public static int avio_open2(AVIOContext** @s, [MarshalAs(UnmanagedType.LPStr)] string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options)
        {
            return avio_open2_fptr(@s, @url, @flags, @int_cb, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_pause_delegate(AVIOContext* @h, int @pause);
        private static avio_pause_delegate avio_pause_fptr = (AVIOContext* @h, int @pause) =>
        {
            avio_pause_fptr = GetFunctionDelegate<avio_pause_delegate>(GetOrLoadLibrary("avformat", 57), "avio_pause");
            if (avio_pause_fptr == null)
            {
                avio_pause_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_pause is not supported on this platform.");
                };
            }
            return avio_pause_fptr(@h, @pause);
        };
        /// <summary>Pause and resume playing - only meaningful if using a network streaming protocol (e.g. MMS).</summary>
        /// <param name="h">IO context from which to call the read_pause function pointer</param>
        /// <param name="pause">1 for pause, 0 for resume</param>
        public static int avio_pause(AVIOContext* @h, int @pause)
        {
            return avio_pause_fptr(@h, @pause);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_printf_delegate(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @fmt);
        private static avio_printf_delegate avio_printf_fptr = (AVIOContext* @s, string @fmt) =>
        {
            avio_printf_fptr = GetFunctionDelegate<avio_printf_delegate>(GetOrLoadLibrary("avformat", 57), "avio_printf");
            if (avio_printf_fptr == null)
            {
                avio_printf_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_printf is not supported on this platform.");
                };
            }
            return avio_printf_fptr(@s, @fmt);
        };
        public static int avio_printf(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @fmt)
        {
            return avio_printf_fptr(@s, @fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_put_str_delegate(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str);
        private static avio_put_str_delegate avio_put_str_fptr = (AVIOContext* @s, string @str) =>
        {
            avio_put_str_fptr = GetFunctionDelegate<avio_put_str_delegate>(GetOrLoadLibrary("avformat", 57), "avio_put_str");
            if (avio_put_str_fptr == null)
            {
                avio_put_str_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_put_str is not supported on this platform.");
                };
            }
            return avio_put_str_fptr(@s, @str);
        };
        /// <summary>Write a NULL-terminated string.</summary>
        public static int avio_put_str(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str)
        {
            return avio_put_str_fptr(@s, @str);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_put_str16be_delegate(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str);
        private static avio_put_str16be_delegate avio_put_str16be_fptr = (AVIOContext* @s, string @str) =>
        {
            avio_put_str16be_fptr = GetFunctionDelegate<avio_put_str16be_delegate>(GetOrLoadLibrary("avformat", 57), "avio_put_str16be");
            if (avio_put_str16be_fptr == null)
            {
                avio_put_str16be_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_put_str16be is not supported on this platform.");
                };
            }
            return avio_put_str16be_fptr(@s, @str);
        };
        /// <summary>Convert an UTF-8 string to UTF-16BE and write it.</summary>
        /// <param name="s">the AVIOContext</param>
        /// <param name="str">NULL-terminated UTF-8 string</param>
        public static int avio_put_str16be(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str)
        {
            return avio_put_str16be_fptr(@s, @str);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_put_str16le_delegate(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str);
        private static avio_put_str16le_delegate avio_put_str16le_fptr = (AVIOContext* @s, string @str) =>
        {
            avio_put_str16le_fptr = GetFunctionDelegate<avio_put_str16le_delegate>(GetOrLoadLibrary("avformat", 57), "avio_put_str16le");
            if (avio_put_str16le_fptr == null)
            {
                avio_put_str16le_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_put_str16le is not supported on this platform.");
                };
            }
            return avio_put_str16le_fptr(@s, @str);
        };
        /// <summary>Convert an UTF-8 string to UTF-16LE and write it.</summary>
        /// <param name="s">the AVIOContext</param>
        /// <param name="str">NULL-terminated UTF-8 string</param>
        public static int avio_put_str16le(AVIOContext* @s, [MarshalAs(UnmanagedType.LPStr)] string @str)
        {
            return avio_put_str16le_fptr(@s, @str);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_r8_delegate(AVIOContext* @s);
        private static avio_r8_delegate avio_r8_fptr = (AVIOContext* @s) =>
        {
            avio_r8_fptr = GetFunctionDelegate<avio_r8_delegate>(GetOrLoadLibrary("avformat", 57), "avio_r8");
            if (avio_r8_fptr == null)
            {
                avio_r8_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_r8 is not supported on this platform.");
                };
            }
            return avio_r8_fptr(@s);
        };
        /// <summary>@{</summary>
        public static int avio_r8(AVIOContext* @s)
        {
            return avio_r8_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avio_rb16_delegate(AVIOContext* @s);
        private static avio_rb16_delegate avio_rb16_fptr = (AVIOContext* @s) =>
        {
            avio_rb16_fptr = GetFunctionDelegate<avio_rb16_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rb16");
            if (avio_rb16_fptr == null)
            {
                avio_rb16_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rb16 is not supported on this platform.");
                };
            }
            return avio_rb16_fptr(@s);
        };
        public static uint avio_rb16(AVIOContext* @s)
        {
            return avio_rb16_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avio_rb24_delegate(AVIOContext* @s);
        private static avio_rb24_delegate avio_rb24_fptr = (AVIOContext* @s) =>
        {
            avio_rb24_fptr = GetFunctionDelegate<avio_rb24_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rb24");
            if (avio_rb24_fptr == null)
            {
                avio_rb24_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rb24 is not supported on this platform.");
                };
            }
            return avio_rb24_fptr(@s);
        };
        public static uint avio_rb24(AVIOContext* @s)
        {
            return avio_rb24_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avio_rb32_delegate(AVIOContext* @s);
        private static avio_rb32_delegate avio_rb32_fptr = (AVIOContext* @s) =>
        {
            avio_rb32_fptr = GetFunctionDelegate<avio_rb32_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rb32");
            if (avio_rb32_fptr == null)
            {
                avio_rb32_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rb32 is not supported on this platform.");
                };
            }
            return avio_rb32_fptr(@s);
        };
        public static uint avio_rb32(AVIOContext* @s)
        {
            return avio_rb32_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong avio_rb64_delegate(AVIOContext* @s);
        private static avio_rb64_delegate avio_rb64_fptr = (AVIOContext* @s) =>
        {
            avio_rb64_fptr = GetFunctionDelegate<avio_rb64_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rb64");
            if (avio_rb64_fptr == null)
            {
                avio_rb64_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rb64 is not supported on this platform.");
                };
            }
            return avio_rb64_fptr(@s);
        };
        public static ulong avio_rb64(AVIOContext* @s)
        {
            return avio_rb64_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_read_delegate(AVIOContext* @s, byte* @buf, int @size);
        private static avio_read_delegate avio_read_fptr = (AVIOContext* @s, byte* @buf, int @size) =>
        {
            avio_read_fptr = GetFunctionDelegate<avio_read_delegate>(GetOrLoadLibrary("avformat", 57), "avio_read");
            if (avio_read_fptr == null)
            {
                avio_read_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_read is not supported on this platform.");
                };
            }
            return avio_read_fptr(@s, @buf, @size);
        };
        /// <summary>Read size bytes from AVIOContext into buf.</summary>
        public static int avio_read(AVIOContext* @s, byte* @buf, int @size)
        {
            return avio_read_fptr(@s, @buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_read_dir_delegate(AVIODirContext* @s, AVIODirEntry** @next);
        private static avio_read_dir_delegate avio_read_dir_fptr = (AVIODirContext* @s, AVIODirEntry** @next) =>
        {
            avio_read_dir_fptr = GetFunctionDelegate<avio_read_dir_delegate>(GetOrLoadLibrary("avformat", 57), "avio_read_dir");
            if (avio_read_dir_fptr == null)
            {
                avio_read_dir_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_read_dir is not supported on this platform.");
                };
            }
            return avio_read_dir_fptr(@s, @next);
        };
        /// <summary>Get next directory entry.</summary>
        /// <param name="s">directory read context.</param>
        /// <param name="next">next entry or NULL when no more entries.</param>
        public static int avio_read_dir(AVIODirContext* @s, AVIODirEntry** @next)
        {
            return avio_read_dir_fptr(@s, @next);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_read_partial_delegate(AVIOContext* @s, byte* @buf, int @size);
        private static avio_read_partial_delegate avio_read_partial_fptr = (AVIOContext* @s, byte* @buf, int @size) =>
        {
            avio_read_partial_fptr = GetFunctionDelegate<avio_read_partial_delegate>(GetOrLoadLibrary("avformat", 57), "avio_read_partial");
            if (avio_read_partial_fptr == null)
            {
                avio_read_partial_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_read_partial is not supported on this platform.");
                };
            }
            return avio_read_partial_fptr(@s, @buf, @size);
        };
        /// <summary>Read size bytes from AVIOContext into buf. Unlike avio_read(), this is allowed to read fewer bytes than requested. The missing bytes can be read in the next call. This always tries to read at least 1 byte. Useful to reduce latency in certain cases.</summary>
        public static int avio_read_partial(AVIOContext* @s, byte* @buf, int @size)
        {
            return avio_read_partial_fptr(@s, @buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avio_read_to_bprint_delegate(AVIOContext* @h, AVBPrint* @pb, ulong @max_size);
        private static avio_read_to_bprint_delegate avio_read_to_bprint_fptr = (AVIOContext* @h, AVBPrint* @pb, ulong @max_size) =>
        {
            avio_read_to_bprint_fptr = GetFunctionDelegate<avio_read_to_bprint_delegate>(GetOrLoadLibrary("avformat", 57), "avio_read_to_bprint");
            if (avio_read_to_bprint_fptr == null)
            {
                avio_read_to_bprint_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_read_to_bprint is not supported on this platform.");
                };
            }
            return avio_read_to_bprint_fptr(@h, @pb, @max_size);
        };
        /// <summary>Read contents of h into print buffer, up to max_size bytes, or up to EOF.</summary>
        public static int avio_read_to_bprint(AVIOContext* @h, AVBPrint* @pb, ulong @max_size)
        {
            return avio_read_to_bprint_fptr(@h, @pb, @max_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avio_rl16_delegate(AVIOContext* @s);
        private static avio_rl16_delegate avio_rl16_fptr = (AVIOContext* @s) =>
        {
            avio_rl16_fptr = GetFunctionDelegate<avio_rl16_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rl16");
            if (avio_rl16_fptr == null)
            {
                avio_rl16_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rl16 is not supported on this platform.");
                };
            }
            return avio_rl16_fptr(@s);
        };
        public static uint avio_rl16(AVIOContext* @s)
        {
            return avio_rl16_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avio_rl24_delegate(AVIOContext* @s);
        private static avio_rl24_delegate avio_rl24_fptr = (AVIOContext* @s) =>
        {
            avio_rl24_fptr = GetFunctionDelegate<avio_rl24_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rl24");
            if (avio_rl24_fptr == null)
            {
                avio_rl24_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rl24 is not supported on this platform.");
                };
            }
            return avio_rl24_fptr(@s);
        };
        public static uint avio_rl24(AVIOContext* @s)
        {
            return avio_rl24_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avio_rl32_delegate(AVIOContext* @s);
        private static avio_rl32_delegate avio_rl32_fptr = (AVIOContext* @s) =>
        {
            avio_rl32_fptr = GetFunctionDelegate<avio_rl32_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rl32");
            if (avio_rl32_fptr == null)
            {
                avio_rl32_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rl32 is not supported on this platform.");
                };
            }
            return avio_rl32_fptr(@s);
        };
        public static uint avio_rl32(AVIOContext* @s)
        {
            return avio_rl32_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong avio_rl64_delegate(AVIOContext* @s);
        private static avio_rl64_delegate avio_rl64_fptr = (AVIOContext* @s) =>
        {
            avio_rl64_fptr = GetFunctionDelegate<avio_rl64_delegate>(GetOrLoadLibrary("avformat", 57), "avio_rl64");
            if (avio_rl64_fptr == null)
            {
                avio_rl64_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_rl64 is not supported on this platform.");
                };
            }
            return avio_rl64_fptr(@s);
        };
        public static ulong avio_rl64(AVIOContext* @s)
        {
            return avio_rl64_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long avio_seek_delegate(AVIOContext* @s, long @offset, int @whence);
        private static avio_seek_delegate avio_seek_fptr = (AVIOContext* @s, long @offset, int @whence) =>
        {
            avio_seek_fptr = GetFunctionDelegate<avio_seek_delegate>(GetOrLoadLibrary("avformat", 57), "avio_seek");
            if (avio_seek_fptr == null)
            {
                avio_seek_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_seek is not supported on this platform.");
                };
            }
            return avio_seek_fptr(@s, @offset, @whence);
        };
        /// <summary>fseek() equivalent for AVIOContext.</summary>
        public static long avio_seek(AVIOContext* @s, long @offset, int @whence)
        {
            return avio_seek_fptr(@s, @offset, @whence);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long avio_seek_time_delegate(AVIOContext* @h, int @stream_index, long @timestamp, int @flags);
        private static avio_seek_time_delegate avio_seek_time_fptr = (AVIOContext* @h, int @stream_index, long @timestamp, int @flags) =>
        {
            avio_seek_time_fptr = GetFunctionDelegate<avio_seek_time_delegate>(GetOrLoadLibrary("avformat", 57), "avio_seek_time");
            if (avio_seek_time_fptr == null)
            {
                avio_seek_time_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_seek_time is not supported on this platform.");
                };
            }
            return avio_seek_time_fptr(@h, @stream_index, @timestamp, @flags);
        };
        /// <summary>Seek to a given timestamp relative to some component stream. Only meaningful if using a network streaming protocol (e.g. MMS.).</summary>
        /// <param name="h">IO context from which to call the seek function pointers</param>
        /// <param name="stream_index">The stream index that the timestamp is relative to. If stream_index is (-1) the timestamp should be in AV_TIME_BASE units from the beginning of the presentation. If a stream_index &gt;= 0 is used and the protocol does not support seeking based on component streams, the call will fail.</param>
        /// <param name="timestamp">timestamp in AVStream.time_base units or if there is no stream specified then in AV_TIME_BASE units.</param>
        /// <param name="flags">Optional combination of AVSEEK_FLAG_BACKWARD, AVSEEK_FLAG_BYTE and AVSEEK_FLAG_ANY. The protocol may silently ignore AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will fail if used and not supported.</param>
        public static long avio_seek_time(AVIOContext* @h, int @stream_index, long @timestamp, int @flags)
        {
            return avio_seek_time_fptr(@h, @stream_index, @timestamp, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long avio_size_delegate(AVIOContext* @s);
        private static avio_size_delegate avio_size_fptr = (AVIOContext* @s) =>
        {
            avio_size_fptr = GetFunctionDelegate<avio_size_delegate>(GetOrLoadLibrary("avformat", 57), "avio_size");
            if (avio_size_fptr == null)
            {
                avio_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_size is not supported on this platform.");
                };
            }
            return avio_size_fptr(@s);
        };
        /// <summary>Get the filesize.</summary>
        public static long avio_size(AVIOContext* @s)
        {
            return avio_size_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long avio_skip_delegate(AVIOContext* @s, long @offset);
        private static avio_skip_delegate avio_skip_fptr = (AVIOContext* @s, long @offset) =>
        {
            avio_skip_fptr = GetFunctionDelegate<avio_skip_delegate>(GetOrLoadLibrary("avformat", 57), "avio_skip");
            if (avio_skip_fptr == null)
            {
                avio_skip_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_skip is not supported on this platform.");
                };
            }
            return avio_skip_fptr(@s, @offset);
        };
        /// <summary>Skip given number of bytes forward</summary>
        public static long avio_skip(AVIOContext* @s, long @offset)
        {
            return avio_skip_fptr(@s, @offset);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_w8_delegate(AVIOContext* @s, int @b);
        private static avio_w8_delegate avio_w8_fptr = (AVIOContext* @s, int @b) =>
        {
            avio_w8_fptr = GetFunctionDelegate<avio_w8_delegate>(GetOrLoadLibrary("avformat", 57), "avio_w8");
            if (avio_w8_fptr == null)
            {
                avio_w8_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_w8 is not supported on this platform.");
                };
            }
            avio_w8_fptr(@s, @b);
        };
        public static void avio_w8(AVIOContext* @s, int @b)
        {
            avio_w8_fptr(@s, @b);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wb16_delegate(AVIOContext* @s, uint @val);
        private static avio_wb16_delegate avio_wb16_fptr = (AVIOContext* @s, uint @val) =>
        {
            avio_wb16_fptr = GetFunctionDelegate<avio_wb16_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wb16");
            if (avio_wb16_fptr == null)
            {
                avio_wb16_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wb16 is not supported on this platform.");
                };
            }
            avio_wb16_fptr(@s, @val);
        };
        public static void avio_wb16(AVIOContext* @s, uint @val)
        {
            avio_wb16_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wb24_delegate(AVIOContext* @s, uint @val);
        private static avio_wb24_delegate avio_wb24_fptr = (AVIOContext* @s, uint @val) =>
        {
            avio_wb24_fptr = GetFunctionDelegate<avio_wb24_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wb24");
            if (avio_wb24_fptr == null)
            {
                avio_wb24_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wb24 is not supported on this platform.");
                };
            }
            avio_wb24_fptr(@s, @val);
        };
        public static void avio_wb24(AVIOContext* @s, uint @val)
        {
            avio_wb24_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wb32_delegate(AVIOContext* @s, uint @val);
        private static avio_wb32_delegate avio_wb32_fptr = (AVIOContext* @s, uint @val) =>
        {
            avio_wb32_fptr = GetFunctionDelegate<avio_wb32_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wb32");
            if (avio_wb32_fptr == null)
            {
                avio_wb32_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wb32 is not supported on this platform.");
                };
            }
            avio_wb32_fptr(@s, @val);
        };
        public static void avio_wb32(AVIOContext* @s, uint @val)
        {
            avio_wb32_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wb64_delegate(AVIOContext* @s, ulong @val);
        private static avio_wb64_delegate avio_wb64_fptr = (AVIOContext* @s, ulong @val) =>
        {
            avio_wb64_fptr = GetFunctionDelegate<avio_wb64_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wb64");
            if (avio_wb64_fptr == null)
            {
                avio_wb64_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wb64 is not supported on this platform.");
                };
            }
            avio_wb64_fptr(@s, @val);
        };
        public static void avio_wb64(AVIOContext* @s, ulong @val)
        {
            avio_wb64_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wl16_delegate(AVIOContext* @s, uint @val);
        private static avio_wl16_delegate avio_wl16_fptr = (AVIOContext* @s, uint @val) =>
        {
            avio_wl16_fptr = GetFunctionDelegate<avio_wl16_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wl16");
            if (avio_wl16_fptr == null)
            {
                avio_wl16_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wl16 is not supported on this platform.");
                };
            }
            avio_wl16_fptr(@s, @val);
        };
        public static void avio_wl16(AVIOContext* @s, uint @val)
        {
            avio_wl16_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wl24_delegate(AVIOContext* @s, uint @val);
        private static avio_wl24_delegate avio_wl24_fptr = (AVIOContext* @s, uint @val) =>
        {
            avio_wl24_fptr = GetFunctionDelegate<avio_wl24_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wl24");
            if (avio_wl24_fptr == null)
            {
                avio_wl24_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wl24 is not supported on this platform.");
                };
            }
            avio_wl24_fptr(@s, @val);
        };
        public static void avio_wl24(AVIOContext* @s, uint @val)
        {
            avio_wl24_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wl32_delegate(AVIOContext* @s, uint @val);
        private static avio_wl32_delegate avio_wl32_fptr = (AVIOContext* @s, uint @val) =>
        {
            avio_wl32_fptr = GetFunctionDelegate<avio_wl32_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wl32");
            if (avio_wl32_fptr == null)
            {
                avio_wl32_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wl32 is not supported on this platform.");
                };
            }
            avio_wl32_fptr(@s, @val);
        };
        public static void avio_wl32(AVIOContext* @s, uint @val)
        {
            avio_wl32_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_wl64_delegate(AVIOContext* @s, ulong @val);
        private static avio_wl64_delegate avio_wl64_fptr = (AVIOContext* @s, ulong @val) =>
        {
            avio_wl64_fptr = GetFunctionDelegate<avio_wl64_delegate>(GetOrLoadLibrary("avformat", 57), "avio_wl64");
            if (avio_wl64_fptr == null)
            {
                avio_wl64_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_wl64 is not supported on this platform.");
                };
            }
            avio_wl64_fptr(@s, @val);
        };
        public static void avio_wl64(AVIOContext* @s, ulong @val)
        {
            avio_wl64_fptr(@s, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_write_delegate(AVIOContext* @s, byte* @buf, int @size);
        private static avio_write_delegate avio_write_fptr = (AVIOContext* @s, byte* @buf, int @size) =>
        {
            avio_write_fptr = GetFunctionDelegate<avio_write_delegate>(GetOrLoadLibrary("avformat", 57), "avio_write");
            if (avio_write_fptr == null)
            {
                avio_write_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_write is not supported on this platform.");
                };
            }
            avio_write_fptr(@s, @buf, @size);
        };
        public static void avio_write(AVIOContext* @s, byte* @buf, int @size)
        {
            avio_write_fptr(@s, @buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void avio_write_marker_delegate(AVIOContext* @s, long @time, AVIODataMarkerType @type);
        private static avio_write_marker_delegate avio_write_marker_fptr = (AVIOContext* @s, long @time, AVIODataMarkerType @type) =>
        {
            avio_write_marker_fptr = GetFunctionDelegate<avio_write_marker_delegate>(GetOrLoadLibrary("avformat", 57), "avio_write_marker");
            if (avio_write_marker_fptr == null)
            {
                avio_write_marker_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avio_write_marker is not supported on this platform.");
                };
            }
            avio_write_marker_fptr(@s, @time, @type);
        };
        /// <summary>Mark the written bytestream as a specific type.</summary>
        /// <param name="time">the stream time the current bytestream pos corresponds to (in AV_TIME_BASE units), or AV_NOPTS_VALUE if unknown or not applicable</param>
        /// <param name="type">the kind of data written starting at the current pos</param>
        public static void avio_write_marker(AVIOContext* @s, long @time, AVIODataMarkerType @type)
        {
            avio_write_marker_fptr(@s, @time, @type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avpriv_io_delete_delegate([MarshalAs(UnmanagedType.LPStr)] string @url);
        private static avpriv_io_delete_delegate avpriv_io_delete_fptr = (string @url) =>
        {
            avpriv_io_delete_fptr = GetFunctionDelegate<avpriv_io_delete_delegate>(GetOrLoadLibrary("avformat", 57), "avpriv_io_delete");
            if (avpriv_io_delete_fptr == null)
            {
                avpriv_io_delete_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpriv_io_delete is not supported on this platform.");
                };
            }
            return avpriv_io_delete_fptr(@url);
        };
        /// <summary>Delete a resource.</summary>
        /// <param name="url">resource to be deleted.</param>
        public static int avpriv_io_delete([MarshalAs(UnmanagedType.LPStr)] string @url)
        {
            return avpriv_io_delete_fptr(@url);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int avpriv_io_move_delegate([MarshalAs(UnmanagedType.LPStr)] string @url_src, [MarshalAs(UnmanagedType.LPStr)] string @url_dst);
        private static avpriv_io_move_delegate avpriv_io_move_fptr = (string @url_src, string @url_dst) =>
        {
            avpriv_io_move_fptr = GetFunctionDelegate<avpriv_io_move_delegate>(GetOrLoadLibrary("avformat", 57), "avpriv_io_move");
            if (avpriv_io_move_fptr == null)
            {
                avpriv_io_move_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpriv_io_move is not supported on this platform.");
                };
            }
            return avpriv_io_move_fptr(@url_src, @url_dst);
        };
        /// <summary>Move or rename a resource.</summary>
        /// <param name="url_src">url to resource to be moved</param>
        /// <param name="url_dst">new url to resource if the operation succeeded</param>
        public static int avpriv_io_move([MarshalAs(UnmanagedType.LPStr)] string @url_src, [MarshalAs(UnmanagedType.LPStr)] string @url_dst)
        {
            return avpriv_io_move_fptr(@url_src, @url_dst);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int url_feof_delegate(AVIOContext* @s);
        private static url_feof_delegate url_feof_fptr = (AVIOContext* @s) =>
        {
            url_feof_fptr = GetFunctionDelegate<url_feof_delegate>(GetOrLoadLibrary("avformat", 57), "url_feof");
            if (url_feof_fptr == null)
            {
                url_feof_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("url_feof is not supported on this platform.");
                };
            }
            return url_feof_fptr(@s);
        };
        [Obsolete("use avio_feof()")]
        public static int url_feof(AVIOContext* @s)
        {
            return url_feof_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_add_q_delegate(AVRational @b, AVRational @c);
        private static av_add_q_delegate av_add_q_fptr = (AVRational @b, AVRational @c) =>
        {
            av_add_q_fptr = GetFunctionDelegate<av_add_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_add_q");
            if (av_add_q_fptr == null)
            {
                av_add_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_add_q is not supported on this platform.");
                };
            }
            return av_add_q_fptr(@b, @c);
        };
        /// <summary>Add two rationals.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        public static AVRational av_add_q(AVRational @b, AVRational @c)
        {
            return av_add_q_fptr(@b, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_add_stable_delegate(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc);
        private static av_add_stable_delegate av_add_stable_fptr = (AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc) =>
        {
            av_add_stable_fptr = GetFunctionDelegate<av_add_stable_delegate>(GetOrLoadLibrary("avutil", 55), "av_add_stable");
            if (av_add_stable_fptr == null)
            {
                av_add_stable_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_add_stable is not supported on this platform.");
                };
            }
            return av_add_stable_fptr(@ts_tb, @ts, @inc_tb, @inc);
        };
        /// <summary>Add a value to a timestamp.</summary>
        /// <param name="ts_tb">Input timestamp time base</param>
        /// <param name="ts">Input timestamp</param>
        /// <param name="inc_tb">Time base of `inc`</param>
        /// <param name="inc">Value to be added</param>
        public static long av_add_stable(AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc)
        {
            return av_add_stable_fptr(@ts_tb, @ts, @inc_tb, @inc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVAudioFifo* av_audio_fifo_alloc_delegate(AVSampleFormat @sample_fmt, int @channels, int @nb_samples);
        private static av_audio_fifo_alloc_delegate av_audio_fifo_alloc_fptr = (AVSampleFormat @sample_fmt, int @channels, int @nb_samples) =>
        {
            av_audio_fifo_alloc_fptr = GetFunctionDelegate<av_audio_fifo_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_alloc");
            if (av_audio_fifo_alloc_fptr == null)
            {
                av_audio_fifo_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_alloc is not supported on this platform.");
                };
            }
            return av_audio_fifo_alloc_fptr(@sample_fmt, @channels, @nb_samples);
        };
        /// <summary>Allocate an AVAudioFifo.</summary>
        /// <param name="sample_fmt">sample format</param>
        /// <param name="channels">number of channels</param>
        /// <param name="nb_samples">initial allocation size, in samples</param>
        public static AVAudioFifo* av_audio_fifo_alloc(AVSampleFormat @sample_fmt, int @channels, int @nb_samples)
        {
            return av_audio_fifo_alloc_fptr(@sample_fmt, @channels, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_drain_delegate(AVAudioFifo* @af, int @nb_samples);
        private static av_audio_fifo_drain_delegate av_audio_fifo_drain_fptr = (AVAudioFifo* @af, int @nb_samples) =>
        {
            av_audio_fifo_drain_fptr = GetFunctionDelegate<av_audio_fifo_drain_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_drain");
            if (av_audio_fifo_drain_fptr == null)
            {
                av_audio_fifo_drain_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_drain is not supported on this platform.");
                };
            }
            return av_audio_fifo_drain_fptr(@af, @nb_samples);
        };
        /// <summary>Drain data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to drain</param>
        /// <param name="nb_samples">number of samples to drain</param>
        public static int av_audio_fifo_drain(AVAudioFifo* @af, int @nb_samples)
        {
            return av_audio_fifo_drain_fptr(@af, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_audio_fifo_free_delegate(AVAudioFifo* @af);
        private static av_audio_fifo_free_delegate av_audio_fifo_free_fptr = (AVAudioFifo* @af) =>
        {
            av_audio_fifo_free_fptr = GetFunctionDelegate<av_audio_fifo_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_free");
            if (av_audio_fifo_free_fptr == null)
            {
                av_audio_fifo_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_free is not supported on this platform.");
                };
            }
            av_audio_fifo_free_fptr(@af);
        };
        /// <summary>Free an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to free</param>
        public static void av_audio_fifo_free(AVAudioFifo* @af)
        {
            av_audio_fifo_free_fptr(@af);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_peek_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
        private static av_audio_fifo_peek_delegate av_audio_fifo_peek_fptr = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
        {
            av_audio_fifo_peek_fptr = GetFunctionDelegate<av_audio_fifo_peek_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_peek");
            if (av_audio_fifo_peek_fptr == null)
            {
                av_audio_fifo_peek_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_peek is not supported on this platform.");
                };
            }
            return av_audio_fifo_peek_fptr(@af, @data, @nb_samples);
        };
        /// <summary>Peek data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to peek</param>
        public static int av_audio_fifo_peek(AVAudioFifo* @af, void** @data, int @nb_samples)
        {
            return av_audio_fifo_peek_fptr(@af, @data, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_peek_at_delegate(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset);
        private static av_audio_fifo_peek_at_delegate av_audio_fifo_peek_at_fptr = (AVAudioFifo* @af, void** @data, int @nb_samples, int @offset) =>
        {
            av_audio_fifo_peek_at_fptr = GetFunctionDelegate<av_audio_fifo_peek_at_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_peek_at");
            if (av_audio_fifo_peek_at_fptr == null)
            {
                av_audio_fifo_peek_at_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_peek_at is not supported on this platform.");
                };
            }
            return av_audio_fifo_peek_at_fptr(@af, @data, @nb_samples, @offset);
        };
        /// <summary>Peek data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to peek</param>
        /// <param name="offset">offset from current read position</param>
        public static int av_audio_fifo_peek_at(AVAudioFifo* @af, void** @data, int @nb_samples, int @offset)
        {
            return av_audio_fifo_peek_at_fptr(@af, @data, @nb_samples, @offset);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_read_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
        private static av_audio_fifo_read_delegate av_audio_fifo_read_fptr = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
        {
            av_audio_fifo_read_fptr = GetFunctionDelegate<av_audio_fifo_read_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_read");
            if (av_audio_fifo_read_fptr == null)
            {
                av_audio_fifo_read_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_read is not supported on this platform.");
                };
            }
            return av_audio_fifo_read_fptr(@af, @data, @nb_samples);
        };
        /// <summary>Read data from an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to read from</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to read</param>
        public static int av_audio_fifo_read(AVAudioFifo* @af, void** @data, int @nb_samples)
        {
            return av_audio_fifo_read_fptr(@af, @data, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_realloc_delegate(AVAudioFifo* @af, int @nb_samples);
        private static av_audio_fifo_realloc_delegate av_audio_fifo_realloc_fptr = (AVAudioFifo* @af, int @nb_samples) =>
        {
            av_audio_fifo_realloc_fptr = GetFunctionDelegate<av_audio_fifo_realloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_realloc");
            if (av_audio_fifo_realloc_fptr == null)
            {
                av_audio_fifo_realloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_realloc is not supported on this platform.");
                };
            }
            return av_audio_fifo_realloc_fptr(@af, @nb_samples);
        };
        /// <summary>Reallocate an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to reallocate</param>
        /// <param name="nb_samples">new allocation size, in samples</param>
        public static int av_audio_fifo_realloc(AVAudioFifo* @af, int @nb_samples)
        {
            return av_audio_fifo_realloc_fptr(@af, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_audio_fifo_reset_delegate(AVAudioFifo* @af);
        private static av_audio_fifo_reset_delegate av_audio_fifo_reset_fptr = (AVAudioFifo* @af) =>
        {
            av_audio_fifo_reset_fptr = GetFunctionDelegate<av_audio_fifo_reset_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_reset");
            if (av_audio_fifo_reset_fptr == null)
            {
                av_audio_fifo_reset_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_reset is not supported on this platform.");
                };
            }
            av_audio_fifo_reset_fptr(@af);
        };
        /// <summary>Reset the AVAudioFifo buffer.</summary>
        /// <param name="af">AVAudioFifo to reset</param>
        public static void av_audio_fifo_reset(AVAudioFifo* @af)
        {
            av_audio_fifo_reset_fptr(@af);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_size_delegate(AVAudioFifo* @af);
        private static av_audio_fifo_size_delegate av_audio_fifo_size_fptr = (AVAudioFifo* @af) =>
        {
            av_audio_fifo_size_fptr = GetFunctionDelegate<av_audio_fifo_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_size");
            if (av_audio_fifo_size_fptr == null)
            {
                av_audio_fifo_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_size is not supported on this platform.");
                };
            }
            return av_audio_fifo_size_fptr(@af);
        };
        /// <summary>Get the current number of samples in the AVAudioFifo available for reading.</summary>
        /// <param name="af">the AVAudioFifo to query</param>
        public static int av_audio_fifo_size(AVAudioFifo* @af)
        {
            return av_audio_fifo_size_fptr(@af);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_space_delegate(AVAudioFifo* @af);
        private static av_audio_fifo_space_delegate av_audio_fifo_space_fptr = (AVAudioFifo* @af) =>
        {
            av_audio_fifo_space_fptr = GetFunctionDelegate<av_audio_fifo_space_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_space");
            if (av_audio_fifo_space_fptr == null)
            {
                av_audio_fifo_space_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_space is not supported on this platform.");
                };
            }
            return av_audio_fifo_space_fptr(@af);
        };
        /// <summary>Get the current number of samples in the AVAudioFifo available for writing.</summary>
        /// <param name="af">the AVAudioFifo to query</param>
        public static int av_audio_fifo_space(AVAudioFifo* @af)
        {
            return av_audio_fifo_space_fptr(@af);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_audio_fifo_write_delegate(AVAudioFifo* @af, void** @data, int @nb_samples);
        private static av_audio_fifo_write_delegate av_audio_fifo_write_fptr = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
        {
            av_audio_fifo_write_fptr = GetFunctionDelegate<av_audio_fifo_write_delegate>(GetOrLoadLibrary("avutil", 55), "av_audio_fifo_write");
            if (av_audio_fifo_write_fptr == null)
            {
                av_audio_fifo_write_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_audio_fifo_write is not supported on this platform.");
                };
            }
            return av_audio_fifo_write_fptr(@af, @data, @nb_samples);
        };
        /// <summary>Write data to an AVAudioFifo.</summary>
        /// <param name="af">AVAudioFifo to write to</param>
        /// <param name="data">audio data plane pointers</param>
        /// <param name="nb_samples">number of samples to write</param>
        public static int av_audio_fifo_write(AVAudioFifo* @af, void** @data, int @nb_samples)
        {
            return av_audio_fifo_write_fptr(@af, @data, @nb_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_bprint_channel_layout_delegate(AVBPrint* @bp, int @nb_channels, ulong @channel_layout);
        private static av_bprint_channel_layout_delegate av_bprint_channel_layout_fptr = (AVBPrint* @bp, int @nb_channels, ulong @channel_layout) =>
        {
            av_bprint_channel_layout_fptr = GetFunctionDelegate<av_bprint_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_bprint_channel_layout");
            if (av_bprint_channel_layout_fptr == null)
            {
                av_bprint_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_bprint_channel_layout is not supported on this platform.");
                };
            }
            av_bprint_channel_layout_fptr(@bp, @nb_channels, @channel_layout);
        };
        /// <summary>Append a description of a channel layout to a bprint buffer.</summary>
        public static void av_bprint_channel_layout(AVBPrint* @bp, int @nb_channels, ulong @channel_layout)
        {
            av_bprint_channel_layout_fptr(@bp, @nb_channels, @channel_layout);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_buffer_alloc_delegate(int @size);
        private static av_buffer_alloc_delegate av_buffer_alloc_fptr = (int @size) =>
        {
            av_buffer_alloc_fptr = GetFunctionDelegate<av_buffer_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_alloc");
            if (av_buffer_alloc_fptr == null)
            {
                av_buffer_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_alloc is not supported on this platform.");
                };
            }
            return av_buffer_alloc_fptr(@size);
        };
        /// <summary>Allocate an AVBuffer of the given size using av_malloc().</summary>
        public static AVBufferRef* av_buffer_alloc(int @size)
        {
            return av_buffer_alloc_fptr(@size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_buffer_allocz_delegate(int @size);
        private static av_buffer_allocz_delegate av_buffer_allocz_fptr = (int @size) =>
        {
            av_buffer_allocz_fptr = GetFunctionDelegate<av_buffer_allocz_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_allocz");
            if (av_buffer_allocz_fptr == null)
            {
                av_buffer_allocz_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_allocz is not supported on this platform.");
                };
            }
            return av_buffer_allocz_fptr(@size);
        };
        /// <summary>Same as av_buffer_alloc(), except the returned buffer will be initialized to zero.</summary>
        public static AVBufferRef* av_buffer_allocz(int @size)
        {
            return av_buffer_allocz_fptr(@size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_buffer_create_delegate(byte* @data, int @size, av_buffer_create_free_func @free, void* @opaque, int @flags);
        private static av_buffer_create_delegate av_buffer_create_fptr = (byte* @data, int @size, av_buffer_create_free_func @free, void* @opaque, int @flags) =>
        {
            av_buffer_create_fptr = GetFunctionDelegate<av_buffer_create_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_create");
            if (av_buffer_create_fptr == null)
            {
                av_buffer_create_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_create is not supported on this platform.");
                };
            }
            return av_buffer_create_fptr(@data, @size, @free, @opaque, @flags);
        };
        /// <summary>Create an AVBuffer from an existing array.</summary>
        /// <param name="data">data array</param>
        /// <param name="size">size of data in bytes</param>
        /// <param name="free">a callback for freeing this buffer&apos;s data</param>
        /// <param name="opaque">parameter to be got for processing or passed to free</param>
        /// <param name="flags">a combination of AV_BUFFER_FLAG_*</param>
        public static AVBufferRef* av_buffer_create(byte* @data, int @size, av_buffer_create_free_func @free, void* @opaque, int @flags)
        {
            return av_buffer_create_fptr(@data, @size, @free, @opaque, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_buffer_default_free_delegate(void* @opaque, byte* @data);
        private static av_buffer_default_free_delegate av_buffer_default_free_fptr = (void* @opaque, byte* @data) =>
        {
            av_buffer_default_free_fptr = GetFunctionDelegate<av_buffer_default_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_default_free");
            if (av_buffer_default_free_fptr == null)
            {
                av_buffer_default_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_default_free is not supported on this platform.");
                };
            }
            av_buffer_default_free_fptr(@opaque, @data);
        };
        /// <summary>Default free callback, which calls av_free() on the buffer data. This function is meant to be passed to av_buffer_create(), not called directly.</summary>
        public static void av_buffer_default_free(void* @opaque, byte* @data)
        {
            av_buffer_default_free_fptr(@opaque, @data);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_buffer_get_opaque_delegate(AVBufferRef* @buf);
        private static av_buffer_get_opaque_delegate av_buffer_get_opaque_fptr = (AVBufferRef* @buf) =>
        {
            av_buffer_get_opaque_fptr = GetFunctionDelegate<av_buffer_get_opaque_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_get_opaque");
            if (av_buffer_get_opaque_fptr == null)
            {
                av_buffer_get_opaque_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_get_opaque is not supported on this platform.");
                };
            }
            return av_buffer_get_opaque_fptr(@buf);
        };
        /// <summary>Returns the opaque parameter set by av_buffer_create.</summary>
        public static void* av_buffer_get_opaque(AVBufferRef* @buf)
        {
            return av_buffer_get_opaque_fptr(@buf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffer_get_ref_count_delegate(AVBufferRef* @buf);
        private static av_buffer_get_ref_count_delegate av_buffer_get_ref_count_fptr = (AVBufferRef* @buf) =>
        {
            av_buffer_get_ref_count_fptr = GetFunctionDelegate<av_buffer_get_ref_count_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_get_ref_count");
            if (av_buffer_get_ref_count_fptr == null)
            {
                av_buffer_get_ref_count_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_get_ref_count is not supported on this platform.");
                };
            }
            return av_buffer_get_ref_count_fptr(@buf);
        };
        public static int av_buffer_get_ref_count(AVBufferRef* @buf)
        {
            return av_buffer_get_ref_count_fptr(@buf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffer_is_writable_delegate(AVBufferRef* @buf);
        private static av_buffer_is_writable_delegate av_buffer_is_writable_fptr = (AVBufferRef* @buf) =>
        {
            av_buffer_is_writable_fptr = GetFunctionDelegate<av_buffer_is_writable_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_is_writable");
            if (av_buffer_is_writable_fptr == null)
            {
                av_buffer_is_writable_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_is_writable is not supported on this platform.");
                };
            }
            return av_buffer_is_writable_fptr(@buf);
        };
        /// <summary>Returns 1 if the caller may write to the data referred to by buf (which is true if and only if buf is the only reference to the underlying AVBuffer). Return 0 otherwise. A positive answer is valid until av_buffer_ref() is called on buf.</summary>
        public static int av_buffer_is_writable(AVBufferRef* @buf)
        {
            return av_buffer_is_writable_fptr(@buf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffer_make_writable_delegate(AVBufferRef** @buf);
        private static av_buffer_make_writable_delegate av_buffer_make_writable_fptr = (AVBufferRef** @buf) =>
        {
            av_buffer_make_writable_fptr = GetFunctionDelegate<av_buffer_make_writable_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_make_writable");
            if (av_buffer_make_writable_fptr == null)
            {
                av_buffer_make_writable_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_make_writable is not supported on this platform.");
                };
            }
            return av_buffer_make_writable_fptr(@buf);
        };
        /// <summary>Create a writable reference from a given buffer reference, avoiding data copy if possible.</summary>
        /// <param name="buf">buffer reference to make writable. On success, buf is either left untouched, or it is unreferenced and a new writable AVBufferRef is written in its place. On failure, buf is left untouched.</param>
        public static int av_buffer_make_writable(AVBufferRef** @buf)
        {
            return av_buffer_make_writable_fptr(@buf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_buffer_pool_get_delegate(AVBufferPool* @pool);
        private static av_buffer_pool_get_delegate av_buffer_pool_get_fptr = (AVBufferPool* @pool) =>
        {
            av_buffer_pool_get_fptr = GetFunctionDelegate<av_buffer_pool_get_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_pool_get");
            if (av_buffer_pool_get_fptr == null)
            {
                av_buffer_pool_get_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_pool_get is not supported on this platform.");
                };
            }
            return av_buffer_pool_get_fptr(@pool);
        };
        /// <summary>Allocate a new AVBuffer, reusing an old buffer from the pool when available. This function may be called simultaneously from multiple threads.</summary>
        public static AVBufferRef* av_buffer_pool_get(AVBufferPool* @pool)
        {
            return av_buffer_pool_get_fptr(@pool);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferPool* av_buffer_pool_init_delegate(int @size, av_buffer_pool_init_alloc_func @alloc);
        private static av_buffer_pool_init_delegate av_buffer_pool_init_fptr = (int @size, av_buffer_pool_init_alloc_func @alloc) =>
        {
            av_buffer_pool_init_fptr = GetFunctionDelegate<av_buffer_pool_init_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_pool_init");
            if (av_buffer_pool_init_fptr == null)
            {
                av_buffer_pool_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_pool_init is not supported on this platform.");
                };
            }
            return av_buffer_pool_init_fptr(@size, @alloc);
        };
        /// <summary>Allocate and initialize a buffer pool.</summary>
        /// <param name="size">size of each buffer in this pool</param>
        /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty. May be NULL, then the default allocator will be used (av_buffer_alloc()).</param>
        public static AVBufferPool* av_buffer_pool_init(int @size, av_buffer_pool_init_alloc_func @alloc)
        {
            return av_buffer_pool_init_fptr(@size, @alloc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferPool* av_buffer_pool_init2_delegate(int @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free);
        private static av_buffer_pool_init2_delegate av_buffer_pool_init2_fptr = (int @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free) =>
        {
            av_buffer_pool_init2_fptr = GetFunctionDelegate<av_buffer_pool_init2_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_pool_init2");
            if (av_buffer_pool_init2_fptr == null)
            {
                av_buffer_pool_init2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_pool_init2 is not supported on this platform.");
                };
            }
            return av_buffer_pool_init2_fptr(@size, @opaque, @alloc, @pool_free);
        };
        /// <summary>Allocate and initialize a buffer pool with a more complex allocator.</summary>
        /// <param name="size">size of each buffer in this pool</param>
        /// <param name="opaque">arbitrary user data used by the allocator</param>
        /// <param name="alloc">a function that will be used to allocate new buffers when the pool is empty.</param>
        /// <param name="pool_free">a function that will be called immediately before the pool is freed. I.e. after av_buffer_pool_uninit() is called by the caller and all the frames are returned to the pool and freed. It is intended to uninitialize the user opaque data.</param>
        public static AVBufferPool* av_buffer_pool_init2(int @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free)
        {
            return av_buffer_pool_init2_fptr(@size, @opaque, @alloc, @pool_free);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_buffer_pool_uninit_delegate(AVBufferPool** @pool);
        private static av_buffer_pool_uninit_delegate av_buffer_pool_uninit_fptr = (AVBufferPool** @pool) =>
        {
            av_buffer_pool_uninit_fptr = GetFunctionDelegate<av_buffer_pool_uninit_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_pool_uninit");
            if (av_buffer_pool_uninit_fptr == null)
            {
                av_buffer_pool_uninit_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_pool_uninit is not supported on this platform.");
                };
            }
            av_buffer_pool_uninit_fptr(@pool);
        };
        /// <summary>Mark the pool as being available for freeing. It will actually be freed only once all the allocated buffers associated with the pool are released. Thus it is safe to call this function while some of the allocated buffers are still in use.</summary>
        /// <param name="pool">pointer to the pool to be freed. It will be set to NULL.</param>
        public static void av_buffer_pool_uninit(AVBufferPool** @pool)
        {
            av_buffer_pool_uninit_fptr(@pool);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_buffer_realloc_delegate(AVBufferRef** @buf, int @size);
        private static av_buffer_realloc_delegate av_buffer_realloc_fptr = (AVBufferRef** @buf, int @size) =>
        {
            av_buffer_realloc_fptr = GetFunctionDelegate<av_buffer_realloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_realloc");
            if (av_buffer_realloc_fptr == null)
            {
                av_buffer_realloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_realloc is not supported on this platform.");
                };
            }
            return av_buffer_realloc_fptr(@buf, @size);
        };
        /// <summary>Reallocate a given buffer.</summary>
        /// <param name="buf">a buffer reference to reallocate. On success, buf will be unreferenced and a new reference with the required size will be written in its place. On failure buf will be left untouched. *buf may be NULL, then a new buffer is allocated.</param>
        /// <param name="size">required new buffer size.</param>
        public static int av_buffer_realloc(AVBufferRef** @buf, int @size)
        {
            return av_buffer_realloc_fptr(@buf, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_buffer_ref_delegate(AVBufferRef* @buf);
        private static av_buffer_ref_delegate av_buffer_ref_fptr = (AVBufferRef* @buf) =>
        {
            av_buffer_ref_fptr = GetFunctionDelegate<av_buffer_ref_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_ref");
            if (av_buffer_ref_fptr == null)
            {
                av_buffer_ref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_ref is not supported on this platform.");
                };
            }
            return av_buffer_ref_fptr(@buf);
        };
        /// <summary>Create a new reference to an AVBuffer.</summary>
        public static AVBufferRef* av_buffer_ref(AVBufferRef* @buf)
        {
            return av_buffer_ref_fptr(@buf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_buffer_unref_delegate(AVBufferRef** @buf);
        private static av_buffer_unref_delegate av_buffer_unref_fptr = (AVBufferRef** @buf) =>
        {
            av_buffer_unref_fptr = GetFunctionDelegate<av_buffer_unref_delegate>(GetOrLoadLibrary("avutil", 55), "av_buffer_unref");
            if (av_buffer_unref_fptr == null)
            {
                av_buffer_unref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_buffer_unref is not supported on this platform.");
                };
            }
            av_buffer_unref_fptr(@buf);
        };
        /// <summary>Free a given reference and automatically free the buffer if there are no more references to it.</summary>
        /// <param name="buf">the reference to be freed. The pointer is set to NULL on return.</param>
        public static void av_buffer_unref(AVBufferRef** @buf)
        {
            av_buffer_unref_fptr(@buf);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_calloc_delegate(ulong @nmemb, ulong @size);
        private static av_calloc_delegate av_calloc_fptr = (ulong @nmemb, ulong @size) =>
        {
            av_calloc_fptr = GetFunctionDelegate<av_calloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_calloc");
            if (av_calloc_fptr == null)
            {
                av_calloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_calloc is not supported on this platform.");
                };
            }
            return av_calloc_fptr(@nmemb, @size);
        };
        /// <summary>Non-inlined equivalent of av_mallocz_array().</summary>
        public static void* av_calloc(ulong @nmemb, ulong @size)
        {
            return av_calloc_fptr(@nmemb, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong av_channel_layout_extract_channel_delegate(ulong @channel_layout, int @index);
        private static av_channel_layout_extract_channel_delegate av_channel_layout_extract_channel_fptr = (ulong @channel_layout, int @index) =>
        {
            av_channel_layout_extract_channel_fptr = GetFunctionDelegate<av_channel_layout_extract_channel_delegate>(GetOrLoadLibrary("avutil", 55), "av_channel_layout_extract_channel");
            if (av_channel_layout_extract_channel_fptr == null)
            {
                av_channel_layout_extract_channel_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_channel_layout_extract_channel is not supported on this platform.");
                };
            }
            return av_channel_layout_extract_channel_fptr(@channel_layout, @index);
        };
        /// <summary>Get the channel with the given index in channel_layout.</summary>
        public static ulong av_channel_layout_extract_channel(ulong @channel_layout, int @index)
        {
            return av_channel_layout_extract_channel_fptr(@channel_layout, @index);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_chroma_location_from_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_chroma_location_from_name_delegate av_chroma_location_from_name_fptr = (string @name) =>
        {
            av_chroma_location_from_name_fptr = GetFunctionDelegate<av_chroma_location_from_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_chroma_location_from_name");
            if (av_chroma_location_from_name_fptr == null)
            {
                av_chroma_location_from_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_chroma_location_from_name is not supported on this platform.");
                };
            }
            return av_chroma_location_from_name_fptr(@name);
        };
        /// <summary>Returns the AVChromaLocation value for name or an AVError if not found.</summary>
        public static int av_chroma_location_from_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_chroma_location_from_name_fptr(@name);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_chroma_location_name_delegate(AVChromaLocation @location);
        private static av_chroma_location_name_delegate av_chroma_location_name_fptr = (AVChromaLocation @location) =>
        {
            av_chroma_location_name_fptr = GetFunctionDelegate<av_chroma_location_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_chroma_location_name");
            if (av_chroma_location_name_fptr == null)
            {
                av_chroma_location_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_chroma_location_name is not supported on this platform.");
                };
            }
            return av_chroma_location_name_fptr(@location);
        };
        /// <summary>Returns the name for provided chroma location or NULL if unknown.</summary>
        public static string av_chroma_location_name(AVChromaLocation @location)
        {
            return av_chroma_location_name_fptr(@location);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_color_primaries_from_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_color_primaries_from_name_delegate av_color_primaries_from_name_fptr = (string @name) =>
        {
            av_color_primaries_from_name_fptr = GetFunctionDelegate<av_color_primaries_from_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_primaries_from_name");
            if (av_color_primaries_from_name_fptr == null)
            {
                av_color_primaries_from_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_primaries_from_name is not supported on this platform.");
                };
            }
            return av_color_primaries_from_name_fptr(@name);
        };
        /// <summary>Returns the AVColorPrimaries value for name or an AVError if not found.</summary>
        public static int av_color_primaries_from_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_color_primaries_from_name_fptr(@name);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_color_primaries_name_delegate(AVColorPrimaries @primaries);
        private static av_color_primaries_name_delegate av_color_primaries_name_fptr = (AVColorPrimaries @primaries) =>
        {
            av_color_primaries_name_fptr = GetFunctionDelegate<av_color_primaries_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_primaries_name");
            if (av_color_primaries_name_fptr == null)
            {
                av_color_primaries_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_primaries_name is not supported on this platform.");
                };
            }
            return av_color_primaries_name_fptr(@primaries);
        };
        /// <summary>Returns the name for provided color primaries or NULL if unknown.</summary>
        public static string av_color_primaries_name(AVColorPrimaries @primaries)
        {
            return av_color_primaries_name_fptr(@primaries);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_color_range_from_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_color_range_from_name_delegate av_color_range_from_name_fptr = (string @name) =>
        {
            av_color_range_from_name_fptr = GetFunctionDelegate<av_color_range_from_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_range_from_name");
            if (av_color_range_from_name_fptr == null)
            {
                av_color_range_from_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_range_from_name is not supported on this platform.");
                };
            }
            return av_color_range_from_name_fptr(@name);
        };
        /// <summary>Returns the AVColorRange value for name or an AVError if not found.</summary>
        public static int av_color_range_from_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_color_range_from_name_fptr(@name);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_color_range_name_delegate(AVColorRange @range);
        private static av_color_range_name_delegate av_color_range_name_fptr = (AVColorRange @range) =>
        {
            av_color_range_name_fptr = GetFunctionDelegate<av_color_range_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_range_name");
            if (av_color_range_name_fptr == null)
            {
                av_color_range_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_range_name is not supported on this platform.");
                };
            }
            return av_color_range_name_fptr(@range);
        };
        /// <summary>Returns the name for provided color range or NULL if unknown.</summary>
        public static string av_color_range_name(AVColorRange @range)
        {
            return av_color_range_name_fptr(@range);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_color_space_from_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_color_space_from_name_delegate av_color_space_from_name_fptr = (string @name) =>
        {
            av_color_space_from_name_fptr = GetFunctionDelegate<av_color_space_from_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_space_from_name");
            if (av_color_space_from_name_fptr == null)
            {
                av_color_space_from_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_space_from_name is not supported on this platform.");
                };
            }
            return av_color_space_from_name_fptr(@name);
        };
        /// <summary>Returns the AVColorSpace value for name or an AVError if not found.</summary>
        public static int av_color_space_from_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_color_space_from_name_fptr(@name);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_color_space_name_delegate(AVColorSpace @space);
        private static av_color_space_name_delegate av_color_space_name_fptr = (AVColorSpace @space) =>
        {
            av_color_space_name_fptr = GetFunctionDelegate<av_color_space_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_space_name");
            if (av_color_space_name_fptr == null)
            {
                av_color_space_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_space_name is not supported on this platform.");
                };
            }
            return av_color_space_name_fptr(@space);
        };
        /// <summary>Returns the name for provided color space or NULL if unknown.</summary>
        public static string av_color_space_name(AVColorSpace @space)
        {
            return av_color_space_name_fptr(@space);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_color_transfer_from_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_color_transfer_from_name_delegate av_color_transfer_from_name_fptr = (string @name) =>
        {
            av_color_transfer_from_name_fptr = GetFunctionDelegate<av_color_transfer_from_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_transfer_from_name");
            if (av_color_transfer_from_name_fptr == null)
            {
                av_color_transfer_from_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_transfer_from_name is not supported on this platform.");
                };
            }
            return av_color_transfer_from_name_fptr(@name);
        };
        /// <summary>Returns the AVColorTransferCharacteristic value for name or an AVError if not found.</summary>
        public static int av_color_transfer_from_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_color_transfer_from_name_fptr(@name);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_color_transfer_name_delegate(AVColorTransferCharacteristic @transfer);
        private static av_color_transfer_name_delegate av_color_transfer_name_fptr = (AVColorTransferCharacteristic @transfer) =>
        {
            av_color_transfer_name_fptr = GetFunctionDelegate<av_color_transfer_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_color_transfer_name");
            if (av_color_transfer_name_fptr == null)
            {
                av_color_transfer_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_color_transfer_name is not supported on this platform.");
                };
            }
            return av_color_transfer_name_fptr(@transfer);
        };
        /// <summary>Returns the name for provided color transfer or NULL if unknown.</summary>
        public static string av_color_transfer_name(AVColorTransferCharacteristic @transfer)
        {
            return av_color_transfer_name_fptr(@transfer);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_compare_mod_delegate(ulong @a, ulong @b, ulong @mod);
        private static av_compare_mod_delegate av_compare_mod_fptr = (ulong @a, ulong @b, ulong @mod) =>
        {
            av_compare_mod_fptr = GetFunctionDelegate<av_compare_mod_delegate>(GetOrLoadLibrary("avutil", 55), "av_compare_mod");
            if (av_compare_mod_fptr == null)
            {
                av_compare_mod_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_compare_mod is not supported on this platform.");
                };
            }
            return av_compare_mod_fptr(@a, @b, @mod);
        };
        /// <summary>Compare the remainders of two integer operands divided by a common divisor.</summary>
        /// <param name="mod">Divisor; must be a power of 2</param>
        public static long av_compare_mod(ulong @a, ulong @b, ulong @mod)
        {
            return av_compare_mod_fptr(@a, @b, @mod);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_compare_ts_delegate(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b);
        private static av_compare_ts_delegate av_compare_ts_fptr = (long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b) =>
        {
            av_compare_ts_fptr = GetFunctionDelegate<av_compare_ts_delegate>(GetOrLoadLibrary("avutil", 55), "av_compare_ts");
            if (av_compare_ts_fptr == null)
            {
                av_compare_ts_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_compare_ts is not supported on this platform.");
                };
            }
            return av_compare_ts_fptr(@ts_a, @tb_a, @ts_b, @tb_b);
        };
        /// <summary>Compare two timestamps each in its own time base.</summary>
        public static int av_compare_ts(long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b)
        {
            return av_compare_ts_fptr(@ts_a, @tb_a, @ts_b, @tb_b);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_cpu_count_delegate();
        private static av_cpu_count_delegate av_cpu_count_fptr = () =>
        {
            av_cpu_count_fptr = GetFunctionDelegate<av_cpu_count_delegate>(GetOrLoadLibrary("avutil", 55), "av_cpu_count");
            if (av_cpu_count_fptr == null)
            {
                av_cpu_count_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_cpu_count is not supported on this platform.");
                };
            }
            return av_cpu_count_fptr();
        };
        /// <summary>Returns the number of logical CPU cores present.</summary>
        public static int av_cpu_count()
        {
            return av_cpu_count_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong av_cpu_max_align_delegate();
        private static av_cpu_max_align_delegate av_cpu_max_align_fptr = () =>
        {
            av_cpu_max_align_fptr = GetFunctionDelegate<av_cpu_max_align_delegate>(GetOrLoadLibrary("avutil", 55), "av_cpu_max_align");
            if (av_cpu_max_align_fptr == null)
            {
                av_cpu_max_align_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_cpu_max_align is not supported on this platform.");
                };
            }
            return av_cpu_max_align_fptr();
        };
        /// <summary>Get the maximum data alignment that may be required by FFmpeg.</summary>
        public static ulong av_cpu_max_align()
        {
            return av_cpu_max_align_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_d2q_delegate(double @d, int @max);
        private static av_d2q_delegate av_d2q_fptr = (double @d, int @max) =>
        {
            av_d2q_fptr = GetFunctionDelegate<av_d2q_delegate>(GetOrLoadLibrary("avutil", 55), "av_d2q");
            if (av_d2q_fptr == null)
            {
                av_d2q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_d2q is not supported on this platform.");
                };
            }
            return av_d2q_fptr(@d, @max);
        };
        /// <summary>Convert a double precision floating point number to a rational.</summary>
        /// <param name="d">`double` to convert</param>
        /// <param name="max">Maximum allowed numerator and denominator</param>
        public static AVRational av_d2q(double @d, int @max)
        {
            return av_d2q_fptr(@d, @max);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClassCategory av_default_get_category_delegate(void* @ptr);
        private static av_default_get_category_delegate av_default_get_category_fptr = (void* @ptr) =>
        {
            av_default_get_category_fptr = GetFunctionDelegate<av_default_get_category_delegate>(GetOrLoadLibrary("avutil", 55), "av_default_get_category");
            if (av_default_get_category_fptr == null)
            {
                av_default_get_category_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_default_get_category is not supported on this platform.");
                };
            }
            return av_default_get_category_fptr(@ptr);
        };
        public static AVClassCategory av_default_get_category(void* @ptr)
        {
            return av_default_get_category_fptr(@ptr);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_default_item_name_delegate(void* @ctx);
        private static av_default_item_name_delegate av_default_item_name_fptr = (void* @ctx) =>
        {
            av_default_item_name_fptr = GetFunctionDelegate<av_default_item_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_default_item_name");
            if (av_default_item_name_fptr == null)
            {
                av_default_item_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_default_item_name is not supported on this platform.");
                };
            }
            return av_default_item_name_fptr(@ctx);
        };
        /// <summary>Return the context name</summary>
        /// <param name="ctx">The AVClass context</param>
        public static string av_default_item_name(void* @ctx)
        {
            return av_default_item_name_fptr(@ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dict_copy_delegate(AVDictionary** @dst, AVDictionary* @src, int @flags);
        private static av_dict_copy_delegate av_dict_copy_fptr = (AVDictionary** @dst, AVDictionary* @src, int @flags) =>
        {
            av_dict_copy_fptr = GetFunctionDelegate<av_dict_copy_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_copy");
            if (av_dict_copy_fptr == null)
            {
                av_dict_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_copy is not supported on this platform.");
                };
            }
            return av_dict_copy_fptr(@dst, @src, @flags);
        };
        /// <summary>Copy entries from one AVDictionary struct into another.</summary>
        /// <param name="dst">pointer to a pointer to a AVDictionary struct. If *dst is NULL, this function will allocate a struct for you and put it in *dst</param>
        /// <param name="src">pointer to source AVDictionary struct</param>
        /// <param name="flags">flags to use when setting entries in *dst</param>
        public static int av_dict_copy(AVDictionary** @dst, AVDictionary* @src, int @flags)
        {
            return av_dict_copy_fptr(@dst, @src, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dict_count_delegate(AVDictionary* @m);
        private static av_dict_count_delegate av_dict_count_fptr = (AVDictionary* @m) =>
        {
            av_dict_count_fptr = GetFunctionDelegate<av_dict_count_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_count");
            if (av_dict_count_fptr == null)
            {
                av_dict_count_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_count is not supported on this platform.");
                };
            }
            return av_dict_count_fptr(@m);
        };
        /// <summary>Get number of entries in dictionary.</summary>
        /// <param name="m">dictionary</param>
        public static int av_dict_count(AVDictionary* @m)
        {
            return av_dict_count_fptr(@m);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_dict_free_delegate(AVDictionary** @m);
        private static av_dict_free_delegate av_dict_free_fptr = (AVDictionary** @m) =>
        {
            av_dict_free_fptr = GetFunctionDelegate<av_dict_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_free");
            if (av_dict_free_fptr == null)
            {
                av_dict_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_free is not supported on this platform.");
                };
            }
            av_dict_free_fptr(@m);
        };
        /// <summary>Free all the memory allocated for an AVDictionary struct and all keys and values.</summary>
        public static void av_dict_free(AVDictionary** @m)
        {
            av_dict_free_fptr(@m);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVDictionaryEntry* av_dict_get_delegate(AVDictionary* @m, [MarshalAs(UnmanagedType.LPStr)] string @key, AVDictionaryEntry* @prev, int @flags);
        private static av_dict_get_delegate av_dict_get_fptr = (AVDictionary* @m, string @key, AVDictionaryEntry* @prev, int @flags) =>
        {
            av_dict_get_fptr = GetFunctionDelegate<av_dict_get_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_get");
            if (av_dict_get_fptr == null)
            {
                av_dict_get_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_get is not supported on this platform.");
                };
            }
            return av_dict_get_fptr(@m, @key, @prev, @flags);
        };
        /// <summary>Get a dictionary entry with matching key.</summary>
        /// <param name="key">matching key</param>
        /// <param name="prev">Set to the previous matching element to find the next. If set to NULL the first matching element is returned.</param>
        /// <param name="flags">a collection of AV_DICT_* flags controlling how the entry is retrieved</param>
        public static AVDictionaryEntry* av_dict_get(AVDictionary* @m, [MarshalAs(UnmanagedType.LPStr)] string @key, AVDictionaryEntry* @prev, int @flags)
        {
            return av_dict_get_fptr(@m, @key, @prev, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dict_get_string_delegate(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
        private static av_dict_get_string_delegate av_dict_get_string_fptr = (AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep) =>
        {
            av_dict_get_string_fptr = GetFunctionDelegate<av_dict_get_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_get_string");
            if (av_dict_get_string_fptr == null)
            {
                av_dict_get_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_get_string is not supported on this platform.");
                };
            }
            return av_dict_get_string_fptr(@m, @buffer, @key_val_sep, @pairs_sep);
        };
        /// <summary>Get dictionary entries as a string.</summary>
        /// <param name="m">dictionary</param>
        /// <param name="buffer">Pointer to buffer that will be allocated with string containg entries. Buffer must be freed by the caller when is no longer needed.</param>
        /// <param name="key_val_sep">character used to separate key from value</param>
        /// <param name="pairs_sep">character used to separate two pairs from each other</param>
        public static int av_dict_get_string(AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep)
        {
            return av_dict_get_string_fptr(@m, @buffer, @key_val_sep, @pairs_sep);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dict_parse_string_delegate(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @str, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, int @flags);
        private static av_dict_parse_string_delegate av_dict_parse_string_fptr = (AVDictionary** @pm, string @str, string @key_val_sep, string @pairs_sep, int @flags) =>
        {
            av_dict_parse_string_fptr = GetFunctionDelegate<av_dict_parse_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_parse_string");
            if (av_dict_parse_string_fptr == null)
            {
                av_dict_parse_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_parse_string is not supported on this platform.");
                };
            }
            return av_dict_parse_string_fptr(@pm, @str, @key_val_sep, @pairs_sep, @flags);
        };
        /// <summary>Parse the key/value pairs list and add the parsed entries to a dictionary.</summary>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
        /// <param name="flags">flags to use when adding to dictionary. AV_DICT_DONT_STRDUP_KEY and AV_DICT_DONT_STRDUP_VAL are ignored since the key/value tokens will always be duplicated.</param>
        public static int av_dict_parse_string(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @str, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, int @flags)
        {
            return av_dict_parse_string_fptr(@pm, @str, @key_val_sep, @pairs_sep, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dict_set_delegate(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, [MarshalAs(UnmanagedType.LPStr)] string @value, int @flags);
        private static av_dict_set_delegate av_dict_set_fptr = (AVDictionary** @pm, string @key, string @value, int @flags) =>
        {
            av_dict_set_fptr = GetFunctionDelegate<av_dict_set_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_set");
            if (av_dict_set_fptr == null)
            {
                av_dict_set_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_set is not supported on this platform.");
                };
            }
            return av_dict_set_fptr(@pm, @key, @value, @flags);
        };
        /// <summary>Set the given entry in *pm, overwriting an existing entry.</summary>
        /// <param name="pm">pointer to a pointer to a dictionary struct. If *pm is NULL a dictionary struct is allocated and put in *pm.</param>
        /// <param name="key">entry key to add to *pm (will either be av_strduped or added as a new key depending on flags)</param>
        /// <param name="value">entry value to add to *pm (will be av_strduped or added as a new key depending on flags). Passing a NULL value will cause an existing entry to be deleted.</param>
        public static int av_dict_set(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, [MarshalAs(UnmanagedType.LPStr)] string @value, int @flags)
        {
            return av_dict_set_fptr(@pm, @key, @value, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dict_set_int_delegate(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, long @value, int @flags);
        private static av_dict_set_int_delegate av_dict_set_int_fptr = (AVDictionary** @pm, string @key, long @value, int @flags) =>
        {
            av_dict_set_int_fptr = GetFunctionDelegate<av_dict_set_int_delegate>(GetOrLoadLibrary("avutil", 55), "av_dict_set_int");
            if (av_dict_set_int_fptr == null)
            {
                av_dict_set_int_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dict_set_int is not supported on this platform.");
                };
            }
            return av_dict_set_int_fptr(@pm, @key, @value, @flags);
        };
        /// <summary>Convenience wrapper for av_dict_set that converts the value to a string and stores it.</summary>
        public static int av_dict_set_int(AVDictionary** @pm, [MarshalAs(UnmanagedType.LPStr)] string @key, long @value, int @flags)
        {
            return av_dict_set_int_fptr(@pm, @key, @value, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_div_q_delegate(AVRational @b, AVRational @c);
        private static av_div_q_delegate av_div_q_fptr = (AVRational @b, AVRational @c) =>
        {
            av_div_q_fptr = GetFunctionDelegate<av_div_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_div_q");
            if (av_div_q_fptr == null)
            {
                av_div_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_div_q is not supported on this platform.");
                };
            }
            return av_div_q_fptr(@b, @c);
        };
        /// <summary>Divide one rational by another.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        public static AVRational av_div_q(AVRational @b, AVRational @c)
        {
            return av_div_q_fptr(@b, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_dynarray_add_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);
        private static av_dynarray_add_delegate av_dynarray_add_fptr = (void* @tab_ptr, int* @nb_ptr, void* @elem) =>
        {
            av_dynarray_add_fptr = GetFunctionDelegate<av_dynarray_add_delegate>(GetOrLoadLibrary("avutil", 55), "av_dynarray_add");
            if (av_dynarray_add_fptr == null)
            {
                av_dynarray_add_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dynarray_add is not supported on this platform.");
                };
            }
            av_dynarray_add_fptr(@tab_ptr, @nb_ptr, @elem);
        };
        /// <summary>Add the pointer to an element to a dynamic array.</summary>
        /// <param name="tab_ptr">Pointer to the array to grow</param>
        /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
        /// <param name="elem">Element to add</param>
        public static void av_dynarray_add(void* @tab_ptr, int* @nb_ptr, void* @elem)
        {
            av_dynarray_add_fptr(@tab_ptr, @nb_ptr, @elem);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_dynarray_add_nofree_delegate(void* @tab_ptr, int* @nb_ptr, void* @elem);
        private static av_dynarray_add_nofree_delegate av_dynarray_add_nofree_fptr = (void* @tab_ptr, int* @nb_ptr, void* @elem) =>
        {
            av_dynarray_add_nofree_fptr = GetFunctionDelegate<av_dynarray_add_nofree_delegate>(GetOrLoadLibrary("avutil", 55), "av_dynarray_add_nofree");
            if (av_dynarray_add_nofree_fptr == null)
            {
                av_dynarray_add_nofree_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dynarray_add_nofree is not supported on this platform.");
                };
            }
            return av_dynarray_add_nofree_fptr(@tab_ptr, @nb_ptr, @elem);
        };
        /// <summary>Add an element to a dynamic array.</summary>
        public static int av_dynarray_add_nofree(void* @tab_ptr, int* @nb_ptr, void* @elem)
        {
            return av_dynarray_add_nofree_fptr(@tab_ptr, @nb_ptr, @elem);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_dynarray2_add_delegate(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data);
        private static av_dynarray2_add_delegate av_dynarray2_add_fptr = (void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data) =>
        {
            av_dynarray2_add_fptr = GetFunctionDelegate<av_dynarray2_add_delegate>(GetOrLoadLibrary("avutil", 55), "av_dynarray2_add");
            if (av_dynarray2_add_fptr == null)
            {
                av_dynarray2_add_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_dynarray2_add is not supported on this platform.");
                };
            }
            return av_dynarray2_add_fptr(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
        };
        /// <summary>Add an element of size `elem_size` to a dynamic array.</summary>
        /// <param name="tab_ptr">Pointer to the array to grow</param>
        /// <param name="nb_ptr">Pointer to the number of elements in the array</param>
        /// <param name="elem_size">Size in bytes of an element in the array</param>
        /// <param name="elem_data">Pointer to the data of the element to add. If `NULL`, the space of the newly added element is allocated but left uninitialized.</param>
        public static void* av_dynarray2_add(void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data)
        {
            return av_dynarray2_add_fptr(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fast_malloc_delegate(void* @ptr, uint* @size, ulong @min_size);
        private static av_fast_malloc_delegate av_fast_malloc_fptr = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            av_fast_malloc_fptr = GetFunctionDelegate<av_fast_malloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_fast_malloc");
            if (av_fast_malloc_fptr == null)
            {
                av_fast_malloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fast_malloc is not supported on this platform.");
                };
            }
            av_fast_malloc_fptr(@ptr, @size, @min_size);
        };
        /// <summary>Allocate a buffer, reusing the given one if large enough.</summary>
        /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
        /// <param name="size">Pointer to current size of buffer `*ptr`. `*size` is changed to `min_size` in case of success or 0 in case of failure</param>
        /// <param name="min_size">New size of buffer `*ptr`</param>
        public static void av_fast_malloc(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_malloc_fptr(@ptr, @size, @min_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fast_mallocz_delegate(void* @ptr, uint* @size, ulong @min_size);
        private static av_fast_mallocz_delegate av_fast_mallocz_fptr = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            av_fast_mallocz_fptr = GetFunctionDelegate<av_fast_mallocz_delegate>(GetOrLoadLibrary("avutil", 55), "av_fast_mallocz");
            if (av_fast_mallocz_fptr == null)
            {
                av_fast_mallocz_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fast_mallocz is not supported on this platform.");
                };
            }
            av_fast_mallocz_fptr(@ptr, @size, @min_size);
        };
        /// <summary>Allocate and clear a buffer, reusing the given one if large enough.</summary>
        /// <param name="ptr">Pointer to pointer to an already allocated buffer. `*ptr` will be overwritten with pointer to new buffer on success or `NULL` on failure</param>
        /// <param name="size">Pointer to current size of buffer `*ptr`. `*size` is changed to `min_size` in case of success or 0 in case of failure</param>
        /// <param name="min_size">New size of buffer `*ptr`</param>
        public static void av_fast_mallocz(void* @ptr, uint* @size, ulong @min_size)
        {
            av_fast_mallocz_fptr(@ptr, @size, @min_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_fast_realloc_delegate(void* @ptr, uint* @size, ulong @min_size);
        private static av_fast_realloc_delegate av_fast_realloc_fptr = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            av_fast_realloc_fptr = GetFunctionDelegate<av_fast_realloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_fast_realloc");
            if (av_fast_realloc_fptr == null)
            {
                av_fast_realloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fast_realloc is not supported on this platform.");
                };
            }
            return av_fast_realloc_fptr(@ptr, @size, @min_size);
        };
        /// <summary>Reallocate the given buffer if it is not large enough, otherwise do nothing.</summary>
        /// <param name="ptr">Already allocated buffer, or `NULL`</param>
        /// <param name="size">Pointer to current size of buffer `ptr`. `*size` is changed to `min_size` in case of success or 0 in case of failure</param>
        /// <param name="min_size">New size of buffer `ptr`</param>
        public static void* av_fast_realloc(void* @ptr, uint* @size, ulong @min_size)
        {
            return av_fast_realloc_fptr(@ptr, @size, @min_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFifoBuffer* av_fifo_alloc_delegate(uint @size);
        private static av_fifo_alloc_delegate av_fifo_alloc_fptr = (uint @size) =>
        {
            av_fifo_alloc_fptr = GetFunctionDelegate<av_fifo_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_alloc");
            if (av_fifo_alloc_fptr == null)
            {
                av_fifo_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_alloc is not supported on this platform.");
                };
            }
            return av_fifo_alloc_fptr(@size);
        };
        /// <summary>Initialize an AVFifoBuffer.</summary>
        /// <param name="size">of FIFO</param>
        public static AVFifoBuffer* av_fifo_alloc(uint @size)
        {
            return av_fifo_alloc_fptr(@size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFifoBuffer* av_fifo_alloc_array_delegate(ulong @nmemb, ulong @size);
        private static av_fifo_alloc_array_delegate av_fifo_alloc_array_fptr = (ulong @nmemb, ulong @size) =>
        {
            av_fifo_alloc_array_fptr = GetFunctionDelegate<av_fifo_alloc_array_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_alloc_array");
            if (av_fifo_alloc_array_fptr == null)
            {
                av_fifo_alloc_array_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_alloc_array is not supported on this platform.");
                };
            }
            return av_fifo_alloc_array_fptr(@nmemb, @size);
        };
        /// <summary>Initialize an AVFifoBuffer.</summary>
        /// <param name="nmemb">number of elements</param>
        /// <param name="size">size of the single element</param>
        public static AVFifoBuffer* av_fifo_alloc_array(ulong @nmemb, ulong @size)
        {
            return av_fifo_alloc_array_fptr(@nmemb, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fifo_drain_delegate(AVFifoBuffer* @f, int @size);
        private static av_fifo_drain_delegate av_fifo_drain_fptr = (AVFifoBuffer* @f, int @size) =>
        {
            av_fifo_drain_fptr = GetFunctionDelegate<av_fifo_drain_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_drain");
            if (av_fifo_drain_fptr == null)
            {
                av_fifo_drain_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_drain is not supported on this platform.");
                };
            }
            av_fifo_drain_fptr(@f, @size);
        };
        /// <summary>Read and discard the specified amount of data from an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="size">amount of data to read in bytes</param>
        public static void av_fifo_drain(AVFifoBuffer* @f, int @size)
        {
            av_fifo_drain_fptr(@f, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fifo_free_delegate(AVFifoBuffer* @f);
        private static av_fifo_free_delegate av_fifo_free_fptr = (AVFifoBuffer* @f) =>
        {
            av_fifo_free_fptr = GetFunctionDelegate<av_fifo_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_free");
            if (av_fifo_free_fptr == null)
            {
                av_fifo_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_free is not supported on this platform.");
                };
            }
            av_fifo_free_fptr(@f);
        };
        /// <summary>Free an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to free</param>
        public static void av_fifo_free(AVFifoBuffer* @f)
        {
            av_fifo_free_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fifo_freep_delegate(AVFifoBuffer** @f);
        private static av_fifo_freep_delegate av_fifo_freep_fptr = (AVFifoBuffer** @f) =>
        {
            av_fifo_freep_fptr = GetFunctionDelegate<av_fifo_freep_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_freep");
            if (av_fifo_freep_fptr == null)
            {
                av_fifo_freep_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_freep is not supported on this platform.");
                };
            }
            av_fifo_freep_fptr(@f);
        };
        /// <summary>Free an AVFifoBuffer and reset pointer to NULL.</summary>
        /// <param name="f">AVFifoBuffer to free</param>
        public static void av_fifo_freep(AVFifoBuffer** @f)
        {
            av_fifo_freep_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_generic_peek_delegate(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_peek_func_func @func);
        private static av_fifo_generic_peek_delegate av_fifo_generic_peek_fptr = (AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_peek_func_func @func) =>
        {
            av_fifo_generic_peek_fptr = GetFunctionDelegate<av_fifo_generic_peek_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_generic_peek");
            if (av_fifo_generic_peek_fptr == null)
            {
                av_fifo_generic_peek_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_generic_peek is not supported on this platform.");
                };
            }
            return av_fifo_generic_peek_fptr(@f, @dest, @buf_size, @func);
        };
        /// <summary>Feed data from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        public static int av_fifo_generic_peek(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_peek_func_func @func)
        {
            return av_fifo_generic_peek_fptr(@f, @dest, @buf_size, @func);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_generic_peek_at_delegate(AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, av_fifo_generic_peek_at_func_func @func);
        private static av_fifo_generic_peek_at_delegate av_fifo_generic_peek_at_fptr = (AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, av_fifo_generic_peek_at_func_func @func) =>
        {
            av_fifo_generic_peek_at_fptr = GetFunctionDelegate<av_fifo_generic_peek_at_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_generic_peek_at");
            if (av_fifo_generic_peek_at_fptr == null)
            {
                av_fifo_generic_peek_at_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_generic_peek_at is not supported on this platform.");
                };
            }
            return av_fifo_generic_peek_at_fptr(@f, @dest, @offset, @buf_size, @func);
        };
        /// <summary>Feed data at specific position from an AVFifoBuffer to a user-supplied callback. Similar as av_fifo_gereric_read but without discarding data.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="offset">offset from current read position</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        public static int av_fifo_generic_peek_at(AVFifoBuffer* @f, void* @dest, int @offset, int @buf_size, av_fifo_generic_peek_at_func_func @func)
        {
            return av_fifo_generic_peek_at_fptr(@f, @dest, @offset, @buf_size, @func);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_generic_read_delegate(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_read_func_func @func);
        private static av_fifo_generic_read_delegate av_fifo_generic_read_fptr = (AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_read_func_func @func) =>
        {
            av_fifo_generic_read_fptr = GetFunctionDelegate<av_fifo_generic_read_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_generic_read");
            if (av_fifo_generic_read_fptr == null)
            {
                av_fifo_generic_read_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_generic_read is not supported on this platform.");
                };
            }
            return av_fifo_generic_read_fptr(@f, @dest, @buf_size, @func);
        };
        /// <summary>Feed data from an AVFifoBuffer to a user-supplied callback.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        /// <param name="dest">data destination</param>
        /// <param name="buf_size">number of bytes to read</param>
        /// <param name="func">generic read function</param>
        public static int av_fifo_generic_read(AVFifoBuffer* @f, void* @dest, int @buf_size, av_fifo_generic_read_func_func @func)
        {
            return av_fifo_generic_read_fptr(@f, @dest, @buf_size, @func);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_generic_write_delegate(AVFifoBuffer* @f, void* @src, int @size, av_fifo_generic_write_func_func @func);
        private static av_fifo_generic_write_delegate av_fifo_generic_write_fptr = (AVFifoBuffer* @f, void* @src, int @size, av_fifo_generic_write_func_func @func) =>
        {
            av_fifo_generic_write_fptr = GetFunctionDelegate<av_fifo_generic_write_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_generic_write");
            if (av_fifo_generic_write_fptr == null)
            {
                av_fifo_generic_write_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_generic_write is not supported on this platform.");
                };
            }
            return av_fifo_generic_write_fptr(@f, @src, @size, @func);
        };
        /// <summary>Feed data from a user-supplied callback to an AVFifoBuffer.</summary>
        /// <param name="f">AVFifoBuffer to write to</param>
        /// <param name="src">data source; non-const since it may be used as a modifiable context by the function defined in func</param>
        /// <param name="size">number of bytes to write</param>
        /// <param name="func">generic write function; the first parameter is src, the second is dest_buf, the third is dest_buf_size. func must return the number of bytes written to dest_buf, or &lt; = 0 to indicate no more data available to write. If func is NULL, src is interpreted as a simple byte array for source data.</param>
        public static int av_fifo_generic_write(AVFifoBuffer* @f, void* @src, int @size, av_fifo_generic_write_func_func @func)
        {
            return av_fifo_generic_write_fptr(@f, @src, @size, @func);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_grow_delegate(AVFifoBuffer* @f, uint @additional_space);
        private static av_fifo_grow_delegate av_fifo_grow_fptr = (AVFifoBuffer* @f, uint @additional_space) =>
        {
            av_fifo_grow_fptr = GetFunctionDelegate<av_fifo_grow_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_grow");
            if (av_fifo_grow_fptr == null)
            {
                av_fifo_grow_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_grow is not supported on this platform.");
                };
            }
            return av_fifo_grow_fptr(@f, @additional_space);
        };
        /// <summary>Enlarge an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged. The new fifo size may be larger than the requested size.</summary>
        /// <param name="f">AVFifoBuffer to resize</param>
        /// <param name="additional_space">the amount of space in bytes to allocate in addition to av_fifo_size()</param>
        public static int av_fifo_grow(AVFifoBuffer* @f, uint @additional_space)
        {
            return av_fifo_grow_fptr(@f, @additional_space);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_realloc2_delegate(AVFifoBuffer* @f, uint @size);
        private static av_fifo_realloc2_delegate av_fifo_realloc2_fptr = (AVFifoBuffer* @f, uint @size) =>
        {
            av_fifo_realloc2_fptr = GetFunctionDelegate<av_fifo_realloc2_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_realloc2");
            if (av_fifo_realloc2_fptr == null)
            {
                av_fifo_realloc2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_realloc2 is not supported on this platform.");
                };
            }
            return av_fifo_realloc2_fptr(@f, @size);
        };
        /// <summary>Resize an AVFifoBuffer. In case of reallocation failure, the old FIFO is kept unchanged.</summary>
        /// <param name="f">AVFifoBuffer to resize</param>
        /// <param name="size">new AVFifoBuffer size in bytes</param>
        public static int av_fifo_realloc2(AVFifoBuffer* @f, uint @size)
        {
            return av_fifo_realloc2_fptr(@f, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_fifo_reset_delegate(AVFifoBuffer* @f);
        private static av_fifo_reset_delegate av_fifo_reset_fptr = (AVFifoBuffer* @f) =>
        {
            av_fifo_reset_fptr = GetFunctionDelegate<av_fifo_reset_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_reset");
            if (av_fifo_reset_fptr == null)
            {
                av_fifo_reset_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_reset is not supported on this platform.");
                };
            }
            av_fifo_reset_fptr(@f);
        };
        /// <summary>Reset the AVFifoBuffer to the state right after av_fifo_alloc, in particular it is emptied.</summary>
        /// <param name="f">AVFifoBuffer to reset</param>
        public static void av_fifo_reset(AVFifoBuffer* @f)
        {
            av_fifo_reset_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_size_delegate(AVFifoBuffer* @f);
        private static av_fifo_size_delegate av_fifo_size_fptr = (AVFifoBuffer* @f) =>
        {
            av_fifo_size_fptr = GetFunctionDelegate<av_fifo_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_size");
            if (av_fifo_size_fptr == null)
            {
                av_fifo_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_size is not supported on this platform.");
                };
            }
            return av_fifo_size_fptr(@f);
        };
        /// <summary>Return the amount of data in bytes in the AVFifoBuffer, that is the amount of data you can read from it.</summary>
        /// <param name="f">AVFifoBuffer to read from</param>
        public static int av_fifo_size(AVFifoBuffer* @f)
        {
            return av_fifo_size_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_fifo_space_delegate(AVFifoBuffer* @f);
        private static av_fifo_space_delegate av_fifo_space_fptr = (AVFifoBuffer* @f) =>
        {
            av_fifo_space_fptr = GetFunctionDelegate<av_fifo_space_delegate>(GetOrLoadLibrary("avutil", 55), "av_fifo_space");
            if (av_fifo_space_fptr == null)
            {
                av_fifo_space_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fifo_space is not supported on this platform.");
                };
            }
            return av_fifo_space_fptr(@f);
        };
        /// <summary>Return the amount of space in bytes in the AVFifoBuffer, that is the amount of data you can write into it.</summary>
        /// <param name="f">AVFifoBuffer to write into</param>
        public static int av_fifo_space(AVFifoBuffer* @f)
        {
            return av_fifo_space_fptr(@f);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat av_find_best_pix_fmt_of_2_delegate(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr);
        private static av_find_best_pix_fmt_of_2_delegate av_find_best_pix_fmt_of_2_fptr = (AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
        {
            av_find_best_pix_fmt_of_2_fptr = GetFunctionDelegate<av_find_best_pix_fmt_of_2_delegate>(GetOrLoadLibrary("avutil", 55), "av_find_best_pix_fmt_of_2");
            if (av_find_best_pix_fmt_of_2_fptr == null)
            {
                av_find_best_pix_fmt_of_2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_find_best_pix_fmt_of_2 is not supported on this platform.");
                };
            }
            return av_find_best_pix_fmt_of_2_fptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        };
        /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        public static AVPixelFormat av_find_best_pix_fmt_of_2(AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr)
        {
            return av_find_best_pix_fmt_of_2_fptr(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_find_nearest_q_idx_delegate(AVRational @q, AVRational* @q_list);
        private static av_find_nearest_q_idx_delegate av_find_nearest_q_idx_fptr = (AVRational @q, AVRational* @q_list) =>
        {
            av_find_nearest_q_idx_fptr = GetFunctionDelegate<av_find_nearest_q_idx_delegate>(GetOrLoadLibrary("avutil", 55), "av_find_nearest_q_idx");
            if (av_find_nearest_q_idx_fptr == null)
            {
                av_find_nearest_q_idx_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_find_nearest_q_idx is not supported on this platform.");
                };
            }
            return av_find_nearest_q_idx_fptr(@q, @q_list);
        };
        /// <summary>Find the value in a list of rationals nearest a given reference rational.</summary>
        /// <param name="q">Reference rational</param>
        /// <param name="q_list">Array of rationals terminated by `{0, 0}`</param>
        public static int av_find_nearest_q_idx(AVRational @q, AVRational* @q_list)
        {
            return av_find_nearest_q_idx_fptr(@q, @q_list);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate _iobuf* av_fopen_utf8_delegate([MarshalAs(UnmanagedType.LPStr)] string @path, [MarshalAs(UnmanagedType.LPStr)] string @mode);
        private static av_fopen_utf8_delegate av_fopen_utf8_fptr = (string @path, string @mode) =>
        {
            av_fopen_utf8_fptr = GetFunctionDelegate<av_fopen_utf8_delegate>(GetOrLoadLibrary("avutil", 55), "av_fopen_utf8");
            if (av_fopen_utf8_fptr == null)
            {
                av_fopen_utf8_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fopen_utf8 is not supported on this platform.");
                };
            }
            return av_fopen_utf8_fptr(@path, @mode);
        };
        /// <summary>Open a file using a UTF-8 filename. The API of this function matches POSIX fopen(), errors are returned through errno.</summary>
        public static _iobuf* av_fopen_utf8([MarshalAs(UnmanagedType.LPStr)] string @path, [MarshalAs(UnmanagedType.LPStr)] string @mode)
        {
            return av_fopen_utf8_fptr(@path, @mode);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_force_cpu_flags_delegate(int @flags);
        private static av_force_cpu_flags_delegate av_force_cpu_flags_fptr = (int @flags) =>
        {
            av_force_cpu_flags_fptr = GetFunctionDelegate<av_force_cpu_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_force_cpu_flags");
            if (av_force_cpu_flags_fptr == null)
            {
                av_force_cpu_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_force_cpu_flags is not supported on this platform.");
                };
            }
            av_force_cpu_flags_fptr(@flags);
        };
        /// <summary>Disables cpu detection and forces the specified flags. -1 is a special case that disables forcing of specific flags.</summary>
        public static void av_force_cpu_flags(int @flags)
        {
            av_force_cpu_flags_fptr(@flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_fourcc_make_string_delegate(byte* @buf, uint @fourcc);
        private static av_fourcc_make_string_delegate av_fourcc_make_string_fptr = (byte* @buf, uint @fourcc) =>
        {
            av_fourcc_make_string_fptr = GetFunctionDelegate<av_fourcc_make_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_fourcc_make_string");
            if (av_fourcc_make_string_fptr == null)
            {
                av_fourcc_make_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_fourcc_make_string is not supported on this platform.");
                };
            }
            return av_fourcc_make_string_fptr(@buf, @fourcc);
        };
        /// <summary>Fill the provided buffer with a string containing a FourCC (four-character code) representation.</summary>
        /// <param name="buf">a buffer with size in bytes of at least AV_FOURCC_MAX_STRING_SIZE</param>
        /// <param name="fourcc">the fourcc to represent</param>
        public static byte* av_fourcc_make_string(byte* @buf, uint @fourcc)
        {
            return av_fourcc_make_string_fptr(@buf, @fourcc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFrame* av_frame_alloc_delegate();
        private static av_frame_alloc_delegate av_frame_alloc_fptr = () =>
        {
            av_frame_alloc_fptr = GetFunctionDelegate<av_frame_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_alloc");
            if (av_frame_alloc_fptr == null)
            {
                av_frame_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_alloc is not supported on this platform.");
                };
            }
            return av_frame_alloc_fptr();
        };
        /// <summary>Allocate an AVFrame and set its fields to default values. The resulting struct must be freed using av_frame_free().</summary>
        public static AVFrame* av_frame_alloc()
        {
            return av_frame_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_apply_cropping_delegate(AVFrame* @frame, int @flags);
        private static av_frame_apply_cropping_delegate av_frame_apply_cropping_fptr = (AVFrame* @frame, int @flags) =>
        {
            av_frame_apply_cropping_fptr = GetFunctionDelegate<av_frame_apply_cropping_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_apply_cropping");
            if (av_frame_apply_cropping_fptr == null)
            {
                av_frame_apply_cropping_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_apply_cropping is not supported on this platform.");
                };
            }
            return av_frame_apply_cropping_fptr(@frame, @flags);
        };
        /// <summary>Crop the given video AVFrame according to its crop_left/crop_top/crop_right/ crop_bottom fields. If cropping is successful, the function will adjust the data pointers and the width/height fields, and set the crop fields to 0.</summary>
        /// <param name="frame">the frame which should be cropped</param>
        /// <param name="flags">Some combination of AV_FRAME_CROP_* flags, or 0.</param>
        public static int av_frame_apply_cropping(AVFrame* @frame, int @flags)
        {
            return av_frame_apply_cropping_fptr(@frame, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFrame* av_frame_clone_delegate(AVFrame* @src);
        private static av_frame_clone_delegate av_frame_clone_fptr = (AVFrame* @src) =>
        {
            av_frame_clone_fptr = GetFunctionDelegate<av_frame_clone_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_clone");
            if (av_frame_clone_fptr == null)
            {
                av_frame_clone_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_clone is not supported on this platform.");
                };
            }
            return av_frame_clone_fptr(@src);
        };
        /// <summary>Create a new frame that references the same data as src.</summary>
        public static AVFrame* av_frame_clone(AVFrame* @src)
        {
            return av_frame_clone_fptr(@src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_copy_delegate(AVFrame* @dst, AVFrame* @src);
        private static av_frame_copy_delegate av_frame_copy_fptr = (AVFrame* @dst, AVFrame* @src) =>
        {
            av_frame_copy_fptr = GetFunctionDelegate<av_frame_copy_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_copy");
            if (av_frame_copy_fptr == null)
            {
                av_frame_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_copy is not supported on this platform.");
                };
            }
            return av_frame_copy_fptr(@dst, @src);
        };
        /// <summary>Copy the frame data from src to dst.</summary>
        public static int av_frame_copy(AVFrame* @dst, AVFrame* @src)
        {
            return av_frame_copy_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_copy_props_delegate(AVFrame* @dst, AVFrame* @src);
        private static av_frame_copy_props_delegate av_frame_copy_props_fptr = (AVFrame* @dst, AVFrame* @src) =>
        {
            av_frame_copy_props_fptr = GetFunctionDelegate<av_frame_copy_props_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_copy_props");
            if (av_frame_copy_props_fptr == null)
            {
                av_frame_copy_props_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_copy_props is not supported on this platform.");
                };
            }
            return av_frame_copy_props_fptr(@dst, @src);
        };
        /// <summary>Copy only &quot;metadata&quot; fields from src to dst.</summary>
        public static int av_frame_copy_props(AVFrame* @dst, AVFrame* @src)
        {
            return av_frame_copy_props_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_free_delegate(AVFrame** @frame);
        private static av_frame_free_delegate av_frame_free_fptr = (AVFrame** @frame) =>
        {
            av_frame_free_fptr = GetFunctionDelegate<av_frame_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_free");
            if (av_frame_free_fptr == null)
            {
                av_frame_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_free is not supported on this platform.");
                };
            }
            av_frame_free_fptr(@frame);
        };
        /// <summary>Free the frame and any dynamically allocated objects in it, e.g. extended_data. If the frame is reference counted, it will be unreferenced first.</summary>
        /// <param name="frame">frame to be freed. The pointer will be set to NULL.</param>
        public static void av_frame_free(AVFrame** @frame)
        {
            av_frame_free_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_frame_get_best_effort_timestamp_delegate(AVFrame* @frame);
        private static av_frame_get_best_effort_timestamp_delegate av_frame_get_best_effort_timestamp_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_best_effort_timestamp_fptr = GetFunctionDelegate<av_frame_get_best_effort_timestamp_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_best_effort_timestamp");
            if (av_frame_get_best_effort_timestamp_fptr == null)
            {
                av_frame_get_best_effort_timestamp_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_best_effort_timestamp is not supported on this platform.");
                };
            }
            return av_frame_get_best_effort_timestamp_fptr(@frame);
        };
        /// <summary>Accessors for some AVFrame fields. These used to be provided for ABI compatibility, and do not need to be used anymore.</summary>
        public static long av_frame_get_best_effort_timestamp(AVFrame* @frame)
        {
            return av_frame_get_best_effort_timestamp_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_get_buffer_delegate(AVFrame* @frame, int @align);
        private static av_frame_get_buffer_delegate av_frame_get_buffer_fptr = (AVFrame* @frame, int @align) =>
        {
            av_frame_get_buffer_fptr = GetFunctionDelegate<av_frame_get_buffer_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_buffer");
            if (av_frame_get_buffer_fptr == null)
            {
                av_frame_get_buffer_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_buffer is not supported on this platform.");
                };
            }
            return av_frame_get_buffer_fptr(@frame, @align);
        };
        /// <summary>Allocate new buffer(s) for audio or video data.</summary>
        /// <param name="frame">frame in which to store the new buffers.</param>
        /// <param name="align">Required buffer size alignment. If equal to 0, alignment will be chosen automatically for the current CPU. It is highly recommended to pass 0 here unless you know what you are doing.</param>
        public static int av_frame_get_buffer(AVFrame* @frame, int @align)
        {
            return av_frame_get_buffer_fptr(@frame, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_frame_get_channel_layout_delegate(AVFrame* @frame);
        private static av_frame_get_channel_layout_delegate av_frame_get_channel_layout_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_channel_layout_fptr = GetFunctionDelegate<av_frame_get_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_channel_layout");
            if (av_frame_get_channel_layout_fptr == null)
            {
                av_frame_get_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_channel_layout is not supported on this platform.");
                };
            }
            return av_frame_get_channel_layout_fptr(@frame);
        };
        public static long av_frame_get_channel_layout(AVFrame* @frame)
        {
            return av_frame_get_channel_layout_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_get_channels_delegate(AVFrame* @frame);
        private static av_frame_get_channels_delegate av_frame_get_channels_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_channels_fptr = GetFunctionDelegate<av_frame_get_channels_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_channels");
            if (av_frame_get_channels_fptr == null)
            {
                av_frame_get_channels_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_channels is not supported on this platform.");
                };
            }
            return av_frame_get_channels_fptr(@frame);
        };
        public static int av_frame_get_channels(AVFrame* @frame)
        {
            return av_frame_get_channels_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVColorRange av_frame_get_color_range_delegate(AVFrame* @frame);
        private static av_frame_get_color_range_delegate av_frame_get_color_range_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_color_range_fptr = GetFunctionDelegate<av_frame_get_color_range_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_color_range");
            if (av_frame_get_color_range_fptr == null)
            {
                av_frame_get_color_range_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_color_range is not supported on this platform.");
                };
            }
            return av_frame_get_color_range_fptr(@frame);
        };
        public static AVColorRange av_frame_get_color_range(AVFrame* @frame)
        {
            return av_frame_get_color_range_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVColorSpace av_frame_get_colorspace_delegate(AVFrame* @frame);
        private static av_frame_get_colorspace_delegate av_frame_get_colorspace_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_colorspace_fptr = GetFunctionDelegate<av_frame_get_colorspace_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_colorspace");
            if (av_frame_get_colorspace_fptr == null)
            {
                av_frame_get_colorspace_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_colorspace is not supported on this platform.");
                };
            }
            return av_frame_get_colorspace_fptr(@frame);
        };
        public static AVColorSpace av_frame_get_colorspace(AVFrame* @frame)
        {
            return av_frame_get_colorspace_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_get_decode_error_flags_delegate(AVFrame* @frame);
        private static av_frame_get_decode_error_flags_delegate av_frame_get_decode_error_flags_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_decode_error_flags_fptr = GetFunctionDelegate<av_frame_get_decode_error_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_decode_error_flags");
            if (av_frame_get_decode_error_flags_fptr == null)
            {
                av_frame_get_decode_error_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_decode_error_flags is not supported on this platform.");
                };
            }
            return av_frame_get_decode_error_flags_fptr(@frame);
        };
        public static int av_frame_get_decode_error_flags(AVFrame* @frame)
        {
            return av_frame_get_decode_error_flags_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVDictionary* av_frame_get_metadata_delegate(AVFrame* @frame);
        private static av_frame_get_metadata_delegate av_frame_get_metadata_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_metadata_fptr = GetFunctionDelegate<av_frame_get_metadata_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_metadata");
            if (av_frame_get_metadata_fptr == null)
            {
                av_frame_get_metadata_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_metadata is not supported on this platform.");
                };
            }
            return av_frame_get_metadata_fptr(@frame);
        };
        public static AVDictionary* av_frame_get_metadata(AVFrame* @frame)
        {
            return av_frame_get_metadata_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_frame_get_pkt_duration_delegate(AVFrame* @frame);
        private static av_frame_get_pkt_duration_delegate av_frame_get_pkt_duration_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_pkt_duration_fptr = GetFunctionDelegate<av_frame_get_pkt_duration_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_pkt_duration");
            if (av_frame_get_pkt_duration_fptr == null)
            {
                av_frame_get_pkt_duration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_pkt_duration is not supported on this platform.");
                };
            }
            return av_frame_get_pkt_duration_fptr(@frame);
        };
        public static long av_frame_get_pkt_duration(AVFrame* @frame)
        {
            return av_frame_get_pkt_duration_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_frame_get_pkt_pos_delegate(AVFrame* @frame);
        private static av_frame_get_pkt_pos_delegate av_frame_get_pkt_pos_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_pkt_pos_fptr = GetFunctionDelegate<av_frame_get_pkt_pos_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_pkt_pos");
            if (av_frame_get_pkt_pos_fptr == null)
            {
                av_frame_get_pkt_pos_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_pkt_pos is not supported on this platform.");
                };
            }
            return av_frame_get_pkt_pos_fptr(@frame);
        };
        public static long av_frame_get_pkt_pos(AVFrame* @frame)
        {
            return av_frame_get_pkt_pos_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_get_pkt_size_delegate(AVFrame* @frame);
        private static av_frame_get_pkt_size_delegate av_frame_get_pkt_size_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_pkt_size_fptr = GetFunctionDelegate<av_frame_get_pkt_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_pkt_size");
            if (av_frame_get_pkt_size_fptr == null)
            {
                av_frame_get_pkt_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_pkt_size is not supported on this platform.");
                };
            }
            return av_frame_get_pkt_size_fptr(@frame);
        };
        public static int av_frame_get_pkt_size(AVFrame* @frame)
        {
            return av_frame_get_pkt_size_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_frame_get_plane_buffer_delegate(AVFrame* @frame, int @plane);
        private static av_frame_get_plane_buffer_delegate av_frame_get_plane_buffer_fptr = (AVFrame* @frame, int @plane) =>
        {
            av_frame_get_plane_buffer_fptr = GetFunctionDelegate<av_frame_get_plane_buffer_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_plane_buffer");
            if (av_frame_get_plane_buffer_fptr == null)
            {
                av_frame_get_plane_buffer_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_plane_buffer is not supported on this platform.");
                };
            }
            return av_frame_get_plane_buffer_fptr(@frame, @plane);
        };
        /// <summary>Get the buffer reference a given data plane is stored in.</summary>
        /// <param name="plane">index of the data plane of interest in frame-&gt;extended_data.</param>
        public static AVBufferRef* av_frame_get_plane_buffer(AVFrame* @frame, int @plane)
        {
            return av_frame_get_plane_buffer_fptr(@frame, @plane);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate sbyte* av_frame_get_qp_table_delegate(AVFrame* @f, int* @stride, int* @type);
        private static av_frame_get_qp_table_delegate av_frame_get_qp_table_fptr = (AVFrame* @f, int* @stride, int* @type) =>
        {
            av_frame_get_qp_table_fptr = GetFunctionDelegate<av_frame_get_qp_table_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_qp_table");
            if (av_frame_get_qp_table_fptr == null)
            {
                av_frame_get_qp_table_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_qp_table is not supported on this platform.");
                };
            }
            return av_frame_get_qp_table_fptr(@f, @stride, @type);
        };
        public static sbyte* av_frame_get_qp_table(AVFrame* @f, int* @stride, int* @type)
        {
            return av_frame_get_qp_table_fptr(@f, @stride, @type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_get_sample_rate_delegate(AVFrame* @frame);
        private static av_frame_get_sample_rate_delegate av_frame_get_sample_rate_fptr = (AVFrame* @frame) =>
        {
            av_frame_get_sample_rate_fptr = GetFunctionDelegate<av_frame_get_sample_rate_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_sample_rate");
            if (av_frame_get_sample_rate_fptr == null)
            {
                av_frame_get_sample_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_sample_rate is not supported on this platform.");
                };
            }
            return av_frame_get_sample_rate_fptr(@frame);
        };
        public static int av_frame_get_sample_rate(AVFrame* @frame)
        {
            return av_frame_get_sample_rate_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFrameSideData* av_frame_get_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);
        private static av_frame_get_side_data_delegate av_frame_get_side_data_fptr = (AVFrame* @frame, AVFrameSideDataType @type) =>
        {
            av_frame_get_side_data_fptr = GetFunctionDelegate<av_frame_get_side_data_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_get_side_data");
            if (av_frame_get_side_data_fptr == null)
            {
                av_frame_get_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_get_side_data is not supported on this platform.");
                };
            }
            return av_frame_get_side_data_fptr(@frame, @type);
        };
        /// <summary>Returns a pointer to the side data of a given type on success, NULL if there is no side data with such type in this frame.</summary>
        public static AVFrameSideData* av_frame_get_side_data(AVFrame* @frame, AVFrameSideDataType @type)
        {
            return av_frame_get_side_data_fptr(@frame, @type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_is_writable_delegate(AVFrame* @frame);
        private static av_frame_is_writable_delegate av_frame_is_writable_fptr = (AVFrame* @frame) =>
        {
            av_frame_is_writable_fptr = GetFunctionDelegate<av_frame_is_writable_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_is_writable");
            if (av_frame_is_writable_fptr == null)
            {
                av_frame_is_writable_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_is_writable is not supported on this platform.");
                };
            }
            return av_frame_is_writable_fptr(@frame);
        };
        /// <summary>Check if the frame data is writable.</summary>
        public static int av_frame_is_writable(AVFrame* @frame)
        {
            return av_frame_is_writable_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_make_writable_delegate(AVFrame* @frame);
        private static av_frame_make_writable_delegate av_frame_make_writable_fptr = (AVFrame* @frame) =>
        {
            av_frame_make_writable_fptr = GetFunctionDelegate<av_frame_make_writable_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_make_writable");
            if (av_frame_make_writable_fptr == null)
            {
                av_frame_make_writable_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_make_writable is not supported on this platform.");
                };
            }
            return av_frame_make_writable_fptr(@frame);
        };
        /// <summary>Ensure that the frame data is writable, avoiding data copy if possible.</summary>
        public static int av_frame_make_writable(AVFrame* @frame)
        {
            return av_frame_make_writable_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_move_ref_delegate(AVFrame* @dst, AVFrame* @src);
        private static av_frame_move_ref_delegate av_frame_move_ref_fptr = (AVFrame* @dst, AVFrame* @src) =>
        {
            av_frame_move_ref_fptr = GetFunctionDelegate<av_frame_move_ref_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_move_ref");
            if (av_frame_move_ref_fptr == null)
            {
                av_frame_move_ref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_move_ref is not supported on this platform.");
                };
            }
            av_frame_move_ref_fptr(@dst, @src);
        };
        /// <summary>Move everything contained in src to dst and reset src.</summary>
        public static void av_frame_move_ref(AVFrame* @dst, AVFrame* @src)
        {
            av_frame_move_ref_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVFrameSideData* av_frame_new_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type, int @size);
        private static av_frame_new_side_data_delegate av_frame_new_side_data_fptr = (AVFrame* @frame, AVFrameSideDataType @type, int @size) =>
        {
            av_frame_new_side_data_fptr = GetFunctionDelegate<av_frame_new_side_data_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_new_side_data");
            if (av_frame_new_side_data_fptr == null)
            {
                av_frame_new_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_new_side_data is not supported on this platform.");
                };
            }
            return av_frame_new_side_data_fptr(@frame, @type, @size);
        };
        /// <summary>Add a new side data to a frame.</summary>
        /// <param name="frame">a frame to which the side data should be added</param>
        /// <param name="type">type of the added side data</param>
        /// <param name="size">size of the side data</param>
        public static AVFrameSideData* av_frame_new_side_data(AVFrame* @frame, AVFrameSideDataType @type, int @size)
        {
            return av_frame_new_side_data_fptr(@frame, @type, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_ref_delegate(AVFrame* @dst, AVFrame* @src);
        private static av_frame_ref_delegate av_frame_ref_fptr = (AVFrame* @dst, AVFrame* @src) =>
        {
            av_frame_ref_fptr = GetFunctionDelegate<av_frame_ref_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_ref");
            if (av_frame_ref_fptr == null)
            {
                av_frame_ref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_ref is not supported on this platform.");
                };
            }
            return av_frame_ref_fptr(@dst, @src);
        };
        /// <summary>Set up a new reference to the data described by the source frame.</summary>
        public static int av_frame_ref(AVFrame* @dst, AVFrame* @src)
        {
            return av_frame_ref_fptr(@dst, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_remove_side_data_delegate(AVFrame* @frame, AVFrameSideDataType @type);
        private static av_frame_remove_side_data_delegate av_frame_remove_side_data_fptr = (AVFrame* @frame, AVFrameSideDataType @type) =>
        {
            av_frame_remove_side_data_fptr = GetFunctionDelegate<av_frame_remove_side_data_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_remove_side_data");
            if (av_frame_remove_side_data_fptr == null)
            {
                av_frame_remove_side_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_remove_side_data is not supported on this platform.");
                };
            }
            av_frame_remove_side_data_fptr(@frame, @type);
        };
        /// <summary>If side data of the supplied type exists in the frame, free it and remove it from the frame.</summary>
        public static void av_frame_remove_side_data(AVFrame* @frame, AVFrameSideDataType @type)
        {
            av_frame_remove_side_data_fptr(@frame, @type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_best_effort_timestamp_delegate(AVFrame* @frame, long @val);
        private static av_frame_set_best_effort_timestamp_delegate av_frame_set_best_effort_timestamp_fptr = (AVFrame* @frame, long @val) =>
        {
            av_frame_set_best_effort_timestamp_fptr = GetFunctionDelegate<av_frame_set_best_effort_timestamp_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_best_effort_timestamp");
            if (av_frame_set_best_effort_timestamp_fptr == null)
            {
                av_frame_set_best_effort_timestamp_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_best_effort_timestamp is not supported on this platform.");
                };
            }
            av_frame_set_best_effort_timestamp_fptr(@frame, @val);
        };
        public static void av_frame_set_best_effort_timestamp(AVFrame* @frame, long @val)
        {
            av_frame_set_best_effort_timestamp_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_channel_layout_delegate(AVFrame* @frame, long @val);
        private static av_frame_set_channel_layout_delegate av_frame_set_channel_layout_fptr = (AVFrame* @frame, long @val) =>
        {
            av_frame_set_channel_layout_fptr = GetFunctionDelegate<av_frame_set_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_channel_layout");
            if (av_frame_set_channel_layout_fptr == null)
            {
                av_frame_set_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_channel_layout is not supported on this platform.");
                };
            }
            av_frame_set_channel_layout_fptr(@frame, @val);
        };
        public static void av_frame_set_channel_layout(AVFrame* @frame, long @val)
        {
            av_frame_set_channel_layout_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_channels_delegate(AVFrame* @frame, int @val);
        private static av_frame_set_channels_delegate av_frame_set_channels_fptr = (AVFrame* @frame, int @val) =>
        {
            av_frame_set_channels_fptr = GetFunctionDelegate<av_frame_set_channels_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_channels");
            if (av_frame_set_channels_fptr == null)
            {
                av_frame_set_channels_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_channels is not supported on this platform.");
                };
            }
            av_frame_set_channels_fptr(@frame, @val);
        };
        public static void av_frame_set_channels(AVFrame* @frame, int @val)
        {
            av_frame_set_channels_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_color_range_delegate(AVFrame* @frame, AVColorRange @val);
        private static av_frame_set_color_range_delegate av_frame_set_color_range_fptr = (AVFrame* @frame, AVColorRange @val) =>
        {
            av_frame_set_color_range_fptr = GetFunctionDelegate<av_frame_set_color_range_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_color_range");
            if (av_frame_set_color_range_fptr == null)
            {
                av_frame_set_color_range_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_color_range is not supported on this platform.");
                };
            }
            av_frame_set_color_range_fptr(@frame, @val);
        };
        public static void av_frame_set_color_range(AVFrame* @frame, AVColorRange @val)
        {
            av_frame_set_color_range_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_colorspace_delegate(AVFrame* @frame, AVColorSpace @val);
        private static av_frame_set_colorspace_delegate av_frame_set_colorspace_fptr = (AVFrame* @frame, AVColorSpace @val) =>
        {
            av_frame_set_colorspace_fptr = GetFunctionDelegate<av_frame_set_colorspace_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_colorspace");
            if (av_frame_set_colorspace_fptr == null)
            {
                av_frame_set_colorspace_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_colorspace is not supported on this platform.");
                };
            }
            av_frame_set_colorspace_fptr(@frame, @val);
        };
        public static void av_frame_set_colorspace(AVFrame* @frame, AVColorSpace @val)
        {
            av_frame_set_colorspace_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_decode_error_flags_delegate(AVFrame* @frame, int @val);
        private static av_frame_set_decode_error_flags_delegate av_frame_set_decode_error_flags_fptr = (AVFrame* @frame, int @val) =>
        {
            av_frame_set_decode_error_flags_fptr = GetFunctionDelegate<av_frame_set_decode_error_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_decode_error_flags");
            if (av_frame_set_decode_error_flags_fptr == null)
            {
                av_frame_set_decode_error_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_decode_error_flags is not supported on this platform.");
                };
            }
            av_frame_set_decode_error_flags_fptr(@frame, @val);
        };
        public static void av_frame_set_decode_error_flags(AVFrame* @frame, int @val)
        {
            av_frame_set_decode_error_flags_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_metadata_delegate(AVFrame* @frame, AVDictionary* @val);
        private static av_frame_set_metadata_delegate av_frame_set_metadata_fptr = (AVFrame* @frame, AVDictionary* @val) =>
        {
            av_frame_set_metadata_fptr = GetFunctionDelegate<av_frame_set_metadata_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_metadata");
            if (av_frame_set_metadata_fptr == null)
            {
                av_frame_set_metadata_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_metadata is not supported on this platform.");
                };
            }
            av_frame_set_metadata_fptr(@frame, @val);
        };
        public static void av_frame_set_metadata(AVFrame* @frame, AVDictionary* @val)
        {
            av_frame_set_metadata_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_pkt_duration_delegate(AVFrame* @frame, long @val);
        private static av_frame_set_pkt_duration_delegate av_frame_set_pkt_duration_fptr = (AVFrame* @frame, long @val) =>
        {
            av_frame_set_pkt_duration_fptr = GetFunctionDelegate<av_frame_set_pkt_duration_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_pkt_duration");
            if (av_frame_set_pkt_duration_fptr == null)
            {
                av_frame_set_pkt_duration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_pkt_duration is not supported on this platform.");
                };
            }
            av_frame_set_pkt_duration_fptr(@frame, @val);
        };
        public static void av_frame_set_pkt_duration(AVFrame* @frame, long @val)
        {
            av_frame_set_pkt_duration_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_pkt_pos_delegate(AVFrame* @frame, long @val);
        private static av_frame_set_pkt_pos_delegate av_frame_set_pkt_pos_fptr = (AVFrame* @frame, long @val) =>
        {
            av_frame_set_pkt_pos_fptr = GetFunctionDelegate<av_frame_set_pkt_pos_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_pkt_pos");
            if (av_frame_set_pkt_pos_fptr == null)
            {
                av_frame_set_pkt_pos_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_pkt_pos is not supported on this platform.");
                };
            }
            av_frame_set_pkt_pos_fptr(@frame, @val);
        };
        public static void av_frame_set_pkt_pos(AVFrame* @frame, long @val)
        {
            av_frame_set_pkt_pos_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_pkt_size_delegate(AVFrame* @frame, int @val);
        private static av_frame_set_pkt_size_delegate av_frame_set_pkt_size_fptr = (AVFrame* @frame, int @val) =>
        {
            av_frame_set_pkt_size_fptr = GetFunctionDelegate<av_frame_set_pkt_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_pkt_size");
            if (av_frame_set_pkt_size_fptr == null)
            {
                av_frame_set_pkt_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_pkt_size is not supported on this platform.");
                };
            }
            av_frame_set_pkt_size_fptr(@frame, @val);
        };
        public static void av_frame_set_pkt_size(AVFrame* @frame, int @val)
        {
            av_frame_set_pkt_size_fptr(@frame, @val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_frame_set_qp_table_delegate(AVFrame* @f, AVBufferRef* @buf, int @stride, int @type);
        private static av_frame_set_qp_table_delegate av_frame_set_qp_table_fptr = (AVFrame* @f, AVBufferRef* @buf, int @stride, int @type) =>
        {
            av_frame_set_qp_table_fptr = GetFunctionDelegate<av_frame_set_qp_table_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_qp_table");
            if (av_frame_set_qp_table_fptr == null)
            {
                av_frame_set_qp_table_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_qp_table is not supported on this platform.");
                };
            }
            return av_frame_set_qp_table_fptr(@f, @buf, @stride, @type);
        };
        public static int av_frame_set_qp_table(AVFrame* @f, AVBufferRef* @buf, int @stride, int @type)
        {
            return av_frame_set_qp_table_fptr(@f, @buf, @stride, @type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_set_sample_rate_delegate(AVFrame* @frame, int @val);
        private static av_frame_set_sample_rate_delegate av_frame_set_sample_rate_fptr = (AVFrame* @frame, int @val) =>
        {
            av_frame_set_sample_rate_fptr = GetFunctionDelegate<av_frame_set_sample_rate_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_set_sample_rate");
            if (av_frame_set_sample_rate_fptr == null)
            {
                av_frame_set_sample_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_set_sample_rate is not supported on this platform.");
                };
            }
            av_frame_set_sample_rate_fptr(@frame, @val);
        };
        public static void av_frame_set_sample_rate(AVFrame* @frame, int @val)
        {
            av_frame_set_sample_rate_fptr(@frame, @val);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_frame_side_data_name_delegate(AVFrameSideDataType @type);
        private static av_frame_side_data_name_delegate av_frame_side_data_name_fptr = (AVFrameSideDataType @type) =>
        {
            av_frame_side_data_name_fptr = GetFunctionDelegate<av_frame_side_data_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_side_data_name");
            if (av_frame_side_data_name_fptr == null)
            {
                av_frame_side_data_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_side_data_name is not supported on this platform.");
                };
            }
            return av_frame_side_data_name_fptr(@type);
        };
        /// <summary>Returns a string identifying the side data type</summary>
        public static string av_frame_side_data_name(AVFrameSideDataType @type)
        {
            return av_frame_side_data_name_fptr(@type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_frame_unref_delegate(AVFrame* @frame);
        private static av_frame_unref_delegate av_frame_unref_fptr = (AVFrame* @frame) =>
        {
            av_frame_unref_fptr = GetFunctionDelegate<av_frame_unref_delegate>(GetOrLoadLibrary("avutil", 55), "av_frame_unref");
            if (av_frame_unref_fptr == null)
            {
                av_frame_unref_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_frame_unref is not supported on this platform.");
                };
            }
            av_frame_unref_fptr(@frame);
        };
        /// <summary>Unreference all the buffers referenced by frame and reset the frame fields.</summary>
        public static void av_frame_unref(AVFrame* @frame)
        {
            av_frame_unref_fptr(@frame);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_free_delegate(void* @ptr);
        private static av_free_delegate av_free_fptr = (void* @ptr) =>
        {
            av_free_fptr = GetFunctionDelegate<av_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_free");
            if (av_free_fptr == null)
            {
                av_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_free is not supported on this platform.");
                };
            }
            av_free_fptr(@ptr);
        };
        /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family.</summary>
        /// <param name="ptr">Pointer to the memory block which should be freed.</param>
        public static void av_free(void* @ptr)
        {
            av_free_fptr(@ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_freep_delegate(void* @ptr);
        private static av_freep_delegate av_freep_fptr = (void* @ptr) =>
        {
            av_freep_fptr = GetFunctionDelegate<av_freep_delegate>(GetOrLoadLibrary("avutil", 55), "av_freep");
            if (av_freep_fptr == null)
            {
                av_freep_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_freep is not supported on this platform.");
                };
            }
            av_freep_fptr(@ptr);
        };
        /// <summary>Free a memory block which has been allocated with a function of av_malloc() or av_realloc() family, and set the pointer pointing to it to `NULL`.</summary>
        /// <param name="ptr">Pointer to the pointer to the memory block which should be freed</param>
        public static void av_freep(void* @ptr)
        {
            av_freep_fptr(@ptr);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_gcd_delegate(long @a, long @b);
        private static av_gcd_delegate av_gcd_fptr = (long @a, long @b) =>
        {
            av_gcd_fptr = GetFunctionDelegate<av_gcd_delegate>(GetOrLoadLibrary("avutil", 55), "av_gcd");
            if (av_gcd_fptr == null)
            {
                av_gcd_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_gcd is not supported on this platform.");
                };
            }
            return av_gcd_fptr(@a, @b);
        };
        /// <summary>Compute the greatest common divisor of two integer operands.</summary>
        public static long av_gcd(long @a, long @b)
        {
            return av_gcd_fptr(@a, @b);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVSampleFormat av_get_alt_sample_fmt_delegate(AVSampleFormat @sample_fmt, int @planar);
        private static av_get_alt_sample_fmt_delegate av_get_alt_sample_fmt_fptr = (AVSampleFormat @sample_fmt, int @planar) =>
        {
            av_get_alt_sample_fmt_fptr = GetFunctionDelegate<av_get_alt_sample_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_alt_sample_fmt");
            if (av_get_alt_sample_fmt_fptr == null)
            {
                av_get_alt_sample_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_alt_sample_fmt is not supported on this platform.");
                };
            }
            return av_get_alt_sample_fmt_fptr(@sample_fmt, @planar);
        };
        /// <summary>Return the planar&lt;-&gt;packed alternative form of the given sample format, or AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the requested planar/packed format, the format returned is the same as the input.</summary>
        public static AVSampleFormat av_get_alt_sample_fmt(AVSampleFormat @sample_fmt, int @planar)
        {
            return av_get_alt_sample_fmt_fptr(@sample_fmt, @planar);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);
        private static av_get_bits_per_pixel_delegate av_get_bits_per_pixel_fptr = (AVPixFmtDescriptor* @pixdesc) =>
        {
            av_get_bits_per_pixel_fptr = GetFunctionDelegate<av_get_bits_per_pixel_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_bits_per_pixel");
            if (av_get_bits_per_pixel_fptr == null)
            {
                av_get_bits_per_pixel_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_bits_per_pixel is not supported on this platform.");
                };
            }
            return av_get_bits_per_pixel_fptr(@pixdesc);
        };
        /// <summary>Return the number of bits per pixel used by the pixel format described by pixdesc. Note that this is not the same as the number of bits per sample.</summary>
        public static int av_get_bits_per_pixel(AVPixFmtDescriptor* @pixdesc)
        {
            return av_get_bits_per_pixel_fptr(@pixdesc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_bytes_per_sample_delegate(AVSampleFormat @sample_fmt);
        private static av_get_bytes_per_sample_delegate av_get_bytes_per_sample_fptr = (AVSampleFormat @sample_fmt) =>
        {
            av_get_bytes_per_sample_fptr = GetFunctionDelegate<av_get_bytes_per_sample_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_bytes_per_sample");
            if (av_get_bytes_per_sample_fptr == null)
            {
                av_get_bytes_per_sample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_bytes_per_sample is not supported on this platform.");
                };
            }
            return av_get_bytes_per_sample_fptr(@sample_fmt);
        };
        /// <summary>Return number of bytes per sample.</summary>
        /// <param name="sample_fmt">the sample format</param>
        public static int av_get_bytes_per_sample(AVSampleFormat @sample_fmt)
        {
            return av_get_bytes_per_sample_fptr(@sample_fmt);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_channel_description_delegate(ulong @channel);
        private static av_get_channel_description_delegate av_get_channel_description_fptr = (ulong @channel) =>
        {
            av_get_channel_description_fptr = GetFunctionDelegate<av_get_channel_description_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_channel_description");
            if (av_get_channel_description_fptr == null)
            {
                av_get_channel_description_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_channel_description is not supported on this platform.");
                };
            }
            return av_get_channel_description_fptr(@channel);
        };
        /// <summary>Get the description of a given channel.</summary>
        /// <param name="channel">a channel layout with a single channel</param>
        public static string av_get_channel_description(ulong @channel)
        {
            return av_get_channel_description_fptr(@channel);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate ulong av_get_channel_layout_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_get_channel_layout_delegate av_get_channel_layout_fptr = (string @name) =>
        {
            av_get_channel_layout_fptr = GetFunctionDelegate<av_get_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_channel_layout");
            if (av_get_channel_layout_fptr == null)
            {
                av_get_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_channel_layout is not supported on this platform.");
                };
            }
            return av_get_channel_layout_fptr(@name);
        };
        /// <summary>Return a channel layout id that matches name, or 0 if no match is found.</summary>
        public static ulong av_get_channel_layout([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_get_channel_layout_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_channel_layout_channel_index_delegate(ulong @channel_layout, ulong @channel);
        private static av_get_channel_layout_channel_index_delegate av_get_channel_layout_channel_index_fptr = (ulong @channel_layout, ulong @channel) =>
        {
            av_get_channel_layout_channel_index_fptr = GetFunctionDelegate<av_get_channel_layout_channel_index_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_channel_layout_channel_index");
            if (av_get_channel_layout_channel_index_fptr == null)
            {
                av_get_channel_layout_channel_index_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_channel_layout_channel_index is not supported on this platform.");
                };
            }
            return av_get_channel_layout_channel_index_fptr(@channel_layout, @channel);
        };
        /// <summary>Get the index of a channel in channel_layout.</summary>
        /// <param name="channel">a channel layout describing exactly one channel which must be present in channel_layout.</param>
        public static int av_get_channel_layout_channel_index(ulong @channel_layout, ulong @channel)
        {
            return av_get_channel_layout_channel_index_fptr(@channel_layout, @channel);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_channel_layout_nb_channels_delegate(ulong @channel_layout);
        private static av_get_channel_layout_nb_channels_delegate av_get_channel_layout_nb_channels_fptr = (ulong @channel_layout) =>
        {
            av_get_channel_layout_nb_channels_fptr = GetFunctionDelegate<av_get_channel_layout_nb_channels_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_channel_layout_nb_channels");
            if (av_get_channel_layout_nb_channels_fptr == null)
            {
                av_get_channel_layout_nb_channels_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_channel_layout_nb_channels is not supported on this platform.");
                };
            }
            return av_get_channel_layout_nb_channels_fptr(@channel_layout);
        };
        /// <summary>Return the number of channels in the channel layout.</summary>
        public static int av_get_channel_layout_nb_channels(ulong @channel_layout)
        {
            return av_get_channel_layout_nb_channels_fptr(@channel_layout);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_get_channel_layout_string_delegate(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout);
        private static av_get_channel_layout_string_delegate av_get_channel_layout_string_fptr = (byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout) =>
        {
            av_get_channel_layout_string_fptr = GetFunctionDelegate<av_get_channel_layout_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_channel_layout_string");
            if (av_get_channel_layout_string_fptr == null)
            {
                av_get_channel_layout_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_channel_layout_string is not supported on this platform.");
                };
            }
            av_get_channel_layout_string_fptr(@buf, @buf_size, @nb_channels, @channel_layout);
        };
        /// <summary>Return a description of a channel layout. If nb_channels is &lt;= 0, it is guessed from the channel_layout.</summary>
        /// <param name="buf">put here the string containing the channel layout</param>
        /// <param name="buf_size">size in bytes of the buffer</param>
        public static void av_get_channel_layout_string(byte* @buf, int @buf_size, int @nb_channels, ulong @channel_layout)
        {
            av_get_channel_layout_string_fptr(@buf, @buf_size, @nb_channels, @channel_layout);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_channel_name_delegate(ulong @channel);
        private static av_get_channel_name_delegate av_get_channel_name_fptr = (ulong @channel) =>
        {
            av_get_channel_name_fptr = GetFunctionDelegate<av_get_channel_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_channel_name");
            if (av_get_channel_name_fptr == null)
            {
                av_get_channel_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_channel_name is not supported on this platform.");
                };
            }
            return av_get_channel_name_fptr(@channel);
        };
        /// <summary>Get the name of a given channel.</summary>
        public static string av_get_channel_name(ulong @channel)
        {
            return av_get_channel_name_fptr(@channel);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_colorspace_name_delegate(AVColorSpace @val);
        private static av_get_colorspace_name_delegate av_get_colorspace_name_fptr = (AVColorSpace @val) =>
        {
            av_get_colorspace_name_fptr = GetFunctionDelegate<av_get_colorspace_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_colorspace_name");
            if (av_get_colorspace_name_fptr == null)
            {
                av_get_colorspace_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_colorspace_name is not supported on this platform.");
                };
            }
            return av_get_colorspace_name_fptr(@val);
        };
        /// <summary>Get the name of a colorspace.</summary>
        public static string av_get_colorspace_name(AVColorSpace @val)
        {
            return av_get_colorspace_name_fptr(@val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_cpu_flags_delegate();
        private static av_get_cpu_flags_delegate av_get_cpu_flags_fptr = () =>
        {
            av_get_cpu_flags_fptr = GetFunctionDelegate<av_get_cpu_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_cpu_flags");
            if (av_get_cpu_flags_fptr == null)
            {
                av_get_cpu_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_cpu_flags is not supported on this platform.");
                };
            }
            return av_get_cpu_flags_fptr();
        };
        /// <summary>Return the flags which specify extensions supported by the CPU. The returned value is affected by av_force_cpu_flags() if that was used before. So av_get_cpu_flags() can easily be used in an application to detect the enabled cpu flags.</summary>
        public static int av_get_cpu_flags()
        {
            return av_get_cpu_flags_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_get_default_channel_layout_delegate(int @nb_channels);
        private static av_get_default_channel_layout_delegate av_get_default_channel_layout_fptr = (int @nb_channels) =>
        {
            av_get_default_channel_layout_fptr = GetFunctionDelegate<av_get_default_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_default_channel_layout");
            if (av_get_default_channel_layout_fptr == null)
            {
                av_get_default_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_default_channel_layout is not supported on this platform.");
                };
            }
            return av_get_default_channel_layout_fptr(@nb_channels);
        };
        /// <summary>Return default channel layout for a given number of channels.</summary>
        public static long av_get_default_channel_layout(int @nb_channels)
        {
            return av_get_default_channel_layout_fptr(@nb_channels);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_extended_channel_layout_delegate([MarshalAs(UnmanagedType.LPStr)] string @name, ulong* @channel_layout, int* @nb_channels);
        private static av_get_extended_channel_layout_delegate av_get_extended_channel_layout_fptr = (string @name, ulong* @channel_layout, int* @nb_channels) =>
        {
            av_get_extended_channel_layout_fptr = GetFunctionDelegate<av_get_extended_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_extended_channel_layout");
            if (av_get_extended_channel_layout_fptr == null)
            {
                av_get_extended_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_extended_channel_layout is not supported on this platform.");
                };
            }
            return av_get_extended_channel_layout_fptr(@name, @channel_layout, @nb_channels);
        };
        /// <summary>Return a channel layout and the number of channels based on the specified name.</summary>
        /// <param name="name">channel layout specification string</param>
        /// <param name="channel_layout">parsed channel layout (0 if unknown)</param>
        /// <param name="nb_channels">number of channels</param>
        public static int av_get_extended_channel_layout([MarshalAs(UnmanagedType.LPStr)] string @name, ulong* @channel_layout, int* @nb_channels)
        {
            return av_get_extended_channel_layout_fptr(@name, @channel_layout, @nb_channels);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_media_type_string_delegate(AVMediaType @media_type);
        private static av_get_media_type_string_delegate av_get_media_type_string_fptr = (AVMediaType @media_type) =>
        {
            av_get_media_type_string_fptr = GetFunctionDelegate<av_get_media_type_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_media_type_string");
            if (av_get_media_type_string_fptr == null)
            {
                av_get_media_type_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_media_type_string is not supported on this platform.");
                };
            }
            return av_get_media_type_string_fptr(@media_type);
        };
        /// <summary>Return a string describing the media_type enum, NULL if media_type is unknown.</summary>
        public static string av_get_media_type_string(AVMediaType @media_type)
        {
            return av_get_media_type_string_fptr(@media_type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVSampleFormat av_get_packed_sample_fmt_delegate(AVSampleFormat @sample_fmt);
        private static av_get_packed_sample_fmt_delegate av_get_packed_sample_fmt_fptr = (AVSampleFormat @sample_fmt) =>
        {
            av_get_packed_sample_fmt_fptr = GetFunctionDelegate<av_get_packed_sample_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_packed_sample_fmt");
            if (av_get_packed_sample_fmt_fptr == null)
            {
                av_get_packed_sample_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_packed_sample_fmt is not supported on this platform.");
                };
            }
            return av_get_packed_sample_fmt_fptr(@sample_fmt);
        };
        /// <summary>Get the packed alternative form of the given sample format.</summary>
        public static AVSampleFormat av_get_packed_sample_fmt(AVSampleFormat @sample_fmt)
        {
            return av_get_packed_sample_fmt_fptr(@sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_padded_bits_per_pixel_delegate(AVPixFmtDescriptor* @pixdesc);
        private static av_get_padded_bits_per_pixel_delegate av_get_padded_bits_per_pixel_fptr = (AVPixFmtDescriptor* @pixdesc) =>
        {
            av_get_padded_bits_per_pixel_fptr = GetFunctionDelegate<av_get_padded_bits_per_pixel_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_padded_bits_per_pixel");
            if (av_get_padded_bits_per_pixel_fptr == null)
            {
                av_get_padded_bits_per_pixel_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_padded_bits_per_pixel is not supported on this platform.");
                };
            }
            return av_get_padded_bits_per_pixel_fptr(@pixdesc);
        };
        /// <summary>Return the number of bits per pixel for the pixel format described by pixdesc, including any padding or unused bits.</summary>
        public static int av_get_padded_bits_per_pixel(AVPixFmtDescriptor* @pixdesc)
        {
            return av_get_padded_bits_per_pixel_fptr(@pixdesc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte av_get_picture_type_char_delegate(AVPictureType @pict_type);
        private static av_get_picture_type_char_delegate av_get_picture_type_char_fptr = (AVPictureType @pict_type) =>
        {
            av_get_picture_type_char_fptr = GetFunctionDelegate<av_get_picture_type_char_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_picture_type_char");
            if (av_get_picture_type_char_fptr == null)
            {
                av_get_picture_type_char_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_picture_type_char is not supported on this platform.");
                };
            }
            return av_get_picture_type_char_fptr(@pict_type);
        };
        /// <summary>Return a single letter to describe the given picture type pict_type.</summary>
        /// <param name="pict_type">the picture type</param>
        public static byte av_get_picture_type_char(AVPictureType @pict_type)
        {
            return av_get_picture_type_char_fptr(@pict_type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat av_get_pix_fmt_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_get_pix_fmt_delegate av_get_pix_fmt_fptr = (string @name) =>
        {
            av_get_pix_fmt_fptr = GetFunctionDelegate<av_get_pix_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_pix_fmt");
            if (av_get_pix_fmt_fptr == null)
            {
                av_get_pix_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_pix_fmt is not supported on this platform.");
                };
            }
            return av_get_pix_fmt_fptr(@name);
        };
        /// <summary>Return the pixel format corresponding to name.</summary>
        public static AVPixelFormat av_get_pix_fmt([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_get_pix_fmt_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_pix_fmt_loss_delegate(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha);
        private static av_get_pix_fmt_loss_delegate av_get_pix_fmt_loss_fptr = (AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha) =>
        {
            av_get_pix_fmt_loss_fptr = GetFunctionDelegate<av_get_pix_fmt_loss_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_pix_fmt_loss");
            if (av_get_pix_fmt_loss_fptr == null)
            {
                av_get_pix_fmt_loss_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_pix_fmt_loss is not supported on this platform.");
                };
            }
            return av_get_pix_fmt_loss_fptr(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        };
        /// <summary>Compute what kind of losses will occur when converting from one specific pixel format to another. When converting from one pixel format to another, information loss may occur. For example, when converting from RGB24 to GRAY, the color information will be lost. Similarly, other losses occur when converting from some formats to other formats. These losses can involve loss of chroma, but also loss of resolution, loss of color depth, loss due to the color space conversion, loss of the alpha bits or loss due to color quantization. av_get_fix_fmt_loss() informs you about the various types of losses which will occur when converting from one pixel format to another.</summary>
        /// <param name="dst_pix_fmt">destination pixel format</param>
        /// <param name="src_pix_fmt">source pixel format</param>
        /// <param name="has_alpha">Whether the source pixel format alpha channel is used.</param>
        public static int av_get_pix_fmt_loss(AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha)
        {
            return av_get_pix_fmt_loss_fptr(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_pix_fmt_name_delegate(AVPixelFormat @pix_fmt);
        private static av_get_pix_fmt_name_delegate av_get_pix_fmt_name_fptr = (AVPixelFormat @pix_fmt) =>
        {
            av_get_pix_fmt_name_fptr = GetFunctionDelegate<av_get_pix_fmt_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_pix_fmt_name");
            if (av_get_pix_fmt_name_fptr == null)
            {
                av_get_pix_fmt_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_pix_fmt_name is not supported on this platform.");
                };
            }
            return av_get_pix_fmt_name_fptr(@pix_fmt);
        };
        /// <summary>Return the short name for a pixel format, NULL in case pix_fmt is unknown.</summary>
        public static string av_get_pix_fmt_name(AVPixelFormat @pix_fmt)
        {
            return av_get_pix_fmt_name_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_get_pix_fmt_string_delegate(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt);
        private static av_get_pix_fmt_string_delegate av_get_pix_fmt_string_fptr = (byte* @buf, int @buf_size, AVPixelFormat @pix_fmt) =>
        {
            av_get_pix_fmt_string_fptr = GetFunctionDelegate<av_get_pix_fmt_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_pix_fmt_string");
            if (av_get_pix_fmt_string_fptr == null)
            {
                av_get_pix_fmt_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_pix_fmt_string is not supported on this platform.");
                };
            }
            return av_get_pix_fmt_string_fptr(@buf, @buf_size, @pix_fmt);
        };
        /// <summary>Print in buf the string corresponding to the pixel format with number pix_fmt, or a header if pix_fmt is negative.</summary>
        /// <param name="buf">the buffer where to write the string</param>
        /// <param name="buf_size">the size of buf</param>
        /// <param name="pix_fmt">the number of the pixel format to print the corresponding info string, or a negative value to print the corresponding header.</param>
        public static byte* av_get_pix_fmt_string(byte* @buf, int @buf_size, AVPixelFormat @pix_fmt)
        {
            return av_get_pix_fmt_string_fptr(@buf, @buf_size, @pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVSampleFormat av_get_planar_sample_fmt_delegate(AVSampleFormat @sample_fmt);
        private static av_get_planar_sample_fmt_delegate av_get_planar_sample_fmt_fptr = (AVSampleFormat @sample_fmt) =>
        {
            av_get_planar_sample_fmt_fptr = GetFunctionDelegate<av_get_planar_sample_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_planar_sample_fmt");
            if (av_get_planar_sample_fmt_fptr == null)
            {
                av_get_planar_sample_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_planar_sample_fmt is not supported on this platform.");
                };
            }
            return av_get_planar_sample_fmt_fptr(@sample_fmt);
        };
        /// <summary>Get the planar alternative form of the given sample format.</summary>
        public static AVSampleFormat av_get_planar_sample_fmt(AVSampleFormat @sample_fmt)
        {
            return av_get_planar_sample_fmt_fptr(@sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVSampleFormat av_get_sample_fmt_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_get_sample_fmt_delegate av_get_sample_fmt_fptr = (string @name) =>
        {
            av_get_sample_fmt_fptr = GetFunctionDelegate<av_get_sample_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_sample_fmt");
            if (av_get_sample_fmt_fptr == null)
            {
                av_get_sample_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_sample_fmt is not supported on this platform.");
                };
            }
            return av_get_sample_fmt_fptr(@name);
        };
        /// <summary>Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE on error.</summary>
        public static AVSampleFormat av_get_sample_fmt([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_get_sample_fmt_fptr(@name);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_get_sample_fmt_name_delegate(AVSampleFormat @sample_fmt);
        private static av_get_sample_fmt_name_delegate av_get_sample_fmt_name_fptr = (AVSampleFormat @sample_fmt) =>
        {
            av_get_sample_fmt_name_fptr = GetFunctionDelegate<av_get_sample_fmt_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_sample_fmt_name");
            if (av_get_sample_fmt_name_fptr == null)
            {
                av_get_sample_fmt_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_sample_fmt_name is not supported on this platform.");
                };
            }
            return av_get_sample_fmt_name_fptr(@sample_fmt);
        };
        /// <summary>Return the name of sample_fmt, or NULL if sample_fmt is not recognized.</summary>
        public static string av_get_sample_fmt_name(AVSampleFormat @sample_fmt)
        {
            return av_get_sample_fmt_name_fptr(@sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_get_sample_fmt_string_delegate(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt);
        private static av_get_sample_fmt_string_delegate av_get_sample_fmt_string_fptr = (byte* @buf, int @buf_size, AVSampleFormat @sample_fmt) =>
        {
            av_get_sample_fmt_string_fptr = GetFunctionDelegate<av_get_sample_fmt_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_sample_fmt_string");
            if (av_get_sample_fmt_string_fptr == null)
            {
                av_get_sample_fmt_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_sample_fmt_string is not supported on this platform.");
                };
            }
            return av_get_sample_fmt_string_fptr(@buf, @buf_size, @sample_fmt);
        };
        /// <summary>Generate a string corresponding to the sample format with sample_fmt, or a header if sample_fmt is negative.</summary>
        /// <param name="buf">the buffer where to write the string</param>
        /// <param name="buf_size">the size of buf</param>
        /// <param name="sample_fmt">the number of the sample format to print the corresponding info string, or a negative value to print the corresponding header.</param>
        public static byte* av_get_sample_fmt_string(byte* @buf, int @buf_size, AVSampleFormat @sample_fmt)
        {
            return av_get_sample_fmt_string_fptr(@buf, @buf_size, @sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_get_standard_channel_layout_delegate(uint @index, ulong* @layout, byte** @name);
        private static av_get_standard_channel_layout_delegate av_get_standard_channel_layout_fptr = (uint @index, ulong* @layout, byte** @name) =>
        {
            av_get_standard_channel_layout_fptr = GetFunctionDelegate<av_get_standard_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_standard_channel_layout");
            if (av_get_standard_channel_layout_fptr == null)
            {
                av_get_standard_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_standard_channel_layout is not supported on this platform.");
                };
            }
            return av_get_standard_channel_layout_fptr(@index, @layout, @name);
        };
        /// <summary>Get the value and name of a standard channel layout.</summary>
        /// <param name="index">index in an internal list, starting at 0</param>
        /// <param name="layout">channel layout mask</param>
        /// <param name="name">name of the layout</param>
        public static int av_get_standard_channel_layout(uint @index, ulong* @layout, byte** @name)
        {
            return av_get_standard_channel_layout_fptr(@index, @layout, @name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_get_time_base_q_delegate();
        private static av_get_time_base_q_delegate av_get_time_base_q_fptr = () =>
        {
            av_get_time_base_q_fptr = GetFunctionDelegate<av_get_time_base_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_get_time_base_q");
            if (av_get_time_base_q_fptr == null)
            {
                av_get_time_base_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_get_time_base_q is not supported on this platform.");
                };
            }
            return av_get_time_base_q_fptr();
        };
        /// <summary>Return the fractional representation of the internal time base.</summary>
        public static AVRational av_get_time_base_q()
        {
            return av_get_time_base_q_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_hwdevice_ctx_alloc_delegate(AVHWDeviceType @type);
        private static av_hwdevice_ctx_alloc_delegate av_hwdevice_ctx_alloc_fptr = (AVHWDeviceType @type) =>
        {
            av_hwdevice_ctx_alloc_fptr = GetFunctionDelegate<av_hwdevice_ctx_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_ctx_alloc");
            if (av_hwdevice_ctx_alloc_fptr == null)
            {
                av_hwdevice_ctx_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_ctx_alloc is not supported on this platform.");
                };
            }
            return av_hwdevice_ctx_alloc_fptr(@type);
        };
        /// <summary>Allocate an AVHWDeviceContext for a given hardware type.</summary>
        /// <param name="type">the type of the hardware device to allocate.</param>
        public static AVBufferRef* av_hwdevice_ctx_alloc(AVHWDeviceType @type)
        {
            return av_hwdevice_ctx_alloc_fptr(@type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwdevice_ctx_create_delegate(AVBufferRef** @device_ctx, AVHWDeviceType @type, [MarshalAs(UnmanagedType.LPStr)] string @device, AVDictionary* @opts, int @flags);
        private static av_hwdevice_ctx_create_delegate av_hwdevice_ctx_create_fptr = (AVBufferRef** @device_ctx, AVHWDeviceType @type, string @device, AVDictionary* @opts, int @flags) =>
        {
            av_hwdevice_ctx_create_fptr = GetFunctionDelegate<av_hwdevice_ctx_create_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_ctx_create");
            if (av_hwdevice_ctx_create_fptr == null)
            {
                av_hwdevice_ctx_create_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_ctx_create is not supported on this platform.");
                };
            }
            return av_hwdevice_ctx_create_fptr(@device_ctx, @type, @device, @opts, @flags);
        };
        /// <summary>Open a device of the specified type and create an AVHWDeviceContext for it.</summary>
        /// <param name="device_ctx">On success, a reference to the newly-created device context will be written here. The reference is owned by the caller and must be released with av_buffer_unref() when no longer needed. On failure, NULL will be written to this pointer.</param>
        /// <param name="type">The type of the device to create.</param>
        /// <param name="device">A type-specific string identifying the device to open.</param>
        /// <param name="opts">A dictionary of additional (type-specific) options to use in opening the device. The dictionary remains owned by the caller.</param>
        /// <param name="flags">currently unused</param>
        public static int av_hwdevice_ctx_create(AVBufferRef** @device_ctx, AVHWDeviceType @type, [MarshalAs(UnmanagedType.LPStr)] string @device, AVDictionary* @opts, int @flags)
        {
            return av_hwdevice_ctx_create_fptr(@device_ctx, @type, @device, @opts, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwdevice_ctx_create_derived_delegate(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags);
        private static av_hwdevice_ctx_create_derived_delegate av_hwdevice_ctx_create_derived_fptr = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags) =>
        {
            av_hwdevice_ctx_create_derived_fptr = GetFunctionDelegate<av_hwdevice_ctx_create_derived_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_ctx_create_derived");
            if (av_hwdevice_ctx_create_derived_fptr == null)
            {
                av_hwdevice_ctx_create_derived_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_ctx_create_derived is not supported on this platform.");
                };
            }
            return av_hwdevice_ctx_create_derived_fptr(@dst_ctx, @type, @src_ctx, @flags);
        };
        /// <summary>Create a new device of the specified type from an existing device.</summary>
        /// <param name="dst_ctx">On success, a reference to the newly-created AVHWDeviceContext.</param>
        /// <param name="type">The type of the new device to create.</param>
        /// <param name="src_ctx">A reference to an existing AVHWDeviceContext which will be used to create the new device.</param>
        /// <param name="flags">Currently unused; should be set to zero.</param>
        public static int av_hwdevice_ctx_create_derived(AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags)
        {
            return av_hwdevice_ctx_create_derived_fptr(@dst_ctx, @type, @src_ctx, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwdevice_ctx_init_delegate(AVBufferRef* @ref);
        private static av_hwdevice_ctx_init_delegate av_hwdevice_ctx_init_fptr = (AVBufferRef* @ref) =>
        {
            av_hwdevice_ctx_init_fptr = GetFunctionDelegate<av_hwdevice_ctx_init_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_ctx_init");
            if (av_hwdevice_ctx_init_fptr == null)
            {
                av_hwdevice_ctx_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_ctx_init is not supported on this platform.");
                };
            }
            return av_hwdevice_ctx_init_fptr(@ref);
        };
        /// <summary>Finalize the device context before use. This function must be called after the context is filled with all the required information and before it is used in any way.</summary>
        /// <param name="ref">a reference to the AVHWDeviceContext</param>
        public static int av_hwdevice_ctx_init(AVBufferRef* @ref)
        {
            return av_hwdevice_ctx_init_fptr(@ref);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVHWDeviceType av_hwdevice_find_type_by_name_delegate([MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_hwdevice_find_type_by_name_delegate av_hwdevice_find_type_by_name_fptr = (string @name) =>
        {
            av_hwdevice_find_type_by_name_fptr = GetFunctionDelegate<av_hwdevice_find_type_by_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_find_type_by_name");
            if (av_hwdevice_find_type_by_name_fptr == null)
            {
                av_hwdevice_find_type_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_find_type_by_name is not supported on this platform.");
                };
            }
            return av_hwdevice_find_type_by_name_fptr(@name);
        };
        /// <summary>Look up an AVHWDeviceType by name.</summary>
        /// <param name="name">String name of the device type (case-insensitive).</param>
        public static AVHWDeviceType av_hwdevice_find_type_by_name([MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_hwdevice_find_type_by_name_fptr(@name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints_delegate(AVBufferRef* @ref, void* @hwconfig);
        private static av_hwdevice_get_hwframe_constraints_delegate av_hwdevice_get_hwframe_constraints_fptr = (AVBufferRef* @ref, void* @hwconfig) =>
        {
            av_hwdevice_get_hwframe_constraints_fptr = GetFunctionDelegate<av_hwdevice_get_hwframe_constraints_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_get_hwframe_constraints");
            if (av_hwdevice_get_hwframe_constraints_fptr == null)
            {
                av_hwdevice_get_hwframe_constraints_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_get_hwframe_constraints is not supported on this platform.");
                };
            }
            return av_hwdevice_get_hwframe_constraints_fptr(@ref, @hwconfig);
        };
        /// <summary>Get the constraints on HW frames given a device and the HW-specific configuration to be used with that device. If no HW-specific configuration is provided, returns the maximum possible capabilities of the device.</summary>
        /// <param name="ref">a reference to the associated AVHWDeviceContext.</param>
        /// <param name="hwconfig">a filled HW-specific configuration structure, or NULL to return the maximum possible capabilities of the device.</param>
        public static AVHWFramesConstraints* av_hwdevice_get_hwframe_constraints(AVBufferRef* @ref, void* @hwconfig)
        {
            return av_hwdevice_get_hwframe_constraints_fptr(@ref, @hwconfig);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_hwdevice_get_type_name_delegate(AVHWDeviceType @type);
        private static av_hwdevice_get_type_name_delegate av_hwdevice_get_type_name_fptr = (AVHWDeviceType @type) =>
        {
            av_hwdevice_get_type_name_fptr = GetFunctionDelegate<av_hwdevice_get_type_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_get_type_name");
            if (av_hwdevice_get_type_name_fptr == null)
            {
                av_hwdevice_get_type_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_get_type_name is not supported on this platform.");
                };
            }
            return av_hwdevice_get_type_name_fptr(@type);
        };
        /// <summary>Get the string name of an AVHWDeviceType.</summary>
        /// <param name="type">Type from enum AVHWDeviceType.</param>
        public static string av_hwdevice_get_type_name(AVHWDeviceType @type)
        {
            return av_hwdevice_get_type_name_fptr(@type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_hwdevice_hwconfig_alloc_delegate(AVBufferRef* @device_ctx);
        private static av_hwdevice_hwconfig_alloc_delegate av_hwdevice_hwconfig_alloc_fptr = (AVBufferRef* @device_ctx) =>
        {
            av_hwdevice_hwconfig_alloc_fptr = GetFunctionDelegate<av_hwdevice_hwconfig_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_hwconfig_alloc");
            if (av_hwdevice_hwconfig_alloc_fptr == null)
            {
                av_hwdevice_hwconfig_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_hwconfig_alloc is not supported on this platform.");
                };
            }
            return av_hwdevice_hwconfig_alloc_fptr(@device_ctx);
        };
        /// <summary>Allocate a HW-specific configuration structure for a given HW device. After use, the user must free all members as required by the specific hardware structure being used, then free the structure itself with av_free().</summary>
        /// <param name="device_ctx">a reference to the associated AVHWDeviceContext.</param>
        public static void* av_hwdevice_hwconfig_alloc(AVBufferRef* @device_ctx)
        {
            return av_hwdevice_hwconfig_alloc_fptr(@device_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVHWDeviceType av_hwdevice_iterate_types_delegate(AVHWDeviceType @prev);
        private static av_hwdevice_iterate_types_delegate av_hwdevice_iterate_types_fptr = (AVHWDeviceType @prev) =>
        {
            av_hwdevice_iterate_types_fptr = GetFunctionDelegate<av_hwdevice_iterate_types_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwdevice_iterate_types");
            if (av_hwdevice_iterate_types_fptr == null)
            {
                av_hwdevice_iterate_types_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwdevice_iterate_types is not supported on this platform.");
                };
            }
            return av_hwdevice_iterate_types_fptr(@prev);
        };
        /// <summary>Iterate over supported device types.</summary>
        public static AVHWDeviceType av_hwdevice_iterate_types(AVHWDeviceType @prev)
        {
            return av_hwdevice_iterate_types_fptr(@prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_hwframe_constraints_free_delegate(AVHWFramesConstraints** @constraints);
        private static av_hwframe_constraints_free_delegate av_hwframe_constraints_free_fptr = (AVHWFramesConstraints** @constraints) =>
        {
            av_hwframe_constraints_free_fptr = GetFunctionDelegate<av_hwframe_constraints_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_constraints_free");
            if (av_hwframe_constraints_free_fptr == null)
            {
                av_hwframe_constraints_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_constraints_free is not supported on this platform.");
                };
            }
            av_hwframe_constraints_free_fptr(@constraints);
        };
        /// <summary>Free an AVHWFrameConstraints structure.</summary>
        /// <param name="constraints">The (filled or unfilled) AVHWFrameConstraints structure.</param>
        public static void av_hwframe_constraints_free(AVHWFramesConstraints** @constraints)
        {
            av_hwframe_constraints_free_fptr(@constraints);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVBufferRef* av_hwframe_ctx_alloc_delegate(AVBufferRef* @device_ctx);
        private static av_hwframe_ctx_alloc_delegate av_hwframe_ctx_alloc_fptr = (AVBufferRef* @device_ctx) =>
        {
            av_hwframe_ctx_alloc_fptr = GetFunctionDelegate<av_hwframe_ctx_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_ctx_alloc");
            if (av_hwframe_ctx_alloc_fptr == null)
            {
                av_hwframe_ctx_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_ctx_alloc is not supported on this platform.");
                };
            }
            return av_hwframe_ctx_alloc_fptr(@device_ctx);
        };
        /// <summary>Allocate an AVHWFramesContext tied to a given device context.</summary>
        /// <param name="device_ctx">a reference to a AVHWDeviceContext. This function will make a new reference for internal use, the one passed to the function remains owned by the caller.</param>
        public static AVBufferRef* av_hwframe_ctx_alloc(AVBufferRef* @device_ctx)
        {
            return av_hwframe_ctx_alloc_fptr(@device_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwframe_ctx_create_derived_delegate(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags);
        private static av_hwframe_ctx_create_derived_delegate av_hwframe_ctx_create_derived_fptr = (AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags) =>
        {
            av_hwframe_ctx_create_derived_fptr = GetFunctionDelegate<av_hwframe_ctx_create_derived_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_ctx_create_derived");
            if (av_hwframe_ctx_create_derived_fptr == null)
            {
                av_hwframe_ctx_create_derived_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_ctx_create_derived is not supported on this platform.");
                };
            }
            return av_hwframe_ctx_create_derived_fptr(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
        };
        /// <summary>Create and initialise an AVHWFramesContext as a mapping of another existing AVHWFramesContext on a different device.</summary>
        /// <param name="derived_frame_ctx">On success, a reference to the newly created AVHWFramesContext.</param>
        /// <param name="derived_device_ctx">A reference to the device to create the new AVHWFramesContext on.</param>
        /// <param name="source_frame_ctx">A reference to an existing AVHWFramesContext which will be mapped to the derived context.</param>
        /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags, defining the mapping parameters to apply to frames which are allocated in the derived device.</param>
        public static int av_hwframe_ctx_create_derived(AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags)
        {
            return av_hwframe_ctx_create_derived_fptr(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwframe_ctx_init_delegate(AVBufferRef* @ref);
        private static av_hwframe_ctx_init_delegate av_hwframe_ctx_init_fptr = (AVBufferRef* @ref) =>
        {
            av_hwframe_ctx_init_fptr = GetFunctionDelegate<av_hwframe_ctx_init_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_ctx_init");
            if (av_hwframe_ctx_init_fptr == null)
            {
                av_hwframe_ctx_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_ctx_init is not supported on this platform.");
                };
            }
            return av_hwframe_ctx_init_fptr(@ref);
        };
        /// <summary>Finalize the context before use. This function must be called after the context is filled with all the required information and before it is attached to any frames.</summary>
        /// <param name="ref">a reference to the AVHWFramesContext</param>
        public static int av_hwframe_ctx_init(AVBufferRef* @ref)
        {
            return av_hwframe_ctx_init_fptr(@ref);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwframe_get_buffer_delegate(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags);
        private static av_hwframe_get_buffer_delegate av_hwframe_get_buffer_fptr = (AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags) =>
        {
            av_hwframe_get_buffer_fptr = GetFunctionDelegate<av_hwframe_get_buffer_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_get_buffer");
            if (av_hwframe_get_buffer_fptr == null)
            {
                av_hwframe_get_buffer_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_get_buffer is not supported on this platform.");
                };
            }
            return av_hwframe_get_buffer_fptr(@hwframe_ctx, @frame, @flags);
        };
        /// <summary>Allocate a new frame attached to the given AVHWFramesContext.</summary>
        /// <param name="hwframe_ctx">a reference to an AVHWFramesContext</param>
        /// <param name="frame">an empty (freshly allocated or unreffed) frame to be filled with newly allocated buffers.</param>
        /// <param name="flags">currently unused, should be set to zero</param>
        public static int av_hwframe_get_buffer(AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags)
        {
            return av_hwframe_get_buffer_fptr(@hwframe_ctx, @frame, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwframe_map_delegate(AVFrame* @dst, AVFrame* @src, int @flags);
        private static av_hwframe_map_delegate av_hwframe_map_fptr = (AVFrame* @dst, AVFrame* @src, int @flags) =>
        {
            av_hwframe_map_fptr = GetFunctionDelegate<av_hwframe_map_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_map");
            if (av_hwframe_map_fptr == null)
            {
                av_hwframe_map_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_map is not supported on this platform.");
                };
            }
            return av_hwframe_map_fptr(@dst, @src, @flags);
        };
        /// <summary>Map a hardware frame.</summary>
        /// <param name="dst">Destination frame, to contain the mapping.</param>
        /// <param name="src">Source frame, to be mapped.</param>
        /// <param name="flags">Some combination of AV_HWFRAME_MAP_* flags.</param>
        public static int av_hwframe_map(AVFrame* @dst, AVFrame* @src, int @flags)
        {
            return av_hwframe_map_fptr(@dst, @src, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwframe_transfer_data_delegate(AVFrame* @dst, AVFrame* @src, int @flags);
        private static av_hwframe_transfer_data_delegate av_hwframe_transfer_data_fptr = (AVFrame* @dst, AVFrame* @src, int @flags) =>
        {
            av_hwframe_transfer_data_fptr = GetFunctionDelegate<av_hwframe_transfer_data_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_transfer_data");
            if (av_hwframe_transfer_data_fptr == null)
            {
                av_hwframe_transfer_data_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_transfer_data is not supported on this platform.");
                };
            }
            return av_hwframe_transfer_data_fptr(@dst, @src, @flags);
        };
        /// <summary>Copy data to or from a hw surface. At least one of dst/src must have an AVHWFramesContext attached.</summary>
        /// <param name="dst">the destination frame. dst is not touched on failure.</param>
        /// <param name="src">the source frame.</param>
        /// <param name="flags">currently unused, should be set to zero</param>
        public static int av_hwframe_transfer_data(AVFrame* @dst, AVFrame* @src, int @flags)
        {
            return av_hwframe_transfer_data_fptr(@dst, @src, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_hwframe_transfer_get_formats_delegate(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags);
        private static av_hwframe_transfer_get_formats_delegate av_hwframe_transfer_get_formats_fptr = (AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags) =>
        {
            av_hwframe_transfer_get_formats_fptr = GetFunctionDelegate<av_hwframe_transfer_get_formats_delegate>(GetOrLoadLibrary("avutil", 55), "av_hwframe_transfer_get_formats");
            if (av_hwframe_transfer_get_formats_fptr == null)
            {
                av_hwframe_transfer_get_formats_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_hwframe_transfer_get_formats is not supported on this platform.");
                };
            }
            return av_hwframe_transfer_get_formats_fptr(@hwframe_ctx, @dir, @formats, @flags);
        };
        /// <summary>Get a list of possible source or target formats usable in av_hwframe_transfer_data().</summary>
        /// <param name="hwframe_ctx">the frame context to obtain the information for</param>
        /// <param name="dir">the direction of the transfer</param>
        /// <param name="formats">the pointer to the output format list will be written here. The list is terminated with AV_PIX_FMT_NONE and must be freed by the caller when no longer needed using av_free(). If this function returns successfully, the format list will have at least one item (not counting the terminator). On failure, the contents of this pointer are unspecified.</param>
        /// <param name="flags">currently unused, should be set to zero</param>
        public static int av_hwframe_transfer_get_formats(AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags)
        {
            return av_hwframe_transfer_get_formats_fptr(@hwframe_ctx, @dir, @formats, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_alloc_delegate(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align);
        private static av_image_alloc_delegate av_image_alloc_fptr = (ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align) =>
        {
            av_image_alloc_fptr = GetFunctionDelegate<av_image_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_alloc");
            if (av_image_alloc_fptr == null)
            {
                av_image_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_alloc is not supported on this platform.");
                };
            }
            return av_image_alloc_fptr(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
        };
        /// <summary>Allocate an image with size w and h and pixel format pix_fmt, and fill pointers and linesizes accordingly. The allocated image buffer has to be freed by using av_freep(&amp;pointers[0]).</summary>
        /// <param name="align">the value to use for buffer size alignment</param>
        public static int av_image_alloc(ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align)
        {
            return av_image_alloc_fptr(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_check_sar_delegate(uint @w, uint @h, AVRational @sar);
        private static av_image_check_sar_delegate av_image_check_sar_fptr = (uint @w, uint @h, AVRational @sar) =>
        {
            av_image_check_sar_fptr = GetFunctionDelegate<av_image_check_sar_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_check_sar");
            if (av_image_check_sar_fptr == null)
            {
                av_image_check_sar_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_check_sar is not supported on this platform.");
                };
            }
            return av_image_check_sar_fptr(@w, @h, @sar);
        };
        /// <summary>Check if the given sample aspect ratio of an image is valid.</summary>
        /// <param name="w">width of the image</param>
        /// <param name="h">height of the image</param>
        /// <param name="sar">sample aspect ratio of the image</param>
        public static int av_image_check_sar(uint @w, uint @h, AVRational @sar)
        {
            return av_image_check_sar_fptr(@w, @h, @sar);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_check_size_delegate(uint @w, uint @h, int @log_offset, void* @log_ctx);
        private static av_image_check_size_delegate av_image_check_size_fptr = (uint @w, uint @h, int @log_offset, void* @log_ctx) =>
        {
            av_image_check_size_fptr = GetFunctionDelegate<av_image_check_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_check_size");
            if (av_image_check_size_fptr == null)
            {
                av_image_check_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_check_size is not supported on this platform.");
                };
            }
            return av_image_check_size_fptr(@w, @h, @log_offset, @log_ctx);
        };
        /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of the image can be addressed with a signed int.</summary>
        /// <param name="w">the width of the picture</param>
        /// <param name="h">the height of the picture</param>
        /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
        /// <param name="log_ctx">the parent logging context, it may be NULL</param>
        public static int av_image_check_size(uint @w, uint @h, int @log_offset, void* @log_ctx)
        {
            return av_image_check_size_fptr(@w, @h, @log_offset, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_check_size2_delegate(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx);
        private static av_image_check_size2_delegate av_image_check_size2_fptr = (uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx) =>
        {
            av_image_check_size2_fptr = GetFunctionDelegate<av_image_check_size2_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_check_size2");
            if (av_image_check_size2_fptr == null)
            {
                av_image_check_size2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_check_size2 is not supported on this platform.");
                };
            }
            return av_image_check_size2_fptr(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
        };
        /// <summary>Check if the given dimension of an image is valid, meaning that all bytes of a plane of an image with the specified pix_fmt can be addressed with a signed int.</summary>
        /// <param name="w">the width of the picture</param>
        /// <param name="h">the height of the picture</param>
        /// <param name="max_pixels">the maximum number of pixels the user wants to accept</param>
        /// <param name="pix_fmt">the pixel format, can be AV_PIX_FMT_NONE if unknown.</param>
        /// <param name="log_offset">the offset to sum to the log level for logging with log_ctx</param>
        /// <param name="log_ctx">the parent logging context, it may be NULL</param>
        public static int av_image_check_size2(uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx)
        {
            return av_image_check_size2_fptr(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_image_copy_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
        private static av_image_copy_delegate av_image_copy_fptr = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            av_image_copy_fptr = GetFunctionDelegate<av_image_copy_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_copy");
            if (av_image_copy_fptr == null)
            {
                av_image_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_copy is not supported on this platform.");
                };
            }
            av_image_copy_fptr(ref @dst_data, ref @dst_linesizes, ref @src_data, @src_linesizes, @pix_fmt, @width, @height);
        };
        /// <summary>Copy image in src_data to dst_data.</summary>
        /// <param name="dst_linesizes">linesizes for the image in dst_data</param>
        /// <param name="src_linesizes">linesizes for the image in src_data</param>
        public static void av_image_copy(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            av_image_copy_fptr(ref @dst_data, ref @dst_linesizes, ref @src_data, @src_linesizes, @pix_fmt, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_image_copy_plane_delegate(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height);
        private static av_image_copy_plane_delegate av_image_copy_plane_fptr = (byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height) =>
        {
            av_image_copy_plane_fptr = GetFunctionDelegate<av_image_copy_plane_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_copy_plane");
            if (av_image_copy_plane_fptr == null)
            {
                av_image_copy_plane_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_copy_plane is not supported on this platform.");
                };
            }
            av_image_copy_plane_fptr(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        };
        /// <summary>Copy image plane from src to dst. That is, copy &quot;height&quot; number of lines of &quot;bytewidth&quot; bytes each. The first byte of each successive line is separated by *_linesize bytes.</summary>
        /// <param name="dst_linesize">linesize for the image plane in dst</param>
        /// <param name="src_linesize">linesize for the image plane in src</param>
        public static void av_image_copy_plane(byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height)
        {
            av_image_copy_plane_fptr(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_copy_to_buffer_delegate(byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        private static av_image_copy_to_buffer_delegate av_image_copy_to_buffer_fptr = (byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
        {
            av_image_copy_to_buffer_fptr = GetFunctionDelegate<av_image_copy_to_buffer_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_copy_to_buffer");
            if (av_image_copy_to_buffer_fptr == null)
            {
                av_image_copy_to_buffer_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_copy_to_buffer is not supported on this platform.");
                };
            }
            return av_image_copy_to_buffer_fptr(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
        };
        /// <summary>Copy image data from an image into a buffer.</summary>
        /// <param name="dst">a buffer into which picture data will be copied</param>
        /// <param name="dst_size">the size in bytes of dst</param>
        /// <param name="src_data">pointers containing the source image data</param>
        /// <param name="src_linesize">linesizes for the image in src_data</param>
        /// <param name="pix_fmt">the pixel format of the source image</param>
        /// <param name="width">the width of the source image in pixels</param>
        /// <param name="height">the height of the source image in pixels</param>
        /// <param name="align">the assumed linesize alignment for dst</param>
        public static int av_image_copy_to_buffer(byte* @dst, int @dst_size, byte_ptrArray4 @src_data, int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align)
        {
            return av_image_copy_to_buffer_fptr(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_image_copy_uc_from_delegate(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height);
        private static av_image_copy_uc_from_delegate av_image_copy_uc_from_fptr = (ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            av_image_copy_uc_from_fptr = GetFunctionDelegate<av_image_copy_uc_from_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_copy_uc_from");
            if (av_image_copy_uc_from_fptr == null)
            {
                av_image_copy_uc_from_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_copy_uc_from is not supported on this platform.");
                };
            }
            av_image_copy_uc_from_fptr(ref @dst_data, @dst_linesizes, ref @src_data, @src_linesizes, @pix_fmt, @width, @height);
        };
        /// <summary>Copy image data located in uncacheable (e.g. GPU mapped) memory. Where available, this function will use special functionality for reading from such memory, which may result in greatly improved performance compared to plain av_image_copy().</summary>
        public static void av_image_copy_uc_from(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesizes, ref byte_ptrArray4 @src_data, long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height)
        {
            av_image_copy_uc_from_fptr(ref @dst_data, @dst_linesizes, ref @src_data, @src_linesizes, @pix_fmt, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_fill_arrays_delegate(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        private static av_image_fill_arrays_delegate av_image_fill_arrays_fptr = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
        {
            av_image_fill_arrays_fptr = GetFunctionDelegate<av_image_fill_arrays_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_fill_arrays");
            if (av_image_fill_arrays_fptr == null)
            {
                av_image_fill_arrays_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_fill_arrays is not supported on this platform.");
                };
            }
            return av_image_fill_arrays_fptr(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
        };
        /// <summary>Setup the data pointers and linesizes based on the specified image parameters and the provided array.</summary>
        /// <param name="dst_data">data pointers to be filled in</param>
        /// <param name="dst_linesize">linesizes for the image in dst_data to be filled in</param>
        /// <param name="src">buffer which will contain or contains the actual image data, can be NULL</param>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        /// <param name="align">the value used in src for linesize alignment</param>
        public static int av_image_fill_arrays(ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align)
        {
            return av_image_fill_arrays_fptr(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_fill_black_delegate(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height);
        private static av_image_fill_black_delegate av_image_fill_black_fptr = (ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height) =>
        {
            av_image_fill_black_fptr = GetFunctionDelegate<av_image_fill_black_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_fill_black");
            if (av_image_fill_black_fptr == null)
            {
                av_image_fill_black_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_fill_black is not supported on this platform.");
                };
            }
            return av_image_fill_black_fptr(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
        };
        /// <summary>Overwrite the image data with black. This is suitable for filling a sub-rectangle of an image, meaning the padding between the right most pixel and the left most pixel on the next line will not be overwritten. For some formats, the image size might be rounded up due to inherent alignment.</summary>
        /// <param name="dst_data">data pointers to destination image</param>
        /// <param name="dst_linesize">linesizes for the destination image</param>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="range">the color range of the image (important for colorspaces such as YUV)</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        public static int av_image_fill_black(ref byte_ptrArray4 @dst_data, long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height)
        {
            return av_image_fill_black_fptr(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_fill_linesizes_delegate(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width);
        private static av_image_fill_linesizes_delegate av_image_fill_linesizes_fptr = (ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width) =>
        {
            av_image_fill_linesizes_fptr = GetFunctionDelegate<av_image_fill_linesizes_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_fill_linesizes");
            if (av_image_fill_linesizes_fptr == null)
            {
                av_image_fill_linesizes_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_fill_linesizes is not supported on this platform.");
                };
            }
            return av_image_fill_linesizes_fptr(ref @linesizes, @pix_fmt, @width);
        };
        /// <summary>Fill plane linesizes for an image with pixel format pix_fmt and width width.</summary>
        /// <param name="linesizes">array to be filled with the linesize for each plane</param>
        public static int av_image_fill_linesizes(ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width)
        {
            return av_image_fill_linesizes_fptr(ref @linesizes, @pix_fmt, @width);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_image_fill_max_pixsteps_delegate(ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc);
        private static av_image_fill_max_pixsteps_delegate av_image_fill_max_pixsteps_fptr = (ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc) =>
        {
            av_image_fill_max_pixsteps_fptr = GetFunctionDelegate<av_image_fill_max_pixsteps_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_fill_max_pixsteps");
            if (av_image_fill_max_pixsteps_fptr == null)
            {
                av_image_fill_max_pixsteps_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_fill_max_pixsteps is not supported on this platform.");
                };
            }
            av_image_fill_max_pixsteps_fptr(ref @max_pixsteps, ref @max_pixstep_comps, @pixdesc);
        };
        /// <summary>Compute the max pixel step for each plane of an image with a format described by pixdesc.</summary>
        /// <param name="max_pixsteps">an array which is filled with the max pixel step for each plane. Since a plane may contain different pixel components, the computed max_pixsteps[plane] is relative to the component in the plane with the max pixel step.</param>
        /// <param name="max_pixstep_comps">an array which is filled with the component for each plane which has the max pixel step. May be NULL.</param>
        public static void av_image_fill_max_pixsteps(ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc)
        {
            av_image_fill_max_pixsteps_fptr(ref @max_pixsteps, ref @max_pixstep_comps, @pixdesc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_fill_pointers_delegate(ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes);
        private static av_image_fill_pointers_delegate av_image_fill_pointers_fptr = (ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes) =>
        {
            av_image_fill_pointers_fptr = GetFunctionDelegate<av_image_fill_pointers_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_fill_pointers");
            if (av_image_fill_pointers_fptr == null)
            {
                av_image_fill_pointers_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_fill_pointers is not supported on this platform.");
                };
            }
            return av_image_fill_pointers_fptr(ref @data, @pix_fmt, @height, @ptr, @linesizes);
        };
        /// <summary>Fill plane data pointers for an image with pixel format pix_fmt and height height.</summary>
        /// <param name="data">pointers array to be filled with the pointer for each image plane</param>
        /// <param name="ptr">the pointer to a buffer which will contain the image</param>
        /// <param name="linesizes">the array containing the linesize for each plane, should be filled by av_image_fill_linesizes()</param>
        public static int av_image_fill_pointers(ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, int_array4 @linesizes)
        {
            return av_image_fill_pointers_fptr(ref @data, @pix_fmt, @height, @ptr, @linesizes);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_get_buffer_size_delegate(AVPixelFormat @pix_fmt, int @width, int @height, int @align);
        private static av_image_get_buffer_size_delegate av_image_get_buffer_size_fptr = (AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
        {
            av_image_get_buffer_size_fptr = GetFunctionDelegate<av_image_get_buffer_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_get_buffer_size");
            if (av_image_get_buffer_size_fptr == null)
            {
                av_image_get_buffer_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_get_buffer_size is not supported on this platform.");
                };
            }
            return av_image_get_buffer_size_fptr(@pix_fmt, @width, @height, @align);
        };
        /// <summary>Return the size in bytes of the amount of data required to store an image with the given parameters.</summary>
        /// <param name="pix_fmt">the pixel format of the image</param>
        /// <param name="width">the width of the image in pixels</param>
        /// <param name="height">the height of the image in pixels</param>
        /// <param name="align">the assumed linesize alignment</param>
        public static int av_image_get_buffer_size(AVPixelFormat @pix_fmt, int @width, int @height, int @align)
        {
            return av_image_get_buffer_size_fptr(@pix_fmt, @width, @height, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_image_get_linesize_delegate(AVPixelFormat @pix_fmt, int @width, int @plane);
        private static av_image_get_linesize_delegate av_image_get_linesize_fptr = (AVPixelFormat @pix_fmt, int @width, int @plane) =>
        {
            av_image_get_linesize_fptr = GetFunctionDelegate<av_image_get_linesize_delegate>(GetOrLoadLibrary("avutil", 55), "av_image_get_linesize");
            if (av_image_get_linesize_fptr == null)
            {
                av_image_get_linesize_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_image_get_linesize is not supported on this platform.");
                };
            }
            return av_image_get_linesize_fptr(@pix_fmt, @width, @plane);
        };
        /// <summary>Compute the size of an image line with format pix_fmt and width width for the plane plane.</summary>
        public static int av_image_get_linesize(AVPixelFormat @pix_fmt, int @width, int @plane)
        {
            return av_image_get_linesize_fptr(@pix_fmt, @width, @plane);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_int_list_length_for_size_delegate(uint @elsize, void* @list, ulong @term);
        private static av_int_list_length_for_size_delegate av_int_list_length_for_size_fptr = (uint @elsize, void* @list, ulong @term) =>
        {
            av_int_list_length_for_size_fptr = GetFunctionDelegate<av_int_list_length_for_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_int_list_length_for_size");
            if (av_int_list_length_for_size_fptr == null)
            {
                av_int_list_length_for_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_int_list_length_for_size is not supported on this platform.");
                };
            }
            return av_int_list_length_for_size_fptr(@elsize, @list, @term);
        };
        /// <summary>Compute the length of an integer list.</summary>
        /// <param name="elsize">size in bytes of each list element (only 1, 2, 4 or 8)</param>
        /// <param name="list">pointer to the list</param>
        /// <param name="term">list terminator (usually 0 or -1)</param>
        public static uint av_int_list_length_for_size(uint @elsize, void* @list, ulong @term)
        {
            return av_int_list_length_for_size_fptr(@elsize, @list, @term);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_delegate(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt);
        private static av_log_delegate av_log_fptr = (void* @avcl, int @level, string @fmt) =>
        {
            av_log_fptr = GetFunctionDelegate<av_log_delegate>(GetOrLoadLibrary("avutil", 55), "av_log");
            if (av_log_fptr == null)
            {
                av_log_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log is not supported on this platform.");
                };
            }
            av_log_fptr(@avcl, @level, @fmt);
        };
        /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct or NULL if general log.</param>
        /// <param name="level">The importance level of the message expressed using a</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        public static void av_log(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt)
        {
            av_log_fptr(@avcl, @level, @fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_default_callback_delegate(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl);
        private static av_log_default_callback_delegate av_log_default_callback_fptr = (void* @avcl, int @level, string @fmt, byte* @vl) =>
        {
            av_log_default_callback_fptr = GetFunctionDelegate<av_log_default_callback_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_default_callback");
            if (av_log_default_callback_fptr == null)
            {
                av_log_default_callback_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_default_callback is not supported on this platform.");
                };
            }
            av_log_default_callback_fptr(@avcl, @level, @fmt, @vl);
        };
        /// <summary>Default logging callback</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message expressed using a</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        /// <param name="vl">The arguments referenced by the format string.</param>
        public static void av_log_default_callback(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl)
        {
            av_log_default_callback_fptr(@avcl, @level, @fmt, @vl);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_format_line_delegate(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
        private static av_log_format_line_delegate av_log_format_line_fptr = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) =>
        {
            av_log_format_line_fptr = GetFunctionDelegate<av_log_format_line_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_format_line");
            if (av_log_format_line_fptr == null)
            {
                av_log_format_line_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_format_line is not supported on this platform.");
                };
            }
            av_log_format_line_fptr(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        };
        /// <summary>Format a line of log the same way as the default callback.</summary>
        /// <param name="line">buffer to receive the formatted line</param>
        /// <param name="line_size">size of the buffer</param>
        /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
        public static void av_log_format_line(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix)
        {
            av_log_format_line_fptr(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_log_format_line2_delegate(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix);
        private static av_log_format_line2_delegate av_log_format_line2_fptr = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) =>
        {
            av_log_format_line2_fptr = GetFunctionDelegate<av_log_format_line2_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_format_line2");
            if (av_log_format_line2_fptr == null)
            {
                av_log_format_line2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_format_line2 is not supported on this platform.");
                };
            }
            return av_log_format_line2_fptr(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        };
        /// <summary>Format a line of log the same way as the default callback.</summary>
        /// <param name="line">buffer to receive the formatted line; may be NULL if line_size is 0</param>
        /// <param name="line_size">size of the buffer; at most line_size-1 characters will be written to the buffer, plus one null terminator</param>
        /// <param name="print_prefix">used to store whether the prefix must be printed; must point to a persistent integer initially set to 1</param>
        public static int av_log_format_line2(void* @ptr, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix)
        {
            return av_log_format_line2_fptr(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_log_get_flags_delegate();
        private static av_log_get_flags_delegate av_log_get_flags_fptr = () =>
        {
            av_log_get_flags_fptr = GetFunctionDelegate<av_log_get_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_get_flags");
            if (av_log_get_flags_fptr == null)
            {
                av_log_get_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_get_flags is not supported on this platform.");
                };
            }
            return av_log_get_flags_fptr();
        };
        public static int av_log_get_flags()
        {
            return av_log_get_flags_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_log_get_level_delegate();
        private static av_log_get_level_delegate av_log_get_level_fptr = () =>
        {
            av_log_get_level_fptr = GetFunctionDelegate<av_log_get_level_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_get_level");
            if (av_log_get_level_fptr == null)
            {
                av_log_get_level_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_get_level is not supported on this platform.");
                };
            }
            return av_log_get_level_fptr();
        };
        /// <summary>Get the current log level</summary>
        public static int av_log_get_level()
        {
            return av_log_get_level_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_set_callback_delegate(av_log_set_callback_callback_func @callback);
        private static av_log_set_callback_delegate av_log_set_callback_fptr = (av_log_set_callback_callback_func @callback) =>
        {
            av_log_set_callback_fptr = GetFunctionDelegate<av_log_set_callback_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_set_callback");
            if (av_log_set_callback_fptr == null)
            {
                av_log_set_callback_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_set_callback is not supported on this platform.");
                };
            }
            av_log_set_callback_fptr(@callback);
        };
        /// <summary>Set the logging callback</summary>
        /// <param name="callback">A logging function with a compatible signature.</param>
        public static void av_log_set_callback(av_log_set_callback_callback_func @callback)
        {
            av_log_set_callback_fptr(@callback);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_set_flags_delegate(int @arg);
        private static av_log_set_flags_delegate av_log_set_flags_fptr = (int @arg) =>
        {
            av_log_set_flags_fptr = GetFunctionDelegate<av_log_set_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_set_flags");
            if (av_log_set_flags_fptr == null)
            {
                av_log_set_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_set_flags is not supported on this platform.");
                };
            }
            av_log_set_flags_fptr(@arg);
        };
        public static void av_log_set_flags(int @arg)
        {
            av_log_set_flags_fptr(@arg);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_log_set_level_delegate(int @level);
        private static av_log_set_level_delegate av_log_set_level_fptr = (int @level) =>
        {
            av_log_set_level_fptr = GetFunctionDelegate<av_log_set_level_delegate>(GetOrLoadLibrary("avutil", 55), "av_log_set_level");
            if (av_log_set_level_fptr == null)
            {
                av_log_set_level_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log_set_level is not supported on this platform.");
                };
            }
            av_log_set_level_fptr(@level);
        };
        /// <summary>Set the log level</summary>
        /// <param name="level">Logging level</param>
        public static void av_log_set_level(int @level)
        {
            av_log_set_level_fptr(@level);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_log2_delegate(uint @v);
        private static av_log2_delegate av_log2_fptr = (uint @v) =>
        {
            av_log2_fptr = GetFunctionDelegate<av_log2_delegate>(GetOrLoadLibrary("avutil", 55), "av_log2");
            if (av_log2_fptr == null)
            {
                av_log2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log2 is not supported on this platform.");
                };
            }
            return av_log2_fptr(@v);
        };
        public static int av_log2(uint @v)
        {
            return av_log2_fptr(@v);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_log2_16bit_delegate(uint @v);
        private static av_log2_16bit_delegate av_log2_16bit_fptr = (uint @v) =>
        {
            av_log2_16bit_fptr = GetFunctionDelegate<av_log2_16bit_delegate>(GetOrLoadLibrary("avutil", 55), "av_log2_16bit");
            if (av_log2_16bit_fptr == null)
            {
                av_log2_16bit_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_log2_16bit is not supported on this platform.");
                };
            }
            return av_log2_16bit_fptr(@v);
        };
        public static int av_log2_16bit(uint @v)
        {
            return av_log2_16bit_fptr(@v);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_malloc_delegate(ulong @size);
        private static av_malloc_delegate av_malloc_fptr = (ulong @size) =>
        {
            av_malloc_fptr = GetFunctionDelegate<av_malloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_malloc");
            if (av_malloc_fptr == null)
            {
                av_malloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_malloc is not supported on this platform.");
                };
            }
            return av_malloc_fptr(@size);
        };
        /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU).</summary>
        /// <param name="size">Size in bytes for the memory block to be allocated</param>
        public static void* av_malloc(ulong @size)
        {
            return av_malloc_fptr(@size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_mallocz_delegate(ulong @size);
        private static av_mallocz_delegate av_mallocz_fptr = (ulong @size) =>
        {
            av_mallocz_fptr = GetFunctionDelegate<av_mallocz_delegate>(GetOrLoadLibrary("avutil", 55), "av_mallocz");
            if (av_mallocz_fptr == null)
            {
                av_mallocz_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_mallocz is not supported on this platform.");
                };
            }
            return av_mallocz_fptr(@size);
        };
        /// <summary>Allocate a memory block with alignment suitable for all memory accesses (including vectors if available on the CPU) and zero all the bytes of the block.</summary>
        /// <param name="size">Size in bytes for the memory block to be allocated</param>
        public static void* av_mallocz(ulong @size)
        {
            return av_mallocz_fptr(@size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_max_alloc_delegate(ulong @max);
        private static av_max_alloc_delegate av_max_alloc_fptr = (ulong @max) =>
        {
            av_max_alloc_fptr = GetFunctionDelegate<av_max_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_max_alloc");
            if (av_max_alloc_fptr == null)
            {
                av_max_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_max_alloc is not supported on this platform.");
                };
            }
            av_max_alloc_fptr(@max);
        };
        /// <summary>Set the maximum size that may be allocated in one block.</summary>
        /// <param name="max">Value to be set as the new maximum size</param>
        public static void av_max_alloc(ulong @max)
        {
            av_max_alloc_fptr(@max);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_memcpy_backptr_delegate(byte* @dst, int @back, int @cnt);
        private static av_memcpy_backptr_delegate av_memcpy_backptr_fptr = (byte* @dst, int @back, int @cnt) =>
        {
            av_memcpy_backptr_fptr = GetFunctionDelegate<av_memcpy_backptr_delegate>(GetOrLoadLibrary("avutil", 55), "av_memcpy_backptr");
            if (av_memcpy_backptr_fptr == null)
            {
                av_memcpy_backptr_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_memcpy_backptr is not supported on this platform.");
                };
            }
            av_memcpy_backptr_fptr(@dst, @back, @cnt);
        };
        /// <summary>Overlapping memcpy() implementation.</summary>
        /// <param name="dst">Destination buffer</param>
        /// <param name="back">Number of bytes back to start copying (i.e. the initial size of the overlapping window); must be &gt; 0</param>
        /// <param name="cnt">Number of bytes to copy; must be &gt;= 0</param>
        public static void av_memcpy_backptr(byte* @dst, int @back, int @cnt)
        {
            av_memcpy_backptr_fptr(@dst, @back, @cnt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_memdup_delegate(void* @p, ulong @size);
        private static av_memdup_delegate av_memdup_fptr = (void* @p, ulong @size) =>
        {
            av_memdup_fptr = GetFunctionDelegate<av_memdup_delegate>(GetOrLoadLibrary("avutil", 55), "av_memdup");
            if (av_memdup_fptr == null)
            {
                av_memdup_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_memdup is not supported on this platform.");
                };
            }
            return av_memdup_fptr(@p, @size);
        };
        /// <summary>Duplicate a buffer with av_malloc().</summary>
        /// <param name="p">Buffer to be duplicated</param>
        /// <param name="size">Size in bytes of the buffer copied</param>
        public static void* av_memdup(void* @p, ulong @size)
        {
            return av_memdup_fptr(@p, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_mul_q_delegate(AVRational @b, AVRational @c);
        private static av_mul_q_delegate av_mul_q_fptr = (AVRational @b, AVRational @c) =>
        {
            av_mul_q_fptr = GetFunctionDelegate<av_mul_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_mul_q");
            if (av_mul_q_fptr == null)
            {
                av_mul_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_mul_q is not supported on this platform.");
                };
            }
            return av_mul_q_fptr(@b, @c);
        };
        /// <summary>Multiply two rationals.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        public static AVRational av_mul_q(AVRational @b, AVRational @c)
        {
            return av_mul_q_fptr(@b, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_nearer_q_delegate(AVRational @q, AVRational @q1, AVRational @q2);
        private static av_nearer_q_delegate av_nearer_q_fptr = (AVRational @q, AVRational @q1, AVRational @q2) =>
        {
            av_nearer_q_fptr = GetFunctionDelegate<av_nearer_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_nearer_q");
            if (av_nearer_q_fptr == null)
            {
                av_nearer_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_nearer_q is not supported on this platform.");
                };
            }
            return av_nearer_q_fptr(@q, @q1, @q2);
        };
        /// <summary>Find which of the two rationals is closer to another rational.</summary>
        /// <param name="q">Rational to be compared against</param>
        public static int av_nearer_q(AVRational @q, AVRational @q1, AVRational @q2)
        {
            return av_nearer_q_fptr(@q, @q1, @q2);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* av_opt_child_class_next_delegate(AVClass* @parent, AVClass* @prev);
        private static av_opt_child_class_next_delegate av_opt_child_class_next_fptr = (AVClass* @parent, AVClass* @prev) =>
        {
            av_opt_child_class_next_fptr = GetFunctionDelegate<av_opt_child_class_next_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_child_class_next");
            if (av_opt_child_class_next_fptr == null)
            {
                av_opt_child_class_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_child_class_next is not supported on this platform.");
                };
            }
            return av_opt_child_class_next_fptr(@parent, @prev);
        };
        /// <summary>Iterate over potential AVOptions-enabled children of parent.</summary>
        /// <param name="prev">result of a previous call to this function or NULL</param>
        public static AVClass* av_opt_child_class_next(AVClass* @parent, AVClass* @prev)
        {
            return av_opt_child_class_next_fptr(@parent, @prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_opt_child_next_delegate(void* @obj, void* @prev);
        private static av_opt_child_next_delegate av_opt_child_next_fptr = (void* @obj, void* @prev) =>
        {
            av_opt_child_next_fptr = GetFunctionDelegate<av_opt_child_next_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_child_next");
            if (av_opt_child_next_fptr == null)
            {
                av_opt_child_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_child_next is not supported on this platform.");
                };
            }
            return av_opt_child_next_fptr(@obj, @prev);
        };
        /// <summary>Iterate over AVOptions-enabled children of obj.</summary>
        /// <param name="prev">result of a previous call to this function or NULL</param>
        public static void* av_opt_child_next(void* @obj, void* @prev)
        {
            return av_opt_child_next_fptr(@obj, @prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_copy_delegate(void* @dest, void* @src);
        private static av_opt_copy_delegate av_opt_copy_fptr = (void* @dest, void* @src) =>
        {
            av_opt_copy_fptr = GetFunctionDelegate<av_opt_copy_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_copy");
            if (av_opt_copy_fptr == null)
            {
                av_opt_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_copy is not supported on this platform.");
                };
            }
            return av_opt_copy_fptr(@dest, @src);
        };
        /// <summary>Copy options from src object into dest object.</summary>
        /// <param name="dest">Object to copy from</param>
        /// <param name="src">Object to copy into</param>
        public static int av_opt_copy(void* @dest, void* @src)
        {
            return av_opt_copy_fptr(@dest, @src);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_eval_double_delegate(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, double* @double_out);
        private static av_opt_eval_double_delegate av_opt_eval_double_fptr = (void* @obj, AVOption* @o, string @val, double* @double_out) =>
        {
            av_opt_eval_double_fptr = GetFunctionDelegate<av_opt_eval_double_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_eval_double");
            if (av_opt_eval_double_fptr == null)
            {
                av_opt_eval_double_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_eval_double is not supported on this platform.");
                };
            }
            return av_opt_eval_double_fptr(@obj, @o, @val, @double_out);
        };
        public static int av_opt_eval_double(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, double* @double_out)
        {
            return av_opt_eval_double_fptr(@obj, @o, @val, @double_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_eval_flags_delegate(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @flags_out);
        private static av_opt_eval_flags_delegate av_opt_eval_flags_fptr = (void* @obj, AVOption* @o, string @val, int* @flags_out) =>
        {
            av_opt_eval_flags_fptr = GetFunctionDelegate<av_opt_eval_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_eval_flags");
            if (av_opt_eval_flags_fptr == null)
            {
                av_opt_eval_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_eval_flags is not supported on this platform.");
                };
            }
            return av_opt_eval_flags_fptr(@obj, @o, @val, @flags_out);
        };
        /// <summary>@{ This group of functions can be used to evaluate option strings and get numbers out of them. They do the same thing as av_opt_set(), except the result is written into the caller-supplied pointer.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass.</param>
        /// <param name="o">an option for which the string is to be evaluated.</param>
        /// <param name="val">string to be evaluated.</param>
        public static int av_opt_eval_flags(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @flags_out)
        {
            return av_opt_eval_flags_fptr(@obj, @o, @val, @flags_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_eval_float_delegate(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, float* @float_out);
        private static av_opt_eval_float_delegate av_opt_eval_float_fptr = (void* @obj, AVOption* @o, string @val, float* @float_out) =>
        {
            av_opt_eval_float_fptr = GetFunctionDelegate<av_opt_eval_float_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_eval_float");
            if (av_opt_eval_float_fptr == null)
            {
                av_opt_eval_float_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_eval_float is not supported on this platform.");
                };
            }
            return av_opt_eval_float_fptr(@obj, @o, @val, @float_out);
        };
        public static int av_opt_eval_float(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, float* @float_out)
        {
            return av_opt_eval_float_fptr(@obj, @o, @val, @float_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_eval_int_delegate(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @int_out);
        private static av_opt_eval_int_delegate av_opt_eval_int_fptr = (void* @obj, AVOption* @o, string @val, int* @int_out) =>
        {
            av_opt_eval_int_fptr = GetFunctionDelegate<av_opt_eval_int_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_eval_int");
            if (av_opt_eval_int_fptr == null)
            {
                av_opt_eval_int_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_eval_int is not supported on this platform.");
                };
            }
            return av_opt_eval_int_fptr(@obj, @o, @val, @int_out);
        };
        public static int av_opt_eval_int(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, int* @int_out)
        {
            return av_opt_eval_int_fptr(@obj, @o, @val, @int_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_eval_int64_delegate(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, long* @int64_out);
        private static av_opt_eval_int64_delegate av_opt_eval_int64_fptr = (void* @obj, AVOption* @o, string @val, long* @int64_out) =>
        {
            av_opt_eval_int64_fptr = GetFunctionDelegate<av_opt_eval_int64_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_eval_int64");
            if (av_opt_eval_int64_fptr == null)
            {
                av_opt_eval_int64_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_eval_int64 is not supported on this platform.");
                };
            }
            return av_opt_eval_int64_fptr(@obj, @o, @val, @int64_out);
        };
        public static int av_opt_eval_int64(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, long* @int64_out)
        {
            return av_opt_eval_int64_fptr(@obj, @o, @val, @int64_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_eval_q_delegate(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, AVRational* @q_out);
        private static av_opt_eval_q_delegate av_opt_eval_q_fptr = (void* @obj, AVOption* @o, string @val, AVRational* @q_out) =>
        {
            av_opt_eval_q_fptr = GetFunctionDelegate<av_opt_eval_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_eval_q");
            if (av_opt_eval_q_fptr == null)
            {
                av_opt_eval_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_eval_q is not supported on this platform.");
                };
            }
            return av_opt_eval_q_fptr(@obj, @o, @val, @q_out);
        };
        public static int av_opt_eval_q(void* @obj, AVOption* @o, [MarshalAs(UnmanagedType.LPStr)] string @val, AVRational* @q_out)
        {
            return av_opt_eval_q_fptr(@obj, @o, @val, @q_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOption* av_opt_find_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags);
        private static av_opt_find_delegate av_opt_find_fptr = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags) =>
        {
            av_opt_find_fptr = GetFunctionDelegate<av_opt_find_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_find");
            if (av_opt_find_fptr == null)
            {
                av_opt_find_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_find is not supported on this platform.");
                };
            }
            return av_opt_find_fptr(@obj, @name, @unit, @opt_flags, @search_flags);
        };
        /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
        /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
        /// <param name="name">The name of the option to look for.</param>
        /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
        /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        public static AVOption* av_opt_find(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags)
        {
            return av_opt_find_fptr(@obj, @name, @unit, @opt_flags, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOption* av_opt_find2_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags, void** @target_obj);
        private static av_opt_find2_delegate av_opt_find2_fptr = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags, void** @target_obj) =>
        {
            av_opt_find2_fptr = GetFunctionDelegate<av_opt_find2_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_find2");
            if (av_opt_find2_fptr == null)
            {
                av_opt_find2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_find2 is not supported on this platform.");
                };
            }
            return av_opt_find2_fptr(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
        };
        /// <summary>Look for an option in an object. Consider only options which have all the specified flags set.</summary>
        /// <param name="obj">A pointer to a struct whose first element is a pointer to an AVClass. Alternatively a double pointer to an AVClass, if AV_OPT_SEARCH_FAKE_OBJ search flag is set.</param>
        /// <param name="name">The name of the option to look for.</param>
        /// <param name="unit">When searching for named constants, name of the unit it belongs to.</param>
        /// <param name="opt_flags">Find only options with all the specified flags set (AV_OPT_FLAG).</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        /// <param name="target_obj">if non-NULL, an object to which the option belongs will be written here. It may be different from obj if AV_OPT_SEARCH_CHILDREN is present in search_flags. This parameter is ignored if search_flags contain AV_OPT_SEARCH_FAKE_OBJ.</param>
        public static AVOption* av_opt_find2(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @unit, int @opt_flags, int @search_flags, void** @target_obj)
        {
            return av_opt_find2_fptr(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_flag_is_set_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @field_name, [MarshalAs(UnmanagedType.LPStr)] string @flag_name);
        private static av_opt_flag_is_set_delegate av_opt_flag_is_set_fptr = (void* @obj, string @field_name, string @flag_name) =>
        {
            av_opt_flag_is_set_fptr = GetFunctionDelegate<av_opt_flag_is_set_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_flag_is_set");
            if (av_opt_flag_is_set_fptr == null)
            {
                av_opt_flag_is_set_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_flag_is_set is not supported on this platform.");
                };
            }
            return av_opt_flag_is_set_fptr(@obj, @field_name, @flag_name);
        };
        /// <summary>Check whether a particular flag is set in a flags field.</summary>
        /// <param name="field_name">the name of the flag field option</param>
        /// <param name="flag_name">the name of the flag to check</param>
        public static int av_opt_flag_is_set(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @field_name, [MarshalAs(UnmanagedType.LPStr)] string @flag_name)
        {
            return av_opt_flag_is_set_fptr(@obj, @field_name, @flag_name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_opt_free_delegate(void* @obj);
        private static av_opt_free_delegate av_opt_free_fptr = (void* @obj) =>
        {
            av_opt_free_fptr = GetFunctionDelegate<av_opt_free_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_free");
            if (av_opt_free_fptr == null)
            {
                av_opt_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_free is not supported on this platform.");
                };
            }
            av_opt_free_fptr(@obj);
        };
        /// <summary>Free all allocated objects in obj.</summary>
        public static void av_opt_free(void* @obj)
        {
            av_opt_free_fptr(@obj);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_opt_freep_ranges_delegate(AVOptionRanges** @ranges);
        private static av_opt_freep_ranges_delegate av_opt_freep_ranges_fptr = (AVOptionRanges** @ranges) =>
        {
            av_opt_freep_ranges_fptr = GetFunctionDelegate<av_opt_freep_ranges_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_freep_ranges");
            if (av_opt_freep_ranges_fptr == null)
            {
                av_opt_freep_ranges_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_freep_ranges is not supported on this platform.");
                };
            }
            av_opt_freep_ranges_fptr(@ranges);
        };
        /// <summary>Free an AVOptionRanges struct and set it to NULL.</summary>
        public static void av_opt_freep_ranges(AVOptionRanges** @ranges)
        {
            av_opt_freep_ranges_fptr(@ranges);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, byte** @out_val);
        private static av_opt_get_delegate av_opt_get_fptr = (void* @obj, string @name, int @search_flags, byte** @out_val) =>
        {
            av_opt_get_fptr = GetFunctionDelegate<av_opt_get_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get");
            if (av_opt_get_fptr == null)
            {
                av_opt_get_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get is not supported on this platform.");
                };
            }
            return av_opt_get_fptr(@obj, @name, @search_flags, @out_val);
        };
        /// <summary>@{ Those functions get a value of the option with the given name from an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to an AVClass.</param>
        /// <param name="name">name of the option to get.</param>
        /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be found in a child of obj.</param>
        /// <param name="out_val">value of the option will be written here</param>
        public static int av_opt_get(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, byte** @out_val)
        {
            return av_opt_get_fptr(@obj, @name, @search_flags, @out_val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_channel_layout_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @ch_layout);
        private static av_opt_get_channel_layout_delegate av_opt_get_channel_layout_fptr = (void* @obj, string @name, int @search_flags, long* @ch_layout) =>
        {
            av_opt_get_channel_layout_fptr = GetFunctionDelegate<av_opt_get_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_channel_layout");
            if (av_opt_get_channel_layout_fptr == null)
            {
                av_opt_get_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_channel_layout is not supported on this platform.");
                };
            }
            return av_opt_get_channel_layout_fptr(@obj, @name, @search_flags, @ch_layout);
        };
        public static int av_opt_get_channel_layout(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @ch_layout)
        {
            return av_opt_get_channel_layout_fptr(@obj, @name, @search_flags, @ch_layout);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_dict_val_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVDictionary** @out_val);
        private static av_opt_get_dict_val_delegate av_opt_get_dict_val_fptr = (void* @obj, string @name, int @search_flags, AVDictionary** @out_val) =>
        {
            av_opt_get_dict_val_fptr = GetFunctionDelegate<av_opt_get_dict_val_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_dict_val");
            if (av_opt_get_dict_val_fptr == null)
            {
                av_opt_get_dict_val_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_dict_val is not supported on this platform.");
                };
            }
            return av_opt_get_dict_val_fptr(@obj, @name, @search_flags, @out_val);
        };
        /// <param name="out_val">The returned dictionary is a copy of the actual value and must be freed with av_dict_free() by the caller</param>
        public static int av_opt_get_dict_val(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVDictionary** @out_val)
        {
            return av_opt_get_dict_val_fptr(@obj, @name, @search_flags, @out_val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_double_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, double* @out_val);
        private static av_opt_get_double_delegate av_opt_get_double_fptr = (void* @obj, string @name, int @search_flags, double* @out_val) =>
        {
            av_opt_get_double_fptr = GetFunctionDelegate<av_opt_get_double_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_double");
            if (av_opt_get_double_fptr == null)
            {
                av_opt_get_double_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_double is not supported on this platform.");
                };
            }
            return av_opt_get_double_fptr(@obj, @name, @search_flags, @out_val);
        };
        public static int av_opt_get_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, double* @out_val)
        {
            return av_opt_get_double_fptr(@obj, @name, @search_flags, @out_val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_image_size_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, int* @w_out, int* @h_out);
        private static av_opt_get_image_size_delegate av_opt_get_image_size_fptr = (void* @obj, string @name, int @search_flags, int* @w_out, int* @h_out) =>
        {
            av_opt_get_image_size_fptr = GetFunctionDelegate<av_opt_get_image_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_image_size");
            if (av_opt_get_image_size_fptr == null)
            {
                av_opt_get_image_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_image_size is not supported on this platform.");
                };
            }
            return av_opt_get_image_size_fptr(@obj, @name, @search_flags, @w_out, @h_out);
        };
        public static int av_opt_get_image_size(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, int* @w_out, int* @h_out)
        {
            return av_opt_get_image_size_fptr(@obj, @name, @search_flags, @w_out, @h_out);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_int_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @out_val);
        private static av_opt_get_int_delegate av_opt_get_int_fptr = (void* @obj, string @name, int @search_flags, long* @out_val) =>
        {
            av_opt_get_int_fptr = GetFunctionDelegate<av_opt_get_int_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_int");
            if (av_opt_get_int_fptr == null)
            {
                av_opt_get_int_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_int is not supported on this platform.");
                };
            }
            return av_opt_get_int_fptr(@obj, @name, @search_flags, @out_val);
        };
        public static int av_opt_get_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, long* @out_val)
        {
            return av_opt_get_int_fptr(@obj, @name, @search_flags, @out_val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_key_value_delegate(byte** @ropts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, uint @flags, byte** @rkey, byte** @rval);
        private static av_opt_get_key_value_delegate av_opt_get_key_value_fptr = (byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, byte** @rval) =>
        {
            av_opt_get_key_value_fptr = GetFunctionDelegate<av_opt_get_key_value_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_key_value");
            if (av_opt_get_key_value_fptr == null)
            {
                av_opt_get_key_value_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_key_value is not supported on this platform.");
                };
            }
            return av_opt_get_key_value_fptr(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
        };
        /// <summary>Extract a key-value pair from the beginning of a string.</summary>
        /// <param name="ropts">pointer to the options string, will be updated to point to the rest of the string (one of the pairs_sep or the final NUL)</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
        /// <param name="flags">flags; see the AV_OPT_FLAG_* values below</param>
        /// <param name="rkey">parsed key; must be freed using av_free()</param>
        /// <param name="rval">parsed value; must be freed using av_free()</param>
        public static int av_opt_get_key_value(byte** @ropts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep, uint @flags, byte** @rkey, byte** @rval)
        {
            return av_opt_get_key_value_fptr(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_pixel_fmt_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVPixelFormat* @out_fmt);
        private static av_opt_get_pixel_fmt_delegate av_opt_get_pixel_fmt_fptr = (void* @obj, string @name, int @search_flags, AVPixelFormat* @out_fmt) =>
        {
            av_opt_get_pixel_fmt_fptr = GetFunctionDelegate<av_opt_get_pixel_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_pixel_fmt");
            if (av_opt_get_pixel_fmt_fptr == null)
            {
                av_opt_get_pixel_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_pixel_fmt is not supported on this platform.");
                };
            }
            return av_opt_get_pixel_fmt_fptr(@obj, @name, @search_flags, @out_fmt);
        };
        public static int av_opt_get_pixel_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVPixelFormat* @out_fmt)
        {
            return av_opt_get_pixel_fmt_fptr(@obj, @name, @search_flags, @out_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_q_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val);
        private static av_opt_get_q_delegate av_opt_get_q_fptr = (void* @obj, string @name, int @search_flags, AVRational* @out_val) =>
        {
            av_opt_get_q_fptr = GetFunctionDelegate<av_opt_get_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_q");
            if (av_opt_get_q_fptr == null)
            {
                av_opt_get_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_q is not supported on this platform.");
                };
            }
            return av_opt_get_q_fptr(@obj, @name, @search_flags, @out_val);
        };
        public static int av_opt_get_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val)
        {
            return av_opt_get_q_fptr(@obj, @name, @search_flags, @out_val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_sample_fmt_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVSampleFormat* @out_fmt);
        private static av_opt_get_sample_fmt_delegate av_opt_get_sample_fmt_fptr = (void* @obj, string @name, int @search_flags, AVSampleFormat* @out_fmt) =>
        {
            av_opt_get_sample_fmt_fptr = GetFunctionDelegate<av_opt_get_sample_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_sample_fmt");
            if (av_opt_get_sample_fmt_fptr == null)
            {
                av_opt_get_sample_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_sample_fmt is not supported on this platform.");
                };
            }
            return av_opt_get_sample_fmt_fptr(@obj, @name, @search_flags, @out_fmt);
        };
        public static int av_opt_get_sample_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVSampleFormat* @out_fmt)
        {
            return av_opt_get_sample_fmt_fptr(@obj, @name, @search_flags, @out_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_get_video_rate_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val);
        private static av_opt_get_video_rate_delegate av_opt_get_video_rate_fptr = (void* @obj, string @name, int @search_flags, AVRational* @out_val) =>
        {
            av_opt_get_video_rate_fptr = GetFunctionDelegate<av_opt_get_video_rate_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_get_video_rate");
            if (av_opt_get_video_rate_fptr == null)
            {
                av_opt_get_video_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_get_video_rate is not supported on this platform.");
                };
            }
            return av_opt_get_video_rate_fptr(@obj, @name, @search_flags, @out_val);
        };
        public static int av_opt_get_video_rate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags, AVRational* @out_val)
        {
            return av_opt_get_video_rate_fptr(@obj, @name, @search_flags, @out_val);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_is_set_to_default_delegate(void* @obj, AVOption* @o);
        private static av_opt_is_set_to_default_delegate av_opt_is_set_to_default_fptr = (void* @obj, AVOption* @o) =>
        {
            av_opt_is_set_to_default_fptr = GetFunctionDelegate<av_opt_is_set_to_default_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_is_set_to_default");
            if (av_opt_is_set_to_default_fptr == null)
            {
                av_opt_is_set_to_default_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_is_set_to_default is not supported on this platform.");
                };
            }
            return av_opt_is_set_to_default_fptr(@obj, @o);
        };
        /// <summary>Check if given option is set to its default value.</summary>
        /// <param name="obj">AVClass object to check option on</param>
        /// <param name="o">option to be checked</param>
        public static int av_opt_is_set_to_default(void* @obj, AVOption* @o)
        {
            return av_opt_is_set_to_default_fptr(@obj, @o);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_is_set_to_default_by_name_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags);
        private static av_opt_is_set_to_default_by_name_delegate av_opt_is_set_to_default_by_name_fptr = (void* @obj, string @name, int @search_flags) =>
        {
            av_opt_is_set_to_default_by_name_fptr = GetFunctionDelegate<av_opt_is_set_to_default_by_name_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_is_set_to_default_by_name");
            if (av_opt_is_set_to_default_by_name_fptr == null)
            {
                av_opt_is_set_to_default_by_name_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_is_set_to_default_by_name is not supported on this platform.");
                };
            }
            return av_opt_is_set_to_default_by_name_fptr(@obj, @name, @search_flags);
        };
        /// <summary>Check if given option is set to its default value.</summary>
        /// <param name="obj">AVClass object to check option on</param>
        /// <param name="name">option name</param>
        /// <param name="search_flags">combination of AV_OPT_SEARCH_*</param>
        public static int av_opt_is_set_to_default_by_name(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @search_flags)
        {
            return av_opt_is_set_to_default_by_name_fptr(@obj, @name, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVOption* av_opt_next_delegate(void* @obj, AVOption* @prev);
        private static av_opt_next_delegate av_opt_next_fptr = (void* @obj, AVOption* @prev) =>
        {
            av_opt_next_fptr = GetFunctionDelegate<av_opt_next_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_next");
            if (av_opt_next_fptr == null)
            {
                av_opt_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_next is not supported on this platform.");
                };
            }
            return av_opt_next_fptr(@obj, @prev);
        };
        /// <summary>Iterate over all AVOptions belonging to obj.</summary>
        /// <param name="obj">an AVOptions-enabled struct or a double pointer to an AVClass describing it.</param>
        /// <param name="prev">result of the previous call to av_opt_next() on this object or NULL</param>
        public static AVOption* av_opt_next(void* @obj, AVOption* @prev)
        {
            return av_opt_next_fptr(@obj, @prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_opt_ptr_delegate(AVClass* @avclass, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name);
        private static av_opt_ptr_delegate av_opt_ptr_fptr = (AVClass* @avclass, void* @obj, string @name) =>
        {
            av_opt_ptr_fptr = GetFunctionDelegate<av_opt_ptr_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_ptr");
            if (av_opt_ptr_fptr == null)
            {
                av_opt_ptr_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_ptr is not supported on this platform.");
                };
            }
            return av_opt_ptr_fptr(@avclass, @obj, @name);
        };
        /// <summary>@}</summary>
        public static void* av_opt_ptr(AVClass* @avclass, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name)
        {
            return av_opt_ptr_fptr(@avclass, @obj, @name);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_query_ranges_delegate(AVOptionRanges** @p0, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags);
        private static av_opt_query_ranges_delegate av_opt_query_ranges_fptr = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) =>
        {
            av_opt_query_ranges_fptr = GetFunctionDelegate<av_opt_query_ranges_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_query_ranges");
            if (av_opt_query_ranges_fptr == null)
            {
                av_opt_query_ranges_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_query_ranges is not supported on this platform.");
                };
            }
            return av_opt_query_ranges_fptr(@p0, @obj, @key, @flags);
        };
        /// <summary>Get a list of allowed ranges for the given option.</summary>
        /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
        public static int av_opt_query_ranges(AVOptionRanges** @p0, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags)
        {
            return av_opt_query_ranges_fptr(@p0, @obj, @key, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_query_ranges_default_delegate(AVOptionRanges** @p0, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags);
        private static av_opt_query_ranges_default_delegate av_opt_query_ranges_default_fptr = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) =>
        {
            av_opt_query_ranges_default_fptr = GetFunctionDelegate<av_opt_query_ranges_default_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_query_ranges_default");
            if (av_opt_query_ranges_default_fptr == null)
            {
                av_opt_query_ranges_default_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_query_ranges_default is not supported on this platform.");
                };
            }
            return av_opt_query_ranges_default_fptr(@p0, @obj, @key, @flags);
        };
        /// <summary>Get a default list of allowed ranges for the given option.</summary>
        /// <param name="flags">is a bitmask of flags, undefined flags should not be set and should be ignored AV_OPT_SEARCH_FAKE_OBJ indicates that the obj is a double pointer to a AVClass instead of a full instance AV_OPT_MULTI_COMPONENT_RANGE indicates that function may return more than one component,</param>
        public static int av_opt_query_ranges_default(AVOptionRanges** @p0, void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @key, int @flags)
        {
            return av_opt_query_ranges_default_fptr(@p0, @obj, @key, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_serialize_delegate(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep);
        private static av_opt_serialize_delegate av_opt_serialize_fptr = (void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep) =>
        {
            av_opt_serialize_fptr = GetFunctionDelegate<av_opt_serialize_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_serialize");
            if (av_opt_serialize_fptr == null)
            {
                av_opt_serialize_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_serialize is not supported on this platform.");
                };
            }
            return av_opt_serialize_fptr(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
        };
        /// <summary>Serialize object&apos;s options.</summary>
        /// <param name="obj">AVClass object to serialize</param>
        /// <param name="opt_flags">serialize options with all the specified flags set (AV_OPT_FLAG)</param>
        /// <param name="flags">combination of AV_OPT_SERIALIZE_* flags</param>
        /// <param name="buffer">Pointer to buffer that will be allocated with string containg serialized options. Buffer must be freed by the caller when is no longer needed.</param>
        /// <param name="key_val_sep">character used to separate key from value</param>
        /// <param name="pairs_sep">character used to separate two pairs from each other</param>
        public static int av_opt_serialize(void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep)
        {
            return av_opt_serialize_fptr(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @val, int @search_flags);
        private static av_opt_set_delegate av_opt_set_fptr = (void* @obj, string @name, string @val, int @search_flags) =>
        {
            av_opt_set_fptr = GetFunctionDelegate<av_opt_set_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set");
            if (av_opt_set_fptr == null)
            {
                av_opt_set_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set is not supported on this platform.");
                };
            }
            return av_opt_set_fptr(@obj, @name, @val, @search_flags);
        };
        /// <summary>@{ Those functions set the field of obj with the given name to value.</summary>
        /// <param name="obj">A struct whose first element is a pointer to an AVClass.</param>
        /// <param name="name">the name of the field to set</param>
        /// <param name="val">The value to set. In case of av_opt_set() if the field is not of a string type, then the given string is parsed. SI postfixes and some named scalars are supported. If the field is of a numeric type, it has to be a numeric or named scalar. Behavior with more than one scalar and +- infix operators is undefined. If the field is of a flags type, it has to be a sequence of numeric scalars or named flags separated by &apos;+&apos; or &apos;-&apos;. Prefixing a flag with &apos;+&apos; causes it to be set without affecting the other flags; similarly, &apos;-&apos; unsets a flag.</param>
        /// <param name="search_flags">flags passed to av_opt_find2. I.e. if AV_OPT_SEARCH_CHILDREN is passed here, then the option may be set on a child of obj.</param>
        public static int av_opt_set(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, [MarshalAs(UnmanagedType.LPStr)] string @val, int @search_flags)
        {
            return av_opt_set_fptr(@obj, @name, @val, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_bin_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, byte* @val, int @size, int @search_flags);
        private static av_opt_set_bin_delegate av_opt_set_bin_fptr = (void* @obj, string @name, byte* @val, int @size, int @search_flags) =>
        {
            av_opt_set_bin_fptr = GetFunctionDelegate<av_opt_set_bin_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_bin");
            if (av_opt_set_bin_fptr == null)
            {
                av_opt_set_bin_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_bin is not supported on this platform.");
                };
            }
            return av_opt_set_bin_fptr(@obj, @name, @val, @size, @search_flags);
        };
        public static int av_opt_set_bin(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, byte* @val, int @size, int @search_flags)
        {
            return av_opt_set_bin_fptr(@obj, @name, @val, @size, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_channel_layout_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @ch_layout, int @search_flags);
        private static av_opt_set_channel_layout_delegate av_opt_set_channel_layout_fptr = (void* @obj, string @name, long @ch_layout, int @search_flags) =>
        {
            av_opt_set_channel_layout_fptr = GetFunctionDelegate<av_opt_set_channel_layout_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_channel_layout");
            if (av_opt_set_channel_layout_fptr == null)
            {
                av_opt_set_channel_layout_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_channel_layout is not supported on this platform.");
                };
            }
            return av_opt_set_channel_layout_fptr(@obj, @name, @ch_layout, @search_flags);
        };
        public static int av_opt_set_channel_layout(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @ch_layout, int @search_flags)
        {
            return av_opt_set_channel_layout_fptr(@obj, @name, @ch_layout, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_opt_set_defaults_delegate(void* @s);
        private static av_opt_set_defaults_delegate av_opt_set_defaults_fptr = (void* @s) =>
        {
            av_opt_set_defaults_fptr = GetFunctionDelegate<av_opt_set_defaults_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_defaults");
            if (av_opt_set_defaults_fptr == null)
            {
                av_opt_set_defaults_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_defaults is not supported on this platform.");
                };
            }
            av_opt_set_defaults_fptr(@s);
        };
        /// <summary>Set the values of all AVOption fields to their default values.</summary>
        /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
        public static void av_opt_set_defaults(void* @s)
        {
            av_opt_set_defaults_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_opt_set_defaults2_delegate(void* @s, int @mask, int @flags);
        private static av_opt_set_defaults2_delegate av_opt_set_defaults2_fptr = (void* @s, int @mask, int @flags) =>
        {
            av_opt_set_defaults2_fptr = GetFunctionDelegate<av_opt_set_defaults2_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_defaults2");
            if (av_opt_set_defaults2_fptr == null)
            {
                av_opt_set_defaults2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_defaults2 is not supported on this platform.");
                };
            }
            av_opt_set_defaults2_fptr(@s, @mask, @flags);
        };
        /// <summary>Set the values of all AVOption fields to their default values. Only these AVOption fields for which (opt-&gt;flags &amp; mask) == flags will have their default applied to s.</summary>
        /// <param name="s">an AVOption-enabled struct (its first member must be a pointer to AVClass)</param>
        /// <param name="mask">combination of AV_OPT_FLAG_*</param>
        /// <param name="flags">combination of AV_OPT_FLAG_*</param>
        public static void av_opt_set_defaults2(void* @s, int @mask, int @flags)
        {
            av_opt_set_defaults2_fptr(@s, @mask, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_dict_delegate(void* @obj, AVDictionary** @options);
        private static av_opt_set_dict_delegate av_opt_set_dict_fptr = (void* @obj, AVDictionary** @options) =>
        {
            av_opt_set_dict_fptr = GetFunctionDelegate<av_opt_set_dict_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_dict");
            if (av_opt_set_dict_fptr == null)
            {
                av_opt_set_dict_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_dict is not supported on this platform.");
                };
            }
            return av_opt_set_dict_fptr(@obj, @options);
        };
        /// <summary>Set all the options from a given dictionary on an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
        /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
        public static int av_opt_set_dict(void* @obj, AVDictionary** @options)
        {
            return av_opt_set_dict_fptr(@obj, @options);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_dict_val_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVDictionary* @val, int @search_flags);
        private static av_opt_set_dict_val_delegate av_opt_set_dict_val_fptr = (void* @obj, string @name, AVDictionary* @val, int @search_flags) =>
        {
            av_opt_set_dict_val_fptr = GetFunctionDelegate<av_opt_set_dict_val_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_dict_val");
            if (av_opt_set_dict_val_fptr == null)
            {
                av_opt_set_dict_val_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_dict_val is not supported on this platform.");
                };
            }
            return av_opt_set_dict_val_fptr(@obj, @name, @val, @search_flags);
        };
        public static int av_opt_set_dict_val(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVDictionary* @val, int @search_flags)
        {
            return av_opt_set_dict_val_fptr(@obj, @name, @val, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_dict2_delegate(void* @obj, AVDictionary** @options, int @search_flags);
        private static av_opt_set_dict2_delegate av_opt_set_dict2_fptr = (void* @obj, AVDictionary** @options, int @search_flags) =>
        {
            av_opt_set_dict2_fptr = GetFunctionDelegate<av_opt_set_dict2_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_dict2");
            if (av_opt_set_dict2_fptr == null)
            {
                av_opt_set_dict2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_dict2 is not supported on this platform.");
                };
            }
            return av_opt_set_dict2_fptr(@obj, @options, @search_flags);
        };
        /// <summary>Set all the options from a given dictionary on an object.</summary>
        /// <param name="obj">a struct whose first element is a pointer to AVClass</param>
        /// <param name="options">options to process. This dictionary will be freed and replaced by a new one containing all options not found in obj. Of course this new dictionary needs to be freed by caller with av_dict_free().</param>
        /// <param name="search_flags">A combination of AV_OPT_SEARCH_*.</param>
        public static int av_opt_set_dict2(void* @obj, AVDictionary** @options, int @search_flags)
        {
            return av_opt_set_dict2_fptr(@obj, @options, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_double_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, double @val, int @search_flags);
        private static av_opt_set_double_delegate av_opt_set_double_fptr = (void* @obj, string @name, double @val, int @search_flags) =>
        {
            av_opt_set_double_fptr = GetFunctionDelegate<av_opt_set_double_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_double");
            if (av_opt_set_double_fptr == null)
            {
                av_opt_set_double_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_double is not supported on this platform.");
                };
            }
            return av_opt_set_double_fptr(@obj, @name, @val, @search_flags);
        };
        public static int av_opt_set_double(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, double @val, int @search_flags)
        {
            return av_opt_set_double_fptr(@obj, @name, @val, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_from_string_delegate(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, byte** @shorthand, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep);
        private static av_opt_set_from_string_delegate av_opt_set_from_string_fptr = (void* @ctx, string @opts, byte** @shorthand, string @key_val_sep, string @pairs_sep) =>
        {
            av_opt_set_from_string_fptr = GetFunctionDelegate<av_opt_set_from_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_from_string");
            if (av_opt_set_from_string_fptr == null)
            {
                av_opt_set_from_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_from_string is not supported on this platform.");
                };
            }
            return av_opt_set_from_string_fptr(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
        };
        /// <summary>Parse the key-value pairs list in opts. For each key=value pair found, set the value of the corresponding option in ctx.</summary>
        /// <param name="ctx">the AVClass object to set options on</param>
        /// <param name="opts">the options string, key-value pairs separated by a delimiter</param>
        /// <param name="shorthand">a NULL-terminated array of options names for shorthand notation: if the first field in opts has no key part, the key is taken from the first element of shorthand; then again for the second, etc., until either opts is finished, shorthand is finished or a named option is found; after that, all options must be named</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value, for example &apos;=&apos;</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other, for example &apos;:&apos; or &apos;,&apos;</param>
        public static int av_opt_set_from_string(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, byte** @shorthand, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep)
        {
            return av_opt_set_from_string_fptr(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_image_size_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @w, int @h, int @search_flags);
        private static av_opt_set_image_size_delegate av_opt_set_image_size_fptr = (void* @obj, string @name, int @w, int @h, int @search_flags) =>
        {
            av_opt_set_image_size_fptr = GetFunctionDelegate<av_opt_set_image_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_image_size");
            if (av_opt_set_image_size_fptr == null)
            {
                av_opt_set_image_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_image_size is not supported on this platform.");
                };
            }
            return av_opt_set_image_size_fptr(@obj, @name, @w, @h, @search_flags);
        };
        public static int av_opt_set_image_size(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, int @w, int @h, int @search_flags)
        {
            return av_opt_set_image_size_fptr(@obj, @name, @w, @h, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_int_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @val, int @search_flags);
        private static av_opt_set_int_delegate av_opt_set_int_fptr = (void* @obj, string @name, long @val, int @search_flags) =>
        {
            av_opt_set_int_fptr = GetFunctionDelegate<av_opt_set_int_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_int");
            if (av_opt_set_int_fptr == null)
            {
                av_opt_set_int_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_int is not supported on this platform.");
                };
            }
            return av_opt_set_int_fptr(@obj, @name, @val, @search_flags);
        };
        public static int av_opt_set_int(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, long @val, int @search_flags)
        {
            return av_opt_set_int_fptr(@obj, @name, @val, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_pixel_fmt_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVPixelFormat @fmt, int @search_flags);
        private static av_opt_set_pixel_fmt_delegate av_opt_set_pixel_fmt_fptr = (void* @obj, string @name, AVPixelFormat @fmt, int @search_flags) =>
        {
            av_opt_set_pixel_fmt_fptr = GetFunctionDelegate<av_opt_set_pixel_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_pixel_fmt");
            if (av_opt_set_pixel_fmt_fptr == null)
            {
                av_opt_set_pixel_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_pixel_fmt is not supported on this platform.");
                };
            }
            return av_opt_set_pixel_fmt_fptr(@obj, @name, @fmt, @search_flags);
        };
        public static int av_opt_set_pixel_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVPixelFormat @fmt, int @search_flags)
        {
            return av_opt_set_pixel_fmt_fptr(@obj, @name, @fmt, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_q_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags);
        private static av_opt_set_q_delegate av_opt_set_q_fptr = (void* @obj, string @name, AVRational @val, int @search_flags) =>
        {
            av_opt_set_q_fptr = GetFunctionDelegate<av_opt_set_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_q");
            if (av_opt_set_q_fptr == null)
            {
                av_opt_set_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_q is not supported on this platform.");
                };
            }
            return av_opt_set_q_fptr(@obj, @name, @val, @search_flags);
        };
        public static int av_opt_set_q(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags)
        {
            return av_opt_set_q_fptr(@obj, @name, @val, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_sample_fmt_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVSampleFormat @fmt, int @search_flags);
        private static av_opt_set_sample_fmt_delegate av_opt_set_sample_fmt_fptr = (void* @obj, string @name, AVSampleFormat @fmt, int @search_flags) =>
        {
            av_opt_set_sample_fmt_fptr = GetFunctionDelegate<av_opt_set_sample_fmt_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_sample_fmt");
            if (av_opt_set_sample_fmt_fptr == null)
            {
                av_opt_set_sample_fmt_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_sample_fmt is not supported on this platform.");
                };
            }
            return av_opt_set_sample_fmt_fptr(@obj, @name, @fmt, @search_flags);
        };
        public static int av_opt_set_sample_fmt(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVSampleFormat @fmt, int @search_flags)
        {
            return av_opt_set_sample_fmt_fptr(@obj, @name, @fmt, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_set_video_rate_delegate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags);
        private static av_opt_set_video_rate_delegate av_opt_set_video_rate_fptr = (void* @obj, string @name, AVRational @val, int @search_flags) =>
        {
            av_opt_set_video_rate_fptr = GetFunctionDelegate<av_opt_set_video_rate_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_set_video_rate");
            if (av_opt_set_video_rate_fptr == null)
            {
                av_opt_set_video_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_set_video_rate is not supported on this platform.");
                };
            }
            return av_opt_set_video_rate_fptr(@obj, @name, @val, @search_flags);
        };
        public static int av_opt_set_video_rate(void* @obj, [MarshalAs(UnmanagedType.LPStr)] string @name, AVRational @val, int @search_flags)
        {
            return av_opt_set_video_rate_fptr(@obj, @name, @val, @search_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_opt_show2_delegate(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags);
        private static av_opt_show2_delegate av_opt_show2_fptr = (void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags) =>
        {
            av_opt_show2_fptr = GetFunctionDelegate<av_opt_show2_delegate>(GetOrLoadLibrary("avutil", 55), "av_opt_show2");
            if (av_opt_show2_fptr == null)
            {
                av_opt_show2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_opt_show2 is not supported on this platform.");
                };
            }
            return av_opt_show2_fptr(@obj, @av_log_obj, @req_flags, @rej_flags);
        };
        /// <summary>Show the obj options.</summary>
        /// <param name="av_log_obj">log context to use for showing the options</param>
        /// <param name="req_flags">requested flags for the options to show. Show only the options for which it is opt-&gt;flags &amp; req_flags.</param>
        /// <param name="rej_flags">rejected flags for the options to show. Show only the options for which it is !(opt-&gt;flags &amp; req_flags).</param>
        public static int av_opt_show2(void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags)
        {
            return av_opt_show2_fptr(@obj, @av_log_obj, @req_flags, @rej_flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_parse_cpu_caps_delegate(uint* @flags, [MarshalAs(UnmanagedType.LPStr)] string @s);
        private static av_parse_cpu_caps_delegate av_parse_cpu_caps_fptr = (uint* @flags, string @s) =>
        {
            av_parse_cpu_caps_fptr = GetFunctionDelegate<av_parse_cpu_caps_delegate>(GetOrLoadLibrary("avutil", 55), "av_parse_cpu_caps");
            if (av_parse_cpu_caps_fptr == null)
            {
                av_parse_cpu_caps_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parse_cpu_caps is not supported on this platform.");
                };
            }
            return av_parse_cpu_caps_fptr(@flags, @s);
        };
        /// <summary>Parse CPU caps from a string and update the given AV_CPU_* flags based on that.</summary>
        public static int av_parse_cpu_caps(uint* @flags, [MarshalAs(UnmanagedType.LPStr)] string @s)
        {
            return av_parse_cpu_caps_fptr(@flags, @s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_parse_cpu_flags_delegate([MarshalAs(UnmanagedType.LPStr)] string @s);
        private static av_parse_cpu_flags_delegate av_parse_cpu_flags_fptr = (string @s) =>
        {
            av_parse_cpu_flags_fptr = GetFunctionDelegate<av_parse_cpu_flags_delegate>(GetOrLoadLibrary("avutil", 55), "av_parse_cpu_flags");
            if (av_parse_cpu_flags_fptr == null)
            {
                av_parse_cpu_flags_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_parse_cpu_flags is not supported on this platform.");
                };
            }
            return av_parse_cpu_flags_fptr(@s);
        };
        /// <summary>Parse CPU flags from a string.</summary>
        [Obsolete("")]
        public static int av_parse_cpu_flags([MarshalAs(UnmanagedType.LPStr)] string @s)
        {
            return av_parse_cpu_flags_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_pix_fmt_count_planes_delegate(AVPixelFormat @pix_fmt);
        private static av_pix_fmt_count_planes_delegate av_pix_fmt_count_planes_fptr = (AVPixelFormat @pix_fmt) =>
        {
            av_pix_fmt_count_planes_fptr = GetFunctionDelegate<av_pix_fmt_count_planes_delegate>(GetOrLoadLibrary("avutil", 55), "av_pix_fmt_count_planes");
            if (av_pix_fmt_count_planes_fptr == null)
            {
                av_pix_fmt_count_planes_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pix_fmt_count_planes is not supported on this platform.");
                };
            }
            return av_pix_fmt_count_planes_fptr(@pix_fmt);
        };
        /// <summary>Returns number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a valid pixel format.</summary>
        public static int av_pix_fmt_count_planes(AVPixelFormat @pix_fmt)
        {
            return av_pix_fmt_count_planes_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixFmtDescriptor* av_pix_fmt_desc_get_delegate(AVPixelFormat @pix_fmt);
        private static av_pix_fmt_desc_get_delegate av_pix_fmt_desc_get_fptr = (AVPixelFormat @pix_fmt) =>
        {
            av_pix_fmt_desc_get_fptr = GetFunctionDelegate<av_pix_fmt_desc_get_delegate>(GetOrLoadLibrary("avutil", 55), "av_pix_fmt_desc_get");
            if (av_pix_fmt_desc_get_fptr == null)
            {
                av_pix_fmt_desc_get_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pix_fmt_desc_get is not supported on this platform.");
                };
            }
            return av_pix_fmt_desc_get_fptr(@pix_fmt);
        };
        /// <summary>Returns a pixel format descriptor for provided pixel format or NULL if this pixel format is unknown.</summary>
        public static AVPixFmtDescriptor* av_pix_fmt_desc_get(AVPixelFormat @pix_fmt)
        {
            return av_pix_fmt_desc_get_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat av_pix_fmt_desc_get_id_delegate(AVPixFmtDescriptor* @desc);
        private static av_pix_fmt_desc_get_id_delegate av_pix_fmt_desc_get_id_fptr = (AVPixFmtDescriptor* @desc) =>
        {
            av_pix_fmt_desc_get_id_fptr = GetFunctionDelegate<av_pix_fmt_desc_get_id_delegate>(GetOrLoadLibrary("avutil", 55), "av_pix_fmt_desc_get_id");
            if (av_pix_fmt_desc_get_id_fptr == null)
            {
                av_pix_fmt_desc_get_id_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pix_fmt_desc_get_id is not supported on this platform.");
                };
            }
            return av_pix_fmt_desc_get_id_fptr(@desc);
        };
        /// <summary>Returns an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc is not a valid pointer to a pixel format descriptor.</summary>
        public static AVPixelFormat av_pix_fmt_desc_get_id(AVPixFmtDescriptor* @desc)
        {
            return av_pix_fmt_desc_get_id_fptr(@desc);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixFmtDescriptor* av_pix_fmt_desc_next_delegate(AVPixFmtDescriptor* @prev);
        private static av_pix_fmt_desc_next_delegate av_pix_fmt_desc_next_fptr = (AVPixFmtDescriptor* @prev) =>
        {
            av_pix_fmt_desc_next_fptr = GetFunctionDelegate<av_pix_fmt_desc_next_delegate>(GetOrLoadLibrary("avutil", 55), "av_pix_fmt_desc_next");
            if (av_pix_fmt_desc_next_fptr == null)
            {
                av_pix_fmt_desc_next_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pix_fmt_desc_next is not supported on this platform.");
                };
            }
            return av_pix_fmt_desc_next_fptr(@prev);
        };
        /// <summary>Iterate over all pixel format descriptors known to libavutil.</summary>
        /// <param name="prev">previous descriptor. NULL to get the first descriptor.</param>
        public static AVPixFmtDescriptor* av_pix_fmt_desc_next(AVPixFmtDescriptor* @prev)
        {
            return av_pix_fmt_desc_next_fptr(@prev);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_pix_fmt_get_chroma_sub_sample_delegate(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift);
        private static av_pix_fmt_get_chroma_sub_sample_delegate av_pix_fmt_get_chroma_sub_sample_fptr = (AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift) =>
        {
            av_pix_fmt_get_chroma_sub_sample_fptr = GetFunctionDelegate<av_pix_fmt_get_chroma_sub_sample_delegate>(GetOrLoadLibrary("avutil", 55), "av_pix_fmt_get_chroma_sub_sample");
            if (av_pix_fmt_get_chroma_sub_sample_fptr == null)
            {
                av_pix_fmt_get_chroma_sub_sample_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pix_fmt_get_chroma_sub_sample is not supported on this platform.");
                };
            }
            return av_pix_fmt_get_chroma_sub_sample_fptr(@pix_fmt, @h_shift, @v_shift);
        };
        /// <summary>Utility function to access log2_chroma_w log2_chroma_h from the pixel format AVPixFmtDescriptor.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        /// <param name="h_shift">store log2_chroma_w (horizontal/width shift)</param>
        /// <param name="v_shift">store log2_chroma_h (vertical/height shift)</param>
        public static int av_pix_fmt_get_chroma_sub_sample(AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift)
        {
            return av_pix_fmt_get_chroma_sub_sample_fptr(@pix_fmt, @h_shift, @v_shift);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVPixelFormat av_pix_fmt_swap_endianness_delegate(AVPixelFormat @pix_fmt);
        private static av_pix_fmt_swap_endianness_delegate av_pix_fmt_swap_endianness_fptr = (AVPixelFormat @pix_fmt) =>
        {
            av_pix_fmt_swap_endianness_fptr = GetFunctionDelegate<av_pix_fmt_swap_endianness_delegate>(GetOrLoadLibrary("avutil", 55), "av_pix_fmt_swap_endianness");
            if (av_pix_fmt_swap_endianness_fptr == null)
            {
                av_pix_fmt_swap_endianness_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_pix_fmt_swap_endianness is not supported on this platform.");
                };
            }
            return av_pix_fmt_swap_endianness_fptr(@pix_fmt);
        };
        /// <summary>Utility function to swap the endianness of a pixel format.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        public static AVPixelFormat av_pix_fmt_swap_endianness(AVPixelFormat @pix_fmt)
        {
            return av_pix_fmt_swap_endianness_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_q2intfloat_delegate(AVRational @q);
        private static av_q2intfloat_delegate av_q2intfloat_fptr = (AVRational @q) =>
        {
            av_q2intfloat_fptr = GetFunctionDelegate<av_q2intfloat_delegate>(GetOrLoadLibrary("avutil", 55), "av_q2intfloat");
            if (av_q2intfloat_fptr == null)
            {
                av_q2intfloat_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_q2intfloat is not supported on this platform.");
                };
            }
            return av_q2intfloat_fptr(@q);
        };
        /// <summary>Convert an AVRational to a IEEE 32-bit `float` expressed in fixed-point format.</summary>
        /// <param name="q">Rational to be converted</param>
        public static uint av_q2intfloat(AVRational @q)
        {
            return av_q2intfloat_fptr(@q);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_read_image_line_delegate(ushort* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component);
        private static av_read_image_line_delegate av_read_image_line_fptr = (ushort* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component) =>
        {
            av_read_image_line_fptr = GetFunctionDelegate<av_read_image_line_delegate>(GetOrLoadLibrary("avutil", 55), "av_read_image_line");
            if (av_read_image_line_fptr == null)
            {
                av_read_image_line_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_read_image_line is not supported on this platform.");
                };
            }
            av_read_image_line_fptr(@dst, ref @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
        };
        /// <summary>Read a line from an image, and write the values of the pixel format component c to dst.</summary>
        /// <param name="data">the array containing the pointers to the planes of the image</param>
        /// <param name="linesize">the array containing the linesizes of the image</param>
        /// <param name="desc">the pixel format descriptor for the image</param>
        /// <param name="x">the horizontal coordinate of the first pixel to read</param>
        /// <param name="y">the vertical coordinate of the first pixel to read</param>
        /// <param name="w">the width of the line to read, that is the number of values to write to dst</param>
        /// <param name="read_pal_component">if not zero and the format is a paletted format writes the values corresponding to the palette component c in data[1] to dst, rather than the palette indexes in data[0]. The behavior is undefined if the format is not paletted.</param>
        public static void av_read_image_line(ushort* @dst, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component)
        {
            av_read_image_line_fptr(@dst, ref @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_realloc_delegate(void* @ptr, ulong @size);
        private static av_realloc_delegate av_realloc_fptr = (void* @ptr, ulong @size) =>
        {
            av_realloc_fptr = GetFunctionDelegate<av_realloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_realloc");
            if (av_realloc_fptr == null)
            {
                av_realloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_realloc is not supported on this platform.");
                };
            }
            return av_realloc_fptr(@ptr, @size);
        };
        /// <summary>Allocate, reallocate, or free a block of memory.</summary>
        /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
        /// <param name="size">Size in bytes of the memory block to be allocated or reallocated</param>
        public static void* av_realloc(void* @ptr, ulong @size)
        {
            return av_realloc_fptr(@ptr, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_realloc_array_delegate(void* @ptr, ulong @nmemb, ulong @size);
        private static av_realloc_array_delegate av_realloc_array_fptr = (void* @ptr, ulong @nmemb, ulong @size) =>
        {
            av_realloc_array_fptr = GetFunctionDelegate<av_realloc_array_delegate>(GetOrLoadLibrary("avutil", 55), "av_realloc_array");
            if (av_realloc_array_fptr == null)
            {
                av_realloc_array_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_realloc_array is not supported on this platform.");
                };
            }
            return av_realloc_array_fptr(@ptr, @nmemb, @size);
        };
        /// <summary>Allocate, reallocate, or free an array.</summary>
        /// <param name="ptr">Pointer to a memory block already allocated with av_realloc() or `NULL`</param>
        /// <param name="nmemb">Number of elements in the array</param>
        /// <param name="size">Size of the single element of the array</param>
        public static void* av_realloc_array(void* @ptr, ulong @nmemb, ulong @size)
        {
            return av_realloc_array_fptr(@ptr, @nmemb, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* av_realloc_f_delegate(void* @ptr, ulong @nelem, ulong @elsize);
        private static av_realloc_f_delegate av_realloc_f_fptr = (void* @ptr, ulong @nelem, ulong @elsize) =>
        {
            av_realloc_f_fptr = GetFunctionDelegate<av_realloc_f_delegate>(GetOrLoadLibrary("avutil", 55), "av_realloc_f");
            if (av_realloc_f_fptr == null)
            {
                av_realloc_f_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_realloc_f is not supported on this platform.");
                };
            }
            return av_realloc_f_fptr(@ptr, @nelem, @elsize);
        };
        /// <summary>Allocate, reallocate, or free a block of memory.</summary>
        public static void* av_realloc_f(void* @ptr, ulong @nelem, ulong @elsize)
        {
            return av_realloc_f_fptr(@ptr, @nelem, @elsize);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_reallocp_delegate(void* @ptr, ulong @size);
        private static av_reallocp_delegate av_reallocp_fptr = (void* @ptr, ulong @size) =>
        {
            av_reallocp_fptr = GetFunctionDelegate<av_reallocp_delegate>(GetOrLoadLibrary("avutil", 55), "av_reallocp");
            if (av_reallocp_fptr == null)
            {
                av_reallocp_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_reallocp is not supported on this platform.");
                };
            }
            return av_reallocp_fptr(@ptr, @size);
        };
        /// <summary>Allocate, reallocate, or free a block of memory through a pointer to a pointer.</summary>
        /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
        /// <param name="size">Size in bytes for the memory block to be allocated or reallocated</param>
        public static int av_reallocp(void* @ptr, ulong @size)
        {
            return av_reallocp_fptr(@ptr, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_reallocp_array_delegate(void* @ptr, ulong @nmemb, ulong @size);
        private static av_reallocp_array_delegate av_reallocp_array_fptr = (void* @ptr, ulong @nmemb, ulong @size) =>
        {
            av_reallocp_array_fptr = GetFunctionDelegate<av_reallocp_array_delegate>(GetOrLoadLibrary("avutil", 55), "av_reallocp_array");
            if (av_reallocp_array_fptr == null)
            {
                av_reallocp_array_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_reallocp_array is not supported on this platform.");
                };
            }
            return av_reallocp_array_fptr(@ptr, @nmemb, @size);
        };
        /// <summary>Allocate, reallocate, or free an array through a pointer to a pointer.</summary>
        /// <param name="ptr">Pointer to a pointer to a memory block already allocated with av_realloc(), or a pointer to `NULL`. The pointer is updated on success, or freed on failure.</param>
        /// <param name="nmemb">Number of elements</param>
        /// <param name="size">Size of the single element</param>
        public static int av_reallocp_array(void* @ptr, ulong @nmemb, ulong @size)
        {
            return av_reallocp_array_fptr(@ptr, @nmemb, @size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_reduce_delegate(int* @dst_num, int* @dst_den, long @num, long @den, long @max);
        private static av_reduce_delegate av_reduce_fptr = (int* @dst_num, int* @dst_den, long @num, long @den, long @max) =>
        {
            av_reduce_fptr = GetFunctionDelegate<av_reduce_delegate>(GetOrLoadLibrary("avutil", 55), "av_reduce");
            if (av_reduce_fptr == null)
            {
                av_reduce_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_reduce is not supported on this platform.");
                };
            }
            return av_reduce_fptr(@dst_num, @dst_den, @num, @den, @max);
        };
        /// <summary>Reduce a fraction.</summary>
        /// <param name="dst_num">Destination numerator</param>
        /// <param name="dst_den">Destination denominator</param>
        /// <param name="num">Source numerator</param>
        /// <param name="den">Source denominator</param>
        /// <param name="max">Maximum allowed values for `dst_num` &amp; `dst_den`</param>
        public static int av_reduce(int* @dst_num, int* @dst_den, long @num, long @den, long @max)
        {
            return av_reduce_fptr(@dst_num, @dst_den, @num, @den, @max);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_rescale_delegate(long @a, long @b, long @c);
        private static av_rescale_delegate av_rescale_fptr = (long @a, long @b, long @c) =>
        {
            av_rescale_fptr = GetFunctionDelegate<av_rescale_delegate>(GetOrLoadLibrary("avutil", 55), "av_rescale");
            if (av_rescale_fptr == null)
            {
                av_rescale_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_rescale is not supported on this platform.");
                };
            }
            return av_rescale_fptr(@a, @b, @c);
        };
        /// <summary>Rescale a 64-bit integer with rounding to nearest.</summary>
        public static long av_rescale(long @a, long @b, long @c)
        {
            return av_rescale_fptr(@a, @b, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_rescale_delta_delegate(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb);
        private static av_rescale_delta_delegate av_rescale_delta_fptr = (AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb) =>
        {
            av_rescale_delta_fptr = GetFunctionDelegate<av_rescale_delta_delegate>(GetOrLoadLibrary("avutil", 55), "av_rescale_delta");
            if (av_rescale_delta_fptr == null)
            {
                av_rescale_delta_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_rescale_delta is not supported on this platform.");
                };
            }
            return av_rescale_delta_fptr(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
        };
        /// <summary>Rescale a timestamp while preserving known durations.</summary>
        /// <param name="in_tb">Input time base</param>
        /// <param name="in_ts">Input timestamp</param>
        /// <param name="fs_tb">Duration time base; typically this is finer-grained (greater) than `in_tb` and `out_tb`</param>
        /// <param name="duration">Duration till the next call to this function (i.e. duration of the current packet/frame)</param>
        /// <param name="last">Pointer to a timestamp expressed in terms of `fs_tb`, acting as a state variable</param>
        /// <param name="out_tb">Output timebase</param>
        public static long av_rescale_delta(AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb)
        {
            return av_rescale_delta_fptr(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_rescale_q_delegate(long @a, AVRational @bq, AVRational @cq);
        private static av_rescale_q_delegate av_rescale_q_fptr = (long @a, AVRational @bq, AVRational @cq) =>
        {
            av_rescale_q_fptr = GetFunctionDelegate<av_rescale_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_rescale_q");
            if (av_rescale_q_fptr == null)
            {
                av_rescale_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_rescale_q is not supported on this platform.");
                };
            }
            return av_rescale_q_fptr(@a, @bq, @cq);
        };
        /// <summary>Rescale a 64-bit integer by 2 rational numbers.</summary>
        public static long av_rescale_q(long @a, AVRational @bq, AVRational @cq)
        {
            return av_rescale_q_fptr(@a, @bq, @cq);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_rescale_q_rnd_delegate(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd);
        private static av_rescale_q_rnd_delegate av_rescale_q_rnd_fptr = (long @a, AVRational @bq, AVRational @cq, AVRounding @rnd) =>
        {
            av_rescale_q_rnd_fptr = GetFunctionDelegate<av_rescale_q_rnd_delegate>(GetOrLoadLibrary("avutil", 55), "av_rescale_q_rnd");
            if (av_rescale_q_rnd_fptr == null)
            {
                av_rescale_q_rnd_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_rescale_q_rnd is not supported on this platform.");
                };
            }
            return av_rescale_q_rnd_fptr(@a, @bq, @cq, @rnd);
        };
        /// <summary>Rescale a 64-bit integer by 2 rational numbers with specified rounding.</summary>
        public static long av_rescale_q_rnd(long @a, AVRational @bq, AVRational @cq, AVRounding @rnd)
        {
            return av_rescale_q_rnd_fptr(@a, @bq, @cq, @rnd);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long av_rescale_rnd_delegate(long @a, long @b, long @c, AVRounding @rnd);
        private static av_rescale_rnd_delegate av_rescale_rnd_fptr = (long @a, long @b, long @c, AVRounding @rnd) =>
        {
            av_rescale_rnd_fptr = GetFunctionDelegate<av_rescale_rnd_delegate>(GetOrLoadLibrary("avutil", 55), "av_rescale_rnd");
            if (av_rescale_rnd_fptr == null)
            {
                av_rescale_rnd_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_rescale_rnd is not supported on this platform.");
                };
            }
            return av_rescale_rnd_fptr(@a, @b, @c, @rnd);
        };
        /// <summary>Rescale a 64-bit integer with specified rounding.</summary>
        public static long av_rescale_rnd(long @a, long @b, long @c, AVRounding @rnd)
        {
            return av_rescale_rnd_fptr(@a, @b, @c, @rnd);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_sample_fmt_is_planar_delegate(AVSampleFormat @sample_fmt);
        private static av_sample_fmt_is_planar_delegate av_sample_fmt_is_planar_fptr = (AVSampleFormat @sample_fmt) =>
        {
            av_sample_fmt_is_planar_fptr = GetFunctionDelegate<av_sample_fmt_is_planar_delegate>(GetOrLoadLibrary("avutil", 55), "av_sample_fmt_is_planar");
            if (av_sample_fmt_is_planar_fptr == null)
            {
                av_sample_fmt_is_planar_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_sample_fmt_is_planar is not supported on this platform.");
                };
            }
            return av_sample_fmt_is_planar_fptr(@sample_fmt);
        };
        /// <summary>Check if the sample format is planar.</summary>
        /// <param name="sample_fmt">the sample format to inspect</param>
        public static int av_sample_fmt_is_planar(AVSampleFormat @sample_fmt)
        {
            return av_sample_fmt_is_planar_fptr(@sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_samples_alloc_delegate(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        private static av_samples_alloc_delegate av_samples_alloc_fptr = (byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            av_samples_alloc_fptr = GetFunctionDelegate<av_samples_alloc_delegate>(GetOrLoadLibrary("avutil", 55), "av_samples_alloc");
            if (av_samples_alloc_fptr == null)
            {
                av_samples_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_samples_alloc is not supported on this platform.");
                };
            }
            return av_samples_alloc_fptr(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        /// <summary>Allocate a samples buffer for nb_samples samples, and fill data pointers and linesize accordingly. The allocated samples buffer can be freed by using av_freep(&amp;audio_data[0]) Allocated data will be initialized to silence.</summary>
        /// <param name="audio_data">array to be filled with the pointer for each channel</param>
        /// <param name="linesize">aligned size for audio buffer(s), may be NULL</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="nb_samples">number of samples per channel</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        public static int av_samples_alloc(byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_alloc_fptr(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_samples_alloc_array_and_samples_delegate(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        private static av_samples_alloc_array_and_samples_delegate av_samples_alloc_array_and_samples_fptr = (byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            av_samples_alloc_array_and_samples_fptr = GetFunctionDelegate<av_samples_alloc_array_and_samples_delegate>(GetOrLoadLibrary("avutil", 55), "av_samples_alloc_array_and_samples");
            if (av_samples_alloc_array_and_samples_fptr == null)
            {
                av_samples_alloc_array_and_samples_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_samples_alloc_array_and_samples is not supported on this platform.");
                };
            }
            return av_samples_alloc_array_and_samples_fptr(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        /// <summary>Allocate a data pointers array, samples buffer for nb_samples samples, and fill data pointers and linesize accordingly.</summary>
        public static int av_samples_alloc_array_and_samples(byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_alloc_array_and_samples_fptr(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_samples_copy_delegate(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        private static av_samples_copy_delegate av_samples_copy_fptr = (byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) =>
        {
            av_samples_copy_fptr = GetFunctionDelegate<av_samples_copy_delegate>(GetOrLoadLibrary("avutil", 55), "av_samples_copy");
            if (av_samples_copy_fptr == null)
            {
                av_samples_copy_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_samples_copy is not supported on this platform.");
                };
            }
            return av_samples_copy_fptr(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        };
        /// <summary>Copy samples from src to dst.</summary>
        /// <param name="dst">destination array of pointers to data planes</param>
        /// <param name="src">source array of pointers to data planes</param>
        /// <param name="dst_offset">offset in samples at which the data will be written to dst</param>
        /// <param name="src_offset">offset in samples at which the data will be read from src</param>
        /// <param name="nb_samples">number of samples to be copied</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="sample_fmt">audio sample format</param>
        public static int av_samples_copy(byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
        {
            return av_samples_copy_fptr(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_samples_fill_arrays_delegate(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        private static av_samples_fill_arrays_delegate av_samples_fill_arrays_fptr = (byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            av_samples_fill_arrays_fptr = GetFunctionDelegate<av_samples_fill_arrays_delegate>(GetOrLoadLibrary("avutil", 55), "av_samples_fill_arrays");
            if (av_samples_fill_arrays_fptr == null)
            {
                av_samples_fill_arrays_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_samples_fill_arrays is not supported on this platform.");
                };
            }
            return av_samples_fill_arrays_fptr(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        /// <summary>Fill plane data pointers and linesize for samples with sample format sample_fmt.</summary>
        /// <param name="audio_data">array to be filled with the pointer for each channel</param>
        /// <param name="linesize">calculated linesize, may be NULL</param>
        /// <param name="buf">the pointer to a buffer containing the samples</param>
        /// <param name="nb_channels">the number of channels</param>
        /// <param name="nb_samples">the number of samples in a single channel</param>
        /// <param name="sample_fmt">the sample format</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        public static int av_samples_fill_arrays(byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_fill_arrays_fptr(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_samples_get_buffer_size_delegate(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align);
        private static av_samples_get_buffer_size_delegate av_samples_get_buffer_size_fptr = (int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            av_samples_get_buffer_size_fptr = GetFunctionDelegate<av_samples_get_buffer_size_delegate>(GetOrLoadLibrary("avutil", 55), "av_samples_get_buffer_size");
            if (av_samples_get_buffer_size_fptr == null)
            {
                av_samples_get_buffer_size_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_samples_get_buffer_size is not supported on this platform.");
                };
            }
            return av_samples_get_buffer_size_fptr(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        /// <summary>Get the required buffer size for the given audio parameters.</summary>
        /// <param name="linesize">calculated linesize, may be NULL</param>
        /// <param name="nb_channels">the number of channels</param>
        /// <param name="nb_samples">the number of samples in a single channel</param>
        /// <param name="sample_fmt">the sample format</param>
        /// <param name="align">buffer size alignment (0 = default, 1 = no alignment)</param>
        public static int av_samples_get_buffer_size(int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align)
        {
            return av_samples_get_buffer_size_fptr(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_samples_set_silence_delegate(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt);
        private static av_samples_set_silence_delegate av_samples_set_silence_fptr = (byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) =>
        {
            av_samples_set_silence_fptr = GetFunctionDelegate<av_samples_set_silence_delegate>(GetOrLoadLibrary("avutil", 55), "av_samples_set_silence");
            if (av_samples_set_silence_fptr == null)
            {
                av_samples_set_silence_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_samples_set_silence is not supported on this platform.");
                };
            }
            return av_samples_set_silence_fptr(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
        };
        /// <summary>Fill an audio buffer with silence.</summary>
        /// <param name="audio_data">array of pointers to data planes</param>
        /// <param name="offset">offset in samples at which to start filling</param>
        /// <param name="nb_samples">number of samples to fill</param>
        /// <param name="nb_channels">number of audio channels</param>
        /// <param name="sample_fmt">audio sample format</param>
        public static int av_samples_set_silence(byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt)
        {
            return av_samples_set_silence_fptr(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_set_cpu_flags_mask_delegate(int @mask);
        private static av_set_cpu_flags_mask_delegate av_set_cpu_flags_mask_fptr = (int @mask) =>
        {
            av_set_cpu_flags_mask_fptr = GetFunctionDelegate<av_set_cpu_flags_mask_delegate>(GetOrLoadLibrary("avutil", 55), "av_set_cpu_flags_mask");
            if (av_set_cpu_flags_mask_fptr == null)
            {
                av_set_cpu_flags_mask_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_set_cpu_flags_mask is not supported on this platform.");
                };
            }
            av_set_cpu_flags_mask_fptr(@mask);
        };
        /// <summary>Set a mask on flags returned by av_get_cpu_flags(). This function is mainly useful for testing. Please use av_force_cpu_flags() and av_get_cpu_flags() instead which are more flexible</summary>
        [Obsolete("")]
        public static void av_set_cpu_flags_mask(int @mask)
        {
            av_set_cpu_flags_mask_fptr(@mask);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_set_options_string_delegate(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep);
        private static av_set_options_string_delegate av_set_options_string_fptr = (void* @ctx, string @opts, string @key_val_sep, string @pairs_sep) =>
        {
            av_set_options_string_fptr = GetFunctionDelegate<av_set_options_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_set_options_string");
            if (av_set_options_string_fptr == null)
            {
                av_set_options_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_set_options_string is not supported on this platform.");
                };
            }
            return av_set_options_string_fptr(@ctx, @opts, @key_val_sep, @pairs_sep);
        };
        /// <summary>Parse the key/value pairs list in opts. For each key/value pair found, stores the value in the field in ctx that is named like the key. ctx must be an AVClass context, storing is done using AVOptions.</summary>
        /// <param name="opts">options string to parse, may be NULL</param>
        /// <param name="key_val_sep">a 0-terminated list of characters used to separate key from value</param>
        /// <param name="pairs_sep">a 0-terminated list of characters used to separate two pairs from each other</param>
        public static int av_set_options_string(void* @ctx, [MarshalAs(UnmanagedType.LPStr)] string @opts, [MarshalAs(UnmanagedType.LPStr)] string @key_val_sep, [MarshalAs(UnmanagedType.LPStr)] string @pairs_sep)
        {
            return av_set_options_string_fptr(@ctx, @opts, @key_val_sep, @pairs_sep);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_strdup_delegate([MarshalAs(UnmanagedType.LPStr)] string @s);
        private static av_strdup_delegate av_strdup_fptr = (string @s) =>
        {
            av_strdup_fptr = GetFunctionDelegate<av_strdup_delegate>(GetOrLoadLibrary("avutil", 55), "av_strdup");
            if (av_strdup_fptr == null)
            {
                av_strdup_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_strdup is not supported on this platform.");
                };
            }
            return av_strdup_fptr(@s);
        };
        /// <summary>Duplicate a string.</summary>
        /// <param name="s">String to be duplicated</param>
        public static byte* av_strdup([MarshalAs(UnmanagedType.LPStr)] string @s)
        {
            return av_strdup_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_strerror_delegate(int @errnum, byte* @errbuf, ulong @errbuf_size);
        private static av_strerror_delegate av_strerror_fptr = (int @errnum, byte* @errbuf, ulong @errbuf_size) =>
        {
            av_strerror_fptr = GetFunctionDelegate<av_strerror_delegate>(GetOrLoadLibrary("avutil", 55), "av_strerror");
            if (av_strerror_fptr == null)
            {
                av_strerror_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_strerror is not supported on this platform.");
                };
            }
            return av_strerror_fptr(@errnum, @errbuf, @errbuf_size);
        };
        /// <summary>Put a description of the AVERROR code errnum in errbuf. In case of failure the global variable errno is set to indicate the error. Even in case of failure av_strerror() will print a generic error message indicating the errnum provided to errbuf.</summary>
        /// <param name="errnum">error code to describe</param>
        /// <param name="errbuf">buffer to which description is written</param>
        /// <param name="errbuf_size">the size in bytes of errbuf</param>
        public static int av_strerror(int @errnum, byte* @errbuf, ulong @errbuf_size)
        {
            return av_strerror_fptr(@errnum, @errbuf, @errbuf_size);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_strndup_delegate([MarshalAs(UnmanagedType.LPStr)] string @s, ulong @len);
        private static av_strndup_delegate av_strndup_fptr = (string @s, ulong @len) =>
        {
            av_strndup_fptr = GetFunctionDelegate<av_strndup_delegate>(GetOrLoadLibrary("avutil", 55), "av_strndup");
            if (av_strndup_fptr == null)
            {
                av_strndup_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_strndup is not supported on this platform.");
                };
            }
            return av_strndup_fptr(@s, @len);
        };
        /// <summary>Duplicate a substring of a string.</summary>
        /// <param name="s">String to be duplicated</param>
        /// <param name="len">Maximum length of the resulting string (not counting the terminating byte)</param>
        public static byte* av_strndup([MarshalAs(UnmanagedType.LPStr)] string @s, ulong @len)
        {
            return av_strndup_fptr(@s, @len);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVRational av_sub_q_delegate(AVRational @b, AVRational @c);
        private static av_sub_q_delegate av_sub_q_fptr = (AVRational @b, AVRational @c) =>
        {
            av_sub_q_fptr = GetFunctionDelegate<av_sub_q_delegate>(GetOrLoadLibrary("avutil", 55), "av_sub_q");
            if (av_sub_q_fptr == null)
            {
                av_sub_q_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_sub_q is not supported on this platform.");
                };
            }
            return av_sub_q_fptr(@b, @c);
        };
        /// <summary>Subtract one rational from another.</summary>
        /// <param name="b">First rational</param>
        /// <param name="c">Second rational</param>
        public static AVRational av_sub_q(AVRational @b, AVRational @c)
        {
            return av_sub_q_fptr(@b, @c);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_timecode_adjust_ntsc_framenum2_delegate(int @framenum, int @fps);
        private static av_timecode_adjust_ntsc_framenum2_delegate av_timecode_adjust_ntsc_framenum2_fptr = (int @framenum, int @fps) =>
        {
            av_timecode_adjust_ntsc_framenum2_fptr = GetFunctionDelegate<av_timecode_adjust_ntsc_framenum2_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_adjust_ntsc_framenum2");
            if (av_timecode_adjust_ntsc_framenum2_fptr == null)
            {
                av_timecode_adjust_ntsc_framenum2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_adjust_ntsc_framenum2 is not supported on this platform.");
                };
            }
            return av_timecode_adjust_ntsc_framenum2_fptr(@framenum, @fps);
        };
        /// <summary>Adjust frame number for NTSC drop frame time code.</summary>
        /// <param name="framenum">frame number to adjust</param>
        /// <param name="fps">frame per second, 30 or 60</param>
        public static int av_timecode_adjust_ntsc_framenum2(int @framenum, int @fps)
        {
            return av_timecode_adjust_ntsc_framenum2_fptr(@framenum, @fps);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_timecode_check_frame_rate_delegate(AVRational @rate);
        private static av_timecode_check_frame_rate_delegate av_timecode_check_frame_rate_fptr = (AVRational @rate) =>
        {
            av_timecode_check_frame_rate_fptr = GetFunctionDelegate<av_timecode_check_frame_rate_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_check_frame_rate");
            if (av_timecode_check_frame_rate_fptr == null)
            {
                av_timecode_check_frame_rate_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_check_frame_rate is not supported on this platform.");
                };
            }
            return av_timecode_check_frame_rate_fptr(@rate);
        };
        /// <summary>Check if the timecode feature is available for the given frame rate</summary>
        public static int av_timecode_check_frame_rate(AVRational @rate)
        {
            return av_timecode_check_frame_rate_fptr(@rate);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint av_timecode_get_smpte_from_framenum_delegate(AVTimecode* @tc, int @framenum);
        private static av_timecode_get_smpte_from_framenum_delegate av_timecode_get_smpte_from_framenum_fptr = (AVTimecode* @tc, int @framenum) =>
        {
            av_timecode_get_smpte_from_framenum_fptr = GetFunctionDelegate<av_timecode_get_smpte_from_framenum_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_get_smpte_from_framenum");
            if (av_timecode_get_smpte_from_framenum_fptr == null)
            {
                av_timecode_get_smpte_from_framenum_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_get_smpte_from_framenum is not supported on this platform.");
                };
            }
            return av_timecode_get_smpte_from_framenum_fptr(@tc, @framenum);
        };
        /// <summary>Convert frame number to SMPTE 12M binary representation.</summary>
        /// <param name="tc">timecode data correctly initialized</param>
        /// <param name="framenum">frame number</param>
        public static uint av_timecode_get_smpte_from_framenum(AVTimecode* @tc, int @framenum)
        {
            return av_timecode_get_smpte_from_framenum_fptr(@tc, @framenum);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_timecode_init_delegate(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx);
        private static av_timecode_init_delegate av_timecode_init_fptr = (AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx) =>
        {
            av_timecode_init_fptr = GetFunctionDelegate<av_timecode_init_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_init");
            if (av_timecode_init_fptr == null)
            {
                av_timecode_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_init is not supported on this platform.");
                };
            }
            return av_timecode_init_fptr(@tc, @rate, @flags, @frame_start, @log_ctx);
        };
        /// <summary>Init a timecode struct with the passed parameters.</summary>
        /// <param name="tc">pointer to an allocated AVTimecode</param>
        /// <param name="rate">frame rate in rational form</param>
        /// <param name="flags">miscellaneous flags such as drop frame, +24 hours, ... (see AVTimecodeFlag)</param>
        /// <param name="frame_start">the first frame number</param>
        /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log)</param>
        public static int av_timecode_init(AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx)
        {
            return av_timecode_init_fptr(@tc, @rate, @flags, @frame_start, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int av_timecode_init_from_string_delegate(AVTimecode* @tc, AVRational @rate, [MarshalAs(UnmanagedType.LPStr)] string @str, void* @log_ctx);
        private static av_timecode_init_from_string_delegate av_timecode_init_from_string_fptr = (AVTimecode* @tc, AVRational @rate, string @str, void* @log_ctx) =>
        {
            av_timecode_init_from_string_fptr = GetFunctionDelegate<av_timecode_init_from_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_init_from_string");
            if (av_timecode_init_from_string_fptr == null)
            {
                av_timecode_init_from_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_init_from_string is not supported on this platform.");
                };
            }
            return av_timecode_init_from_string_fptr(@tc, @rate, @str, @log_ctx);
        };
        /// <summary>Parse timecode representation (hh:mm:ss[:;.]ff).</summary>
        /// <param name="tc">pointer to an allocated AVTimecode</param>
        /// <param name="rate">frame rate in rational form</param>
        /// <param name="str">timecode string which will determine the frame start</param>
        /// <param name="log_ctx">a pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct (used for av_log).</param>
        public static int av_timecode_init_from_string(AVTimecode* @tc, AVRational @rate, [MarshalAs(UnmanagedType.LPStr)] string @str, void* @log_ctx)
        {
            return av_timecode_init_from_string_fptr(@tc, @rate, @str, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_timecode_make_mpeg_tc_string_delegate(byte* @buf, uint @tc25bit);
        private static av_timecode_make_mpeg_tc_string_delegate av_timecode_make_mpeg_tc_string_fptr = (byte* @buf, uint @tc25bit) =>
        {
            av_timecode_make_mpeg_tc_string_fptr = GetFunctionDelegate<av_timecode_make_mpeg_tc_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_make_mpeg_tc_string");
            if (av_timecode_make_mpeg_tc_string_fptr == null)
            {
                av_timecode_make_mpeg_tc_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_make_mpeg_tc_string is not supported on this platform.");
                };
            }
            return av_timecode_make_mpeg_tc_string_fptr(@buf, @tc25bit);
        };
        /// <summary>Get the timecode string from the 25-bit timecode format (MPEG GOP format).</summary>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="tc25bit">the 25-bits timecode</param>
        public static byte* av_timecode_make_mpeg_tc_string(byte* @buf, uint @tc25bit)
        {
            return av_timecode_make_mpeg_tc_string_fptr(@buf, @tc25bit);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_timecode_make_smpte_tc_string_delegate(byte* @buf, uint @tcsmpte, int @prevent_df);
        private static av_timecode_make_smpte_tc_string_delegate av_timecode_make_smpte_tc_string_fptr = (byte* @buf, uint @tcsmpte, int @prevent_df) =>
        {
            av_timecode_make_smpte_tc_string_fptr = GetFunctionDelegate<av_timecode_make_smpte_tc_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_make_smpte_tc_string");
            if (av_timecode_make_smpte_tc_string_fptr == null)
            {
                av_timecode_make_smpte_tc_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_make_smpte_tc_string is not supported on this platform.");
                };
            }
            return av_timecode_make_smpte_tc_string_fptr(@buf, @tcsmpte, @prevent_df);
        };
        /// <summary>Get the timecode string from the SMPTE timecode format.</summary>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="tcsmpte">the 32-bit SMPTE timecode</param>
        /// <param name="prevent_df">prevent the use of a drop flag when it is known the DF bit is arbitrary</param>
        public static byte* av_timecode_make_smpte_tc_string(byte* @buf, uint @tcsmpte, int @prevent_df)
        {
            return av_timecode_make_smpte_tc_string_fptr(@buf, @tcsmpte, @prevent_df);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate byte* av_timecode_make_string_delegate(AVTimecode* @tc, byte* @buf, int @framenum);
        private static av_timecode_make_string_delegate av_timecode_make_string_fptr = (AVTimecode* @tc, byte* @buf, int @framenum) =>
        {
            av_timecode_make_string_fptr = GetFunctionDelegate<av_timecode_make_string_delegate>(GetOrLoadLibrary("avutil", 55), "av_timecode_make_string");
            if (av_timecode_make_string_fptr == null)
            {
                av_timecode_make_string_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_timecode_make_string is not supported on this platform.");
                };
            }
            return av_timecode_make_string_fptr(@tc, @buf, @framenum);
        };
        /// <summary>Load timecode string in buf.</summary>
        /// <param name="tc">timecode data correctly initialized</param>
        /// <param name="buf">destination buffer, must be at least AV_TIMECODE_STR_SIZE long</param>
        /// <param name="framenum">frame number</param>
        public static byte* av_timecode_make_string(AVTimecode* @tc, byte* @buf, int @framenum)
        {
            return av_timecode_make_string_fptr(@tc, @buf, @framenum);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string av_version_info_delegate();
        private static av_version_info_delegate av_version_info_fptr = () =>
        {
            av_version_info_fptr = GetFunctionDelegate<av_version_info_delegate>(GetOrLoadLibrary("avutil", 55), "av_version_info");
            if (av_version_info_fptr == null)
            {
                av_version_info_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_version_info is not supported on this platform.");
                };
            }
            return av_version_info_fptr();
        };
        /// <summary>Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code.</summary>
        public static string av_version_info()
        {
            return av_version_info_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_vlog_delegate(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl);
        private static av_vlog_delegate av_vlog_fptr = (void* @avcl, int @level, string @fmt, byte* @vl) =>
        {
            av_vlog_fptr = GetFunctionDelegate<av_vlog_delegate>(GetOrLoadLibrary("avutil", 55), "av_vlog");
            if (av_vlog_fptr == null)
            {
                av_vlog_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_vlog is not supported on this platform.");
                };
            }
            av_vlog_fptr(@avcl, @level, @fmt, @vl);
        };
        /// <summary>Send the specified message to the log if the level is less than or equal to the current av_log_level. By default, all logging messages are sent to stderr. This behavior can be altered by setting a different logging callback function.</summary>
        /// <param name="avcl">A pointer to an arbitrary struct of which the first field is a pointer to an AVClass struct.</param>
        /// <param name="level">The importance level of the message expressed using a</param>
        /// <param name="fmt">The format string (printf-compatible) that specifies how subsequent arguments are converted to output.</param>
        /// <param name="vl">The arguments referenced by the format string.</param>
        public static void av_vlog(void* @avcl, int @level, [MarshalAs(UnmanagedType.LPStr)] string @fmt, byte* @vl)
        {
            av_vlog_fptr(@avcl, @level, @fmt, @vl);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void av_write_image_line_delegate(ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w);
        private static av_write_image_line_delegate av_write_image_line_fptr = (ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w) =>
        {
            av_write_image_line_fptr = GetFunctionDelegate<av_write_image_line_delegate>(GetOrLoadLibrary("avutil", 55), "av_write_image_line");
            if (av_write_image_line_fptr == null)
            {
                av_write_image_line_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("av_write_image_line is not supported on this platform.");
                };
            }
            av_write_image_line_fptr(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
        };
        /// <summary>Write the values from src to the pixel format component c of an image line.</summary>
        /// <param name="src">array containing the values to write</param>
        /// <param name="data">the array containing the pointers to the planes of the image to write into. It is supposed to be zeroed.</param>
        /// <param name="linesize">the array containing the linesizes of the image</param>
        /// <param name="desc">the pixel format descriptor for the image</param>
        /// <param name="x">the horizontal coordinate of the first pixel to write</param>
        /// <param name="y">the vertical coordinate of the first pixel to write</param>
        /// <param name="w">the width of the line to write, that is the number of values to write to the image line</param>
        public static void av_write_image_line(ushort* @src, ref byte_ptrArray4 @data, int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w)
        {
            av_write_image_line_fptr(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVDictionary** avpriv_frame_get_metadatap_delegate(AVFrame* @frame);
        private static avpriv_frame_get_metadatap_delegate avpriv_frame_get_metadatap_fptr = (AVFrame* @frame) =>
        {
            avpriv_frame_get_metadatap_fptr = GetFunctionDelegate<avpriv_frame_get_metadatap_delegate>(GetOrLoadLibrary("avutil", 55), "avpriv_frame_get_metadatap");
            if (avpriv_frame_get_metadatap_fptr == null)
            {
                avpriv_frame_get_metadatap_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avpriv_frame_get_metadatap is not supported on this platform.");
                };
            }
            return avpriv_frame_get_metadatap_fptr(@frame);
        };
        public static AVDictionary** avpriv_frame_get_metadatap(AVFrame* @frame)
        {
            return avpriv_frame_get_metadatap_fptr(@frame);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avutil_configuration_delegate();
        private static avutil_configuration_delegate avutil_configuration_fptr = () =>
        {
            avutil_configuration_fptr = GetFunctionDelegate<avutil_configuration_delegate>(GetOrLoadLibrary("avutil", 55), "avutil_configuration");
            if (avutil_configuration_fptr == null)
            {
                avutil_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avutil_configuration is not supported on this platform.");
                };
            }
            return avutil_configuration_fptr();
        };
        /// <summary>Return the libavutil build-time configuration.</summary>
        public static string avutil_configuration()
        {
            return avutil_configuration_fptr();
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string avutil_license_delegate();
        private static avutil_license_delegate avutil_license_fptr = () =>
        {
            avutil_license_fptr = GetFunctionDelegate<avutil_license_delegate>(GetOrLoadLibrary("avutil", 55), "avutil_license");
            if (avutil_license_fptr == null)
            {
                avutil_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avutil_license is not supported on this platform.");
                };
            }
            return avutil_license_fptr();
        };
        /// <summary>Return the libavutil license.</summary>
        public static string avutil_license()
        {
            return avutil_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint avutil_version_delegate();
        private static avutil_version_delegate avutil_version_fptr = () =>
        {
            avutil_version_fptr = GetFunctionDelegate<avutil_version_delegate>(GetOrLoadLibrary("avutil", 55), "avutil_version");
            if (avutil_version_fptr == null)
            {
                avutil_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("avutil_version is not supported on this platform.");
                };
            }
            return avutil_version_fptr();
        };
        /// <summary>Return the LIBAVUTIL_VERSION_INT constant.</summary>
        public static uint avutil_version()
        {
            return avutil_version_fptr();
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string postproc_configuration_delegate();
        private static postproc_configuration_delegate postproc_configuration_fptr = () =>
        {
            postproc_configuration_fptr = GetFunctionDelegate<postproc_configuration_delegate>(GetOrLoadLibrary("postproc", 54), "postproc_configuration");
            if (postproc_configuration_fptr == null)
            {
                postproc_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("postproc_configuration is not supported on this platform.");
                };
            }
            return postproc_configuration_fptr();
        };
        /// <summary>Return the libpostproc build-time configuration.</summary>
        public static string postproc_configuration()
        {
            return postproc_configuration_fptr();
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string postproc_license_delegate();
        private static postproc_license_delegate postproc_license_fptr = () =>
        {
            postproc_license_fptr = GetFunctionDelegate<postproc_license_delegate>(GetOrLoadLibrary("postproc", 54), "postproc_license");
            if (postproc_license_fptr == null)
            {
                postproc_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("postproc_license is not supported on this platform.");
                };
            }
            return postproc_license_fptr();
        };
        /// <summary>Return the libpostproc license.</summary>
        public static string postproc_license()
        {
            return postproc_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint postproc_version_delegate();
        private static postproc_version_delegate postproc_version_fptr = () =>
        {
            postproc_version_fptr = GetFunctionDelegate<postproc_version_delegate>(GetOrLoadLibrary("postproc", 54), "postproc_version");
            if (postproc_version_fptr == null)
            {
                postproc_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("postproc_version is not supported on this platform.");
                };
            }
            return postproc_version_fptr();
        };
        /// <summary>Return the LIBPOSTPROC_VERSION_INT constant.</summary>
        public static uint postproc_version()
        {
            return postproc_version_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void pp_free_context_delegate(void* @ppContext);
        private static pp_free_context_delegate pp_free_context_fptr = (void* @ppContext) =>
        {
            pp_free_context_fptr = GetFunctionDelegate<pp_free_context_delegate>(GetOrLoadLibrary("postproc", 54), "pp_free_context");
            if (pp_free_context_fptr == null)
            {
                pp_free_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("pp_free_context is not supported on this platform.");
                };
            }
            pp_free_context_fptr(@ppContext);
        };
        public static void pp_free_context(void* @ppContext)
        {
            pp_free_context_fptr(@ppContext);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void pp_free_mode_delegate(void* @mode);
        private static pp_free_mode_delegate pp_free_mode_fptr = (void* @mode) =>
        {
            pp_free_mode_fptr = GetFunctionDelegate<pp_free_mode_delegate>(GetOrLoadLibrary("postproc", 54), "pp_free_mode");
            if (pp_free_mode_fptr == null)
            {
                pp_free_mode_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("pp_free_mode is not supported on this platform.");
                };
            }
            pp_free_mode_fptr(@mode);
        };
        public static void pp_free_mode(void* @mode)
        {
            pp_free_mode_fptr(@mode);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* pp_get_context_delegate(int @width, int @height, int @flags);
        private static pp_get_context_delegate pp_get_context_fptr = (int @width, int @height, int @flags) =>
        {
            pp_get_context_fptr = GetFunctionDelegate<pp_get_context_delegate>(GetOrLoadLibrary("postproc", 54), "pp_get_context");
            if (pp_get_context_fptr == null)
            {
                pp_get_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("pp_get_context is not supported on this platform.");
                };
            }
            return pp_get_context_fptr(@width, @height, @flags);
        };
        public static void* pp_get_context(int @width, int @height, int @flags)
        {
            return pp_get_context_fptr(@width, @height, @flags);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void* pp_get_mode_by_name_and_quality_delegate([MarshalAs(UnmanagedType.LPStr)] string @name, int @quality);
        private static pp_get_mode_by_name_and_quality_delegate pp_get_mode_by_name_and_quality_fptr = (string @name, int @quality) =>
        {
            pp_get_mode_by_name_and_quality_fptr = GetFunctionDelegate<pp_get_mode_by_name_and_quality_delegate>(GetOrLoadLibrary("postproc", 54), "pp_get_mode_by_name_and_quality");
            if (pp_get_mode_by_name_and_quality_fptr == null)
            {
                pp_get_mode_by_name_and_quality_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("pp_get_mode_by_name_and_quality is not supported on this platform.");
                };
            }
            return pp_get_mode_by_name_and_quality_fptr(@name, @quality);
        };
        /// <summary>Return a pp_mode or NULL if an error occurred.</summary>
        /// <param name="name">the string after &quot;-pp&quot; on the command line</param>
        /// <param name="quality">a number from 0 to PP_QUALITY_MAX</param>
        public static void* pp_get_mode_by_name_and_quality([MarshalAs(UnmanagedType.LPStr)] string @name, int @quality)
        {
            return pp_get_mode_by_name_and_quality_fptr(@name, @quality);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void pp_postprocess_delegate(ref byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type);
        private static pp_postprocess_delegate pp_postprocess_fptr = (ref byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type) =>
        {
            pp_postprocess_fptr = GetFunctionDelegate<pp_postprocess_delegate>(GetOrLoadLibrary("postproc", 54), "pp_postprocess");
            if (pp_postprocess_fptr == null)
            {
                pp_postprocess_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("pp_postprocess is not supported on this platform.");
                };
            }
            pp_postprocess_fptr(ref @src, @srcStride, ref @dst, @dstStride, @horizontalSize, @verticalSize, @QP_store, @QP_stride, @mode, @ppContext, @pict_type);
        };
        public static void pp_postprocess(ref byte_ptrArray3 @src, int_array3 @srcStride, ref byte_ptrArray3 @dst, int_array3 @dstStride, int @horizontalSize, int @verticalSize, sbyte* @QP_store, int @QP_stride, void* @mode, void* @ppContext, int @pict_type)
        {
            pp_postprocess_fptr(ref @src, @srcStride, ref @dst, @dstStride, @horizontalSize, @verticalSize, @QP_store, @QP_stride, @mode, @ppContext, @pict_type);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwrContext* swr_alloc_delegate();
        private static swr_alloc_delegate swr_alloc_fptr = () =>
        {
            swr_alloc_fptr = GetFunctionDelegate<swr_alloc_delegate>(GetOrLoadLibrary("swresample", 2), "swr_alloc");
            if (swr_alloc_fptr == null)
            {
                swr_alloc_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_alloc is not supported on this platform.");
                };
            }
            return swr_alloc_fptr();
        };
        /// <summary>Allocate SwrContext.</summary>
        public static SwrContext* swr_alloc()
        {
            return swr_alloc_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwrContext* swr_alloc_set_opts_delegate(SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx);
        private static swr_alloc_set_opts_delegate swr_alloc_set_opts_fptr = (SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx) =>
        {
            swr_alloc_set_opts_fptr = GetFunctionDelegate<swr_alloc_set_opts_delegate>(GetOrLoadLibrary("swresample", 2), "swr_alloc_set_opts");
            if (swr_alloc_set_opts_fptr == null)
            {
                swr_alloc_set_opts_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_alloc_set_opts is not supported on this platform.");
                };
            }
            return swr_alloc_set_opts_fptr(@s, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        };
        /// <summary>Allocate SwrContext if needed and set/reset common parameters.</summary>
        /// <param name="s">existing Swr context if available, or NULL if not</param>
        /// <param name="out_ch_layout">output channel layout (AV_CH_LAYOUT_*)</param>
        /// <param name="out_sample_fmt">output sample format (AV_SAMPLE_FMT_*).</param>
        /// <param name="out_sample_rate">output sample rate (frequency in Hz)</param>
        /// <param name="in_ch_layout">input channel layout (AV_CH_LAYOUT_*)</param>
        /// <param name="in_sample_fmt">input sample format (AV_SAMPLE_FMT_*).</param>
        /// <param name="in_sample_rate">input sample rate (frequency in Hz)</param>
        /// <param name="log_offset">logging level offset</param>
        /// <param name="log_ctx">parent logging context, can be NULL</param>
        public static SwrContext* swr_alloc_set_opts(SwrContext* @s, long @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, long @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx)
        {
            return swr_alloc_set_opts_fptr(@s, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_build_matrix_delegate(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx);
        private static swr_build_matrix_delegate swr_build_matrix_fptr = (ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx) =>
        {
            swr_build_matrix_fptr = GetFunctionDelegate<swr_build_matrix_delegate>(GetOrLoadLibrary("swresample", 2), "swr_build_matrix");
            if (swr_build_matrix_fptr == null)
            {
                swr_build_matrix_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_build_matrix is not supported on this platform.");
                };
            }
            return swr_build_matrix_fptr(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @rematrix_maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_ctx);
        };
        /// <summary>Generate a channel mixing matrix.</summary>
        /// <param name="in_layout">input channel layout</param>
        /// <param name="out_layout">output channel layout</param>
        /// <param name="center_mix_level">mix level for the center channel</param>
        /// <param name="surround_mix_level">mix level for the surround channel(s)</param>
        /// <param name="lfe_mix_level">mix level for the low-frequency effects channel</param>
        /// <param name="rematrix_maxval">if 1.0, coefficients will be normalized to prevent overflow. if INT_MAX, coefficients will not be normalized.</param>
        /// <param name="matrix">mixing coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o.</param>
        /// <param name="stride">distance between adjacent input channels in the matrix array</param>
        /// <param name="matrix_encoding">matrixed stereo downmix mode (e.g. dplii)</param>
        /// <param name="log_ctx">parent logging context, can be NULL</param>
        public static int swr_build_matrix(ulong @in_layout, ulong @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @rematrix_maxval, double @rematrix_volume, double* @matrix, int @stride, AVMatrixEncoding @matrix_encoding, void* @log_ctx)
        {
            return swr_build_matrix_fptr(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @rematrix_maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_ctx);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void swr_close_delegate(SwrContext* @s);
        private static swr_close_delegate swr_close_fptr = (SwrContext* @s) =>
        {
            swr_close_fptr = GetFunctionDelegate<swr_close_delegate>(GetOrLoadLibrary("swresample", 2), "swr_close");
            if (swr_close_fptr == null)
            {
                swr_close_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_close is not supported on this platform.");
                };
            }
            swr_close_fptr(@s);
        };
        /// <summary>Closes the context so that swr_is_initialized() returns 0.</summary>
        /// <param name="s">Swr context to be closed</param>
        public static void swr_close(SwrContext* @s)
        {
            swr_close_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_config_frame_delegate(SwrContext* @swr, AVFrame* @out, AVFrame* @in);
        private static swr_config_frame_delegate swr_config_frame_fptr = (SwrContext* @swr, AVFrame* @out, AVFrame* @in) =>
        {
            swr_config_frame_fptr = GetFunctionDelegate<swr_config_frame_delegate>(GetOrLoadLibrary("swresample", 2), "swr_config_frame");
            if (swr_config_frame_fptr == null)
            {
                swr_config_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_config_frame is not supported on this platform.");
                };
            }
            return swr_config_frame_fptr(@swr, @out, @in);
        };
        /// <summary>Configure or reconfigure the SwrContext using the information provided by the AVFrames.</summary>
        /// <param name="swr">audio resample context</param>
        public static int swr_config_frame(SwrContext* @swr, AVFrame* @out, AVFrame* @in)
        {
            return swr_config_frame_fptr(@swr, @out, @in);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_convert_delegate(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count);
        private static swr_convert_delegate swr_convert_fptr = (SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count) =>
        {
            swr_convert_fptr = GetFunctionDelegate<swr_convert_delegate>(GetOrLoadLibrary("swresample", 2), "swr_convert");
            if (swr_convert_fptr == null)
            {
                swr_convert_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_convert is not supported on this platform.");
                };
            }
            return swr_convert_fptr(@s, @out, @out_count, @in, @in_count);
        };
        /// <summary>Convert audio.</summary>
        /// <param name="s">allocated Swr context, with parameters set</param>
        /// <param name="out">output buffers, only the first one need be set in case of packed audio</param>
        /// <param name="out_count">amount of space available for output in samples per channel</param>
        /// <param name="in">input buffers, only the first one need to be set in case of packed audio</param>
        /// <param name="in_count">number of input samples available in one channel</param>
        public static int swr_convert(SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count)
        {
            return swr_convert_fptr(@s, @out, @out_count, @in, @in_count);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_convert_frame_delegate(SwrContext* @swr, AVFrame* @output, AVFrame* @input);
        private static swr_convert_frame_delegate swr_convert_frame_fptr = (SwrContext* @swr, AVFrame* @output, AVFrame* @input) =>
        {
            swr_convert_frame_fptr = GetFunctionDelegate<swr_convert_frame_delegate>(GetOrLoadLibrary("swresample", 2), "swr_convert_frame");
            if (swr_convert_frame_fptr == null)
            {
                swr_convert_frame_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_convert_frame is not supported on this platform.");
                };
            }
            return swr_convert_frame_fptr(@swr, @output, @input);
        };
        /// <summary>Convert the samples in the input AVFrame and write them to the output AVFrame.</summary>
        /// <param name="swr">audio resample context</param>
        /// <param name="output">output AVFrame</param>
        /// <param name="input">input AVFrame</param>
        public static int swr_convert_frame(SwrContext* @swr, AVFrame* @output, AVFrame* @input)
        {
            return swr_convert_frame_fptr(@swr, @output, @input);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_drop_output_delegate(SwrContext* @s, int @count);
        private static swr_drop_output_delegate swr_drop_output_fptr = (SwrContext* @s, int @count) =>
        {
            swr_drop_output_fptr = GetFunctionDelegate<swr_drop_output_delegate>(GetOrLoadLibrary("swresample", 2), "swr_drop_output");
            if (swr_drop_output_fptr == null)
            {
                swr_drop_output_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_drop_output is not supported on this platform.");
                };
            }
            return swr_drop_output_fptr(@s, @count);
        };
        /// <summary>Drops the specified number of output samples.</summary>
        /// <param name="s">allocated Swr context</param>
        /// <param name="count">number of samples to be dropped</param>
        public static int swr_drop_output(SwrContext* @s, int @count)
        {
            return swr_drop_output_fptr(@s, @count);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void swr_free_delegate(SwrContext** @s);
        private static swr_free_delegate swr_free_fptr = (SwrContext** @s) =>
        {
            swr_free_fptr = GetFunctionDelegate<swr_free_delegate>(GetOrLoadLibrary("swresample", 2), "swr_free");
            if (swr_free_fptr == null)
            {
                swr_free_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_free is not supported on this platform.");
                };
            }
            swr_free_fptr(@s);
        };
        /// <summary>Free the given SwrContext and set the pointer to NULL.</summary>
        /// <param name="s">a pointer to a pointer to Swr context</param>
        public static void swr_free(SwrContext** @s)
        {
            swr_free_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* swr_get_class_delegate();
        private static swr_get_class_delegate swr_get_class_fptr = () =>
        {
            swr_get_class_fptr = GetFunctionDelegate<swr_get_class_delegate>(GetOrLoadLibrary("swresample", 2), "swr_get_class");
            if (swr_get_class_fptr == null)
            {
                swr_get_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_get_class is not supported on this platform.");
                };
            }
            return swr_get_class_fptr();
        };
        /// <summary>Get the AVClass for SwrContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* swr_get_class()
        {
            return swr_get_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long swr_get_delay_delegate(SwrContext* @s, long @base);
        private static swr_get_delay_delegate swr_get_delay_fptr = (SwrContext* @s, long @base) =>
        {
            swr_get_delay_fptr = GetFunctionDelegate<swr_get_delay_delegate>(GetOrLoadLibrary("swresample", 2), "swr_get_delay");
            if (swr_get_delay_fptr == null)
            {
                swr_get_delay_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_get_delay is not supported on this platform.");
                };
            }
            return swr_get_delay_fptr(@s, @base);
        };
        /// <summary>Gets the delay the next input sample will experience relative to the next output sample.</summary>
        /// <param name="s">swr context</param>
        /// <param name="base">timebase in which the returned delay will be:</param>
        public static long swr_get_delay(SwrContext* @s, long @base)
        {
            return swr_get_delay_fptr(@s, @base);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_get_out_samples_delegate(SwrContext* @s, int @in_samples);
        private static swr_get_out_samples_delegate swr_get_out_samples_fptr = (SwrContext* @s, int @in_samples) =>
        {
            swr_get_out_samples_fptr = GetFunctionDelegate<swr_get_out_samples_delegate>(GetOrLoadLibrary("swresample", 2), "swr_get_out_samples");
            if (swr_get_out_samples_fptr == null)
            {
                swr_get_out_samples_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_get_out_samples is not supported on this platform.");
                };
            }
            return swr_get_out_samples_fptr(@s, @in_samples);
        };
        /// <summary>Find an upper bound on the number of samples that the next swr_convert call will output, if called with in_samples of input samples. This depends on the internal state, and anything changing the internal state (like further swr_convert() calls) will may change the number of samples swr_get_out_samples() returns for the same number of input samples.</summary>
        /// <param name="in_samples">number of input samples.</param>
        public static int swr_get_out_samples(SwrContext* @s, int @in_samples)
        {
            return swr_get_out_samples_fptr(@s, @in_samples);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_init_delegate(SwrContext* @s);
        private static swr_init_delegate swr_init_fptr = (SwrContext* @s) =>
        {
            swr_init_fptr = GetFunctionDelegate<swr_init_delegate>(GetOrLoadLibrary("swresample", 2), "swr_init");
            if (swr_init_fptr == null)
            {
                swr_init_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_init is not supported on this platform.");
                };
            }
            return swr_init_fptr(@s);
        };
        /// <summary>Initialize context after user parameters have been set.</summary>
        /// <param name="s">Swr context to initialize</param>
        public static int swr_init(SwrContext* @s)
        {
            return swr_init_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_inject_silence_delegate(SwrContext* @s, int @count);
        private static swr_inject_silence_delegate swr_inject_silence_fptr = (SwrContext* @s, int @count) =>
        {
            swr_inject_silence_fptr = GetFunctionDelegate<swr_inject_silence_delegate>(GetOrLoadLibrary("swresample", 2), "swr_inject_silence");
            if (swr_inject_silence_fptr == null)
            {
                swr_inject_silence_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_inject_silence is not supported on this platform.");
                };
            }
            return swr_inject_silence_fptr(@s, @count);
        };
        /// <summary>Injects the specified number of silence samples.</summary>
        /// <param name="s">allocated Swr context</param>
        /// <param name="count">number of samples to be dropped</param>
        public static int swr_inject_silence(SwrContext* @s, int @count)
        {
            return swr_inject_silence_fptr(@s, @count);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_is_initialized_delegate(SwrContext* @s);
        private static swr_is_initialized_delegate swr_is_initialized_fptr = (SwrContext* @s) =>
        {
            swr_is_initialized_fptr = GetFunctionDelegate<swr_is_initialized_delegate>(GetOrLoadLibrary("swresample", 2), "swr_is_initialized");
            if (swr_is_initialized_fptr == null)
            {
                swr_is_initialized_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_is_initialized is not supported on this platform.");
                };
            }
            return swr_is_initialized_fptr(@s);
        };
        /// <summary>Check whether an swr context has been initialized or not.</summary>
        /// <param name="s">Swr context to check</param>
        public static int swr_is_initialized(SwrContext* @s)
        {
            return swr_is_initialized_fptr(@s);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate long swr_next_pts_delegate(SwrContext* @s, long @pts);
        private static swr_next_pts_delegate swr_next_pts_fptr = (SwrContext* @s, long @pts) =>
        {
            swr_next_pts_fptr = GetFunctionDelegate<swr_next_pts_delegate>(GetOrLoadLibrary("swresample", 2), "swr_next_pts");
            if (swr_next_pts_fptr == null)
            {
                swr_next_pts_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_next_pts is not supported on this platform.");
                };
            }
            return swr_next_pts_fptr(@s, @pts);
        };
        /// <summary>Convert the next timestamp from input to output timestamps are in 1/(in_sample_rate * out_sample_rate) units.</summary>
        public static long swr_next_pts(SwrContext* @s, long @pts)
        {
            return swr_next_pts_fptr(@s, @pts);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_set_channel_mapping_delegate(SwrContext* @s, int* @channel_map);
        private static swr_set_channel_mapping_delegate swr_set_channel_mapping_fptr = (SwrContext* @s, int* @channel_map) =>
        {
            swr_set_channel_mapping_fptr = GetFunctionDelegate<swr_set_channel_mapping_delegate>(GetOrLoadLibrary("swresample", 2), "swr_set_channel_mapping");
            if (swr_set_channel_mapping_fptr == null)
            {
                swr_set_channel_mapping_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_set_channel_mapping is not supported on this platform.");
                };
            }
            return swr_set_channel_mapping_fptr(@s, @channel_map);
        };
        /// <summary>Set a customized input channel mapping.</summary>
        /// <param name="s">allocated Swr context, not yet initialized</param>
        /// <param name="channel_map">customized input channel mapping (array of channel indexes, -1 for a muted channel)</param>
        public static int swr_set_channel_mapping(SwrContext* @s, int* @channel_map)
        {
            return swr_set_channel_mapping_fptr(@s, @channel_map);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_set_compensation_delegate(SwrContext* @s, int @sample_delta, int @compensation_distance);
        private static swr_set_compensation_delegate swr_set_compensation_fptr = (SwrContext* @s, int @sample_delta, int @compensation_distance) =>
        {
            swr_set_compensation_fptr = GetFunctionDelegate<swr_set_compensation_delegate>(GetOrLoadLibrary("swresample", 2), "swr_set_compensation");
            if (swr_set_compensation_fptr == null)
            {
                swr_set_compensation_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_set_compensation is not supported on this platform.");
                };
            }
            return swr_set_compensation_fptr(@s, @sample_delta, @compensation_distance);
        };
        /// <summary>Activate resampling compensation (&quot;soft&quot; compensation). This function is internally called when needed in swr_next_pts().</summary>
        /// <param name="s">allocated Swr context. If it is not initialized, or SWR_FLAG_RESAMPLE is not set, swr_init() is called with the flag set.</param>
        /// <param name="sample_delta">delta in PTS per sample</param>
        /// <param name="compensation_distance">number of samples to compensate for</param>
        public static int swr_set_compensation(SwrContext* @s, int @sample_delta, int @compensation_distance)
        {
            return swr_set_compensation_fptr(@s, @sample_delta, @compensation_distance);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int swr_set_matrix_delegate(SwrContext* @s, double* @matrix, int @stride);
        private static swr_set_matrix_delegate swr_set_matrix_fptr = (SwrContext* @s, double* @matrix, int @stride) =>
        {
            swr_set_matrix_fptr = GetFunctionDelegate<swr_set_matrix_delegate>(GetOrLoadLibrary("swresample", 2), "swr_set_matrix");
            if (swr_set_matrix_fptr == null)
            {
                swr_set_matrix_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swr_set_matrix is not supported on this platform.");
                };
            }
            return swr_set_matrix_fptr(@s, @matrix, @stride);
        };
        /// <summary>Set a customized remix matrix.</summary>
        /// <param name="s">allocated Swr context, not yet initialized</param>
        /// <param name="matrix">remix coefficients; matrix[i + stride * o] is the weight of input channel i in output channel o</param>
        /// <param name="stride">offset between lines of the matrix</param>
        public static int swr_set_matrix(SwrContext* @s, double* @matrix, int @stride)
        {
            return swr_set_matrix_fptr(@s, @matrix, @stride);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string swresample_configuration_delegate();
        private static swresample_configuration_delegate swresample_configuration_fptr = () =>
        {
            swresample_configuration_fptr = GetFunctionDelegate<swresample_configuration_delegate>(GetOrLoadLibrary("swresample", 2), "swresample_configuration");
            if (swresample_configuration_fptr == null)
            {
                swresample_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swresample_configuration is not supported on this platform.");
                };
            }
            return swresample_configuration_fptr();
        };
        /// <summary>Return the swr build-time configuration.</summary>
        public static string swresample_configuration()
        {
            return swresample_configuration_fptr();
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string swresample_license_delegate();
        private static swresample_license_delegate swresample_license_fptr = () =>
        {
            swresample_license_fptr = GetFunctionDelegate<swresample_license_delegate>(GetOrLoadLibrary("swresample", 2), "swresample_license");
            if (swresample_license_fptr == null)
            {
                swresample_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swresample_license is not supported on this platform.");
                };
            }
            return swresample_license_fptr();
        };
        /// <summary>Return the swr license.</summary>
        public static string swresample_license()
        {
            return swresample_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint swresample_version_delegate();
        private static swresample_version_delegate swresample_version_fptr = () =>
        {
            swresample_version_fptr = GetFunctionDelegate<swresample_version_delegate>(GetOrLoadLibrary("swresample", 2), "swresample_version");
            if (swresample_version_fptr == null)
            {
                swresample_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swresample_version is not supported on this platform.");
                };
            }
            return swresample_version_fptr();
        };
        /// <summary>Return the</summary>
        public static uint swresample_version()
        {
            return swresample_version_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_addVec_delegate(SwsVector* @a, SwsVector* @b);
        private static sws_addVec_delegate sws_addVec_fptr = (SwsVector* @a, SwsVector* @b) =>
        {
            sws_addVec_fptr = GetFunctionDelegate<sws_addVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_addVec");
            if (sws_addVec_fptr == null)
            {
                sws_addVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_addVec is not supported on this platform.");
                };
            }
            sws_addVec_fptr(@a, @b);
        };
        [Obsolete("")]
        public static void sws_addVec(SwsVector* @a, SwsVector* @b)
        {
            sws_addVec_fptr(@a, @b);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsContext* sws_alloc_context_delegate();
        private static sws_alloc_context_delegate sws_alloc_context_fptr = () =>
        {
            sws_alloc_context_fptr = GetFunctionDelegate<sws_alloc_context_delegate>(GetOrLoadLibrary("swscale", 4), "sws_alloc_context");
            if (sws_alloc_context_fptr == null)
            {
                sws_alloc_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_alloc_context is not supported on this platform.");
                };
            }
            return sws_alloc_context_fptr();
        };
        /// <summary>Allocate an empty SwsContext. This must be filled and passed to sws_init_context(). For filling see AVOptions, options.c and sws_setColorspaceDetails().</summary>
        public static SwsContext* sws_alloc_context()
        {
            return sws_alloc_context_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsVector* sws_allocVec_delegate(int @length);
        private static sws_allocVec_delegate sws_allocVec_fptr = (int @length) =>
        {
            sws_allocVec_fptr = GetFunctionDelegate<sws_allocVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_allocVec");
            if (sws_allocVec_fptr == null)
            {
                sws_allocVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_allocVec is not supported on this platform.");
                };
            }
            return sws_allocVec_fptr(@length);
        };
        /// <summary>Allocate and return an uninitialized vector with length coefficients.</summary>
        public static SwsVector* sws_allocVec(int @length)
        {
            return sws_allocVec_fptr(@length);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsVector* sws_cloneVec_delegate(SwsVector* @a);
        private static sws_cloneVec_delegate sws_cloneVec_fptr = (SwsVector* @a) =>
        {
            sws_cloneVec_fptr = GetFunctionDelegate<sws_cloneVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_cloneVec");
            if (sws_cloneVec_fptr == null)
            {
                sws_cloneVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_cloneVec is not supported on this platform.");
                };
            }
            return sws_cloneVec_fptr(@a);
        };
        [Obsolete("")]
        public static SwsVector* sws_cloneVec(SwsVector* @a)
        {
            return sws_cloneVec_fptr(@a);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_convertPalette8ToPacked24_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
        private static sws_convertPalette8ToPacked24_delegate sws_convertPalette8ToPacked24_fptr = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) =>
        {
            sws_convertPalette8ToPacked24_fptr = GetFunctionDelegate<sws_convertPalette8ToPacked24_delegate>(GetOrLoadLibrary("swscale", 4), "sws_convertPalette8ToPacked24");
            if (sws_convertPalette8ToPacked24_fptr == null)
            {
                sws_convertPalette8ToPacked24_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_convertPalette8ToPacked24 is not supported on this platform.");
                };
            }
            sws_convertPalette8ToPacked24_fptr(@src, @dst, @num_pixels, @palette);
        };
        /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 24 bits.</summary>
        /// <param name="src">source frame buffer</param>
        /// <param name="dst">destination frame buffer</param>
        /// <param name="num_pixels">number of pixels to convert</param>
        /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
        public static void sws_convertPalette8ToPacked24(byte* @src, byte* @dst, int @num_pixels, byte* @palette)
        {
            sws_convertPalette8ToPacked24_fptr(@src, @dst, @num_pixels, @palette);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_convertPalette8ToPacked32_delegate(byte* @src, byte* @dst, int @num_pixels, byte* @palette);
        private static sws_convertPalette8ToPacked32_delegate sws_convertPalette8ToPacked32_fptr = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) =>
        {
            sws_convertPalette8ToPacked32_fptr = GetFunctionDelegate<sws_convertPalette8ToPacked32_delegate>(GetOrLoadLibrary("swscale", 4), "sws_convertPalette8ToPacked32");
            if (sws_convertPalette8ToPacked32_fptr == null)
            {
                sws_convertPalette8ToPacked32_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_convertPalette8ToPacked32 is not supported on this platform.");
                };
            }
            sws_convertPalette8ToPacked32_fptr(@src, @dst, @num_pixels, @palette);
        };
        /// <summary>Convert an 8-bit paletted frame into a frame with a color depth of 32 bits.</summary>
        /// <param name="src">source frame buffer</param>
        /// <param name="dst">destination frame buffer</param>
        /// <param name="num_pixels">number of pixels to convert</param>
        /// <param name="palette">array with [256] entries, which must match color arrangement (RGB or BGR) of src</param>
        public static void sws_convertPalette8ToPacked32(byte* @src, byte* @dst, int @num_pixels, byte* @palette)
        {
            sws_convertPalette8ToPacked32_fptr(@src, @dst, @num_pixels, @palette);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_convVec_delegate(SwsVector* @a, SwsVector* @b);
        private static sws_convVec_delegate sws_convVec_fptr = (SwsVector* @a, SwsVector* @b) =>
        {
            sws_convVec_fptr = GetFunctionDelegate<sws_convVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_convVec");
            if (sws_convVec_fptr == null)
            {
                sws_convVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_convVec is not supported on this platform.");
                };
            }
            sws_convVec_fptr(@a, @b);
        };
        [Obsolete("")]
        public static void sws_convVec(SwsVector* @a, SwsVector* @b)
        {
            sws_convVec_fptr(@a, @b);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_freeContext_delegate(SwsContext* @swsContext);
        private static sws_freeContext_delegate sws_freeContext_fptr = (SwsContext* @swsContext) =>
        {
            sws_freeContext_fptr = GetFunctionDelegate<sws_freeContext_delegate>(GetOrLoadLibrary("swscale", 4), "sws_freeContext");
            if (sws_freeContext_fptr == null)
            {
                sws_freeContext_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_freeContext is not supported on this platform.");
                };
            }
            sws_freeContext_fptr(@swsContext);
        };
        /// <summary>Free the swscaler context swsContext. If swsContext is NULL, then does nothing.</summary>
        public static void sws_freeContext(SwsContext* @swsContext)
        {
            sws_freeContext_fptr(@swsContext);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_freeFilter_delegate(SwsFilter* @filter);
        private static sws_freeFilter_delegate sws_freeFilter_fptr = (SwsFilter* @filter) =>
        {
            sws_freeFilter_fptr = GetFunctionDelegate<sws_freeFilter_delegate>(GetOrLoadLibrary("swscale", 4), "sws_freeFilter");
            if (sws_freeFilter_fptr == null)
            {
                sws_freeFilter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_freeFilter is not supported on this platform.");
                };
            }
            sws_freeFilter_fptr(@filter);
        };
        public static void sws_freeFilter(SwsFilter* @filter)
        {
            sws_freeFilter_fptr(@filter);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_freeVec_delegate(SwsVector* @a);
        private static sws_freeVec_delegate sws_freeVec_fptr = (SwsVector* @a) =>
        {
            sws_freeVec_fptr = GetFunctionDelegate<sws_freeVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_freeVec");
            if (sws_freeVec_fptr == null)
            {
                sws_freeVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_freeVec is not supported on this platform.");
                };
            }
            sws_freeVec_fptr(@a);
        };
        public static void sws_freeVec(SwsVector* @a)
        {
            sws_freeVec_fptr(@a);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate AVClass* sws_get_class_delegate();
        private static sws_get_class_delegate sws_get_class_fptr = () =>
        {
            sws_get_class_fptr = GetFunctionDelegate<sws_get_class_delegate>(GetOrLoadLibrary("swscale", 4), "sws_get_class");
            if (sws_get_class_fptr == null)
            {
                sws_get_class_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_get_class is not supported on this platform.");
                };
            }
            return sws_get_class_fptr();
        };
        /// <summary>Get the AVClass for swsContext. It can be used in combination with AV_OPT_SEARCH_FAKE_OBJ for examining options.</summary>
        public static AVClass* sws_get_class()
        {
            return sws_get_class_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsContext* sws_getCachedContext_delegate(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
        private static sws_getCachedContext_delegate sws_getCachedContext_fptr = (SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) =>
        {
            sws_getCachedContext_fptr = GetFunctionDelegate<sws_getCachedContext_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getCachedContext");
            if (sws_getCachedContext_fptr == null)
            {
                sws_getCachedContext_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getCachedContext is not supported on this platform.");
                };
            }
            return sws_getCachedContext_fptr(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        };
        /// <summary>Check if context can be reused, otherwise reallocate a new one.</summary>
        public static SwsContext* sws_getCachedContext(SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param)
        {
            return sws_getCachedContext_fptr(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int* sws_getCoefficients_delegate(int @colorspace);
        private static sws_getCoefficients_delegate sws_getCoefficients_fptr = (int @colorspace) =>
        {
            sws_getCoefficients_fptr = GetFunctionDelegate<sws_getCoefficients_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getCoefficients");
            if (sws_getCoefficients_fptr == null)
            {
                sws_getCoefficients_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getCoefficients is not supported on this platform.");
                };
            }
            return sws_getCoefficients_fptr(@colorspace);
        };
        /// <summary>Return a pointer to yuv&lt;-&gt;rgb coefficients for the given colorspace suitable for sws_setColorspaceDetails().</summary>
        /// <param name="colorspace">One of the SWS_CS_* macros. If invalid, SWS_CS_DEFAULT is used.</param>
        public static int* sws_getCoefficients(int @colorspace)
        {
            return sws_getCoefficients_fptr(@colorspace);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_getColorspaceDetails_delegate(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation);
        private static sws_getColorspaceDetails_delegate sws_getColorspaceDetails_fptr = (SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation) =>
        {
            sws_getColorspaceDetails_fptr = GetFunctionDelegate<sws_getColorspaceDetails_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getColorspaceDetails");
            if (sws_getColorspaceDetails_fptr == null)
            {
                sws_getColorspaceDetails_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getColorspaceDetails is not supported on this platform.");
                };
            }
            return sws_getColorspaceDetails_fptr(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        };
        /// <summary>Returns -1 if not supported</summary>
        public static int sws_getColorspaceDetails(SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation)
        {
            return sws_getColorspaceDetails_fptr(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsVector* sws_getConstVec_delegate(double @c, int @length);
        private static sws_getConstVec_delegate sws_getConstVec_fptr = (double @c, int @length) =>
        {
            sws_getConstVec_fptr = GetFunctionDelegate<sws_getConstVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getConstVec");
            if (sws_getConstVec_fptr == null)
            {
                sws_getConstVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getConstVec is not supported on this platform.");
                };
            }
            return sws_getConstVec_fptr(@c, @length);
        };
        [Obsolete("")]
        public static SwsVector* sws_getConstVec(double @c, int @length)
        {
            return sws_getConstVec_fptr(@c, @length);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsContext* sws_getContext_delegate(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param);
        private static sws_getContext_delegate sws_getContext_fptr = (int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) =>
        {
            sws_getContext_fptr = GetFunctionDelegate<sws_getContext_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getContext");
            if (sws_getContext_fptr == null)
            {
                sws_getContext_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getContext is not supported on this platform.");
                };
            }
            return sws_getContext_fptr(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        };
        /// <summary>Allocate and return an SwsContext. You need it to perform scaling/conversion operations using sws_scale().</summary>
        /// <param name="srcW">the width of the source image</param>
        /// <param name="srcH">the height of the source image</param>
        /// <param name="srcFormat">the source image format</param>
        /// <param name="dstW">the width of the destination image</param>
        /// <param name="dstH">the height of the destination image</param>
        /// <param name="dstFormat">the destination image format</param>
        /// <param name="flags">specify which algorithm and options to use for rescaling</param>
        /// <param name="param">extra parameters to tune the used scaler For SWS_BICUBIC param[0] and [1] tune the shape of the basis function, param[0] tunes f(1) and param[1] f´(1) For SWS_GAUSS param[0] tunes the exponent and thus cutoff frequency For SWS_LANCZOS param[0] tunes the width of the window function</param>
        public static SwsContext* sws_getContext(int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param)
        {
            return sws_getContext_fptr(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsFilter* sws_getDefaultFilter_delegate(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose);
        private static sws_getDefaultFilter_delegate sws_getDefaultFilter_fptr = (float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose) =>
        {
            sws_getDefaultFilter_fptr = GetFunctionDelegate<sws_getDefaultFilter_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getDefaultFilter");
            if (sws_getDefaultFilter_fptr == null)
            {
                sws_getDefaultFilter_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getDefaultFilter is not supported on this platform.");
                };
            }
            return sws_getDefaultFilter_fptr(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
        };
        public static SwsFilter* sws_getDefaultFilter(float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose)
        {
            return sws_getDefaultFilter_fptr(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsVector* sws_getGaussianVec_delegate(double @variance, double @quality);
        private static sws_getGaussianVec_delegate sws_getGaussianVec_fptr = (double @variance, double @quality) =>
        {
            sws_getGaussianVec_fptr = GetFunctionDelegate<sws_getGaussianVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getGaussianVec");
            if (sws_getGaussianVec_fptr == null)
            {
                sws_getGaussianVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getGaussianVec is not supported on this platform.");
                };
            }
            return sws_getGaussianVec_fptr(@variance, @quality);
        };
        /// <summary>Return a normalized Gaussian curve used to filter stuff quality = 3 is high quality, lower is lower quality.</summary>
        public static SwsVector* sws_getGaussianVec(double @variance, double @quality)
        {
            return sws_getGaussianVec_fptr(@variance, @quality);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate SwsVector* sws_getIdentityVec_delegate();
        private static sws_getIdentityVec_delegate sws_getIdentityVec_fptr = () =>
        {
            sws_getIdentityVec_fptr = GetFunctionDelegate<sws_getIdentityVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_getIdentityVec");
            if (sws_getIdentityVec_fptr == null)
            {
                sws_getIdentityVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_getIdentityVec is not supported on this platform.");
                };
            }
            return sws_getIdentityVec_fptr();
        };
        [Obsolete("")]
        public static SwsVector* sws_getIdentityVec()
        {
            return sws_getIdentityVec_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_init_context_delegate(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter);
        private static sws_init_context_delegate sws_init_context_fptr = (SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter) =>
        {
            sws_init_context_fptr = GetFunctionDelegate<sws_init_context_delegate>(GetOrLoadLibrary("swscale", 4), "sws_init_context");
            if (sws_init_context_fptr == null)
            {
                sws_init_context_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_init_context is not supported on this platform.");
                };
            }
            return sws_init_context_fptr(@sws_context, @srcFilter, @dstFilter);
        };
        /// <summary>Initialize the swscaler context sws_context.</summary>
        public static int sws_init_context(SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter)
        {
            return sws_init_context_fptr(@sws_context, @srcFilter, @dstFilter);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_isSupportedEndiannessConversion_delegate(AVPixelFormat @pix_fmt);
        private static sws_isSupportedEndiannessConversion_delegate sws_isSupportedEndiannessConversion_fptr = (AVPixelFormat @pix_fmt) =>
        {
            sws_isSupportedEndiannessConversion_fptr = GetFunctionDelegate<sws_isSupportedEndiannessConversion_delegate>(GetOrLoadLibrary("swscale", 4), "sws_isSupportedEndiannessConversion");
            if (sws_isSupportedEndiannessConversion_fptr == null)
            {
                sws_isSupportedEndiannessConversion_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_isSupportedEndiannessConversion is not supported on this platform.");
                };
            }
            return sws_isSupportedEndiannessConversion_fptr(@pix_fmt);
        };
        /// <summary>Returns a positive value if an endianness conversion for pix_fmt is supported, 0 otherwise.</summary>
        /// <param name="pix_fmt">the pixel format</param>
        public static int sws_isSupportedEndiannessConversion(AVPixelFormat @pix_fmt)
        {
            return sws_isSupportedEndiannessConversion_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_isSupportedInput_delegate(AVPixelFormat @pix_fmt);
        private static sws_isSupportedInput_delegate sws_isSupportedInput_fptr = (AVPixelFormat @pix_fmt) =>
        {
            sws_isSupportedInput_fptr = GetFunctionDelegate<sws_isSupportedInput_delegate>(GetOrLoadLibrary("swscale", 4), "sws_isSupportedInput");
            if (sws_isSupportedInput_fptr == null)
            {
                sws_isSupportedInput_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_isSupportedInput is not supported on this platform.");
                };
            }
            return sws_isSupportedInput_fptr(@pix_fmt);
        };
        /// <summary>Return a positive value if pix_fmt is a supported input format, 0 otherwise.</summary>
        public static int sws_isSupportedInput(AVPixelFormat @pix_fmt)
        {
            return sws_isSupportedInput_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_isSupportedOutput_delegate(AVPixelFormat @pix_fmt);
        private static sws_isSupportedOutput_delegate sws_isSupportedOutput_fptr = (AVPixelFormat @pix_fmt) =>
        {
            sws_isSupportedOutput_fptr = GetFunctionDelegate<sws_isSupportedOutput_delegate>(GetOrLoadLibrary("swscale", 4), "sws_isSupportedOutput");
            if (sws_isSupportedOutput_fptr == null)
            {
                sws_isSupportedOutput_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_isSupportedOutput is not supported on this platform.");
                };
            }
            return sws_isSupportedOutput_fptr(@pix_fmt);
        };
        /// <summary>Return a positive value if pix_fmt is a supported output format, 0 otherwise.</summary>
        public static int sws_isSupportedOutput(AVPixelFormat @pix_fmt)
        {
            return sws_isSupportedOutput_fptr(@pix_fmt);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_normalizeVec_delegate(SwsVector* @a, double @height);
        private static sws_normalizeVec_delegate sws_normalizeVec_fptr = (SwsVector* @a, double @height) =>
        {
            sws_normalizeVec_fptr = GetFunctionDelegate<sws_normalizeVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_normalizeVec");
            if (sws_normalizeVec_fptr == null)
            {
                sws_normalizeVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_normalizeVec is not supported on this platform.");
                };
            }
            sws_normalizeVec_fptr(@a, @height);
        };
        /// <summary>Scale all the coefficients of a so that their sum equals height.</summary>
        public static void sws_normalizeVec(SwsVector* @a, double @height)
        {
            sws_normalizeVec_fptr(@a, @height);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_printVec2_delegate(SwsVector* @a, AVClass* @log_ctx, int @log_level);
        private static sws_printVec2_delegate sws_printVec2_fptr = (SwsVector* @a, AVClass* @log_ctx, int @log_level) =>
        {
            sws_printVec2_fptr = GetFunctionDelegate<sws_printVec2_delegate>(GetOrLoadLibrary("swscale", 4), "sws_printVec2");
            if (sws_printVec2_fptr == null)
            {
                sws_printVec2_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_printVec2 is not supported on this platform.");
                };
            }
            sws_printVec2_fptr(@a, @log_ctx, @log_level);
        };
        [Obsolete("")]
        public static void sws_printVec2(SwsVector* @a, AVClass* @log_ctx, int @log_level)
        {
            sws_printVec2_fptr(@a, @log_ctx, @log_level);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_scale_delegate(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride);
        private static sws_scale_delegate sws_scale_fptr = (SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride) =>
        {
            sws_scale_fptr = GetFunctionDelegate<sws_scale_delegate>(GetOrLoadLibrary("swscale", 4), "sws_scale");
            if (sws_scale_fptr == null)
            {
                sws_scale_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_scale is not supported on this platform.");
                };
            }
            return sws_scale_fptr(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
        };
        /// <summary>Scale the image slice in srcSlice and put the resulting scaled slice in the image in dst. A slice is a sequence of consecutive rows in an image.</summary>
        /// <param name="c">the scaling context previously created with sws_getContext()</param>
        /// <param name="srcSlice">the array containing the pointers to the planes of the source slice</param>
        /// <param name="srcStride">the array containing the strides for each plane of the source image</param>
        /// <param name="srcSliceY">the position in the source image of the slice to process, that is the number (counted starting from zero) in the image of the first row of the slice</param>
        /// <param name="srcSliceH">the height of the source slice, that is the number of rows in the slice</param>
        /// <param name="dst">the array containing the pointers to the planes of the destination image</param>
        /// <param name="dstStride">the array containing the strides for each plane of the destination image</param>
        public static int sws_scale(SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride)
        {
            return sws_scale_fptr(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_scaleVec_delegate(SwsVector* @a, double @scalar);
        private static sws_scaleVec_delegate sws_scaleVec_fptr = (SwsVector* @a, double @scalar) =>
        {
            sws_scaleVec_fptr = GetFunctionDelegate<sws_scaleVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_scaleVec");
            if (sws_scaleVec_fptr == null)
            {
                sws_scaleVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_scaleVec is not supported on this platform.");
                };
            }
            sws_scaleVec_fptr(@a, @scalar);
        };
        /// <summary>Scale all the coefficients of a by the scalar value.</summary>
        public static void sws_scaleVec(SwsVector* @a, double @scalar)
        {
            sws_scaleVec_fptr(@a, @scalar);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int sws_setColorspaceDetails_delegate(SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation);
        private static sws_setColorspaceDetails_delegate sws_setColorspaceDetails_fptr = (SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation) =>
        {
            sws_setColorspaceDetails_fptr = GetFunctionDelegate<sws_setColorspaceDetails_delegate>(GetOrLoadLibrary("swscale", 4), "sws_setColorspaceDetails");
            if (sws_setColorspaceDetails_fptr == null)
            {
                sws_setColorspaceDetails_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_setColorspaceDetails is not supported on this platform.");
                };
            }
            return sws_setColorspaceDetails_fptr(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        };
        /// <summary>Returns -1 if not supported</summary>
        /// <param name="inv_table">the yuv2rgb coefficients describing the input yuv space, normally ff_yuv2rgb_coeffs[x]</param>
        /// <param name="srcRange">flag indicating the while-black range of the input (1=jpeg / 0=mpeg)</param>
        /// <param name="table">the yuv2rgb coefficients describing the output yuv space, normally ff_yuv2rgb_coeffs[x]</param>
        /// <param name="dstRange">flag indicating the while-black range of the output (1=jpeg / 0=mpeg)</param>
        /// <param name="brightness">16.16 fixed point brightness correction</param>
        /// <param name="contrast">16.16 fixed point contrast correction</param>
        /// <param name="saturation">16.16 fixed point saturation correction</param>
        public static int sws_setColorspaceDetails(SwsContext* @c, int_array4 @inv_table, int @srcRange, int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation)
        {
            return sws_setColorspaceDetails_fptr(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_shiftVec_delegate(SwsVector* @a, int @shift);
        private static sws_shiftVec_delegate sws_shiftVec_fptr = (SwsVector* @a, int @shift) =>
        {
            sws_shiftVec_fptr = GetFunctionDelegate<sws_shiftVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_shiftVec");
            if (sws_shiftVec_fptr == null)
            {
                sws_shiftVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_shiftVec is not supported on this platform.");
                };
            }
            sws_shiftVec_fptr(@a, @shift);
        };
        [Obsolete("")]
        public static void sws_shiftVec(SwsVector* @a, int @shift)
        {
            sws_shiftVec_fptr(@a, @shift);
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate void sws_subVec_delegate(SwsVector* @a, SwsVector* @b);
        private static sws_subVec_delegate sws_subVec_fptr = (SwsVector* @a, SwsVector* @b) =>
        {
            sws_subVec_fptr = GetFunctionDelegate<sws_subVec_delegate>(GetOrLoadLibrary("swscale", 4), "sws_subVec");
            if (sws_subVec_fptr == null)
            {
                sws_subVec_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("sws_subVec is not supported on this platform.");
                };
            }
            sws_subVec_fptr(@a, @b);
        };
        [Obsolete("")]
        public static void sws_subVec(SwsVector* @a, SwsVector* @b)
        {
            sws_subVec_fptr(@a, @b);
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string swscale_configuration_delegate();
        private static swscale_configuration_delegate swscale_configuration_fptr = () =>
        {
            swscale_configuration_fptr = GetFunctionDelegate<swscale_configuration_delegate>(GetOrLoadLibrary("swscale", 4), "swscale_configuration");
            if (swscale_configuration_fptr == null)
            {
                swscale_configuration_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swscale_configuration is not supported on this platform.");
                };
            }
            return swscale_configuration_fptr();
        };
        /// <summary>Return the libswscale build-time configuration.</summary>
        public static string swscale_configuration()
        {
            return swscale_configuration_fptr();
        }
        
        
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstCharPtrMarshaler))]
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate string swscale_license_delegate();
        private static swscale_license_delegate swscale_license_fptr = () =>
        {
            swscale_license_fptr = GetFunctionDelegate<swscale_license_delegate>(GetOrLoadLibrary("swscale", 4), "swscale_license");
            if (swscale_license_fptr == null)
            {
                swscale_license_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swscale_license is not supported on this platform.");
                };
            }
            return swscale_license_fptr();
        };
        /// <summary>Return the libswscale license.</summary>
        public static string swscale_license()
        {
            return swscale_license_fptr();
        }
        
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate uint swscale_version_delegate();
        private static swscale_version_delegate swscale_version_fptr = () =>
        {
            swscale_version_fptr = GetFunctionDelegate<swscale_version_delegate>(GetOrLoadLibrary("swscale", 4), "swscale_version");
            if (swscale_version_fptr == null)
            {
                swscale_version_fptr = delegate 
                {
                    throw new PlatformNotSupportedException("swscale_version is not supported on this platform.");
                };
            }
            return swscale_version_fptr();
        };
        /// <summary>Color conversion and scaling library.</summary>
        public static uint swscale_version()
        {
            return swscale_version_fptr();
        }
        
        
    }
}
