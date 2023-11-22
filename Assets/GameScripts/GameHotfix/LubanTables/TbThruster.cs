
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
public partial class TbThruster
{
    private readonly System.Collections.Generic.Dictionary<int, Thruster> _dataMap;
    private readonly System.Collections.Generic.List<Thruster> _dataList;
    
    public TbThruster(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Thruster>();
        _dataList = new System.Collections.Generic.List<Thruster>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Thruster _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Thruster.DeserializeThruster(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Thruster> DataMap => _dataMap;
    public System.Collections.Generic.List<Thruster> DataList => _dataList;

    public Thruster GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Thruster Get(int key) => _dataMap[key];
    public Thruster this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
