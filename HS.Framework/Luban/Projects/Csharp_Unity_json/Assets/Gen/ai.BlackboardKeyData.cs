
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.ai
{
public sealed partial class BlackboardKeyData : ai.KeyData
{
    public BlackboardKeyData(JSONNode _buf)  : base(_buf) 
    {
        { if(!_buf["value"].IsString) { throw new SerializationException(); }  Value = _buf["value"]; }
    }

    public static BlackboardKeyData DeserializeBlackboardKeyData(JSONNode _buf)
    {
        return new ai.BlackboardKeyData(_buf);
    }

    public readonly string Value;
   
    public const int __ID__ = 1517269500;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "value:" + Value + ","
        + "}";
    }
}

}
