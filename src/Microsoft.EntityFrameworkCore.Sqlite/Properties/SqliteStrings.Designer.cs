// <auto-generated />
namespace Microsoft.EntityFrameworkCore.Internal
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
    using JetBrains.Annotations;

	/// <summary>
	///		This API supports the Entity Framework Core infrastructure and is not intended to be used 
    ///     directly from your code. This API may change or be removed in future releases.
	/// </summary>
    public static class SqliteStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Sqlite.Properties.SqliteStrings", typeof(SqliteStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// SQLite does not support this migration operation ('{operation}'). For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string InvalidMigrationOperation([CanBeNull] object operation)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidMigrationOperation", "operation"), operation);
        }

        /// <summary>
        /// Generating idempotent scripts for migration is not currently supported by SQLite. For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string MigrationScriptGenerationNotSupported
        {
            get { return GetString("MigrationScriptGenerationNotSupported"); }
        }

        /// <summary>
        /// SQLite does not support schemas. For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string SchemasNotSupported
        {
            get { return GetString("SchemasNotSupported"); }
        }

        /// <summary>
        /// SQLite does not support sequences. For more information, see http://go.microsoft.com/fwlink/?LinkId=723262.
        /// </summary>
        public static string SequencesNotSupported
        {
            get { return GetString("SequencesNotSupported"); }
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
