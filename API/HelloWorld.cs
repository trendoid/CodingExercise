using System;

namespace API
{
    public class HelloWorld
    { 
        protected string Phrase {get; set;}

        public HelloWorld()
        {
            Phrase = "Default Phrase";
        }

        public HelloWorld(string phrase)
        {
            this.Phrase = phrase;
        }

        public override string ToString()
        {
            return $"{this.Phrase}";
        } 
    }
}