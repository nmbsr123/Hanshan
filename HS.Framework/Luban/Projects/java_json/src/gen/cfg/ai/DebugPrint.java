
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public final class DebugPrint extends cfg.ai.Task {
    public DebugPrint(JsonObject _buf) { 
        super(_buf);
        text = _buf.get("text").getAsString();
    }

    public static DebugPrint deserialize(JsonObject _buf) {
            return new cfg.ai.DebugPrint(_buf);
    }

    public final String text;

    public static final int __ID__ = 1357409728;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + nodeName + ","
        + "(format_field_name __code_style field.name):" + decorators + ","
        + "(format_field_name __code_style field.name):" + services + ","
        + "(format_field_name __code_style field.name):" + ignoreRestartSelf + ","
        + "(format_field_name __code_style field.name):" + text + ","
        + "}";
    }
}

