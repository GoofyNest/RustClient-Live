public class UnderwearSkinPicker : MonoBehaviour // TypeDefIndex: 9248
{	public GameObjectRef pickerIcon; // 0x18
	public GameObject container; // 0x20
	public Action skinChangedEvent; // 0x28
	public Sprite defaultNudeIcon; // 0x30
	public Sprite defaultIconMale; // 0x38
	public Sprite defaultIconFemale; // 0x40


	public void RefreshUnderwear() { }

	protected void AddOption(string underwearShortName, string text, bool canUse, Sprite icon) { }

	public virtual void OnUnderwearChanged() { }

	public void .ctor() { }

}

