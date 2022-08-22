public class ReclaimBackpack : StorageContainer // TypeDefIndex: 8741
{	public int reclaimID; // 0x3D0
	public ulong playerSteamID; // 0x3D8
	public bool onlyOwnerLoot; // 0x3E0
	public Collider myCollider; // 0x3E8
	public GameObject art; // 0x3F0


	public override void Load(BaseNetworkable.LoadInfo info) { }

	private bool BelongsToLocalPlayer() { }

	public override bool ShouldShowLootMenus() { }

	protected override void ClientInit(Entity info) { }

	public void .ctor() { }

}

