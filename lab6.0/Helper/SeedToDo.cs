using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace SeedingProdoct.Helper
{
    public static class StudentSeedingDate
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>().HasData(

                new ToDo
                {
                    Id = 7,
                    Description = "a",
                    Created = 1,
                    IsDone = 0
                },
                new ToDo
                 {
                    Id = 8,
                    Description = "b",
                    Created = 1,
                    IsDone = 0
                },
                new ToDo
                 {
                     Id = 9,
                     Description = "c",
                     Created = 1,
                     IsDone = 1
                 },
                new ToDo
                  {
                      Id = 10,
                      Description = "d",
                      Created = 1,
                      IsDone = 0
                  }
                  , 
                new ToDo
                  {
                      Id = 11,
                      Description = "e",
                      Created = 0,
                      IsDone = 1
                  }


                ); ; ;
        }
    }

}