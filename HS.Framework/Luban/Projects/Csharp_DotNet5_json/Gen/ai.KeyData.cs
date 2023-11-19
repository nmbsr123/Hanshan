
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using System.Text.Json;


namespace cfg.ai
{
public abstract partial class KeyData : Luban.BeanBase
{
    public KeyData(JsonElement _buf) 
    {
    }

    public static KeyData DeserializeKeyData(JsonElement _buf)
    {
        switch (_buf.GetProperty("$type").GetString())
        {
            case "FloatKeyData": return new ai.FloatKeyData(_buf);
            case "IntKeyData": return new ai.IntKeyData(_buf);
            case "StringKeyData": return new ai.StringKeyData(_buf);
            case "BlackboardKeyData": return new ai.BlackboardKeyData(_buf);
            default: throw new SerializationException();
        }
    }

   

    public virtual void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "}";
    }
}

}
