
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

type TestItem struct {
    Id int32
    Name string
    Desc string
    Num int32
    Price int32
}

const TypeId_TestItem = -1226641649

func (*TestItem) GetTypeId() int32 {
    return -1226641649
}

func NewTestItem(_buf *luban.ByteBuf) (_v *TestItem, err error) {
    _v = &TestItem{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Name, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.Desc, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.Num, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.Price, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    return
}

