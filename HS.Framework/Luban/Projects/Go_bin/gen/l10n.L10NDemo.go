
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

type L10nL10NDemo struct {
    Id int32
    Text string
}

const TypeId_L10nL10NDemo = -331195887

func (*L10nL10NDemo) GetTypeId() int32 {
    return -331195887
}

func NewL10nL10NDemo(_buf *luban.ByteBuf) (_v *L10nL10NDemo, err error) {
    _v = &L10nL10NDemo{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Text, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    return
}

