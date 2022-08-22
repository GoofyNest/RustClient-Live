public class OreResourceEntity : StagedResourceEntity // TypeDefIndex: 8610
{	public GameObjectRef bonusPrefab; // 0x1A0
	public GameObjectRef finishEffect; // 0x1A8
	public GameObjectRef bonusFailEffect; // 0x1B0
	public OreHotSpot _hotSpot; // 0x1B8
	public SoundPlayer bonusSound; // 0x1C0


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void PlayBonusLevelSound(BaseEntity.RPCMessage msg) { }

	public Vector3 RandomCircle(float distance = 1, bool allowInside = False) { }

	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset, bool allowInside = True, bool changeHeight = True) { }

	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	public static Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0, bool allowInside = False) { }

	public Vector3 ClampToCylinder(Vector3 localPos, Vector3 cylinderAxis, float cylinderDistance, float minHeight = 0, float maxHeight = 0) { }

	public void .ctor() { }

}

