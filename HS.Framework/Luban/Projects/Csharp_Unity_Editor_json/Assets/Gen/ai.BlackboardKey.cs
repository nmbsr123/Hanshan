
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

namespace editor.cfg.ai
{

public sealed class BlackboardKey :  Luban.EditorBeanBase 
{
    public BlackboardKey()
    {
            name = "";
            desc = "";
            type = ai.EKeyType.BOOL;
            typeClassName = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  name = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["desc"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  desc = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["is_static"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  isStatic = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["type"];
            if (_fieldJson != null)
            {
                if(_fieldJson.IsString) { type = (ai.EKeyType)System.Enum.Parse(typeof(ai.EKeyType), _fieldJson); } else if(_fieldJson.IsNumber) { type = (ai.EKeyType)(int)_fieldJson; } else { throw new SerializationException(); }  
            }
        }
        
        { 
            var _fieldJson = _json["type_class_name"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  typeClassName = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        {

            if (name == null) { throw new System.ArgumentNullException(); }
            _json["name"] = new JSONString(name);
        }
        {

            if (desc == null) { throw new System.ArgumentNullException(); }
            _json["desc"] = new JSONString(desc);
        }
        {
            _json["is_static"] = new JSONBool(isStatic);
        }
        {
            _json["type"] = new JSONNumber((int)type);
        }
        {

            if (typeClassName == null) { throw new System.ArgumentNullException(); }
            _json["type_class_name"] = new JSONString(typeClassName);
        }
    }

    public static BlackboardKey LoadJsonBlackboardKey(SimpleJSON.JSONNode _json)
    {
        BlackboardKey obj = new ai.BlackboardKey();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonBlackboardKey(BlackboardKey _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    public string name;

    public string desc;

    public bool isStatic;

    public ai.EKeyType type;

    public string typeClassName;

}

}
