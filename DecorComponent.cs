public abstract class DecorComponent : PrefabAttribute // TypeDefIndex: 12089
{
	internal bool isRoot;


	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	protected override Type GetIndexedType() { }

	protected void .ctor() { }

}

