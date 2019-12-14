// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.ObjectModel;
using Forked.Runtime.CompilerServices;

namespace Forked.Dynamic.Utils
{
    internal static class EmptyReadOnlyCollection<T>
    {
        public static readonly ReadOnlyCollection<T> Instance = new TrueReadOnlyCollection<T>(Array.Empty<T>());
    }
}
