﻿using UnityEngine;

namespace UnityWeld.Binding.Adapters
{
    /// <summary>
    /// Options for converting from a bool to a string.
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Weld/Adapter Options/Bool to String Adapter")]
    public class BoolToStringAdapterOptions : AdapterOptions
    {
        /// <summary>
        /// The value used when the bool is set to true.
        /// </summary>
        public string TrueValueString;

        /// <summary>
        /// The value used when the bool is set to false.
        /// </summary>
        public string FalseValueString;
    }
}