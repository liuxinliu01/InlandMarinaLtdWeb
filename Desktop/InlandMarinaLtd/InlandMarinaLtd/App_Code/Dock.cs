using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InlandMarinaLtd.App_Code
{
    public class Dock
    {
        public int DockID { get; set; }
        public string Name { get; set; }
        public byte WaterService { get; set; }
        public byte ElectricalService { get; set; }

    }
}