using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CFX.Structures
{
    /// <summary>
    /// A structure that specifies the quantity of units for a Recipe to be produced within a Work Order.
    /// </summary>
    [JsonObject(ItemTypeNameHandling = TypeNameHandling.Auto)]

    public class WorkOrderRecipe
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public WorkOrderRecipe()
        {
        }

        /// <summary>
        /// The name of the recipe (may include full path, if applicable)
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// An optional version number, e.g. “2.0”
        /// </summary>
        public string Revision
        {
            get;
            set;
        }

        /// <summary>
        /// The quantity of units to be produced for the Recipe by the Work Order.
        /// </summary>
        public double Quantity
        {
            get;
            set;
        }
    }
}
