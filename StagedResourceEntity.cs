public class StagedResourceEntity : ResourceEntity // TypeDefIndex: 8650
{
	public List<StagedResourceEntity.ResourceStage> stages; 
	public int stage; 
	public GameObjectRef changeStageEffect; 
	public GameObject gibSourceTest; 


public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

public override void Load(BaseNetworkable.LoadInfo info) { }

public void RunChangeEffect() { }

protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] 
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
{
	public float health; 
	public GameObject instance; 


public void .ctor() { }

}

