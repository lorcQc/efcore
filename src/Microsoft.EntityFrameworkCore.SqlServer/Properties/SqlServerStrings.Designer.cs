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
    public static class SqlServerStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.SqlServer.Properties.SqlServerStrings", typeof(SqlServerStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// Identity value generation cannot be used for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Identity value generation can only be used with signed integer properties.
        /// </summary>
        public static string IdentityBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("IdentityBadType", "property", "entityType", "propertyType"), property, entityType, propertyType);
        }

        /// <summary>
        /// Data type '{dataType}' is not supported in this form. Either specify the length explicitly in the type name, for example as '{dataType}(16)', or remove the data type and use APIs such as HasMaxLength to allow EF choose the data type.
        /// </summary>
        public static string UnqualifiedDataType([CanBeNull] object dataType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnqualifiedDataType", "dataType"), dataType);
        }

        /// <summary>
        /// SQL Server sequences cannot be used to generate values for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Sequences can only be used with integer properties.
        /// </summary>
        public static string SequenceBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("SequenceBadType", "property", "entityType", "propertyType"), property, entityType, propertyType);
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
