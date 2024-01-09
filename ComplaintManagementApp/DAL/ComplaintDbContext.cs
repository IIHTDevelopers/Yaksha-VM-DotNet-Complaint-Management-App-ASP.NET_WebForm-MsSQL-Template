using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ComplaintManagementApp.Model;

namespace ComplaintManagementApp.DAL
{
    public class ComplaintDbContext : DbContext
    {
        public DbSet<Model.ComplaintModel> ComplaintModels { get; set; }

        public ComplaintDbContext() : base("ConnStr")
        {
        }
    }
}