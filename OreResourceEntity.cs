public class OreResourceEntity : StagedResourceEntity // TypeDefIndex: 10336
{
	public GameObjectRef bonusPrefab;
	public GameObjectRef finishEffect;
	public GameObjectRef bonusFailEffect;
	public OreHotSpot _hotSpot;
	public SoundPlayer bonusSound;


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client]
	public void PlayBonusLevelSound(BaseEntity.RPCMessage msg) { }

	public Vector3 RandomCircle(float distance = 1, bool allowInside = False) { }

	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset, bool allowInside = True, bool changeHeight = True) { }

	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	public static Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0, bool allowInside = False) { }

	public Vector3 ClampToCylinder(Vector3 localPos, Vector3 cylinderAxis, float cylinderDistance, float minHeight = 0, float maxHeight = 0) { }

	public void .ctor() { }

}

