// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Data previews of the asset
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Preview
    {
        /// <summary>
        /// Initializes a new instance of the Preview class.
        /// </summary>
        public Preview() { }

        /// <summary>
        /// Initializes a new instance of the Preview class.
        /// </summary>
        /// <param name="previewProperty">preview property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="key">key property</param>
        public Preview(System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, string>> previewProperty, bool fromSourceSystem, string key, System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
        {
            PreviewProperty = previewProperty;
            FromSourceSystem = fromSourceSystem;
            Key = key;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets preview property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.preview")]
        public System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, string>> PreviewProperty { get; set; }

        /// <summary>
        /// Gets or sets fromSourceSystem property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fromSourceSystem")]
        public bool FromSourceSystem { get; set; }

        /// <summary>
        /// Gets or sets key property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "roles")]
        public System.Collections.Generic.IList<RolesItem> Roles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PreviewProperty == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PreviewProperty");
            }
            if (Key == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Key");
            }
            if (this.Roles != null)
            {
                foreach (var element in this.Roles)
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