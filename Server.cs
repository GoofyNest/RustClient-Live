internal abstract class ServerIdentity : Identity // TypeDefIndex: 1145
{	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

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
{	private IMessageSink _nextSink; // 0x10


	public void .ctor(IMessageSink nextSink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1261
{	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18


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
{	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18


	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	internal void Callback(object state) { }

	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 2986
{	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C


	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

public struct ServerInfo : IEquatable<ServerInfo> // TypeDefIndex: 5557
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Ping>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <GameDir>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Map>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Description>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <AppId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Players>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <MaxPlayers>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <BotPlayers>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Passworded>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Secure>k__BackingField; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <LastTimePlayed>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Version>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <TagString>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <SteamId>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <AddressRaw>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private IPAddress <Address>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ConnectionPort>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <QueryPort>k__BackingField; // 0x6C
	private string[] _tags; // 0x70

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


	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Name(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Ping(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_GameDir(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Map(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Description(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_AppId(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Players(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_MaxPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_BotPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Passworded(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public bool get_Secure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Secure(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_LastTimePlayed(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_TagString(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_AddressRaw(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Address(IPAddress value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_ConnectionPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_QueryPort(int value) { }

	internal static ServerInfo From(gameserveritem_t item) { }

	public void .ctor(uint ip, ushort cport, ushort qport, uint timeplayed) { }

	public void AddToHistory() { }

	[AsyncStateMachineAttribute] // RVA: 0xA5C10 Offset: 0xA5010 VA: 0x1800A5C10
	public Task<Dictionary<string, string>> QueryRulesAsync() { }

	public void RemoveFromHistory() { }

	public void AddToFavourites() { }

	public void RemoveFromFavourites() { }

	public bool Equals(ServerInfo other) { }

	public override int GetHashCode() { }

}

private struct ServerInfo.<QueryRulesAsync>d__85 : IAsyncStateMachine // TypeDefIndex: 5558
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo <>4__this; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public enum ServerQuerySet // TypeDefIndex: 5695
{	public int value__; // 0x0
	public const ServerQuerySet Whitelist = 0;
	public const ServerQuerySet Internet = 1;
	public const ServerQuerySet LocalNetwork = 2;
	public const ServerQuerySet Friends = 3;
	public const ServerQuerySet Favorites = 4;
	public const ServerQuerySet History = 5;

}

public struct ServerInfo // TypeDefIndex: 5701
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly uint <AppId>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <Name>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IPAddress <Address>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly uint <AddressRaw>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <ConnectionPort>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <QueryPort>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <Map>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <TagString>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsSecure>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <Players>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <MaxPlayers>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly uint <LastTimePlayed>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly int <Ping>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ulong <SteamId>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly uint <Born>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IReadOnlyList<string> <Tags>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <ConnectionProtocol>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <ConnectionString>k__BackingField; // 0x70

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public uint get_Born() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IReadOnlyList<string> get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_ConnectionProtocol() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_ConnectionString() { }

	public void .ctor(uint appId, string name, IPAddress address, int connectionPort, int queryPort, string map, string tagString, bool isSecure, int players, int maxPlayers, uint lastTimePlayed, int ping, ulong steamId, int authedPlayers = 2147483647) { }

	private static uint AddressToUInt32(IPAddress address) { }

	private static uint Swap(uint x) { }

}

private sealed class ServerInfo.<>c // TypeDefIndex: 5702
{	public static readonly ServerInfo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__54_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <.ctor>b__54_0(string x) { }

}

public struct ServerParameters // TypeDefIndex: 5703
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <ShortName>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <FullName>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly string <Version>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsSecure>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <HideIP>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly IPAddress <Address>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ushort <GamePort>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly ushort <QueryPort>k__BackingField; // 0x2A

	public string ShortName { get; }
	public string FullName { get; }
	public string Version { get; }
	public bool IsSecure { get; }
	public bool HideIP { get; }
	public IPAddress Address { get; }
	public ushort GamePort { get; }
	public ushort QueryPort { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_ShortName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_FullName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_HideIP() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ushort get_GamePort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ushort get_QueryPort() { }

	public void .ctor(string shortName, string fullName, string version, bool isSecure, bool hideIP, IPAddress address, ushort gamePort, ushort queryPort = 0) { }

}

public static class ServerInfoExtensions // TypeDefIndex: 6157
{
	[AsyncStateMachineAttribute] // RVA: 0x99F90 Offset: 0x99390 VA: 0x180099F90
	[ExtensionAttribute] // RVA: 0x99F90 Offset: 0x99390 VA: 0x180099F90
	public static Task<Dictionary<string, string>> QueryRulesAsync(ServerInfo server) { }

}

private struct ServerInfoExtensions.<QueryRulesAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 6158
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo server; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class ServerListMetadata // TypeDefIndex: 6211
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static DateTimeOffset <LastDownloaded>k__BackingField; // 0x2885

	public static DateTimeOffset LastDownloaded { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static DateTimeOffset get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void set_LastDownloaded(DateTimeOffset value) { }

	public static void Refresh(bool force = False) { }

	private static void UpdateMetadata() { }

	private static void LoadMetadata(string json) { }

	private static void OnUpdated(Dictionary<IPEndPoint, int> metadata) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool <LoadMetadata>g__TryParseIPEndPoint|6_0(string value, out IPEndPoint endPoint) { }

}

private sealed class ServerListMetadata.<>c // TypeDefIndex: 6212
{	public static readonly ServerListMetadata.<>c <>9; // 0x0
	public static Action<string> <>9__5_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal void <UpdateMetadata>b__5_0(string str) { }

}

public class ServerGib : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6330
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string gibName; // 0x18


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

public abstract class Server : BaseNetwork // TypeDefIndex: 6703
{	public static ulong MaxPacketsPerSecond; // 0x0
	public static int MaxPacketSize; // 0x8
	public static int MaxConnectionsPerIP; // 0xC
	public static float MaxReceiveTime; // 0x10
	public string ip; // 0x28
	public int port; // 0x30
	public bool compressionEnabled; // 0x34
	public bool logging; // 0x35
	public Manager visibility; // 0x38
	public IServerCallback callbackHandler; // 0x40
	public bool debug; // 0x48
	internal uint lastValueGiven; // 0x4C
	public List<Connection> connections; // 0x50
	private Dictionary<ulong, Connection> connectionByGUID; // 0x58
	private Dictionary<string, List<Connection>> connectionsByIP; // 0x60

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

public class ServerVar : ConsoleVar // TypeDefIndex: 6891
{
	public void .ctor() { }

}

public class ServerUserVar : ConsoleVar // TypeDefIndex: 6892
{
	public void .ctor() { }

}

public class ServerAllVar : ConsoleVar // TypeDefIndex: 6893
{
	public void .ctor() { }

}

public class Server : Server // TypeDefIndex: 7333
{	private Peer peer; // 0x68

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

public class ServerConsole : SingletonComponent<ServerConsole> // TypeDefIndex: 9289
{
	public void .ctor() { }

}

public class ServerGib : BaseCombatEntity // TypeDefIndex: 9604
{	public GameObject _gibSource; // 0x240
	public string _gibName; // 0x248
	public PhysicMaterial physicsMaterial; // 0x250
	private MeshCollider meshCollider; // 0x258
	private MeshFilter meshFilter; // 0x260
	private MeshRenderer meshRenderer; // 0x268
	private bool initialized; // 0x270


	public MeshCollider GetCollider() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void ClientSetGib(string newgibname) { }

	protected override void ClientInit(Entity info) { }

	public void VisualsInit(Mesh mesh, Material[] materials) { }

	public virtual void PhysicsInit(Mesh physicsMesh) { }

	public void .ctor() { }

}

public class ServerProjectile : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 9681
{	public Vector3 initialVelocity; // 0x20
	public float drag; // 0x2C
	public float gravityModifier; // 0x30
	public float speed; // 0x34
	public float scanRange; // 0x38
	public Vector3 swimScale; // 0x3C
	public Vector3 swimSpeed; // 0x48
	public float radius; // 0x54

	public virtual bool HasRangeLimit { get; }


	public virtual bool get_HasRangeLimit() { }

	public float GetMaxRange(float maxFuseTime) { }

	public void .ctor() { }

}

public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10711
{
public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10711
	public const string BYPASS_PROCEDURAL_SPAWN_PREF = "bypassProceduralSpawn";


	public void .ctor() { }

}

public class ServerPerformance : BaseMonoBehaviour // TypeDefIndex: 10712
{	public static ulong deaths; // 0x0
	public static ulong spawns; // 0x8
	public static ulong position_changes; // 0x10


	public void .ctor() { }

	private static void .cctor() { }

}

public class ServerBrowser : MonoBehaviour // TypeDefIndex: 11146
{	public string orderBy; // 0x18
	private string searchText; // 0x20
	private bool showFull; // 0x28
	private bool showEmpty; // 0x29
	private HashSet<string> searchTags; // 0x30
	private HashSet<string> excludeTags; // 0x38


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

public class ServerBrowserCategory : MonoBehaviour // TypeDefIndex: 11147
{	public LocalizeText serverCountText; // 0x18
	public ServerBrowserList browserList; // 0x20
	public bool isDirty; // 0x28


	public void OnEnable() { }

	public void Update() { }

	public void Dirty() { }

	public void UpdateCounts() { }

	public void .ctor() { }

}

private sealed class ServerBrowserCategory.<>c // TypeDefIndex: 11148
{	public static readonly ServerBrowserCategory.<>c <>9; // 0x0
	public static Func<ServerInfo, int> <>9__6_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <UpdateCounts>b__6_0(ServerInfo x) { }

}

public class ServerBrowserInfo : SingletonComponent<ServerBrowserInfo> // TypeDefIndex: 11149
{	public bool isMain; // 0x18
	public Text serverName; // 0x20
	public Text serverMeta; // 0x28
	public Text serverText; // 0x30
	public Button viewWebpage; // 0x38
	public Button refresh; // 0x40
	public Nullable<ServerInfo> currentServer; // 0x48
	public HttpImage headerImage; // 0xC8
	public HttpImage logoImage; // 0xD0
	private string weburl; // 0xD8
	private Texture loadedTexture; // 0xE0
	private string descriptionText; // 0xE8


	public override void SingletonSetup() { }

	public void Open(ServerInfo server) { }

	public void Close() { }

	public void JoinServer() { }

	public void JoinDelayed() { }

	public static void Join(ServerInfo server) { }

	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x99E60 Offset: 0x99260 VA: 0x180099E60
	private void QueryRules() { }

	private void EnableRefreshButton() { }

	public void VisitWebpage() { }

	public void .ctor() { }

}

private struct ServerBrowserInfo.<QueryRules>d__19 : IAsyncStateMachine // TypeDefIndex: 11150
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ServerBrowserInfo <>4__this; // 0x28
	private bool <loadedImage>5__2; // 0x30
	private bool <loadedLogo>5__3; // 0x31
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x38


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ServerBrowserItem : MonoBehaviour // TypeDefIndex: 11151
{	public TextMeshProUGUI serverName; // 0x18
	public RustText mapName; // 0x20
	public TextMeshProUGUI playerCount; // 0x28
	public TextMeshProUGUI ping; // 0x30
	public Toggle favourited; // 0x38
	public ServerBrowserTagList serverTagList; // 0x40
	private static RealTimeSince timeSinceGotFriendServers; // 0x0
	private static Dictionary<string, string> friendsOnServers; // 0x8
	private static RealTimeSince timeSinceGotFavouriteServers; // 0x10
	private static HashSet<string> favorites; // 0x18
	private ServerInfo serverInfo; // 0x48
	internal bool preventFavouriteToggle; // 0xC0


	private static string GetFriendOnServer(IPAddress addr, int port) { }

	private static bool GetIsFavourite(IPAddress addr, int port) { }

	internal void Init(ServerInfo s, bool isFavourites, bool isHistory) { }

	public void OnClicked() { }

	public void OnFavouriteToggle(bool favourite) { }

	public void .ctor() { }

}

private sealed class ServerBrowserItem.<>c // TypeDefIndex: 11152
{	public static readonly ServerBrowserItem.<>c <>9; // 0x0
	public static Func<IPlayerInfo, bool> <>9__8_0; // 0x8
	public static Func<IPlayerInfo, bool> <>9__8_1; // 0x10
	public static Func<IPlayerInfo, bool> <>9__8_2; // 0x18
	public static Func<IPlayerInfo, string> <>9__8_3; // 0x20
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_4; // 0x28
	public static Func<IPlayerInfo, string> <>9__8_6; // 0x30
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_5; // 0x38
	public static Func<ServerInfo, string> <>9__11_0; // 0x40


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

public class ServerBrowserList : BaseMonoBehaviour, VirtualScroll.IDataSource // TypeDefIndex: 11153
{	public ServerBrowserList.QueryType queryType; // 0x18
	public static string VersionTag; // 0x0
	public ServerBrowserList.ServerKeyvalues[] keyValues; // 0x20
	private IServerQuery Request; // 0x28
	internal int servers; // 0x30
	internal int players; // 0x34
	public bool shouldShowSecureServers; // 0x38
	private HashSet<IPEndPoint> officialServers; // 0x40
	public ServerBrowserCategory categoryButton; // 0x48
	public bool startActive; // 0x50
	public Transform listTransform; // 0x58
	public int refreshOrder; // 0x60
	public bool UseOfficialServers; // 0x64
	public VirtualScroll VirtualScroll; // 0x68
	public ServerBrowserList.Rules[] rules; // 0x70
	public bool hideOfficialServers; // 0x78
	public bool excludeEmptyServersUsingQuery; // 0x79
	public bool alwaysIncludeEmptyServers; // 0x7A
	public bool clampPlayerCountsToTrustedValues; // 0x7B
	internal bool isDirty; // 0x7C
	private string searchFilter; // 0x80
	private bool showFull; // 0x88
	private bool showEmpty; // 0x89
	private HashSet<string> searchTags; // 0x90
	private HashSet<string> excludeTags; // 0x98
	private List<ServerInfo> serverList; // 0xA0
	private List<ServerInfo> serverListSortedFiltered; // 0xA8
	public string sortOrder; // 0xB0
	private RealTimeSince timeSinceRebuild; // 0xB8


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

public enum ServerBrowserList.QueryType // TypeDefIndex: 11154
{	public int value__; // 0x0
	public const ServerBrowserList.QueryType RegularInternet = 0;
	public const ServerBrowserList.QueryType Friends = 1;
	public const ServerBrowserList.QueryType History = 2;
	public const ServerBrowserList.QueryType LAN = 3;
	public const ServerBrowserList.QueryType Favourites = 4;
	public const ServerBrowserList.QueryType None = 5;

}

public struct ServerBrowserList.ServerKeyvalues // TypeDefIndex: 11155
{	public string key; // 0x0
	public string value; // 0x8

}

public struct ServerBrowserList.Rules // TypeDefIndex: 11156
{	public string tag; // 0x0
	public ServerBrowserList serverList; // 0x8

}

private sealed class ServerBrowserList.<>c // TypeDefIndex: 11157
{	public static readonly ServerBrowserList.<>c <>9; // 0x0
	public static Func<Manifest.ServerDesc, string> <>9__11_0; // 0x8
	public static Func<ServerInfo, bool> <>9__41_1; // 0x10
	public static Func<ServerInfo, bool> <>9__41_2; // 0x18
	public static Func<ServerInfo, int> <>9__41_3; // 0x20
	public static Func<ServerInfo, uint> <>9__41_5; // 0x28
	public static Func<ServerInfo, uint> <>9__41_7; // 0x30
	public static Func<ServerInfo, bool> <>9__41_8; // 0x38
	public static Func<ServerInfo, uint> <>9__41_9; // 0x40
	public static Func<ServerInfo, bool> <>9__41_10; // 0x48
	public static Func<ServerInfo, uint> <>9__41_11; // 0x50
	public static Func<ServerInfo, string> <>9__41_12; // 0x58
	public static Func<ServerInfo, string> <>9__41_13; // 0x60
	public static Func<ServerInfo, int> <>9__41_14; // 0x68
	public static Func<ServerInfo, int> <>9__41_15; // 0x70
	public static Func<ServerInfo, int> <>9__41_16; // 0x78


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

private sealed class ServerBrowserList.<>c__DisplayClass12_0 // TypeDefIndex: 11158
{	public ServerBrowserList.Rules rule; // 0x10


	public void .ctor() { }

	internal bool <ServerResponded>b__0(string x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass41_0 // TypeDefIndex: 11159
{	public ServerBrowserList <>4__this; // 0x10
	public int now; // 0x18


	public void .ctor() { }

	internal bool <GetSortedServers>b__0(ServerInfo x) { }

	internal bool <GetSortedServers>b__4(ServerInfo x) { }

	internal bool <GetSortedServers>b__6(ServerInfo x) { }

}

public class ServerBrowserTag : MonoBehaviour // TypeDefIndex: 11160
{	public string[] serverHasAnyOf; // 0x18
	public string[] serverHasNoneOf; // 0x20
	public bool isToggleable; // 0x28
	public Color activeColor; // 0x2C
	public Color inactiveColor; // 0x3C
	public Image background; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsActive>k__BackingField; // 0x58

	public bool IsActive { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_IsActive(bool value) { }

	public void OnEnable() { }

	public bool Test(in ServerInfo serverInfo) { }

	public void Toggle() { }

	private void Refresh() { }

	public void .ctor() { }

}

public class ServerBrowserTagFilters : MonoBehaviour // TypeDefIndex: 11161
{	public RustButton Button; // 0x18
	public RectTransform OptionsParent; // 0x20
	public UnityEvent TagFiltersChanged; // 0x28
	private ServerBrowserTag[] _allTags; // 0x30
	private List<bool> _previousState; // 0x38


	public void Start() { }

	public void Open() { }

	public void Close() { }

	public void GetTags(out HashSet<string> searchTags, out HashSet<string> excludeTags) { }

	private List<bool> GetCurrentSelections() { }

	public void .ctor() { }

}

private sealed class ServerBrowserTagFilters.<>c // TypeDefIndex: 11162
{	public static readonly ServerBrowserTagFilters.<>c <>9; // 0x0
	public static Func<bool, bool> <>9__7_0; // 0x8
	public static Func<ServerBrowserTag, bool> <>9__9_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <Close>b__7_0(bool b) { }

	internal bool <GetCurrentSelections>b__9_0(ServerBrowserTag t) { }

}

public class ServerBrowserTagList : MonoBehaviour // TypeDefIndex: 11163
{	private ServerBrowserTag[] _allTags; // 0x18


	private void Initialize() { }

	public void Awake() { }

	public bool Refresh(ServerInfo server) { }

	public void .ctor() { }

}

public class ServerHistory : MonoBehaviour // TypeDefIndex: 11164
{	public ServerHistoryItem prefab; // 0x18
	public GameObject panelList; // 0x20
	internal IServerQuery Request; // 0x28


	private void Start() { }

	[AsyncStateMachineAttribute] // RVA: 0x9AD60 Offset: 0x9A160 VA: 0x18009AD60
	public Task Refresh() { }

	private void OnServer(ServerInfo server) { }

	public void .ctor() { }

}

private struct ServerHistory.<Refresh>d__4 : IAsyncStateMachine // TypeDefIndex: 11165
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ServerHistory <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class ServerHistory.<>c // TypeDefIndex: 11166
{	public static readonly ServerHistory.<>c <>9; // 0x0
	public static Func<Transform, object> <>9__5_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal object <OnServer>b__5_0(Transform x) { }

}

public class ServerHistoryItem : MonoBehaviour // TypeDefIndex: 11167
{	private ServerInfo serverInfo; // 0x18
	public Text serverName; // 0x90
	public Text players; // 0x98
	public Text lastJoinDate; // 0xA0
	public uint order; // 0xA8


	internal void Setup(ServerInfo s) { }

	public void Open() { }

	public void .ctor() { }

}

public static class ServerInfoHelpers // TypeDefIndex: 11168
{
	[AsyncStateMachineAttribute] // RVA: 0x9B140 Offset: 0x9A540 VA: 0x18009B140
	public static Task<Nullable<ServerInfo>> Load(string address, int port) { }

	[AsyncStateMachineAttribute] // RVA: 0x9B2F0 Offset: 0x9A6F0 VA: 0x18009B2F0
	public static Task<Dictionary<string, string>> LoadRules(ServerInfo serverInfo) { }

}

private struct ServerInfoHelpers.<Load>d__0 : IAsyncStateMachine // TypeDefIndex: 11169
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<ServerInfo>> <>t__builder; // 0x8
	public string address; // 0x20
	public int port; // 0x28
	private List<string> <endpointSet>5__2; // 0x30
	private int <i>5__3; // 0x38
	private IServerQuery <query>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ServerInfoHelpers.<LoadRules>d__1 : IAsyncStateMachine // TypeDefIndex: 11170
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo serverInfo; // 0x20
	private Dictionary<string, string> <rules>5__2; // 0x98
	private int <i>5__3; // 0xA0
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0xA8
	private TaskAwaiter <>u__2; // 0xB0


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class Server // TypeDefIndex: 11647
{	public const byte Default = 0;
	public const byte Positions = 14;

}

public class Server : ConsoleSystem // TypeDefIndex: 11956
{	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string ip; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int port; // 0x8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int queryport; // 0xC
	[ServerVar] // RVA: 0xB4320 Offset: 0xB3720 VA: 0x1800B4320
	public static int maxplayers; // 0x10
	[ServerVar] // RVA: 0xB4320 Offset: 0xB3720 VA: 0x1800B4320
	public static string hostname; // 0x18
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string identity; // 0x20
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string level; // 0x28
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string levelurl; // 0x30
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool leveltransfer; // 0x38
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int seed; // 0x3C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int salt; // 0x40
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int worldsize; // 0x44
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int saveinterval; // 0x48
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool secure; // 0x4C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int encryption; // 0x50
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int tickrate; // 0x54
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int entityrate; // 0x58
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float schematime; // 0x5C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float cycletime; // 0x60
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool official; // 0x64
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool stats; // 0x65
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool globalchat; // 0x66
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool stability; // 0x67
	[ServerVar] // RVA: 0xB4320 Offset: 0xB3720 VA: 0x1800B4320
	public static bool radiation; // 0x68
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float itemdespawn; // 0x6C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float itemdespawn_quick; // 0x70
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float corpsedespawn; // 0x74
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float debrisdespawn; // 0x78
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool pve; // 0x7C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool cinematic; // 0x7D
	[ServerVar] // RVA: 0xB4320 Offset: 0xB3720 VA: 0x1800B4320
	public static string description; // 0x80
	[ServerVar] // RVA: 0xB4320 Offset: 0xB3720 VA: 0x1800B4320
	public static string url; // 0x88
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string branch; // 0x90
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int queriesPerSecond; // 0x98
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int ipQueriesPerMin; // 0x9C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool statBackup; // 0xA0
	[ServerVar] // RVA: 0xB72B0 Offset: 0xB66B0 VA: 0x1800B72B0
	public static string headerimage; // 0xA8
	[ServerVar] // RVA: 0xB72B0 Offset: 0xB66B0 VA: 0x1800B72B0
	public static string logoimage; // 0xB0
	[ServerVar] // RVA: 0xB72B0 Offset: 0xB66B0 VA: 0x1800B72B0
	public static int saveBackupCount; // 0xB8
	[ReplicatedVar] // RVA: 0xB87E0 Offset: 0xB7BE0 VA: 0x1800B87E0
	public static string motd; // 0xC0
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float meleedamage; // 0xC8
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float arrowdamage; // 0xCC
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float bulletdamage; // 0xD0
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float bleedingdamage; // 0xD4
	[ReplicatedVar] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	public static float funWaterDamageThreshold; // 0xD8
	[ReplicatedVar] // RVA: 0x856E0 Offset: 0x84AE0 VA: 0x1800856E0
	public static float funWaterWetnessGain; // 0xDC
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float meleearmor; // 0xE0
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float arrowarmor; // 0xE4
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float bulletarmor; // 0xE8
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float bleedingarmor; // 0xEC
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int updatebatch; // 0xF0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int updatebatchspawn; // 0xF4
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int entitybatchsize; // 0xF8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float entitybatchtime; // 0xFC
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float composterUpdateInterval; // 0x100
	[ReplicatedVar] // RVA: 0xA98E0 Offset: 0xA8CE0 VA: 0x1800A98E0
	public static float planttick; // 0x104
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float planttickscale; // 0x108
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool useMinimumPlantCondition; // 0x10C
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float nonPlanterDeathChancePerTick; // 0x110
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float ceilingLightGrowableRange; // 0x114
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float artificialTemperatureGrowableRange; // 0x118
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float ceilingLightHeightOffset; // 0x11C
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float sprinklerRadius; // 0x120
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float sprinklerEyeHeightOffset; // 0x124
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float optimalPlanterQualitySaturation; // 0x128
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float metabolismtick; // 0x12C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float modifierTickRate; // 0x130
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static float rewounddelay; // 0x134
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static bool woundingenabled; // 0x138
	[ServerVar] // RVA: 0xB9C20 Offset: 0xB9020 VA: 0x1800B9C20
	public static float woundedrecoverchance; // 0x13C
	[ServerVar] // RVA: 0xB9C90 Offset: 0xB9090 VA: 0x1800B9C90
	public static float incapacitatedrecoverchance; // 0x140
	[ServerVar] // RVA: 0xB9D90 Offset: 0xB9190 VA: 0x1800B9D90
	public static float woundedmaxfoodandwaterbonus; // 0x144
	[ServerVar] // RVA: 0xB9E90 Offset: 0xB9290 VA: 0x1800B9E90
	public static int crawlingminimumhealth; // 0x148
	[ServerVar] // RVA: 0xB9F50 Offset: 0xB9350 VA: 0x1800B9F50
	public static int crawlingmaximumhealth; // 0x14C
	[ServerVar] // RVA: 0xB8840 Offset: 0xB7C40 VA: 0x1800B8840
	public static bool playerserverfall; // 0x150
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool plantlightdetection; // 0x151
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static float respawnresetrange; // 0x154
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int maxunack; // 0x158
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool netcache; // 0x15C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool corpses; // 0x15D
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool events; // 0x15E
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static bool dropitems; // 0x15F
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int netcachesize; // 0x160
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int savecachesize; // 0x164
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int combatlogsize; // 0x168
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int combatlogdelay; // 0x16C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int authtimeout; // 0x170
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int playertimeout; // 0x174
	[ServerVar] // RVA: 0xB4320 Offset: 0xB3720 VA: 0x1800B4320
	public static int idlekick; // 0x178
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int idlekickmode; // 0x17C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int idlekickadmins; // 0x180
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string gamemode; // 0x188
	[ServerVar] // RVA: 0xBBFB0 Offset: 0xBB3B0 VA: 0x1800BBFB0
	public static string tags; // 0x190
	[ServerVar] // RVA: 0xBC0E0 Offset: 0xBB4E0 VA: 0x1800BC0E0
	public static bool censorplayerlist; // 0x198
	[ServerVar] // RVA: 0xBC300 Offset: 0xBB700 VA: 0x1800BC300
	public static string bansServerEndpoint; // 0x1A0
	[ServerVar] // RVA: 0xBC3D0 Offset: 0xBB7D0 VA: 0x1800BC3D0
	public static int bansServerFailureMode; // 0x1A8
	[ServerVar] // RVA: 0xBC690 Offset: 0xBBA90 VA: 0x1800BC690
	public static int bansServerTimeout; // 0x1AC
	[ServerVar] // RVA: 0xBDA50 Offset: 0xBCE50 VA: 0x1800BDA50
	public static string reportsServerEndpoint; // 0x1B0
	[ServerVar] // RVA: 0xBDBE0 Offset: 0xBCFE0 VA: 0x1800BDBE0
	public static string reportsServerEndpointKey; // 0x1B8
	[ServerVar] // RVA: 0xBDC70 Offset: 0xBD070 VA: 0x1800BDC70
	public static bool printReportsToConsole; // 0x1C0


	public static float TickDelta() { }

	public static float TickTime(uint tick) { }

	public void .ctor() { }

	private static void .cctor() { }

}

