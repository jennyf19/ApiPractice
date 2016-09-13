using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPractice
{
    class GitHubData
    {
        public class RootObject
        {
            public string avatar_url { get; set; }
            public string bio { get; set; }
            public string blog { get; set; }
            public string company { get; set; }
            public string created_at { get; set; }
            public string email { get; set; }
            public string events_url { get; set; }
            public int followers { get; set; }
            public string followers_url { get; set; }
            public int following { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string gravatar_id { get; set; }
            public bool hireable { get; set; }
            public string html_url { get; set; }
            public int id { get; set; }
            public string location { get; set; }
            public string login { get; set; }
            public string name { get; set; }
            public string organizations_url { get; set; }
            public int public_gists { get; set; }
            public int public_repos { get; set; }
            public string received_events_url { get; set; }
            public string repos_url { get; set; }
            public bool site_admin { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string type { get; set; }
            public string updated_at { get; set; }
            public string url { get; set; }
        }
    }

    public class RootObject
    {
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("blog")]
        public string Blog { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }
        [JsonProperty("followers")]
        public int Followers { get; set; }
        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }
        [JsonProperty("following")]
        public int Following { get; set; }
        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }
        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }
        
    }
