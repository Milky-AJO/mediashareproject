using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mediashare.Models
{
    public class ImageModel
    {
        public int ImageId { get; set; }
        public string ImageTitle { get; set; }
        public string ImagePath { get; set; }
        public bool ImagePublic { get; set; }
    }
}