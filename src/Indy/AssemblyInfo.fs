namespace Indy

open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices

module AssemblyInfo =
    [<Literal>]
    let Version = "0.6.0.0"

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[<assembly: AssemblyTitle("Indy.NET")>]
[<assembly: AssemblyDescription("")>]
[<assembly: AssemblyConfiguration("")>]
[<assembly: AssemblyCompany("")>]
[<assembly: AssemblyProduct("Indy.NET")>]
[<assembly: AssemblyCopyright("Copyright © Will Pitts 2017")>]
[<assembly: AssemblyTrademark("")>]
[<assembly: AssemblyCulture("")>]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[<assembly: ComVisible(false)>]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the ‘*’ as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[<assembly: AssemblyVersion(AssemblyInfo.Version)>]
[<assembly: AssemblyFileVersion("0.6.*")>]
()