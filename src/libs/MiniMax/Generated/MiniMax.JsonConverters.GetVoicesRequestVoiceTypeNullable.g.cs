#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetVoicesRequestVoiceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.GetVoicesRequestVoiceType?>
    {
        /// <inheritdoc />
        public override global::MiniMax.GetVoicesRequestVoiceType? Read(
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
                        return global::MiniMax.GetVoicesRequestVoiceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.GetVoicesRequestVoiceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.GetVoicesRequestVoiceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.GetVoicesRequestVoiceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MiniMax.GetVoicesRequestVoiceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
