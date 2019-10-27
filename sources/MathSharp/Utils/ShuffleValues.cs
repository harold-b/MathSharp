﻿using System.Runtime.Intrinsics;
// ReSharper disable IdentifierTypo

// ReSharper disable InconsistentNaming
namespace MathSharp.Utils
{
    /// <summary>
    /// Values used in <see cref="Vector.Shuffle(Vector128{float}, Vector128{float}, byte)"/>,
    /// <see cref="Vector.Shuffle(Vector256{double}, Vector256{double}, byte)"/>,
    /// <see cref="Vector.Permute(Vector128{float}, byte)"/>,
    /// <see cref="Vector.Permute(Vector256{double}, byte)"/>,
    /// methods to dictate the ordering of the resultant vectors
    /// </summary>
    /// <example>
    /// To reverse a vector (x, y, z, w), to (w, z, y, x), you would do
    /// <code>
    /// Vector.Permute(vector, <see cref="_3_2_1_0"/>)
    /// </code>
    /// which selects the 4th, then 3rd, then 2nd, then 1st element
    /// </example>
    public static class ShuffleValues
    {
        public const byte _0_0_0_0 = (0 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte _1_0_0_0 = (0 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte _2_0_0_0 = (0 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte _3_0_0_0 = (0 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte _0_1_0_0 = (0 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte _1_1_0_0 = (0 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte _2_1_0_0 = (0 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte _3_1_0_0 = (0 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte _0_2_0_0 = (0 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte _1_2_0_0 = (0 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte _2_2_0_0 = (0 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte _3_2_0_0 = (0 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte _0_3_0_0 = (0 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte _1_3_0_0 = (0 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte _2_3_0_0 = (0 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte _3_3_0_0 = (0 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte _0_0_1_0 = (0 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte _1_0_1_0 = (0 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte _2_0_1_0 = (0 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte _3_0_1_0 = (0 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte _0_1_1_0 = (0 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte _1_1_1_0 = (0 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte _2_1_1_0 = (0 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte _3_1_1_0 = (0 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte _0_2_1_0 = (0 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte _1_2_1_0 = (0 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte _2_2_1_0 = (0 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte _3_2_1_0 = (0 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte _0_3_1_0 = (0 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte _1_3_1_0 = (0 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte _2_3_1_0 = (0 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte _3_3_1_0 = (0 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte _0_0_2_0 = (0 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte _1_0_2_0 = (0 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte _2_0_2_0 = (0 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte _3_0_2_0 = (0 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte _0_1_2_0 = (0 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte _1_1_2_0 = (0 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte _2_1_2_0 = (0 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte _3_1_2_0 = (0 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte _0_2_2_0 = (0 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte _1_2_2_0 = (0 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte _2_2_2_0 = (0 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte _3_2_2_0 = (0 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte _0_3_2_0 = (0 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte _1_3_2_0 = (0 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte _2_3_2_0 = (0 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte _3_3_2_0 = (0 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte _0_0_3_0 = (0 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte _1_0_3_0 = (0 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte _2_0_3_0 = (0 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte _3_0_3_0 = (0 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte _0_1_3_0 = (0 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte _1_1_3_0 = (0 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte _2_1_3_0 = (0 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte _3_1_3_0 = (0 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte _0_2_3_0 = (0 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte _1_2_3_0 = (0 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte _2_2_3_0 = (0 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte _3_2_3_0 = (0 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte _0_3_3_0 = (0 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte _1_3_3_0 = (0 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte _2_3_3_0 = (0 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte _3_3_3_0 = (0 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte _0_0_0_1 = (1 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte _1_0_0_1 = (1 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte _2_0_0_1 = (1 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte _3_0_0_1 = (1 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte _0_1_0_1 = (1 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte _1_1_0_1 = (1 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte _2_1_0_1 = (1 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte _3_1_0_1 = (1 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte _0_2_0_1 = (1 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte _1_2_0_1 = (1 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte _2_2_0_1 = (1 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte _3_2_0_1 = (1 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte _0_3_0_1 = (1 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte _1_3_0_1 = (1 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte _2_3_0_1 = (1 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte _3_3_0_1 = (1 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte _0_0_1_1 = (1 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte _1_0_1_1 = (1 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte _2_0_1_1 = (1 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte _3_0_1_1 = (1 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte _0_1_1_1 = (1 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte _1_1_1_1 = (1 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte _2_1_1_1 = (1 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte _3_1_1_1 = (1 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte _0_2_1_1 = (1 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte _1_2_1_1 = (1 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte _2_2_1_1 = (1 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte _3_2_1_1 = (1 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte _0_3_1_1 = (1 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte _1_3_1_1 = (1 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte _2_3_1_1 = (1 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte _3_3_1_1 = (1 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte _0_0_2_1 = (1 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte _1_0_2_1 = (1 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte _2_0_2_1 = (1 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte _3_0_2_1 = (1 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte _0_1_2_1 = (1 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte _1_1_2_1 = (1 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte _2_1_2_1 = (1 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte _3_1_2_1 = (1 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte _0_2_2_1 = (1 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte _1_2_2_1 = (1 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte _2_2_2_1 = (1 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte _3_2_2_1 = (1 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte _0_3_2_1 = (1 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte _1_3_2_1 = (1 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte _2_3_2_1 = (1 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte _3_3_2_1 = (1 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte _0_0_3_1 = (1 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte _1_0_3_1 = (1 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte _2_0_3_1 = (1 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte _3_0_3_1 = (1 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte _0_1_3_1 = (1 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte _1_1_3_1 = (1 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte _2_1_3_1 = (1 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte _3_1_3_1 = (1 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte _0_2_3_1 = (1 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte _1_2_3_1 = (1 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte _2_2_3_1 = (1 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte _3_2_3_1 = (1 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte _0_3_3_1 = (1 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte _1_3_3_1 = (1 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte _2_3_3_1 = (1 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte _3_3_3_1 = (1 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte _0_0_0_2 = (2 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte _1_0_0_2 = (2 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte _2_0_0_2 = (2 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte _3_0_0_2 = (2 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte _0_1_0_2 = (2 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte _1_1_0_2 = (2 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte _2_1_0_2 = (2 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte _3_1_0_2 = (2 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte _0_2_0_2 = (2 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte _1_2_0_2 = (2 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte _2_2_0_2 = (2 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte _3_2_0_2 = (2 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte _0_3_0_2 = (2 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte _1_3_0_2 = (2 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte _2_3_0_2 = (2 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte _3_3_0_2 = (2 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte _0_0_1_2 = (2 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte _1_0_1_2 = (2 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte _2_0_1_2 = (2 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte _3_0_1_2 = (2 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte _0_1_1_2 = (2 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte _1_1_1_2 = (2 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte _2_1_1_2 = (2 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte _3_1_1_2 = (2 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte _0_2_1_2 = (2 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte _1_2_1_2 = (2 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte _2_2_1_2 = (2 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte _3_2_1_2 = (2 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte _0_3_1_2 = (2 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte _1_3_1_2 = (2 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte _2_3_1_2 = (2 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte _3_3_1_2 = (2 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte _0_0_2_2 = (2 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte _1_0_2_2 = (2 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte _2_0_2_2 = (2 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte _3_0_2_2 = (2 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte _0_1_2_2 = (2 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte _1_1_2_2 = (2 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte _2_1_2_2 = (2 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte _3_1_2_2 = (2 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte _0_2_2_2 = (2 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte _1_2_2_2 = (2 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte _2_2_2_2 = (2 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte _3_2_2_2 = (2 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte _0_3_2_2 = (2 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte _1_3_2_2 = (2 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte _2_3_2_2 = (2 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte _3_3_2_2 = (2 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte _0_0_3_2 = (2 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte _1_0_3_2 = (2 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte _2_0_3_2 = (2 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte _3_0_3_2 = (2 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte _0_1_3_2 = (2 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte _1_1_3_2 = (2 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte _2_1_3_2 = (2 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte _3_1_3_2 = (2 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte _0_2_3_2 = (2 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte _1_2_3_2 = (2 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte _2_2_3_2 = (2 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte _3_2_3_2 = (2 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte _0_3_3_2 = (2 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte _1_3_3_2 = (2 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte _2_3_3_2 = (2 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte _3_3_3_2 = (2 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte _0_0_0_3 = (3 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte _1_0_0_3 = (3 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte _2_0_0_3 = (3 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte _3_0_0_3 = (3 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte _0_1_0_3 = (3 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte _1_1_0_3 = (3 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte _2_1_0_3 = (3 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte _3_1_0_3 = (3 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte _0_2_0_3 = (3 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte _1_2_0_3 = (3 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte _2_2_0_3 = (3 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte _3_2_0_3 = (3 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte _0_3_0_3 = (3 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte _1_3_0_3 = (3 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte _2_3_0_3 = (3 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte _3_3_0_3 = (3 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte _0_0_1_3 = (3 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte _1_0_1_3 = (3 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte _2_0_1_3 = (3 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte _3_0_1_3 = (3 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte _0_1_1_3 = (3 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte _1_1_1_3 = (3 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte _2_1_1_3 = (3 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte _3_1_1_3 = (3 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte _0_2_1_3 = (3 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte _1_2_1_3 = (3 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte _2_2_1_3 = (3 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte _3_2_1_3 = (3 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte _0_3_1_3 = (3 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte _1_3_1_3 = (3 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte _2_3_1_3 = (3 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte _3_3_1_3 = (3 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte _0_0_2_3 = (3 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte _1_0_2_3 = (3 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte _2_0_2_3 = (3 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte _3_0_2_3 = (3 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte _0_1_2_3 = (3 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte _1_1_2_3 = (3 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte _2_1_2_3 = (3 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte _3_1_2_3 = (3 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte _0_2_2_3 = (3 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte _1_2_2_3 = (3 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte _2_2_2_3 = (3 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte _3_2_2_3 = (3 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte _0_3_2_3 = (3 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte _1_3_2_3 = (3 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte _2_3_2_3 = (3 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte _3_3_2_3 = (3 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte _0_0_3_3 = (3 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte _1_0_3_3 = (3 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte _2_0_3_3 = (3 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte _3_0_3_3 = (3 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte _0_1_3_3 = (3 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte _1_1_3_3 = (3 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte _2_1_3_3 = (3 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte _3_1_3_3 = (3 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte _0_2_3_3 = (3 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte _1_2_3_3 = (3 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte _2_2_3_3 = (3 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte _3_2_3_3 = (3 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte _0_3_3_3 = (3 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte _1_3_3_3 = (3 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte _2_3_3_3 = (3 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte _3_3_3_3 = (3 << 6) | (3 << 4) | (3 << 2) | 3;

        public const byte XXXX = (0 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte YXXX = (0 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte ZXXX = (0 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte WXXX = (0 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte XYXX = (0 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte YYXX = (0 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte ZYXX = (0 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte WYXX = (0 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte XZXX = (0 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte YZXX = (0 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte ZZXX = (0 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte WZXX = (0 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte XWXX = (0 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte YWXX = (0 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte ZWXX = (0 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte WWXX = (0 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte XXYX = (0 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte YXYX = (0 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte ZXYX = (0 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte WXYX = (0 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte XYYX = (0 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte YYYX = (0 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte ZYYX = (0 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte WYYX = (0 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte XZYX = (0 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte YZYX = (0 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte ZZYX = (0 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte WZYX = (0 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte XWYX = (0 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte YWYX = (0 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte ZWYX = (0 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte WWYX = (0 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte XXZX = (0 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte YXZX = (0 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte ZXZX = (0 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte WXZX = (0 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte XYZX = (0 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte YYZX = (0 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte ZYZX = (0 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte WYZX = (0 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte XZZX = (0 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte YZZX = (0 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte ZZZX = (0 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte WZZX = (0 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte XWZX = (0 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte YWZX = (0 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte ZWZX = (0 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte WWZX = (0 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte XXWX = (0 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte YXWX = (0 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte ZXWX = (0 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte WXWX = (0 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte XYWX = (0 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte YYWX = (0 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte ZYWX = (0 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte WYWX = (0 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte XZWX = (0 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte YZWX = (0 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte ZZWX = (0 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte WZWX = (0 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte XWWX = (0 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte YWWX = (0 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte ZWWX = (0 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte WWWX = (0 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte XXXY = (1 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte YXXY = (1 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte ZXXY = (1 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte WXXY = (1 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte XYXY = (1 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte YYXY = (1 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte ZYXY = (1 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte WYXY = (1 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte XZXY = (1 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte YZXY = (1 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte ZZXY = (1 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte WZXY = (1 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte XWXY = (1 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte YWXY = (1 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte ZWXY = (1 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte WWXY = (1 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte XXYY = (1 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte YXYY = (1 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte ZXYY = (1 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte WXYY = (1 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte XYYY = (1 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte YYYY = (1 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte ZYYY = (1 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte WYYY = (1 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte XZYY = (1 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte YZYY = (1 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte ZZYY = (1 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte WZYY = (1 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte XWYY = (1 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte YWYY = (1 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte ZWYY = (1 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte WWYY = (1 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte XXZY = (1 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte YXZY = (1 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte ZXZY = (1 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte WXZY = (1 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte XYZY = (1 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte YYZY = (1 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte ZYZY = (1 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte WYZY = (1 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte XZZY = (1 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte YZZY = (1 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte ZZZY = (1 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte WZZY = (1 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte XWZY = (1 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte YWZY = (1 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte ZWZY = (1 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte WWZY = (1 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte XXWY = (1 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte YXWY = (1 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte ZXWY = (1 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte WXWY = (1 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte XYWY = (1 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte YYWY = (1 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte ZYWY = (1 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte WYWY = (1 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte XZWY = (1 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte YZWY = (1 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte ZZWY = (1 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte WZWY = (1 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte XWWY = (1 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte YWWY = (1 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte ZWWY = (1 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte WWWY = (1 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte XXXZ = (2 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte YXXZ = (2 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte ZXXZ = (2 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte WXXZ = (2 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte XYXZ = (2 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte YYXZ = (2 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte ZYXZ = (2 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte WYXZ = (2 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte XZXZ = (2 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte YZXZ = (2 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte ZZXZ = (2 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte WZXZ = (2 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte XWXZ = (2 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte YWXZ = (2 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte ZWXZ = (2 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte WWXZ = (2 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte XXYZ = (2 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte YXYZ = (2 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte ZXYZ = (2 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte WXYZ = (2 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte XYYZ = (2 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte YYYZ = (2 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte ZYYZ = (2 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte WYYZ = (2 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte XZYZ = (2 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte YZYZ = (2 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte ZZYZ = (2 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte WZYZ = (2 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte XWYZ = (2 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte YWYZ = (2 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte ZWYZ = (2 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte WWYZ = (2 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte XXZZ = (2 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte YXZZ = (2 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte ZXZZ = (2 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte WXZZ = (2 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte XYZZ = (2 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte YYZZ = (2 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte ZYZZ = (2 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte WYZZ = (2 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte XZZZ = (2 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte YZZZ = (2 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte ZZZZ = (2 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte WZZZ = (2 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte XWZZ = (2 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte YWZZ = (2 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte ZWZZ = (2 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte WWZZ = (2 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte XXWZ = (2 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte YXWZ = (2 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte ZXWZ = (2 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte WXWZ = (2 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte XYWZ = (2 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte YYWZ = (2 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte ZYWZ = (2 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte WYWZ = (2 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte XZWZ = (2 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte YZWZ = (2 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte ZZWZ = (2 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte WZWZ = (2 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte XWWZ = (2 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte YWWZ = (2 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte ZWWZ = (2 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte WWWZ = (2 << 6) | (3 << 4) | (3 << 2) | 3;
        public const byte XXXW = (3 << 6) | (0 << 4) | (0 << 2) | 0;
        public const byte YXXW = (3 << 6) | (0 << 4) | (0 << 2) | 1;
        public const byte ZXXW = (3 << 6) | (0 << 4) | (0 << 2) | 2;
        public const byte WXXW = (3 << 6) | (0 << 4) | (0 << 2) | 3;
        public const byte XYXW = (3 << 6) | (0 << 4) | (1 << 2) | 0;
        public const byte YYXW = (3 << 6) | (0 << 4) | (1 << 2) | 1;
        public const byte ZYXW = (3 << 6) | (0 << 4) | (1 << 2) | 2;
        public const byte WYXW = (3 << 6) | (0 << 4) | (1 << 2) | 3;
        public const byte XZXW = (3 << 6) | (0 << 4) | (2 << 2) | 0;
        public const byte YZXW = (3 << 6) | (0 << 4) | (2 << 2) | 1;
        public const byte ZZXW = (3 << 6) | (0 << 4) | (2 << 2) | 2;
        public const byte WZXW = (3 << 6) | (0 << 4) | (2 << 2) | 3;
        public const byte XWXW = (3 << 6) | (0 << 4) | (3 << 2) | 0;
        public const byte YWXW = (3 << 6) | (0 << 4) | (3 << 2) | 1;
        public const byte ZWXW = (3 << 6) | (0 << 4) | (3 << 2) | 2;
        public const byte WWXW = (3 << 6) | (0 << 4) | (3 << 2) | 3;
        public const byte XXYW = (3 << 6) | (1 << 4) | (0 << 2) | 0;
        public const byte YXYW = (3 << 6) | (1 << 4) | (0 << 2) | 1;
        public const byte ZXYW = (3 << 6) | (1 << 4) | (0 << 2) | 2;
        public const byte WXYW = (3 << 6) | (1 << 4) | (0 << 2) | 3;
        public const byte XYYW = (3 << 6) | (1 << 4) | (1 << 2) | 0;
        public const byte YYYW = (3 << 6) | (1 << 4) | (1 << 2) | 1;
        public const byte ZYYW = (3 << 6) | (1 << 4) | (1 << 2) | 2;
        public const byte WYYW = (3 << 6) | (1 << 4) | (1 << 2) | 3;
        public const byte XZYW = (3 << 6) | (1 << 4) | (2 << 2) | 0;
        public const byte YZYW = (3 << 6) | (1 << 4) | (2 << 2) | 1;
        public const byte ZZYW = (3 << 6) | (1 << 4) | (2 << 2) | 2;
        public const byte WZYW = (3 << 6) | (1 << 4) | (2 << 2) | 3;
        public const byte XWYW = (3 << 6) | (1 << 4) | (3 << 2) | 0;
        public const byte YWYW = (3 << 6) | (1 << 4) | (3 << 2) | 1;
        public const byte ZWYW = (3 << 6) | (1 << 4) | (3 << 2) | 2;
        public const byte WWYW = (3 << 6) | (1 << 4) | (3 << 2) | 3;
        public const byte XXZW = (3 << 6) | (2 << 4) | (0 << 2) | 0;
        public const byte YXZW = (3 << 6) | (2 << 4) | (0 << 2) | 1;
        public const byte ZXZW = (3 << 6) | (2 << 4) | (0 << 2) | 2;
        public const byte WXZW = (3 << 6) | (2 << 4) | (0 << 2) | 3;
        public const byte XYZW = (3 << 6) | (2 << 4) | (1 << 2) | 0;
        public const byte YYZW = (3 << 6) | (2 << 4) | (1 << 2) | 1;
        public const byte ZYZW = (3 << 6) | (2 << 4) | (1 << 2) | 2;
        public const byte WYZW = (3 << 6) | (2 << 4) | (1 << 2) | 3;
        public const byte XZZW = (3 << 6) | (2 << 4) | (2 << 2) | 0;
        public const byte YZZW = (3 << 6) | (2 << 4) | (2 << 2) | 1;
        public const byte ZZZW = (3 << 6) | (2 << 4) | (2 << 2) | 2;
        public const byte WZZW = (3 << 6) | (2 << 4) | (2 << 2) | 3;
        public const byte XWZW = (3 << 6) | (2 << 4) | (3 << 2) | 0;
        public const byte YWZW = (3 << 6) | (2 << 4) | (3 << 2) | 1;
        public const byte ZWZW = (3 << 6) | (2 << 4) | (3 << 2) | 2;
        public const byte WWZW = (3 << 6) | (2 << 4) | (3 << 2) | 3;
        public const byte XXWW = (3 << 6) | (3 << 4) | (0 << 2) | 0;
        public const byte YXWW = (3 << 6) | (3 << 4) | (0 << 2) | 1;
        public const byte ZXWW = (3 << 6) | (3 << 4) | (0 << 2) | 2;
        public const byte WXWW = (3 << 6) | (3 << 4) | (0 << 2) | 3;
        public const byte XYWW = (3 << 6) | (3 << 4) | (1 << 2) | 0;
        public const byte YYWW = (3 << 6) | (3 << 4) | (1 << 2) | 1;
        public const byte ZYWW = (3 << 6) | (3 << 4) | (1 << 2) | 2;
        public const byte WYWW = (3 << 6) | (3 << 4) | (1 << 2) | 3;
        public const byte XZWW = (3 << 6) | (3 << 4) | (2 << 2) | 0;
        public const byte YZWW = (3 << 6) | (3 << 4) | (2 << 2) | 1;
        public const byte ZZWW = (3 << 6) | (3 << 4) | (2 << 2) | 2;
        public const byte WZWW = (3 << 6) | (3 << 4) | (2 << 2) | 3;
        public const byte XWWW = (3 << 6) | (3 << 4) | (3 << 2) | 0;
        public const byte YWWW = (3 << 6) | (3 << 4) | (3 << 2) | 1;
        public const byte ZWWW = (3 << 6) | (3 << 4) | (3 << 2) | 2;
        public const byte WWWW = (3 << 6) | (3 << 4) | (3 << 2) | 3;
    }
}
