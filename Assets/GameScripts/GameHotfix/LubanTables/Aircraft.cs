
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
public sealed partial class Aircraft : Luban.BeanBase
{
    public Aircraft(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["ThrusterId"].IsNumber) { throw new SerializationException(); }  ThrusterId = _buf["ThrusterId"]; }
        { var __json0 = _buf["WeaponId"]; if(!__json0.IsArray) { throw new SerializationException(); } WeaponId = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  WeaponId.Add(__v0); }   }
        { var __json0 = _buf["ArmorId"]; if(!__json0.IsArray) { throw new SerializationException(); } ArmorId = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  ArmorId.Add(__v0); }   }
        { if(!_buf["DeadEffectId"].IsNumber) { throw new SerializationException(); }  DeadEffectId = _buf["DeadEffectId"]; }
        { if(!_buf["DeadSoundId"].IsNumber) { throw new SerializationException(); }  DeadSoundId = _buf["DeadSoundId"]; }
    }

    public static Aircraft DeserializeAircraft(JSONNode _buf)
    {
        return new Aircraft(_buf);
    }

    /// <summary>
    /// 声音编号
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 推进器编号
    /// </summary>
    public readonly int ThrusterId;
    /// <summary>
    /// 武器编号
    /// </summary>
    public readonly System.Collections.Generic.List<int> WeaponId;
    /// <summary>
    /// 装甲编号0
    /// </summary>
    public readonly System.Collections.Generic.List<int> ArmorId;
    /// <summary>
    /// 死亡特效编号
    /// </summary>
    public readonly int DeadEffectId;
    /// <summary>
    /// 死亡声音编号
    /// </summary>
    public readonly int DeadSoundId;
   
    public const int __ID__ = -624194762;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "ThrusterId:" + ThrusterId + ","
        + "WeaponId:" + Luban.StringUtil.CollectionToString(WeaponId) + ","
        + "ArmorId:" + Luban.StringUtil.CollectionToString(ArmorId) + ","
        + "DeadEffectId:" + DeadEffectId + ","
        + "DeadSoundId:" + DeadSoundId + ","
        + "}";
    }
}

}
