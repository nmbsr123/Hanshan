// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestTestRef : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestTestRef GetRootAsTestTestRef(ByteBuffer _bb) { return GetRootAsTestTestRef(_bb, new TestTestRef()); }
  public static TestTestRef GetRootAsTestTestRef(ByteBuffer _bb, TestTestRef obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestTestRef __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X1 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X12 { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X2 { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X3 { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X4 { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int A1(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int A1Length { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetA1Bytes() { return __p.__vector_as_span<int>(16, 4); }
#else
  public ArraySegment<byte>? GetA1Bytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public int[] GetA1Array() { return __p.__vector_as_array<int>(16); }
  public int A2(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int A2Length { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetA2Bytes() { return __p.__vector_as_span<int>(18, 4); }
#else
  public ArraySegment<byte>? GetA2Bytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public int[] GetA2Array() { return __p.__vector_as_array<int>(18); }
  public int B1(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int B1Length { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetB1Bytes() { return __p.__vector_as_span<int>(20, 4); }
#else
  public ArraySegment<byte>? GetB1Bytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public int[] GetB1Array() { return __p.__vector_as_array<int>(20); }
  public int B2(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int B2Length { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetB2Bytes() { return __p.__vector_as_span<int>(22, 4); }
#else
  public ArraySegment<byte>? GetB2Bytes() { return __p.__vector_as_arraysegment(22); }
#endif
  public int[] GetB2Array() { return __p.__vector_as_array<int>(22); }
  public int C1(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int C1Length { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetC1Bytes() { return __p.__vector_as_span<int>(24, 4); }
#else
  public ArraySegment<byte>? GetC1Bytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public int[] GetC1Array() { return __p.__vector_as_array<int>(24); }
  public int C2(int j) { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int C2Length { get { int o = __p.__offset(26); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetC2Bytes() { return __p.__vector_as_span<int>(26, 4); }
#else
  public ArraySegment<byte>? GetC2Bytes() { return __p.__vector_as_arraysegment(26); }
#endif
  public int[] GetC2Array() { return __p.__vector_as_array<int>(26); }
  public cfg.KeyValue_int32_int32? D1(int j) { int o = __p.__offset(28); return o != 0 ? (cfg.KeyValue_int32_int32?)(new cfg.KeyValue_int32_int32()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int D1Length { get { int o = __p.__offset(28); return o != 0 ? __p.__vector_len(o) : 0; } }
  public cfg.KeyValue_int32_int32? D2(int j) { int o = __p.__offset(30); return o != 0 ? (cfg.KeyValue_int32_int32?)(new cfg.KeyValue_int32_int32()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int D2Length { get { int o = __p.__offset(30); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int E1 { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long E2 { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string E3 { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetE3Bytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetE3Bytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetE3Array() { return __p.__vector_as_array<byte>(36); }
  public int F1 { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long F2 { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string F3 { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetF3Bytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetF3Bytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetF3Array() { return __p.__vector_as_array<byte>(42); }
  public cfg.TestRefDynamicBase S1Type { get { int o = __p.__offset(44); return o != 0 ? (cfg.TestRefDynamicBase)__p.bb.Get(o + __p.bb_pos) : cfg.TestRefDynamicBase.NONE; } }
  public TTable? S1<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(46); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public cfg.TestRefBean S1AsTestRefBean() { return S1<cfg.TestRefBean>().Value; }

  public static Offset<cfg.TestTestRef> CreateTestTestRef(FlatBufferBuilder builder,
      int id = 0,
      int x1 = 0,
      int x1_2 = 0,
      int x2 = 0,
      int x3 = 0,
      int x4 = 0,
      VectorOffset a1Offset = default(VectorOffset),
      VectorOffset a2Offset = default(VectorOffset),
      VectorOffset b1Offset = default(VectorOffset),
      VectorOffset b2Offset = default(VectorOffset),
      VectorOffset c1Offset = default(VectorOffset),
      VectorOffset c2Offset = default(VectorOffset),
      VectorOffset d1Offset = default(VectorOffset),
      VectorOffset d2Offset = default(VectorOffset),
      int e1 = 0,
      long e2 = 0,
      StringOffset e3Offset = default(StringOffset),
      int f1 = 0,
      long f2 = 0,
      StringOffset f3Offset = default(StringOffset),
      cfg.TestRefDynamicBase s1_type = cfg.TestRefDynamicBase.NONE,
      int s1Offset = 0) {
    builder.StartTable(22);
    TestTestRef.AddF2(builder, f2);
    TestTestRef.AddE2(builder, e2);
    TestTestRef.AddS1(builder, s1Offset);
    TestTestRef.AddF3(builder, f3Offset);
    TestTestRef.AddF1(builder, f1);
    TestTestRef.AddE3(builder, e3Offset);
    TestTestRef.AddE1(builder, e1);
    TestTestRef.AddD2(builder, d2Offset);
    TestTestRef.AddD1(builder, d1Offset);
    TestTestRef.AddC2(builder, c2Offset);
    TestTestRef.AddC1(builder, c1Offset);
    TestTestRef.AddB2(builder, b2Offset);
    TestTestRef.AddB1(builder, b1Offset);
    TestTestRef.AddA2(builder, a2Offset);
    TestTestRef.AddA1(builder, a1Offset);
    TestTestRef.AddX4(builder, x4);
    TestTestRef.AddX3(builder, x3);
    TestTestRef.AddX2(builder, x2);
    TestTestRef.AddX12(builder, x1_2);
    TestTestRef.AddX1(builder, x1);
    TestTestRef.AddId(builder, id);
    TestTestRef.AddS1Type(builder, s1_type);
    return TestTestRef.EndTestTestRef(builder);
  }

  public static void StartTestTestRef(FlatBufferBuilder builder) { builder.StartTable(22); }
  public static void AddId(FlatBufferBuilder builder, int id) { builder.AddInt(0, id, 0); }
  public static void AddX1(FlatBufferBuilder builder, int x1) { builder.AddInt(1, x1, 0); }
  public static void AddX12(FlatBufferBuilder builder, int x12) { builder.AddInt(2, x12, 0); }
  public static void AddX2(FlatBufferBuilder builder, int x2) { builder.AddInt(3, x2, 0); }
  public static void AddX3(FlatBufferBuilder builder, int x3) { builder.AddInt(4, x3, 0); }
  public static void AddX4(FlatBufferBuilder builder, int x4) { builder.AddInt(5, x4, 0); }
  public static void AddA1(FlatBufferBuilder builder, VectorOffset a1Offset) { builder.AddOffset(6, a1Offset.Value, 0); }
  public static VectorOffset CreateA1Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateA1VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateA1VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateA1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartA1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddA2(FlatBufferBuilder builder, VectorOffset a2Offset) { builder.AddOffset(7, a2Offset.Value, 0); }
  public static VectorOffset CreateA2Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateA2VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateA2VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateA2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartA2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddB1(FlatBufferBuilder builder, VectorOffset b1Offset) { builder.AddOffset(8, b1Offset.Value, 0); }
  public static VectorOffset CreateB1Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateB1VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateB1VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateB1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartB1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddB2(FlatBufferBuilder builder, VectorOffset b2Offset) { builder.AddOffset(9, b2Offset.Value, 0); }
  public static VectorOffset CreateB2Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateB2VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateB2VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateB2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartB2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddC1(FlatBufferBuilder builder, VectorOffset c1Offset) { builder.AddOffset(10, c1Offset.Value, 0); }
  public static VectorOffset CreateC1Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateC1VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateC1VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateC1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartC1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddC2(FlatBufferBuilder builder, VectorOffset c2Offset) { builder.AddOffset(11, c2Offset.Value, 0); }
  public static VectorOffset CreateC2Vector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateC2VectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateC2VectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateC2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartC2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddD1(FlatBufferBuilder builder, VectorOffset d1Offset) { builder.AddOffset(12, d1Offset.Value, 0); }
  public static VectorOffset CreateD1Vector(FlatBufferBuilder builder, Offset<cfg.KeyValue_int32_int32>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateD1VectorBlock(FlatBufferBuilder builder, Offset<cfg.KeyValue_int32_int32>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateD1VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<cfg.KeyValue_int32_int32>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateD1VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<cfg.KeyValue_int32_int32>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartD1Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddD2(FlatBufferBuilder builder, VectorOffset d2Offset) { builder.AddOffset(13, d2Offset.Value, 0); }
  public static VectorOffset CreateD2Vector(FlatBufferBuilder builder, Offset<cfg.KeyValue_int32_int32>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateD2VectorBlock(FlatBufferBuilder builder, Offset<cfg.KeyValue_int32_int32>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateD2VectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<cfg.KeyValue_int32_int32>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateD2VectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<cfg.KeyValue_int32_int32>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartD2Vector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddE1(FlatBufferBuilder builder, int e1) { builder.AddInt(14, e1, 0); }
  public static void AddE2(FlatBufferBuilder builder, long e2) { builder.AddLong(15, e2, 0); }
  public static void AddE3(FlatBufferBuilder builder, StringOffset e3Offset) { builder.AddOffset(16, e3Offset.Value, 0); }
  public static void AddF1(FlatBufferBuilder builder, int f1) { builder.AddInt(17, f1, 0); }
  public static void AddF2(FlatBufferBuilder builder, long f2) { builder.AddLong(18, f2, 0); }
  public static void AddF3(FlatBufferBuilder builder, StringOffset f3Offset) { builder.AddOffset(19, f3Offset.Value, 0); }
  public static void AddS1Type(FlatBufferBuilder builder, cfg.TestRefDynamicBase s1Type) { builder.AddByte(20, (byte)s1Type, 0); }
  public static void AddS1(FlatBufferBuilder builder, int s1Offset) { builder.AddOffset(21, s1Offset, 0); }
  public static Offset<cfg.TestTestRef> EndTestTestRef(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 16);  // a1
    builder.Required(o, 18);  // a2
    builder.Required(o, 20);  // b1
    builder.Required(o, 22);  // b2
    builder.Required(o, 24);  // c1
    builder.Required(o, 26);  // c2
    builder.Required(o, 28);  // d1
    builder.Required(o, 30);  // d2
    builder.Required(o, 46);  // s1
    return new Offset<cfg.TestTestRef>(o);
  }
}


static public class TestTestRefVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*X1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*X12*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*X2*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*X3*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*X4*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 16 /*A1*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 18 /*A2*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 20 /*B1*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 22 /*B2*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 24 /*C1*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfData(tablePos, 26 /*C2*/, 4 /*int*/, true)
      && verifier.VerifyVectorOfTables(tablePos, 28 /*D1*/, cfg.KeyValue_int32_int32Verify.Verify, true)
      && verifier.VerifyVectorOfTables(tablePos, 30 /*D2*/, cfg.KeyValue_int32_int32Verify.Verify, true)
      && verifier.VerifyField(tablePos, 32 /*E1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 34 /*E2*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 36 /*E3*/, false)
      && verifier.VerifyField(tablePos, 38 /*F1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 40 /*F2*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 42 /*F3*/, false)
      && verifier.VerifyField(tablePos, 44 /*S1Type*/, 1 /*cfg.TestRefDynamicBase*/, 1, false)
      && verifier.VerifyUnion(tablePos, 44, 46 /*S1*/, cfg.TestRefDynamicBaseVerify.Verify, true)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
