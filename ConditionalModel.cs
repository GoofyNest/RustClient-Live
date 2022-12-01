public class ConditionalModel : PrefabAttribute // TypeDefIndex: 10782
{
	public GameObjectRef prefab;
	public bool onClient;
	public bool onServer;
	public ModelConditionTest[] conditions;
	[CompilerGeneratedAttribute]
	private uint <targetPrefabId>k__BackingField;

	public uint targetPrefabId { get; set; }


	[CompilerGeneratedAttribute]
	public uint get_targetPrefabId() { }

	[CompilerGeneratedAttribute]
	private void set_targetPrefabId(uint value) { }

	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public bool RunTests(BaseEntity parent) { }

	public GameObject InstantiateSkin(BaseEntity parent) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

