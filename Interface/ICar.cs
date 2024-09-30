using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YH_Inlämning_2_Car_factory.Interfaces;

namespace YH_Inlämning_2_Car_factory.Interface
{
    
        public interface ICar : IVehicle, IDriveable
        {
            int Doors { get; set; }
        }
    
}
