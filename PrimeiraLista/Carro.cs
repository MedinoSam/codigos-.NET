using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraLista
{
    public class Carro
    {
        public string Placa {  get; private set; }
        public string Modelo { get; private set; }
        public Motor Motor { get; private set; }
        public Carro(string placa, string modelo, Motor motor)
        {
            Placa = placa;
            Modelo = modelo;
            Motor = motor;

            Motor.InstalarEmCarro(this);
        }

        public void TrocarMotor(Motor novoMotor)
        {
            if (novoMotor.Car != null)
                throw new InvalidOperationException("O motor essta  em outro carro.");

        
            Motor = novoMotor;

            Motor.InstalarEmCarro(this);
        }
        public double VelocidadeMaxima()
        {
            if (Motor == null)
                throw new InvalidOperationException("Sem motor nao da");

            if (Motor.Cilindrada <= 1.0)
                return 140;
            else if (Motor.Cilindrada <= 1.6)
                return 160;
            else if (Motor.Cilindrada <= 2.0)
                return 180;
            else
                return 220;
        }
    }
}
