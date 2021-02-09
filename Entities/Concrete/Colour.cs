
using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{

    public class Colour: IEntity
    {
        [Key]
        public int ColourId { get; set; }
        public string ColourName { get; set; }
    }
}
