public class StagedResourceEntity : ResourceEntity // TypeDefIndex: 8650
{	public List<StagedResourceEntity.ResourceStage> stages; // 0x180
	public int stage; // 0x188
	public GameObjectRef changeStageEffect; // 0x190
	public GameObject gibSourceTest; // 0x198


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void RunChangeEffect() { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void ResourceUpdate(BaseEntity.RPCMessage packet) { }

	public T GetStageComponent<T>() { }
	/* GenericInstMethod :
	|
	|-StagedResourceEntity.GetStageComponent<object>
	|-StagedResourceEntity.GetStageComponent<MeshRenderer>
	*/

	private void UpdateStage() { }

	public void .ctor() { }

}

public class StagedResourceEntity.ResourceStage // TypeDefIndex: 8651
{	public float health; // 0x10
	public GameObject instance; // 0x18


	public void .ctor() { }

}

