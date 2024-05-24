﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PartsListViewModel
    {
        public IEnumerable<Part> Parts { get; set; }
        public PagingInfo Paging { get; set; }
        public string CurrentCategory { get; set; }
    }
}