using System;
using System.Collections.Generic;

namespace Evaluacion1
{
    class Program
    {
        static void Main(string[] args)
        {

            
         
            Console.WriteLine($" insertar (1)");
            Console.WriteLine($" listar (2)");
            
            var resultado = Console.ReadLine();
            List<MusicPlayer> musica = new List<MusicPlayer>();






            if (resultado == "1")
            {
                MusicPlayer mus = new MusicPlayer();
                Console.WriteLine($"Digite el nombre de cancion");
                mus.Nombre = Console.ReadLine();

                Console.WriteLine($"Digite el genero de la cancion");
                mus.Genero = Console.ReadLine();

                Console.WriteLine($"Digite el album de la cancion");
                mus.Album = Console.ReadLine();

                Console.WriteLine($"Digite el tiempo que dura la cancion");
                mus.TiemRepro = int.Parse(Console.ReadLine());

                musica.Add(mus);


            }

            Console.WriteLine($" insertar (1)");
            Console.WriteLine($" listar (2)");
            
            resultado = Console.ReadLine();

            if (resultado == "2")
            {
                foreach (var item in musica)
                {
                    Console.WriteLine($"el nombre:{ item.Nombre} genero:{item.Genero} Album:{item.Album} Tiempo reproduccion: {item.TiemRepro}");
                }
            }

        }
        
    }
}
