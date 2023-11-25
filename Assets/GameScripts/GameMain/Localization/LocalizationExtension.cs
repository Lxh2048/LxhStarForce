// -----------------------------------------------
// Copyright © GameFramework. All rights reserved.
// CreateTime: 2021/5/26   14:14:38
// -----------------------------------------------
using UnityGameFramework.Runtime;

using GameFramework;

namespace Game.Main
{	
	//本地化扩展工具
	public static class LocalizationExtension
	{
	    //加载本地化配置
		public static void LoadDictionary(this LocalizationComponent localizationComponent, string dictionaryName, bool fromBytes, object userData = null)
	    {
	        if (string.IsNullOrEmpty(dictionaryName))
	        {
	            Log.Warning("Dictionary name is invalid.");
	            return;
	        }
			string fullname = MainAssetUtility.GetDictionaryAsset(dictionaryName, fromBytes);

			localizationComponent.ReadData(fullname, MainConstant.AssetPriority.DictionaryAsset, userData);
	    }
	}
}
