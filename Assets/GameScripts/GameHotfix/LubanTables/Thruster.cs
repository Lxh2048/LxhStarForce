
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
public sealed partial class Thruster : Luban.BeanBase
{
    public Thruster(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["Speed"].IsNumber) { throw new SerializationException(); }  Speed = _buf["Speed"]; }
    }

    public static Thruster DeserializeThruster(JSONNode _buf)
    {
        return new Thruster(_buf);
    }

    /// <summary>
    /// 推进器编号
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 速度
    /// </summary>
    public readonly float Speed;
   
    public const int __ID__ = 1553598245;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Speed:" + Speed + ","
        + "}";
    }
}

}
