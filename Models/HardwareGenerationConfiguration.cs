#nullable enable
using System.Collections.Generic;

namespace Hast.Remote.Bridge.Models;

public class HardwareGenerationConfiguration
{
    public string DeviceName { get; set; }
    public IDictionary<string, object> CustomConfiguration { get; }
    public IList<string> HardwareEntryPointMemberFullNames { get; }
    public IList<string> HardwareEntryPointMemberNamePrefixes { get; }

    public HardwareGenerationConfiguration(
        string deviceName,
        IDictionary<string, object>? customConfiguration = null,
        IList<string>? hardwareEntryPointMemberFullNames = null,
        IList<string>? hardwareEntryPointMemberNamePrefixes = null)
    {
        DeviceName = deviceName;
        CustomConfiguration = customConfiguration ?? new Dictionary<string, object>();
        HardwareEntryPointMemberFullNames = hardwareEntryPointMemberFullNames ?? new List<string>();
        HardwareEntryPointMemberNamePrefixes = hardwareEntryPointMemberNamePrefixes ?? new List<string>();
    }
}
