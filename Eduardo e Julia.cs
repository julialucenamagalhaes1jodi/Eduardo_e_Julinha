using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia_e_Eduardo
{
    class Jogador
    {
        string Nome;
        int Idade = 25 , drible = 80, chute = 60, força = 70 , velocidade = 80;

        public void correr()
        {
            int aceleração = força + velocidade;

        }

        public int chutar()
        {
            int potenciachute = força * chute;

            return potenciachute;
        }

        public void tocar()
        {
            double Toque;

            Toque = (chute = chute / 3) + (força = força / 3);
        }

        public void inteceptar()
        {
            double PotenciaCaminho;

            PotenciaCaminho = (velocidade = velocidade * velocidade) + (força = força / 2);
        }

        public void driblar()
        {
            int Eficienciadrible;

            Eficienciadrible = drible + (velocidade = velocidade * velocidade);
        }
    }
}
