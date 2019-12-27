using System;
namespace Diablo.DataAccessLayer.Repo
{
    public interface IDepartmentRepository
    {
        void Delete(int id);
        Diablo.DataAccessLayer.Models.Department Find(int id);
        System.Collections.Generic.IList<Diablo.DataAccessLayer.Models.Department> List { get; }
        System.Linq.IQueryable<Diablo.DataAccessLayer.Models.Department> QueryList { get; }
        void Store(Diablo.DataAccessLayer.Models.Department department);
    }
}
