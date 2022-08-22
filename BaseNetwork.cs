public class BaseNetworkable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6292
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint group; // 0x18
	public uint prefabID; // 0x1C


	public static void ResetToPool(BaseNetworkable instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(BaseNetworkable instance) { }

	public BaseNetworkable Copy() { }

	public static BaseNetworkable Deserialize(Stream stream) { }

	public static BaseNetworkable DeserializeLengthDelimited(Stream stream) { }

	public static BaseNetworkable DeserializeLength(Stream stream, int length) { }

	public static BaseNetworkable Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, BaseNetworkable previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static BaseNetworkable Deserialize(byte[] buffer, BaseNetworkable instance, bool isDelta = False) { }

	public static BaseNetworkable Deserialize(Stream stream, BaseNetworkable instance, bool isDelta) { }

	public static BaseNetworkable DeserializeLengthDelimited(Stream stream, BaseNetworkable instance, bool isDelta) { }

	public static BaseNetworkable DeserializeLength(Stream stream, int length, BaseNetworkable instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, BaseNetworkable instance, BaseNetworkable previous) { }

	public static void Serialize(Stream stream, BaseNetworkable instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(BaseNetworkable instance) { }

	public static void SerializeLengthDelimited(Stream stream, BaseNetworkable instance) { }

	public void .ctor() { }

}

public abstract class BaseNetwork // TypeDefIndex: 6679
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NetRead <read>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NetWrite <write>k__BackingField; // 0x18
	public INetworkCryptocraphy cryptography; // 0x20

	public NetRead read { get; set; }
	public NetWrite write { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public NetRead get_read() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_read(NetRead value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public NetWrite get_write() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_write(NetWrite value) { }

	public void .ctor() { }

	public virtual void Send(SendInfo sendinfo, MemoryStream data) { }

	protected Message StartMessage(Message.Type type, Connection connection) { }

	public void Decrypt(Connection connection, NetRead read) { }

	public void Encrypt(Connection connection, ref MemoryStream stream) { }

	public void Record(Connection connection, Stream stream) { }

	public virtual string GetDebug(Connection connection) { }

	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

public enum BaseNetwork.StatTypeLong // TypeDefIndex: 6680
{	public int value__; // 0x0
	public const BaseNetwork.StatTypeLong BytesSent = 0;
	public const BaseNetwork.StatTypeLong BytesSent_LastSecond = 1;
	public const BaseNetwork.StatTypeLong BytesReceived = 2;
	public const BaseNetwork.StatTypeLong BytesReceived_LastSecond = 3;
	public const BaseNetwork.StatTypeLong MessagesInSendBuffer = 4;
	public const BaseNetwork.StatTypeLong BytesInSendBuffer = 5;
	public const BaseNetwork.StatTypeLong MessagesInResendBuffer = 6;
	public const BaseNetwork.StatTypeLong BytesInResendBuffer = 7;
	public const BaseNetwork.StatTypeLong PacketLossAverage = 8;
	public const BaseNetwork.StatTypeLong PacketLossLastSecond = 9;
	public const BaseNetwork.StatTypeLong ThrottleBytes = 10;

}

public abstract class BaseNetworkable : BaseMonoBehaviour, IPrefabPostProcess, IEntity, NetworkHandler // TypeDefIndex: 9474
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <JustCreated>k__BackingField; // 0x18
	private DeferredAction entityDestroy; // 0x20
	public List<Component> postNetworkUpdateComponents; // 0x28
	public EntityRef parentEntity; // 0x30
	public readonly List<BaseEntity> children; // 0x40
	public bool canTriggerParent; // 0x48
	[HeaderAttribute] // RVA: 0x72150 Offset: 0x71550 VA: 0x180072150
	[ReadOnlyAttribute] // RVA: 0x72150 Offset: 0x71550 VA: 0x180072150
	public uint prefabID; // 0x4C
	[TooltipAttribute] // RVA: 0x72320 Offset: 0x71720 VA: 0x180072320
	public bool globalBroadcast; // 0x50
	public Networkable net; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsDestroyed>k__BackingField; // 0x60
	private string _prefabName; // 0x68
	private string _prefabNameWithoutExtension; // 0x70
	public static BaseNetworkable.EntityRealm clientEntities; // 0x0
	private const bool isServersideEntity = False;

	protected bool JustCreated { get; set; }
	public GameManager gameManager { get; }
	public PrefabAttribute.Library prefabAttribute { get; }
	public bool IsDestroyed { get; set; }
	public string PrefabName { get; }
	public string ShortPrefabName { get; }
	public bool isServer { get; }
	public bool isClient { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected bool get_JustCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected void set_JustCreated(bool value) { }

	public void ClientSpawn(Entity info) { }

	public virtual void ClientOnEnable() { }

	protected virtual void ClientInit(Entity info) { }

	public void OnNetworkUpdate(Entity entity) { }

	public virtual void PreNetworkUpdate() { }

	public virtual void PostNetworkUpdate() { }

	public virtual bool ShouldDestroyWithGroup() { }

	public virtual bool ShouldDestroyImmediately() { }

	public void NetworkDestroy(bool immediately) { }

	protected virtual void DoClientDestroy() { }

	internal virtual void DoNetworkDestroy() { }

	public void BroadcastOnPostNetworkUpdate(BaseEntity entity) { }

	public virtual void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public BaseEntity GetParentEntity() { }

	public bool HasParent() { }

	public void AddChild(BaseEntity child) { }

	protected virtual void OnChildAdded(BaseEntity child) { }

	public void RemoveChild(BaseEntity child) { }

	protected virtual void OnChildRemoved(BaseEntity child) { }

	public GameManager get_gameManager() { }

	public PrefabAttribute.Library get_prefabAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsDestroyed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsDestroyed(bool value) { }

	public string get_PrefabName() { }

	public string get_ShortPrefabName() { }

	public virtual Vector3 GetNetworkPosition() { }

	public virtual Quaternion GetNetworkRotation() { }

	public string InvokeString() { }

	public BaseEntity LookupPrefab() { }

	public bool EqualNetID(BaseNetworkable other) { }

	public bool EqualNetID(uint otherID) { }

	public virtual void ResetState() { }

	public virtual void InitShared() { }

	public virtual void PreInitShared() { }

	public virtual void PostInitShared() { }

	public virtual void DestroyShared() { }

	public virtual void OnNetworkGroupEnter(Group group) { }

	public virtual void OnNetworkGroupLeave(Group group) { }

	public void OnNetworkGroupChange() { }

	public void OnNetworkSubscribersEnter(List<Connection> connections) { }

	public void OnNetworkSubscribersLeave(List<Connection> connections) { }

	private void EntityDestroy() { }

	private void DoEntityDestroy() { }

	private void SpawnShared() { }

	public virtual void Load(BaseNetworkable.LoadInfo info) { }

	public bool get_isServer() { }

	public bool get_isClient() { }

	public T ToClient<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4950 Offset: 0x5E3D50 VA: 0x1805E4950
	|-BaseNetworkable.ToClient<BaseEntity>
	|-BaseNetworkable.ToClient<object>
	*/

	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public struct BaseNetworkable.SaveInfo // TypeDefIndex: 9475
{	public Entity msg; // 0x0
	public bool forDisk; // 0x8
	public Connection forConnection; // 0x10


	internal bool SendingTo(Connection ownerConnection) { }

}

public struct BaseNetworkable.LoadInfo // TypeDefIndex: 9476
{	public Entity msg; // 0x0
	public bool fromDisk; // 0x8

}

public class BaseNetworkable.EntityRealmClient : BaseNetworkable.EntityRealm // TypeDefIndex: 9477
{	protected override Manager visibilityManager { get; }


	protected override Manager get_visibilityManager() { }

	public void .ctor() { }

}

public abstract class BaseNetworkable.EntityRealm : IEnumerable<BaseNetworkable>, IEnumerable // TypeDefIndex: 9478
{	private ListDictionary<uint, BaseNetworkable> entityList; // 0x10

	public int Count { get; }
	protected abstract Manager visibilityManager { get; }


	public int get_Count() { }

	protected abstract Manager get_visibilityManager();

	public bool Contains(uint uid) { }

	public BaseNetworkable Find(uint uid) { }

	public void RegisterID(BaseNetworkable ent) { }

	public void UnregisterID(BaseNetworkable ent) { }

	public Group FindGroup(uint uid) { }

	public Group TryFindGroup(uint uid) { }

	public void FindInGroup(uint uid, List<BaseNetworkable> list) { }

	public IEnumerator<BaseNetworkable> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public void Clear() { }

	protected void .ctor() { }

}

public enum BaseNetworkable.DestroyMode // TypeDefIndex: 9479
{	public byte value__; // 0x0
	public const BaseNetworkable.DestroyMode None = 0;
	public const BaseNetworkable.DestroyMode Gib = 1;

}

public static class BaseNetworkableEx // TypeDefIndex: 9480
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool IsValid(BaseNetworkable ent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static bool IsRealNull(BaseNetworkable ent) { }

}

