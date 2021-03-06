// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Internal.TypeSystem
{
    public partial class InstantiatedType
    {
        public override PInvokeStringFormat PInvokeStringFormat
        {
            get
            {
                return _typeDef.PInvokeStringFormat;
            }
        }
    }
}
