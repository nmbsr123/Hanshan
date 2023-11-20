
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

func NewAiComposeNode(_buf *luban.ByteBuf) (interface{}, error) {
    var id int32
    var err error
    if id, err = _buf.ReadInt() ; err != nil {
        return nil, err
    }
    switch id {
        case -1789006105: _v, err := NewAiSequence(_buf); if err != nil { return nil, errors.New("ai.sequence") } else { return _v, nil }
        case -1946981627: _v, err := NewAiSelector(_buf); if err != nil { return nil, errors.New("ai.selector") } else { return _v, nil }
        case -1952582529: _v, err := NewAiSimpleParallel(_buf); if err != nil { return nil, errors.New("ai.simpleparallel") } else { return _v, nil }
        default: return nil, errors.New("unknown type id")
    }
}

