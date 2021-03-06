// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobState
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "disabling")]
        Disabling,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "enabling")]
        Enabling,
        [EnumMember(Value = "terminating")]
        Terminating,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "deleting")]
        Deleting
    }
    internal static class JobStateEnumExtension
    {
        internal static string ToSerializedValue(this JobState? value)
        {
            return value == null ? null : ((JobState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobState value)
        {
            switch( value )
            {
                case JobState.Active:
                    return "active";
                case JobState.Disabling:
                    return "disabling";
                case JobState.Disabled:
                    return "disabled";
                case JobState.Enabling:
                    return "enabling";
                case JobState.Terminating:
                    return "terminating";
                case JobState.Completed:
                    return "completed";
                case JobState.Deleting:
                    return "deleting";
            }
            return null;
        }

        internal static JobState? ParseJobState(this string value)
        {
            switch( value )
            {
                case "active":
                    return JobState.Active;
                case "disabling":
                    return JobState.Disabling;
                case "disabled":
                    return JobState.Disabled;
                case "enabling":
                    return JobState.Enabling;
                case "terminating":
                    return JobState.Terminating;
                case "completed":
                    return JobState.Completed;
                case "deleting":
                    return JobState.Deleting;
            }
            return null;
        }
    }
}
