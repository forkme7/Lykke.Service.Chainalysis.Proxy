// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.ChainalysisProxy.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class IUserDetails
    {
        /// <summary>
        /// Initializes a new instance of the IUserDetails class.
        /// </summary>
        public IUserDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IUserDetails class.
        /// </summary>
        public IUserDetails(int creationDate, int lastActivity, int scoreUpdatedDate, string userId = default(string), string comment = default(string), string score = default(string), IList<IUserExplosureDetails> exposureDetails = default(IList<IUserExplosureDetails>))
        {
            UserId = userId;
            CreationDate = creationDate;
            Comment = comment;
            LastActivity = lastActivity;
            Score = score;
            ScoreUpdatedDate = scoreUpdatedDate;
            ExposureDetails = exposureDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creationDate")]
        public int CreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastActivity")]
        public int LastActivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public string Score { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scoreUpdatedDate")]
        public int ScoreUpdatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exposureDetails")]
        public IList<IUserExplosureDetails> ExposureDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExposureDetails != null)
            {
                foreach (var element in ExposureDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
