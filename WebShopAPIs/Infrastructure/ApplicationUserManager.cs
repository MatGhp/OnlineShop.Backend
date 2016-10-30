using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopAPIs.Models.DB;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
namespace WebShopAPIs.Infrastructure
{
    public class ApplicationUserManager : UserManager<User>
    {
        public ApplicationUserManager(IUserStore<User> store)
            : base(store)
        {
        }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            var appDbContext = context.Get<ApplicationDbContext>();
            var appUserManager = new ApplicationUserManager(new UserStore<User>(appDbContext));

            return appUserManager;
        }
        //public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        //{
        //    var appDbContext = context.Get<ApplicationDbContext>();
        //    var appUserManager = new ApplicationUserManager(new UserStore<User>(appDbContext));

            
        //    appUserManager.EmailService = new WebShopAPIs.Services.EmailService();

        //    var dataProtectionProvider = options.DataProtectionProvider;
        //    if (dataProtectionProvider != null)
        //    {
        //        appUserManager.UserTokenProvider = new DataProtectorTokenProvider<User>(dataProtectionProvider.Create("ASP.NET Identity"))
        //        {
        //            //Code for email confirmation and reset password life time
        //            TokenLifespan = TimeSpan.FromHours(6)
        //        };
        //    }

        //    return appUserManager;
        //}
    }
}