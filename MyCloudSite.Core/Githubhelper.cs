using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace MyCloudSite.Core
{
    public class Githubhelper
    {
        public string getCode()
        {
            return "hello";
        }

        public static IReadOnlyList<Repository> GetRepositories(string Organization)
        {
            var client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            return client.Repository.GetAllForOrg(Organization).Result;
        }
    }
}
