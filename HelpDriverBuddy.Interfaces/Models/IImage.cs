namespace HelpDriverBuddy.Interfaces.Models
{
    public interface IImage
    {
        byte[] ImageBytes { get; set; }
        string ImageExt { get; set; }
    }
}
