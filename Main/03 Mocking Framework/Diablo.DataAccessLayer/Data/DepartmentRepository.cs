using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Diablo.DataAccessLayer.Models;

namespace Diablo.DataAccessLayer.Data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private IList<Department> objDepartmentDataSet;

        public DepartmentRepository()
        {
            var items = new System.Collections.Generic.List<Department>
            {
                new Department { DepartmentId = 1, Name = "Accounting", Description = "A place for numbers", Address = "4101 Hearthside Drive", City = "Traverse City", State = "MI", PostalCode = "43196", IsActive = true, IsDeleted = false },
                new Department { DepartmentId = 2, Name = "Development", Description = "This is how code gets done", Address = "123 West Ave Suite 200", City = "Columbus", State = "OH", PostalCode = "99183", IsActive = true, IsDeleted = false },
                new Department { DepartmentId = 3, Name = "Operations", Description = "I love the game Operation", Address = "4451 Rodoe Drive", City = "Denver", State = "CO", PostalCode = "80123", IsActive = true, IsDeleted = false },
                new Department { DepartmentId = 4, Name = "Marketing", Description = "Pretty pictures", Address = "4445 East Lansing Road", City = "Salt Lake City", State = "UT", PostalCode = "29854", IsActive = true, IsDeleted = false }
            };

            this.objDepartmentDataSet = items;
        }

        public IQueryable<Department> QueryList
        {
            get
            {
                return this.objDepartmentDataSet.AsQueryable();
            }
        }

        public IList<Department> List
        {
            get
            {
                return this.objDepartmentDataSet.ToList();
            }
        }

        public void Store(Department department)
        {
            if (department.DepartmentId == 0)
            {
                Department newDepartment = new Department();

                newDepartment.DepartmentId = department.DepartmentId;
                newDepartment.Address = department.Address;
                newDepartment.City = department.City;
                newDepartment.Description = department.Description;
                newDepartment.IsActive = department.IsActive;
                newDepartment.IsDeleted = department.IsDeleted;
                newDepartment.Name = department.Name;
                newDepartment.PostalCode = department.PostalCode;
                newDepartment.State = department.State;

                objDepartmentDataSet.Add(newDepartment);
            }
            else
            {
                for (int i = 0; i < objDepartmentDataSet.Count(); i++)
                {
                    if (objDepartmentDataSet[i].DepartmentId == department.DepartmentId)
                    {
                        objDepartmentDataSet[i] = department;
                        break;
                    }
                }
            }
        }

        public Department Find(int id)
        {
            var result = from dept in objDepartmentDataSet
                         where dept.DepartmentId == id
                         select dept;

            return result.First();
        }

        public void Delete(int id)
        {
            for (int i = 0; i < objDepartmentDataSet.Count(); i++)
            {
                if (objDepartmentDataSet[i].DepartmentId == id)
                {
                    objDepartmentDataSet.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
