using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.InformationSystem.WorkOrderManagement
{
    /// <summary>
    /// Sent by a process endpoint to indicate the deactivation of a work order by its identifier
    /// <code language="none">
    /// {
    ///   "WorkOrderIdentifier": {
    ///     "WorkOrderId": "WO1122334455",
    ///     "Batch": null
    ///   }
    ///   "Lane": 1,
    ///   "Stage": null,
    /// }
    /// </code>
    /// </summary>
    public class WorkOrderDeactivated : CFXMessage
    {
        /// <summary>
        /// The identifer of the Work Order or Work Order sub-batch
        /// </summary>
        public WorkOrderIdentifier WorkOrderIdentifier
        {
            get;
            set;
        }

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
