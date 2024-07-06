using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    public class Estacionamento
    {
        public List<Veiculo> veiculosEstacionados { get; set; }

        public double ValorHora { get; private set;}
        public Estacionamento(double valorHora) 
        {
            ValorHora = valorHora;
            veiculosEstacionados = new List<Veiculo>();
        }

        public void adicionarVeiculo(Veiculo veiculo)
        {
            veiculosEstacionados.Add(veiculo);
        }
        public bool VeiculoExiste(string placa)
        {
            foreach (Veiculo veiculo in veiculosEstacionados)
            {
                if (veiculo.Placa.Equals(placa))
                {
                    return true;
                }
            }
            return false;
        }
        public double SaidaVeiculo(string placa, int horasEstacionado)
        {
            foreach(Veiculo veiculo in veiculosEstacionados)
            {
                if (veiculo.Placa.Equals(placa))
                {
                    veiculosEstacionados.Remove(veiculo);
                    return ValorHora * horasEstacionado;
                }
            }
            return 0;
        }
    }
}
