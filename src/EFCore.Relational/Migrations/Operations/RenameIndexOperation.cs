// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using JetBrains.Annotations;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    /// <summary>
    ///     A <see cref="MigrationOperation" /> for renaming an existing index.
    /// </summary>
    [DebuggerDisplay("ALTER INDEX {Name} RENAME TO {NewName}")]
    public class RenameIndexOperation : MigrationOperation
    {
        /// <summary>
        ///     The old name of the index.
        /// </summary>
        public virtual string Name { get; [param: NotNull] set; } = null!;

        /// <summary>
        ///     The new name for the index.
        /// </summary>
        public virtual string NewName { get; [param: NotNull] set; } = null!;

        /// <summary>
        ///     The schema that contains the table, or <see langword="null" /> if the default schema should be used.
        /// </summary>
        public virtual string? Schema { get; [param: CanBeNull] set; }

        /// <summary>
        ///     The name of the table that contains the index.
        /// </summary>
        public virtual string? Table { get; [param: CanBeNull] set; }
    }
}
