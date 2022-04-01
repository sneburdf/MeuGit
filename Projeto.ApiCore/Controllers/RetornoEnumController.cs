using Microsoft.AspNetCore.Mvc;
using Projeto.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.ApiCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RetornoEnumController : ControllerBase
    {

        [HttpGet]
        [Route("/RetornarEnumerador")]
        public string RetornarEnumerador(int index)
        {
            if(index > 8)
            {
                return "Index não localixado";
            }
            var objSaida = (PeriodicidadeUnidadeTempo)(Enum.GetValues(PeriodicidadeUnidadeTempo.Final.GetType())).GetValue(index);

            return objSaida.ToString();
        }
        [HttpGet]
        [Route("/RetornarEnumeradorOutro")]
        public string RetornarEnumeradorPost(int index)
        {
            if(index > 8)
            {
                return "Index não localixado";
            }
            var objSaida = (PeriodicidadeUnidadeTempo)index;
            return objSaida.ToString();
        }
    }
}
