using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServerBrowser.Entities;
using ServerBrowser.Models;
using ServerBrowser.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerBrowser.Controllers
{
    [Route("servers")]
    public class ServerBrowserController : ControllerBase
    {

        private readonly IServerBrowserService serverBrowserService;
        public ServerBrowserController(IServerBrowserService _serverBrowserService)
        {
            serverBrowserService = _serverBrowserService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Servers>> GetAll()
        {
            var serverMap = serverBrowserService.GetAll();
            return Ok(serverMap);
        }
        [HttpPost]
        public ActionResult CreateServer([FromBody] CreateServersMap dataPost)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }
            serverBrowserService.Create(dataPost);
            return Created("Success",null);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            if(serverBrowserService.Delete(id))          
                return NoContent();
            return NotFound();
        }
    }
}
