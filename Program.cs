using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace StatiqBlog {
    public class Program {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .DeployToGitHubPagesBranch("GITHUB_USERNAME", "GITHUB_REPONAME", Config.FromSetting<string>("GITHUB_TOKEN"), "web")
                .RunAsync();
    }
}
