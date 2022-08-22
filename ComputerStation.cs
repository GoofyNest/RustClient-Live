public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6376
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string bookmarks; // 0x18


	public static void ResetToPool(ComputerStation instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ComputerStation instance) { }

	public ComputerStation Copy() { }

	public static ComputerStation Deserialize(Stream stream) { }

	public static ComputerStation DeserializeLengthDelimited(Stream stream) { }

	public static ComputerStation DeserializeLength(Stream stream, int length) { }

	public static ComputerStation Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ComputerStation previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ComputerStation Deserialize(byte[] buffer, ComputerStation instance, bool isDelta = False) { }

	public static ComputerStation Deserialize(Stream stream, ComputerStation instance, bool isDelta) { }

	public static ComputerStation DeserializeLengthDelimited(Stream stream, ComputerStation instance, bool isDelta) { }

	public static ComputerStation DeserializeLength(Stream stream, int length, ComputerStation instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ComputerStation instance, ComputerStation previous) { }

	public static void Serialize(Stream stream, ComputerStation instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ComputerStation instance) { }

	public static void SerializeLengthDelimited(Stream stream, ComputerStation instance) { }

	public void .ctor() { }

}

public class ComputerStation : BaseMountable // TypeDefIndex: 8562
{	[HeaderAttribute] // RVA: 0xAA970 Offset: 0xA9D70 VA: 0x1800AA970
	public GameObjectRef menuPrefab; // 0x320
	public ComputerMenu computerMenu; // 0x328
	public EntityRef currentlyControllingEnt; // 0x330
	public Dictionary<string, uint> controlBookmarks; // 0x340
	public Transform leftHandIKPosition; // 0x348
	public Transform rightHandIKPosition; // 0x350
	public SoundDefinition turnOnSoundDef; // 0x358
	public SoundDefinition turnOffSoundDef; // 0x360
	public SoundDefinition onLoopSoundDef; // 0x368
	public bool isStatic; // 0x370
	public float autoGatherRadius; // 0x374
	private Sound onLoopSound; // 0x378


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static bool IsValidIdentifier(string str) { }

	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override Quaternion GetMountedRotation() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void ReceiveBookmarks(BaseEntity.RPCMessage msg) { }

	public override void PlayerDismounted(BasePlayer player, bool wasSwap) { }

	public override BasePlayer.CameraMode GetMountedCameraMode() { }

	public void MenuShutdown() { }

	public override void PlayerMounted(BasePlayer player, bool wasSwap) { }

	public override Quaternion GetMountedBodyAngles() { }

	public override Vector3 EyePositionForPlayer(BasePlayer player, Quaternion lookRot) { }

	public override bool ModifiesThirdPersonCamera() { }

	public override Transform GetEyeOverride() { }

	public override Vector2 GetPitchClamp() { }

	public override Vector2 GetYawClamp() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void .ctor() { }

}

