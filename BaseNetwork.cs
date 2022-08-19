public class BaseNetworkable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6292
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint uid; // 0x14
	public uint group; // 0x18
	public uint prefabID; // 0x1C

	// Methods

	// RVA: 0x1FFC080 Offset: 0x1FFB480 VA: 0x181FFC080
	public static void ResetToPool(BaseNetworkable instance) { }

	// RVA: 0x1FFC110 Offset: 0x1FFB510 VA: 0x181FFC110
	public void ResetToPool() { }

	// RVA: 0x1FFBDA0 Offset: 0x1FFB1A0 VA: 0x181FFBDA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E231E0 Offset: 0x1E225E0 VA: 0x181E231E0
	public void CopyTo(BaseNetworkable instance) { }

	// RVA: 0x1FFAE70 Offset: 0x1FFA270 VA: 0x181FFAE70
	public BaseNetworkable Copy() { }

	// RVA: 0x1FFB780 Offset: 0x1FFAB80 VA: 0x181FFB780
	public static BaseNetworkable Deserialize(Stream stream) { }

	// RVA: 0x1FFAEF0 Offset: 0x1FFA2F0 VA: 0x181FFAEF0
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FFB450 Offset: 0x1FFA850 VA: 0x181FFB450
	public static BaseNetworkable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FFB4E0 Offset: 0x1FFA8E0 VA: 0x181FFB4E0
	public static BaseNetworkable Deserialize(byte[] buffer) { }

	// RVA: 0x1FFBEB0 Offset: 0x1FFB2B0 VA: 0x181FFBEB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FFC650 Offset: 0x1FFBA50 VA: 0x181FFC650 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FFC670 Offset: 0x1FFBA70 VA: 0x181FFC670 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, BaseNetworkable previous) { }

	// RVA: 0x1FFC060 Offset: 0x1FFB460 VA: 0x181FFC060 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FFBB20 Offset: 0x1FFAF20 VA: 0x181FFBB20
	public static BaseNetworkable Deserialize(byte[] buffer, BaseNetworkable instance, bool isDelta = False) { }

	// RVA: 0x1FFB970 Offset: 0x1FFAD70 VA: 0x181FFB970
	public static BaseNetworkable Deserialize(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x1FFAF70 Offset: 0x1FFA370 VA: 0x181FFAF70
	public static BaseNetworkable DeserializeLengthDelimited(Stream stream, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x1FFB1F0 Offset: 0x1FFA5F0 VA: 0x181FFB1F0
	public static BaseNetworkable DeserializeLength(Stream stream, int length, BaseNetworkable instance, bool isDelta) { }

	// RVA: 0x1FFC1A0 Offset: 0x1FFB5A0 VA: 0x181FFC1A0
	public static void SerializeDelta(Stream stream, BaseNetworkable instance, BaseNetworkable previous) { }

	// RVA: 0x1FFC520 Offset: 0x1FFB920 VA: 0x181FFC520
	public static void Serialize(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x1FFC640 Offset: 0x1FFBA40 VA: 0x181FFC640
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FFC650 Offset: 0x1FFBA50 VA: 0x181FFC650
	public void ToProto(Stream stream) { }

	// RVA: 0x1FFC410 Offset: 0x1FFB810 VA: 0x181FFC410
	public static byte[] SerializeToBytes(BaseNetworkable instance) { }

	// RVA: 0x1FFC360 Offset: 0x1FFB760 VA: 0x181FFC360
	public static void SerializeLengthDelimited(Stream stream, BaseNetworkable instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public abstract class BaseNetwork // TypeDefIndex: 6679
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NetRead <read>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private NetWrite <write>k__BackingField; // 0x18
	public INetworkCryptocraphy cryptography; // 0x20

	// Properties
	public NetRead read { get; set; }
	public NetWrite write { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public NetRead get_read() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	private void set_read(NetRead value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public NetWrite get_write() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_write(NetWrite value) { }

	// RVA: 0x2207730 Offset: 0x2206B30 VA: 0x182207730
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 4
	public virtual void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x2207680 Offset: 0x2206A80 VA: 0x182207680
	protected Message StartMessage(Message.Type type, Connection connection) { }

	// RVA: 0x22072F0 Offset: 0x22066F0 VA: 0x1822072F0
	public void Decrypt(Connection connection, NetRead read) { }

	// RVA: 0x2207510 Offset: 0x2206910 VA: 0x182207510
	public void Encrypt(Connection connection, ref MemoryStream stream) { }

	// RVA: 0x2207660 Offset: 0x2206A60 VA: 0x182207660
	public void Record(Connection connection, Stream stream) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public virtual string GetDebug(Connection connection) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

}

public enum BaseNetwork.StatTypeLong // TypeDefIndex: 6680
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	protected bool JustCreated { get; set; }
	public GameManager gameManager { get; }
	public PrefabAttribute.Library prefabAttribute { get; }
	public bool IsDestroyed { get; set; }
	public string PrefabName { get; }
	public string ShortPrefabName { get; }
	public bool isServer { get; }
	public bool isClient { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	protected bool get_JustCreated() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x95B2F0 Offset: 0x95A6F0 VA: 0x18095B2F0
	protected void set_JustCreated(bool value) { }

	// RVA: 0xA2C400 Offset: 0xA2B800 VA: 0x180A2C400
	public void ClientSpawn(Entity info) { }

	// RVA: 0xA2C380 Offset: 0xA2B780 VA: 0x180A2C380 Slot: 13
	public virtual void ClientOnEnable() { }

	// RVA: 0xA2C190 Offset: 0xA2B590 VA: 0x180A2C190 Slot: 14
	protected virtual void ClientInit(Entity info) { }

	// RVA: 0xA2D6B0 Offset: 0xA2CAB0 VA: 0x180A2D6B0
	public void OnNetworkUpdate(Entity entity) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	public virtual void PreNetworkUpdate() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 16
	public virtual void PostNetworkUpdate() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 17
	public virtual bool ShouldDestroyWithGroup() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 18
	public virtual bool ShouldDestroyImmediately() { }

	// RVA: 0xA2D240 Offset: 0xA2C640 VA: 0x180A2D240
	public void NetworkDestroy(bool immediately) { }

	// RVA: 0xA2C7D0 Offset: 0xA2BBD0 VA: 0x180A2C7D0 Slot: 19
	protected virtual void DoClientDestroy() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 20
	internal virtual void DoNetworkDestroy() { }

	// RVA: 0xA2BF70 Offset: 0xA2B370 VA: 0x180A2BF70
	public void BroadcastOnPostNetworkUpdate(BaseEntity entity) { }

	// RVA: 0xA2D830 Offset: 0xA2CC30 VA: 0x180A2D830 Slot: 21
	public virtual void PostProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA2CB70 Offset: 0xA2BF70 VA: 0x180A2CB70
	public BaseEntity GetParentEntity() { }

	// RVA: 0xA2CB80 Offset: 0xA2BF80 VA: 0x180A2CB80
	public bool HasParent() { }

	// RVA: 0xA2BEE0 Offset: 0xA2B2E0 VA: 0x180A2BEE0
	public void AddChild(BaseEntity child) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 22
	protected virtual void OnChildAdded(BaseEntity child) { }

	// RVA: 0xA2D8B0 Offset: 0xA2CCB0 VA: 0x180A2D8B0
	public void RemoveChild(BaseEntity child) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 23
	protected virtual void OnChildRemoved(BaseEntity child) { }

	// RVA: 0xA2DCF0 Offset: 0xA2D0F0 VA: 0x180A2DCF0
	public GameManager get_gameManager() { }

	// RVA: 0xA2DD50 Offset: 0xA2D150 VA: 0x180A2DD50
	public PrefabAttribute.Library get_prefabAttribute() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2DBD0 Offset: 0xA2CFD0 VA: 0x180A2DBD0 Slot: 7
	public bool get_IsDestroyed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x70AFB0 Offset: 0x70A3B0 VA: 0x18070AFB0
	private void set_IsDestroyed(bool value) { }

	// RVA: 0xA2DBE0 Offset: 0xA2CFE0 VA: 0x180A2DBE0
	public string get_PrefabName() { }

	// RVA: 0xA2DC60 Offset: 0xA2D060 VA: 0x180A2DC60
	public string get_ShortPrefabName() { }

	// RVA: 0x82BB00 Offset: 0x82AF00 VA: 0x18082BB00 Slot: 24
	public virtual Vector3 GetNetworkPosition() { }

	// RVA: 0xA2CB30 Offset: 0xA2BF30 VA: 0x180A2CB30 Slot: 25
	public virtual Quaternion GetNetworkRotation() { }

	// RVA: 0xA2CB90 Offset: 0xA2BF90 VA: 0x180A2CB90
	public string InvokeString() { }

	// RVA: 0xA2D1A0 Offset: 0xA2C5A0 VA: 0x180A2D1A0
	public BaseEntity LookupPrefab() { }

	// RVA: 0xA2CAE0 Offset: 0xA2BEE0 VA: 0x180A2CAE0 Slot: 26
	public bool EqualNetID(BaseNetworkable other) { }

	// RVA: 0xA2CB10 Offset: 0xA2BF10 VA: 0x180A2CB10
	public bool EqualNetID(uint otherID) { }

	// RVA: 0xA2D920 Offset: 0xA2CD20 VA: 0x180A2D920 Slot: 27
	public virtual void ResetState() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 28
	public virtual void InitShared() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 29
	public virtual void PreInitShared() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 30
	public virtual void PostInitShared() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 31
	public virtual void DestroyShared() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 32
	public virtual void OnNetworkGroupEnter(Group group) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 33
	public virtual void OnNetworkGroupLeave(Group group) { }

	// RVA: 0xA2D570 Offset: 0xA2C970 VA: 0x180A2D570 Slot: 10
	public void OnNetworkGroupChange() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public void OnNetworkSubscribersEnter(List<Connection> connections) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public void OnNetworkSubscribersLeave(List<Connection> connections) { }

	// RVA: 0xA2C9F0 Offset: 0xA2BDF0 VA: 0x180A2C9F0
	private void EntityDestroy() { }

	// RVA: 0xA2C890 Offset: 0xA2BC90 VA: 0x180A2C890
	private void DoEntityDestroy() { }

	// RVA: 0xA2D970 Offset: 0xA2CD70 VA: 0x180A2D970
	private void SpawnShared() { }

	// RVA: 0xA2CDE0 Offset: 0xA2C1E0 VA: 0x180A2CDE0 Slot: 34
	public virtual void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	public bool get_isServer() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0
	public bool get_isClient() { }

	// RVA: -1 Offset: -1
	public T ToClient<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4950 Offset: 0x5E3D50 VA: 0x1805E4950
	|-BaseNetworkable.ToClient<BaseEntity>
	|-BaseNetworkable.ToClient<object>
	*/

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 35
	public virtual bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA2DB30 Offset: 0xA2CF30 VA: 0x180A2DB30
	protected void .ctor() { }

	// RVA: 0xA2DA80 Offset: 0xA2CE80 VA: 0x180A2DA80
	private static void .cctor() { }

}

public struct BaseNetworkable.SaveInfo // TypeDefIndex: 9475
{	// Fields
	public Entity msg; // 0x0
	public bool forDisk; // 0x8
	public Connection forConnection; // 0x10

	// Methods

	// RVA: 0xFB7D0 Offset: 0xFABD0 VA: 0x1800FB7D0
	internal bool SendingTo(Connection ownerConnection) { }

}

public struct BaseNetworkable.LoadInfo // TypeDefIndex: 9476
{	// Fields
	public Entity msg; // 0x0
	public bool fromDisk; // 0x8

}

public class BaseNetworkable.EntityRealmClient : BaseNetworkable.EntityRealm // TypeDefIndex: 9477
{	// Properties
	protected override Manager visibilityManager { get; }

	// Methods

	// RVA: 0xA325E0 Offset: 0xA319E0 VA: 0x180A325E0 Slot: 6
	protected override Manager get_visibilityManager() { }

	// RVA: 0xA32570 Offset: 0xA31970 VA: 0x180A32570
	public void .ctor() { }

}

public abstract class BaseNetworkable.EntityRealm : IEnumerable<BaseNetworkable>, IEnumerable // TypeDefIndex: 9478
{	// Fields
	private ListDictionary<uint, BaseNetworkable> entityList; // 0x10

	// Properties
	public int Count { get; }
	protected abstract Manager visibilityManager { get; }

	// Methods

	// RVA: 0xA32BE0 Offset: 0xA31FE0 VA: 0x180A32BE0
	public int get_Count() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract Manager get_visibilityManager();

	// RVA: 0xA326B0 Offset: 0xA31AB0 VA: 0x180A326B0
	public bool Contains(uint uid) { }

	// RVA: 0xA32980 Offset: 0xA31D80 VA: 0x180A32980
	public BaseNetworkable Find(uint uid) { }

	// RVA: 0xA32A70 Offset: 0xA31E70 VA: 0x180A32A70
	public void RegisterID(BaseNetworkable ent) { }

	// RVA: 0xA32B70 Offset: 0xA31F70 VA: 0x180A32B70
	public void UnregisterID(BaseNetworkable ent) { }

	// RVA: 0xA32710 Offset: 0xA31B10 VA: 0x180A32710
	public Group FindGroup(uint uid) { }

	// RVA: 0xA32B30 Offset: 0xA31F30 VA: 0x180A32B30
	public Group TryFindGroup(uint uid) { }

	// RVA: 0xA32750 Offset: 0xA31B50 VA: 0x180A32750
	public void FindInGroup(uint uid, List<BaseNetworkable> list) { }

	// RVA: 0xA32A00 Offset: 0xA31E00 VA: 0x180A32A00 Slot: 4
	public IEnumerator<BaseNetworkable> GetEnumerator() { }

	// RVA: 0xA32A00 Offset: 0xA31E00 VA: 0x180A32A00 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xA32660 Offset: 0xA31A60 VA: 0x180A32660
	public void Clear() { }

	// RVA: 0xA32570 Offset: 0xA31970 VA: 0x180A32570
	protected void .ctor() { }

}

public enum BaseNetworkable.DestroyMode // TypeDefIndex: 9479
{	// Fields
	public byte value__; // 0x0
	public const BaseNetworkable.DestroyMode None = 0;
	public const BaseNetworkable.DestroyMode Gib = 1;

}

public static class BaseNetworkableEx // TypeDefIndex: 9480
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE60 Offset: 0xA2B260 VA: 0x180A2BE60
	public static bool IsValid(BaseNetworkable ent) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE50 Offset: 0xA2B250 VA: 0x180A2BE50
	public static bool IsRealNull(BaseNetworkable ent) { }

}

