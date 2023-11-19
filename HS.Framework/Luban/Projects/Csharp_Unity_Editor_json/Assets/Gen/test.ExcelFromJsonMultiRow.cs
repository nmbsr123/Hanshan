
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using SimpleJSON;
using Luban;

namespace editor.cfg.test
{

public sealed class ExcelFromJsonMultiRow :  Luban.EditorBeanBase 
{
    public ExcelFromJsonMultiRow()
    {
            items = new System.Collections.Generic.List<test.TestRow>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["x"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  x = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["items"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } items = new System.Collections.Generic.List<test.TestRow>(); foreach(JSONNode __e in _fieldJson.Children) { test.TestRow __v;  if(!__e.IsObject) { throw new SerializationException(); }  __v = test.TestRow.LoadJsonTestRow(__e);  items.Add(__v); }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {
            _json["id"] = new JSONNumber(id);
        }
        {
            _json["x"] = new JSONNumber(x);
        }
        {

            if (items == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in items) { { var __bjson = new JSONObject();  test.TestRow.SaveJsonTestRow(_e, __bjson); __cjson["null"] = __bjson; } } _json["items"] = __cjson; }
        }
    }

    public static ExcelFromJsonMultiRow LoadJsonExcelFromJsonMultiRow(SimpleJSON.JSONNode _json)
    {
        ExcelFromJsonMultiRow obj = new test.ExcelFromJsonMultiRow();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonExcelFromJsonMultiRow(ExcelFromJsonMultiRow _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public int id;

    public int x;

    public System.Collections.Generic.List<test.TestRow> items;

}

}
