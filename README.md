# GitLab.RestApiClient

Forked from [GitLabApiClient](https://www.nuget.org/packages/GitLabApiClient), which has not been updated since 2021, in order to add some newer missing features.

## Release Notes (since fork, most recent first)

### Version 2.0.1

- User date fields changed from string to DateTime
- Add CRUD methods for Project members
- Remove `Project.GetUsers()`, which isn't an API endpoint
- Use `DateTime` for `AddGroupMemberRequest.ExpiredAt`
- Add missing property `bool User.Bot`
- Use `DateTime` rather than `string` for `Project.LastActivityAt` and `User.Created_At`
- Update target framework to .NET 8
- Update Newtonsoft.Json 12.0.3 to 13.0.3 (critical security issue)

# Original Readme Content Below

_This should be useful but may be out of date as I add new features_

## Main features

- Targets .NET 8
- Fully async
- Thread safe.
- Multi core paging.
- Simple and natural to use.
- Handles URL encoding for you

## Quick start

### Authenticate

```csharp
// if you have auth token:
var client =  new GitLabClient("https://gitlab.example.com", "your_private_token");
```

```csharp
// if you want to use username & password:
var client =  new GitLabClient("https://gitlab.example.com");
await client.LoginAsync("username", "password");
```

### Use it

```csharp
// create a new issue.
await client.Issues.CreateAsync("group/project", new CreateIssueRequest("issue title"));

// list issues for a project  with specified assignee and labels.
await client.Issues.GetAsync("group/project", o => o.AssigneeId = 100 && o.Labels == new[] { "test-label" });

// create a new merge request featureBranch -> master.
await client.MergeRequests.CreateAsync("group/project", new CreateMergeRequest("featureBranch", "master", "Merge request title")
{
    Labels = new[] { "bugfix" },
    Description = "Implement feature"
});

// get a list of projects and find each project's README.
var projects = await Client.Projects.GetAsync();
foreach (var project in projects)
{
    var file = await Client.Files.GetAsync(project, filePath: "README.md", reference: project.DefaultBranch);
    var readme = file.ContentDecoded;
    // mad science goes here
}
```
