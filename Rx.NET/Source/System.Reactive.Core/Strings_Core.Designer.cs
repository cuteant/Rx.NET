﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reactive {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings_Core {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings_Core() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
#if NET40
          global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Reactive.Strings_Core", typeof(Strings_Core).Assembly);
#else
          global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Reactive.Strings_Core", typeof(Strings_Core).GetTypeInfo().Assembly);
#endif
          resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Using the Scheduler.{0} property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Please include System.Reactive.PlatformServices for your target platform and use the {0}Scheduler type instead. If you&apos;re building a Windows Store app, notice some schedulers are no longer supported. Consider using Scheduler.Default instead. 的本地化字符串。
        /// </summary>
        internal static string CANT_OBTAIN_SCHEDULER {
            get {
                return ResourceManager.GetString("CANT_OBTAIN_SCHEDULER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 OnCompleted notification doesn&apos;t have a value. 的本地化字符串。
        /// </summary>
        internal static string COMPLETED_NO_VALUE {
            get {
                return ResourceManager.GetString("COMPLETED_NO_VALUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Disposable has already been assigned. 的本地化字符串。
        /// </summary>
        internal static string DISPOSABLE_ALREADY_ASSIGNED {
            get {
                return ResourceManager.GetString("DISPOSABLE_ALREADY_ASSIGNED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Disposables collection can not contain null values. 的本地化字符串。
        /// </summary>
        internal static string DISPOSABLES_CANT_CONTAIN_NULL {
            get {
                return ResourceManager.GetString("DISPOSABLES_CANT_CONTAIN_NULL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to start monitoring system clock changes. 的本地化字符串。
        /// </summary>
        internal static string FAILED_CLOCK_MONITORING {
            get {
                return ResourceManager.GetString("FAILED_CLOCK_MONITORING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Heap is empty. 的本地化字符串。
        /// </summary>
        internal static string HEAP_EMPTY {
            get {
                return ResourceManager.GetString("HEAP_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Observer has already terminated. 的本地化字符串。
        /// </summary>
        internal static string OBSERVER_TERMINATED {
            get {
                return ResourceManager.GetString("OBSERVER_TERMINATED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Reentrancy has been detected. 的本地化字符串。
        /// </summary>
        internal static string REENTRANCY_DETECTED {
            get {
                return ResourceManager.GetString("REENTRANCY_DETECTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This scheduler operation has already been awaited. 的本地化字符串。
        /// </summary>
        internal static string SCHEDULER_OPERATION_ALREADY_AWAITED {
            get {
                return ResourceManager.GetString("SCHEDULER_OPERATION_ALREADY_AWAITED", resourceCulture);
            }
        }
    }
}
