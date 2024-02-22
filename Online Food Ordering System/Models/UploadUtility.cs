using System.Collections.Generic;

namespace Online_Food_Ordering_System.Models
{
    public class UploadUtility
    {

        public class UploadOperationResult
        {
            public string? RelastivePath { get; set; }
            public bool IsSuccess { get; set; }
        }

        public static UploadOperationResult UploadImage(IFormFile Image, String RootUploadImagePath, string SuperFolderUploadImage)
        {
            bool _ISuccess = false;
            string fileExtantion = FileExtantion(Image.FileName);


            string uploadsFolderPath = Path.Combine(RootUploadImagePath, SuperFolderUploadImage);
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName.GetHashCode() + "." +fileExtantion;
            string filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

            List<Extantion> validExtantions = new List<Extantion>();
            validExtantions.Add(Extantion.png);
            validExtantions.Add(Extantion.jpg);

            if (HasValidExtantions(fileExtantion, validExtantions))
            {
                try
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        Image.CopyTo(fileStream);
                        fileStream.Close();
                    }
                    _ISuccess = true;
                }
                catch (Exception)
                {
                    _ISuccess = false;
                }
            }

            string relastivePath = "\\" +  SuperFolderUploadImage + "\\" + uniqueFileName;
            return new UploadOperationResult() { RelastivePath = relastivePath, IsSuccess = _ISuccess };

        }

        private static bool HasValidExtantions(string fileExtantion, List<Extantion> validExtantions)
        {

            foreach (var validEx in validExtantions)
            {
                if (fileExtantion == validEx.ToString())
                {
                    return true;
                } 
            }

            return false;
        }

        private static string FileExtantion(string fileName)
        {

            return fileName.Substring(fileName.Length - 3);
        }


        internal enum Extantion
        {
            png,
            jpg
        }

    }
}


