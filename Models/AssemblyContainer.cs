using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Hast.Remote.Bridge.Models;

public class AssemblyContainer
{
    public string Name { get; set; }

    // Using a property with the [JsonProperty] attribute makes it serializable even when it's otherwise inaccessible.
    [JsonProperty]
    private byte[] FileContent { get; set; }

    public AssemblyContainer(string name, byte[] fileContent)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        FileContent = fileContent ?? throw new ArgumentNullException(nameof(fileContent));
    }

    public async Task SaveContentToFileStreamAsync(FileStream fileStream, CancellationToken cancellationToken = default)
    {
        // See: https://github.com/microsoft/referencesource/blob/master/mscorlib/system/io/stream.cs#L50-L53
        const int defaultBufferSize = 81920;

        using var memoryStream = new MemoryStream(FileContent);
        await memoryStream.CopyToAsync(
            fileStream,
            Math.Min(FileContent.Length, defaultBufferSize),
            cancellationToken);
    }
}
