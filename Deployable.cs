public class Deployable : PrefabAttribute // TypeDefIndex: 9850
{	public Mesh guideMesh; // 0x98
	public Vector3 guideMeshScale; // 0xA0
	public bool guideLights; // 0xAC
	public bool wantsInstanceData; // 0xAD
	public bool copyInventoryFromItem; // 0xAE
	public bool setSocketParent; // 0xAF
	public bool toSlot; // 0xB0
	public BaseEntity.Slot slot; // 0xB4
	public GameObjectRef placeEffect; // 0xB8
	public Bounds bounds; // 0xC0


	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

