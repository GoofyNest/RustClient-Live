public class StagedResourceEntity : ResourceEntity // TypeDefIndex: 8650
{	// Fields
	public List<StagedResourceEntity.ResourceStage> stages; // 0x180
	public int stage; // 0x188
	public GameObjectRef changeStageEffect; // 0x190
	public GameObject gibSourceTest; // 0x198

	// Methods

	// RVA: 0xA85E70 Offset: 0xA85270 VA: 0x180A85E70 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA85DD0 Offset: 0xA851D0 VA: 0x180A85DD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xA86340 Offset: 0xA85740 VA: 0x180A86340
	public void RunChangeEffect() { }

	// RVA: 0xA85DB0 Offset: 0xA851B0 VA: 0x180A85DB0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA862F0 Offset: 0xA856F0 VA: 0x180A862F0
	private void ResourceUpdate(BaseEntity.RPCMessage packet) { }

	// RVA: -1 Offset: -1
	public T GetStageComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5ED560 Offset: 0x5EC960 VA: 0x1805ED560
	|-StagedResourceEntity.GetStageComponent<object>
	|-StagedResourceEntity.GetStageComponent<MeshRenderer>
	*/

	// RVA: 0xA86470 Offset: 0xA85870 VA: 0x180A86470
	private void UpdateStage() { }

	// RVA: 0xA86660 Offset: 0xA85A60 VA: 0x180A86660
	public void .ctor() { }

}

public class StagedResourceEntity.ResourceStage // TypeDefIndex: 8651
{	// Fields
	public float health; // 0x10
	public GameObject instance; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

