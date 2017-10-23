using System;
using System.Collections.Generic;
using System.Linq;

namespace HolisticWare.Net.HTTP
{
    public partial class QueryParameters
    {
        public Dictionary<string, string> Parameters
        {
            get;
            set;
        }

        public QueryParameters()
        {
            this.Parameters = null;

            return;
        }

        public QueryParameters(IDictionary<string, string> parameters)
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


        public override string ToString()
        {
            return this.ToString("F", System.Globalization.CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Formatted output
        /// F - Uri Fragment output
        /// D - DEBUG (pretty) output
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public string ToString(string format)
        {
            return this.ToString(format, System.Globalization.CultureInfo.CurrentCulture);
        }

        public string ToString(string format, System.IFormatProvider provider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "F";
            }

            if (provider == null)
            {
                provider = System.Globalization.CultureInfo.CurrentCulture;
            }

            if (null == this.Parameters)
            {
                return "";
            }

            switch (format.ToUpperInvariant())
            {
                case "F":
                case "Q":
                    string q = string.Join("&", this.Parameters?.Select(x => x.Key + "=" + x.Value));
                    return q;
                case "D":
                    System.Text.StringBuilder sbd = new System.Text.StringBuilder();
                    sbd.AppendLine($"{this.GetType().ToString()} = ");
                    sbd.AppendLine(string.Join(Environment.NewLine, this.Parameters?.Select(x => x.Key + "=" + x.Value)));
                    return sbd.ToString();
                default:
                    string msg = $"The {format} format string is not supported.";
                    throw new FormatException(string.Format(msg));
            }


        }

    }
}