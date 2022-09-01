internal abstract class ServerIdentity : Identity // TypeDefIndex: 1145
{
	protected Type _objectType; 
	protected MarshalByRefObject _serverObject; 
	protected IMessageSink _serverSink; 
	protected Context _context; 
	protected Lease _lease; 

	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }


	public void .ctor(string objectUri, Context context, Type objectType) { }

	public Type get_ObjectType() { }

	public void StartTrackingLifetime(ILease lease) { }

	public virtual void OnLifetimeExpired() { }

	public override ObjRef CreateObjRef(Type requestedType) { }

	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	public Lease get_Lease() { }

	public Context get_Context() { }

	public void set_Context(Context value) { }

	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	protected void DisposeServerObject() { }

}

internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 1259
{

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	public void .ctor() { }

}

internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 1260
{
	private IMessageSink _nextSink; 


	public void .ctor(IMessageSink nextSink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1261
{
	private IMessageSink _replySink; 
	private ServerIdentity _identity; 


	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal sealed class ServerCertValidationCallbackWrapper : MulticastDelegate // TypeDefIndex: 2542
{

	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

}

internal class ServerCertValidationCallback // TypeDefIndex: 2985
{
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; 
	private readonly ExecutionContext m_Context; 


	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	internal void Callback(object state) { }

	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 2986
{
	internal readonly object request; 
	internal readonly X509Certificate certificate; 
	internal readonly X509Chain chain; 
	internal readonly SslPolicyErrors sslPolicyErrors; 
	internal bool result; 


	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

public struct ServerInfo : IEquatable<ServerInfo> // TypeDefIndex: 5558
{
	[CompilerGeneratedAttribute] 
	private string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Ping>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <GameDir>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Map>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Description>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <AppId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Players>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <MaxPlayers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <BotPlayers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Passworded>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Secure>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <LastTimePlayed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Version>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <TagString>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <SteamId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <AddressRaw>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IPAddress <Address>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ConnectionPort>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <QueryPort>k__BackingField; 
	private string[] _tags; 

	public string Name { get; set; }
	public int Ping { get; set; }
	public string GameDir { set; }
	public string Map { get; set; }
	public string Description { set; }
	public uint AppId { get; set; }
	public int Players { get; set; }
	public int MaxPlayers { get; set; }
	public int BotPlayers { set; }
	public bool Passworded { set; }
	public bool Secure { get; set; }
	public uint LastTimePlayed { get; set; }
	public int Version { set; }
	public string TagString { get; set; }
	public ulong SteamId { get; set; }
	public uint AddressRaw { get; set; }
	public IPAddress Address { get; set; }
	public int ConnectionPort { get; set; }
	public int QueryPort { get; set; }


	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	public void set_Name(string value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public int get_Ping() { }

	[CompilerGeneratedAttribute] 
	public void set_Ping(int value) { }

	[CompilerGeneratedAttribute] 
	public void set_GameDir(string value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public string get_Map() { }

	[CompilerGeneratedAttribute] 
	public void set_Map(string value) { }

	[CompilerGeneratedAttribute] 
	public void set_Description(string value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] 
	public void set_AppId(uint value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public int get_Players() { }

	[CompilerGeneratedAttribute] 
	public void set_Players(int value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] 
	public void set_MaxPlayers(int value) { }

	[CompilerGeneratedAttribute] 
	public void set_BotPlayers(int value) { }

	[CompilerGeneratedAttribute] 
	public void set_Passworded(bool value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public bool get_Secure() { }

	[CompilerGeneratedAttribute] 
	public void set_Secure(bool value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] 
	public void set_LastTimePlayed(uint value) { }

	[CompilerGeneratedAttribute] 
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public string get_TagString() { }

	[CompilerGeneratedAttribute] 
	public void set_TagString(string value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] 
	public void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] 
	public void set_AddressRaw(uint value) { }

	[IsReadOnlyAttribute] 
	[CompilerGeneratedAttribute] 
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] 
	public void set_Address(IPAddress value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] 
	public void set_ConnectionPort(int value) { }

	[CompilerGeneratedAttribute] 
	[IsReadOnlyAttribute] 
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] 
	public void set_QueryPort(int value) { }

	internal static ServerInfo From(gameserveritem_t item) { }

	public void .ctor(uint ip, ushort cport, ushort qport, uint timeplayed) { }

	public void AddToHistory() { }

	[AsyncStateMachineAttribute] 
	public Task<Dictionary<string, string>> QueryRulesAsync() { }

	public void RemoveFromHistory() { }

	public void AddToFavourites() { }

	public void RemoveFromFavourites() { }

	public bool Equals(ServerInfo other) { }

	public override int GetHashCode() { }

}

private struct ServerInfo.<QueryRulesAsync>d__85 : IAsyncStateMachine // TypeDefIndex: 5559
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; 
	public ServerInfo <>4__this; 
	private TaskAwaiter<Dictionary<string, string>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public enum ServerQuerySet // TypeDefIndex: 5696
{
	public int value__; 
	public const ServerQuerySet Whitelist = 0;
	public const ServerQuerySet Internet = 1;
	public const ServerQuerySet LocalNetwork = 2;
	public const ServerQuerySet Friends = 3;
	public const ServerQuerySet Favorites = 4;
	public const ServerQuerySet History = 5;

}

public struct ServerInfo // TypeDefIndex: 5702
{
	[CompilerGeneratedAttribute] 
	private readonly uint <AppId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <Name>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly IPAddress <Address>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly uint <AddressRaw>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <ConnectionPort>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <QueryPort>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <Map>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <TagString>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly bool <IsSecure>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <Players>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <MaxPlayers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly uint <LastTimePlayed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly int <Ping>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly ulong <SteamId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly uint <Born>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly IReadOnlyList<string> <Tags>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <ConnectionProtocol>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <ConnectionString>k__BackingField; 

	public uint AppId { get; }
	public string Name { get; }
	public IPAddress Address { get; }
	public uint AddressRaw { get; }
	public int ConnectionPort { get; }
	public int QueryPort { get; }
	public string Map { get; }
	public string TagString { get; }
	public bool IsSecure { get; }
	public int Players { get; }
	public int MaxPlayers { get; }
	public uint LastTimePlayed { get; }
	public int Ping { get; }
	public ulong SteamId { get; }
	public uint Born { get; }
	public IReadOnlyList<string> Tags { get; }
	public string ConnectionProtocol { get; }
	public string ConnectionString { get; }


	[CompilerGeneratedAttribute] 
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] 
	public string get_Name() { }

	[CompilerGeneratedAttribute] 
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] 
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] 
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] 
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] 
	public string get_Map() { }

	[CompilerGeneratedAttribute] 
	public string get_TagString() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] 
	public int get_Players() { }

	[CompilerGeneratedAttribute] 
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] 
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] 
	public int get_Ping() { }

	[CompilerGeneratedAttribute] 
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] 
	public uint get_Born() { }

	[CompilerGeneratedAttribute] 
	public IReadOnlyList<string> get_Tags() { }

	[CompilerGeneratedAttribute] 
	public string get_ConnectionProtocol() { }

	[CompilerGeneratedAttribute] 
	public string get_ConnectionString() { }

	public void .ctor(uint appId, string name, IPAddress address, int connectionPort, int queryPort, string map, string tagString, bool isSecure, int players, int maxPlayers, uint lastTimePlayed, int ping, ulong steamId, int authedPlayers = 2147483647) { }

	private static uint AddressToUInt32(IPAddress address) { }

	private static uint Swap(uint x) { }

}

private sealed class ServerInfo.<>c // TypeDefIndex: 5703
{
	public static readonly ServerInfo.<>c <>9; 
	public static Func<string, bool> <>9__54_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <.ctor>b__54_0(string x) { }

}

public struct ServerParameters // TypeDefIndex: 5704
{
	[CompilerGeneratedAttribute] 
	private readonly string <ShortName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <FullName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly string <Version>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly bool <IsSecure>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly bool <HideIP>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly IPAddress <Address>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly ushort <GamePort>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly ushort <QueryPort>k__BackingField; 

	public string ShortName { get; }
	public string FullName { get; }
	public string Version { get; }
	public bool IsSecure { get; }
	public bool HideIP { get; }
	public IPAddress Address { get; }
	public ushort GamePort { get; }
	public ushort QueryPort { get; }


	[CompilerGeneratedAttribute] 
	public string get_ShortName() { }

	[CompilerGeneratedAttribute] 
	public string get_FullName() { }

	[CompilerGeneratedAttribute] 
	public string get_Version() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] 
	public bool get_HideIP() { }

	[CompilerGeneratedAttribute] 
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] 
	public ushort get_GamePort() { }

	[CompilerGeneratedAttribute] 
	public ushort get_QueryPort() { }

	public void .ctor(string shortName, string fullName, string version, bool isSecure, bool hideIP, IPAddress address, ushort gamePort, ushort queryPort = 0) { }

}

public static class ServerInfoExtensions // TypeDefIndex: 6158
{

	[AsyncStateMachineAttribute] 
	[ExtensionAttribute] 
	public static Task<Dictionary<string, string>> QueryRulesAsync(ServerInfo server) { }

}

private struct ServerInfoExtensions.<QueryRulesAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 6159
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; 
	public ServerInfo server; 
	private TaskAwaiter<Dictionary<string, string>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class ServerListMetadata // TypeDefIndex: 6212
{
	[CompilerGeneratedAttribute] 
	private static DateTimeOffset <LastDownloaded>k__BackingField; 

	public static DateTimeOffset LastDownloaded { get; set; }


	[CompilerGeneratedAttribute] 
	public static DateTimeOffset get_LastDownloaded() { }

	[CompilerGeneratedAttribute] 
	private static void set_LastDownloaded(DateTimeOffset value) { }

	public static void Refresh(bool force = False) { }

	private static void UpdateMetadata() { }

	private static void LoadMetadata(string json) { }

	private static void OnUpdated(Dictionary<IPEndPoint, int> metadata) { }

	[CompilerGeneratedAttribute] 
	internal static bool <LoadMetadata>g__TryParseIPEndPoint|6_0(string value, out IPEndPoint endPoint) { }

}

private sealed class ServerListMetadata.<>c // TypeDefIndex: 6213
{
	public static readonly ServerListMetadata.<>c <>9; 
	public static Action<string> <>9__5_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <UpdateMetadata>b__5_0(string str) { }

}

public class ServerGib : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6331
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string gibName; 


	public static void ResetToPool(ServerGib instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ServerGib instance) { }

	public ServerGib Copy() { }

	public static ServerGib Deserialize(Stream stream) { }

	public static ServerGib DeserializeLengthDelimited(Stream stream) { }

	public static ServerGib DeserializeLength(Stream stream, int length) { }

	public static ServerGib Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ServerGib previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ServerGib Deserialize(byte[] buffer, ServerGib instance, bool isDelta = False) { }

	public static ServerGib Deserialize(Stream stream, ServerGib instance, bool isDelta) { }

	public static ServerGib DeserializeLengthDelimited(Stream stream, ServerGib instance, bool isDelta) { }

	public static ServerGib DeserializeLength(Stream stream, int length, ServerGib instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ServerGib instance, ServerGib previous) { }

	public static void Serialize(Stream stream, ServerGib instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ServerGib instance) { }

	public static void SerializeLengthDelimited(Stream stream, ServerGib instance) { }

	public void .ctor() { }

}

public abstract class Server : BaseNetwork // TypeDefIndex: 6704
{
	public static ulong MaxPacketsPerSecond; 
	public static int MaxPacketSize; 
	public static int MaxConnectionsPerIP; 
	public static float MaxReceiveTime; 
	public string ip; 
	public int port; 
	public bool compressionEnabled; 
	public bool logging; 
	public Manager visibility; 
	public IServerCallback callbackHandler; 
	public bool debug; 
	internal uint lastValueGiven; 
	public List<Connection> connections; 
	private Dictionary<ulong, Connection> connectionByGUID; 
	private Dictionary<string, List<Connection>> connectionsByIP; 

	public virtual string ProtocolId { get; }
	public virtual bool AllowPassthroughMessages { get; }


	public abstract bool IsConnected();

	public virtual string get_ProtocolId() { }

	public virtual bool get_AllowPassthroughMessages() { }

	public void Reset() { }

	public virtual bool Start() { }

	public virtual void Stop(string shutdownMsg) { }

	public virtual void Cycle() { }

	public abstract void Disconnect(Connection cn);

	public abstract void Kick(Connection cn, string message, bool logfile = False);

	public uint TakeUID() { }

	public void ReturnUID(uint uid) { }

	public void RegisterUID(uint uid) { }

	internal void ResetUIDs() { }

	public Networkable CreateNetworkable() { }

	public Networkable CreateNetworkable(uint uid) { }

	public void DestroyNetworkable(ref Networkable networkable) { }

	protected void OnDisconnected(string strReason, Connection cn) { }

	protected Connection FindConnection(ulong guid) { }

	protected virtual void OnNewConnection() { }

	private string IPAddressWithoutPort(string address) { }

	protected virtual void OnNewConnection(Connection connection) { }

	protected void RemoveConnection(Connection connection) { }

	public virtual int GetAveragePing(Connection connection) { }

	public virtual void SendUnconnected(uint netAddr, ushort netPort, byte[] steamResponseBuffer, int packetSize) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public class ServerVar : ConsoleVar // TypeDefIndex: 6892
{

	public void .ctor() { }

}

public class ServerUserVar : ConsoleVar // TypeDefIndex: 6893
{

	public void .ctor() { }

}

public class ServerAllVar : ConsoleVar // TypeDefIndex: 6894
{

	public void .ctor() { }

}

public class Server : Server // TypeDefIndex: 7334
{
	private Peer peer; 

	public override string ProtocolId { get; }
	public override bool AllowPassthroughMessages { get; }


	public override string get_ProtocolId() { }

	public override bool get_AllowPassthroughMessages() { }

	public override bool IsConnected() { }

	public override bool Start() { }

	public override void Stop(string shutdownMsg) { }

	public override void Disconnect(Connection cn) { }

	public override void Kick(Connection cn, string message, bool logfile) { }

	internal bool HandleRaknetPacket(byte type, Connection connection) { }

	internal void UnconnectedPacket() { }

	internal void ConnectedPacket(Connection connection) { }

	public override void Cycle() { }

	protected override void OnNewConnection() { }

	public override string GetDebug(Connection connection) { }

	public override int GetAveragePing(Connection connection) { }

	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	public void .ctor() { }

}

public class ServerConsole : SingletonComponent<ServerConsole> // TypeDefIndex: 9293
{

	public void .ctor() { }

}

public class ServerGib : BaseCombatEntity // TypeDefIndex: 9609
{
	public GameObject _gibSource; 
	public string _gibName; 
	public PhysicMaterial physicsMaterial; 
	private MeshCollider meshCollider; 
	private MeshFilter meshFilter; 
	private MeshRenderer meshRenderer; 
	private bool initialized; 


	public MeshCollider GetCollider() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientSetGib(string newgibname) { }

	protected override void ClientInit(Entity info) { }

	public void VisualsInit(Mesh mesh, Material[] materials) { }

	public virtual void PhysicsInit(Mesh physicsMesh) { }

	public void .ctor() { }

}

public class ServerProjectile : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 9686
{
	public Vector3 initialVelocity; 
	public float drag; 
	public float gravityModifier; 
	public float speed; 
	public float scanRange; 
	public Vector3 swimScale; 
	public Vector3 swimSpeed; 
	public float radius; 

	public virtual bool HasRangeLimit { get; }


	public virtual bool get_HasRangeLimit() { }

	public float GetMaxRange(float maxFuseTime) { }

	public void .ctor() { }

}

public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10722
{

public class ServerMgr : SingletonComponent<ServerMgr>
	public const string BYPASS_PROCEDURAL_SPAWN_PREF = "bypassProceduralSpawn";


	public void .ctor() { }

}

public class ServerPerformance : BaseMonoBehaviour // TypeDefIndex: 10723
{
	public static ulong deaths; 
	public static ulong spawns; 
	public static ulong position_changes; 


	public void .ctor() { }

	private static void .cctor() { }

}

public class ServerBrowser : MonoBehaviour // TypeDefIndex: 11174
{
	public string orderBy; 
	private string searchText; 
	private bool showFull; 
	private bool showEmpty; 
	private HashSet<string> searchTags; 
	private HashSet<string> excludeTags; 


	private void OnEnable() { }

	private void OnDisable() { }

	private void OnOpenStateChanged() { }

	public void RefreshAll() { }

	private void ClearAll() { }

	public void SetOrder(string strBy) { }

	public void SetShowFull(bool showFull) { }

	public void SetShowEmpty(bool showFull) { }

	public void SetSearchFilter(string txt) { }

	public void SetTagsFilter(ServerBrowserTagFilters tagFilters) { }

	public void .ctor() { }

}

public class ServerBrowserCategory : MonoBehaviour // TypeDefIndex: 11175
{
	public LocalizeText serverCountText; 
	public ServerBrowserList browserList; 
	public bool isDirty; 


	public void OnEnable() { }

	public void Update() { }

	public void Dirty() { }

	public void UpdateCounts() { }

	public void .ctor() { }

}

private sealed class ServerBrowserCategory.<>c // TypeDefIndex: 11176
{
	public static readonly ServerBrowserCategory.<>c <>9; 
	public static Func<ServerInfo, int> <>9__6_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <UpdateCounts>b__6_0(ServerInfo x) { }

}

public class ServerBrowserInfo : SingletonComponent<ServerBrowserInfo> // TypeDefIndex: 11177
{
	public bool isMain; 
	public Text serverName; 
	public Text serverMeta; 
	public Text serverText; 
	public Button viewWebpage; 
	public Button refresh; 
	public Nullable<ServerInfo> currentServer; 
	public HttpImage headerImage; 
	public HttpImage logoImage; 
	private string weburl; 
	private Texture loadedTexture; 
	private string descriptionText; 


	public override void SingletonSetup() { }

	public void Open(ServerInfo server) { }

	public void Close() { }

	public void JoinServer() { }

	public void JoinDelayed() { }

	public static void Join(ServerInfo server) { }

	public void Refresh() { }

	[AsyncStateMachineAttribute] 
	private void QueryRules() { }

	private void EnableRefreshButton() { }

	public void VisitWebpage() { }

	public void .ctor() { }

}

private struct ServerBrowserInfo.<QueryRules>d__19 : IAsyncStateMachine // TypeDefIndex: 11178
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public ServerBrowserInfo <>4__this; 
	private bool <loadedImage>5__2; 
	private bool <loadedLogo>5__3; 
	private TaskAwaiter<Dictionary<string, string>> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ServerBrowserItem : MonoBehaviour // TypeDefIndex: 11179
{
	public TextMeshProUGUI serverName; 
	public RustText mapName; 
	public TextMeshProUGUI playerCount; 
	public TextMeshProUGUI ping; 
	public Toggle favourited; 
	public ServerBrowserTagList serverTagList; 
	private static RealTimeSince timeSinceGotFriendServers; 
	private static Dictionary<string, string> friendsOnServers; 
	private static RealTimeSince timeSinceGotFavouriteServers; 
	private static HashSet<string> favorites; 
	private ServerInfo serverInfo; 
	internal bool preventFavouriteToggle; 


	private static string GetFriendOnServer(IPAddress addr, int port) { }

	private static bool GetIsFavourite(IPAddress addr, int port) { }

	internal void Init(ServerInfo s, bool isFavourites, bool isHistory) { }

	public void OnClicked() { }

	public void OnFavouriteToggle(bool favourite) { }

	public void .ctor() { }

}

private sealed class ServerBrowserItem.<>c // TypeDefIndex: 11180
{
	public static readonly ServerBrowserItem.<>c <>9; 
	public static Func<IPlayerInfo, bool> <>9__8_0; 
	public static Func<IPlayerInfo, bool> <>9__8_1; 
	public static Func<IPlayerInfo, bool> <>9__8_2; 
	public static Func<IPlayerInfo, string> <>9__8_3; 
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_4; 
	public static Func<IPlayerInfo, string> <>9__8_6; 
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_5; 
	public static Func<ServerInfo, string> <>9__11_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <GetFriendOnServer>b__8_0(IPlayerInfo x) { }

	internal bool <GetFriendOnServer>b__8_1(IPlayerInfo x) { }

	internal bool <GetFriendOnServer>b__8_2(IPlayerInfo x) { }

	internal string <GetFriendOnServer>b__8_3(IPlayerInfo x) { }

	internal string <GetFriendOnServer>b__8_4(IGrouping<string, IPlayerInfo> x) { }

	internal string <GetFriendOnServer>b__8_5(IGrouping<string, IPlayerInfo> x) { }

	internal string <GetFriendOnServer>b__8_6(IPlayerInfo y) { }

	internal string <GetIsFavourite>b__11_0(ServerInfo x) { }

}

public class ServerBrowserList : BaseMonoBehaviour, VirtualScroll.IDataSource // TypeDefIndex: 11181
{
	public ServerBrowserList.QueryType queryType; 
	public static string VersionTag; 
	public ServerBrowserList.ServerKeyvalues[] keyValues; 
	private IServerQuery Request; 
	internal int servers; 
	internal int players; 
	public bool shouldShowSecureServers; 
	private HashSet<IPEndPoint> officialServers; 
	public ServerBrowserCategory categoryButton; 
	public bool startActive; 
	public Transform listTransform; 
	public int refreshOrder; 
	public bool UseOfficialServers; 
	public VirtualScroll VirtualScroll; 
	public ServerBrowserList.Rules[] rules; 
	public bool hideOfficialServers; 
	public bool excludeEmptyServersUsingQuery; 
	public bool alwaysIncludeEmptyServers; 
	public bool clampPlayerCountsToTrustedValues; 
	internal bool isDirty; 
	private string searchFilter; 
	private bool showFull; 
	private bool showEmpty; 
	private HashSet<string> searchTags; 
	private HashSet<string> excludeTags; 
	private List<ServerInfo> serverList; 
	private List<ServerInfo> serverListSortedFiltered; 
	public string sortOrder; 
	private RealTimeSince timeSinceRebuild; 


	public bool IsCheater() { }

	public void Refresh() { }

	private void ServerResponded(ServerInfo server) { }

	public void InitFilters(string searchFilter, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	public void Init() { }

	public void OnEnable() { }

	public void OnDisable() { }

	public void Clear() { }

	public void AddServer(ServerInfo server) { }

	public void Rebuild() { }

	internal IOrderedEnumerable<ServerInfo> GetSortedServers() { }

	public void Update() { }

	public void SearchFilter(string searchtext, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	public void OrderBy(string strBy) { }

	private void UpdateAllPlayerClamps() { }

	private static ServerInfo ClampPlayerCount(in ServerInfo server, int maxAllowedPlayers) { }

	public int GetItemCount() { }

	public void SetItemData(int i, GameObject obj) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum ServerBrowserList.QueryType // TypeDefIndex: 11182
{
	public int value__; 
	public const ServerBrowserList.QueryType RegularInternet = 0;
	public const ServerBrowserList.QueryType Friends = 1;
	public const ServerBrowserList.QueryType History = 2;
	public const ServerBrowserList.QueryType LAN = 3;
	public const ServerBrowserList.QueryType Favourites = 4;
	public const ServerBrowserList.QueryType None = 5;

}

public struct ServerBrowserList.ServerKeyvalues // TypeDefIndex: 11183
{
	public string key; 
	public string value; 

}

public struct ServerBrowserList.Rules // TypeDefIndex: 11184
{
	public string tag; 
	public ServerBrowserList serverList; 

}

private sealed class ServerBrowserList.<>c // TypeDefIndex: 11185
{
	public static readonly ServerBrowserList.<>c <>9; 
	public static Func<Manifest.ServerDesc, string> <>9__11_0; 
	public static Func<ServerInfo, bool> <>9__41_1; 
	public static Func<ServerInfo, bool> <>9__41_2; 
	public static Func<ServerInfo, int> <>9__41_3; 
	public static Func<ServerInfo, uint> <>9__41_5; 
	public static Func<ServerInfo, uint> <>9__41_7; 
	public static Func<ServerInfo, bool> <>9__41_8; 
	public static Func<ServerInfo, uint> <>9__41_9; 
	public static Func<ServerInfo, bool> <>9__41_10; 
	public static Func<ServerInfo, uint> <>9__41_11; 
	public static Func<ServerInfo, string> <>9__41_12; 
	public static Func<ServerInfo, string> <>9__41_13; 
	public static Func<ServerInfo, int> <>9__41_14; 
	public static Func<ServerInfo, int> <>9__41_15; 
	public static Func<ServerInfo, int> <>9__41_16; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <Refresh>b__11_0(Manifest.ServerDesc x) { }

	internal bool <GetSortedServers>b__41_1(ServerInfo x) { }

	internal bool <GetSortedServers>b__41_2(ServerInfo x) { }

	internal int <GetSortedServers>b__41_3(ServerInfo x) { }

	internal uint <GetSortedServers>b__41_5(ServerInfo x) { }

	internal uint <GetSortedServers>b__41_7(ServerInfo x) { }

	internal bool <GetSortedServers>b__41_8(ServerInfo x) { }

	internal uint <GetSortedServers>b__41_9(ServerInfo x) { }

	internal bool <GetSortedServers>b__41_10(ServerInfo x) { }

	internal uint <GetSortedServers>b__41_11(ServerInfo x) { }

	internal string <GetSortedServers>b__41_12(ServerInfo x) { }

	internal string <GetSortedServers>b__41_13(ServerInfo x) { }

	internal int <GetSortedServers>b__41_14(ServerInfo x) { }

	internal int <GetSortedServers>b__41_15(ServerInfo x) { }

	internal int <GetSortedServers>b__41_16(ServerInfo x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass12_0 // TypeDefIndex: 11186
{
	public ServerBrowserList.Rules rule; 


	public void .ctor() { }

	internal bool <ServerResponded>b__0(string x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass41_0 // TypeDefIndex: 11187
{
	public ServerBrowserList <>4__this; 
	public int now; 


	public void .ctor() { }

	internal bool <GetSortedServers>b__0(ServerInfo x) { }

	internal bool <GetSortedServers>b__4(ServerInfo x) { }

	internal bool <GetSortedServers>b__6(ServerInfo x) { }

}

public class ServerBrowserTag : MonoBehaviour // TypeDefIndex: 11188
{
	public string[] serverHasAnyOf; 
	public string[] serverHasNoneOf; 
	public bool isToggleable; 
	public Color activeColor; 
	public Color inactiveColor; 
	public Image background; 
	[CompilerGeneratedAttribute] 
	private bool <IsActive>k__BackingField; 

	public bool IsActive { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] 
	private void set_IsActive(bool value) { }

	public void OnEnable() { }

	public bool Test(in ServerInfo serverInfo) { }

	public void Toggle() { }

	private void Refresh() { }

	public void .ctor() { }

}

public class ServerBrowserTagFilters : MonoBehaviour // TypeDefIndex: 11189
{
	public RustButton Button; 
	public RectTransform OptionsParent; 
	public UnityEvent TagFiltersChanged; 
	private ServerBrowserTag[] _allTags; 
	private List<bool> _previousState; 


	public void Start() { }

	public void Open() { }

	public void Close() { }

	public void GetTags(out HashSet<string> searchTags, out HashSet<string> excludeTags) { }

	private List<bool> GetCurrentSelections() { }

	public void .ctor() { }

}

private sealed class ServerBrowserTagFilters.<>c // TypeDefIndex: 11190
{
	public static readonly ServerBrowserTagFilters.<>c <>9; 
	public static Func<bool, bool> <>9__7_0; 
	public static Func<ServerBrowserTag, bool> <>9__9_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Close>b__7_0(bool b) { }

	internal bool <GetCurrentSelections>b__9_0(ServerBrowserTag t) { }

}

public class ServerBrowserTagList : MonoBehaviour // TypeDefIndex: 11191
{
	private ServerBrowserTag[] _allTags; 


	private void Initialize() { }

	public void Awake() { }

	public bool Refresh(ServerInfo server) { }

	public void .ctor() { }

}

public class ServerHistory : MonoBehaviour // TypeDefIndex: 11192
{
	public ServerHistoryItem prefab; 
	public GameObject panelList; 
	internal IServerQuery Request; 


	private void Start() { }

	[AsyncStateMachineAttribute] 
	public Task Refresh() { }

	private void OnServer(ServerInfo server) { }

	public void .ctor() { }

}

private struct ServerHistory.<Refresh>d__4 : IAsyncStateMachine // TypeDefIndex: 11193
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public ServerHistory <>4__this; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class ServerHistory.<>c // TypeDefIndex: 11194
{
	public static readonly ServerHistory.<>c <>9; 
	public static Func<Transform, object> <>9__5_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal object <OnServer>b__5_0(Transform x) { }

}

public class ServerHistoryItem : MonoBehaviour // TypeDefIndex: 11195
{
	private ServerInfo serverInfo; 
	public Text serverName; 
	public Text players; 
	public Text lastJoinDate; 
	public uint order; 


	internal void Setup(ServerInfo s) { }

	public void Open() { }

	public void .ctor() { }

}

public static class ServerInfoHelpers // TypeDefIndex: 11196
{

	[AsyncStateMachineAttribute] 
	public static Task<Nullable<ServerInfo>> Load(string address, int port) { }

	[AsyncStateMachineAttribute] 
	public static Task<Dictionary<string, string>> LoadRules(ServerInfo serverInfo) { }

}

private struct ServerInfoHelpers.<Load>d__0 : IAsyncStateMachine // TypeDefIndex: 11197
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Nullable<ServerInfo>> <>t__builder; 
	public string address; 
	public int port; 
	private List<string> <endpointSet>5__2; 
	private int <i>5__3; 
	private IServerQuery <query>5__4; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ServerInfoHelpers.<LoadRules>d__1 : IAsyncStateMachine // TypeDefIndex: 11198
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; 
	public ServerInfo serverInfo; 
	private Dictionary<string, string> <rules>5__2; 
	private int <i>5__3; 
	private TaskAwaiter<Dictionary<string, string>> <>u__1; 
	private TaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class Server // TypeDefIndex: 11675
{
	public const byte Default = 0;
	public const byte Positions = 14;

}

public class Server : ConsoleSystem // TypeDefIndex: 11984
{
	[ServerVar] 
	public static string ip; 
	[ServerVar] 
	public static int port; 
	[ServerVar] 
	public static int queryport; 
	[ServerVar] 
	public static int maxplayers; 
	[ServerVar] 
	public static string hostname; 
	[ServerVar] 
	public static string identity; 
	[ServerVar] 
	public static string level; 
	[ServerVar] 
	public static string levelurl; 
	[ServerVar] 
	public static bool leveltransfer; 
	[ServerVar] 
	public static int seed; 
	[ServerVar] 
	public static int salt; 
	[ServerVar] 
	public static int worldsize; 
	[ServerVar] 
	public static int saveinterval; 
	[ServerVar] 
	public static bool secure; 
	[ServerVar] 
	public static int encryption; 
	[ServerVar] 
	public static int tickrate; 
	[ServerVar] 
	public static int entityrate; 
	[ServerVar] 
	public static float schematime; 
	[ServerVar] 
	public static float cycletime; 
	[ServerVar] 
	public static bool official; 
	[ServerVar] 
	public static bool stats; 
	[ServerVar] 
	public static bool stability; 
	[ServerVar] 
	public static bool radiation; 
	[ServerVar] 
	public static float itemdespawn; 
	[ServerVar] 
	public static float itemdespawn_quick; 
	[ServerVar] 
	public static float corpsedespawn; 
	[ServerVar] 
	public static float debrisdespawn; 
	[ServerVar] 
	public static bool pve; 
	[ServerVar] 
	public static bool cinematic; 
	[ServerVar] 
	public static string description; 
	[ServerVar] 
	public static string url; 
	[ServerVar] 
	public static string branch; 
	[ServerVar] 
	public static int queriesPerSecond; 
	[ServerVar] 
	public static int ipQueriesPerMin; 
	[ServerVar] 
	public static bool statBackup; 
	[ServerVar] 
	public static string headerimage; 
	[ServerVar] 
	public static string logoimage; 
	[ServerVar] 
	public static int saveBackupCount; 
	[ReplicatedVar] 
	public static string motd; 
	[ServerVar] 
	public static float meleedamage; 
	[ServerVar] 
	public static float arrowdamage; 
	[ServerVar] 
	public static float bulletdamage; 
	[ServerVar] 
	public static float bleedingdamage; 
	[ReplicatedVar] 
	public static float funWaterDamageThreshold; 
	[ReplicatedVar] 
	public static float funWaterWetnessGain; 
	[ServerVar] 
	public static float meleearmor; 
	[ServerVar] 
	public static float arrowarmor; 
	[ServerVar] 
	public static float bulletarmor; 
	[ServerVar] 
	public static float bleedingarmor; 
	[ServerVar] 
	public static int updatebatch; 
	[ServerVar] 
	public static int updatebatchspawn; 
	[ServerVar] 
	public static int entitybatchsize; 
	[ServerVar] 
	public static float entitybatchtime; 
	[ServerVar] 
	public static float composterUpdateInterval; 
	[ReplicatedVar] 
	public static float planttick; 
	[ServerVar] 
	public static float planttickscale; 
	[ServerVar] 
	public static bool useMinimumPlantCondition; 
	[ServerVar] 
	public static float nonPlanterDeathChancePerTick; 
	[ServerVar] 
	public static float ceilingLightGrowableRange; 
	[ServerVar] 
	public static float artificialTemperatureGrowableRange; 
	[ServerVar] 
	public static float ceilingLightHeightOffset; 
	[ServerVar] 
	public static float sprinklerRadius; 
	[ServerVar] 
	public static float sprinklerEyeHeightOffset; 
	[ServerVar] 
	public static float optimalPlanterQualitySaturation; 
	[ServerVar] 
	public static float metabolismtick; 
	[ServerVar] 
	public static float modifierTickRate; 
	[ServerVar] 
	public static float rewounddelay; 
	[ServerVar] 
	public static bool woundingenabled; 
	[ServerVar] 
	public static bool crawlingenabled; 
	[ServerVar] 
	public static float woundedrecoverchance; 
	[ServerVar] 
	public static float incapacitatedrecoverchance; 
	[ServerVar] 
	public static float woundedmaxfoodandwaterbonus; 
	[ServerVar] 
	public static int crawlingminimumhealth; 
	[ServerVar] 
	public static int crawlingmaximumhealth; 
	[ServerVar] 
	public static bool playerserverfall; 
	[ServerVar] 
	public static bool plantlightdetection; 
	[ServerVar] 
	public static float respawnresetrange; 
	[ServerVar] 
	public static int maxunack; 
	[ServerVar] 
	public static bool netcache; 
	[ServerVar] 
	public static bool corpses; 
	[ServerVar] 
	public static bool events; 
	[ServerVar] 
	public static bool dropitems; 
	[ServerVar] 
	public static int netcachesize; 
	[ServerVar] 
	public static int savecachesize; 
	[ServerVar] 
	public static int combatlogsize; 
	[ServerVar] 
	public static int combatlogdelay; 
	[ServerVar] 
	public static int authtimeout; 
	[ServerVar] 
	public static int playertimeout; 
	[ServerVar] 
	public static int idlekick; 
	[ServerVar] 
	public static int idlekickmode; 
	[ServerVar] 
	public static int idlekickadmins; 
	[ServerVar] 
	public static string gamemode; 
	[ServerVar] 
	public static string tags; 
	[ServerVar] 
	public static bool censorplayerlist; 
	[ServerVar] 
	public static string bansServerEndpoint; 
	[ServerVar] 
	public static int bansServerFailureMode; 
	[ServerVar] 
	public static int bansServerTimeout; 
	[ServerVar] 
	public static string reportsServerEndpoint; 
	[ServerVar] 
	public static string reportsServerEndpointKey; 
	[ServerVar] 
	public static bool printReportsToConsole; 


	public static float TickDelta() { }

	public static float TickTime(uint tick) { }

	public void .ctor() { }

	private static void .cctor() { }

}

