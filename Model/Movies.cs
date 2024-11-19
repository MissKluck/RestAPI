public class Movies
{
    /// <summary>
    /// Our Movies endpoint model. It contains the following fields
    /// int Id
    /// string Title
    /// string Director
    /// int ReleaseYear
    /// </summary>/
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Director { get; set; }
    public required int ReleaseYear { get; set; }

}