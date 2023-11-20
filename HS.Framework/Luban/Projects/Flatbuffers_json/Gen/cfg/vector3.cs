// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace cfg
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct vector3 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_5_26(); }
  public static vector3 GetRootAsvector3(ByteBuffer _bb) { return GetRootAsvector3(_bb, new vector3()); }
  public static vector3 GetRootAsvector3(ByteBuffer _bb, vector3 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public vector3 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Z { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<cfg.vector3> Createvector3(FlatBufferBuilder builder,
      float x = 0.0f,
      float y = 0.0f,
      float z = 0.0f) {
    builder.StartTable(3);
    vector3.AddZ(builder, z);
    vector3.AddY(builder, y);
    vector3.AddX(builder, x);
    return vector3.Endvector3(builder);
  }

  public static void Startvector3(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddX(FlatBufferBuilder builder, float x) { builder.AddFloat(0, x, 0.0f); }
  public static void AddY(FlatBufferBuilder builder, float y) { builder.AddFloat(1, y, 0.0f); }
  public static void AddZ(FlatBufferBuilder builder, float z) { builder.AddFloat(2, z, 0.0f); }
  public static Offset<cfg.vector3> Endvector3(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<cfg.vector3>(o);
  }
}


static public class vector3Verify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*X*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Y*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*Z*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}