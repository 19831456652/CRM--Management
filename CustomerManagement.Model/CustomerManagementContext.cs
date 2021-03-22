using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CustomerManagement.Model.Business;
using CustomerManagement.Model.Client;
using CustomerManagement.Model.Contact;
using CustomerManagement.Model.Employees;
using CustomerManagement.Model.Products;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Model
{
    public class CustomerManagementContext:DbContext
    {
        public CustomerManagementContext()
        {
        
        }

        public CustomerManagementContext(DbContextOptions options) : base(options)
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

        // 客户
        public DbSet<ClientSource> ClientSources { get; set; }
        public DbSet<ClientTrade> ClientTrades { get; set; }
        public DbSet<ClientLevel> ClientLevels { get; set; }
        public DbSet<ClientStatus> ClientStatuses { get; set; }
        public DbSet<Client.Client> Clients { get; set; }

        // 客户公海
        public DbSet<ClientHighSeas> ClientHighSeases { get; set; }

        // 联系人
        public DbSet<ContactPerson> ContactPersons { get; set; }

        // 产品
        public DbSet<ProductClassify> ProductClassifies { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<Product> Products { get; set; }

        // 商机
        public DbSet<BusinessStateGroup> BusinessStateGroups { get; set; }
        public DbSet<Business.Business> Businesses { get; set; }

        // 合同 先不加

    }
}
