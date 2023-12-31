// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestTbDefineFromExcel2 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestTbDefineFromExcel2 GetRootAsTestTbDefineFromExcel2(ByteBuffer _bb) { return GetRootAsTestTbDefineFromExcel2(_bb, new TestTbDefineFromExcel2()); }
  public static TestTbDefineFromExcel2 GetRootAsTestTbDefineFromExcel2(ByteBuffer _bb, TestTbDefineFromExcel2 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool VerifyTestTbDefineFromExcel2(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("", false, TestTbDefineFromExcel2Verify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestTbDefineFromExcel2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.DefineFromExcel2? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (cfg.DefineFromExcel2?)(new cfg.DefineFromExcel2()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<cfg.TestTbDefineFromExcel2> CreateTestTbDefineFromExcel2(FlatBufferBuilder builder,
      VectorOffset data_listOffset = default(VectorOffset)) {
    builder.StartTable(1);
    TestTbDefineFromExcel2.AddDataList(builder, data_listOffset);
    return TestTbDefineFromExcel2.EndTestTbDefineFromExcel2(builder);
  }

  public static void StartTestTbDefineFromExcel2(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<cfg.DefineFromExcel2>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<cfg.DefineFromExcel2>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<cfg.DefineFromExcel2>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<cfg.DefineFromExcel2>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<cfg.TestTbDefineFromExcel2> EndTestTbDefineFromExcel2(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 4);  // data_list
    return new Offset<cfg.TestTbDefineFromExcel2>(o);
  }
  public static void FinishTestTbDefineFromExcel2Buffer(FlatBufferBuilder builder, Offset<cfg.TestTbDefineFromExcel2> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedTestTbDefineFromExcel2Buffer(FlatBufferBuilder builder, Offset<cfg.TestTbDefineFromExcel2> offset) { builder.FinishSizePrefixed(offset.Value); }
}


static public class TestTbDefineFromExcel2Verify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, cfg.DefineFromExcel2Verify.Verify, true)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
