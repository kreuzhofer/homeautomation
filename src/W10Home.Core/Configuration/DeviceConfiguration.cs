﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10Home.Core.Configuration
{
	public class DeviceConfiguration
	{
		public string Type { get; set; }
		public Dictionary<string,string> Properties { get; set; }
	}
}