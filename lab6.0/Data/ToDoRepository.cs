using API.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace API.Data
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly DataContext context;

        public ToDoRepository(DataContext context)
        {
            this.context = context;
        }

       

        public void Update(ToDo ToDo)
        {
            this.context.Update(ToDo);
            this.context.SaveChanges();
        }

        public IEnumerable<ToDo> GetAll()
        {
            return this.context.ToDos.ToList();
        }

        public ToDo GetById(int id)
        {
            return this.context.ToDos.Find(id);
        }

        public void Remove(int id)
        {  
            this.context.Remove(this.context.ToDos.Find(id));
            this.context.SaveChanges();
        }

        public IEnumerable<ToDo> GetActive()
        {
            List<ToDo> list = new List<ToDo>();
            foreach (ToDo p in this.context.ToDos)
            {
                if (p.IsDone==0)
                {
                    list.Add(p);
                }
            }
            return list;
        }

        public IEnumerable<ToDo> GetDone()
        {
            List<ToDo> list = new List<ToDo>();
            foreach (ToDo p in this.context.ToDos)
            {
                if (p.IsDone == 1)
                {
                    list.Add(p);
                }
            }
            return list;
        }
    }
}
