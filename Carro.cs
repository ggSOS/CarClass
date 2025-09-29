using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Carro
    {
        private String Chassis {  get; set; }
        private String LicensePlate { get; set; }
        private String Cor { get; set; }
        private String Motor { get; set; }

        public Carro(string chassis, string licensePlate, string cor, string motor)
        {
            Chassis = chassis;
            LicensePlate = licensePlate;
            Cor = cor;
            Motor = motor;
        }

        public override string ToString()
        {
            string output = "\t- Chassis: " + Chassis +
                "\n\t- LicensePlate: " + LicensePlate +
                "\n\t- Cor: " + Cor +
                "\n\t- Motor: " + Motor;
            return output;
        }
    }
}