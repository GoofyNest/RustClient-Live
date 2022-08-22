public class VisualStorageContainer : LootContainer // TypeDefIndex: 9614
{	public VisualStorageContainerNode[] displayNodes; // 0x418
	public VisualStorageContainer.DisplayModel[] displayModels; // 0x420
	public Transform nodeParent; // 0x428
	public GameObject defaultDisplayModel; // 0x430


	public void ClearRigidBodies() { }

	public void SetItemsVisible(bool vis) { }

	public void ItemUpdateComplete() { }

	public void UpdateVisibleItems(ItemContainer msg) { }

	public void .ctor() { }

}

public class VisualStorageContainer.DisplayModel // TypeDefIndex: 9615
{	public GameObject displayModel; // 0x10
	public ItemDefinition def; // 0x18
	public int slot; // 0x20


	public void .ctor() { }

}

