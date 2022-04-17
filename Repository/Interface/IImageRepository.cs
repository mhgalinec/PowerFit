using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;


namespace PowerFit.Repository.Interface
{
    public interface IImageRepository
    {
        public Image ByteToImgConverter(byte[] imgByte);
        public byte[] ImageToByteConverter(IFormFile image);
        public bool IfImageExists(int id,DateTime? updateDate);
        public string IfImageDoesNotExist(int id);
        public bool IfImageExistsDetails(int id, DateTime? updateDate);
        public string IfImageDoesNotExistDetails(int id);
        public bool HasExerciseImage(int id);
        public string DateTimeFormatter(DateTime? updateDate);
        public bool IfDirectoryExists(int id);
        public int IsExerciseUpdated(int id, string path);
    }
}
