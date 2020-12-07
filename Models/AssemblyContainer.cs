using System;

namespace Hast.Remote.Bridge.Models
{
    public class AssemblyContainer
    {
        public string Name { get; set; }

        private byte[] _fileContent;

        public AssemblyContainer(string name, byte[] fileContent)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _fileContent = fileContent ?? throw new ArgumentNullException(nameof(fileContent));
        }

        public byte[] GetFileContent() => _fileContent;
        public void SetFileContent(byte[] value) => _fileContent = value;
    }
}
