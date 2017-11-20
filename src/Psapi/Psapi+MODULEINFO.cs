﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace PInvoke
{
    using System;
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="MODULEINFO"/> nested type.
    /// </content>
    public static partial class Psapi
    {
        /// <summary>
        /// The MODULEINFO structure specifies processmodules properties.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        [OfferIntPtrPropertyAccessors]
        public partial struct MODULEINFO
        {
            /// <summary>
            /// The base address of the module
            /// </summary>
            public IntPtr lpBaseOfDll;

            /// <summary>
            /// The size of the module
            /// </summary>
            public uint SizeOfImage;

            /// <summary>
            /// The entry point of the module
            /// </summary>
            public IntPtr EntryPoint;
        }
    }
}