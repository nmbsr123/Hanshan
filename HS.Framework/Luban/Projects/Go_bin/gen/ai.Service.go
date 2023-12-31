
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import (
    "demo/luban"
)

import "errors"

type AiService struct {
    Id int32
    NodeName string
}

const TypeId_AiService = -472395057

func (*AiService) GetTypeId() int32 {
    return -472395057
}

func NewAiService(_buf *luban.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case 1812449155: _v, err := NewAiUeSetDefaultFocus(_buf); if err != nil { return nil, errors.New("ai.uesetdefaultfocus") } else { return _v, nil }
        case 990693812: _v, err := NewAiExecuteTimeStatistic(_buf); if err != nil { return nil, errors.New("ai.executetimestatistic") } else { return _v, nil }
        case 1601247918: _v, err := NewAiChooseTarget(_buf); if err != nil { return nil, errors.New("ai.choosetarget") } else { return _v, nil }
        case 1195270745: _v, err := NewAiKeepFaceTarget(_buf); if err != nil { return nil, errors.New("ai.keepfacetarget") } else { return _v, nil }
        case -999247644: _v, err := NewAiGetOwnerPlayer(_buf); if err != nil { return nil, errors.New("ai.getownerplayer") } else { return _v, nil }
        case -61887372: _v, err := NewAiUpdateDailyBehaviorProps(_buf); if err != nil { return nil, errors.New("ai.updatedailybehaviorprops") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}


