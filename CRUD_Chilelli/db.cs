using System.Configuration;

namespace CRUD_Chilelli
{
    class db
    {
        public static string getConnString()
        {
            string connString = ConfigurationManager.AppSettings["connString"].ToString();
            return connString;
        }
    }
    class getTehStuff
    {
    }
}
