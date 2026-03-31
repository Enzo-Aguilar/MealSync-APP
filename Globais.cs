using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealSync_APP
{
    internal class Globais
    {
        public class Utilizador
        {
            public static int ID;
            public static string funcao;
            public static string nome;
        }

        public class ContaBancaria 
        {
            public static int ID;
            public static SqlMoney saldo;
            public static string tipo;
        }
    }
}
