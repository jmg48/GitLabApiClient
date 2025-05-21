using Newtonsoft.Json;

namespace GitLabApiClient.Models.Users.Responses
{
    public sealed record Membership(
         [property: JsonProperty("source_id")] int SourceId,
         [property: JsonProperty("source_name")] string SourceName,
         [property: JsonProperty("source_type")] string SourceType,
         [property: JsonProperty("access_level")] string AccessLevel);
}
