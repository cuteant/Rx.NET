using System;
using System.Reflection;

[assembly: AssemblyTitle("System.Reactive.Windows.Threading")]
#if !USE_SL_DISPATCHER
// Notice: same description as in the .nuspec files; see Source/Rx/Setup/NuGet
[assembly: AssemblyDescription("Windows Presentation Foundation extensions library for Rx. Contains scheduler functionality for the WPF Dispatcher.")]
#else
// Notice: same description as in the .nuspec files; see Source/Rx/Setup/NuGet
[assembly: AssemblyDescription("Silverlight extensions library for Rx. Contains scheduler functionality for the Silverlight Dispatcher.")]
#endif
