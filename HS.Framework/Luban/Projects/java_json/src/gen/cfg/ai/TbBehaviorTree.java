
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


public final class TbBehaviorTree {
    private final java.util.HashMap<Integer, cfg.ai.BehaviorTree> _dataMap;
    private final java.util.ArrayList<cfg.ai.BehaviorTree> _dataList;
    
    public TbBehaviorTree(JsonElement _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.ai.BehaviorTree>();
        _dataList = new java.util.ArrayList<cfg.ai.BehaviorTree>();
        
        for (com.google.gson.JsonElement _e_ : _buf.getAsJsonArray()) {
            cfg.ai.BehaviorTree _v;
            _v = cfg.ai.BehaviorTree.deserialize(_e_.getAsJsonObject());
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.ai.BehaviorTree> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.ai.BehaviorTree> getDataList() { return _dataList; }

    public cfg.ai.BehaviorTree get(int key) { return _dataMap.get(key); }

}
