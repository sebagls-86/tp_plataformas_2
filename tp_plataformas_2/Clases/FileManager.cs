using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tp_plataformas_2
{
    public abstract class FileManager
    {
        public static void CreateFolder()
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mercado";
            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }

        }
        public static void CreateFile(string file)
        {
            string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mercado";
            if (Directory.Exists(sourcePath))
            {

                string fileName = file + ".txt";
                string sourceFile = Path.Combine(sourcePath, fileName);
                if (!File.Exists(sourceFile))
                {
                    File.WriteAllText(sourceFile, "");

                }
            }

        }

        public static string[] ReadFileCategorias()
        {
            string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mercado";

            string fileName = "categorias.txt";
            string sourceFile = Path.Combine(sourcePath, fileName);

            string line;

            string[] contenido = new string[10];

            if (File.Exists(sourceFile))
            {
                StreamReader archivo = new StreamReader(sourceFile);
                int counter = 0;
                while ((line = archivo.ReadLine()) != null)
                {
                    contenido[counter] = line;
                    //System.Console.WriteLine(line);
                    counter++;
                }

                archivo.Close();

            }
            return contenido;
        }

        public static void SaveFileCategorias(string file, string contenido)
        {
            string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mercado";
            string fileName = file + ".txt";
            string sourceFile = Path.Combine(sourcePath, fileName);

            StreamWriter archivo = new StreamWriter(sourceFile, true);
            archivo.WriteLine(contenido);

            archivo.Close();
        }
        public static void SaveAllData(Categoria[] categorias)
        {

            string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mercado";
            string fileName = "categorias.txt";
            string sourceFile = Path.Combine(sourcePath, fileName);
            //StreamWriter archivo = new StreamWriter(sourceFile, true);
            string[] contenido = new string[10];
            int i = 0;
            foreach (Categoria categoria in categorias)
            {
                
                if(categoria != null)
                {

                    contenido[i] = categoria.Nombre;
                }
                i++;
                
            }

            File.WriteAllLines(sourceFile, contenido);
            //archivo.Close();
            //string[] lines = { "First line", "Second line", "Third line" };
            //File.WriteAllLines("WriteLines.txt", lines)

            //string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\Local\Mercado";
            //string fileName = file + ".txt";
            //string sourceFile = Path.Combine(sourcePath, fileName);

            //StreamWriter archivo = new StreamWriter(sourceFile, true);
            //archivo.WriteLine(contenido);

        }

    }
}


