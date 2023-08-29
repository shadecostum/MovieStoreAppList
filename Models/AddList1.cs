using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppList.Models
{
    internal class AddList1
    {
     
       public int MovieId { get; set; }
        public string MovieNmae { get; set; }

        public int MovieYear { get; set; }

        public string MoviePerson { get; set; }


        public AddList1(int id, string name,int year,string person)
        {
            MovieId = id;
            MovieNmae = name;
            MovieYear = year;
            MoviePerson = person;
        }   

        public void AddFunction() 
        {
            ListStatic.staticList.Add(new ListArray{ Id = MovieId,Name=MovieNmae,Year=MovieYear,Person=MoviePerson });
        }

     
    }
}
