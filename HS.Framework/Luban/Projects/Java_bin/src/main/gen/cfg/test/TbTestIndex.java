
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.test;

import luban.*;


public final class TbTestIndex {
    private final java.util.HashMap<Integer, cfg.test.TestIndex> _dataMap;
    private final java.util.ArrayList<cfg.test.TestIndex> _dataList;
    
    public TbTestIndex(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.test.TestIndex>();
        _dataList = new java.util.ArrayList<cfg.test.TestIndex>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.test.TestIndex _v;
            _v = cfg.test.TestIndex.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.test.TestIndex> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.test.TestIndex> getDataList() { return _dataList; }

    public cfg.test.TestIndex get(int key) { return _dataMap.get(key); }

}
