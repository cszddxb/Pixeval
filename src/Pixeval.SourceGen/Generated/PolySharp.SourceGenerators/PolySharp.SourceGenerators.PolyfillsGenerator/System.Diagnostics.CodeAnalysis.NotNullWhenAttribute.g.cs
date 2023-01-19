﻿// <auto-generated/>
#pragma warning disable
#nullable enable annotations

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that when a method returns <see cref="ReturnValue"/>, the parameter will not be null even if the corresponding type allows it.
    /// </summary>
    [global::System.AttributeUsage(global::System.AttributeTargets.Parameter, Inherited = false)]
    internal sealed class NotNullWhenAttribute : global::System.Attribute
    {
        /// <summary>
        /// Initializes the attribute with the specified return value condition.
        /// </summary>
        /// <param name="returnValue">The return value condition. If the method returns this value, the associated parameter will not be null.</param>
        public NotNullWhenAttribute(bool returnValue)
        {
            ReturnValue = returnValue;
        }

        /// <summary>Gets the return value condition.</summary>
        public bool ReturnValue { get; }
    }
}