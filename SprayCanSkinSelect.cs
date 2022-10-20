public class SprayCanSkinSelect : UIDialog // TypeDefIndex: 12641
{
	public IconSkinPicker skinPicker; 
	private Action<bool, int> onSkinSelected; 
	private ItemBlueprint cachedBlueprint; 
	private BaseEntity targetEntity; 


	private void Update() { }

	public void Setup(ItemBlueprint blueprint, SprayCan spray, BaseEntity ent, Action<bool, int> callback) { }

	private void SkinChangedEvent() { }

	public override void CloseDialog() { }

	public void .ctor() { }

}

