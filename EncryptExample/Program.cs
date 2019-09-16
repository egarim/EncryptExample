using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "500.00";
            var pass = "Saludemos la patria orgullosos de hijos suyos podernos llamar y juremos la vida animosos,sin descanso a su bien consagrar. Consagrar, consagrar";



            var salt = Crypto.CreateSalt(50);
            Console.WriteLine("Salt "+BitConverter.ToString(salt));
            var bytes = Crypto.EncryptAes(data, pass, salt);
            Console.WriteLine("EncryptAes " + BitConverter.ToString(bytes));
            var str = Crypto.DecryptAes(bytes, pass, salt);
            Console.WriteLine("DecryptAes " + str);

            Console.ReadLine();
        }
    }
}
