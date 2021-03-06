// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace SINners.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UploadClient
    {
        /// <summary>
        /// Initializes a new instance of the UploadClient class.
        /// </summary>
        public UploadClient()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UploadClient class.
        /// </summary>
        public UploadClient(System.Guid? id = default(System.Guid?), string chummerVersion = default(string), System.Guid? installationId = default(System.Guid?), string clientSecret = default(string), string userEmail = default(string))
        {
            Id = id;
            ChummerVersion = chummerVersion;
            InstallationId = installationId;
            ClientSecret = clientSecret;
            UserEmail = userEmail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chummerVersion")]
        public string ChummerVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "installationId")]
        public System.Guid? InstallationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userEmail")]
        public string UserEmail { get; set; }

    }
}
