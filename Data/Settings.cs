using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableTracewithQRCode.Data
{
    public static class Settings
    {
        //public const string BaseURL = "https://athsessgate.azurewebsites.net";
        public const string BaseURL = "https://localhost:44362";
        public static string TableTracesPath = $"{BaseURL}/api/TableTraces";
        public static string RestaurantsPath = $"{BaseURL}/api/Restaurants";
        public const int ManagementPin = 137;
        public const int QrcodePin = 549;
        public const int FetchDataPin = 787;
        //Set Dev to false for deployment
        public const bool Dev = true;
        //public const bool Dev = false;
    }
}
