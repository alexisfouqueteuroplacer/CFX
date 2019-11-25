using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CFX.Structures;

namespace CFX.Production
{
    /// <summary>
    /// Used to request work order that is activated at a process
    /// endpoint. The response indicates the work order identifier
    /// <code language="none">
    /// {
    ///   "Result": {
    ///     "Result": "Success",
    ///     "ResultCode": 0,
    ///     "Message": "OK"
    ///   },
    ///   "WorkOrderIdentifier": {
    ///     "WorkOrderId": "WO1122334455",
    ///     "Batch": null
    ///   }
    /// }
    /// </code>
    /// </summary>
    public class GetActiveWorkOrderResponse : CFXMessage
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public GetActiveWorkOrderResponse()
        {
            Result = new RequestResult();
        }

        /// <summary>
        /// The result of the request
        /// </summary>
        public RequestResult Result
        {
            get;
            set;
        }

        /// <summary>
        /// The identifer of the Work Order or Work Order sub-batch
        /// </summary>
        public WorkOrderIdentifier WorkOrderIdentifier
        {
            get;
            set;
        }
    }
}
