
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class CompositeJsonTable1 extends AbstractBean {
    public CompositeJsonTable1(ByteBuf _buf) { 
        id = _buf.readInt();
        x = _buf.readString();
    }

    public static CompositeJsonTable1 deserialize(ByteBuf _buf) {
            return new cfg.test.CompositeJsonTable1(_buf);
    }

    public final int id;
    public final String x;

    public static final int __ID__ = 1566207894;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + x + ","
        + "}";
    }
}
