using ArtworkGallery.UI.Enums;

namespace ArtworkGallery.UI.Menus
{
    public class MenuSelection
    {
        public EntityType Entity { get; set; }
        public OperationType Operation { get; set; }

        public MenuSelection(EntityType entity, OperationType operation)
        {
            Entity = entity;
            Operation = operation;
        }
    }
}