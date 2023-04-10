using System.Globalization;

namespace Light.Logic.DataTransferObjects
{
    public class FileInfoDto
    {
        public string Filename { get; set; }
        public string Destination { get; set; }
        public byte[] Content { get; set; }
        public string MediaType { get; set; }
    }
}
