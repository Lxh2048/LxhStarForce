using System;
using System.Threading.Tasks;
using Luban;
using SimpleJSON;

namespace Game.Main
{
    public class BaseLubanTables : ILubanTables
    {
        public virtual LubanTableType GetTableType { get; }

        public virtual Task LoadAsync(Func<string, Task<ByteBuf>> loader)
        {
            return null;
        }

        public virtual Task LoadAsync(Func<string, Task<JSONNode>> loader)
        {
            return null;
        }

        public virtual void TranslateText(Func<string, string, string> translator)
        {
            
        }
    }
}

