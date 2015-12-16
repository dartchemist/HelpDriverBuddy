namespace HelpDriverBuddy.Data.Models
{
    public class BaseProblemInformation
    {
        /// <summary>
        /// Image represent with byte array
        /// </summary>
        public byte[] Image { get; set; }

        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string RegisrationNumber { get; set; }
    }
}
