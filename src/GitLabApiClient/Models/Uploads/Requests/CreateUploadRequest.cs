using System.IO;

namespace GitLabApiClient.Models.Uploads.Requests
{
    public sealed record CreateUploadRequest(Stream Stream, string FileName);
}
