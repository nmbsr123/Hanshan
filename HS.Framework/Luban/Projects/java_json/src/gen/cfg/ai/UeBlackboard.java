
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


public final class UeBlackboard extends cfg.ai.Decorator {
    public UeBlackboard(JsonObject _buf) { 
        super(_buf);
        notifyObserver = _buf.get("notify_observer").getAsInt();
        blackboardKey = _buf.get("blackboard_key").getAsString();
        keyQuery = cfg.ai.KeyQueryOperator.deserialize(_buf.get("key_query").getAsJsonObject());
    }

    public static UeBlackboard deserialize(JsonObject _buf) {
            return new cfg.ai.UeBlackboard(_buf);
    }

    public final int notifyObserver;
    public final String blackboardKey;
    public final cfg.ai.KeyQueryOperator keyQuery;

    public static final int __ID__ = -315297507;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + nodeName + ","
        + "(format_field_name __code_style field.name):" + flowAbortMode + ","
        + "(format_field_name __code_style field.name):" + notifyObserver + ","
        + "(format_field_name __code_style field.name):" + blackboardKey + ","
        + "(format_field_name __code_style field.name):" + keyQuery + ","
        + "}";
    }
}

