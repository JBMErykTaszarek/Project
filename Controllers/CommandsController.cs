using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;

namespace Project.Controllers
{
    //api/commands
    [Route("api/commands")]
    [ApiController]
     public class CommandsController : ControllerBase
     {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = (SqlCommanderRepo)repository;
        }
         
         //GET api/commands
         [HttpGet]
         public ActionResult <IEnumerable<Command>> GetAllCommands()
         {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
         }
        //Get api/commands/{id}
        [HttpGet("{id}")]
         public ActionResult<Command> GetCommandById(int id)
         {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
         }

     }
}