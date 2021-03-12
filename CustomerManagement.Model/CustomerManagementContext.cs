using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CustomerManagement.Model.Employees;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Model
{
    public class CustomerManagementContext:DbContext
    {
        public CustomerManagementContext()
        {

        }

        public CustomerManagementContext(DbContextOptions<CustomerManagementContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .;Database=CustomerManagementCRM;Uid = sa;Pwd = sa;");
        }

        public DbSet<Employees.Employees> Employeeses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<EmployeeOrRole> EmployeeOrRoles { get; set; }
        public DbSet<RoleOrMenu> RoleOrMenus { get; set; }
    }
}
