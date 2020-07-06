using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParseadorXML.Domain.src.Interfaces.Repositories;
using ParseadorXML.Infra.Data.EFRepositories.src.Repositories;

namespace ParseadorXML.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobanteController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IComprobanteRepository _comprobanteRepository;



        public ComprobanteController(IComprobanteRepository comprobanteRepository)
        {
            _comprobanteRepository = comprobanteRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetPost()
        {
            var post = await _comprobanteRepository.SelectAll();

            return Ok(post);
        }



    }
}
