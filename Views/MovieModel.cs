using MovieMaui.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMaui.Views
{
    internal class MovieModel
    {
        public string Title { get; set; }
        public string Directors { get; set; }
        public string Year { get; set; }
        public string Imagepath { get; set; }


        private DateTime _dateTime;
        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                }
            }
        }
      
    }
}
