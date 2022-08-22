public class ConditionalModel : PrefabAttribute // TypeDefIndex: 9051
{	public GameObjectRef prefab; // 0x98
	public bool onClient; // 0xA0
	public bool onServer; // 0xA1
	public ModelConditionTest[] conditions; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <targetPrefabId>k__BackingField; // 0xB0

	public uint targetPrefabId { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_targetPrefabId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_targetPrefabId(uint value) { }

	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public bool RunTests(BaseEntity parent) { }

	public GameObject InstantiateSkin(BaseEntity parent) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

