#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncTextToSpeechAudioSettingFormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.AsyncTextToSpeechAudioSettingFormat?>
    {
        /// <inheritdoc />
        public override global::MiniMax.AsyncTextToSpeechAudioSettingFormat? Read(
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
                        return global::MiniMax.AsyncTextToSpeechAudioSettingFormatExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.AsyncTextToSpeechAudioSettingFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.AsyncTextToSpeechAudioSettingFormat?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.AsyncTextToSpeechAudioSettingFormat? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MiniMax.AsyncTextToSpeechAudioSettingFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
