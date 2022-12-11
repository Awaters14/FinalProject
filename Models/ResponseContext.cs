using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class ResponseContext: DbContext
    {
        public ResponseContext(DbContextOptions<ResponseContext> options)
            : base(options) 
        { }

        public DbSet<Response> Respones { get; set; }
        public DbSet<Priority> Priorities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Priority>().HasData(
                new Priority { priorityId = "1", priorityValue = "A" },
                new Priority { priorityId = "2", priorityValue = "B" },
                new Priority { priorityId = "3", priorityValue = "C" },
                new Priority { priorityId = "4", priorityValue = "D" },
                new Priority { priorityId = "5", priorityValue = "E" },
                new Priority { priorityId = "6", priorityValue = "F" });

                modelBuilder.Entity<Response>().HasData(
                new Response
                {
                    ResponseId = 1,
                    name = "Bob",
                    problem = "Broken Window",
                    address = "123 main st.",
                    state = "IA",
                    zipcode = "55555",
                    priorityId = "2"
                    
                    
                },
                new Response
                {
                    ResponseId = 2,
                    name = "Frank",
                    problem = "Missing roof",
                    address = "456 downtown ave.",
                    state = "IA",
                    zipcode = "44444",
                    priorityId = "1"
                },
                new Response
                {
                    ResponseId = 3,
                    name = "Phil",
                    problem = "Tree fell into house",
                    address = "5533 86th st.",
                    state = "IA",
                    zipcode = "333",
                    priorityId = "1"
                }
             );
        }

    }
}
