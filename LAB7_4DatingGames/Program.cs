using System;

namespace LAB7_4DatingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile bob = new DatingProfile("Mark", "Slone", 40, "Male");
            bob.WriteBio("New to this online dating.");

            DatingProfile susie = new DatingProfile("Lexie", "Grey", 25, "Female");
            susie.WriteBio("Love to read and write.");

            bob.SendMessage("Hello Lexie", "When is the new book coming out?", susie);
            susie.ReadMessage();
        }
    }
}