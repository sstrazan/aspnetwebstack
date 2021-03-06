﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Net.Http;

namespace System.Web.Http
{
    /// <summary>
    /// Specifies that an action supports the DELETE HTTP method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class HttpDeleteAttribute : AcceptVerbsAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpDeleteAttribute" /> class.
        /// </summary>
        public HttpDeleteAttribute()
            : base(HttpMethod.Delete)
        {
        }
    }
}
