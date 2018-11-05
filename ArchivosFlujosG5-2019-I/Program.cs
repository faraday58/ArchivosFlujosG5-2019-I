using System;
using System.IO;

namespace ArchivosFlujosG5_2019_I
{
    class Program
    {
        static void Main()
        {
            StreamWriter sw = null;
            StreamReader sr=null;
            FileStream fs= null;
            try
            {
                fs = new FileStream("Archivo1.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                Console.WriteLine("Escribe una calaverita \n" +
                    "Para finalizar una línea pulse <Enter> \n" +
                    "Para finalizar el documento pulse dos veces <Enter>");

                string aux = Console.ReadLine();
                while( aux.Length != 0)
                {
                    sw.WriteLine(aux);
                    aux = Console.ReadLine();
                }


            }
            catch(IOException error)
            {
                Console.WriteLine("Error: " + error.Message);
            }
            finally
            {
               
                sw.Close();
                fs.Close();
            }

            try
            {
                fs = new FileStream("Archivo1.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string aux = sr.ReadLine();
                while(aux != null)
                {
                    Console.WriteLine(aux);
                    aux=sr.ReadLine();
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("Error: "+error.Message);
            }
            finally
            {
                fs.Close();
                sr.Close();
            }

        }
    }
}
