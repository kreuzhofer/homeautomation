﻿using System;
using System.Threading.Tasks;
using W10Home.Core.Channels;
using W10Home.Interfaces;

namespace W10Home.Plugin.ETATouch
{
	public class EtaChannel : IDeviceChannel
	{
		private ChannelType _channelType;
		private string _name;
        private UnitType _unitType;

        public EtaChannel(string name, ChannelType channelType, UnitType unitType)
		{
			_name = name;
			_channelType = channelType;
            _unitType = unitType;
		}

		public ChannelType ChannelType => _channelType;

		public bool IsRead => true;

		public bool IsWrite => false;

		public string Name => _name;
		public object Read()
		{
			throw new NotImplementedException();
		}

		public void Write(object value)
		{
			throw new NotImplementedException();
		}
	}
}