
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class DemoE2 extends AbstractBean {
    public DemoE2(JsonObject _buf) { 
        { if (_buf.has("y1") && !_buf.get("y1").isJsonNull()) { y1 = _buf.get("y1").getAsInt(); } else { y1 = null; } }
        y2 = _buf.get("y2").getAsBoolean();
    }

    public static DemoE2 deserialize(JsonObject _buf) {
            return new cfg.test.DemoE2(_buf);
    }

    public final Integer y1;
    public final boolean y2;

    public static final int __ID__ = -2138341716;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + y1 + ","
        + "(format_field_name __code_style field.name):" + y2 + ","
        + "}";
    }
}

