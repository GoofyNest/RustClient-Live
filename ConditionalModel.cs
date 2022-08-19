public class ConditionalModel : PrefabAttribute // TypeDefIndex: 9051
{	// Fields
	public GameObjectRef prefab; // 0x98
	public bool onClient; // 0xA0
	public bool onServer; // 0xA1
	public ModelConditionTest[] conditions; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <targetPrefabId>k__BackingField; // 0xB0

	// Properties
	public uint targetPrefabId { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95B0 Offset: 0x2F89B0 VA: 0x1802F95B0
	public uint get_targetPrefabId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95C0 Offset: 0x2F89C0 VA: 0x1802F95C0
	private void set_targetPrefabId(uint value) { }

	// RVA: 0x2F9200 Offset: 0x2F8600 VA: 0x1802F9200 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2F9490 Offset: 0x2F8890 VA: 0x1802F9490
	public bool RunTests(BaseEntity parent) { }

	// RVA: 0x2F9320 Offset: 0x2F8720 VA: 0x1802F9320
	public GameObject InstantiateSkin(BaseEntity parent) { }

	// RVA: 0x2F92C0 Offset: 0x2F86C0 VA: 0x1802F92C0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x2F9550 Offset: 0x2F8950 VA: 0x1802F9550
	public void .ctor() { }

}

