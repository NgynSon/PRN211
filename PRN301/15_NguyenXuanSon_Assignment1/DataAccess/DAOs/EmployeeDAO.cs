using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccess.DAOs
{
    public enum Sex
    {
        None,
        Male,
        Female
    }
    public class EmployeeDAO
    {
        private PE_Fall21B5Context context;

        public EmployeeDAO()
        {
            context = new PE_Fall21B5Context();
        }
        public List<string> GetPositions()
        {
            var results = context.Employees.Select(x => x.Position).ToList();
            var newResult = new List<string>();

            newResult.Add("All Position");
            foreach (var result in results)
            {
                if (!newResult.Contains(result))
                {
                    newResult.Add(result);
                }
            }
            return newResult;
        }

        public List<Employee> GetFilter(string name, Sex sex, string position)
        {
            var filterName = context.Employees.Include(e => e.DepartmentNavigation).Where(x => x.Name.Contains(name)).ToList();
            var filterGender = sex switch
            {
                Sex.None => filterName,
                Sex.Male => filterName.Where(x => x.Sex == "Male"),
                Sex.Female => filterName.Where(x => x.Sex == "Female")
            };
            var filterPosition = filterGender;
            if(position == "All Position")
            {

            }
            else
            {
                filterPosition = filterGender.Where(x => x.Position == position);
            }
            return filterPosition.ToList();
        }

        public void AddEmployee(Employee newEmployee)
        {
            try
            {
                context.Employees.Add(newEmployee);
                context.SaveChanges();
            }catch(Exception ex)
            {
                throw;
            }
        }


    }
}
