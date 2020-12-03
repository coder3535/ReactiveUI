﻿// Copyright (c) 2020 .NET Foundation and Contributors. All rights reserved.
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Reactive.Concurrency;
using Splat;

namespace ReactiveUI
{
    /// <summary>
    /// Platform registrations for a .NET Core application.
    /// </summary>
    public class PlatformRegistrations : IWantsToRegisterStuff
    {
        /// <inheritdoc/>
        public void Register(Action<Func<object>, Type> registerFunction)
        {
            if (!ModeDetector.InUnitTestRunner())
            {
                RxApp.TaskpoolScheduler = TaskPoolScheduler.Default;
                RxApp.MainThreadScheduler = DefaultScheduler.Instance;
            }
        }
    }
}