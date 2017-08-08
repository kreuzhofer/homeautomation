﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using W10Home.NetCoreDevicePortal.DataAccess.Entities;

namespace W10Home.NetCoreDevicePortal.DataAccess.Services
{
    public class DevicePluginPropertyService : BaseTableService<DevicePluginPropertyEntity>
    {
        public DevicePluginPropertyService(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
