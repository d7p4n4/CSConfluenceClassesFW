using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CSConfluenceClassesFW.GetIdByTitle
{
    public class GetIdByTitleSuccessResponse
    {
        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("_links")]
        public TemperaturesLinks Links { get; set; }
    }

    public partial class TemperaturesLinks
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }

        [JsonProperty("base")]
        public Uri Base { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("history")]
        public History History { get; set; }

        [JsonProperty("extensions")]
        public Extensions Extensions { get; set; }

        [JsonProperty("_links")]
        public ResultLinks Links { get; set; }

        [JsonProperty("_expandable")]
        public ResultExpandable Expandable { get; set; }
    }

    public partial class ResultExpandable
    {
        [JsonProperty("container")]
        public string Container { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("operations")]
        public string Operations { get; set; }

        [JsonProperty("children")]
        public string Children { get; set; }

        [JsonProperty("restrictions")]
        public string Restrictions { get; set; }

        [JsonProperty("ancestors")]
        public string Ancestors { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("descendants")]
        public string Descendants { get; set; }

        [JsonProperty("space")]
        public string Space { get; set; }
    }

    public partial class Extensions
    {
        [JsonProperty("position")]
        public string Position { get; set; }
    }

    public partial class History
    {
        [JsonProperty("latest")]
        public bool Latest { get; set; }

        [JsonProperty("createdBy")]
        public CreatedBy CreatedBy { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("_links")]
        public HistoryLinks Links { get; set; }

        [JsonProperty("_expandable")]
        public HistoryExpandable Expandable { get; set; }
    }

    public partial class CreatedBy
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userKey")]
        public string UserKey { get; set; }

        [JsonProperty("profilePicture")]
        public ProfilePicture ProfilePicture { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("_links")]
        public HistoryLinks Links { get; set; }

        [JsonProperty("_expandable")]
        public CreatedByExpandable Expandable { get; set; }
    }

    public partial class CreatedByExpandable
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class HistoryLinks
    {
        [JsonProperty("self")]
        public Uri Self { get; set; }
    }

    public partial class ProfilePicture
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }

    public partial class HistoryExpandable
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("previousVersion")]
        public string PreviousVersion { get; set; }

        [JsonProperty("contributors")]
        public string Contributors { get; set; }

        [JsonProperty("nextVersion")]
        public string NextVersion { get; set; }
    }

    public partial class ResultLinks
    {
        [JsonProperty("webui")]
        public string Webui { get; set; }

        [JsonProperty("edit")]
        public string Edit { get; set; }

        [JsonProperty("tinyui")]
        public string Tinyui { get; set; }

        [JsonProperty("self")]
        public Uri Self { get; set; }
    }
}
