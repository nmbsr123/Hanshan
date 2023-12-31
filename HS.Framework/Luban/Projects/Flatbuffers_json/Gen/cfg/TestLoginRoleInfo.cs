// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TestLoginRoleInfo : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static TestLoginRoleInfo GetRootAsTestLoginRoleInfo(ByteBuffer _bb) { return GetRootAsTestLoginRoleInfo(_bb, new TestLoginRoleInfo()); }
  public static TestLoginRoleInfo GetRootAsTestLoginRoleInfo(ByteBuffer _bb, TestLoginRoleInfo obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TestLoginRoleInfo __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int X1 { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int X3 { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long RoleId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<cfg.TestLoginRoleInfo> CreateTestLoginRoleInfo(FlatBufferBuilder builder,
      int x1 = 0,
      int x3 = 0,
      long role_id = 0) {
    builder.StartTable(3);
    TestLoginRoleInfo.AddRoleId(builder, role_id);
    TestLoginRoleInfo.AddX3(builder, x3);
    TestLoginRoleInfo.AddX1(builder, x1);
    return TestLoginRoleInfo.EndTestLoginRoleInfo(builder);
  }

  public static void StartTestLoginRoleInfo(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddX1(FlatBufferBuilder builder, int x1) { builder.AddInt(0, x1, 0); }
  public static void AddX3(FlatBufferBuilder builder, int x3) { builder.AddInt(1, x3, 0); }
  public static void AddRoleId(FlatBufferBuilder builder, long roleId) { builder.AddLong(2, roleId, 0); }
  public static Offset<cfg.TestLoginRoleInfo> EndTestLoginRoleInfo(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.TestLoginRoleInfo>(o);
  }
}


static public class TestLoginRoleInfoVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X1*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*X3*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RoleId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
