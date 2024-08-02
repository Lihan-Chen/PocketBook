using System;
using System.Collections.Generic;
using mvc4ESL.Models.BLL;

namespace PocketBook.Models.Collections
{
    public class LogList : List<Log>
    {
        public static LogList logList
        {
            get
            {
                return LogTypeManager.GetLogList();
            }
        }
    }
}