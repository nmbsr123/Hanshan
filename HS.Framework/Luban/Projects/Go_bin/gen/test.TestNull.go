
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

type TestTestNull struct {
    Id int32
    X1 *int32
    X2 *int32
    X3 *TestDemoType1
    X4 interface{}
    S1 *string
    S2 *string
}

const TypeId_TestTestNull = 339868469

func (*TestTestNull) GetTypeId() int32 {
    return 339868469
}

func NewTestTestNull(_buf *luban.ByteBuf) (_v *TestTestNull, err error) {
    _v = &TestTestNull{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ int32;  { if __x__, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; _v.X1 = &__x__ }}
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ int32;  { if __x__, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }; _v.X2 = &__x__ }}
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ *TestDemoType1;  { if __x__, err = NewTestDemoType1(_buf); err != nil { err = errors.New("error"); return } }; _v.X3 = __x__ }}
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ interface{};  { if __x__, err = NewTestDemoDynamic(_buf); err != nil { err = errors.New("error"); return } }; _v.X4 = __x__ }}
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ string;  { if __x__, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }; _v.S1 = &__x__ }}
    { var __exists__ bool; if __exists__, err = _buf.ReadBool(); err != nil { return }; if __exists__ { var __x__ string;  { if __x__, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }; _v.S2 = &__x__ }}
    return
}

