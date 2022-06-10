using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EscrituraBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            int nbytes = 0, car;

            try
            {
                //crear el flujo del archivo 
                fs = new FileStream("Text.txt", FileMode.Create, FileAccess.Write);
                Console.WriteLine("Escriba el texto que desea almacenar en el archivo:");
                while ((car=Console.Read()) != '\r' && (nbytes <Buffer.Length))
                {
                    Buffer[nbytes] = (byte)car;
                    nbytes++;


                }
                fs.Write(Buffer, 0, nbytes);

            }
            catch (IOException e )
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
