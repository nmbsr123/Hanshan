
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.l10n;

import luban.*;


public final class L10NDemo extends AbstractBean {
    public L10NDemo(ByteBuf _buf) { 
        id = _buf.readInt();
        text = _buf.readString();
    }

    public static L10NDemo deserialize(ByteBuf _buf) {
            return new cfg.l10n.L10NDemo(_buf);
    }

    public final int id;
    public final String text;

    public static final int __ID__ = -331195887;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + text + ","
        + "}";
    }
}

