
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

type AiBlackboardKeyData struct {
    Value string
}

const TypeId_AiBlackboardKeyData = 1517269500

func (*AiBlackboardKeyData) GetTypeId() int32 {
    return 1517269500
}

func NewAiBlackboardKeyData(_buf *luban.ByteBuf) (_v *AiBlackboardKeyData, err error) {
    _v = &AiBlackboardKeyData{}
    { if _v.Value, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    return
}

