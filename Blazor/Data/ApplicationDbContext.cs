﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Models;


namespace Blazor.Data
{
    public class ApplicationDbContext :DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            var baseDirectory = AppContext.BaseDirectory;
            var projectRootPath = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\.."));
            var resolvedPath = Path.Combine(projectRootPath, "Blazor", "Data", "Weather.db");
            var resolvedConnectionString = $"Data Source={resolvedPath}";

            optionsBuilder.UseSqlite(resolvedConnectionString);
        }

        public DbSet<MainWeather> weathers { get; set; }

    }
}
