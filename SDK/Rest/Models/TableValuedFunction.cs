// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// Functions used to generate tables
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class TableValuedFunction
    {
        /// <summary>
        /// Initializes a new instance of the TableValuedFunction class.
        /// </summary>
        public TableValuedFunction() { }

        /// <summary>
        /// Initializes a new instance of the TableValuedFunction class.
        /// </summary>
        /// <param name="name">name property</param>
        /// <param name="fromSourceSystem">fromSourceSystem property</param>
        /// <param name="containerId">containerId property</param>
        /// <param name="descriptions">Description property, used to describe
        /// assets</param>
        /// <param name="experts">The data steward of the asset</param>
        /// <param name="tags">Taging the asset</param>
        /// <param name="termTags">Taging the asset using glossary terms, this
        /// is a feature only for standard SKU</param>
        /// <param name="columnDescriptions">Descriptions of a column</param>
        /// <param name="columnTags">Tagging a column</param>
        /// <param name="columnTermTags">Tagging a column with glossary terms,
        /// this is a feature only for standard SKU </param>
        /// <param name="parameterDescriptions">Parameter descriptions</param>
        /// <param name="parameterTags">Tagging a parameter</param>
        /// <param name="parameterTermTags">Tagging a parameter with glossary
        /// terms, this is a feature only for standard SKU</param>
        public TableValuedFunction(string name, Dsl dsl, DataSource dataSource, LastRegisteredBy lastRegisteredBy, bool fromSourceSystem, System.Collections.Generic.IList<RolesItem> roles = default(System.Collections.Generic.IList<RolesItem>), double? containerId = default(double?), System.Collections.Generic.IList<Description> descriptions = default(System.Collections.Generic.IList<Description>), System.Collections.Generic.IList<Expert> experts = default(System.Collections.Generic.IList<Expert>), AccessInstruction accessInstructions = default(AccessInstruction), Documentation documentation = default(Documentation), FriendlyName friendlyName = default(FriendlyName), System.Collections.Generic.IList<Tag> tags = default(System.Collections.Generic.IList<Tag>), System.Collections.Generic.IList<TermTag> termTags = default(System.Collections.Generic.IList<TermTag>), FunctionSchema schema = default(FunctionSchema), System.Collections.Generic.IList<ColumnDescription> columnDescriptions = default(System.Collections.Generic.IList<ColumnDescription>), System.Collections.Generic.IList<ColumnTag> columnTags = default(System.Collections.Generic.IList<ColumnTag>), System.Collections.Generic.IList<ColumnTermTag> columnTermTags = default(System.Collections.Generic.IList<ColumnTermTag>), System.Collections.Generic.IList<ParameterDescription> parameterDescriptions = default(System.Collections.Generic.IList<ParameterDescription>), System.Collections.Generic.IList<ParameterTag> parameterTags = default(System.Collections.Generic.IList<ParameterTag>), System.Collections.Generic.IList<ParameterTermTag> parameterTermTags = default(System.Collections.Generic.IList<ParameterTermTag>))
        {
            Roles = roles;
            Name = name;
            Dsl = dsl;
            DataSource = dataSource;
            LastRegisteredBy = lastRegisteredBy;
            FromSourceSystem = fromSourceSystem;
            ContainerId = containerId;
            Descriptions = descriptions;
            Experts = experts;
            AccessInstructions = accessInstructions;
            Documentation = documentation;
            FriendlyName = friendlyName;
            Tags = tags;
            TermTags = termTags;
            Schema = schema;
            ColumnDescriptions = columnDescriptions;
            ColumnTags = columnTags;
            ColumnTermTags = columnTermTags;
            ParameterDescriptions = parameterDescriptions;
            ParameterTags = parameterTags;
            ParameterTermTags = parameterTermTags;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "roles")]
        public System.Collections.Generic.IList<RolesItem> Roles { get; set; }

        /// <summary>
        /// Gets or sets name property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dsl")]
        public Dsl Dsl { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dataSource")]
        public DataSource DataSource { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lastRegisteredBy")]
        public LastRegisteredBy LastRegisteredBy { get; set; }

        /// <summary>
        /// Gets or sets fromSourceSystem property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.fromSourceSystem")]
        public bool FromSourceSystem { get; set; }

        /// <summary>
        /// Gets or sets containerId property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.containerId")]
        public double? ContainerId { get; set; }

        /// <summary>
        /// Gets or sets description property, used to describe assets
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.descriptions")]
        public System.Collections.Generic.IList<Description> Descriptions { get; set; }

        /// <summary>
        /// Gets or sets the data steward of the asset
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.experts")]
        public System.Collections.Generic.IList<Expert> Experts { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.accessInstructions")]
        public AccessInstruction AccessInstructions { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.documentation")]
        public Documentation Documentation { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.friendlyName")]
        public FriendlyName FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets taging the asset
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.tags")]
        public System.Collections.Generic.IList<Tag> Tags { get; set; }

        /// <summary>
        /// Gets or sets taging the asset using glossary terms, this is a
        /// feature only for standard SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.termTags")]
        public System.Collections.Generic.IList<TermTag> TermTags { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.schema")]
        public FunctionSchema Schema { get; set; }

        /// <summary>
        /// Gets or sets descriptions of a column
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.columnDescriptions")]
        public System.Collections.Generic.IList<ColumnDescription> ColumnDescriptions { get; set; }

        /// <summary>
        /// Gets or sets tagging a column
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.columnTags")]
        public System.Collections.Generic.IList<ColumnTag> ColumnTags { get; set; }

        /// <summary>
        /// Gets or sets tagging a column with glossary terms, this is a
        /// feature only for standard SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.columnTermTags")]
        public System.Collections.Generic.IList<ColumnTermTag> ColumnTermTags { get; set; }

        /// <summary>
        /// Gets or sets parameter descriptions
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.parameterDescriptions")]
        public System.Collections.Generic.IList<ParameterDescription> ParameterDescriptions { get; set; }

        /// <summary>
        /// Gets or sets tagging a parameter
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.parameterTags")]
        public System.Collections.Generic.IList<ParameterTag> ParameterTags { get; set; }

        /// <summary>
        /// Gets or sets tagging a parameter with glossary terms, this is a
        /// feature only for standard SKU
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "annotations.parameterTermTags")]
        public System.Collections.Generic.IList<ParameterTermTag> ParameterTermTags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Dsl == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Dsl");
            }
            if (DataSource == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DataSource");
            }
            if (LastRegisteredBy == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "LastRegisteredBy");
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
            if (this.Dsl != null)
            {
                this.Dsl.Validate();
            }
            if (this.DataSource != null)
            {
                this.DataSource.Validate();
            }
            if (this.LastRegisteredBy != null)
            {
                this.LastRegisteredBy.Validate();
            }
            if (this.Descriptions != null)
            {
                foreach (var element1 in this.Descriptions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Experts != null)
            {
                foreach (var element2 in this.Experts)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (this.AccessInstructions != null)
            {
                this.AccessInstructions.Validate();
            }
            if (this.Documentation != null)
            {
                this.Documentation.Validate();
            }
            if (this.FriendlyName != null)
            {
                this.FriendlyName.Validate();
            }
            if (this.Tags != null)
            {
                foreach (var element3 in this.Tags)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (this.TermTags != null)
            {
                foreach (var element4 in this.TermTags)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (this.Schema != null)
            {
                this.Schema.Validate();
            }
            if (this.ColumnDescriptions != null)
            {
                foreach (var element5 in this.ColumnDescriptions)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
            if (this.ColumnTags != null)
            {
                foreach (var element6 in this.ColumnTags)
                {
                    if (element6 != null)
                    {
                        element6.Validate();
                    }
                }
            }
            if (this.ColumnTermTags != null)
            {
                foreach (var element7 in this.ColumnTermTags)
                {
                    if (element7 != null)
                    {
                        element7.Validate();
                    }
                }
            }
            if (this.ParameterDescriptions != null)
            {
                foreach (var element8 in this.ParameterDescriptions)
                {
                    if (element8 != null)
                    {
                        element8.Validate();
                    }
                }
            }
            if (this.ParameterTags != null)
            {
                foreach (var element9 in this.ParameterTags)
                {
                    if (element9 != null)
                    {
                        element9.Validate();
                    }
                }
            }
            if (this.ParameterTermTags != null)
            {
                foreach (var element10 in this.ParameterTermTags)
                {
                    if (element10 != null)
                    {
                        element10.Validate();
                    }
                }
            }
        }
    }
}