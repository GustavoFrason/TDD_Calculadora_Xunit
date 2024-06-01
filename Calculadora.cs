using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraComHistorico
{
    public class Calculadora
    {

        //criação dos metodos da calculadora
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int somar (int val1, int val2)
        {
            int res = val1 + val2;
            listaHistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, "Resultado: " + res);

            return res;
        }

        public List<string> historico() //grava o historico das últimas contas realizadas 
        {  
            //List<string> ret = new List<string>();
            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }
    }
}
