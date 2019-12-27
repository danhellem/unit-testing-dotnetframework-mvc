using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Diablo.DataAccessLayer.Models
{
    public partial class Department
    {    
        public int DepartmentId { get; set; }        
      
        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string MailingAddress
        {
            get
            {
                return Address + " " + City + ", " + State + " " + PostalCode;
            }            
        }

        public Boolean IsActive { get; set; }

        public Boolean IsDeleted { get; set; }
       
    }
}
