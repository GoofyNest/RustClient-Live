public class TreeManager : BaseEntity // TypeDefIndex: 10366
{
	public static TreeManager client; 
	private static Dictionary<uint, ImpostorInstanceData> trees; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static Vector3 ProtoHalf3ToVec3(Half3 half3) { }

	public static Half3 Vec3ToProtoHalf3(Vector3 vec3) { }

	protected override void ClientInit(Entity info) { }

	public override void ClientOnEnable() { }

	public static void Reset() { }

	public static void AddBillboard(uint id, ImpostorInstanceData data) { }

	public static void RemoveBillboard(uint id) { }

	public static void HideBillboard(uint id) { }

	public static void ShowBillboard(uint id) { }

	private static ImpostorInstanceData CreateImpostorInstanceData(BaseEntity entity, Vector3 position, Vector3 scale) { }

	[BaseEntity.RPC_Client] 
	private void CLIENT_ReceiveTrees(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void CLIENT_TreeDestroyed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] 
	private void CLIENT_TreeSpawned(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

