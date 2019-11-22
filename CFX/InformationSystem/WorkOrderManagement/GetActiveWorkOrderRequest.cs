using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production
{
    /// <summary>
    /// Used to request work order that is activated at a process
    /// endpoint. The response indicates the work order identifier
    /// <code language="none">
    /// {
    ///   "Lane": 1,
    ///   "Stage": null,
    /// }
    /// </code>
    /// </summary>
    public class GetActiveWorkOrderRequest : CFXMessage
    {
        /// <summary>
        /// Number of the production lane (if applicable)
        /// </summary>
        public int? Lane
        {
            get;
            set;
        }

        /// <summary>
        /// An optional stage
        /// </summary>
        public Stage Stage
        {
            get;
            set;
        }
    }
}
