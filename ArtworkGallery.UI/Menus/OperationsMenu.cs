using System;

namespace ArtworkGallery.UI.Menus
{
    public static class OperationMenu
    {
        public static int Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Select Operation to perform:\n" +
                    "1 - Get All\n" +
                    "2 - Get By ID\n" +
                    "3 - Add\n" +
                    "4 - Update\n" +
                    "5 - Delete\n" +
                    "0 - Back");

                string? input = Console.ReadLine();
                
                int operationChoice = Convert.ToInt32(input);

                if (operationChoice >= 0 && operationChoice <= 5)
                    return operationChoice;

                Console.WriteLine("Invalid operation. Press any key to try again...");
                Console.ReadKey();
            }
        }

    }
}