using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityInANutshell.Models
{
    public class ApplicationRole : IdentityRole<string, ApplicationUserRole>
    {
    }
}