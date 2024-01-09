using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ComplaintManagementApp.DAL.Interfaces;
using ComplaintManagementApp.Model;

namespace ComplaintManagementApp.DAL.Services
{
    public class ComplaintService : Interfaces.IComplaintService
    {
        private Interfaces.IComplaintRepository _repository;

        public ComplaintService(Interfaces.IComplaintRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Add()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Update()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public string Delete()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}