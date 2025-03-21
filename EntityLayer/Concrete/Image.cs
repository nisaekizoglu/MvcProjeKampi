﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [StringLength(100)] 
        public string ImageName { get; set; }
        [StringLength(500)]
        public string ImagePath { get; set; }
    }
}
