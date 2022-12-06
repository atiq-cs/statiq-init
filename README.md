### Statiq Blog Initializer
This provides a quick repository that sets you up the statiq blog to start with.

### Quict Start
Let's get started,

    git clone --recurse-submodules https://github.com/atiq-cs/statiq-template.git MyBlog

Edit using Visual Studio Code IDE,

    Push-Location MyBlog/
    Start-Process Code .

Update statiq package,

    dotnet add package Statiq.Web --prerelease

Replace the deployment code with this for running locally,

```csharp
        public class Program
        {
            public static async Task<int> Main(string[] args) =>
                await Bootstrapper
                    .Factory
                    .CreateWeb(args)
                    .RunAsync();
        }
```

To try a local run/preview, please run,

    dotnet run -- preview

Update required in following to deploy using Github Pages,
- `Program.cs`: `GITHUB_USERNAME`, `GITHUB_REPONAME`
- `settings.yml`: `Host`

Then, please run,

    dotnet run -- deploy

Surf your github pages URL to check it out!


You are all set! Keep updating and have fun blogging :)