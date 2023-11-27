using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplaintManagementApp.Model;

namespace ComplaintManagementApp.DAL.Interfaces
{
    public interface IComplaintService
    {
        string GetAll();
        string Add();
        string Update();
        string Delete();
    }
}
