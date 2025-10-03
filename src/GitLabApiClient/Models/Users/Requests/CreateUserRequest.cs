using Newtonsoft.Json;

namespace GitLabApiClient.Models.Users.Requests
{
    /// <summary>
    /// Creates a new user.
    /// https://docs.gitlab.com/api/users/#create-a-user
    /// </summary>
    public sealed record CreateUserRequest(
        [property: JsonProperty("email")] string Email,
        [property: JsonProperty("username")] string Username,
        [property: JsonProperty("name")] string Name,
        [property: JsonProperty("password")] string Password = default,
        [property: JsonProperty("skype")] string Skype = default,
        [property: JsonProperty("linkedin")] string Linkedin = default,
        [property: JsonProperty("twitter")] string Twitter = default,
        [property: JsonProperty("website_url")] string WebSiteUrl = default,
        [property: JsonProperty("organization")] string Organization = default,
        [property: JsonProperty("projects_limit")] int? ProjectsLimit = default,
        [property: JsonProperty("extern_uid")] string ExternUid = default,
        [property: JsonProperty("provider")] string Provider = default,
        [property: JsonProperty("bio")] string Bio = default,
        [property: JsonProperty("location")] string Location = default,
        [property: JsonProperty("admin")] bool? Admin = default,
        [property: JsonProperty("can_create_group")] bool? CanCreateGroup = default,
        [property: JsonProperty("skip_confirmation")] bool? SkipConfirmation = default,
        [property: JsonProperty("external")] bool? External = default,
        [property: JsonProperty("reset_password")] bool? ResetPassword = default,
        [property: JsonProperty("force_random_password")] bool? ForceRandomPassword = default);
}
