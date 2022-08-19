public abstract class DecorComponent : PrefabAttribute // TypeDefIndex: 10320
{	// Fields
	internal bool isRoot; // 0x98

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	// RVA: 0x8E7E90 Offset: 0x8E7290 VA: 0x1808E7E90 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x8E7F50 Offset: 0x8E7350 VA: 0x1808E7F50 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x8E7FB0 Offset: 0x8E73B0 VA: 0x1808E7FB0
	protected void .ctor() { }

}

