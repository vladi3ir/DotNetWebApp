using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment5a.Models
{
    public class MainViewModel
    {
        public string Name { get; set; }
        [RegularExpression(@"(?i)(^\s*open sesame\s*$)")]
        public string Pasword { get; set; }
    }
}
