﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiseGeneration
{
    public class RenderParameters
    {
        public bool ShowInPreview { get; set; }
        public int Radius { get; set; }
        public int Seed { get; set; }
        public int RejectionSamples { get; set; }
        public GenerationType Generationtype { get; set; }
        public RenderParameters(GenerationType generationtype, int radius, int seed, bool preview = true, int rejectionSamples = 15)
        {
            Generationtype = generationtype;
            ShowInPreview = preview;
            Radius = radius;
            Seed = seed;
            RejectionSamples = rejectionSamples;
        }
    }
}
