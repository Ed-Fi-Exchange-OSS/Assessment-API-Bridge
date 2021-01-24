namespace EdFi.Ods.Common
{
    /// <summary>
    /// Defines a method for setting a back-reference to a child entity's parent.
    /// </summary>
    public interface IChildEntity
    {
        /// <summary>
        /// Set the child entity's parent reference.
        /// </summary>
        /// <param name="value">The parent reference for the current child entity.</param>
        void SetParent(object value);
    }
}
