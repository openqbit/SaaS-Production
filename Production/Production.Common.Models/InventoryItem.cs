﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OpenQubit.Production.Common.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public ItemType ItemType { get; set; }
        public int Quantity { get; set; }
    }
}