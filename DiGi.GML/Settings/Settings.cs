using DiGi.GML.Classes;

namespace DiGi.GML
{
    public static partial class Settings
    {
        /// <summary>
        /// Gets the type manager instance used for handling GML types.
        /// </summary>
        public static TypeManager TypeManager { get; } = Create.TypeManager();
    }
}
