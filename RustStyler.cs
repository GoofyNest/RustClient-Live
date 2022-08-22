public class RustStyler : MonoBehaviour // TypeDefIndex: 7032
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected StyleAsset _styles; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected StyleGroup _group; // 0x20
	public Graphic[] Foreground; // 0x28
	public Graphic[] Background; // 0x30
	public Graphic[] Icon; // 0x38

	public StyleAsset Styles { get; set; }
	public StyleGroup Group { get; set; }


	public StyleAsset get_Styles() { }

	public void set_Styles(StyleAsset value) { }

	public StyleGroup get_Group() { }

	public void set_Group(StyleGroup value) { }

	private void ApplyStyles() { }

	private StyleAsset.Group GetStyleGroup() { }

	public void .ctor() { }

}

