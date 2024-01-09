using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ComplaintManagementApp.Model
{
    public class ComplaintModel
    {
        [Key]
        public int ComplaintId { get; set; }
        public string Title { get; set; }
        public bool IsResolved { get; set; }
        public DateTime DueDate { get; set; }
    }
}