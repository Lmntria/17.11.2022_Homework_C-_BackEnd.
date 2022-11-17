using System;
using System.Collections.Generic;
using Eterna.Models;

namespace Eterna.ViewModels
{
	public class HomeVm
	{
		public List<Service> Services { get; set; }
        public List<Feature> Features { get; set; }
        public List<Slide> Slides { get; set; }

    }
}

