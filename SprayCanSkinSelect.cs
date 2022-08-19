public class SprayCanSkinSelect : UIDialog // TypeDefIndex: 10910
{	// Fields
	public IconSkinPicker skinPicker; // 0x30
	private Action<bool, int> onSkinSelected; // 0x38
	private ItemBlueprint cachedBlueprint; // 0x40
	private BaseEntity targetEntity; // 0x48

	// Methods

	// RVA: 0xA7CED0 Offset: 0xA7C2D0 VA: 0x180A7CED0
	private void Update() { }

	// RVA: 0xA7CD50 Offset: 0xA7C150 VA: 0x180A7CD50
	public void Setup(ItemBlueprint blueprint, SprayCan spray, BaseEntity ent, Action<bool, int> callback) { }

	// RVA: 0xA7CE30 Offset: 0xA7C230 VA: 0x180A7CE30
	private void SkinChangedEvent() { }

	// RVA: 0xA7CD20 Offset: 0xA7C120 VA: 0x180A7CD20 Slot: 9
	public override void CloseDialog() { }

	// RVA: 0x4BE840 Offset: 0x4BDC40 VA: 0x1804BE840
	public void .ctor() { }

}

