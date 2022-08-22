public class SprayCanSkinSelect : UIDialog // TypeDefIndex: 10910
{	public IconSkinPicker skinPicker; // 0x30
	private Action<bool, int> onSkinSelected; // 0x38
	private ItemBlueprint cachedBlueprint; // 0x40
	private BaseEntity targetEntity; // 0x48


	private void Update() { }

	public void Setup(ItemBlueprint blueprint, SprayCan spray, BaseEntity ent, Action<bool, int> callback) { }

	private void SkinChangedEvent() { }

	public override void CloseDialog() { }

	public void .ctor() { }

}

