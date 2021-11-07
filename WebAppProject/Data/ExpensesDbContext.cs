using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProject.Models;

namespace WebAppProject.Data {
    public class ExpensesDbContext : DbContext {
        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) : base(options) {

        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
