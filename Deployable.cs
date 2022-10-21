public class Deployable : PrefabAttribute // TypeDefIndex: 11573
{
	public Mesh guideMesh; 
	public Vector3 guideMeshScale; 
	public bool guideLights; 
	public bool wantsInstanceData; 
	public bool copyInventoryFromItem; 
	public bool setSocketParent; 
	public bool toSlot; 
	public BaseEntity.Slot slot; 
	public GameObjectRef placeEffect; 
	public Bounds bounds; 


	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

