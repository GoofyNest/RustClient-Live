public class RustStyler : MonoBehaviour // TypeDefIndex: 7032
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected StyleAsset _styles; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected StyleGroup _group; // 0x20
	public Graphic[] Foreground; // 0x28
	public Graphic[] Background; // 0x30
	public Graphic[] Icon; // 0x38

	// Properties
	public StyleAsset Styles { get; set; }
	public StyleGroup Group { get; set; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public StyleAsset get_Styles() { }

	// RVA: 0xFCA930 Offset: 0xFC9D30 VA: 0x180FCA930
	public void set_Styles(StyleAsset value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public StyleGroup get_Group() { }

	// RVA: 0xFCA920 Offset: 0xFC9D20 VA: 0x180FCA920
	public void set_Group(StyleGroup value) { }

	// RVA: 0xFCA560 Offset: 0xFC9960 VA: 0x180FCA560
	private void ApplyStyles() { }

	// RVA: 0xFCA840 Offset: 0xFC9C40 VA: 0x180FCA840
	private StyleAsset.Group GetStyleGroup() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

