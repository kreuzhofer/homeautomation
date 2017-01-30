﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W10Home.Core.Interfaces;

namespace W10Home.Core.Channels
{
	public abstract class NotificationChannel : IChannel
	{
		public ChannelType ChannelType => ChannelType.Notification;
		public abstract bool IsRead { get; }
		public abstract bool IsWrite { get; }
		public abstract string Name { get; }
		public abstract Task<bool> SendMessageAsync(string messageBody);
	}
}
