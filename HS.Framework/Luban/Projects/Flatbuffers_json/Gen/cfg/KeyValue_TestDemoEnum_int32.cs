// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct KeyValue_TestDemoEnum_int32 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static KeyValue_TestDemoEnum_int32 GetRootAsKeyValue_TestDemoEnum_int32(ByteBuffer _bb) { return GetRootAsKeyValue_TestDemoEnum_int32(_bb, new KeyValue_TestDemoEnum_int32()); }
  public static KeyValue_TestDemoEnum_int32 GetRootAsKeyValue_TestDemoEnum_int32(ByteBuffer _bb, KeyValue_TestDemoEnum_int32 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KeyValue_TestDemoEnum_int32 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public cfg.TestDemoEnum Key { get { int o = __p.__offset(4); return o != 0 ? (cfg.TestDemoEnum)__p.bb.GetInt(o + __p.bb_pos) : cfg.TestDemoEnum.TestDemoEnum_NONE; } }
  public int Value { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<cfg.KeyValue_TestDemoEnum_int32> CreateKeyValue_TestDemoEnum_int32(FlatBufferBuilder builder,
      cfg.TestDemoEnum key = cfg.TestDemoEnum.TestDemoEnum_NONE,
      int value = 0) {
    builder.StartTable(2);
    KeyValue_TestDemoEnum_int32.AddValue(builder, value);
    KeyValue_TestDemoEnum_int32.AddKey(builder, key);
    return KeyValue_TestDemoEnum_int32.EndKeyValue_TestDemoEnum_int32(builder);
  }

  public static void StartKeyValue_TestDemoEnum_int32(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddKey(FlatBufferBuilder builder, cfg.TestDemoEnum key) { builder.AddInt(0, (int)key, 0); }
  public static void AddValue(FlatBufferBuilder builder, int value) { builder.AddInt(1, value, 0); }
  public static Offset<cfg.KeyValue_TestDemoEnum_int32> EndKeyValue_TestDemoEnum_int32(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.KeyValue_TestDemoEnum_int32>(o);
  }
}


static public class KeyValue_TestDemoEnum_int32Verify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Key*/, 4 /*cfg.TestDemoEnum*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Value*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
