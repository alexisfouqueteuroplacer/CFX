using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CFX.Structures
{
    /// <summary>
    /// Describes the dimensions of a PCB
    /// </summary>
    [JsonObject(ItemTypeNameHandling = TypeNameHandling.Auto)]
    public class PCBDimensions
    {
        public PCBDimensions()
        {
        }

        /// <summary>
        /// The PCB width
        /// </summary>
        public double Width
        {
            get;
            set;
        }

        /// <summary>
        /// The PCB height
        /// </summary>
        public double Height
        {
            get;
            set;
        }

        /// <summary>
        /// The PCB thickness
        /// </summary>
        public double Thickness
        {
            get;
            set;
        }
    }
}
