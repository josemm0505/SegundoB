using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLSegundoB
{
    public class ClsLogIn
    {
        private string usuario = "Jose_Mejia";
        private string clave = "0804348928";
        public bool autenticar (string Usuario, string Clave)
        {
            bool result = false;
            if (Usuario==usuario && Clave==clave)
            {
                result =true;
            }
            return result;
        }
    }
}
