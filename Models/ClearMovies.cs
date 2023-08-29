using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAppList.Models
{
    internal class ClearMovies
    {
        public ClearMovies() {
        ListStatic.staticList.Clear();
        }
    }
}
