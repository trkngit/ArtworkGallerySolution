using System;
using System.Threading;
using ArtworkGallery.UI.Menus;
using System.Reflection.Metadata;
using ArtworkGallery.DAL.Models;
using ArtworkGallery.UI.Handlers;

namespace ArtworkGallery.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE 'ARTWORK DB'");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("____");
                Thread.Sleep(150);
                Console.Write("_____");
                Thread.Sleep(100);
            }

            while (true)
            {
                MenuSelection selection = EntityMenu.Display();

                // Exit if both entity and operation are 0
                if (selection.Entity == 0 && selection.Operation == 0)
                {
                    Console.WriteLine("Exiting application...");
                    break;
                }

                Console.Clear();
    
                Console.WriteLine($"Selected Entity: {selection.Entity}, Operation: {selection.Operation}");
                
                //handler call

                HandleType.Handle(selection);

                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }
    }
}