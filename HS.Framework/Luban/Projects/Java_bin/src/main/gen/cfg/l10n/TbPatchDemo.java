
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.l10n;

import luban.*;


public final class TbPatchDemo {
    private final java.util.HashMap<Integer, cfg.l10n.PatchDemo> _dataMap;
    private final java.util.ArrayList<cfg.l10n.PatchDemo> _dataList;
    
    public TbPatchDemo(ByteBuf _buf) {
        _dataMap = new java.util.HashMap<Integer, cfg.l10n.PatchDemo>();
        _dataList = new java.util.ArrayList<cfg.l10n.PatchDemo>();
        
        for(int n = _buf.readSize() ; n > 0 ; --n) {
            cfg.l10n.PatchDemo _v;
            _v = cfg.l10n.PatchDemo.deserialize(_buf);
            _dataList.add(_v);
            _dataMap.put(_v.id, _v);
        }
    }

    public java.util.HashMap<Integer, cfg.l10n.PatchDemo> getDataMap() { return _dataMap; }
    public java.util.ArrayList<cfg.l10n.PatchDemo> getDataList() { return _dataList; }

    public cfg.l10n.PatchDemo get(int key) { return _dataMap.get(key); }

}
