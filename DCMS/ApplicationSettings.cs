using System.Configuration;

namespace DCMS
{
    internal class ApplicationSettings
    {
        public static String ConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}