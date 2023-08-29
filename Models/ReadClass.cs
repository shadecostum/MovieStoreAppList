using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppList.Models
{
    internal class ReadClass
    {
        public void ReadFunction()
        {
            foreach (var item in ListStatic.staticList)
            {
                if(item !=null)
                {
                    Console.WriteLine("ID : " + item.Id + ",Movie Name = " + item.Name + ",Movie Year : " + item.Year + ",Movie Director : " + item.Person);

                }
                else { Console.WriteLine("list is empty"); }
            }

        }
    }
}
