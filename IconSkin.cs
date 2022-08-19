public class IconSkin : MonoBehaviour, IItemIconChanged, IClientComponent // TypeDefIndex: 9191
{	// Fields
	public Image icon; // 0x18
	public Text text; // 0x20
	public Action<int> onChanged; // 0x28
	internal ItemDefinition item; // 0x30
	internal int skinId; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <searchString>k__BackingField; // 0x40

	// Properties
	public string searchString { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_searchString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	private void set_searchString(string value) { }

	// RVA: 0x808CA0 Offset: 0x8080A0 VA: 0x180808CA0
	protected void OnEnable() { }

	// RVA: 0x808BF0 Offset: 0x807FF0 VA: 0x180808BF0
	protected void OnDisable() { }

	// RVA: 0x808D30 Offset: 0x808130 VA: 0x180808D30 Slot: 4
	public void OnItemIconChanged() { }

	// RVA: 0x808FE0 Offset: 0x8083E0 VA: 0x180808FE0
	internal void Setup(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x808E20 Offset: 0x808220 VA: 0x180808E20
	public void Select() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

