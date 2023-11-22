
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace Game.Hotfix.Cfg
{
public partial class TbAircraft
{
    private readonly System.Collections.Generic.Dictionary<int, Aircraft> _dataMap;
    private readonly System.Collections.Generic.List<Aircraft> _dataList;
    
    public TbAircraft(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Aircraft>();
        _dataList = new System.Collections.Generic.List<Aircraft>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Aircraft _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Aircraft.DeserializeAircraft(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Aircraft> DataMap => _dataMap;
    public System.Collections.Generic.List<Aircraft> DataList => _dataList;

    public Aircraft GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Aircraft Get(int key) => _dataMap[key];
    public Aircraft this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}