using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppList.Models
{
    internal class DeletList
    {

        public DeletList() 
        {
            Console.WriteLine("Enter the Name of Movie to delete");
            string deleteMovieName= Console.ReadLine();

            ListArray deletingMovie=ListStatic.staticList.Find(ListArray=>ListArray.Name== deleteMovieName);
            if (deletingMovie != null )
            {
                Console.WriteLine("Deleted of Movie Details : " + deletingMovie.Id + ",Movie Name = " + deletingMovie.Name + ",Movie Year : " + deletingMovie.Year + ",Movie Director : " + deletingMovie.Person);

                ListStatic.staticList.Remove(deletingMovie);
                Console.WriteLine("succesfully deleted");
            }
            else { Console.WriteLine("not found ID"); }


          
        }
    }
}
