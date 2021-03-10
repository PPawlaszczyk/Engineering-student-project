using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange
{
    public class Gun
    {
        public long ID { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int FPS { get; set; }
        public int Capacity { get; set; }
        public string PowerSource { get; set; }
    }



}
