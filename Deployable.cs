public class Deployable : PrefabAttribute // TypeDefIndex: 9850
{	// Fields
	public Mesh guideMesh; // 0x98
	public Vector3 guideMeshScale; // 0xA0
	public bool guideLights; // 0xAC
	public bool wantsInstanceData; // 0xAD
	public bool copyInventoryFromItem; // 0xAE
	public bool setSocketParent; // 0xAF
	public bool toSlot; // 0xB0
	public BaseEntity.Slot slot; // 0xB4
	public GameObjectRef placeEffect; // 0xB8
	public Bounds bounds; // 0xC0

	// Methods

	// RVA: 0x9B7700 Offset: 0x9B6B00 VA: 0x1809B7700 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x9B77C0 Offset: 0x9B6BC0 VA: 0x1809B77C0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9B7820 Offset: 0x9B6C20 VA: 0x1809B7820
	public void .ctor() { }

}

