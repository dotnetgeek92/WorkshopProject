using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCEW.Util
{
    public static class AppConstants
    {
        public static class SessionKey
        {
            public const string CURRENT_USER = "CURRENT_USER";
            public const string CURRENT_USER_RIGHTS = "CURRENT_USER_RIGHTS";
        }
        public static class Messages
        {
            public const string Not_Authorized = "You are not authorized user for this action.";
            
        }
        public enum AppPages
        {
            Add_Product = 1,
            View_product = 2,
            Edit_product = 3
        }
        public enum RoleActions
        {
            InsertUpdate = 1,
            //Edit =2,
            Delete = 3,
            View = 4,
            Print = 5,
            Export = 6,
        }

    }
}
