public class VisualStorageContainer : LootContainer // TypeDefIndex: 9614
{	// Fields
	public VisualStorageContainerNode[] displayNodes; // 0x418
	public VisualStorageContainer.DisplayModel[] displayModels; // 0x420
	public Transform nodeParent; // 0x428
	public GameObject defaultDisplayModel; // 0x430

	// Methods

	// RVA: 0x7DD930 Offset: 0x7DCD30 VA: 0x1807DD930
	public void ClearRigidBodies() { }

	// RVA: 0x7DDAE0 Offset: 0x7DCEE0 VA: 0x1807DDAE0
	public void SetItemsVisible(bool vis) { }

	// RVA: 0x7DDA00 Offset: 0x7DCE00 VA: 0x1807DDA00
	public void ItemUpdateComplete() { }

	// RVA: 0x7DDD00 Offset: 0x7DD100 VA: 0x1807DDD00
	public void UpdateVisibleItems(ItemContainer msg) { }

	// RVA: 0x6F1B40 Offset: 0x6F0F40 VA: 0x1806F1B40
	public void .ctor() { }

}

public class VisualStorageContainer.DisplayModel // TypeDefIndex: 9615
{	// Fields
	public GameObject displayModel; // 0x10
	public ItemDefinition def; // 0x18
	public int slot; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

