using API.Entities;
using System.Collections.Generic;

namespace API.Data
{
    public interface IToDoRepository
    {
       
        IEnumerable<ToDo> GetAll();
        IEnumerable<ToDo> GetActive();
        IEnumerable<ToDo> GetDone();
        ToDo GetById(int id);
        void Remove(int id);
        void Update(ToDo ToDo);

    }
}