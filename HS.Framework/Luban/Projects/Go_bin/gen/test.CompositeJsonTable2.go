
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

type TestCompositeJsonTable2 struct {
    Id int32
    Y int32
}

const TypeId_TestCompositeJsonTable2 = 1566207895

func (*TestCompositeJsonTable2) GetTypeId() int32 {
    return 1566207895
}

func NewTestCompositeJsonTable2(_buf *luban.ByteBuf) (_v *TestCompositeJsonTable2, err error) {
    _v = &TestCompositeJsonTable2{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Y, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    return
}

