using AccountManagementApp2.Models;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Text;

namespace AccountManagementApp2
{
        public class AccountManagementDbContext : Microsoft.EntityFrameworkCore.DbContext
        {
            public AccountManagementDbContext(DbContextOptions<AccountManagementDbContext> options)
                    : base(options)
            {
            }
            public DbSet<Account> Accounts { get; set; }
        }
}
