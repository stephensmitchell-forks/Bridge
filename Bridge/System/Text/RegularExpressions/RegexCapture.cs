﻿using Bridge;

namespace System.Text.RegularExpressions.CoreFx
{
    /// <summary>
    /// Represents the results from a single successful subexpression capture.
    /// </summary>
    [External]
    public class Capture
    {
        internal Capture()
        {
        }

        /// <summary>
        /// The position in the original string where the first character of the captured substring is found.
        /// </summary>
        public extern int Index { get; }

        /// <summary>
        /// Gets the length of the captured substring.
        /// </summary>
        public extern int Length { get; }

        /// <summary>
        /// Gets the captured substring from the input string.
        /// </summary>
        public extern string Value { get; }

        /// <summary>
        /// Retrieves the captured substring from the input string by calling the Value property. (Overrides Object.ToString().)
        /// </summary>
        public extern override string ToString();
    }
}