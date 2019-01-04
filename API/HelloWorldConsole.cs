using System;

namespace API
{
    public class HelloWorldConsole : HelloWorld
    {
        public HelloWorldConsole()
        {
            this.Phrase = "Hello World";
        }

        public HelloWorldConsole(string phrase)
        {

            this.Phrase = string.IsNullOrEmpty(phrase) ? "Hello World" : phrase;
        }

        public void Execute()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
