using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Francisco_Moreira.Models
{
    public class ApplicationDbContext:  IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("TareasContext")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}