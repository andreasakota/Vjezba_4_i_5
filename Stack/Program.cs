namespace Stack
{
   
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();

            
            stack.Push("Ivana");
            stack.Push("Luka");
            stack.Push("Petar");

            Console.WriteLine("Stack after pushing elements:");
            stack.Display();

            
            try
            {
                while (!stack.IsEmpty())
                {
                    Console.WriteLine($"\nPopped: {stack.Pop()}");
                    Console.WriteLine("Stack after popping:");
                    stack.Display(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
