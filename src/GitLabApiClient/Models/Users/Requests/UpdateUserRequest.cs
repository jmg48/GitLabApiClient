using Newtonsoft.Json;

namespace GitLabApiClient.Models.Users.Requests
{
    public sealed record UpdateUserRequest(
        [property: JsonProperty("email")] string Email,
        [property: JsonProperty("password")] string Password,
        [property: JsonProperty("username")] string Username,
        [property: JsonProperty("name")] string Name,
        [property: JsonProperty("skype")] string Skype,
        [property: JsonProperty("linkedin")] string Linkedin,
        [property: JsonProperty("twitter")] string Twitter,
        [property: JsonProperty("website_url")] string WebSiteUrl,
        [property: JsonProperty("organization")] string Organization,
        [property: JsonProperty("projects_limit")] int? ProjectsLimit,
        [property: JsonProperty("extern_uid")] string ExternUid,
        [property: JsonProperty("provider")] string Provider,
        [property: JsonProperty("bio")] string Bio,
        [property: JsonProperty("location")] string Location,
        [property: JsonProperty("admin")] bool? Admin,
        [property: JsonProperty("can_create_group")] bool? CanCreateGroup,
        [property: JsonProperty("skip_confirmation")] bool? SkipConfirmation,
        [property: JsonProperty("external")] bool? External);
}
