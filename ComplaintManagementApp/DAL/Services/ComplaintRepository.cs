using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ComplaintManagementApp.DAL.Interfaces;

namespace ComplaintManagementApp.DAL.Services
{
    public class ComplaintRepository : Interfaces.IComplaintRepository
    {
        private ComplaintDbContext _context;

        public ComplaintRepository(ComplaintDbContext context)
        {
            _context = context;
        }

        public Model.ComplaintModel GetById(int id)
        {
            //write your code here
            throw new NotImplementedException();
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