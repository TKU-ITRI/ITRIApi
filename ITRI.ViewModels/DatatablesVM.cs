﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITRI.ViewModels
{
    public class DatatablesVM<T> where T : class
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public IEnumerable<T> data { get; set; }
        public string error { get; set; }
    }
}
