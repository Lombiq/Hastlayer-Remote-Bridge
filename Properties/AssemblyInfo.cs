using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Hast.Remote.Bridge")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a9d9fec6-20ce-48f5-9d94-1919b2b0ace2")]

// Copying these attributes here because since this project is also added to Lombiq.Tenants SharedAssemblyInfo.cs can't
// be used. Version attributes are intentionally not added, not to have to maintain them (and versions for this assembly
// don't really matter).
[assembly: AssemblyCompany("Lombiq Technologies Ltd.")]
[assembly: AssemblyProduct("Hastlayer (hastlayer.com)")]
[assembly: AssemblyCopyright("Copyright © 2015-2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyVersion("1.1.0.0")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
