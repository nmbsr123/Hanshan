
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type AiDecorator struct {
    Id int32
    NodeName string
    FlowAbortMode int32
}

const TypeId_AiDecorator = 2017109461

func (*AiDecorator) GetTypeId() int32 {
    return 2017109461
}

func NewAiDecorator(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["$type"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "UeLoop": _v, err := NewAiUeLoop(_buf); if err != nil { return nil, errors.New("aiueloop") } else { return _v, nil }
        case "UeCooldown": _v, err := NewAiUeCooldown(_buf); if err != nil { return nil, errors.New("aiuecooldown") } else { return _v, nil }
        case "UeTimeLimit": _v, err := NewAiUeTimeLimit(_buf); if err != nil { return nil, errors.New("aiuetimelimit") } else { return _v, nil }
        case "UeBlackboard": _v, err := NewAiUeBlackboard(_buf); if err != nil { return nil, errors.New("aiueblackboard") } else { return _v, nil }
        case "UeForceSuccess": _v, err := NewAiUeForceSuccess(_buf); if err != nil { return nil, errors.New("aiueforcesuccess") } else { return _v, nil }
        case "IsAtLocation": _v, err := NewAiIsAtLocation(_buf); if err != nil { return nil, errors.New("aiisatlocation") } else { return _v, nil }
        case "DistanceLessThan": _v, err := NewAiDistanceLessThan(_buf); if err != nil { return nil, errors.New("aidistancelessthan") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}


