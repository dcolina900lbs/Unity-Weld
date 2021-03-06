using UnityEngine;

namespace UnityWeld.Binding.Adapters
{
    /// <summary>
    /// Options for converting from a bool to a Unity color.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Weld/Adapter Options/Bool to Color Adapter Options")]
    public class BoolToColorAdapterOptions : AdapterOptions
    {
        /// <summary>
        /// The value used when the bool is false.
        /// </summary>
        public Color FalseColor;

        /// <summary>
        /// The value used when the bool is true.
        /// </summary>
        public Color TrueColor;
    }
}