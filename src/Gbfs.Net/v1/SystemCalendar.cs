using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the days of operation for the system.
    /// </summary>
    /// <remarks>
    /// This file is optional.
    /// </remarks>
    public class SystemCalendar : GbfsFile<SystemCalendarData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public override SystemCalendarData Data { get; set; }
    }
}