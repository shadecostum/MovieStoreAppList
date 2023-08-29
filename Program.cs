using MovieStoreAppList.Models;

namespace MovieStoreAppList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose \n1.Add a movie\n2.Display all movies\n3.Update\n4.Remove movie by name\n5.Find movie by year\n6.Clear list\n7.Exit  ");
                int choose = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("+++++++++++============++++++++++");

                switch (choose)
                {
                    case 1:

                        Console.WriteLine("Enter the movie id");
                        int movieId = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter the movie Name");
                        string movieName = Console.ReadLine();
                        Console.WriteLine("Enter movie year");
                        int movieYear = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Enter movie director");
                        string moviePerson = Console.ReadLine();

                        AddList1 addList1 = new AddList1(movieId, movieName, movieYear, moviePerson);
                        addList1.AddFunction();


                        Console.WriteLine("+++++++++++============++++++++++");
                        break;
                    case 2:
                        
                        ReadClass readClass = new ReadClass();
                        readClass.ReadFunction();
                        Console.WriteLine("+++++++++++================+++++++++");

                        break;
                    case 3:
                        UpdateList updateList = new UpdateList();
                        Console.WriteLine("+++++++++++================+++++++++");
                        Console.WriteLine();

                        break;
                    case 4:
                        DeletList deletList = new DeletList();
                        Console.WriteLine("+++++++++++================+++++++++");
                        Console.WriteLine();

                        break;
                    case 5:
                        Console.WriteLine("Enter the Year to find Movie");
                        int yearFind = Convert.ToInt16(Console.ReadLine());
                        FindMovie findMovie = new FindMovie(yearFind);
                        Console.WriteLine("+++++++++++================+++++++++");
                        break;
                    case 6:
                        ClearMovies clearMovies = new ClearMovies();
                        Console.WriteLine("Database is cleared");
                        Console.WriteLine("+++++++++++================+++++++++");
                        break;
                    case 7: return;

                    default:
                        Console.WriteLine("invalid");
                        break;
                }
            }


        }
    }
}