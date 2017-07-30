namespace Gbfs.Net.v1
{
    public class AlertTime{
        /// <summary>
        /// Integer POSIX timestamp - required if container "times" key is present
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public long Start {get;set;}

        /// <summary>
        /// Integer POSIX timestamp - if there is currently no end time planned for the alert, this key can be omitted indicating that there is no currently scheduled end time for the alert
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public long End {get;set;}
    }
}