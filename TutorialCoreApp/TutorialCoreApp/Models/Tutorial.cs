using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialCoreApp.Models
{
    public class Tutorial
    {
        [Key]
        public int TutorialId { get; set; }

          public string TutorialName{ get; set; }
             public  string TutorialDesc { get; set; }
             public int Published { get; set; }

        }   
}
