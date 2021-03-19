using System;
using System.Collections.Generic;

namespace Pelicula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombresDePelicula = new List<string>();
            nombresDePelicula.Add("Toy Story");
            nombresDePelicula.Add("Avengers");
            nombresDePelicula.Add("Bicentenial Man");
            nombresDePelicula.Add("Silence of the Lambs");
            nombresDePelicula.Add("Bad boys");
            nombresDePelicula.Add("Bad boys");
            nombresDePelicula.Add("Aladdin");
            nombresDePelicula.Add("Aladdin");

            HashSet<string> nombresDePeliculaSet = new HashSet<string>();
            nombresDePeliculaSet.Add("Toy Story");
            nombresDePeliculaSet.Add("Avengers");
            nombresDePeliculaSet.Add("Bicentenial Man");
            nombresDePeliculaSet.Add("Silence of the Lambs");
            nombresDePeliculaSet.Add("Bad boys");
            nombresDePeliculaSet.Add("Bad boys");
            nombresDePeliculaSet.Add("Aladdin");
            nombresDePeliculaSet.Add("Aladdin");

            Console.WriteLine("Cant.de peliculas en nombresDepelicula" + nombresDePeliculaSet);
            Console.WriteLine("Cant.de peliculas en nombresDepelicula" + nombresDePeliculaSet);

            HashSet<Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add (new Pelicula("Bad boys", 1995));
            peliculasSet.Add (new Pelicula("Bad boys", 1983));
            peliculasSet.Add (new Pelicula("Aladdin", 2019));
            peliculasSet.Add (new Pelicula("Aladdin", 1992));
            peliculasSet.Add (new Pelicula("Aladdin", 1992));
            Console.WriteLine("Cant. de Peliculas en peliculasSet" + peliculasSet.Count);


            Dictionary<string, string> nombresDePeliculasFavoritas = new Dictionary<string, string>();
            nombresDePeliculasFavoritas.Add("Pablo", "Titanic");
            nombresDePeliculasFavoritas.Add("Esteban", "The Fast and furious: Tokio Drift");
            nombresDePeliculasFavoritas.Add("Panfilo", "Barbie in the 12 Dancing Princesses");

            string nombrePeliculaFavoritaPablo = nombresDePeliculasFavoritas.GetValueOrDefault("Pablo");
            Console.WriteLine("nombrePEliculaFavoriitaPablo:" + nombrePeliculaFavoritaPablo);
            
            string nombreDePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro");
            Console.WriteLine("nombresDePeliculasFavoritas" + nombreDePeliculaFavoritaRamiro);

            nombreDePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro", "Ninguna");
            Console.WriteLine("nombresDePeliculasFavoritas" + nombreDePeliculaFavoritaRamiro);

            nombresDePeliculasFavoritas.Add("Ramiro", "Avatar");

            nombreDePeliculaFavoritaRamiro = nombresDePeliculasFavoritas.GetValueOrDefault("Ramiro", "Ninguna");
            Console.WriteLine("nombresDePeliculasFavoritas" + nombreDePeliculaFavoritaRamiro);
            
            if (nombresDePeliculasFavoritas.TryGetValue("Maria", out string nombrePeliculaFavoritaMaria))
            {
                Console.WriteLine("nombrePeliculasFavoritaMaria:" + nombrePeliculaFavoritaMaria);
            }
            else 
            {
                Console.WriteLine("Maria no tiene pelicula Favorita");
            }

            //lista
            Console.WriteLine(".............");
            Console.WriteLine("Listas");

            for (int i= 0; i < nombresDePelicula.Count; i++)
            {
                Console.WriteLine(nombresDePelicula[i]);
            }

            //HeashSet
            Console.WriteLine(".......");
            Console.WriteLine("Set");

            foreach (string nombrePelicula in nombresDePeliculaSet)
            {
                Console.WriteLine(nombrePelicula);
            }

            //Dictonary
            Console.WriteLine("........");
            Console.WriteLine("Dictonary");
            foreach (var key in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(key);
            }
            foreach(var value in nombresDePeliculasFavoritas.Values)
            {
                Console.WriteLine(value);
            }
            foreach(var key in nombresDePeliculasFavoritas.Keys)
            {
                Console.WriteLine(key + ":" + nombresDePeliculasFavoritas.GetValueOrDefault(key));
            }



            











            


        }
    }
}
