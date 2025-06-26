using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string IntercambiarAxE(string fraseOriginal)  
        {
            //string fraseOriginal = hola mundo
            //char[] caracteres = h o l a m u n d o
            char[] caracteres = fraseOriginal.ToCharArray();
            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == 'a')
                {
                    caracteres[i] = 'e';
                }
                // h o l e m u n d o
                // h o l e m u n d o   
            }
            string nuevafrase = new string(caracteres);
            return nuevafrase;
        }
    }
}
