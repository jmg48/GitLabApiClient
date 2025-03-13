using System;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Groups.Requests
{
    /// <summary>
    /// Used to add members in a group.
    /// </summary>
    /// <param name="AccessLevel"> The desired access level </param>
    /// <param name="UserId"> The UserID to add </param>
    /// <param name="ExpiresAt"> The membership expiration date. Date time string in the format YEAR-MONTH-DAY, e.g. 2016-03-11. </param>
    public sealed record AddGroupMemberRequest(
        [property:JsonProperty("access_level")] int AccessLevel,
        [property:JsonProperty("user_id")] int UserId,
        [property:JsonProperty("expires_at")] DateTime ExpiresAt = default);
}
