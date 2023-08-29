using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppList.Models
{
    internal class UpdateList
    {
        private int indexOfItemToUpdate;

        public UpdateList() 
        {
            Console.WriteLine("Enter Id to update");
           int updateId=Convert.ToInt32( Console.ReadLine());

            ListArray updatingId = ListStatic.staticList.Find(ListArray => ListArray.Id == updateId);
            if (updatingId != null )
            {
               
               Console.WriteLine("enter the Name");
               string updatenamePerson = Console.ReadLine();
               updatingId.Name= updatenamePerson;
               
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
