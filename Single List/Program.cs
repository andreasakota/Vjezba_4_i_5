using System;

namespace SingleList
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            list.InsertFront("Ivo");
            list.InsertEnd(1);
            list.InsertEnd(3.14);
            list.InsertFront(true);
            list.InsertEnd(100m);

            Console.WriteLine("List after initial insertions:");
            list.Display();

            try
            {
                list.RemoveEnd();
                list.RemoveFront();

                Console.WriteLine("List after removing end and front:");
                list.Display();

                list.RemoveEnd();
                list.RemoveFront();
                list.RemoveFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("List after final operations:");
            list.Display();
        }
    }
}

