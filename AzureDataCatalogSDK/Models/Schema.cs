// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// The schema of the asset
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class Schema
    {
        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        public Schema() { }

        /// <summary>
        /// Initializes a new instance of the Schema class.
        /// </summary>
        /// <param name="columns">columns property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="sourceSchemaDescription">sourceSchemaDescription
        /// property</param>
        public Schema(System.Collections.Generic.IList<Column> columns, bool fromSourceSystem, string sourceSchemaDescription = default(string), System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>))
        {
            Columns = columns;
            SourceSchemaDescription = sourceSchemaDescription;
            FromSourceSystem = fromSourceSystem;
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets columns property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.columns")]
        public System.Collections.Generic.IList<Column> Columns { get; set; }

        /// <summary>
        /// Gets or sets sourceSchemaDescription property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sourceSchemaDescription")]
        public string SourceSchemaDescription { get; set; }

        /// <summary>
        /// Gets or sets fromSourceSystem property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fromSourceSystem")]
        public bool FromSourceSystem { get; set; }

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
            if (Columns == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Columns");
            }
            if (this.Columns != null)
            {
                foreach (var element in this.Columns)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Roles != null)
            {
                foreach (var element1 in this.Roles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}