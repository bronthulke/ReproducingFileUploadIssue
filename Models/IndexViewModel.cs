using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproducingFileUploadIssue.Models
{
    public class IndexViewModel
    {
        [UIHint("ImageUpload")]
        [Display(Name = "Select/Update an Image")]
        public string UploadedImageData { get; set; }
        public string UploadedImageDataFileName { get; set; }

    }
}
