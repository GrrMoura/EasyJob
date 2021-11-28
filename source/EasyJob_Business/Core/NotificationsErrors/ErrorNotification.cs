using System;
using System.Collections.Generic;
using System.Text;

namespace EasyJob_Business.Core.NotificationsErrors

{
    public class ErrorNotification
    {
        public ErrorNotification(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
