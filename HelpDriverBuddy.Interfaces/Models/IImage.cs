namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IImage
    {
        int Id { get; set; }
        byte[] ImageBytes { get; set; }
        string ImageExt { get; set; }
    }
}
