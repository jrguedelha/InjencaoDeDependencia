using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.DI.Classes
{
    //Classe que fara o transporte de cargas medias
    public class CarroService : ICarroService
    {
        public string Motorista { get; set; }

        public CarroService(string motorista)
        {
            Motorista = motorista;
        }

        public string RealizarEntrega(string tipoEntrega)
        {
            if (tipoEntrega == "media")
                return $"Motorista: {Motorista}\n Entrega de carga media";
            else
                return "Voce nao possui o tipo de automovel necessario!";
        }
    }
}
