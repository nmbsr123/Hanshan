
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

type AiChooseSkill struct {
    Id int32
    NodeName string
    Decorators []interface{}
    Services []interface{}
    IgnoreRestartSelf bool
    TargetActorKey string
    ResultSkillIdKey string
}

const TypeId_AiChooseSkill = -918812268

func (*AiChooseSkill) GetTypeId() int32 {
    return -918812268
}

func NewAiChooseSkill(_buf *luban.ByteBuf) (_v *AiChooseSkill, err error) {
    _v = &AiChooseSkill{}
    { if _v.Id, err = _buf.ReadInt(); err != nil { err = errors.New("error"); return } }
    { if _v.NodeName, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    {_v.Decorators = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = NewAiDecorator(_buf); err != nil { err = errors.New("error"); return } }; _v.Decorators = append(_v.Decorators, _e_) } }
    {_v.Services = make([]interface{}, 0); var _n_ int; if _n_, err = _buf.ReadSize(); err != nil { err = errors.New("error"); return}; for i := 0 ; i < _n_ ; i++ { var _e_ interface{}; { if _e_, err = NewAiService(_buf); err != nil { err = errors.New("error"); return } }; _v.Services = append(_v.Services, _e_) } }
    { if _v.IgnoreRestartSelf, err = _buf.ReadBool(); err != nil { err = errors.New("error"); err = errors.New("error"); return } }
    { if _v.TargetActorKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    { if _v.ResultSkillIdKey, err = _buf.ReadString(); err != nil { err = errors.New("error"); return } }
    return
}
