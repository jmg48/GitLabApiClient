using System;
using Newtonsoft.Json;

namespace GitLabApiClient.Models
{
    /// <summary>
    /// https://docs.gitlab.com/api/members/
    /// </summary>
    public sealed record Member(
        [property: JsonProperty("id")] int Id,
        [property: JsonProperty("username")] string Username,
        [property: JsonProperty("name")] string Name,
        [property: JsonProperty("state")] string State,
        [property: JsonProperty("avatar_url")] string AvatarUrl,
        [property: JsonProperty("web_url")] string WebUrl,
        [property: JsonProperty("created_at")] DateTime CreatedAt,
        [property: JsonProperty("expires_at")] DateTime? ExpiresAt,
        [property: JsonProperty("access_level")] int AccessLevel);
}
