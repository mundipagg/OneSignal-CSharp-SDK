using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    /// <summary>
    /// Errors are returned as part of http result (200 OK status code).
    /// NotificationCreateResult will contain one of the following values of ErrorResultType:
    /// <seealso cref="ErrorResultTypeEnum"/>
    /// If ErrorResultType is other than "None", you should inspect proper properties of this object to help you deside your further actions.
    /// </summary>
    public class NotificationErrorResult
    {
        /// <summary>
        /// Helps distinguish the type of NotificationCreateResult, so that you can be given a proper result information.
        /// <seealso cref="ErrorResultTypeEnum"/>
        /// </summary>
        public ErrorResultTypeEnum ErrorResultType { get; set; }

        /// <summary>
        /// Returned if some used include_player_ids are valid, and some are not.
        /// Please process these on your server and remove them from your database if you are track them.
        /// </summary>
        public string[] InvalidPlayerIds { get; set; }
    }
}
