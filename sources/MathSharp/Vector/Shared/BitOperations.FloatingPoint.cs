﻿using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using MathSharp.Attributes;

namespace MathSharp
{
    using Vector4Single = Vector128<float>;
    using Vector4SingleParam1_3 = Vector128<float>;

    using Vector4Double = Vector256<double>;
    using Vector4DoubleParam1_3 = Vector256<double>;

    public static partial class Vector
    {
        public static readonly Vector128<float> MaskXSingle = Vector128.Create(+0, -1, -1, -1).AsSingle();
        public static readonly Vector128<float> MaskYSingle = Vector128.Create(-1, +0, -1, -1).AsSingle();
        public static readonly Vector128<float> MaskZSingle = Vector128.Create(-1, -1, +0, -1).AsSingle();
        public static readonly Vector128<float> MaskWSingle = Vector128.Create(-1, -1, -1, +0).AsSingle();
        public static readonly Vector128<float> MaskZAndWSingle = Vector128.Create(-1, -1, +0, +0).AsSingle();

        #region Vector128

        [UsesInstructionSet(InstructionSets.Sse)]
        [MethodImpl(MaxOpt)]
        public static Vector4Single Or(Vector4SingleParam1_3 left, Vector4SingleParam1_3 right)
        {
            if (Sse.IsSupported)
            {
                return Sse.Or(left, right);
            }

            return SoftwareFallbacks.Or_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Sse)]
        [MethodImpl(MaxOpt)]
        public static Vector4Single And(Vector4SingleParam1_3 left, Vector4SingleParam1_3 right)
        {
            if (Sse.IsSupported)
            {
                return Sse.And(left, right);
            }

            return SoftwareFallbacks.And_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Sse)]
        [MethodImpl(MaxOpt)]
        public static Vector4Single Xor(Vector4SingleParam1_3 left, Vector4SingleParam1_3 right)
        {
            if (Sse.IsSupported)
            {
                return Sse.Xor(left, right);
            }

            return SoftwareFallbacks.Xor_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Sse)]
        [MethodImpl(MaxOpt)]
        public static Vector4Single Not(Vector4SingleParam1_3 vector)
        {
            if (Sse.IsSupported)
            {
                Vector4Single mask = Vector128.Create(-1, -1, -1, -1).AsSingle();
                return Sse.AndNot(vector, mask);
            }

            return SoftwareFallbacks.Not_Software(vector);
        }

        [UsesInstructionSet(InstructionSets.Sse)]
        [MethodImpl(MaxOpt)]
        public static Vector4Single AndNot(Vector4SingleParam1_3 left, Vector4SingleParam1_3 right)
        {
            if (Sse.IsSupported)
            {
                return Sse.AndNot(left, right);
            }

            return SoftwareFallbacks.AndNot_Software(left, right);
        }

        #endregion

        #region Vector256

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4Double Or(Vector4DoubleParam1_3 left, Vector4DoubleParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Or(left, right);
            }

            return SoftwareFallbacks.Or_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4Double And(Vector4DoubleParam1_3 left, Vector4DoubleParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.And(left, right);
            }

            return SoftwareFallbacks.And_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4Double Xor(Vector4DoubleParam1_3 left, Vector4DoubleParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.Xor(left, right);
            }

            return SoftwareFallbacks.Xor_Software(left, right);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4Double Not(Vector4DoubleParam1_3 vector)
        {
            if (Avx.IsSupported)
            {
                Vector4Double mask = Vector256.Create(-1, -1, -1, -1).AsDouble();
                return Avx.AndNot(vector, mask);
            }

            return SoftwareFallbacks.Not_Software(vector);
        }

        [UsesInstructionSet(InstructionSets.Avx)]
        [MethodImpl(MaxOpt)]
        public static Vector4Double AndNot(Vector4DoubleParam1_3 left, Vector4DoubleParam1_3 right)
        {
            if (Avx.IsSupported)
            {
                return Avx.AndNot(left, right);
            }

            return SoftwareFallbacks.AndNot_Software(left, right);
        }

        #endregion
    }
}
