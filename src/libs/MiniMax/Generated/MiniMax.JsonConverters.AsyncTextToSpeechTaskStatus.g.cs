#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncTextToSpeechTaskStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.AsyncTextToSpeechTaskStatus>
    {
        /// <inheritdoc />
        public override global::MiniMax.AsyncTextToSpeechTaskStatus Read(
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
                        return global::MiniMax.AsyncTextToSpeechTaskStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.AsyncTextToSpeechTaskStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.AsyncTextToSpeechTaskStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.AsyncTextToSpeechTaskStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MiniMax.AsyncTextToSpeechTaskStatusExtensions.ToValueString(value));
        }
    }
}
