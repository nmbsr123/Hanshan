
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


public final class TbDemoGroup_S {
    private final java.util.HashMap<Integer, cfg.test.DemoGroup> _dataMap;
    private final java.util.ArrayList<cfg.test.DemoGroup> _dataList;
    
    public TbDemoGroup_S(JsonElement _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.DemoGroup>();
        _dataList = new java.util.ArrayList<cfg.test.DemoGroup>();
        
        for (com.google.gson.JsonElement _e_ : _buf.getAsJsonArray()) {
            cfg.test.DemoGroup _v;
            _v = cfg.test.DemoGroup.deserialize(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.DemoGroup> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.DemoGroup> getDataList() { return _dataList; }

    public cfg.test.DemoGroup get(int key) { return _dataMap.get(key); }

}
