﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFood_C_Sharp.Modele
{
    class Species
    {
        public string average_height { get; set; }
        public string average_lifespan { get; set; }
        public string classification { get; set; }
        public string created { get; set; }
        public string designation { get; set; }
        public string edited { get; set; }
        public string eye_colors { get; set; }
        public string hair_colors { get; set; }
        public string homeworld { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public List<string> people { get; set; }
        public List<string> films { get; set; }
        public string skin_colors { get; set; }
        public string url {get;set;}

        public override string ToString()
        {
            return name;
        }

    }
}
