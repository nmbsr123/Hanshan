// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestDemoType2 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestDemoType2 GetRootAsTestDemoType2(ByteBuffer _bb) { return GetRootAsTestDemoType2(_bb, new TestDemoType2()); }
  public static TestDemoType2 GetRootAsTestDemoType2(ByteBuffer _bb, TestDemoType2 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestDemoType2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X4 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool X1 { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public byte X2 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public short X3 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public long X5 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public float X6 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public double X7 { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetDouble(o + __p.bb_pos) : (double)0.0; } }
  public short X80 { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public int X8 { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long X9 { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string X10 { get { int o = __p.__offset(24); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetX10Bytes() { return __p.__vector_as_span<byte>(24, 1); }
#else
  public ArraySegment<byte>? GetX10Bytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public byte[] GetX10Array() { return __p.__vector_as_array<byte>(24); }
  public cfg.TestDemoType1? X12 { get { int o = __p.__offset(26); return o != 0 ? (cfg.TestDemoType1?)(new cfg.TestDemoType1()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public cfg.TestDemoEnum X13 { get { int o = __p.__offset(28); return o != 0 ? (cfg.TestDemoEnum)__p.bb.GetInt(o + __p.bb_pos) : cfg.TestDemoEnum.TestDemoEnum_NONE; } }
  public cfg.TestDemoDynamic X14Type { get { int o = __p.__offset(30); return o != 0 ? (cfg.TestDemoDynamic)__p.bb.Get(o + __p.bb_pos) : cfg.TestDemoDynamic.NONE; } }
  public TTable? X14<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(32); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public cfg.TestDemoD2 X14AsTestDemoD2() { return X14<cfg.TestDemoD2>().Value; }
  public cfg.TestDemoE1 X14AsTestDemoE1() { return X14<cfg.TestDemoE1>().Value; }
  public cfg.TestLoginRoleInfo X14AsTestLoginRoleInfo() { return X14<cfg.TestLoginRoleInfo>().Value; }
  public cfg.TestDemoD5 X14AsTestDemoD5() { return X14<cfg.TestDemoD5>().Value; }
  public string S1 { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetS1Bytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetS1Bytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetS1Array() { return __p.__vector_as_array<byte>(34); }
  public long T1 { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int K1(int j) { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int K1Length { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetK1Bytes() { return __p.__vector_as_span<int>(38, 4); }
#else
  public ArraySegment<byte>? GetK1Bytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public int[] GetK1Array() { return __p.__vector_as_array<int>(38); }
  public int K2(int j) { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int K2Length { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetK2Bytes() { return __p.__vector_as_span<int>(40, 4); }
#else
  public ArraySegment<byte>? GetK2Bytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public int[] GetK2Array() { return __p.__vector_as_array<int>(40); }
  public int K5(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int K5Length { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetK5Bytes() { return __p.__vector_as_span<int>(42, 4); }
#else
  public ArraySegment<byte>? GetK5Bytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public int[] GetK5Array() { return __p.__vector_as_array<int>(42); }
  public cfg.KeyValue_int32_int32? K8(int j) { int o = __p.__offset(44); return o != 0 ? (cfg.KeyValue_int32_int32?)(new cfg.KeyValue_int32_int32()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int K8Length { get { int o = __p.__offset(44); return o != 0 ? __p.__vector_len(o) : 0; } }
  public cfg.TestDemoE2? K9(int j) { int o = __p.__offset(46); return o != 0 ? (cfg.TestDemoE2?)(new cfg.TestDemoE2()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int K9Length { get { int o = __p.__offset(46); return o != 0 ? __p.__vector_len(o) : 0; } }
  public cfg.TestDemoDynamic K15Type(int j) { int o = __p.__offset(48); return o != 0 ? (cfg.TestDemoDynamic)__p.bb.Get(__p.__vector(o) + j * 1) : (cfg.TestDemoDynamic)0; }
  public int K15TypeLength { get { int o = __p.__offset(48); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<cfg.TestDemoDynamic> GetK15TypeBytes() { return __p.__vector_as_span<cfg.TestDemoDynamic>(48, 1); }
#else
  public ArraySegment<byte>? GetK15TypeBytes() { return __p.__vector_as_arraysegment(48); }
#endif
  public cfg.TestDemoDynamic[] GetK15TypeArray() { int o = __p.__offset(48); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); cfg.TestDemoDynamic[] a = new cfg.TestDemoDynamic[l]; for (int i = 0; i < l; i++) { a[i] = (cfg.TestDemoDynamic)__p.bb.Get(p + i * 1); } return a; }
  public TTable? K15<TTable>(int j) where TTable : struct, IFlatbufferObject { int o = __p.__offset(50); return o != 0 ? (TTable?)__p.__union<TTable>(__p.__vector(o) + j * 4) : null; }
  public int K15Length { get { int o = __p.__offset(50); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<cfg.TestDemoType2> CreateTestDemoType2(FlatBufferBuilder builder,
      int x4 = 0,
      bool x1 = false,
      byte x2 = 0,
      short x3 = 0,
      long x5 = 0,
      float x6 = 0.0f,
      double x7 = 0.0,
      short x8_0 = 0,
      int x8 = 0,
      long x9 = 0,
      StringOffset x10Offset = default(StringOffset),
      Offset<cfg.TestDemoType1> x12Offset = default(Offset<cfg.TestDemoType1>),
      cfg.TestDemoEnum x13 = cfg.TestDemoEnum.TestDemoEnum_NONE,
      cfg.TestDemoDynamic x14_type = cfg.TestDemoDynamic.NONE,
      int x14Offset = 0,
      StringOffset s1Offset = default(StringOffset),
      long t1 = 0,
      VectorOffset k1Offset = default(VectorOffset),
      VectorOffset k2Offset = default(VectorOffset),
      VectorOffset k5Offset = default(VectorOffset),
      VectorOffset k8Offset = default(VectorOffset),
      VectorOffset k9Offset = default(VectorOffset),
      VectorOffset k15_typeOffset = default(VectorOffset),
      VectorOffset k15Offset = default(VectorOffset)) {
    builder.StartTable(24);
    TestDemoType2.AddT1(builder, t1);
    TestDemoType2.AddX9(builder, x9);
    TestDemoType2.AddX7(builder, x7);
    TestDemoType2.AddX5(builder, x5);
    TestDemoType2.AddK15(builder, k15Offset);
    TestDemoType2.AddK15Type(builder, k15_typeOffset);
    TestDemoType2.AddK9(builder, k9Offset);
    TestDemoType2.AddK8(builder, k8Offset);
    TestDemoType2.AddK5(builder, k5Offset);
    TestDemoType2.AddK2(builder, k2Offset);
    TestDemoType2.AddK1(builder, k1Offset);
    TestDemoType2.AddS1(builder, s1Offset);
    TestDemoType2.AddX14(builder, x14Offset);
    TestDemoType2.AddX13(builder, x13);
    TestDemoType2.AddX12(builder, x12Offset);
    TestDemoType2.AddX10(builder, x10Offset);
    TestDemoType2.AddX8(builder, x8);
    TestDemoType2.AddX6(builder, x6);
    TestDemoType2.AddX4(builder, x4);
    TestDemoType2.AddX80(builder, x8_0);
    TestDemoType2.AddX3(builder, x3);
    TestDemoType2.AddX14Type(builder, x14_type);
    TestDemoType2.AddX2(builder, x2);
    TestDemoType2.AddX1(builder, x1);
    return TestDemoType2.EndTestDemoType2(builder);
  }

  public static void StartTestDemoType2(FlatBufferBuilder builder) { builder.StartTable(24); }
  public static void AddX4(FlatBufferBuilder builder, int x4) { builder.AddInt(0, x4, 0); }
  public static void AddX1(FlatBufferBuilder builder, bool x1) { builder.AddBool(1, x1, false); }
  public static void AddX2(FlatBufferBuilder builder, byte x2) { builder.AddByte(2, x2, 0); }
  public static void AddX3(FlatBufferBuilder builder, short x3) { builder.AddShort(3, x3, 0); }
  public static void AddX5(FlatBufferBuilder builder, long x5) { builder.AddLong(4, x5, 0); }
  public static void AddX6(FlatBufferBuilder builder, float x6) { builder.AddFloat(5, x6, 0.0f); }
  public static void AddX7(FlatBufferBuilder builder, double x7) { builder.AddDouble(6, x7, 0.0); }
  public static void AddX80(FlatBufferBuilder builder, short x80) { builder.AddShort(7, x80, 0); }
  public static void AddX8(FlatBufferBuilder builder, int x8) { builder.AddInt(8, x8, 0); }
  public static void AddX9(FlatBufferBuilder builder, long x9) { builder.AddLong(9, x9, 0); }
  public static void AddX10(FlatBufferBuilder builder, StringOffset x10Offset) { builder.AddOffset(10, x10Offset.Value, 0); }
  public static void AddX12(FlatBufferBuilder builder, Offset<cfg.TestDemoType1> x12Offset) { builder.AddOffset(11, x12Offset.Value, 0); }
  public static void AddX13(FlatBufferBuilder builder, cfg.TestDemoEnum x13) { builder.AddInt(12, (int)x13, 0); }
  public static void AddX14Type(FlatBufferBuilder builder, cfg.TestDemoDynamic x14Type) { builder.AddByte(13, (byte)x14Type, 0); }
  public static void AddX14(FlatBufferBuilder builder, int x14Offset) { builder.AddOffset(14, x14Offset, 0); }
  public static void AddS1(FlatBufferBuilder builder, StringOffset s1Offset) { builder.AddOffset(15, s1Offset.Value, 0); }
  public static void AddT1(FlatBufferBuilder builder, long t1) { builder.AddLong(16, t1, 0); }
  public static void AddK1(FlatBufferBuilder builder, VectorOffset k1Offset) { builder.AddOffset(17, k1Offset.Value, 0); }
  public static VectorOffset CreateK1Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateK1VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK1VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddK2(FlatBufferBuilder builder, VectorOffset k2Offset) { builder.AddOffset(18, k2Offset.Value, 0); }
  public static VectorOffset CreateK2Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateK2VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK2VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddK5(FlatBufferBuilder builder, VectorOffset k5Offset) { builder.AddOffset(19, k5Offset.Value, 0); }
  public static VectorOffset CreateK5Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateK5VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK5VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK5VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK5Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddK8(FlatBufferBuilder builder, VectorOffset k8Offset) { builder.AddOffset(20, k8Offset.Value, 0); }
  public static VectorOffset CreateK8Vector(FlatBufferBuilder builder, Offset<cfg.KeyValue_int32_int32>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateK8VectorBlock(FlatBufferBuilder builder, Offset<cfg.KeyValue_int32_int32>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK8VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<cfg.KeyValue_int32_int32>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK8VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<cfg.KeyValue_int32_int32>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK8Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddK9(FlatBufferBuilder builder, VectorOffset k9Offset) { builder.AddOffset(21, k9Offset.Value, 0); }
  public static VectorOffset CreateK9Vector(FlatBufferBuilder builder, Offset<cfg.TestDemoE2>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateK9VectorBlock(FlatBufferBuilder builder, Offset<cfg.TestDemoE2>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK9VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<cfg.TestDemoE2>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK9VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<cfg.TestDemoE2>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK9Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddK15Type(FlatBufferBuilder builder, VectorOffset k15TypeOffset) { builder.AddOffset(22, k15TypeOffset.Value, 0); }
  public static VectorOffset CreateK15TypeVector(FlatBufferBuilder builder, cfg.TestDemoDynamic[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte((byte)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateK15TypeVectorBlock(FlatBufferBuilder builder, cfg.TestDemoDynamic[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK15TypeVectorBlock(FlatBufferBuilder builder, ArraySegment<cfg.TestDemoDynamic> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK15TypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<cfg.TestDemoDynamic>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK15TypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddK15(FlatBufferBuilder builder, VectorOffset k15Offset) { builder.AddOffset(23, k15Offset.Value, 0); }
  public static VectorOffset CreateK15Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateK15VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK15VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateK15VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartK15Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.TestDemoType2> EndTestDemoType2(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 26);  // x12
    builder.Required(o, 32);  // x14
    builder.Required(o, 38);  // k1
    builder.Required(o, 40);  // k2
    builder.Required(o, 42);  // k5
    builder.Required(o, 44);  // k8
    builder.Required(o, 46);  // k9
    builder.Required(o, 48);  // k15_type
    builder.Required(o, 50);  // k15
    return new Offset<cfg.TestDemoType2>(o);
  }
}


static public class TestDemoType2Verify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X4*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*X1*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*X2*/, 1 /*byte*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*X3*/, 2 /*short*/, 2, false)
      && verifier.VerifyField(tablePos, 12 /*X5*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*X6*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*X7*/, 8 /*double*/, 8, false)
      && verifier.VerifyField(tablePos, 18 /*X80*/, 2 /*short*/, 2, false)
      && verifier.VerifyField(tablePos, 20 /*X8*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*X9*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 24 /*X10*/, false)
      && verifier.VerifyTable(tablePos, 26 /*X12*/, cfg.TestDemoType1Verify.Verify, true)
      && verifier.VerifyField(tablePos, 28 /*X13*/, 4 /*cfg.TestDemoEnum*/, 4, false)
      && verifier.VerifyField(tablePos, 30 /*X14Type*/, 1 /*cfg.TestDemoDynamic*/, 1, false)
      && verifier.VerifyUnion(tablePos, 30, 32 /*X14*/, cfg.TestDemoDynamicVerify.Verify, true)
      && verifier.VerifyString(tablePos, 34 /*S1*/, false)
      && verifier.VerifyField(tablePos, 36 /*T1*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 38 /*K1*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 40 /*K2*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 42 /*K5*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfTables(tablePos, 44 /*K8*/, cfg.KeyValue_int32_int32Verify.Verify, true)
      && verifier.VerifyVectorOfTables(tablePos, 46 /*K9*/, cfg.TestDemoE2Verify.Verify, true)
      && verifier.VerifyVectorOfData(tablePos, 48 /*K15Type*/, 1 /*cfg.TestDemoDynamic*/, true)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
