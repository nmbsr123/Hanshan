// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestDateTimeRange : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestDateTimeRange GetRootAsTestDateTimeRange(ByteBuffer _bb) { return GetRootAsTestDateTimeRange(_bb, new TestDateTimeRange()); }
  public static TestDateTimeRange GetRootAsTestDateTimeRange(ByteBuffer _bb, TestDateTimeRange obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestDateTimeRange __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StartTime { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EndTime { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<cfg.TestDateTimeRange> CreateTestDateTimeRange(FlatBufferBuilder builder,
      long start_time = 0,
      long end_time = 0) {
    builder.StartTable(2);
    TestDateTimeRange.AddEndTime(builder, end_time);
    TestDateTimeRange.AddStartTime(builder, start_time);
    return TestDateTimeRange.EndTestDateTimeRange(builder);
  }

  public static void StartTestDateTimeRange(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddStartTime(FlatBufferBuilder builder, long startTime) { builder.AddLong(0, startTime, 0); }
  public static void AddEndTime(FlatBufferBuilder builder, long endTime) { builder.AddLong(1, endTime, 0); }
  public static Offset<cfg.TestDateTimeRange> EndTestDateTimeRange(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestDateTimeRange>(o);
  }
}


static public class TestDateTimeRangeVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StartTime*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EndTime*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
