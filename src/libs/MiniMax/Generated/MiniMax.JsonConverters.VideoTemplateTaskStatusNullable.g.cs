#nullable enable

namespace MiniMax.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoTemplateTaskStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::MiniMax.VideoTemplateTaskStatus?>
    {
        /// <inheritdoc />
        public override global::MiniMax.VideoTemplateTaskStatus? Read(
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
                        return global::MiniMax.VideoTemplateTaskStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::MiniMax.VideoTemplateTaskStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::MiniMax.VideoTemplateTaskStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::MiniMax.VideoTemplateTaskStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::MiniMax.VideoTemplateTaskStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
