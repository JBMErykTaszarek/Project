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
        
        public CommandsController(ICommanderRepo repository)
        {
            _repository = (MockCommanderRepo)repository;
        }
         private readonly MockCommanderRepo _repository = new MockCommanderRepo();
         //GET api/commands
         [HttpGet]
         public ActionResult <IEnumerable<Command>> GetAllCommands()
         {
            var commandItems = _repository.GerAppCommands();

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