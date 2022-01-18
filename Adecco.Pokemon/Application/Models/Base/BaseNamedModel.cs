namespace Adecco.Pokemon.Application.Models.Base
{
    /// <summary>
    /// Base named model.
    /// </summary>
    public abstract class BaseNamedModel
    {
        /// <summary>
        /// The name of this resource
        /// </summary>
        public string Name { get; set; }
    }
}
