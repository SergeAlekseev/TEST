﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ProcessingsClient
{
	public class GetNumber : ProcessingClient
	{
		public int num;
		public override void Process(ControllerClient controller)
		{
			controller.model.number = num;
			controller.threadStart = true;
			controller.setName(controller.model.GInfo.Name);
		}
	}
}
