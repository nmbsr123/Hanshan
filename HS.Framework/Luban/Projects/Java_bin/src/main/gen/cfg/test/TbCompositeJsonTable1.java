
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbCompositeJsonTable1 {
    private final java.util.HashMap<Integer, cfg.test.CompositeJsonTable1> _dataMap;
    private final java.util.ArrayList<cfg.test.CompositeJsonTable1> _dataList;
    
    public TbCompositeJsonTable1(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.CompositeJsonTable1>();
        _dataList = new java.util.ArrayList<cfg.test.CompositeJsonTable1>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.CompositeJsonTable1 _v;
            _v = cfg.test.CompositeJsonTable1.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.CompositeJsonTable1> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.CompositeJsonTable1> getDataList() { return _dataList; }

    public cfg.test.CompositeJsonTable1 get(int key) { return _dataMap.get(key); }

}
