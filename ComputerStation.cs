public class ComputerStation : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6383
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string bookmarks; 


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

public class ComputerStation : BaseMountable // TypeDefIndex: 10282
{
	[HeaderAttribute] 
	public GameObjectRef menuPrefab; 
	public ComputerMenu computerMenu; 
	public EntityRef currentlyControllingEnt; 
	public Dictionary<string, uint> controlBookmarks; 
	public Transform leftHandIKPosition; 
	public Transform rightHandIKPosition; 
	public SoundDefinition turnOnSoundDef; 
	public SoundDefinition turnOffSoundDef; 
	public SoundDefinition onLoopSoundDef; 
	public bool isStatic; 
	public float autoGatherRadius; 
	private Sound onLoopSound; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public static bool IsValidIdentifier(string str) { }

	public override void DestroyShared() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override Quaternion GetMountedRotation() { }

	[BaseEntity.RPC_Client] 
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

