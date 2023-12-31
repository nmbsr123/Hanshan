// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestRefBean : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestRefBean GetRootAsTestRefBean(ByteBuffer _bb) { return GetRootAsTestRefBean(_bb, new TestRefBean()); }
  public static TestRefBean GetRootAsTestRefBean(ByteBuffer _bb, TestRefBean obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestRefBean __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Arr(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ArrLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetArrBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetArrBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetArrArray() { return __p.__vector_as_array<int>(6); }

  public static Offset<cfg.TestRefBean> CreateTestRefBean(FlatBufferBuilder builder,
      int x = 0,
      VectorOffset arrOffset = default(VectorOffset)) {
    builder.StartTable(2);
    TestRefBean.AddArr(builder, arrOffset);
    TestRefBean.AddX(builder, x);
    return TestRefBean.EndTestRefBean(builder);
  }

  public static void StartTestRefBean(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddX(FlatBufferBuilder builder, int x) { builder.AddInt(0, x, 0); }
  public static void AddArr(FlatBufferBuilder builder, VectorOffset arrOffset) { builder.AddOffset(1, arrOffset.Value, 0); }
  public static VectorOffset CreateArrVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateArrVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateArrVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateArrVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartArrVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.TestRefBean> EndTestRefBean(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 6);  // arr
    return new Offset<cfg.TestRefBean>(o);
  }
}


static public class TestRefBeanVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*int*/, 4, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*Arr*/, 4 /*int*/, true)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
