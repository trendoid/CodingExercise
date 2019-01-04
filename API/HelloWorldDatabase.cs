using System;

namespace API
{
    public class HelloWorldDatabase : HelloWorld
    {
        public HelloWorldDatabase()
        {
            this.Phrase = "Hello World";
        }

        public HelloWorldDatabase(string phrase)
        {

            this.Phrase = string.IsNullOrEmpty(phrase) ? "Hello World" : phrase;
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
