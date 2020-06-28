using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.Controllers
{
    public class DIController : Controller
    {
        private readonly IMotoService _motoService;
        private readonly ICarroService _carroService;
        private readonly ICaminhaoService _caminhaoService;

        public DIController(
            IMotoService motoService,
            ICarroService carroService,
            ICaminhaoService caminhaoService)
        {
            _motoService = motoService;
            _carroService = carroService;
            _caminhaoService = caminhaoService;
        }
        [Route("/entregas")]
        public string Entregas()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string carga1 = "leve";
            string carga2 = "media";
            string carga3 = "pesada";

            //carga 1 - leve
            switch (carga1)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 1 - " + _motoService.RealizarEntrega(carga1));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 1 - " + _carroService.RealizarEntrega(carga1));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 1 - " + _caminhaoService.RealizarEntrega(carga1));
                    break;

                default:
                    stringBuilder.Append("Carga 1 - Tipo de carga nao identificado");
                    break;
            }
            stringBuilder.AppendLine("\n");

            //carga2
            switch (carga2)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 2 - " + _motoService.RealizarEntrega(carga1));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 2 - " + _carroService.RealizarEntrega(carga1));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 2 - " + _caminhaoService.RealizarEntrega(carga1));
                    break;

                default:
                    stringBuilder.Append("Carga 2 - Tipo de carga nao identificado");
                    break;
            }

            stringBuilder.AppendLine("\n");

            //carga3
            switch (carga3)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 2 - " + _motoService.RealizarEntrega(carga1));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 2 - " + _carroService.RealizarEntrega(carga1));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 2 - " + _caminhaoService.RealizarEntrega(carga1));
                    break;

                default:
                    stringBuilder.Append("Carga 2 - Tipo de carga nao identificado");
                    break;
            }

            return stringBuilder.ToString();
        }
    }
}
