
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

type Test2Rectangle struct {
    Width float32
    Height float32
}

const TypeId_Test2Rectangle = 694982337

func (*Test2Rectangle) GetTypeId() int32 {
    return 694982337
}

func NewTest2Rectangle(_buf *luban.ByteBuf) (_v *Test2Rectangle, err error) {
    _v = &Test2Rectangle{}
    { if _v.Width, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    { if _v.Height, err = _buf.ReadFloat(); err != nil { err = errors.New("error"); return } }
    return
}

