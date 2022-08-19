public class TreeManager : BaseEntity // TypeDefIndex: 8658
{	// Fields
	public static TreeManager client; // 0x0
	private static Dictionary<uint, ImpostorInstanceData> trees; // 0x8

	// Methods

	// RVA: 0x9FC1A0 Offset: 0x9FB5A0 VA: 0x1809FC1A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9FCD80 Offset: 0x9FC180 VA: 0x1809FCD80
	public static Vector3 ProtoHalf3ToVec3(Half3 half3) { }

	// RVA: 0x9FD070 Offset: 0x9FC470 VA: 0x1809FD070
	public static Half3 Vec3ToProtoHalf3(Vector3 vec3) { }

	// RVA: 0x9FBE00 Offset: 0x9FB200 VA: 0x1809FBE00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9FBE80 Offset: 0x9FB280 VA: 0x1809FBE80 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x9FCF40 Offset: 0x9FC340 VA: 0x1809FCF40
	public static void Reset() { }

	// RVA: 0x9FB420 Offset: 0x9FA820 VA: 0x1809FB420
	public static void AddBillboard(uint id, ImpostorInstanceData data) { }

	// RVA: 0x9FCE30 Offset: 0x9FC230 VA: 0x1809FCE30
	public static void RemoveBillboard(uint id) { }

	// RVA: 0x9FC0E0 Offset: 0x9FB4E0 VA: 0x1809FC0E0
	public static void HideBillboard(uint id) { }

	// RVA: 0x9FCFB0 Offset: 0x9FC3B0 VA: 0x1809FCFB0
	public static void ShowBillboard(uint id) { }

	// RVA: 0x9FBED0 Offset: 0x9FB2D0 VA: 0x1809FBED0
	private static ImpostorInstanceData CreateImpostorInstanceData(BaseEntity entity, Vector3 position, Vector3 scale) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9FB580 Offset: 0x9FA980 VA: 0x1809FB580
	private void CLIENT_ReceiveTrees(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9FB950 Offset: 0x9FAD50 VA: 0x1809FB950
	private void CLIENT_TreeDestroyed(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9FBAD0 Offset: 0x9FAED0 VA: 0x1809FBAD0
	private void CLIENT_TreeSpawned(BaseEntity.RPCMessage msg) { }

	// RVA: 0x9FD190 Offset: 0x9FC590 VA: 0x1809FD190
	public void .ctor() { }

	// RVA: 0x9FD120 Offset: 0x9FC520 VA: 0x1809FD120
	private static void .cctor() { }

}

