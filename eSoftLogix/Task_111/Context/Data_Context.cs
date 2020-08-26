using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_111.Models;

namespace Task_111.Context
{
    public class Data_Context : DbContext
    {
        public Data_Context(DbContextOptions<Data_Context> options) : base(options)
        {
        }
        public DbSet<GL_CONTROL_ACCOUNTS> GL_CONTROL_ACCOUNTs { get; set; }
        public DbSet<GL_CHART_OF_ACCOUNTS> GL_CHART_OF_ACCOUNTs { get; set; }
        


    }
}
