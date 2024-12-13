namespace Queue
{

    class Program
    {
        static void Main(string[] args)
        {
           
            Queue queue = new Queue();

            
            queue.Enqueue("Lana");
            queue.Enqueue("Josip");
            queue.Enqueue("Matej");
            queue.Enqueue("Sara");
            queue.Enqueue("Marko");

            Console.WriteLine("Queue after enqueueing elements:");
            queue.Display(); 

            
            try
            {
                while (!queue.IsEmpty())
                {
                    Console.WriteLine($"\nDequeued: {queue.Dequeue()}");
                    Console.WriteLine("Queue after dequeueing:");
                    queue.Display(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


}
