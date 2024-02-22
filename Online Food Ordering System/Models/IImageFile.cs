namespace Online_Food_Ordering_System.Models
{
    public interface IImageFile
    {
        IFormFile? ImageFile
        {
            get;
            set;
        }

        public string ImageSrc { get; set; }

        List<string> OldImages { get; set; }
    }
}
