using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.DI.Classes
{
    //Clase que fara o transporte de cargas leves
    public class MotoService : IMotoService
    {
        private string Motorista;
        private string Placa;

        public MotoService(string motorista, string placa)
        {
            Motorista = motorista;
            Placa = placa;
        }

        public string RealizarEntrega(string tipoEntrega)
        {
            if (tipoEntrega == "leve")
                return $"Motorista: {Motorista} \nPlaca: {Placa}\nEntrega de carga leve";
            else
                return "Voce nao possui o tipo de automovel necessario!";
        }
    }
}
