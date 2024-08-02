using System;
using System.ComponentModel;
using System.Diagnostics;
using PocketBook.Models.Validation;

namespace PocketBook.Models
{
    /// <summary>
    /// The PreScheduled_FlowChange class represents a PreScheduled FlowChange that belongs to a <see cref="PreScheduled_FlowChanget"> PreScheduled_FlowChange</see>.
    /// </summary>
    [DebuggerDisplay("PreScheduled_FlowChange: {FacilName, nq} {LogTypeName, nq} {EventID, nq} - {EventID_RevNo, nq})")] // ({Type, nq})
    public class PreScheduled_FlowChange : AllEvent
    {
        public PreScheduled_FlowChange()
        { }
    }       
}