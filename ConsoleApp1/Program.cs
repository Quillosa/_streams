namespace program;
    class myFirstProgram {


        static void Main(string[] args) {

        Console.ForegroundColor = ConsoleColor.Green;
        //Console.BackgroundColor = ConsoleColor.White;

            string data;
            StreamReader reader = null;
            StreamWriter writer = null;

        try
        {
            reader = new StreamReader("C:\\Users\\Public\\Documents\\letter.txt");
           
             data = reader.ReadLine();

            while (data != null)
            {
                Console.WriteLine(data);
                data = reader.ReadLine();
            }
            reader.Close();
            writer = new StreamWriter("C:\\Users\\Public\\Documents\\letter.txt");
            writer.WriteLine(@"BARUYYYYYyyyyy");

        }catch(Exception ex)
        {
            Console.WriteLine("may error ang dagis");
        }
        finally
        {   
            writer.Close();
        }
     
        }

     }
