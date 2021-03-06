﻿using System;
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
                    stringBuilder.AppendLine("Carga 1\n" + _motoService.RealizarEntrega(carga1));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 1\n" + _carroService.RealizarEntrega(carga1));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 1\n" + _caminhaoService.RealizarEntrega(carga1));
                    break;

                default:
                    stringBuilder.Append("Carga 1\nTipo de carga nao identificado");
                    break;
            }

            stringBuilder.AppendLine("\n");

            //carga2 - media
            switch (carga2)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 2\n" + _motoService.RealizarEntrega(carga2));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 2\n" + _carroService.RealizarEntrega(carga2));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 2\n" + _caminhaoService.RealizarEntrega(carga2));
                    break;

                default:
                    stringBuilder.Append("Carga 2\nTipo de carga nao identificado");
                    break;
            }

            stringBuilder.AppendLine("\n");

            //carga3 - pesada
            switch (carga3)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 3\n" + _motoService.RealizarEntrega(carga3));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 3\n" + _carroService.RealizarEntrega(carga3));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 3\n" + _caminhaoService.RealizarEntrega(carga3));
                    break;

                default:
                    stringBuilder.Append("Carga 3\nTipo de carga nao identificado");
                    break;
            }

            return stringBuilder.ToString();
        }
    }
}
