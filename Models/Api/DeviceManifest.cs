﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models.Api
{
    public class DeviceManifest
    {
        public string Name { get; set; }
        public uint ClockFrequencyHz { get; set; }
        public IEnumerable<string> SupportedCommunicationChannelNames { get; set; } = Enumerable.Empty<string>();
        public string DefaultCommunicationChannelName { get; set; }
        public uint AvailableMemoryBytes { get; set; }
    }
}
