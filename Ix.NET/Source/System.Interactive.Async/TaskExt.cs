// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 
using System.Collections.Generic;

namespace System.Threading.Tasks
{
  static class TaskExt
  {
#if NET40
    public static readonly Task<bool> True = TaskEx.FromResult(true);
    public static readonly Task<bool> False = TaskEx.FromResult(false);
#else
    public static readonly Task<bool> True = Task.FromResult(true);
    public static readonly Task<bool> False = Task.FromResult(false);
#endif
  }
}
