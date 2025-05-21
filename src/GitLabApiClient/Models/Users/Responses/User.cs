using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Users.Responses
{

    /// <summary>
    /// https://docs.gitlab.com/api/users/#as-an-administrator-1
    /// </summary>
    public sealed record User(
        [property: JsonProperty("id")] int Id,
        [property: JsonProperty("username")] string Username,
        [property: JsonProperty("email")] string Email,
        [property: JsonProperty("name")] string Name,
        [property: JsonProperty("state")] string State,
        [property: JsonProperty("locked")] string Locked,
        [property: JsonProperty("avatar_url")] string AvatarUrl,
        [property: JsonProperty("web_url")] string WebUrl,
        [property: JsonProperty("created_at")] string CreatedAt,
        [property: JsonProperty("is_admin")] bool IsAdmin,
        [property: JsonProperty("bio")] string Bio,
        [property: JsonProperty("bot")] bool Bot,
        [property: JsonProperty("location")] string Location,
        [property: JsonProperty("public_email")] string PublicEmail,
        [property: JsonProperty("skype")] string Skype,
        [property: JsonProperty("linkedin")] string Linkedin,
        [property: JsonProperty("twitter")] string Twitter,
        [property: JsonProperty("discord")] string Discord,
        [property: JsonProperty("website_url")] string WebsiteUrl,
        [property: JsonProperty("organization")] string Organization,
        [property: JsonProperty("job_title")] string JobTitle,
        [property: JsonProperty("pronouns")] string Pronouns,
        [property: JsonProperty("work_information")] string WorkInformation,
        [property: JsonProperty("followers")] int Followers,
        [property: JsonProperty("following")] int Following,
        [property: JsonProperty("local_time")] DateTime? LocalTime,
        [property: JsonProperty("is_followed")] bool IsFollowed,
        [property: JsonProperty("last_sign_in_at")] DateTime? LastSignInAt,
        [property: JsonProperty("confirmed_at")] DateTime? ConfirmedAt,
        [property: JsonProperty("theme_id")] int? ThemeId,
        [property: JsonProperty("last_activity_on")] DateTime? LastActivityOn,
        [property: JsonProperty("color_scheme_id")] int ColorSchemeId,
        [property: JsonProperty("projects_limit")] int ProjectsLimit,
        [property: JsonProperty("current_sign_in_at")] DateTime? CurrentSignInAt,
        [property: JsonProperty("note")] string Note,
        [property: JsonProperty("can_create_group")] bool CanCreateGroup,
        [property: JsonProperty("can_create_project")] bool CanCreateProject,
        [property: JsonProperty("two_factor_enabled")] bool TwoFactorEnabled,
        [property: JsonProperty("external")] bool? External,
        [property: JsonProperty("private_profile")] bool PrivateProfile,
        [property: JsonProperty("commit_email")] string CommitEmail,
        [property: JsonProperty("current_sign_in_ip")] string CurrentSignInIp,
        [property: JsonProperty("last_sign_in_ip")] string LastSignInIp,
        [property: JsonProperty("plan")] string Plan,
        [property: JsonProperty("trial")] bool Trial,
        [property: JsonProperty("sign_in_count")] int SignInCount,
        [property: JsonProperty("namespace_id")] int NamespaceId,
        [property: JsonProperty("created_by")] User CreatedBy,
        [property: JsonProperty("email_reset_offered_at")] DateTime? EmailResetOfferedAt)
    {
        [JsonProperty("identities")]
        public List<Identity> Identities { get; } = new();
    }
}
