using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    public abstract class Veiculo
    {
        public string Placa { get; set;}
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public Veiculo(string placa, string modelo, string marca)
        {
            Placa = placa;
            Modelo = modelo;
            Marca = marca;
        }

        public override string ToString()
        {
            return $"Placa: {Placa} Modelo: {Modelo} Marca: {Marca}";
        }

    }
}
