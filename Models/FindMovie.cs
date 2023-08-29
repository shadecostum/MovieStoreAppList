using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppList.Models
{
    internal class FindMovie
    {
        public FindMovie(int year)
        {
           
          ListArray yearMovie=  ListStatic.staticList.Find(ListArray => ListArray.Year == year);
            if (yearMovie != null) 
            {
                Console.WriteLine("Deatails of Movie searched ID : " + yearMovie.Id + ",Movie Name = " + yearMovie.Name + ",Movie Year : " + yearMovie.Year + ",Movie Director : " + yearMovie.Person);
            }
            else { Console.WriteLine("Enter a valid year"); }
        }
    }
}
