// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.DataCatalog.Rest.Models
{
    using System.Linq;

    /// <summary>
    /// parameterSet property
    /// </summary>
    public partial class FunctionSchemaBodyParameterSet
    {
        /// <summary>
        /// Initializes a new instance of the FunctionSchemaBodyParameterSet
        /// class.
        /// </summary>
        public FunctionSchemaBodyParameterSet() { }

        /// <summary>
        /// Initializes a new instance of the FunctionSchemaBodyParameterSet
        /// class.
        /// </summary>
        /// <param name="parameters">parameters property</param>
        public FunctionSchemaBodyParameterSet(System.Collections.Generic.IList<Parameter> parameters = default(System.Collections.Generic.IList<Parameter>))
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Gets or sets parameters property
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IList<Parameter> Parameters { get; set; }

    }
}