using System.ComponentModel.DataAnnotations;
using System;

namespace API.Entities
{
    public class ToDo
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int IsDone { get; set; }
        public int Created { get; set; }


    }
}