
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.test
{
public sealed partial class TestBeRef : Luban.BeanBase
{
    public TestBeRef(JSONNode _buf) 
    {
        { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
        { if(!_buf["count"].IsNumber) { throw new SerializationException(); }  Count = _buf["count"]; }
    }

    public static TestBeRef DeserializeTestBeRef(JSONNode _buf)
    {
        return new test.TestBeRef(_buf);
    }

    public readonly int Id;
    public readonly int Count;
   
    public const int __ID__ = 1934403938;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "count:" + Count + ","
        + "}";
    }
}

}
