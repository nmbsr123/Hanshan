
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type AiComposeNode struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
}

const TypeId_AiComposeNode = -70129202

func (*AiComposeNode) GetTypeId() int32 {
    return -70129202
}

func NewAiComposeNode(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["$type"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "Sequence": _v, err := NewAiSequence(_buf); if err != nil { return nil, errors.New("aisequence") } else { return _v, nil }
        case "Selector": _v, err := NewAiSelector(_buf); if err != nil { return nil, errors.New("aiselector") } else { return _v, nil }
        case "SimpleParallel": _v, err := NewAiSimpleParallel(_buf); if err != nil { return nil, errors.New("aisimpleparallel") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}


