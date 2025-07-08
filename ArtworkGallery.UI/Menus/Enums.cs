namespace ArtworkGallery.UI.Enums
{
    public enum EntityType
    {
        None = 0,
        Artwork = 1,
        Artist = 2,
        Critique = 3,
        Exhibition = 4,
        Gallery = 5,
        Owner = 6,
        Restoration = 7,
        Specialization = 8,
        Staff = 9,
        Transaction = 10,
        ArtworkExhibition = 11,
        OwnerTransaction = 12,
        SpecializationArtist = 13,
        StaffExhibition = 14
    }

    public enum OperationType
    {
        None = 0,
        GetAll = 1,
        GetById = 2,
        Add = 3,
        Update = 4,
        Delete = 5
    }
}