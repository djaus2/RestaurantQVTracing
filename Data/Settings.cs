using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRestaurantQRCode.Data
{
    public static class Settings
    {
        //public const string BaseURL = "https://athsessgate.azurewebsites.net";
        public const string BaseURL = "https://localhost:5001";
        public static string baseURL = $"{BaseURL}/api/TableTraces";
        public const int ManagementPin = 137;
        public const int QrcodePin = 549;
        public const int FetchDataPin = 787;
        //Set Dev to false for deployment
        public const bool Dev = true;
        //public const bool Dev = false;
    }
}
