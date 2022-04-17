using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using PowerFit.Models;
using PowerFit.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PowerFit.Repository
{
    public class ImageRepository : IImageRepository
    {
        private readonly PowerFitContext _context;
        private readonly IWebHostEnvironment _env;
        public ImageRepository(PowerFitContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public Image ByteToImgConverter(byte[] imgByte)
        {
            using (MemoryStream ms = new MemoryStream(imgByte))
            {

                return Image.FromStream(ms);

            }
        }

        public string DateTimeFormatter(DateTime? updateDate)
        {
            string format = "yyyyMMddHHmmss";
            DateTime dt = (DateTime)updateDate.GetValueOrDefault();
            string exerciseUpdateDate = String.Format(dt.ToString(format));

            return exerciseUpdateDate;
        }

        public bool HasExerciseImage(int id)
        {
            var exercise = (from e in _context.Exercises
                            where e.ExerciseId == id
                            select new Exercise
                            {
                                Image = e.Image

                            }).FirstOrDefault();

            if (exercise.Image == null)
            {
                return false;
            }
            return true;
        }

        public bool IfDirectoryExists(int id)
        {
            var wwwroot = _env.WebRootPath;
            var imagePath = @"\image\exercise\" + id + @"\";

            var directoryPath = Path.GetFullPath(wwwroot + imagePath);

            return Directory.Exists(directoryPath);
        }

        public string IfImageDoesNotExist(int id)
        {
            var wwwroot = _env.WebRootPath;

            var exercise = _context.Exercises.Where(e => e.ExerciseId == id).Select(p => new Exercise
            {
                Image = p.Image,
                UpdateDate = p.UpdateDate
            }).FirstOrDefault();

            //Save image as thumbnail
            if (HasExerciseImage(id))
            {
                var bitmap = new Bitmap(ByteToImgConverter(exercise.Image), new Size(256, 256));

                var exerciseDirectory = @"\image\exercise\" + id + @"\";

                //Create directory if it doesn't exist
                if (!IfDirectoryExists(id))
                {
                    Directory.CreateDirectory(wwwroot + exerciseDirectory);
                }

                string exerciseUpdateDate = DateTimeFormatter(exercise.UpdateDate);

                try
                {
                    //Save the image in the created directory
                    bitmap.Save(wwwroot + exerciseDirectory + exerciseUpdateDate + "_thumbnail.png");

                    string imagePath = exerciseDirectory + exerciseUpdateDate + "_thumbnail.png";

                    return imagePath;

                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                
            }
            //If there was an error with the image or the exercise does not have an image show a placeholder img instead
            string placeholder = "/image/placeholder.png";
            return placeholder;
        }

        public string IfImageDoesNotExistDetails(int id)
        {
            var wwwroot = _env.WebRootPath;

            var exercise = _context.Exercises.Where(e => e.ExerciseId == id).Select(p => new Exercise
            {
                Image = p.Image,
                UpdateDate = p.UpdateDate
            }).FirstOrDefault();

            if (HasExerciseImage(id))
            {
                //Save image for Details page
                var bitmap = new Bitmap(ByteToImgConverter(exercise.Image), new Size(1000, 1000));


                var exerciseDirectory = @"\image\exercise\" + id + @"\";

                if (!IfDirectoryExists(id))
                {
                    Directory.CreateDirectory(wwwroot + exerciseDirectory);
                }

                string exerciseUpdateDate = DateTimeFormatter(exercise.UpdateDate);

                try
                {
                    //Save the image in the created directory
                    bitmap.Save(wwwroot + exerciseDirectory + exerciseUpdateDate + "_details.png");
                    string imagePath = exerciseDirectory + exerciseUpdateDate + "_details.png";

                    return imagePath;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            //If there was an error with the image or the exercise does not have an image show a placeholder img instead
            string placeholder = "/image/placeholder.png";
            return placeholder;
        }

        public bool IfImageExists(int id, DateTime? updateDate)
        {
            string exerciseUpdateDate = DateTimeFormatter(updateDate);
            var wwwrootPath = _env.WebRootPath;
            var imagePath = @"\image\exercise\" + id + @"\" + exerciseUpdateDate + "_thumbnail.png";
            var fullPath = Path.GetFullPath(wwwrootPath + imagePath);

            return System.IO.File.Exists(fullPath);
        }

        public bool IfImageExistsDetails(int id, DateTime? updateDate)
        {
            string exerciseUpdateDate = DateTimeFormatter(updateDate);
            var wwwrootPath = _env.WebRootPath;
            var imagePath = @"\image\exercise\" + id + @"\" + exerciseUpdateDate + "_details.png";
            var fullPath = Path.GetFullPath(wwwrootPath + imagePath);

            return System.IO.File.Exists(fullPath);
        }

        public byte[] ImageToByteConverter(IFormFile image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.CopyTo(ms);

                return ms.ToArray();
            }
        }

        public int IsExerciseUpdated(int id, string path)
        {
            var wwwrootPath = _env.WebRootPath;
            var fullPath = Path.GetFullPath(wwwrootPath + path);

            var exercise = _context.Exercises.Where(e => e.ExerciseId == id).Select(e => new Exercise
            {
                UpdateDate = e.UpdateDate
            }).FirstOrDefault();

            var imgCreationDate = File.GetCreationTime(fullPath);
            var exerciseUpdateDate = (DateTime)exercise.UpdateDate;


            int result = DateTime.Compare(imgCreationDate, exerciseUpdateDate);
            // -1 imgCreatingDate was before exerciseUpdateDate
            // 0 the dates are equal
            // 1 exerciseUpdateDate was before imgCreationDate
            return result;
        }
    }

     
}
