using System;
using ArtworkGallery.UI.Enums;
using ArtworkGallery.UI.Menus;
using ArtworkGallery.UI.Handlers;

namespace ArtworkGallery.UI.Handlers
{
    public static class HandleType
    {
        public static void Handle(MenuSelection selection)
        {
            switch (selection.Entity)
            {
                case EntityType.Artwork:
                    ArtworkHandler.Handle(selection.Operation);
                    break;

                default:
                    Console.WriteLine("Unknown entity selected.");
                    break;
            }
        }
    }
}