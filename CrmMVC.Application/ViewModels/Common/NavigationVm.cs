﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmMVC.Application.ViewModels.Common
{
    public class NavigationVm
    {
		public int CurrentPage { get; set; }
		public int PageSize { get; set; }
		public int NumberOfPages { get; set; }
		public int Count { get; set; }
	}
}
