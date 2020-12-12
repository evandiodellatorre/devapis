﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace devApiTwo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControllerShowmethecode
    {
        private const string GiT_REPOSITORY = "https://github.com/evandiodellatorre/devapi";

        /// <summary>
        /// Metodo que retorna uma Url do repositório dos fontes no github.
        /// </summary>
        /// <returns>
        /// Retorna url do repositório dos fontes no github.
        /// </returns>
        [HttpGet]
        public ActionResult<string> GetRepository()
        {
            return ControllerShowmethecode.GiT_REPOSITORY;
        }
    }
}
