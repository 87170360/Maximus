using System.Configuration;

namespace Maximus.Model
{
    public class DbConfig
    {
        public const string Config = "MaximusConfig";
        public const string Data = "MaximusData";
        public const string Log = "MaximusLog";
        public const int GlobalPeriodTime = 0;
        public const int PeriodTime = 0;
        public const string PersonalName = "UserId";

        public static string ConfigConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[Config].ConnectionString;
            }
        }

        public static string DataConnectString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[Data].ConnectionString;
            }
        }

        public static string LogConnectString
        {
            get
            {   
                return ConfigurationManager.ConnectionStrings[Log].ConnectionString;
            }
        }

    }
}
