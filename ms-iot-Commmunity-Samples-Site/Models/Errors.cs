﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace msiotCommunitySamples.Models
{
    public class Errors
    {
        public string Message { get; set; } = "";
        public string Source { get; set; } = "";
        public bool LoggedInStatus { get; set; } = false;

        //public bool loggedInStatus
        //{
        //    get { return LoggedInStatus; }
        //}

        public string GetLogLink(bool loggedInStatus)
        {
            if (!LoggedInStatus)
                return "/ms_iot_Community_Samples/Login/0";
            else
                return "/ms_iot_Community_Samples/Logout/0";
        }

        public string LogLink
        {
            get {
                if (!LoggedInStatus)
                    return "/ms_iot_Community_Samples/Login/0";
                else
                    return "/ms_iot_Community_Samples/Logout/0";
            }
        }
        public string LogLabel
        {
            get
            {
                if (!LoggedInStatus)
                    return "Login";
                else
                    return "Logout";
            }
        }
    }
}