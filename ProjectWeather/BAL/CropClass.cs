using ProjectWeather.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeather.BAL
{
    class CropClass
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Fertilizers { get; set; }

        public static void AddItem(CropClass std)
        {
            DataAccessLayer.AddCropRecord(std);
        }
    }
}
