namespace TokenAuthenticationInWebAPI.Models
{
    using System;
    using System.Linq;

    public class UserMasterRepository : IDisposable
    {
        // SECURITY_DBEntities it is your context class
        readonly SECURITY_DB_Entities context = new SECURITY_DB_Entities();
        //This method is used to check and validate the user credentials
        public UserMaster ValidateUser(string username, string password)
        {
            return context.UserMasters.FirstOrDefault(user =>
            user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.UserPassword == password);
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}