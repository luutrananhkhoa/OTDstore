﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OTDStore.ViewModels.Catalog.Brands
{
    public class BrandVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? ParentId { set; get; }
    }
}
