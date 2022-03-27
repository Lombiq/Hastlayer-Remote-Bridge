using System.Collections.Generic;

namespace Hast.Remote.Bridge.Models;

public class TransformationRequest
{
    public HardwareGenerationConfiguration Configuration { get; set; }
    public IEnumerable<AssemblyContainer> Assemblies { get; set; }
}
