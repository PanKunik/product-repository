﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMDataManager.Library.Models
{
    public class VariantDBModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Tax { get; set; }
        public int InStock { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
