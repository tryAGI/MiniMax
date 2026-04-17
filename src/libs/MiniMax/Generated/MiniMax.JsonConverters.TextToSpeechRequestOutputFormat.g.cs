#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToSpeechRequestOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.TextToSpeechRequestOutputFormat>
    {
        /// <inheritdoc />
        public override global::MiniMax.TextToSpeechRequestOutputFormat Read(
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
                        return global::MiniMax.TextToSpeechRequestOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.TextToSpeechRequestOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.TextToSpeechRequestOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.TextToSpeechRequestOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MiniMax.TextToSpeechRequestOutputFormatExtensions.ToValueString(value));
        }
    }
}
