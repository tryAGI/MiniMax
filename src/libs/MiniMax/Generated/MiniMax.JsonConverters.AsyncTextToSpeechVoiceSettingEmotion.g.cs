#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncTextToSpeechVoiceSettingEmotionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion>
    {
        /// <inheritdoc />
        public override global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion Read(
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
                        return global::MiniMax.AsyncTextToSpeechVoiceSettingEmotionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.AsyncTextToSpeechVoiceSettingEmotion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::MiniMax.AsyncTextToSpeechVoiceSettingEmotionExtensions.ToValueString(value));
        }
    }
}
