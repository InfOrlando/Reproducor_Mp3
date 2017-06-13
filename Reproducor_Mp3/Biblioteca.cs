using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproducor_Mp3
{
  public  class Biblioteca
    {

        private string _Nombre;
        private string _URL;
        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }
        public string URL
        {
            get
            {
                return _URL;
            }

            set
            {
                _URL = value;
            }
        }

       
    }
}
