﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Relational.Metadata;

namespace Npgsql.EntityFramework7.Metadata
{
    public class ReadOnlyNpgsqlForeignKeyExtensions : ReadOnlyRelationalForeignKeyExtensions, INpgsqlForeignKeyExtensions
    {
        protected const string NpgsqlNameAnnotation = NpgsqlAnnotationNames.Prefix + RelationalAnnotationNames.Name;

        public ReadOnlyNpgsqlForeignKeyExtensions([NotNull] IForeignKey foreignKey)
            : base(foreignKey)
        {
        }

        public override string Name
            => ForeignKey[NpgsqlNameAnnotation] as string
               ?? base.Name;
    }
}
