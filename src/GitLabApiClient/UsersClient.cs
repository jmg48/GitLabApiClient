using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Users.Requests;
using GitLabApiClient.Models.Users.Responses;

namespace GitLabApiClient
{
    public sealed class UsersClient : IUsersClient
    {
        private readonly GitLabHttpFacade _httpFacade;

        internal UsersClient(GitLabHttpFacade httpFacade) => _httpFacade = httpFacade;

        public async Task<IList<User>> GetAsync() => await _httpFacade.GetPagedList<User>("users");

        public async Task<User> GetAsync(string name)
        {
            Guard.NotEmpty(name, nameof(name));
            return (await _httpFacade.Get<IList<User>>($"users?username={name}")).FirstOrDefault();
        }

        public async Task<User> GetAsync(int id)
        {
            return await _httpFacade.Get<User>($"users/{id}");
        }

        public async Task<IList<User>> GetByFilterAsync(string filter)
        {
            Guard.NotEmpty(filter, nameof(filter));
            return await _httpFacade.GetPagedList<User>($"users?search={filter}");
        }

        public async Task<User> CreateAsync(CreateUserRequest request) => await _httpFacade.Post<User>("users", request);

        public async Task<User> UpdateAsync(UserId userId, UpdateUserRequest request) => await _httpFacade.Put<User>($"users/{userId}", request);

        public async Task<Session> GetCurrentSessionAsync() => await _httpFacade.Get<Session>("user");

        public async Task DeleteAsync(UserId userId) => await _httpFacade.Delete($"users/{userId}");

        public async Task<IList<Membership>> GetMembershipsAsync(UserId userId, string type = null)
        {
            string url = $"users/{userId}/memberships";

            if (!string.IsNullOrEmpty(type))
            {
                url += $"?type={type}";
            }

            return await _httpFacade.GetPagedList<Membership>(url);
        }
    }
}
