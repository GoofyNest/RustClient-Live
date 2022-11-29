public class UnderwearSkinPicker : MonoBehaviour // TypeDefIndex: 10978
{
	public GameObjectRef pickerIcon; 
	public GameObject container; 
	public Action skinChangedEvent; 
	public Sprite defaultNudeIcon; 
	public Sprite defaultIconMale; 
	public Sprite defaultIconFemale; 


	public void RefreshUnderwear() { }

	protected void AddOption(string underwearShortName, string text, bool canUse, Sprite icon) { }

	public virtual void OnUnderwearChanged() { }

	public void .ctor() { }

}

