public class VisualStorageContainer : LootContainer // TypeDefIndex: 11366
{
	public VisualStorageContainerNode[] displayNodes;
	public VisualStorageContainer.DisplayModel[] displayModels;
	public Transform nodeParent;
	public GameObject defaultDisplayModel;


	public void ClearRigidBodies() { }

	public void SetItemsVisible(bool vis) { }

	public void ItemUpdateComplete() { }

	public void UpdateVisibleItems(ItemContainer msg) { }

	public void .ctor() { }

}

public class VisualStorageContainer.DisplayModel // TypeDefIndex: 11367
{
	public GameObject displayModel;
	public ItemDefinition def;
	public int slot;


	public void .ctor() { }

}

