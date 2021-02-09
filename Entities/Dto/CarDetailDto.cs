using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class CarDetailDto : IDto
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColourName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
