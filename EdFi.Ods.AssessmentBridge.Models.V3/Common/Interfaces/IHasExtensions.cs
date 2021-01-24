using System.Collections;

namespace EdFi.Ods.Common
{
    /// <summary>
    /// Defines a property for accessing named extensions to an Ed-Fi Standard resource or entity.
    /// </summary>
    public interface IHasExtensions
    {
        /// <summary>
        /// Gets or sets the named entity extensions to the containing Ed-Fi Standard resource or entity.
        /// </summary>
        IDictionary Extensions { get; set; }
    }
}
