﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ticari_Otomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
    }
}