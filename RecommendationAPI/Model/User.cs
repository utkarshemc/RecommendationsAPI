using Newtonsoft.Json;
using System;

namespace RecommendationAPI.Model
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonProperty("employeeLeaveDateTime")]
        public DateTime? EmployeeLeaveDateTime { get; set; }

        [JsonProperty("createdDateTime")]
        public DateTime? CreatedDateTime { get; set; }

        [JsonProperty("signInActivity")]
        public SignInActivity SignInActivity { get; set; }
    }

    // SignInActivity nested class
    public class SignInActivity
    {
        [JsonProperty("LastNonInteractiveSignInDateTime")]
        public DateTime? LastNonInteractiveSignInDateTime { get; set; }

        [JsonProperty("LastNonInteractiveSignInRequestId")]
        public string LastNonInteractiveSignInRequestId { get; set; }

        [JsonProperty("LastSignInDateTime")]
        public DateTime? LastSignInDateTime { get; set; }

        [JsonProperty("LastSignInRequestId")]
        public string LastSignInRequestId { get; set; }

        [JsonProperty("LastSuccessfulSignInDateTime")]
        public DateTime? LastSuccessfulSignInDateTime { get; set; }

        [JsonProperty("LastSuccessfulSignInRequestId")]
        public string LastSuccessfulSignInRequestId { get; set; }
    }
}