internal abstract class ServerIdentity : Identity // TypeDefIndex: 1145
{	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x11FDF00 Offset: 0x11FD300 VA: 0x1811FDF00
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public Type get_ObjectType() { }

	// RVA: 0x11FDD70 Offset: 0x11FD170 VA: 0x1811FDD70
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x11FDD60 Offset: 0x11FD160 VA: 0x1811FDD60 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x11FDAF0 Offset: 0x11FCEF0 VA: 0x1811FDAF0 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x11FD9A0 Offset: 0x11FCDA0 VA: 0x1811FD9A0
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public Lease get_Lease() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public Context get_Context() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x11FDCC0 Offset: 0x11FD0C0 VA: 0x1811FDCC0
	protected void DisposeServerObject() { }

}

internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 1259
{	// Methods

	// RVA: 0x1487880 Offset: 0x1486C80 VA: 0x181487880 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1487770 Offset: 0x1486B70 VA: 0x181487770 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 1260
{	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x1487D20 Offset: 0x1487120 VA: 0x181487D20 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1487B00 Offset: 0x1486F00 VA: 0x181487B00 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 1261
{	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0xFD7210 Offset: 0xFD6610 VA: 0x180FD7210
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x1487A40 Offset: 0x1486E40 VA: 0x181487A40 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x14879F0 Offset: 0x1486DF0 VA: 0x1814879F0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal sealed class ServerCertValidationCallbackWrapper : MulticastDelegate // TypeDefIndex: 2542
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFF64E0 Offset: 0xFF58E0 VA: 0x180FF64E0 Slot: 12
	public virtual bool Invoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors) { }

	// RVA: 0x12165F0 Offset: 0x12159F0 VA: 0x1812165F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors, AsyncCallback __callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

internal class ServerCertValidationCallback // TypeDefIndex: 2985
{	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Methods

	// RVA: 0xFF7EA0 Offset: 0xFF72A0 VA: 0x180FF7EA0
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0xFF7C90 Offset: 0xFF7090 VA: 0x180FF7C90
	internal void Callback(object state) { }

	// RVA: 0xFF7D50 Offset: 0xFF7150 VA: 0x180FF7D50
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 2986
{	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0xFF1D70 Offset: 0xFF1170 VA: 0x180FF1D70
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

}

public struct ServerInfo : IEquatable<ServerInfo> // TypeDefIndex: 5557
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_Name(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DDE0 Offset: 0x19D1E0 VA: 0x18019DDE0
	public void set_Ping(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1360 Offset: 0xF0760 VA: 0x1800F1360
	public void set_GameDir(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xF3DE0 Offset: 0xF31E0 VA: 0x1800F3DE0
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1370 Offset: 0xF0770 VA: 0x1800F1370
	public void set_Map(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF13D0 Offset: 0xF07D0 VA: 0x1800F13D0
	public void set_Description(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xF3DC0 Offset: 0xF31C0 VA: 0x1800F3DC0
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DF0 Offset: 0xF31F0 VA: 0x1800F3DF0
	public void set_AppId(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D84B0 Offset: 0x1D78B0 VA: 0x1801D84B0
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8540 Offset: 0x1D7940 VA: 0x1801D8540
	public void set_Players(int value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D0ED0 Offset: 0x1D02D0 VA: 0x1801D0ED0
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8530 Offset: 0x1D7930 VA: 0x1801D8530
	public void set_MaxPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8500 Offset: 0x1D7900 VA: 0x1801D8500
	public void set_BotPlayers(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D2640 Offset: 0x1D1A40 VA: 0x1801D2640
	public void set_Passworded(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D84D0 Offset: 0x1D78D0 VA: 0x1801D84D0
	public bool get_Secure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8560 Offset: 0x1D7960 VA: 0x1801D8560
	public void set_Secure(bool value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D84A0 Offset: 0x1D78A0 VA: 0x1801D84A0
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8520 Offset: 0x1D7920 VA: 0x1801D8520
	public void set_LastTimePlayed(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8580 Offset: 0x1D7980 VA: 0x1801D8580
	public void set_Version(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0xFC6B0 Offset: 0xFBAB0 VA: 0x1800FC6B0
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF38A0 Offset: 0xF2CA0 VA: 0x1800F38A0
	public void set_TagString(string value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D84E0 Offset: 0x1D78E0 VA: 0x1801D84E0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8570 Offset: 0x1D7970 VA: 0x1801D8570
	public void set_SteamId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D8470 Offset: 0x1D7870 VA: 0x1801D8470
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D84F0 Offset: 0x1D78F0 VA: 0x1801D84F0
	public void set_AddressRaw(uint value) { }

	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D8480 Offset: 0x1D7880 VA: 0x1801D8480
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF38C0 Offset: 0xF2CC0 VA: 0x1800F38C0
	public void set_Address(IPAddress value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D8490 Offset: 0x1D7890 VA: 0x1801D8490
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8510 Offset: 0x1D7910 VA: 0x1801D8510
	public void set_ConnectionPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[IsReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	// RVA: 0x1D84C0 Offset: 0x1D78C0 VA: 0x1801D84C0
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8550 Offset: 0x1D7950 VA: 0x1801D8550
	public void set_QueryPort(int value) { }

	// RVA: 0x1289B80 Offset: 0x1288F80 VA: 0x181289B80
	internal static ServerInfo From(gameserveritem_t item) { }

	// RVA: 0x1D83B0 Offset: 0x1D77B0 VA: 0x1801D83B0
	public void .ctor(uint ip, ushort cport, ushort qport, uint timeplayed) { }

	// RVA: 0x1D7E60 Offset: 0x1D7260 VA: 0x1801D7E60
	public void AddToHistory() { }

	[AsyncStateMachineAttribute] // RVA: 0xA5C10 Offset: 0xA5010 VA: 0x1800A5C10
	// RVA: 0x1D80A0 Offset: 0x1D74A0 VA: 0x1801D80A0
	public Task<Dictionary<string, string>> QueryRulesAsync() { }

	// RVA: 0x1D82C0 Offset: 0x1D76C0 VA: 0x1801D82C0
	public void RemoveFromHistory() { }

	// RVA: 0x1D7D20 Offset: 0x1D7120 VA: 0x1801D7D20
	public void AddToFavourites() { }

	// RVA: 0x1D81D0 Offset: 0x1D75D0 VA: 0x1801D81D0
	public void RemoveFromFavourites() { }

	// RVA: 0x1D7FA0 Offset: 0x1D73A0 VA: 0x1801D7FA0 Slot: 4
	public bool Equals(ServerInfo other) { }

	// RVA: 0x1D8090 Offset: 0x1D7490 VA: 0x1801D8090 Slot: 2
	public override int GetHashCode() { }

}

private struct ServerInfo.<QueryRulesAsync>d__85 : IAsyncStateMachine // TypeDefIndex: 5558
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo <>4__this; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98

	// Methods

	// RVA: 0x1DB040 Offset: 0x1DA440 VA: 0x1801DB040 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1DB050 Offset: 0x1DA450 VA: 0x1801DB050 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public enum ServerQuerySet // TypeDefIndex: 5695
{	// Fields
	public int value__; // 0x0
	public const ServerQuerySet Whitelist = 0;
	public const ServerQuerySet Internet = 1;
	public const ServerQuerySet LocalNetwork = 2;
	public const ServerQuerySet Friends = 3;
	public const ServerQuerySet Favorites = 4;
	public const ServerQuerySet History = 5;

}

public struct ServerInfo // TypeDefIndex: 5701
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public uint get_AppId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1EEF30 Offset: 0x1EE330 VA: 0x1801EEF30
	public uint get_AddressRaw() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1EEF40 Offset: 0x1EE340 VA: 0x1801EEF40
	public int get_ConnectionPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12C050 Offset: 0x12B450 VA: 0x18012C050
	public int get_QueryPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC690 Offset: 0xFBA90 VA: 0x1800FC690
	public string get_Map() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC8E0 Offset: 0xFBCE0 VA: 0x1800FC8E0
	public string get_TagString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23F7A0 Offset: 0x23EBA0 VA: 0x18023F7A0
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D84A0 Offset: 0x1D78A0 VA: 0x1801D84A0
	public int get_Players() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6A0 Offset: 0xFBAA0 VA: 0x1800FC6A0
	public int get_MaxPlayers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23F7B0 Offset: 0x23EBB0 VA: 0x18023F7B0
	public uint get_LastTimePlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1E0980 Offset: 0x1DFD80 VA: 0x1801E0980
	public int get_Ping() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D84E0 Offset: 0x1D78E0 VA: 0x1801D84E0
	public ulong get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8470 Offset: 0x1D7870 VA: 0x1801D8470
	public uint get_Born() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8480 Offset: 0x1D7880 VA: 0x1801D8480
	public IReadOnlyList<string> get_Tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6E0 Offset: 0xFBAE0 VA: 0x1800FC6E0
	public string get_ConnectionProtocol() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x141DA0 Offset: 0x1411A0 VA: 0x180141DA0
	public string get_ConnectionString() { }

	// RVA: 0x23F780 Offset: 0x23EB80 VA: 0x18023F780
	public void .ctor(uint appId, string name, IPAddress address, int connectionPort, int queryPort, string map, string tagString, bool isSecure, int players, int maxPlayers, uint lastTimePlayed, int ping, ulong steamId, int authedPlayers = 2147483647) { }

	// RVA: 0x22FB040 Offset: 0x22FA440 VA: 0x1822FB040
	private static uint AddressToUInt32(IPAddress address) { }

	// RVA: 0x19DCF40 Offset: 0x19DC340 VA: 0x1819DCF40
	private static uint Swap(uint x) { }

}

private sealed class ServerInfo.<>c // TypeDefIndex: 5702
{	// Fields
	public static readonly ServerInfo.<>c <>9; // 0x0
	public static Func<string, bool> <>9__54_0; // 0x8

	// Methods

	// RVA: 0x22FB800 Offset: 0x22FAC00 VA: 0x1822FB800
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22FB7B0 Offset: 0x22FABB0 VA: 0x1822FB7B0
	internal bool <.ctor>b__54_0(string x) { }

}

public struct ServerParameters // TypeDefIndex: 5703
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
	public string ShortName { get; }
	public string FullName { get; }
	public string Version { get; }
	public bool IsSecure { get; }
	public bool HideIP { get; }
	public IPAddress Address { get; }
	public ushort GamePort { get; }
	public ushort QueryPort { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public string get_ShortName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public string get_FullName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public string get_Version() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23F940 Offset: 0x23ED40 VA: 0x18023F940
	public bool get_IsSecure() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23F930 Offset: 0x23ED30 VA: 0x18023F930
	public bool get_HideIP() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3860 Offset: 0xF2C60 VA: 0x1800F3860
	public IPAddress get_Address() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23F920 Offset: 0x23ED20 VA: 0x18023F920
	public ushort get_GamePort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23F950 Offset: 0x23ED50 VA: 0x18023F950
	public ushort get_QueryPort() { }

	// RVA: 0x23F7C0 Offset: 0x23EBC0 VA: 0x18023F7C0
	public void .ctor(string shortName, string fullName, string version, bool isSecure, bool hideIP, IPAddress address, ushort gamePort, ushort queryPort = 0) { }

}

public static class ServerInfoExtensions // TypeDefIndex: 6157
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x99F90 Offset: 0x99390 VA: 0x180099F90
	[ExtensionAttribute] // RVA: 0x99F90 Offset: 0x99390 VA: 0x180099F90
	// RVA: 0x2310B20 Offset: 0x230FF20 VA: 0x182310B20
	public static Task<Dictionary<string, string>> QueryRulesAsync(ServerInfo server) { }

}

private struct ServerInfoExtensions.<QueryRulesAsync>d__0 : IAsyncStateMachine // TypeDefIndex: 6158
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo server; // 0x20
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x98

	// Methods

	// RVA: 0x240990 Offset: 0x23FD90 VA: 0x180240990 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2409A0 Offset: 0x23FDA0 VA: 0x1802409A0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class ServerListMetadata // TypeDefIndex: 6211
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static DateTimeOffset <LastDownloaded>k__BackingField; // 0x2885

	// Properties
	public static DateTimeOffset LastDownloaded { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14F02C0 Offset: 0x14EF6C0 VA: 0x1814F02C0
	public static DateTimeOffset get_LastDownloaded() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14F0310 Offset: 0x14EF710 VA: 0x1814F0310
	private static void set_LastDownloaded(DateTimeOffset value) { }

	// RVA: 0x14EFBF0 Offset: 0x14EEFF0 VA: 0x1814EFBF0
	public static void Refresh(bool force = False) { }

	// RVA: 0x14F0160 Offset: 0x14EF560 VA: 0x1814F0160
	private static void UpdateMetadata() { }

	// RVA: 0x14EF1D0 Offset: 0x14EE5D0 VA: 0x1814EF1D0
	private static void LoadMetadata(string json) { }

	// RVA: 0x14EFB40 Offset: 0x14EEF40 VA: 0x1814EFB40
	private static void OnUpdated(Dictionary<IPEndPoint, int> metadata) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EFFE0 Offset: 0x14EF3E0 VA: 0x1814EFFE0
	internal static bool <LoadMetadata>g__TryParseIPEndPoint|6_0(string value, out IPEndPoint endPoint) { }

}

private sealed class ServerListMetadata.<>c // TypeDefIndex: 6212
{	// Fields
	public static readonly ServerListMetadata.<>c <>9; // 0x0
	public static Action<string> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x14F45B0 Offset: 0x14F39B0 VA: 0x1814F45B0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x14F3D50 Offset: 0x14F3150 VA: 0x1814F3D50
	internal void <UpdateMetadata>b__5_0(string str) { }

}

public class ServerGib : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6330
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string gibName; // 0x18

	// Methods

	// RVA: 0x1E02FB0 Offset: 0x1E023B0 VA: 0x181E02FB0
	public static void ResetToPool(ServerGib instance) { }

	// RVA: 0x1E02F20 Offset: 0x1E02320 VA: 0x181E02F20
	public void ResetToPool() { }

	// RVA: 0x1E02DD0 Offset: 0x1E021D0 VA: 0x181E02DD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D62910 Offset: 0x1D61D10 VA: 0x181D62910
	public void CopyTo(ServerGib instance) { }

	// RVA: 0x1E02430 Offset: 0x1E01830 VA: 0x181E02430
	public ServerGib Copy() { }

	// RVA: 0x1E02D50 Offset: 0x1E02150 VA: 0x181E02D50
	public static ServerGib Deserialize(Stream stream) { }

	// RVA: 0x1E026D0 Offset: 0x1E01AD0 VA: 0x181E026D0
	public static ServerGib DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E02750 Offset: 0x1E01B50 VA: 0x181E02750
	public static ServerGib DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E029E0 Offset: 0x1E01DE0 VA: 0x181E029E0
	public static ServerGib Deserialize(byte[] buffer) { }

	// RVA: 0x1E02EE0 Offset: 0x1E022E0 VA: 0x181E02EE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E03420 Offset: 0x1E02820 VA: 0x181E03420 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E03440 Offset: 0x1E02840 VA: 0x181E03440 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ServerGib previous) { }

	// RVA: 0x1E02F00 Offset: 0x1E02300 VA: 0x181E02F00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E02C50 Offset: 0x1E02050 VA: 0x181E02C50
	public static ServerGib Deserialize(byte[] buffer, ServerGib instance, bool isDelta = False) { }

	// RVA: 0x1E02B00 Offset: 0x1E01F00 VA: 0x181E02B00
	public static ServerGib Deserialize(Stream stream, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E024B0 Offset: 0x1E018B0 VA: 0x181E024B0
	public static ServerGib DeserializeLengthDelimited(Stream stream, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E027E0 Offset: 0x1E01BE0 VA: 0x181E027E0
	public static ServerGib DeserializeLength(Stream stream, int length, ServerGib instance, bool isDelta) { }

	// RVA: 0x1E03040 Offset: 0x1E02440 VA: 0x181E03040
	public static void SerializeDelta(Stream stream, ServerGib instance, ServerGib previous) { }

	// RVA: 0x1E03320 Offset: 0x1E02720 VA: 0x181E03320
	public static void Serialize(Stream stream, ServerGib instance) { }

	// RVA: 0x1E03410 Offset: 0x1E02810 VA: 0x181E03410
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E03420 Offset: 0x1E02820 VA: 0x181E03420
	public void ToProto(Stream stream) { }

	// RVA: 0x1E03210 Offset: 0x1E02610 VA: 0x181E03210
	public static byte[] SerializeToBytes(ServerGib instance) { }

	// RVA: 0x1E03160 Offset: 0x1E02560 VA: 0x181E03160
	public static void SerializeLengthDelimited(Stream stream, ServerGib instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public abstract class Server : BaseNetwork // TypeDefIndex: 6703
{	// Fields
	public static ulong MaxPacketsPerSecond; // 0x0
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

	// Properties
	public virtual string ProtocolId { get; }
	public virtual bool AllowPassthroughMessages { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();

	// RVA: 0x220F230 Offset: 0x220E630 VA: 0x18220F230 Slot: 8
	public virtual string get_ProtocolId() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 9
	public virtual bool get_AllowPassthroughMessages() { }

	// RVA: 0x220F010 Offset: 0x220E410 VA: 0x18220F010
	public void Reset() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 10
	public virtual bool Start() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	public virtual void Stop(string shutdownMsg) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public virtual void Cycle() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Disconnect(Connection cn);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Kick(Connection cn, string message, bool logfile = False);

	// RVA: 0x220F020 Offset: 0x220E420 VA: 0x18220F020
	public uint TakeUID() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void ReturnUID(uint uid) { }

	// RVA: 0x220EE80 Offset: 0x220E280 VA: 0x18220EE80
	public void RegisterUID(uint uid) { }

	// RVA: 0x220F010 Offset: 0x220E410 VA: 0x18220F010
	internal void ResetUIDs() { }

	// RVA: 0x220E720 Offset: 0x220DB20 VA: 0x18220E720
	public Networkable CreateNetworkable() { }

	// RVA: 0x220E680 Offset: 0x220DA80 VA: 0x18220E680
	public Networkable CreateNetworkable(uint uid) { }

	// RVA: 0x220E830 Offset: 0x220DC30 VA: 0x18220E830
	public void DestroyNetworkable(ref Networkable networkable) { }

	// RVA: 0x220E990 Offset: 0x220DD90 VA: 0x18220E990
	protected void OnDisconnected(string strReason, Connection cn) { }

	// RVA: 0x220E8C0 Offset: 0x220DCC0 VA: 0x18220E8C0
	protected Connection FindConnection(ulong guid) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 15
	protected virtual void OnNewConnection() { }

	// RVA: 0x220E940 Offset: 0x220DD40 VA: 0x18220E940
	private string IPAddressWithoutPort(string address) { }

	// RVA: 0x220EBB0 Offset: 0x220DFB0 VA: 0x18220EBB0 Slot: 16
	protected virtual void OnNewConnection(Connection connection) { }

	// RVA: 0x220EE90 Offset: 0x220E290 VA: 0x18220EE90
	protected void RemoveConnection(Connection connection) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 17
	public virtual int GetAveragePing(Connection connection) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 18
	public virtual void SendUnconnected(uint netAddr, ushort netPort, byte[] steamResponseBuffer, int packetSize) { }

	// RVA: 0x220F140 Offset: 0x220E540 VA: 0x18220F140
	protected void .ctor() { }

	// RVA: 0x220F0C0 Offset: 0x220E4C0 VA: 0x18220F0C0
	private static void .cctor() { }

}

public class ServerVar : ConsoleVar // TypeDefIndex: 6891
{	// Methods

	// RVA: 0x22B0300 Offset: 0x22AF700 VA: 0x1822B0300
	public void .ctor() { }

}

public class ServerUserVar : ConsoleVar // TypeDefIndex: 6892
{	// Methods

	// RVA: 0x22B02E0 Offset: 0x22AF6E0 VA: 0x1822B02E0
	public void .ctor() { }

}

public class ServerAllVar : ConsoleVar // TypeDefIndex: 6893
{	// Methods

	// RVA: 0x22B02C0 Offset: 0x22AF6C0 VA: 0x1822B02C0
	public void .ctor() { }

}

public class Server : Server // TypeDefIndex: 7333
{	// Fields
	private Peer peer; // 0x68

	// Properties
	public override string ProtocolId { get; }
	public override bool AllowPassthroughMessages { get; }

	// Methods

	// RVA: 0x22CBEF0 Offset: 0x22CB2F0 VA: 0x1822CBEF0 Slot: 8
	public override string get_ProtocolId() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 9
	public override bool get_AllowPassthroughMessages() { }

	// RVA: 0xEE1BC0 Offset: 0xEE0FC0 VA: 0x180EE1BC0 Slot: 7
	public override bool IsConnected() { }

	// RVA: 0x22CBAE0 Offset: 0x22CAEE0 VA: 0x1822CBAE0 Slot: 10
	public override bool Start() { }

	// RVA: 0x22CBB70 Offset: 0x22CAF70 VA: 0x1822CBB70 Slot: 11
	public override void Stop(string shutdownMsg) { }

	// RVA: 0x22CB030 Offset: 0x22CA430 VA: 0x1822CB030 Slot: 13
	public override void Disconnect(Connection cn) { }

	// RVA: 0x22CB3D0 Offset: 0x22CA7D0 VA: 0x1822CB3D0 Slot: 14
	public override void Kick(Connection cn, string message, bool logfile) { }

	// RVA: 0x22CB180 Offset: 0x22CA580 VA: 0x1822CB180
	internal bool HandleRaknetPacket(byte type, Connection connection) { }

	// RVA: 0x22CBCD0 Offset: 0x22CB0D0 VA: 0x1822CBCD0
	internal void UnconnectedPacket() { }

	// RVA: 0x22CAA10 Offset: 0x22C9E10 VA: 0x1822CAA10
	internal void ConnectedPacket(Connection connection) { }

	// RVA: 0x22CACA0 Offset: 0x22CA0A0 VA: 0x1822CACA0 Slot: 12
	public override void Cycle() { }

	// RVA: 0x22CB5B0 Offset: 0x22CA9B0 VA: 0x1822CB5B0 Slot: 15
	protected override void OnNewConnection() { }

	// RVA: 0x22CB0D0 Offset: 0x22CA4D0 VA: 0x1822CB0D0 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22CB090 Offset: 0x22CA490 VA: 0x1822CB090 Slot: 17
	public override int GetAveragePing(Connection connection) { }

	// RVA: 0x22CB160 Offset: 0x22CA560 VA: 0x1822CB160 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22CB6B0 Offset: 0x22CAAB0 VA: 0x1822CB6B0 Slot: 18
	public override void SendUnconnected(uint netAddr, ushort netPort, byte[] data, int size) { }

	// RVA: 0x22CB900 Offset: 0x22CAD00 VA: 0x1822CB900 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22CB7A0 Offset: 0x22CABA0 VA: 0x1822CB7A0
	private void Send(SendInfo sendinfo, MemoryStream data, Connection connection) { }

	// RVA: 0x22CBE90 Offset: 0x22CB290 VA: 0x1822CBE90
	public void .ctor() { }

}

public class ServerConsole : SingletonComponent<ServerConsole> // TypeDefIndex: 9289
{	// Methods

	// RVA: 0x5AC8C0 Offset: 0x5ABCC0 VA: 0x1805AC8C0
	public void .ctor() { }

}

public class ServerGib : BaseCombatEntity // TypeDefIndex: 9604
{	// Fields
	public GameObject _gibSource; // 0x240
	public string _gibName; // 0x248
	public PhysicMaterial physicsMaterial; // 0x250
	private MeshCollider meshCollider; // 0x258
	private MeshFilter meshFilter; // 0x260
	private MeshRenderer meshRenderer; // 0x268
	private bool initialized; // 0x270

	// Methods

	// RVA: 0x5ACB80 Offset: 0x5ABF80 VA: 0x1805ACB80
	public MeshCollider GetCollider() { }

	// RVA: 0x5ACB90 Offset: 0x5ABF90 VA: 0x1805ACB90 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5AC930 Offset: 0x5ABD30 VA: 0x1805AC930
	public void ClientSetGib(string newgibname) { }

	// RVA: 0x5AC920 Offset: 0x5ABD20 VA: 0x1805AC920 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5ACFE0 Offset: 0x5AC3E0 VA: 0x1805ACFE0
	public void VisualsInit(Mesh mesh, Material[] materials) { }

	// RVA: 0x5ACBF0 Offset: 0x5ABFF0 VA: 0x1805ACBF0 Slot: 145
	public virtual void PhysicsInit(Mesh physicsMesh) { }

	// RVA: 0x499120 Offset: 0x498520 VA: 0x180499120
	public void .ctor() { }

}

public class ServerProjectile : EntityComponent<BaseEntity>, IServerComponent // TypeDefIndex: 9681
{	// Fields
	public Vector3 initialVelocity; // 0x20
	public float drag; // 0x2C
	public float gravityModifier; // 0x30
	public float speed; // 0x34
	public float scanRange; // 0x38
	public Vector3 swimScale; // 0x3C
	public Vector3 swimSpeed; // 0x48
	public float radius; // 0x54

	// Properties
	public virtual bool HasRangeLimit { get; }

	// Methods

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 10
	public virtual bool get_HasRangeLimit() { }

	// RVA: 0x5ADA30 Offset: 0x5ACE30 VA: 0x1805ADA30
	public float GetMaxRange(float maxFuseTime) { }

	// RVA: 0x5ADB20 Offset: 0x5ACF20 VA: 0x1805ADB20
	public void .ctor() { }

}

public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10711
{
// Namespace: 
public class ServerMgr : SingletonComponent<ServerMgr> // TypeDefIndex: 10711
	// Fields
	public const string BYPASS_PROCEDURAL_SPAWN_PREF = "bypassProceduralSpawn";

	// Methods

	// RVA: 0x5AD9D0 Offset: 0x5ACDD0 VA: 0x1805AD9D0
	public void .ctor() { }

}

public class ServerPerformance : BaseMonoBehaviour // TypeDefIndex: 10712
{	// Fields
	public static ulong deaths; // 0x0
	public static ulong spawns; // 0x8
	public static ulong position_changes; // 0x10

	// Methods

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class ServerBrowser : MonoBehaviour // TypeDefIndex: 11146
{	// Fields
	public string orderBy; // 0x18
	private string searchText; // 0x20
	private bool showFull; // 0x28
	private bool showEmpty; // 0x29
	private HashSet<string> searchTags; // 0x30
	private HashSet<string> excludeTags; // 0x38

	// Methods

	// RVA: 0x5AC0C0 Offset: 0x5AB4C0 VA: 0x1805AC0C0
	private void OnEnable() { }

	// RVA: 0x5ABFD0 Offset: 0x5AB3D0 VA: 0x1805ABFD0
	private void OnDisable() { }

	// RVA: 0x5AC1B0 Offset: 0x5AB5B0 VA: 0x1805AC1B0
	private void OnOpenStateChanged() { }

	// RVA: 0x5AC220 Offset: 0x5AB620 VA: 0x1805AC220
	public void RefreshAll() { }

	// RVA: 0x5ABEB0 Offset: 0x5AB2B0 VA: 0x1805ABEB0
	private void ClearAll() { }

	// RVA: 0x5AC350 Offset: 0x5AB750 VA: 0x1805AC350
	public void SetOrder(string strBy) { }

	// RVA: 0x5AC6A0 Offset: 0x5ABAA0 VA: 0x1805AC6A0
	public void SetShowFull(bool showFull) { }

	// RVA: 0x5AC5D0 Offset: 0x5AB9D0 VA: 0x1805AC5D0
	public void SetShowEmpty(bool showFull) { }

	// RVA: 0x5AC4E0 Offset: 0x5AB8E0 VA: 0x1805AC4E0
	public void SetSearchFilter(string txt) { }

	// RVA: 0x5AC770 Offset: 0x5ABB70 VA: 0x1805AC770
	public void SetTagsFilter(ServerBrowserTagFilters tagFilters) { }

	// RVA: 0x5AC860 Offset: 0x5ABC60 VA: 0x1805AC860
	public void .ctor() { }

}

public class ServerBrowserCategory : MonoBehaviour // TypeDefIndex: 11147
{	// Fields
	public LocalizeText serverCountText; // 0x18
	public ServerBrowserList browserList; // 0x20
	public bool isDirty; // 0x28

	// Methods

	// RVA: 0x49D360 Offset: 0x49C760 VA: 0x18049D360
	public void OnEnable() { }

	// RVA: 0x5A60D0 Offset: 0x5A54D0 VA: 0x1805A60D0
	public void Update() { }

	// RVA: 0x49D360 Offset: 0x49C760 VA: 0x18049D360
	public void Dirty() { }

	// RVA: 0x5A5E40 Offset: 0x5A5240 VA: 0x1805A5E40
	public void UpdateCounts() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class ServerBrowserCategory.<>c // TypeDefIndex: 11148
{	// Fields
	public static readonly ServerBrowserCategory.<>c <>9; // 0x0
	public static Func<ServerInfo, int> <>9__6_0; // 0x8

	// Methods

	// RVA: 0x5BE500 Offset: 0x5BD900 VA: 0x1805BE500
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE040 Offset: 0x5BD440 VA: 0x1805BE040
	internal int <UpdateCounts>b__6_0(ServerInfo x) { }

}

public class ServerBrowserInfo : SingletonComponent<ServerBrowserInfo> // TypeDefIndex: 11149
{	// Fields
	public bool isMain; // 0x18
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

	// Methods

	// RVA: 0x5A6F10 Offset: 0x5A6310 VA: 0x1805A6F10 Slot: 4
	public override void SingletonSetup() { }

	// RVA: 0x5A6740 Offset: 0x5A5B40 VA: 0x1805A6740
	public void Open(ServerInfo server) { }

	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	public void Close() { }

	// RVA: 0x5A62E0 Offset: 0x5A56E0 VA: 0x1805A62E0
	public void JoinServer() { }

	// RVA: 0x5A6120 Offset: 0x5A5520 VA: 0x1805A6120
	public void JoinDelayed() { }

	// RVA: 0x5A65D0 Offset: 0x5A59D0 VA: 0x1805A65D0
	public static void Join(ServerInfo server) { }

	// RVA: 0x5A6970 Offset: 0x5A5D70 VA: 0x1805A6970
	public void Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x99E60 Offset: 0x99260 VA: 0x180099E60
	// RVA: 0x5A68A0 Offset: 0x5A5CA0 VA: 0x1805A68A0
	private void QueryRules() { }

	// RVA: 0x5A60F0 Offset: 0x5A54F0 VA: 0x1805A60F0
	private void EnableRefreshButton() { }

	// RVA: 0x5A6F60 Offset: 0x5A6360 VA: 0x1805A6F60
	public void VisitWebpage() { }

	// RVA: 0x5A6F70 Offset: 0x5A6370 VA: 0x1805A6F70
	public void .ctor() { }

}

private struct ServerBrowserInfo.<QueryRules>d__19 : IAsyncStateMachine // TypeDefIndex: 11150
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ServerBrowserInfo <>4__this; // 0x28
	private bool <loadedImage>5__2; // 0x30
	private bool <loadedLogo>5__3; // 0x31
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0x38

	// Methods

	// RVA: 0xF3460 Offset: 0xF2860 VA: 0x1800F3460 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ServerBrowserItem : MonoBehaviour // TypeDefIndex: 11151
{	// Fields
	public TextMeshProUGUI serverName; // 0x18
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

	// Methods

	// RVA: 0x5A6FD0 Offset: 0x5A63D0 VA: 0x1805A6FD0
	private static string GetFriendOnServer(IPAddress addr, int port) { }

	// RVA: 0x5A75D0 Offset: 0x5A69D0 VA: 0x1805A75D0
	private static bool GetIsFavourite(IPAddress addr, int port) { }

	// RVA: 0x5A7810 Offset: 0x5A6C10 VA: 0x1805A7810
	internal void Init(ServerInfo s, bool isFavourites, bool isHistory) { }

	// RVA: 0x5A7D70 Offset: 0x5A7170 VA: 0x1805A7D70
	public void OnClicked() { }

	// RVA: 0x5A7EF0 Offset: 0x5A72F0 VA: 0x1805A7EF0
	public void OnFavouriteToggle(bool favourite) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class ServerBrowserItem.<>c // TypeDefIndex: 11152
{	// Fields
	public static readonly ServerBrowserItem.<>c <>9; // 0x0
	public static Func<IPlayerInfo, bool> <>9__8_0; // 0x8
	public static Func<IPlayerInfo, bool> <>9__8_1; // 0x10
	public static Func<IPlayerInfo, bool> <>9__8_2; // 0x18
	public static Func<IPlayerInfo, string> <>9__8_3; // 0x20
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_4; // 0x28
	public static Func<IPlayerInfo, string> <>9__8_6; // 0x30
	public static Func<IGrouping<string, IPlayerInfo>, string> <>9__8_5; // 0x38
	public static Func<ServerInfo, string> <>9__11_0; // 0x40

	// Methods

	// RVA: 0x5BE380 Offset: 0x5BD780 VA: 0x1805BE380
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BDD00 Offset: 0x5BD100 VA: 0x1805BDD00
	internal bool <GetFriendOnServer>b__8_0(IPlayerInfo x) { }

	// RVA: 0x5BDD50 Offset: 0x5BD150 VA: 0x1805BDD50
	internal bool <GetFriendOnServer>b__8_1(IPlayerInfo x) { }

	// RVA: 0x5BDDA0 Offset: 0x5BD1A0 VA: 0x1805BDDA0
	internal bool <GetFriendOnServer>b__8_2(IPlayerInfo x) { }

	// RVA: 0x5BDE00 Offset: 0x5BD200 VA: 0x1805BDE00
	internal string <GetFriendOnServer>b__8_3(IPlayerInfo x) { }

	// RVA: 0x5BDE50 Offset: 0x5BD250 VA: 0x1805BDE50
	internal string <GetFriendOnServer>b__8_4(IGrouping<string, IPlayerInfo> x) { }

	// RVA: 0x5BDEA0 Offset: 0x5BD2A0 VA: 0x1805BDEA0
	internal string <GetFriendOnServer>b__8_5(IGrouping<string, IPlayerInfo> x) { }

	// RVA: 0x5BDFB0 Offset: 0x5BD3B0 VA: 0x1805BDFB0
	internal string <GetFriendOnServer>b__8_6(IPlayerInfo y) { }

	// RVA: 0x5BDFC0 Offset: 0x5BD3C0 VA: 0x1805BDFC0
	internal string <GetIsFavourite>b__11_0(ServerInfo x) { }

}

public class ServerBrowserList : BaseMonoBehaviour, VirtualScroll.IDataSource // TypeDefIndex: 11153
{	// Fields
	public ServerBrowserList.QueryType queryType; // 0x18
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

	// Methods

	// RVA: 0x5A92E0 Offset: 0x5A86E0 VA: 0x1805A92E0
	public bool IsCheater() { }

	// RVA: 0x5A95B0 Offset: 0x5A89B0 VA: 0x1805A95B0
	public void Refresh() { }

	// RVA: 0x5AA490 Offset: 0x5A9890 VA: 0x1805AA490
	private void ServerResponded(ServerInfo server) { }

	// RVA: 0x5A91D0 Offset: 0x5A85D0 VA: 0x1805A91D0
	public void InitFilters(string searchFilter, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	// RVA: 0x5A9240 Offset: 0x5A8640 VA: 0x1805A9240
	public void Init() { }

	// RVA: 0x5A9400 Offset: 0x5A8800 VA: 0x1805A9400
	public void OnEnable() { }

	// RVA: 0x5A93B0 Offset: 0x5A87B0 VA: 0x1805A93B0
	public void OnDisable() { }

	// RVA: 0x5A8480 Offset: 0x5A7880 VA: 0x1805A8480
	public void Clear() { }

	// RVA: 0x5A80E0 Offset: 0x5A74E0 VA: 0x1805A80E0
	public void AddServer(ServerInfo server) { }

	// RVA: 0x5A9520 Offset: 0x5A8920 VA: 0x1805A9520
	public void Rebuild() { }

	// RVA: 0x5A8550 Offset: 0x5A7950 VA: 0x1805A8550
	internal IOrderedEnumerable<ServerInfo> GetSortedServers() { }

	// RVA: 0x5AAF30 Offset: 0x5AA330 VA: 0x1805AAF30
	public void Update() { }

	// RVA: 0x5AA300 Offset: 0x5A9700 VA: 0x1805AA300
	public void SearchFilter(string searchtext, bool showFull, bool showEmpty, HashSet<string> searchTags, HashSet<string> excludeTags) { }

	// RVA: 0x5A94F0 Offset: 0x5A88F0 VA: 0x1805A94F0
	public void OrderBy(string strBy) { }

	// RVA: 0x5AACA0 Offset: 0x5AA0A0 VA: 0x1805AACA0
	private void UpdateAllPlayerClamps() { }

	// RVA: 0x5A8370 Offset: 0x5A7770 VA: 0x1805A8370
	private static ServerInfo ClampPlayerCount(in ServerInfo server, int maxAllowedPlayers) { }

	// RVA: 0x5A8510 Offset: 0x5A7910 VA: 0x1805A8510 Slot: 6
	public int GetItemCount() { }

	// RVA: 0x5AAB70 Offset: 0x5A9F70 VA: 0x1805AAB70 Slot: 7
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x5AAFF0 Offset: 0x5AA3F0 VA: 0x1805AAFF0
	public void .ctor() { }

	// RVA: 0x5AAF80 Offset: 0x5AA380 VA: 0x1805AAF80
	private static void .cctor() { }

}

public enum ServerBrowserList.QueryType // TypeDefIndex: 11154
{	// Fields
	public int value__; // 0x0
	public const ServerBrowserList.QueryType RegularInternet = 0;
	public const ServerBrowserList.QueryType Friends = 1;
	public const ServerBrowserList.QueryType History = 2;
	public const ServerBrowserList.QueryType LAN = 3;
	public const ServerBrowserList.QueryType Favourites = 4;
	public const ServerBrowserList.QueryType None = 5;

}

public struct ServerBrowserList.ServerKeyvalues // TypeDefIndex: 11155
{	// Fields
	public string key; // 0x0
	public string value; // 0x8

}

public struct ServerBrowserList.Rules // TypeDefIndex: 11156
{	// Fields
	public string tag; // 0x0
	public ServerBrowserList serverList; // 0x8

}

private sealed class ServerBrowserList.<>c // TypeDefIndex: 11157
{	// Fields
	public static readonly ServerBrowserList.<>c <>9; // 0x0
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

	// Methods

	// RVA: 0x5BE3E0 Offset: 0x5BD7E0 VA: 0x1805BE3E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE100 Offset: 0x5BD500 VA: 0x1805BE100
	internal string <Refresh>b__11_0(Manifest.ServerDesc x) { }

	// RVA: 0x5BE060 Offset: 0x5BD460 VA: 0x1805BE060
	internal bool <GetSortedServers>b__41_1(ServerInfo x) { }

	// RVA: 0x5BE070 Offset: 0x5BD470 VA: 0x1805BE070
	internal bool <GetSortedServers>b__41_2(ServerInfo x) { }

	// RVA: 0x5BE050 Offset: 0x5BD450 VA: 0x1805BE050
	internal int <GetSortedServers>b__41_3(ServerInfo x) { }

	// RVA: 0x5BE080 Offset: 0x5BD480 VA: 0x1805BE080
	internal uint <GetSortedServers>b__41_5(ServerInfo x) { }

	// RVA: 0x5BE080 Offset: 0x5BD480 VA: 0x1805BE080
	internal uint <GetSortedServers>b__41_7(ServerInfo x) { }

	// RVA: 0x5BE020 Offset: 0x5BD420 VA: 0x1805BE020
	internal bool <GetSortedServers>b__41_8(ServerInfo x) { }

	// RVA: 0x5BE030 Offset: 0x5BD430 VA: 0x1805BE030
	internal uint <GetSortedServers>b__41_9(ServerInfo x) { }

	// RVA: 0x5BE020 Offset: 0x5BD420 VA: 0x1805BE020
	internal bool <GetSortedServers>b__41_10(ServerInfo x) { }

	// RVA: 0x5BE030 Offset: 0x5BD430 VA: 0x1805BE030
	internal uint <GetSortedServers>b__41_11(ServerInfo x) { }

	// RVA: 0x4CE710 Offset: 0x4CDB10 VA: 0x1804CE710
	internal string <GetSortedServers>b__41_12(ServerInfo x) { }

	// RVA: 0x4CE710 Offset: 0x4CDB10 VA: 0x1804CE710
	internal string <GetSortedServers>b__41_13(ServerInfo x) { }

	// RVA: 0x5BE040 Offset: 0x5BD440 VA: 0x1805BE040
	internal int <GetSortedServers>b__41_14(ServerInfo x) { }

	// RVA: 0x5BE040 Offset: 0x5BD440 VA: 0x1805BE040
	internal int <GetSortedServers>b__41_15(ServerInfo x) { }

	// RVA: 0x5BE050 Offset: 0x5BD450 VA: 0x1805BE050
	internal int <GetSortedServers>b__41_16(ServerInfo x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass12_0 // TypeDefIndex: 11158
{	// Fields
	public ServerBrowserList.Rules rule; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE170 Offset: 0x5BD570 VA: 0x1805BE170
	internal bool <ServerResponded>b__0(string x) { }

}

private sealed class ServerBrowserList.<>c__DisplayClass41_0 // TypeDefIndex: 11159
{	// Fields
	public ServerBrowserList <>4__this; // 0x10
	public int now; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE220 Offset: 0x5BD620 VA: 0x1805BE220
	internal bool <GetSortedServers>b__0(ServerInfo x) { }

	// RVA: 0x5BE300 Offset: 0x5BD700 VA: 0x1805BE300
	internal bool <GetSortedServers>b__4(ServerInfo x) { }

	// RVA: 0x5BE300 Offset: 0x5BD700 VA: 0x1805BE300
	internal bool <GetSortedServers>b__6(ServerInfo x) { }

}

public class ServerBrowserTag : MonoBehaviour // TypeDefIndex: 11160
{	// Fields
	public string[] serverHasAnyOf; // 0x18
	public string[] serverHasNoneOf; // 0x20
	public bool isToggleable; // 0x28
	public Color activeColor; // 0x2C
	public Color inactiveColor; // 0x3C
	public Image background; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsActive>k__BackingField; // 0x58

	// Properties
	public bool IsActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	private void set_IsActive(bool value) { }

	// RVA: 0x5ABC00 Offset: 0x5AB000 VA: 0x1805ABC00
	public void OnEnable() { }

	// RVA: 0x5ABCD0 Offset: 0x5AB0D0 VA: 0x1805ABCD0
	public bool Test(in ServerInfo serverInfo) { }

	// RVA: 0x5ABE00 Offset: 0x5AB200 VA: 0x1805ABE00
	public void Toggle() { }

	// RVA: 0x5ABC10 Offset: 0x5AB010 VA: 0x1805ABC10
	private void Refresh() { }

	// RVA: 0x5ABE20 Offset: 0x5AB220 VA: 0x1805ABE20
	public void .ctor() { }

}

public class ServerBrowserTagFilters : MonoBehaviour // TypeDefIndex: 11161
{	// Fields
	public RustButton Button; // 0x18
	public RectTransform OptionsParent; // 0x20
	public UnityEvent TagFiltersChanged; // 0x28
	private ServerBrowserTag[] _allTags; // 0x30
	private List<bool> _previousState; // 0x38

	// Methods

	// RVA: 0x5AB7A0 Offset: 0x5AABA0 VA: 0x1805AB7A0
	public void Start() { }

	// RVA: 0x5AB710 Offset: 0x5AAB10 VA: 0x1805AB710
	public void Open() { }

	// RVA: 0x5AB0E0 Offset: 0x5AA4E0 VA: 0x1805AB0E0
	public void Close() { }

	// RVA: 0x5AB4E0 Offset: 0x5AA8E0 VA: 0x1805AB4E0
	public void GetTags(out HashSet<string> searchTags, out HashSet<string> excludeTags) { }

	// RVA: 0x5AB3D0 Offset: 0x5AA7D0 VA: 0x1805AB3D0
	private List<bool> GetCurrentSelections() { }

	// RVA: 0x5ABA00 Offset: 0x5AAE00 VA: 0x1805ABA00
	public void .ctor() { }

}

private sealed class ServerBrowserTagFilters.<>c // TypeDefIndex: 11162
{	// Fields
	public static readonly ServerBrowserTagFilters.<>c <>9; // 0x0
	public static Func<bool, bool> <>9__7_0; // 0x8
	public static Func<ServerBrowserTag, bool> <>9__9_0; // 0x10

	// Methods

	// RVA: 0x5BE440 Offset: 0x5BD840 VA: 0x1805BE440
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BDC70 Offset: 0x5BD070 VA: 0x1805BDC70
	internal bool <Close>b__7_0(bool b) { }

	// RVA: 0x5BDCE0 Offset: 0x5BD0E0 VA: 0x1805BDCE0
	internal bool <GetCurrentSelections>b__9_0(ServerBrowserTag t) { }

}

public class ServerBrowserTagList : MonoBehaviour // TypeDefIndex: 11163
{	// Fields
	private ServerBrowserTag[] _allTags; // 0x18

	// Methods

	// RVA: 0x5ABA70 Offset: 0x5AAE70 VA: 0x1805ABA70
	private void Initialize() { }

	// RVA: 0x5ABA70 Offset: 0x5AAE70 VA: 0x1805ABA70
	public void Awake() { }

	// RVA: 0x5ABAD0 Offset: 0x5AAED0 VA: 0x1805ABAD0
	public bool Refresh(ServerInfo server) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ServerHistory : MonoBehaviour // TypeDefIndex: 11164
{	// Fields
	public ServerHistoryItem prefab; // 0x18
	public GameObject panelList; // 0x20
	internal IServerQuery Request; // 0x28

	// Methods

	// RVA: 0x5AD680 Offset: 0x5ACA80 VA: 0x1805AD680
	private void Start() { }

	[AsyncStateMachineAttribute] // RVA: 0x9AD60 Offset: 0x9A160 VA: 0x18009AD60
	// RVA: 0x5AD680 Offset: 0x5ACA80 VA: 0x1805AD680
	public Task Refresh() { }

	// RVA: 0x5AD410 Offset: 0x5AC810 VA: 0x1805AD410
	private void OnServer(ServerInfo server) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private struct ServerHistory.<Refresh>d__4 : IAsyncStateMachine // TypeDefIndex: 11165
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ServerHistory <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0xF3540 Offset: 0xF2940 VA: 0x1800F3540 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class ServerHistory.<>c // TypeDefIndex: 11166
{	// Fields
	public static readonly ServerHistory.<>c <>9; // 0x0
	public static Func<Transform, object> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x5BE560 Offset: 0x5BD960 VA: 0x1805BE560
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5BE090 Offset: 0x5BD490 VA: 0x1805BE090
	internal object <OnServer>b__5_0(Transform x) { }

}

public class ServerHistoryItem : MonoBehaviour // TypeDefIndex: 11167
{	// Fields
	private ServerInfo serverInfo; // 0x18
	public Text serverName; // 0x90
	public Text players; // 0x98
	public Text lastJoinDate; // 0xA0
	public uint order; // 0xA8

	// Methods

	// RVA: 0x5AD1A0 Offset: 0x5AC5A0 VA: 0x1805AD1A0
	internal void Setup(ServerInfo s) { }

	// RVA: 0x5AD0D0 Offset: 0x5AC4D0 VA: 0x1805AD0D0
	public void Open() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public static class ServerInfoHelpers // TypeDefIndex: 11168
{	// Methods

	[AsyncStateMachineAttribute] // RVA: 0x9B140 Offset: 0x9A540 VA: 0x18009B140
	// RVA: 0x5AD8B0 Offset: 0x5ACCB0 VA: 0x1805AD8B0
	public static Task<Nullable<ServerInfo>> Load(string address, int port) { }

	[AsyncStateMachineAttribute] // RVA: 0x9B2F0 Offset: 0x9A6F0 VA: 0x18009B2F0
	// RVA: 0x5AD770 Offset: 0x5ACB70 VA: 0x1805AD770
	public static Task<Dictionary<string, string>> LoadRules(ServerInfo serverInfo) { }

}

private struct ServerInfoHelpers.<Load>d__0 : IAsyncStateMachine // TypeDefIndex: 11169
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<ServerInfo>> <>t__builder; // 0x8
	public string address; // 0x20
	public int port; // 0x28
	private List<string> <endpointSet>5__2; // 0x30
	private int <i>5__3; // 0x38
	private IServerQuery <query>5__4; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0xF3400 Offset: 0xF2800 VA: 0x1800F3400 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3410 Offset: 0xF2810 VA: 0x1800F3410 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct ServerInfoHelpers.<LoadRules>d__1 : IAsyncStateMachine // TypeDefIndex: 11170
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Dictionary<string, string>> <>t__builder; // 0x8
	public ServerInfo serverInfo; // 0x20
	private Dictionary<string, string> <rules>5__2; // 0x98
	private int <i>5__3; // 0xA0
	private TaskAwaiter<Dictionary<string, string>> <>u__1; // 0xA8
	private TaskAwaiter <>u__2; // 0xB0

	// Methods

	// RVA: 0xF33A0 Offset: 0xF27A0 VA: 0x1800F33A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF33B0 Offset: 0xF27B0 VA: 0x1800F33B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class Server // TypeDefIndex: 11647
{	// Fields
	public const byte Default = 0;
	public const byte Positions = 14;

}

public class Server : ConsoleSystem // TypeDefIndex: 11956
{	// Fields
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
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

	// Methods

	// RVA: 0x369580 Offset: 0x368980 VA: 0x180369580
	public static float TickDelta() { }

	// RVA: 0x3695F0 Offset: 0x3689F0 VA: 0x1803695F0
	public static float TickTime(uint tick) { }

	// RVA: 0x36A060 Offset: 0x369460 VA: 0x18036A060
	public void .ctor() { }

	// RVA: 0x3696C0 Offset: 0x368AC0 VA: 0x1803696C0
	private static void .cctor() { }

}

