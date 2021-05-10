using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo.ConsoleApp
{
    class Validacao
    {
        public string equilatero;
        public string isosceles;
        public string escaleno;

        public bool Equilatero(string tipoInformado)
        {
            if (tipoInformado == equilatero)
                return true;
            else
                return false;
        }

        public bool Isosceles(string tipoInformado)
        {
            if (tipoInformado == isosceles)
                return true;
            else
                return false;
        }

        public bool Escaleno(string tipoInformado)
        {
            if (tipoInformado == escaleno)
                return true;
            else
                return false;
        }


    }
}
