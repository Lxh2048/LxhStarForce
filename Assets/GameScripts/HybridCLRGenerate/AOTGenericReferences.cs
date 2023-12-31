using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"Game.Main.dll",
		"GameFramework.dll",
		"System.dll",
		"UnityEngine.CoreModule.dll",
		"UnityGameFramework.Runtime.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// GameFramework.Fsm.Fsm<object>
	// GameFramework.Fsm.FsmState<object>
	// GameFramework.Fsm.IFsm<object>
	// GameFramework.GameFrameworkAction<object>
	// GameFramework.GameFrameworkLinkedList.Enumerator<object>
	// GameFramework.GameFrameworkLinkedList<object>
	// GameFramework.ObjectPool.IObjectPool<object>
	// GameFramework.Variable<byte>
	// System.Action<byte>
	// System.Action<int>
	// System.Action<object>
	// System.Collections.Generic.ArraySortHelper<byte>
	// System.Collections.Generic.ArraySortHelper<int>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<byte>
	// System.Collections.Generic.Comparer<int>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.Dictionary.Enumerator<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.Enumerator<object,byte>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,byte>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.Dictionary.KeyCollection<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,byte>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,byte>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.Dictionary.ValueCollection<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,byte>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.Dictionary<object,byte>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<Game.Hotfix.CampPair>
	// System.Collections.Generic.EqualityComparer<System.Collections.Generic.KeyValuePair<byte,byte>>
	// System.Collections.Generic.EqualityComparer<byte>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<Game.Hotfix.CampPair,byte>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,byte>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<byte>
	// System.Collections.Generic.ICollection<int>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<byte>
	// System.Collections.Generic.IComparer<int>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Game.Hotfix.CampPair,byte>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,byte>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<byte>
	// System.Collections.Generic.IEnumerable<int>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<Game.Hotfix.CampPair,byte>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,byte>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<byte>
	// System.Collections.Generic.IEnumerator<int>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<Game.Hotfix.CampPair>
	// System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<byte,byte>>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<byte>
	// System.Collections.Generic.IList<int>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.KeyValuePair<Game.Hotfix.CampPair,byte>
	// System.Collections.Generic.KeyValuePair<System.Collections.Generic.KeyValuePair<byte,byte>,object>
	// System.Collections.Generic.KeyValuePair<byte,byte>
	// System.Collections.Generic.KeyValuePair<int,int>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,byte>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.LinkedList.Enumerator<object>
	// System.Collections.Generic.LinkedList<object>
	// System.Collections.Generic.LinkedListNode<object>
	// System.Collections.Generic.List.Enumerator<byte>
	// System.Collections.Generic.List.Enumerator<int>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List.SynchronizedList<byte>
	// System.Collections.Generic.List.SynchronizedList<int>
	// System.Collections.Generic.List.SynchronizedList<object>
	// System.Collections.Generic.List<byte>
	// System.Collections.Generic.List<int>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<byte>
	// System.Collections.Generic.ObjectComparer<int>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<Game.Hotfix.CampPair>
	// System.Collections.Generic.ObjectEqualityComparer<System.Collections.Generic.KeyValuePair<byte,byte>>
	// System.Collections.Generic.ObjectEqualityComparer<byte>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.Generic.Queue.Enumerator<object>
	// System.Collections.Generic.Queue<object>
	// System.Collections.ObjectModel.ReadOnlyCollection<byte>
	// System.Collections.ObjectModel.ReadOnlyCollection<int>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Comparison<byte>
	// System.Comparison<int>
	// System.Comparison<object>
	// System.EventHandler<object>
	// System.Func<object,object>
	// System.Nullable<int>
	// System.Predicate<byte>
	// System.Predicate<int>
	// System.Predicate<object>
	// System.Runtime.CompilerServices.ConditionalWeakTable.CreateValueCallback<object,object>
	// System.Runtime.CompilerServices.ConditionalWeakTable<object,object>
	// }}

	public void RefMethods()
	{
		// System.Void Game.Main.LubanTableComponent.SetTables<object>(object)
		// bool Game.Main.LubanTableComponent.TryGetTables<object>(object&)
		// System.Void GameFramework.Fsm.Fsm<object>.ChangeState<object>()
		// System.Void GameFramework.Fsm.FsmState<object>.ChangeState<object>(GameFramework.Fsm.IFsm<object>)
		// object GameFramework.Fsm.IFsm<object>.GetData<object>(string)
		// System.Void GameFramework.Fsm.IFsm<object>.SetData<object>(string,object)
		// bool GameFramework.Fsm.IFsmManager.DestroyFsm<object>()
		// object GameFramework.GameFrameworkEntry.GetModule<object>()
		// System.Void GameFramework.GameFrameworkLog.Error<object,object,object>(string,object,object,object)
		// System.Void GameFramework.GameFrameworkLog.Error<object,object>(string,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object,object,object,object>(string,object,object,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object,object,object>(string,object,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object,object>(string,object,object)
		// System.Void GameFramework.GameFrameworkLog.Info<object>(string,object)
		// System.Void GameFramework.GameFrameworkLog.Warning<object,object,object>(string,object,object,object)
		// System.Void GameFramework.GameFrameworkLog.Warning<object,object>(string,object,object)
		// System.Void GameFramework.GameFrameworkLog.Warning<object>(string,object)
		// System.Void GameFramework.Network.INetworkChannel.Send<object>(object)
		// GameFramework.ObjectPool.IObjectPool<object> GameFramework.ObjectPool.IObjectPoolManager.CreateSingleSpawnObjectPool<object>(string,int)
		// System.Void GameFramework.Procedure.IProcedureManager.StartProcedure<object>()
		// object GameFramework.ReferencePool.Acquire<object>()
		// object GameFramework.ReferencePool.ReferenceCollection.Acquire<object>()
		// string GameFramework.Utility.Text.Format<object,object,object,object>(string,object,object,object,object)
		// string GameFramework.Utility.Text.Format<object,object,object>(string,object,object,object)
		// string GameFramework.Utility.Text.Format<object,object>(string,object,object)
		// string GameFramework.Utility.Text.Format<object>(string,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object,object,object,object>(string,object,object,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object,object,object>(string,object,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object,object>(string,object,object)
		// string GameFramework.Utility.Text.ITextHelper.Format<object>(string,object)
		// string Luban.StringUtil.CollectionToString<int>(System.Collections.Generic.IEnumerable<int>)
		// object System.Activator.CreateInstance<object>()
		// object UnityEngine.Component.GetComponent<object>()
		// object UnityEngine.Component.GetComponentInParent<object>()
		// System.Void UnityEngine.Component.GetComponentsInChildren<object>(bool,System.Collections.Generic.List<object>)
		// object[] UnityEngine.Component.GetComponentsInChildren<object>(bool)
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.GameObject.GetComponent<object>()
		// System.Void UnityEngine.GameObject.GetComponentsInChildren<object>(bool,System.Collections.Generic.List<object>)
		// object[] UnityEngine.GameObject.GetComponentsInChildren<object>(bool)
		// object UnityEngine.Object.FindObjectOfType<object>()
		// object UnityEngine.Object.Instantiate<object>(object)
		// object UnityEngine.Object.Instantiate<object>(object,UnityEngine.Transform)
		// object UnityEngine.Object.Instantiate<object>(object,UnityEngine.Transform,bool)
		// object UnityExtension.GetOrAddComponent<object>(UnityEngine.GameObject)
		// bool UnityGameFramework.Runtime.FsmComponent.DestroyFsm<object>()
		// object UnityGameFramework.Runtime.GameEntry.GetComponent<object>()
		// System.Void UnityGameFramework.Runtime.Log.Error<object,object,object>(string,object,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Error<object,object>(string,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object,object,object,object>(string,object,object,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object,object,object>(string,object,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object,object>(string,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Info<object>(string,object)
		// System.Void UnityGameFramework.Runtime.Log.Warning<object,object,object>(string,object,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Warning<object,object>(string,object,object)
		// System.Void UnityGameFramework.Runtime.Log.Warning<object>(string,object)
		// GameFramework.ObjectPool.IObjectPool<object> UnityGameFramework.Runtime.ObjectPoolComponent.CreateSingleSpawnObjectPool<object>(string,int)
		// string string.Join<int>(string,System.Collections.Generic.IEnumerable<int>)
	}
}