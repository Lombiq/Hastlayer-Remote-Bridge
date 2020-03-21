using System.Collections.Generic;

namespace Hast.Remote.Bridge.Models
{
    public class TransformationResult
    {
        public string RemoteHastlayerVersion { get; set; }
        public HardwareDescription HardwareDescription { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
