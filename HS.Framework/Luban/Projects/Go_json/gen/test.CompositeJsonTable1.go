
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg;


import "errors"

type TestCompositeJsonTable1 struct {
    Id int32
    X string
}

const TypeId_TestCompositeJsonTable1 = 1566207894

func (*TestCompositeJsonTable1) GetTypeId() int32 {
    return 1566207894
}

func NewTestCompositeJsonTable1(_buf map[string]interface{}) (_v *TestCompositeJsonTable1, err error) {
    _v = &TestCompositeJsonTable1{}
    { var _ok_ bool; var _tempNum_ float64; if _tempNum_, _ok_ = _buf["id"].(float64); !_ok_ { err = errors.New("id error"); return }; _v.Id = int32(_tempNum_) }
    { var _ok_ bool; if _v.X, _ok_ = _buf["x"].(string); !_ok_ { err = errors.New("x error"); return } }
    return
}

