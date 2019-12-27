using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Diablo.DataAccessLayer.Models
{
    public partial class People
    {

        public People()
        {

        }

        public int PeopleId { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
