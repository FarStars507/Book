﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBookStorev5.Models
{
    public partial class BookTitle
    {
        [Key]


        public string BT_ID { get; set; }


        public string BT_Name { get; set; }
    }
}