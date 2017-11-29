﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedFeaturesUITesting
{
    public class Extensions
    {
        //URL of the homepage
        public const string homepage = "http://localhost:50298/";

        //file location of the chrome driver
        public const string chromeDriverLocation = "C:/Users/oslandt/Desktop/KensUITests/SharedFeaturesUITesting";

        //location to store screenshots in
        public const string screenshotLocation = "C:/Users/oslandt/Desktop/Screenshots";




        //for fetching the current date and time in a format that can be stored as a file name
        public static string CurrentDateTimeFileStringFormat()
        {
            string originalFormat = DateTime.Now.ToString("t");

            string finalFormat = originalFormat.Replace(":","-");

            return finalFormat;
        }
    }
}
