public class BaseNetworkable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{
	public bool ShouldPool;
	private bool _disposed;
	public uint uid;
	public uint group;
	public uint prefabID;


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

public abstract class BaseNetwork // TypeDefIndex: 6855
{
	[CompilerGeneratedAttribute]
	private NetRead <read>k__BackingField;
	[CompilerGeneratedAttribute]
	private NetWrite <write>k__BackingField;
	public INetworkCryptocraphy cryptography;

	public NetRead read { get; set; }
	public NetWrite write { get; set; }


	[CompilerGeneratedAttribute]
	public NetRead get_read() { }

	[CompilerGeneratedAttribute]
	private void set_read(NetRead value) { }

	[CompilerGeneratedAttribute]
	public NetWrite get_write() { }

	[CompilerGeneratedAttribute]
	private void set_write(NetWrite value) { }

	public void .ctor() { }

	public virtual void Send(SendInfo sendinfo, MemoryStream data) { }

	protected Message StartMessage(Message.Type type, Connection connection) { }

	public void Decrypt(Connection connection, NetRead read) { }

	public ArraySegment<byte> Encrypt(Connection connection, MemoryStream stream) { }

	public void Record(Connection connection, Stream stream) { }

	public virtual string GetDebug(Connection connection) { }

	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

public enum BaseNetwork.StatTypeLong // TypeDefIndex: 6856
{
	public int value__;
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

public abstract class BaseNetworkable : BaseMonoBehaviour, IPrefabPostProcess, IEntity, NetworkHandler // TypeDefIndex: 11216
{
	[CompilerGeneratedAttribute]
	private bool <JustCreated>k__BackingField;
	private DeferredAction entityDestroy;
	public List<Component> postNetworkUpdateComponents;
	public EntityRef parentEntity;
	public readonly List<BaseEntity> children;
	public bool canTriggerParent;
	[HeaderAttribute]
	[ReadOnlyAttribute]
	public uint prefabID;
	[TooltipAttribute]
	public bool globalBroadcast;
	public Networkable net;
	[CompilerGeneratedAttribute]
	private bool <IsDestroyed>k__BackingField;
	private string _prefabName;
	private string _prefabNameWithoutExtension;
	public static BaseNetworkable.EntityRealm clientEntities;
	private const bool isServersideEntity = False;

	protected bool JustCreated { get; set; }
	public GameManager gameManager { get; }
	public PrefabAttribute.Library prefabAttribute { get; }
	public bool IsDestroyed { get; set; }
	public string PrefabName { get; }
	public string ShortPrefabName { get; }
	public bool isServer { get; }
	public bool isClient { get; }


	[CompilerGeneratedAttribute]
	protected bool get_JustCreated() { }

	[CompilerGeneratedAttribute]
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

	[CompilerGeneratedAttribute]
	public bool get_IsDestroyed() { }

	[CompilerGeneratedAttribute]
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
	|-BaseNetworkable.ToClient<BaseEntity>
	|-BaseNetworkable.ToClient<object>
	*/

	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public struct BaseNetworkable.SaveInfo // TypeDefIndex: 11217
{
	public Entity msg;
	public bool forDisk;
	public Connection forConnection;


	internal bool SendingTo(Connection ownerConnection) { }

}

public struct BaseNetworkable.LoadInfo // TypeDefIndex: 11218
{
	public Entity msg;
	public bool fromDisk;

}

public class BaseNetworkable.EntityRealmClient : BaseNetworkable.EntityRealm // TypeDefIndex: 11219
{
	protected override Manager visibilityManager { get; }


	protected override Manager get_visibilityManager() { }

	public void .ctor() { }

}

public abstract class BaseNetworkable.EntityRealm : IEnumerable<BaseNetworkable>, IEnumerable // TypeDefIndex: 11220
{
	private ListDictionary<uint, BaseNetworkable> entityList;

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

public enum BaseNetworkable.DestroyMode // TypeDefIndex: 11221
{
	public byte value__;
	public const BaseNetworkable.DestroyMode None = 0;
	public const BaseNetworkable.DestroyMode Gib = 1;

}

public static class BaseNetworkableEx // TypeDefIndex: 11222
{

	[ExtensionAttribute]
	public static bool IsValid(BaseNetworkable ent) { }

	[ExtensionAttribute]
	public static bool IsRealNull(BaseNetworkable ent) { }

}

