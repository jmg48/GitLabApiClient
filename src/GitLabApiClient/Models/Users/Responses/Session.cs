using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Users.Responses
{
    public sealed record Session(
        [property: JsonProperty("email")] string Email,
        [property: JsonProperty("can_create_project")] bool CanCreateProject,
        [property: JsonProperty("bio")] string Bio,
        [property: JsonProperty("avatar_url")] string AvatarUrl,
        [property: JsonProperty("can_create_group")] bool CanCreateGroup,
        [property: JsonProperty("created_at")] DateTime CreatedAt,
        [property: JsonProperty("color_scheme_id")] int ColorSchemeId,
        [property: JsonProperty("current_sign_in_at")] string CurrentSignInAt,
        [property: JsonProperty("linkedin")] string Linkedin,
        [property: JsonProperty("skype")] string Skype,
        [property: JsonProperty("id")] int Id,
        [property: JsonProperty("is_admin")] bool IsAdmin,
        [property: JsonProperty("private_token")] string PrivateToken,
        [property: JsonProperty("name")] string Name,
        [property: JsonProperty("projects_limit")] int ProjectsLimit,
        [property: JsonProperty("twitter")] string Twitter,
        [property: JsonProperty("username")] string Username,
        [property: JsonProperty("state")] string State,
        [property: JsonProperty("two_factor_enabled")] bool TwoFactorEnabled,
        [property: JsonProperty("website_url")] string WebsiteUrl)
    {
        [JsonProperty("identities")]
        public List<Identity> Identities { get; } = new List<Identity>();
    }
}
