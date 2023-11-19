
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type AiKeyData struct {
}

const TypeId_AiKeyData = 1022478019

func (*AiKeyData) GetTypeId() int32 {
    return 1022478019
}

func NewAiKeyData(_buf map[string]interface{}) (interface{}, error) {
    var id string
    var _ok_ bool
    if id, _ok_ = _buf["$type"].(string) ; !_ok_ {
        return nil, errors.New("type id missing")
    }
    switch id {
        case "FloatKeyData": _v, err := NewAiFloatKeyData(_buf); if err != nil { return nil, errors.New("aifloatkeydata") } else { return _v, nil }
        case "IntKeyData": _v, err := NewAiIntKeyData(_buf); if err != nil { return nil, errors.New("aiintkeydata") } else { return _v, nil }
        case "StringKeyData": _v, err := NewAiStringKeyData(_buf); if err != nil { return nil, errors.New("aistringkeydata") } else { return _v, nil }
        case "BlackboardKeyData": _v, err := NewAiBlackboardKeyData(_buf); if err != nil { return nil, errors.New("aiblackboardkeydata") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}


