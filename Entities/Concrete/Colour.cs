using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{

    public class Colour: IEntity
    {
        [Key]
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
