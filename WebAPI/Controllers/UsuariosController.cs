﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/
        /*
        public IEnumerable<UsuarioDTO> GetEmail()
        {
            var repo = new UsuarioRepository();
            List<UsuarioDTO> mercados = repo.RetrieveEmail();
            return mercados;
        }
        */

        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        public void Post([FromBody]Usuario evento)
        {
            var repo = new UsuarioRepository();
            repo.Save(evento);
        }
        /*
        public void Post([FromBody]string value)
        {
        }
        */

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
