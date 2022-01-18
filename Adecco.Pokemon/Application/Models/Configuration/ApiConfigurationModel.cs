namespace Adecco.Pokemon.Application.Models.Configuration
{
    /// <summary>
    /// API configuration model.
    /// </summary>
    public class ApiConfigurationModel
    {
        /// <summary>
        /// Base API address.
        /// </summary>
        public string BaseAddress { get; set; }

        /// <summary>
        /// Api Version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Full address.
        /// </summary>
        public string FullAddress
        {
            get
            {
                return $"{BaseAddress}/{Version}";
            }
        }
    }
}
