// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.ChainalysisProxy.Client.AutorestClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ITransactionInfo
    {
        /// <summary>
        /// Initializes a new instance of the ITransactionInfo class.
        /// </summary>
        public ITransactionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ITransactionInfo class.
        /// </summary>
        public ITransactionInfo(string output = default(string), string status = default(string))
        {
            Output = output;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "output")]
        public string Output { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

    }
}