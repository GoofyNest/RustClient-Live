public class UnderwearSkinPicker : MonoBehaviour // TypeDefIndex: 9248
{	// Fields
	public GameObjectRef pickerIcon; // 0x18
	public GameObject container; // 0x20
	public Action skinChangedEvent; // 0x28
	public Sprite defaultNudeIcon; // 0x30
	public Sprite defaultIconMale; // 0x38
	public Sprite defaultIconFemale; // 0x40

	// Methods

	// RVA: 0x9E6310 Offset: 0x9E5710 VA: 0x1809E6310
	public void RefreshUnderwear() { }

	// RVA: 0x9E6020 Offset: 0x9E5420 VA: 0x1809E6020
	protected void AddOption(string underwearShortName, string text, bool canUse, Sprite icon) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void OnUnderwearChanged() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

