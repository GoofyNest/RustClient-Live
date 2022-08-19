public class OreResourceEntity : StagedResourceEntity // TypeDefIndex: 8610
{	// Fields
	public GameObjectRef bonusPrefab; // 0x1A0
	public GameObjectRef finishEffect; // 0x1A8
	public GameObjectRef bonusFailEffect; // 0x1B0
	public OreHotSpot _hotSpot; // 0x1B8
	public SoundPlayer bonusSound; // 0x1C0

	// Methods

	// RVA: 0xA4B1B0 Offset: 0xA4A5B0 VA: 0x180A4B1B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA4B1A0 Offset: 0xA4A5A0 VA: 0x180A4B1A0 Slot: 14
	protected override void ClientInit(Entity info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA4B740 Offset: 0xA4AB40 VA: 0x180A4B740
	public void PlayBonusLevelSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA4B8C0 Offset: 0xA4ACC0 VA: 0x180A4B8C0
	public Vector3 RandomCircle(float distance = 1, bool allowInside = False) { }

	// RVA: 0xA4BAA0 Offset: 0xA4AEA0 VA: 0x180A4BAA0
	public Vector3 RandomHemisphereDirection(Vector3 input, float degreesOffset, bool allowInside = True, bool changeHeight = True) { }

	// RVA: 0xA4AF10 Offset: 0xA4A310 VA: 0x180A4AF10
	public Vector3 ClampToHemisphere(Vector3 hemiInput, float degreesOffset, Vector3 inputVec) { }

	// RVA: 0xA4B930 Offset: 0xA4AD30 VA: 0x180A4B930
	public static Vector3 RandomCylinderPointAroundVector(Vector3 input, float distance, float minHeight = 0, float maxHeight = 0, bool allowInside = False) { }

	// RVA: 0xA4AEA0 Offset: 0xA4A2A0 VA: 0x180A4AEA0
	public Vector3 ClampToCylinder(Vector3 localPos, Vector3 cylinderAxis, float cylinderDistance, float minHeight = 0, float maxHeight = 0) { }

	// RVA: 0xA4BC70 Offset: 0xA4B070 VA: 0x180A4BC70
	public void .ctor() { }

}

