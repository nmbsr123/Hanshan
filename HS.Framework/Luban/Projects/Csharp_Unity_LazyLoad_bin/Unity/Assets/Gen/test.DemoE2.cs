
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
    public partial struct DemoE2
    {
        public DemoE2(ByteBuf _buf) 
        {
            if(_buf.ReadBool()){ Y1 = _buf.ReadInt(); } else { Y1 = null; }
            Y2 = _buf.ReadBool();
        }

        public static DemoE2 DeserializeDemoE2(ByteBuf _buf)
        {
            return new test.DemoE2(_buf);
        }

        public readonly int? Y1;
        public readonly bool Y2;
   

        public  void ResolveRef(Tables tables)
        {
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "y1:" + Y1 + ","
            + "y2:" + Y2 + ","
            + "}";
        }
    }

}
