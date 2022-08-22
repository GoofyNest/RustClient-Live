public class IOEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6354
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<IOEntity.IOConnection> inputs; // 0x18
	public List<IOEntity.IOConnection> outputs; // 0x20
	public uint genericEntRef1; // 0x28
	public uint genericEntRef2; // 0x2C
	public uint genericEntRef3; // 0x30
	public int genericInt1; // 0x34
	public int genericInt2; // 0x38
	public float genericFloat1; // 0x3C
	public float genericFloat2; // 0x40
	public int genericInt3; // 0x44


	public static void ResetToPool(IOEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(IOEntity instance) { }

	public IOEntity Copy() { }

	public static IOEntity Deserialize(Stream stream) { }

	public static IOEntity DeserializeLengthDelimited(Stream stream) { }

	public static IOEntity DeserializeLength(Stream stream, int length) { }

	public static IOEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, IOEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static IOEntity Deserialize(byte[] buffer, IOEntity instance, bool isDelta = False) { }

	public static IOEntity Deserialize(Stream stream, IOEntity instance, bool isDelta) { }

	public static IOEntity DeserializeLengthDelimited(Stream stream, IOEntity instance, bool isDelta) { }

	public static IOEntity DeserializeLength(Stream stream, int length, IOEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, IOEntity instance, IOEntity previous) { }

	public static void Serialize(Stream stream, IOEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(IOEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, IOEntity instance) { }

	public void .ctor() { }

}

public class IOEntity.IOConnection : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6355
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string niceName; // 0x18
	public int type; // 0x20
	public uint connectedID; // 0x24
	public int connectedToSlot; // 0x28
	public bool inUse; // 0x2C
	public List<IOEntity.IOConnection.LineVec> linePointList; // 0x30
	public int colour; // 0x38


	public static void ResetToPool(IOEntity.IOConnection instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(IOEntity.IOConnection instance) { }

	public IOEntity.IOConnection Copy() { }

	public static IOEntity.IOConnection Deserialize(Stream stream) { }

	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream) { }

	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length) { }

	public static IOEntity.IOConnection Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static IOEntity.IOConnection Deserialize(byte[] buffer, IOEntity.IOConnection instance, bool isDelta = False) { }

	public static IOEntity.IOConnection Deserialize(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	public static IOEntity.IOConnection DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection instance, bool isDelta) { }

	public static IOEntity.IOConnection DeserializeLength(Stream stream, int length, IOEntity.IOConnection instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, IOEntity.IOConnection instance, IOEntity.IOConnection previous) { }

	public static void Serialize(Stream stream, IOEntity.IOConnection instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(IOEntity.IOConnection instance) { }

	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection instance) { }

	public void .ctor() { }

}

public class IOEntity.IOConnection.LineVec : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6356
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 vec; // 0x14


	public static void ResetToPool(IOEntity.IOConnection.LineVec instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(IOEntity.IOConnection.LineVec instance) { }

	public IOEntity.IOConnection.LineVec Copy() { }

	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream) { }

	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream) { }

	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length) { }

	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LineVec previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static IOEntity.IOConnection.LineVec Deserialize(byte[] buffer, IOEntity.IOConnection.LineVec instance, bool isDelta = False) { }

	public static IOEntity.IOConnection.LineVec Deserialize(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	public static IOEntity.IOConnection.LineVec DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	public static IOEntity.IOConnection.LineVec DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LineVec instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LineVec instance, IOEntity.IOConnection.LineVec previous) { }

	public static void Serialize(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(IOEntity.IOConnection.LineVec instance) { }

	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LineVec instance) { }

	public void .ctor() { }

}

public class IOEntity.IOConnection.LinePointList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6357
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public Vector4 a; // 0x14
	public Vector4 b; // 0x24
	public Vector4 c; // 0x34
	public Vector4 d; // 0x44
	public Vector4 e; // 0x54
	public Vector4 f; // 0x64
	public Vector4 g; // 0x74
	public Vector4 h; // 0x84


	public static void ResetToPool(IOEntity.IOConnection.LinePointList instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(IOEntity.IOConnection.LinePointList instance) { }

	public IOEntity.IOConnection.LinePointList Copy() { }

	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream) { }

	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream) { }

	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length) { }

	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, IOEntity.IOConnection.LinePointList previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static IOEntity.IOConnection.LinePointList Deserialize(byte[] buffer, IOEntity.IOConnection.LinePointList instance, bool isDelta = False) { }

	public static IOEntity.IOConnection.LinePointList Deserialize(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	public static IOEntity.IOConnection.LinePointList DeserializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	public static IOEntity.IOConnection.LinePointList DeserializeLength(Stream stream, int length, IOEntity.IOConnection.LinePointList instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, IOEntity.IOConnection.LinePointList instance, IOEntity.IOConnection.LinePointList previous) { }

	public static void Serialize(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(IOEntity.IOConnection.LinePointList instance) { }

	public static void SerializeLengthDelimited(Stream stream, IOEntity.IOConnection.LinePointList instance) { }

	public void .ctor() { }

}

public class IOEntity : DecayEntity // TypeDefIndex: 8587
{	[HeaderAttribute] // RVA: 0xAE7D0 Offset: 0xADBD0 VA: 0x1800AE7D0
	public Transform debugOrigin; // 0x258
	public ItemDefinition sourceItem; // 0x260
	[ServerVar] // RVA: 0xAFC30 Offset: 0xAF030 VA: 0x1800AFC30
	[HelpAttribute] // RVA: 0xAFC30 Offset: 0xAF030 VA: 0x1800AFC30
	public static float framebudgetms; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float responsetime; // 0x4
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int backtracking; // 0x8
	public const BaseEntity.Flags Flag_ShortCircuit = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public IOEntity.IOSlot[] inputs; // 0x268
	public IOEntity.IOSlot[] outputs; // 0x270
	public IOEntity.IOType ioType; // 0x278
	public int client_powerin; // 0x27C
	public int client_slotpower; // 0x280
	public bool client_extradata_dirty; // 0x284

	public virtual bool IsGravitySource { get; }
	protected virtual float LiquidPassthroughGravityThreshold { get; }
	protected virtual bool DisregardGravityRestrictionsOnLiquid { get; }


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void ResetState() { }

	public string GetDisplayName() { }

	public virtual bool IsRootEntity() { }

	public virtual bool get_IsGravitySource() { }

	public IOEntity FindGravitySource(ref Vector3 worldHandlePosition, int depth, bool ignoreSelf) { }

	public virtual void SetFuelType(ItemDefinition def, IOEntity source) { }

	public virtual bool WantsPower() { }

	public virtual bool WantsPassthroughPower() { }

	public virtual int ConsumptionAmount() { }

	public virtual int MaximalPowerOutput() { }

	public virtual bool AllowDrainFrom(int outputSlot) { }

	public virtual bool IsPowered() { }

	public bool IsConnectedToAnySlot(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	public bool IsConnectedTo(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	public bool IsConnectedTo(IOEntity entity, int depth, bool defaultReturn = False) { }

	protected virtual bool ConsiderConnectedTo(IOEntity entity) { }

	public void RequestAdditionalData(int slot, bool input) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_ReceiveAdditionalData(BaseEntity.RPCMessage msg) { }

	public virtual void ProcessAdditionalData(int first, int second, float third, float fourth) { }

	protected virtual float get_LiquidPassthroughGravityThreshold() { }

	protected virtual bool get_DisregardGravityRestrictionsOnLiquid() { }

	public virtual bool AllowLiquidPassthrough(IOEntity fromSource, Vector3 sourceWorldPosition, bool forPlacement = False) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public int GetConnectedInputCount() { }

	public int GetConnectedOutputCount() { }

	public bool HasConnections() { }

	protected override void DoClientDestroy() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum IOEntity.IOType // TypeDefIndex: 8588
{	public int value__; // 0x0
	public const IOEntity.IOType Electric = 0;
	public const IOEntity.IOType Fluidic = 1;
	public const IOEntity.IOType Kinetic = 2;
	public const IOEntity.IOType Generic = 3;

}

public class IOEntity.IORef // TypeDefIndex: 8589
{	public EntityRef entityRef; // 0x10
	public IOEntity ioEnt; // 0x20


	public void Init() { }

	public void InitClient() { }

	public IOEntity Get(bool isServer = True) { }

	public void Clear() { }

	public void Set(IOEntity newIOEnt) { }

	public void .ctor() { }

}

public class IOEntity.IOSlot // TypeDefIndex: 8590
{	public string niceName; // 0x10
	public IOEntity.IOType type; // 0x18
	public IOEntity.IORef connectedTo; // 0x20
	public int connectedToSlot; // 0x28
	public Vector3[] linePoints; // 0x30
	public float[] slackLevels; // 0x38
	public ClientIOLine line; // 0x40
	public Vector3 handlePosition; // 0x48
	public bool rootConnectionsOnly; // 0x54
	public bool mainPowerSlot; // 0x55
	public WireTool.WireColour wireColour; // 0x58


	public void OnDestroy() { }

	public void Clear() { }

	public void CleanupLines() { }

	public void UpdateLines(Transform transform) { }

	public float GetLength() { }

	public void .ctor() { }

}

