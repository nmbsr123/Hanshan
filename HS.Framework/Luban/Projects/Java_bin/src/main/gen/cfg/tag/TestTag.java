
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.tag;

import luban.*;


public final class TestTag extends AbstractBean {
    public TestTag(ByteBuf _buf) { 
        id = _buf.readInt();
        value = _buf.readString();
    }

    public static TestTag deserialize(ByteBuf _buf) {
            return new cfg.tag.TestTag(_buf);
    }

    public final int id;
    public final String value;

    public static final int __ID__ = 1742933812;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + value + ","
        + "}";
    }
}

