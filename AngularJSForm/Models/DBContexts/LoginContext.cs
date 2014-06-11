using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularJSForm.Models.DBContexts
{
    public class LoginContext : DbContext
    {
        public LoginContext() : base("DemoDB")
        {
        }

        public DbSet<UserModel> Users
        {
            get;
            set;
        }
    }
}