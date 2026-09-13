
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace MiniMax
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.BaseResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReferenceType), TypeInfoPropertyName = "VideoSubjectReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequestResolution), TypeInfoPropertyName = "VideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatus), TypeInfoPropertyName = "VideoTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTextInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateMediaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateTextInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::MiniMax.VideoTemplateMediaInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTaskStatus), TypeInfoPropertyName = "VideoTemplateTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTaskStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoSubjectReferenceType?), TypeInfoPropertyName = "NullableVideoSubjectReferenceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoGenerationRequestResolution?), TypeInfoPropertyName = "NullableVideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTaskStatus?), TypeInfoPropertyName = "NullableVideoTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MiniMax.VideoTemplateTaskStatus?), TypeInfoPropertyName = "NullableVideoTemplateTaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoSubjectReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoTemplateTextInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::MiniMax.VideoTemplateMediaInput>))]
    internal sealed partial class VideoSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::MiniMax.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::MiniMax.VideoSubjectReferenceType)

                    || typeToConvert == typeof(global::MiniMax.VideoSubjectReferenceType?)

                    || typeToConvert == typeof(global::MiniMax.VideoGenerationRequestResolution)

                    || typeToConvert == typeof(global::MiniMax.VideoGenerationRequestResolution?)

                    || typeToConvert == typeof(global::MiniMax.VideoTaskStatus)

                    || typeToConvert == typeof(global::MiniMax.VideoTaskStatus?)

                    || typeToConvert == typeof(global::MiniMax.VideoTemplateTaskStatus)

                    || typeToConvert == typeof(global::MiniMax.VideoTemplateTaskStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::MiniMax.VideoSubjectReferenceType))
                {
                    return new global::MiniMax.JsonConverters.VideoSubjectReferenceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoSubjectReferenceType?))
                {
                    return new global::MiniMax.JsonConverters.VideoSubjectReferenceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoGenerationRequestResolution))
                {
                    return new global::MiniMax.JsonConverters.VideoGenerationRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoGenerationRequestResolution?))
                {
                    return new global::MiniMax.JsonConverters.VideoGenerationRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoTaskStatus))
                {
                    return new global::MiniMax.JsonConverters.VideoTaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoTaskStatus?))
                {
                    return new global::MiniMax.JsonConverters.VideoTaskStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoTemplateTaskStatus))
                {
                    return new global::MiniMax.JsonConverters.VideoTemplateTaskStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::MiniMax.VideoTemplateTaskStatus?))
                {
                    return new global::MiniMax.JsonConverters.VideoTemplateTaskStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VideoSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}