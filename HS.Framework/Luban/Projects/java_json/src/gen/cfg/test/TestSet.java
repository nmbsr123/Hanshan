
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


public final class TestSet extends AbstractBean {
    public TestSet(JsonObject _buf) { 
        id = _buf.get("id").getAsInt();
        x0 = _buf.get("x0").getAsString();
        { com.google.gson.JsonArray _json0_ = _buf.get("x1").getAsJsonArray(); x1 = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  x1.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("x2").getAsJsonArray(); x2 = new java.util.ArrayList<Long>(_json0_.size()); for(JsonElement _e0 : _json0_) { long _v0;  _v0 = _e0.getAsLong();  x2.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("x3").getAsJsonArray(); x3 = new java.util.ArrayList<String>(_json0_.size()); for(JsonElement _e0 : _json0_) { String _v0;  _v0 = _e0.getAsString();  x3.add(_v0); }   }
        { com.google.gson.JsonArray _json0_ = _buf.get("x4").getAsJsonArray(); x4 = new java.util.ArrayList<Integer>(_json0_.size()); for(JsonElement _e0 : _json0_) { int _v0;  _v0 = _e0.getAsInt();  x4.add(_v0); }   }
    }

    public static TestSet deserialize(JsonObject _buf) {
            return new cfg.test.TestSet(_buf);
    }

    public final int id;
    public final String x0;
    public final java.util.ArrayList<Integer> x1;
    public final java.util.ArrayList<Long> x2;
    public final java.util.ArrayList<String> x3;
    public final java.util.ArrayList<Integer> x4;

    public static final int __ID__ = -543221516;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + x0 + ","
        + "(format_field_name __code_style field.name):" + x1 + ","
        + "(format_field_name __code_style field.name):" + x2 + ","
        + "(format_field_name __code_style field.name):" + x3 + ","
        + "(format_field_name __code_style field.name):" + x4 + ","
        + "}";
    }
}
