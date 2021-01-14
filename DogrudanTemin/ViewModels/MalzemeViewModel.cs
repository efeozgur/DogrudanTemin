using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DogrudanTemin.Models;

namespace DogrudanTemin.ViewModels
{
    public class MalzemeViewModel
    {
        public List<MALZEME> Malzemeler { get; set; }
        public MALZEME Malzeme { get; set; }
        public OLCUBIRIMLERI OlcuBirimleri { get; set; }
    }
}