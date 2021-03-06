﻿using System;
using System.Collections.Generic;
using OpenTK;
using System.Runtime.Intrinsics;
using Xunit;
using static MathSharp.UnitTests.TestHelpers;

namespace MathSharp.UnitTests.VectorTests.VectorSingle.VectorOperations
{
    public class Length
    {
        public static IEnumerable<object[]> Data(VectorDimensions dimension)
        {
            var objs = new[]
            {
                new object[] {Vector128.Create(0f), default(Vector4)},
                new object[] {Vector128.Create(1f), default(Vector4)},
                new object[] {Vector128.Create(-1f), default(Vector4)},
                new object[] {Vector128.Create(-1f), default(Vector4)},
                new object[] {Vector128.Create(1f, 2f, 3f, 4f), default(Vector4)}, 
                new object[] {Vector128.Create(float.PositiveInfinity), default(Vector4)},
                new object[] {Vector128.Create(float.PositiveInfinity), default(Vector4)},
                new object[] {Vector128.Create(float.NaN), default(Vector4)},
                new object[] {Vector128.Create(float.MaxValue, float.MinValue, float.NaN, 0), default(Vector4)},
            };

            foreach (object[] set in objs)
            {
                switch (dimension)
                {
                    case VectorDimensions.V2D:
                        {
                            Vector2 v1 = ByValToSlowVector2(((Vector128<float>)set[0]));
                            float dot = v1.Length;
                            set[1] = new Vector2(dot);
                            break;
                        }

                    case VectorDimensions.V3D:
                        {
                            Vector3 v1 = ByValToSlowVector3(((Vector128<float>)set[0]));
                            float dot = v1.Length;
                            set[1] = new Vector3(dot);
                            break;
                        }

                    case VectorDimensions.V4D:
                        {
                            Vector4 v1 = ByValToSlowVector4(((Vector128<float>)set[0]));
                            float dot = v1.Length;
                            set[1] = new Vector4(dot);
                            break;
                        }

                    default:
                        throw new ArgumentException(nameof(dimension));
                }
            }

            return objs;
        }

        [Theory]
        [MemberData(nameof(Data), VectorDimensions.V2D)]
        public static void Length2D_Theory(Vector128<float> vector, Vector2 expected)
        {
            Vector128<float> result = Vector.Length2D(vector);

            Assert.True(AreEqual(expected, result), $"Expected {expected}, got {result}");
        }

        [Theory]
        [MemberData(nameof(Data), VectorDimensions.V3D)]
        public static void Length3D_Theory(Vector128<float> vector, Vector3 expected)
        {
            Vector128<float> result = Vector.Length3D(vector);

            Assert.True(AreEqual(expected, result), $"Expected {expected}, got {result}");
        }

        [Theory]
        [MemberData(nameof(Data), VectorDimensions.V4D)]
        public static void Length4D_Theory(Vector128<float> vector, Vector4 expected)
        {
            Vector128<float> result = Vector.Length4D(vector);

            Assert.True(AreEqual(expected, result), $"Expected {expected}, got {result}");
        }
    }
}