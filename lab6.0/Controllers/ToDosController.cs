using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;


namespace API.Controllers
{
    [ApiController]
    [Route("api/ToDos")]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoRepository _repository;

        public IEnumerable<ToDo> ToDos { get; private set; }

        public ToDosController(IToDoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<ToDo>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}", Name = "GetById")]

        public ActionResult<ToDo> GetById(int id) => _repository.GetById(id);



        [HttpGet("active")]
        public ActionResult<List<ToDo>> GetActiveToDo() => _repository.GetActive().ToList();

        [HttpGet("done")]
        public ActionResult<List<ToDo>> GetDoneToDo() => _repository.GetDone().ToList();

        [HttpGet("update")]
        public ActionResult<int> UpdateToDo()
        {
            _repository.Update(
         new ToDo
         {
             Id = 8,
             Description = "update",
             Created = 0,
             IsDone = 1
         });
            return 0;
        }

        [HttpGet("Remove={id}")]
        public ActionResult<int> RemoveToDo(int id)
        {
            _repository.Remove(id);
            return 0;
        }
    }
}