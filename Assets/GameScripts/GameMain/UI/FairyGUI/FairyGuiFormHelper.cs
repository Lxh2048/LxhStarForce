using GameEntry = Game.Main.GameEntry;
using GameFramework.UI;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Game.Main
{
    public class FairyGuiFormHelper : UIFormHelperBase
    {
        public override object InstantiateUIForm(object uiFormAsset)
        {
            return Instantiate((Object)uiFormAsset);
        }
        
        public override IUIForm CreateUIForm(object uiFormInstance, IUIGroup uiGroup, object userData)
        {
            GameObject gameObject = uiFormInstance as GameObject;
            if (gameObject == null)
            {
                Log.Error("UI form instance is invalid.");
                return null;
            }

            Transform transform = gameObject.transform;
            transform.SetParent(((MonoBehaviour)uiGroup.Helper).transform);

            FairyGuiFormBase fairyGuiForm = gameObject.GetComponent<FairyGuiFormBase>();
            fairyGuiForm.CreateUIForm(uiGroup, userData);
            
            return gameObject.GetOrAddComponent<UIForm>();
        }
        
        public override void ReleaseUIForm(object uiFormAsset, object uiFormInstance)
        {
            FairyGuiFormBase fairyGuiForm = ((GameObject)uiFormInstance).GetComponent<FairyGuiFormBase>();
            fairyGuiForm.ReleaseUIForm();
            
            
            GameEntry.Resource.UnloadAsset(uiFormAsset);
            Destroy((Object)uiFormInstance);
        }
    }
}
