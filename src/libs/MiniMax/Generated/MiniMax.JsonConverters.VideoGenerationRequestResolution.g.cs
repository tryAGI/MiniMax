#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoGenerationRequestResolutionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.VideoGenerationRequestResolution>
    {
        /// <inheritdoc />
        public override global::MiniMax.VideoGenerationRequestResolution Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::MiniMax.VideoGenerationRequestResolutionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.VideoGenerationRequestResolution)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.VideoGenerationRequestResolution);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.VideoGenerationRequestResolution value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MiniMax.VideoGenerationRequestResolutionExtensions.ToValueString(value));
        }
    }
}
