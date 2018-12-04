// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["Add.Byte"] = AddByte,
                ["Add.Int16"] = AddInt16,
                ["Add.Int32"] = AddInt32,
                ["Add.Int64"] = AddInt64,
                ["Add.SByte"] = AddSByte,
                ["Add.UInt16"] = AddUInt16,
                ["Add.UInt32"] = AddUInt32,
                ["Add.UInt64"] = AddUInt64,
                ["AlignRight.SByte.5"] = AlignRightSByte5,
                ["AlignRight.SByte.27"] = AlignRightSByte27,
                ["AlignRight.SByte.228"] = AlignRightSByte228,
                ["AlignRight.SByte.250"] = AlignRightSByte250,
                ["AlignRight.Byte.5"] = AlignRightByte5,
                ["AlignRight.Byte.27"] = AlignRightByte27,
                ["AlignRight.Byte.228"] = AlignRightByte228,
                ["AlignRight.Byte.250"] = AlignRightByte250,
                ["AlignRight.Int16.0"] = AlignRightInt160,
                ["AlignRight.Int16.2"] = AlignRightInt162,
                ["AlignRight.UInt16.0"] = AlignRightUInt160,
                ["AlignRight.UInt16.2"] = AlignRightUInt162,
                ["AlignRight.Int32.0"] = AlignRightInt320,
                ["AlignRight.Int32.4"] = AlignRightInt324,
                ["AlignRight.UInt32.0"] = AlignRightUInt320,
                ["AlignRight.UInt32.4"] = AlignRightUInt324,
                ["AlignRight.Int64.0"] = AlignRightInt640,
                ["AlignRight.Int64.8"] = AlignRightInt648,
                ["AlignRight.UInt64.0"] = AlignRightUInt640,
                ["AlignRight.UInt64.8"] = AlignRightUInt648,
                ["And.Byte"] = AndByte,
                ["And.Int16"] = AndInt16,
                ["And.Int32"] = AndInt32,
                ["And.Int64"] = AndInt64,
                ["And.SByte"] = AndSByte,
                ["And.UInt16"] = AndUInt16,
                ["And.UInt32"] = AndUInt32,
                ["And.UInt64"] = AndUInt64,
                ["AndNot.Byte"] = AndNotByte,
                ["AndNot.Int16"] = AndNotInt16,
                ["AndNot.Int32"] = AndNotInt32,
                ["AndNot.Int64"] = AndNotInt64,
                ["AndNot.SByte"] = AndNotSByte,
                ["AndNot.UInt16"] = AndNotUInt16,
                ["AndNot.UInt32"] = AndNotUInt32,
                ["AndNot.UInt64"] = AndNotUInt64,
                ["Average.Byte"] = AverageByte,
                ["Average.UInt16"] = AverageUInt16,
                ["Blend.Int16.1"] = BlendInt161,
                ["Blend.Int16.2"] = BlendInt162,
                ["Blend.Int16.4"] = BlendInt164,
                ["Blend.Int16.85"] = BlendInt1685,
                ["Blend.UInt16.1"] = BlendUInt161,
                ["Blend.UInt16.2"] = BlendUInt162,
                ["Blend.UInt16.4"] = BlendUInt164,
                ["Blend.UInt16.85"] = BlendUInt1685,
                ["Blend.Int32.1"] = BlendInt321,
                ["Blend.Int32.2"] = BlendInt322,
                ["Blend.Int32.4"] = BlendInt324,
                ["Blend.Int32.85"] = BlendInt3285,
                ["Blend.UInt32.1"] = BlendUInt321,
                ["Blend.UInt32.2"] = BlendUInt322,
                ["Blend.UInt32.4"] = BlendUInt324,
                ["Blend.UInt32.85"] = BlendUInt3285,
                ["BlendVariable.Byte"] = BlendVariableByte,
                ["BlendVariable.SByte"] = BlendVariableSByte,
                ["BlendVariable.Int16"] = BlendVariableInt16,
                ["BlendVariable.UInt16"] = BlendVariableUInt16,
                ["BlendVariable.Int32"] = BlendVariableInt32,
                ["BlendVariable.UInt32"] = BlendVariableUInt32,
                ["BlendVariable.Int64"] = BlendVariableInt64,
                ["BlendVariable.UInt64"] = BlendVariableUInt64,
                ["BroadcastScalarToVector128.Byte"] = BroadcastScalarToVector128Byte,
                ["BroadcastScalarToVector128.SByte"] = BroadcastScalarToVector128SByte,
                ["BroadcastScalarToVector128.Int16"] = BroadcastScalarToVector128Int16,
                ["BroadcastScalarToVector128.UInt16"] = BroadcastScalarToVector128UInt16,
                ["BroadcastScalarToVector128.Int32"] = BroadcastScalarToVector128Int32,
                ["BroadcastScalarToVector128.UInt32"] = BroadcastScalarToVector128UInt32,
                ["BroadcastScalarToVector128.Int64"] = BroadcastScalarToVector128Int64,
                ["BroadcastScalarToVector128.UInt64"] = BroadcastScalarToVector128UInt64,
                ["BroadcastScalarToVector128.Single"] = BroadcastScalarToVector128Single,
                ["BroadcastScalarToVector128.Double"] = BroadcastScalarToVector128Double,
                ["BroadcastScalarToVector256.Byte"] = BroadcastScalarToVector256Byte,
                ["BroadcastScalarToVector256.SByte"] = BroadcastScalarToVector256SByte,
                ["BroadcastScalarToVector256.Int16"] = BroadcastScalarToVector256Int16,
                ["BroadcastScalarToVector256.UInt16"] = BroadcastScalarToVector256UInt16,
                ["BroadcastScalarToVector256.Int32"] = BroadcastScalarToVector256Int32,
                ["BroadcastScalarToVector256.UInt32"] = BroadcastScalarToVector256UInt32,
                ["BroadcastScalarToVector256.Int64"] = BroadcastScalarToVector256Int64,
                ["BroadcastScalarToVector256.UInt64"] = BroadcastScalarToVector256UInt64,
                ["BroadcastScalarToVector256.Single"] = BroadcastScalarToVector256Single,
                ["BroadcastScalarToVector256.Double"] = BroadcastScalarToVector256Double,
                ["CompareEqual.Byte"] = CompareEqualByte,
                ["CompareEqual.Int16"] = CompareEqualInt16,
                ["CompareEqual.Int32"] = CompareEqualInt32,
                ["CompareEqual.Int64"] = CompareEqualInt64,
                ["CompareEqual.SByte"] = CompareEqualSByte,
                ["CompareEqual.UInt16"] = CompareEqualUInt16,
                ["CompareEqual.UInt32"] = CompareEqualUInt32,
                ["CompareEqual.UInt64"] = CompareEqualUInt64,
                ["CompareGreaterThan.Int16"] = CompareGreaterThanInt16,
                ["CompareGreaterThan.Int32"] = CompareGreaterThanInt32,
                ["CompareGreaterThan.Int64"] = CompareGreaterThanInt64,
                ["CompareGreaterThan.SByte"] = CompareGreaterThanSByte,
                ["ConvertToInt32.Int32"] = ConvertToInt32Int32,
                ["ConvertToUInt32.UInt32"] = ConvertToUInt32UInt32,
                ["ExtractVector128.Byte.1"] = ExtractVector128Byte1,
                ["ExtractVector128.SByte.1"] = ExtractVector128SByte1,
                ["ExtractVector128.Int16.1"] = ExtractVector128Int161,
                ["ExtractVector128.UInt16.1"] = ExtractVector128UInt161,
                ["ExtractVector128.Int32.1"] = ExtractVector128Int321,
                ["ExtractVector128.UInt32.1"] = ExtractVector128UInt321,
                ["ExtractVector128.Int64.1"] = ExtractVector128Int641,
                ["ExtractVector128.UInt64.1"] = ExtractVector128UInt641,
                ["ExtractVector128.Byte.1.Store"] = ExtractVector128Byte1Store,
                ["ExtractVector128.SByte.1.Store"] = ExtractVector128SByte1Store,
                ["ExtractVector128.Int16.1.Store"] = ExtractVector128Int161Store,
                ["ExtractVector128.UInt16.1.Store"] = ExtractVector128UInt161Store,
                ["ExtractVector128.Int32.1.Store"] = ExtractVector128Int321Store,
                ["ExtractVector128.UInt32.1.Store"] = ExtractVector128UInt321Store,
                ["ExtractVector128.Int64.1.Store"] = ExtractVector128Int641Store,
                ["ExtractVector128.UInt64.1.Store"] = ExtractVector128UInt641Store,
                ["InsertVector128.Byte.1"] = InsertVector128Byte1,
                ["InsertVector128.SByte.1"] = InsertVector128SByte1,
                ["InsertVector128.Int16.1"] = InsertVector128Int161,
                ["InsertVector128.UInt16.1"] = InsertVector128UInt161,
                ["InsertVector128.Int32.1"] = InsertVector128Int321,
                ["InsertVector128.UInt32.1"] = InsertVector128UInt321,
                ["InsertVector128.Int64.1"] = InsertVector128Int641,
                ["InsertVector128.UInt64.1"] = InsertVector128UInt641,
                ["InsertVector128.Byte.1.Load"] = InsertVector128Byte1Load,
                ["InsertVector128.SByte.1.Load"] = InsertVector128SByte1Load,
                ["InsertVector128.Int16.1.Load"] = InsertVector128Int161Load,
                ["InsertVector128.UInt16.1.Load"] = InsertVector128UInt161Load,
                ["InsertVector128.Int32.1.Load"] = InsertVector128Int321Load,
                ["InsertVector128.UInt32.1.Load"] = InsertVector128UInt321Load,
                ["InsertVector128.Int64.1.Load"] = InsertVector128Int641Load,
                ["InsertVector128.UInt64.1.Load"] = InsertVector128UInt641Load,
                ["MaskLoad.Int32"] = MaskLoadInt32,
                ["MaskLoad.UInt32"] = MaskLoadUInt32,
                ["MaskLoad.Int64"] = MaskLoadInt64,
                ["MaskLoad.UInt64"] = MaskLoadUInt64,
                ["MaskStore.Int32"] = MaskStoreInt32,
                ["MaskStore.UInt32"] = MaskStoreUInt32,
                ["MaskStore.Int64"] = MaskStoreInt64,
                ["MaskStore.UInt64"] = MaskStoreUInt64,
                ["Max.Int16"] = MaxInt16,
                ["Max.Byte"] = MaxByte,
                ["Max.Int32"] = MaxInt32,
                ["Max.SByte"] = MaxSByte,
                ["Max.UInt16"] = MaxUInt16,
                ["Max.UInt32"] = MaxUInt32,
                ["Min.Int16"] = MinInt16,
                ["Min.Byte"] = MinByte,
                ["Min.Int32"] = MinInt32,
                ["Min.SByte"] = MinSByte,
                ["Min.UInt16"] = MinUInt16,
                ["Min.UInt32"] = MinUInt32,
                ["MultiplyAddAdjacent.Int16"] = MultiplyAddAdjacentInt16,
                ["MultiplyAddAdjacent.Int32"] = MultiplyAddAdjacentInt32,
                ["MultiplyHighRoundScale.Int16"] = MultiplyHighRoundScaleInt16,
                ["MultiplyHigh.Int16"] = MultiplyHighInt16,
                ["MultiplyHigh.UInt16"] = MultiplyHighUInt16,
                ["MultiplyLow.Int32"] = MultiplyLowInt32,
                ["MultiplyLow.Int16"] = MultiplyLowInt16,
                ["MultiplyLow.UInt32"] = MultiplyLowUInt32,
                ["MultiplyLow.UInt16"] = MultiplyLowUInt16,
                ["MultipleSumAbsoluteDifferences.UInt16.0"] = MultipleSumAbsoluteDifferencesUInt160,
                ["Or.Byte"] = OrByte,
                ["Or.Int16"] = OrInt16,
                ["Or.Int32"] = OrInt32,
                ["Or.Int64"] = OrInt64,
                ["Or.SByte"] = OrSByte,
                ["Or.UInt16"] = OrUInt16,
                ["Or.UInt32"] = OrUInt32,
                ["Or.UInt64"] = OrUInt64,
                ["PackUnsignedSaturate.UInt16"] = PackUnsignedSaturateUInt16,
                ["PackUnsignedSaturate.Byte"] = PackUnsignedSaturateByte,
                ["PackSignedSaturate.Int16"] = PackSignedSaturateInt16,
                ["PackSignedSaturate.SByte"] = PackSignedSaturateSByte,
                ["Permute2x128.Int32.2"] = Permute2x128Int322,
                ["Permute2x128.UInt32.2"] = Permute2x128UInt322,
                ["Permute2x128.Int64.2"] = Permute2x128Int642,
                ["Permute2x128.UInt64.2"] = Permute2x128UInt642,
                ["Permute4x64.Double.85"] = Permute4x64Double85,
                ["Permute4x64.Int64.85"] = Permute4x64Int6485,
                ["Permute4x64.UInt64.85"] = Permute4x64UInt6485,
                ["PermuteVar8x32.Int32"] = PermuteVar8x32Int32,
                ["PermuteVar8x32.UInt32"] = PermuteVar8x32UInt32,
                ["PermuteVar8x32.Single"] = PermuteVar8x32Single,
                ["ShiftLeftLogical.Int16.1"] = ShiftLeftLogicalInt161,
                ["ShiftLeftLogical.UInt16.1"] = ShiftLeftLogicalUInt161,
                ["ShiftLeftLogical.Int32.1"] = ShiftLeftLogicalInt321,
                ["ShiftLeftLogical.UInt32.1"] = ShiftLeftLogicalUInt321,
                ["ShiftLeftLogical.Int64.1"] = ShiftLeftLogicalInt641,
                ["ShiftLeftLogical.UInt64.1"] = ShiftLeftLogicalUInt641,
                ["ShiftLeftLogical.Int16.16"] = ShiftLeftLogicalInt1616,
                ["ShiftLeftLogical.UInt16.16"] = ShiftLeftLogicalUInt1616,
                ["ShiftLeftLogical.Int32.32"] = ShiftLeftLogicalInt3232,
                ["ShiftLeftLogical.UInt32.32"] = ShiftLeftLogicalUInt3232,
                ["ShiftLeftLogical.Int64.64"] = ShiftLeftLogicalInt6464,
                ["ShiftLeftLogical.UInt64.64"] = ShiftLeftLogicalUInt6464,
                ["ShiftLeftLogical128BitLane.SByte.1"] = ShiftLeftLogical128BitLaneSByte1,
                ["ShiftLeftLogical128BitLane.Byte.1"] = ShiftLeftLogical128BitLaneByte1,
                ["ShiftLeftLogical128BitLane.Int16.1"] = ShiftLeftLogical128BitLaneInt161,
                ["ShiftLeftLogical128BitLane.UInt16.1"] = ShiftLeftLogical128BitLaneUInt161,
                ["ShiftLeftLogical128BitLane.Int32.1"] = ShiftLeftLogical128BitLaneInt321,
                ["ShiftLeftLogical128BitLane.UInt32.1"] = ShiftLeftLogical128BitLaneUInt321,
                ["ShiftLeftLogical128BitLane.Int64.1"] = ShiftLeftLogical128BitLaneInt641,
                ["ShiftLeftLogical128BitLane.UInt64.1"] = ShiftLeftLogical128BitLaneUInt641,
                ["ShiftRightArithmetic.Int16.1"] = ShiftRightArithmeticInt161,
                ["ShiftRightArithmetic.Int32.1"] = ShiftRightArithmeticInt321,
                ["ShiftRightArithmetic.Int16.16"] = ShiftRightArithmeticInt1616,
                ["ShiftRightArithmetic.Int32.32"] = ShiftRightArithmeticInt3232,
                ["ShiftRightArithmeticVariable.Int32"] = ShiftRightArithmeticVariableInt32,
                ["ShiftRightLogical.Int16.1"] = ShiftRightLogicalInt161,
                ["ShiftRightLogical.UInt16.1"] = ShiftRightLogicalUInt161,
                ["ShiftRightLogical.Int32.1"] = ShiftRightLogicalInt321,
                ["ShiftRightLogical.UInt32.1"] = ShiftRightLogicalUInt321,
                ["ShiftRightLogical.Int64.1"] = ShiftRightLogicalInt641,
                ["ShiftRightLogical.UInt64.1"] = ShiftRightLogicalUInt641,
                ["ShiftRightLogical.Int16.16"] = ShiftRightLogicalInt1616,
                ["ShiftRightLogical.UInt16.16"] = ShiftRightLogicalUInt1616,
                ["ShiftRightLogical.Int32.32"] = ShiftRightLogicalInt3232,
                ["ShiftRightLogical.UInt32.32"] = ShiftRightLogicalUInt3232,
                ["ShiftRightLogical.Int64.64"] = ShiftRightLogicalInt6464,
                ["ShiftRightLogical.UInt64.64"] = ShiftRightLogicalUInt6464,
                ["ShiftRightLogical128BitLane.SByte.1"] = ShiftRightLogical128BitLaneSByte1,
                ["ShiftRightLogical128BitLane.Byte.1"] = ShiftRightLogical128BitLaneByte1,
                ["ShiftRightLogical128BitLane.Int16.1"] = ShiftRightLogical128BitLaneInt161,
                ["ShiftRightLogical128BitLane.UInt16.1"] = ShiftRightLogical128BitLaneUInt161,
                ["ShiftRightLogical128BitLane.Int32.1"] = ShiftRightLogical128BitLaneInt321,
                ["ShiftRightLogical128BitLane.UInt32.1"] = ShiftRightLogical128BitLaneUInt321,
                ["ShiftRightLogical128BitLane.Int64.1"] = ShiftRightLogical128BitLaneInt641,
                ["ShiftRightLogical128BitLane.UInt64.1"] = ShiftRightLogical128BitLaneUInt641,
                ["Sign.SByte"] = SignSByte,
                ["Sign.Int16"] = SignInt16,
                ["Sign.Int32"] = SignInt32,
                ["Shuffle.Byte"] = ShuffleByte,
                ["Shuffle.SByte"] = ShuffleSByte,
                ["Shuffle.Int32.1"] = ShuffleInt321,
                ["Shuffle.UInt32.1"] = ShuffleUInt321,
                ["ShuffleHigh.Int16.228"] = ShuffleHighInt16228,
                ["ShuffleHigh.UInt16.228"] = ShuffleHighUInt16228,
                ["ShuffleLow.Int16.228"] = ShuffleLowInt16228,
                ["ShuffleLow.UInt16.228"] = ShuffleLowUInt16228,
                ["SumAbsoluteDifferences.UInt16"] = SumAbsoluteDifferencesUInt16,
                ["Subtract.Byte"] = SubtractByte,
                ["Subtract.Int16"] = SubtractInt16,
                ["Subtract.Int32"] = SubtractInt32,
                ["Subtract.Int64"] = SubtractInt64,
                ["Subtract.SByte"] = SubtractSByte,
                ["Subtract.UInt16"] = SubtractUInt16,
                ["Subtract.UInt32"] = SubtractUInt32,
                ["Subtract.UInt64"] = SubtractUInt64,
                ["Xor.Byte"] = XorByte,
                ["Xor.Int16"] = XorInt16,
                ["Xor.Int32"] = XorInt32,
                ["Xor.Int64"] = XorInt64,
                ["Xor.SByte"] = XorSByte,
                ["Xor.UInt16"] = XorUInt16,
                ["Xor.UInt32"] = XorUInt32,
                ["Xor.UInt64"] = XorUInt64,
            };
        }
    }
}
