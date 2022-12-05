public class IOEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6363
{
	public bool ShouldPool;
	private bool _disposed;
	public List<IOEntity.IOConnection> inputs;
	public List<IOEntity.IOConnection> outputs;
	public uint genericEntRef1;
	public uint genericEntRef2;
	public uint genericEntRef3;
	public int genericInt1;
	public int genericInt2;
	public float genericFloat1;
	public float genericFloat2;
	public int genericInt3;


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

public class IOEntity.IOConnection : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6364
{
	public bool ShouldPool;
	private bool _disposed;
	public string niceName;
	public int type;
	public uint connectedID;
	public int connectedToSlot;
	public bool inUse;
	public List<IOEntity.IOConnection.LineVec> linePointList;
	public int colour;


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

public class IOEntity.IOConnection.LineVec : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6365
{
	public bool ShouldPool;
	private bool _disposed;
	public Vector4 vec;


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

public class IOEntity.IOConnection.LinePointList : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6366
{
	public bool ShouldPool;
	private bool _disposed;
	public Vector4 a;
	public Vector4 b;
	public Vector4 c;
	public Vector4 d;
	public Vector4 e;
	public Vector4 f;
	public Vector4 g;
	public Vector4 h;


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

public class IOEntity : DecayEntity // TypeDefIndex: 10311
{
	[HeaderAttribute]
	public Transform debugOrigin;
	public ItemDefinition sourceItem;
	[ServerVar]
	[HelpAttribute]
	public static float framebudgetms;
	[ServerVar]
	public static float responsetime;
	[ServerVar]
	public static int backtracking;
	[ServerVar]
	public static bool debugBudget;
	[ServerVar]
	public static float debugBudgetThreshold;
	public const BaseEntity.Flags Flag_ShortCircuit = 32768;
	public const BaseEntity.Flags Flag_HasPower = 65536;
	public IOEntity.IOSlot[] inputs;
	public IOEntity.IOSlot[] outputs;
	public IOEntity.IOType ioType;
	public int client_powerin;
	public int client_slotpower;
	public bool client_extradata_dirty;

	public virtual bool IsGravitySource { get; }
	protected virtual float LiquidPassthroughGravityThreshold { get; }
	protected virtual bool DisregardGravityRestrictionsOnLiquid { get; }
	public virtual bool BlockIOInformationDisplay { get; }


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

	public virtual bool ShouldDrainBattery(IOEntity battery) { }

	public virtual int MaximalPowerOutput() { }

	public virtual bool AllowDrainFrom(int outputSlot) { }

	public virtual bool IsPowered() { }

	public bool IsConnectedToAnySlot(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	public bool IsConnectedTo(IOEntity entity, int slot, int depth, bool defaultReturn = False) { }

	public bool IsConnectedTo(IOEntity entity, int depth, bool defaultReturn = False) { }

	protected virtual bool ConsiderConnectedTo(IOEntity entity) { }

	public void RequestAdditionalData(int slot, bool input) { }

	[BaseEntity.RPC_Client]
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

	public virtual bool get_BlockIOInformationDisplay() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum IOEntity.IOType // TypeDefIndex: 10312
{
	public int value__;
	public const IOEntity.IOType Electric = 0;
	public const IOEntity.IOType Fluidic = 1;
	public const IOEntity.IOType Kinetic = 2;
	public const IOEntity.IOType Generic = 3;

}

public class IOEntity.IORef // TypeDefIndex: 10313
{
	public EntityRef entityRef;
	public IOEntity ioEnt;


	public void Init() { }

	public void InitClient() { }

	public IOEntity Get(bool isServer = True) { }

	public void Clear() { }

	public void Set(IOEntity newIOEnt) { }

	public void .ctor() { }

}

public class IOEntity.IOSlot // TypeDefIndex: 10314
{
	public string niceName;
	public IOEntity.IOType type;
	public IOEntity.IORef connectedTo;
	public int connectedToSlot;
	public Vector3[] linePoints;
	public float[] slackLevels;
	public ClientIOLine line;
	public Vector3 handlePosition;
	public bool rootConnectionsOnly;
	public bool mainPowerSlot;
	public WireTool.WireColour wireColour;


	public void OnDestroy() { }

	public void Clear() { }

	public void CleanupLines() { }

	public void UpdateLines(Transform transform) { }

	public float GetLength() { }

	public void .ctor() { }

}

