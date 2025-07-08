using System;
using ArtworkGallery.UI.Enums;
using AutoMapper.Internal.Mappers;

namespace ArtworkGallery.UI.Menus
{
    public static class EntityMenu
    {
        public static MenuSelection Display()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "Select Entity to perform operation on\n" +
                    "1. Artwork\n" +
                    "2. Artist\n" +
                    "3. Critique\n" +
                    "4. Exhibition\n" +
                    "5. Gallery\n" +
                    "6. Owner\n" +
                    "7. Restoration\n" +
                    "8. Specialization\n" +
                    "9. Staff\n" +
                    "10. Transaction\n\n" +
                    "Relationship Entities:\n" +
                    "11. ArtworkExhibition\n" +
                    "12. OwnerTransaction\n" +
                    "13. SpecializationArtist\n" +
                    "14. StaffExhibition\n\n" +
                    "0. Exit");

                string? input = Console.ReadLine();
                int entityChoice = Convert.ToInt32(input);
                if ( entityChoice < 0 || entityChoice > 14)
                    {
                        Console.WriteLine("Invalid entry. Press any key to try again...");
                        Console.ReadKey();
                        Console.Clear();

                        continue;
                    }
                    
                else if (entityChoice == 0)
                    {
                    return new MenuSelection(EntityType.None, OperationType.None);
                    }
                   
                else
                    {
                    EntityType selectedEntity = (EntityType)entityChoice;
                    var operationChoice = OperationMenu.Display();
                    OperationType selectedOperation = (OperationType)operationChoice;

                    return new MenuSelection(selectedEntity,selectedOperation);
                    }
                
            }
        }
    }
}