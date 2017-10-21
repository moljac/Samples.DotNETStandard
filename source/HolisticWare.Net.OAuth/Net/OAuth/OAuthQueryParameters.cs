using System.Collections.Generic;

namespace HolisticWare.Net.Http
{
    public partial class OAuthQueryParameters
    {
        public Dictionary<string, string> Parameters
        {
            get;
            set;
        }

        public OAuthQueryParameters()
        {
            this.Parameters = null;

            return;
        }

        public OAuthQueryParameters(IDictionary<string, string> parameters)
        {
            this.Parameters = new Dictionary<string, string>(parameters);

            return;
        }

        /// <summary>
        /// Method to merge Custom OAuth parameters 
        /// (non standard flows or other protocols on top of OAuth like OpenID)
        /// </summary>
        /// <param name="parameters_custom"></param>
        /// <returns></returns>
        public Dictionary<string, string> Merge(IDictionary<string, string> parameters_custom)
        {
            Dictionary<string, string> parameters_merged = null;

            parameters_merged = new Dictionary<string, string>(this.Parameters);

            foreach(KeyValuePair<string, string> kvp in parameters_custom)
            {
                parameters_merged[kvp.Key] = kvp.Value;
            }

            this.Parameters = parameters_merged;

            return this.Parameters;
        }
    }
}