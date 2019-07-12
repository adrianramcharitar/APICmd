using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleAPIProject.Models;

namespace SampleAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CommandsController : ControllerBase
    {
        private readonly CommandContext _context;

        public CommandsController(CommandContext context) => _context = context;
        //GET:      api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommands()
        {
            return _context.CommandItems;
        }
        /*
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "this", "is", "hard", "coded" };
        }
        */

        //GET       api/commands/n
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandItem(int id)
        {
            var commandItem = _context.CommandItems.Find(id);

            if(commandItem == null)
            {
                return NotFound();
            }
            return commandItem;
        }
    }

}