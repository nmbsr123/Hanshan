
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


public final class CompositeJsonTable2 extends AbstractBean {
    public CompositeJsonTable2(JsonObject _buf) { 
        id = _buf.get("id").getAsInt();
        y = _buf.get("y").getAsInt();
    }

    public static CompositeJsonTable2 deserialize(JsonObject _buf) {
            return new cfg.test.CompositeJsonTable2(_buf);
    }

    public final int id;
    public final int y;

    public static final int __ID__ = 1566207895;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + y + ","
        + "}";
    }
}

