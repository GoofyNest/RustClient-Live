public class ReclaimBackpack : StorageContainer // TypeDefIndex: 8741
{	// Fields
	public int reclaimID; // 0x3D0
	public ulong playerSteamID; // 0x3D8
	public bool onlyOwnerLoot; // 0x3E0
	public Collider myCollider; // 0x3E8
	public GameObject art; // 0x3F0

	// Methods

	// RVA: 0x6ABA70 Offset: 0x6AAE70 VA: 0x1806ABA70 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x6AB890 Offset: 0x6AAC90 VA: 0x1806AB890
	private bool BelongsToLocalPlayer() { }

	// RVA: 0x6ABAE0 Offset: 0x6AAEE0 VA: 0x1806ABAE0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	// RVA: 0x6ABA10 Offset: 0x6AAE10 VA: 0x1806ABA10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x6ABB10 Offset: 0x6AAF10 VA: 0x1806ABB10
	public void .ctor() { }

}

