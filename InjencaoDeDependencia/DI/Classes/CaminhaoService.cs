using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.DI.Classes
{
    //Classe que fara entrega de cargas pesadas
    public class CaminhaoService : ICaminhaoService
    {
        public string Motorista { get; set; }
        public string TipoCarteira { get; set; }

        public CaminhaoService(string motorista, string tipoCarteira)
        {
            Motorista = motorista;
            TipoCarteira = tipoCarteira;
        }

        public string RealizarEntrega(string tipoEntrega)
        {
            if (tipoEntrega == "pesada")
                return $"Motorista: {Motorista}\nCarteira: {TipoCarteira}\nEntrega de carga pesada";
            else
                return "Voce nao possui o tipo de veiculo necessario!";
        }
    }
}
