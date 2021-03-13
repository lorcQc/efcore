// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Utilities;

#nullable enable

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    ///     Extension methods for <see cref="IReadOnlyModel" />.
    /// </summary>
    [Obsolete("Use IReadOnlyModel")]
    public static class ModelExtensions
    {
        /// <summary>
        ///     Gets the entity that maps the given entity class. Returns <see langword="null" /> if no entity type with
        ///     the given CLR type is found or the given CLR type is being used by shared type entity type
        ///     or the entity type has a defining navigation.
        /// </summary>
        /// <param name="model"> The model to find the entity type in. </param>
        /// <param name="type"> The type to find the corresponding entity type for. </param>
        /// <returns> The entity type, or <see langword="null" /> if none is found. </returns>
        [DebuggerStepThrough]
        [Obsolete("Use IReadOnlyEntityType.FindEntityType")]
        public static IReadOnlyEntityType? FindEntityType([NotNull] this IModel model, [NotNull] Type type)
            => model.FindEntityType(Check.NotNull(type, nameof(type)));

        /// <summary>
        ///     Gets the entity types matching the given type.
        /// </summary>
        /// <param name="model"> The model to find the entity type in. </param>
        /// <param name="type"> The type of the entity type to find. </param>
        /// <returns> The entity types found. </returns>
        [DebuggerStepThrough]
        [Obsolete("Use IReadOnlyEntityType.FindEntityTypes")]
        public static IEnumerable<IReadOnlyEntityType> GetEntityTypes([NotNull] this IModel model, [NotNull] Type type)
            => model.FindEntityTypes(type);

        /// <summary>
        ///     Gets the entity types matching the given name.
        /// </summary>
        /// <param name="model"> The model to find the entity type in. </param>
        /// <param name="name"> The name of the entity type to find. </param>
        /// <returns> The entity types found. </returns>
        [DebuggerStepThrough]
        [Obsolete("Use FindEntityTypes(Type) or FindEntityType(string)")]
        public static IReadOnlyCollection<IReadOnlyEntityType> GetEntityTypes([NotNull] this IModel model, [NotNull] string name)
            => ((Model)model).GetEntityTypes(name);

        /// <summary>
        ///     Gets a value indicating whether the model contains a corresponding entity type with a defining navigation.
        /// </summary>
        /// <param name="model"> The model to find the entity type in. </param>
        /// <param name="type"> The type used to find an entity type a defining navigation. </param>
        /// <returns> <see langword="true" /> if the model contains a corresponding entity type with a defining navigation. </returns>
        [DebuggerStepThrough]
        [Obsolete("Use IsShared(Type)")]
        public static bool HasEntityTypeWithDefiningNavigation([NotNull] this IModel model, [NotNull] Type type)
            => model.IsShared(type);

        /// <summary>
        ///     Gets a value indicating whether the model contains a corresponding entity type with a defining navigation.
        /// </summary>
        /// <param name="model"> The model to find the entity type in. </param>
        /// <param name="name"> The name used to find an entity type with a defining navigation. </param>
        /// <returns> <see langword="true" /> if the model contains a corresponding entity type with a defining navigation. </returns>
        [DebuggerStepThrough]
        [Obsolete("Use FindEntityType(string)?.HasSharedClrType")]
        public static bool HasEntityTypeWithDefiningNavigation([NotNull] this IModel model, [NotNull] string name)
            => model.FindEntityType(name)?.HasSharedClrType ?? false;
    }
}
