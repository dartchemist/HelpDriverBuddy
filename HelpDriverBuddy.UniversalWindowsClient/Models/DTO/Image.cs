using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDriverBuddy.UniversalWindowsClient.Models.DTO
{
    using Interfaces.Models;

    public class Image : IImage
    {
        public int Id { get; set; }

        public byte[] ImageBytes { get; set; }

        public string ImageExt { get; set; }
    }
}
