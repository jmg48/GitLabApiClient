using Newtonsoft.Json;

namespace GitLabApiClient.Models.Users.Responses
{
    public sealed record Identity(
        [property: JsonProperty("extern_uid")] string ExternUid,
        [property: JsonProperty("provider")] string Provider);
}
