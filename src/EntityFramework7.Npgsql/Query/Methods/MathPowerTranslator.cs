﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.Data.Entity.Relational.Query.Methods;

namespace EntityFramework7.Npgsql.Query.Methods
{
    public class MathPowerTranslator : SingleOverloadStaticMethodCallTranslator
    {
        public MathPowerTranslator()
            : base(typeof(Math), "Pow", "POWER")
        {
        }
    }
}