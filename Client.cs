internal class ClientIdentity : Identity // TypeDefIndex: 1134
{	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0xFDB720 Offset: 0xFDAB20 VA: 0x180FDB720
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0xFDB7F0 Offset: 0xFDABF0 VA: 0x180FDB7F0
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0xFDB8C0 Offset: 0xFDACC0 VA: 0x180FDB8C0
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0xFDB890 Offset: 0xFDAC90 VA: 0x180FDB890
	public string get_TargetUri() { }

}

internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 1146
{	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0xFDB700 Offset: 0xFDAB00 VA: 0x180FDB700
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0xFDB600 Offset: 0xFDAA00 VA: 0x180FDB600 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0xFDB660 Offset: 0xFDAA60 VA: 0x180FDB660 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0xFDB4E0 Offset: 0xFDA8E0 VA: 0x180FDB4E0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 1230
{	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(Context ctx) { }

	// RVA: 0x146CEA0 Offset: 0x146C2A0 VA: 0x18146CEA0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x146CBE0 Offset: 0x146BFE0 VA: 0x18146CBE0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 1231
{	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0xFD7210 Offset: 0xFD6610 VA: 0x180FD7210
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x146CAF0 Offset: 0x146BEF0 VA: 0x18146CAF0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x146CAA0 Offset: 0x146BEA0 VA: 0x18146CAA0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal struct ClientGameServerDeny_t : ICallbackData // TypeDefIndex: 5296
{	// Fields
	internal uint AppID; // 0x0
	internal uint GameServerIP; // 0x4
	internal ushort GameServerPort; // 0x8
	internal ushort Secure; // 0xA
	internal uint Reason; // 0xC
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4590 Offset: 0x1E3990 VA: 0x1801E4590 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4580 Offset: 0x1E3980 VA: 0x1801E4580 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1368D30 Offset: 0x1368130 VA: 0x181368D30
	private static void .cctor() { }

}

public class ClientReady : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6494
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ClientReady.ClientInfo> clientInfo; // 0x18

	// Methods

	// RVA: 0x20A6A50 Offset: 0x20A5E50 VA: 0x1820A6A50
	public static void ResetToPool(ClientReady instance) { }

	// RVA: 0x20A68A0 Offset: 0x20A5CA0 VA: 0x1820A68A0
	public void ResetToPool() { }

	// RVA: 0x20A6620 Offset: 0x20A5A20 VA: 0x1820A6620 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A58E0 Offset: 0x20A4CE0 VA: 0x1820A58E0
	public void CopyTo(ClientReady instance) { }

	// RVA: 0x20A5A90 Offset: 0x20A4E90 VA: 0x1820A5A90
	public ClientReady Copy() { }

	// RVA: 0x20A6190 Offset: 0x20A5590 VA: 0x1820A6190
	public static ClientReady Deserialize(Stream stream) { }

	// RVA: 0x20A5B10 Offset: 0x20A4F10 VA: 0x1820A5B10
	public static ClientReady DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A5E60 Offset: 0x20A5260 VA: 0x1820A5E60
	public static ClientReady DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A6500 Offset: 0x20A5900 VA: 0x1820A6500
	public static ClientReady Deserialize(byte[] buffer) { }

	// RVA: 0x20A6860 Offset: 0x20A5C60 VA: 0x1820A6860
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A7190 Offset: 0x20A6590 VA: 0x1820A7190 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A71B0 Offset: 0x20A65B0 VA: 0x1820A71B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ClientReady previous) { }

	// RVA: 0x20A6880 Offset: 0x20A5C80 VA: 0x1820A6880 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A6400 Offset: 0x20A5800 VA: 0x1820A6400
	public static ClientReady Deserialize(byte[] buffer, ClientReady instance, bool isDelta = False) { }

	// RVA: 0x20A6210 Offset: 0x20A5610 VA: 0x1820A6210
	public static ClientReady Deserialize(Stream stream, ClientReady instance, bool isDelta) { }

	// RVA: 0x20A5B90 Offset: 0x20A4F90 VA: 0x1820A5B90
	public static ClientReady DeserializeLengthDelimited(Stream stream, ClientReady instance, bool isDelta) { }

	// RVA: 0x20A5EF0 Offset: 0x20A52F0 VA: 0x1820A5EF0
	public static ClientReady DeserializeLength(Stream stream, int length, ClientReady instance, bool isDelta) { }

	// RVA: 0x20A6C00 Offset: 0x20A6000 VA: 0x1820A6C00
	public static void SerializeDelta(Stream stream, ClientReady instance, ClientReady previous) { }

	// RVA: 0x20A6FA0 Offset: 0x20A63A0 VA: 0x1820A6FA0
	public static void Serialize(Stream stream, ClientReady instance) { }

	// RVA: 0x20A7180 Offset: 0x20A6580 VA: 0x1820A7180
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A7190 Offset: 0x20A6590 VA: 0x1820A7190
	public void ToProto(Stream stream) { }

	// RVA: 0x20A6E90 Offset: 0x20A6290 VA: 0x1820A6E90
	public static byte[] SerializeToBytes(ClientReady instance) { }

	// RVA: 0x20A6DE0 Offset: 0x20A61E0 VA: 0x1820A6DE0
	public static void SerializeLengthDelimited(Stream stream, ClientReady instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class ClientReady.ClientInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6495
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public string value; // 0x20

	// Methods

	// RVA: 0x20A5170 Offset: 0x20A4570 VA: 0x1820A5170
	public static void ResetToPool(ClientReady.ClientInfo instance) { }

	// RVA: 0x20A5230 Offset: 0x20A4630 VA: 0x1820A5230
	public void ResetToPool() { }

	// RVA: 0x20A50B0 Offset: 0x20A44B0 VA: 0x1820A50B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20A45D0 Offset: 0x20A39D0 VA: 0x1820A45D0
	public void CopyTo(ClientReady.ClientInfo instance) { }

	// RVA: 0x20A4620 Offset: 0x20A3A20 VA: 0x1820A4620
	public ClientReady.ClientInfo Copy() { }

	// RVA: 0x20A5030 Offset: 0x20A4430 VA: 0x1820A5030
	public static ClientReady.ClientInfo Deserialize(Stream stream) { }

	// RVA: 0x20A46B0 Offset: 0x20A3AB0 VA: 0x1820A46B0
	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20A49A0 Offset: 0x20A3DA0 VA: 0x1820A49A0
	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20A4E10 Offset: 0x20A4210 VA: 0x1820A4E10
	public static ClientReady.ClientInfo Deserialize(byte[] buffer) { }

	// RVA: 0x20A5130 Offset: 0x20A4530 VA: 0x1820A5130
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20A58A0 Offset: 0x20A4CA0 VA: 0x1820A58A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20A58C0 Offset: 0x20A4CC0 VA: 0x1820A58C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ClientReady.ClientInfo previous) { }

	// RVA: 0x20A5150 Offset: 0x20A4550 VA: 0x1820A5150 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20A4F30 Offset: 0x20A4330 VA: 0x1820A4F30
	public static ClientReady.ClientInfo Deserialize(byte[] buffer, ClientReady.ClientInfo instance, bool isDelta = False) { }

	// RVA: 0x20A4C80 Offset: 0x20A4080 VA: 0x1820A4C80
	public static ClientReady.ClientInfo Deserialize(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20A4730 Offset: 0x20A3B30 VA: 0x1820A4730
	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20A4A30 Offset: 0x20A3E30 VA: 0x1820A4A30
	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length, ClientReady.ClientInfo instance, bool isDelta) { }

	// RVA: 0x20A52F0 Offset: 0x20A46F0 VA: 0x1820A52F0
	public static void SerializeDelta(Stream stream, ClientReady.ClientInfo instance, ClientReady.ClientInfo previous) { }

	// RVA: 0x20A56C0 Offset: 0x20A4AC0 VA: 0x1820A56C0
	public static void Serialize(Stream stream, ClientReady.ClientInfo instance) { }

	// RVA: 0x20A5890 Offset: 0x20A4C90 VA: 0x1820A5890
	public byte[] ToProtoBytes() { }

	// RVA: 0x20A58A0 Offset: 0x20A4CA0 VA: 0x1820A58A0
	public void ToProto(Stream stream) { }

	// RVA: 0x20A55B0 Offset: 0x20A49B0 VA: 0x1820A55B0
	public static byte[] SerializeToBytes(ClientReady.ClientInfo instance) { }

	// RVA: 0x20A5500 Offset: 0x20A4900 VA: 0x1820A5500
	public static void SerializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Client : BaseNetwork // TypeDefIndex: 6687
{	// Fields
	public static float MaxReceiveTime; // 0x0
	public static float MinReceiveFraction; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Connection <Connection>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly bool <IsPlaying>k__BackingField; // 0x30
	public Manager visibility; // 0x38
	public static string disconnectReason; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ConnectedAddress>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ConnectedPort>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <ServerName>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsOfficialServer>k__BackingField; // 0x58
	public Stats IncomingStats; // 0x60
	public IClientCallback callbackHandler; // 0x68

	// Properties
	public Connection Connection { get; set; }
	public virtual bool IsPlaying { get; }
	public string ConnectedAddress { get; set; }
	public int ConnectedPort { get; set; }
	public string ServerName { get; set; }
	public bool IsOfficialServer { get; set; }
	public bool IsRecording { get; }
	public string RecordFilename { get; }
	public TimeSpan RecordTimeElapsed { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	protected void set_Connection(Connection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8298F0 Offset: 0x828CF0 VA: 0x1808298F0 Slot: 7
	public virtual bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public string get_ConnectedAddress() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_ConnectedAddress(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public int get_ConnectedPort() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	public void set_ConnectedPort(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public string get_ServerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	public void set_ServerName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_IsOfficialServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	public void set_IsOfficialServer(bool value) { }

	// RVA: 0x2207D20 Offset: 0x2207120 VA: 0x182207D20 Slot: 8
	public virtual bool Connect(string strURL, int port) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public virtual void Cycle() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public virtual void Disconnect(string reason, bool sendReasonToServer = True) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 11
	public virtual bool IsConnected() { }

	// RVA: 0x2207ED0 Offset: 0x22072D0 VA: 0x182207ED0
	protected void OnDisconnected(string str) { }

	// RVA: 0x2207D90 Offset: 0x2207190 VA: 0x182207D90
	public Networkable CreateNetworkable(uint networkID, uint networkGroup) { }

	// RVA: 0x2207E40 Offset: 0x2207240 VA: 0x182207E40
	public void DestroyNetworkable(ref Networkable networkable) { }

	// RVA: 0x2207F90 Offset: 0x2207390 VA: 0x182207F90
	public void SetupNetworkable(Networkable net) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 12
	public virtual int GetLastPing() { }

	// RVA: 0x22082C0 Offset: 0x22076C0 VA: 0x1822082C0
	public bool get_IsRecording() { }

	// RVA: 0xF9BAA0 Offset: 0xF9AEA0 VA: 0x180F9BAA0
	public string get_RecordFilename() { }

	// RVA: 0x22082E0 Offset: 0x22076E0 VA: 0x1822082E0
	public TimeSpan get_RecordTimeElapsed() { }

	// RVA: 0x2207FC0 Offset: 0x22073C0 VA: 0x182207FC0
	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	// RVA: 0x22080E0 Offset: 0x22074E0 VA: 0x1822080E0
	public void StopRecording() { }

	// RVA: 0x2208150 Offset: 0x2207550 VA: 0x182208150
	public void .ctor() { }

	// RVA: 0x2208100 Offset: 0x2207500 VA: 0x182208100
	private static void .cctor() { }

}

public class ClientVar : ConsoleVar // TypeDefIndex: 6894
{	// Methods

	// RVA: 0x22ACC10 Offset: 0x22AC010 VA: 0x1822ACC10
	public void .ctor() { }

}

public enum ClientIntegrityViolationType // TypeDefIndex: 7140
{	// Fields
	public int value__; // 0x0
	public const ClientIntegrityViolationType IntegrityViolationNone = 0;
	public const ClientIntegrityViolationType EACHashCatalogueFileNotFound = 1;
	public const ClientIntegrityViolationType EACHashCatalogueError = 2;
	public const ClientIntegrityViolationType EACHashCatalogueCertificateRevoked = 3;
	public const ClientIntegrityViolationType UnknownGameFileVersion = 4;
	public const ClientIntegrityViolationType RequiredGameFileNotFound = 5;
	public const ClientIntegrityViolationType UncataloguedGameFileForbidden = 6;
	public const ClientIntegrityViolationType UnknownSystemFileVersion = 7;
	public const ClientIntegrityViolationType ForbiddenModuleLoaded = 8;
	public const ClientIntegrityViolationType CorruptedMemory = 9;
	public const ClientIntegrityViolationType HackToolDetected = 10;
	public const ClientIntegrityViolationType InternalAntiCheatViolation = 11;
	public const ClientIntegrityViolationType CorruptedNetworkMessageFlow = 12;
	public const ClientIntegrityViolationType CannotRunUnderVirtualMachine = 13;
	public const ClientIntegrityViolationType ForbiddenSystemConfiguration = 14;

}

public class Client : Client // TypeDefIndex: 7331
{	// Fields
	private Peer peer; // 0x70
	public static byte[] ReusableBytes; // 0x0
	private Stopwatch cycleTimer; // 0x78

	// Methods

	// RVA: 0x22C7350 Offset: 0x22C6750 VA: 0x1822C7350 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x22C6040 Offset: 0x22C5440 VA: 0x1822C6040 Slot: 8
	public override bool Connect(string strURL, int port) { }

	// RVA: 0x22C6DD0 Offset: 0x22C61D0 VA: 0x1822C6DD0
	internal bool HandleRaknetPacket(byte type) { }

	// RVA: 0x22C67B0 Offset: 0x22C5BB0 VA: 0x1822C67B0
	protected void HandleMessage() { }

	// RVA: 0x22C6150 Offset: 0x22C5550 VA: 0x1822C6150 Slot: 9
	public override void Cycle() { }

	// RVA: 0x22C6570 Offset: 0x22C5970 VA: 0x1822C6570 Slot: 10
	public override void Disconnect(string reason, bool sendReasonToServer) { }

	// RVA: 0x22C66D0 Offset: 0x22C5AD0 VA: 0x1822C66D0 Slot: 5
	public override string GetDebug(Connection connection) { }

	// RVA: 0x22C6790 Offset: 0x22C5B90 VA: 0x1822C6790 Slot: 6
	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x22C6750 Offset: 0x22C5B50 VA: 0x1822C6750 Slot: 12
	public override int GetLastPing() { }

	// RVA: 0x22C7360 Offset: 0x22C6760 VA: 0x1822C7360 Slot: 4
	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	// RVA: 0x22C7500 Offset: 0x22C6900 VA: 0x1822C7500
	public void .ctor() { }

	// RVA: 0x22C74B0 Offset: 0x22C68B0 VA: 0x1822C74B0
	private static void .cctor() { }

}

public class ClientIOLine : BaseMonoBehaviour // TypeDefIndex: 8884
{	// Fields
	public RendererLOD _lod; // 0x18
	public LineRenderer _line; // 0x20
	public Material directionalMaterial; // 0x28
	public Material defaultMaterial; // 0x30
	public IOEntity.IOType lineType; // 0x38
	public static List<ClientIOLine> _allLines; // 0x0
	public WireTool.WireColour colour; // 0x3C
	public IOEntity ownerIOEnt; // 0x40

	// Properties
	public int PositionCount { get; }

	// Methods

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void SetIOEntityOwner(IOEntity newOwner) { }

	// RVA: 0x589D80 Offset: 0x589180 VA: 0x180589D80
	public void OnEnable() { }

	// RVA: 0x589CF0 Offset: 0x5890F0 VA: 0x180589CF0
	public void OnDisable() { }

	// RVA: 0x589E80 Offset: 0x589280 VA: 0x180589E80
	public static void SetDirectionVisibleAll(bool isVisible, IOEntity.IOType forType) { }

	// RVA: 0x589FE0 Offset: 0x5893E0 VA: 0x180589FE0
	public static void SetDirectionVisibleSingle(bool isVisible, ClientIOLine line) { }

	// RVA: 0x5897C0 Offset: 0x588BC0 VA: 0x1805897C0
	public void Clear() { }

	// RVA: 0x5897F0 Offset: 0x588BF0 VA: 0x1805897F0
	public void DelayedDirectionTest() { }

	// RVA: 0x58A160 Offset: 0x589560 VA: 0x18058A160
	public void SetDirectionVisible(bool isVisible) { }

	// RVA: 0x58A3F0 Offset: 0x5897F0 VA: 0x18058A3F0
	public void SetVisible(bool isVisible) { }

	// RVA: 0x58A310 Offset: 0x589710 VA: 0x18058A310
	public void SetLineCullDistance(float length) { }

	// RVA: 0x58A360 Offset: 0x589760 VA: 0x18058A360
	public void SetPositions(Vector3[] positions, float[] slackLevels) { }

	// RVA: 0x5896D0 Offset: 0x588AD0 VA: 0x1805896D0
	public void AddPosition(Vector3 worldPos) { }

	// RVA: 0x58A240 Offset: 0x589640 VA: 0x18058A240
	public void SetLastNodePosition(Vector3 worldPos) { }

	// RVA: 0x589E10 Offset: 0x589210 VA: 0x180589E10
	public void RemoveLastPosition() { }

	// RVA: 0x589B40 Offset: 0x588F40 VA: 0x180589B40
	public float GetLength() { }

	// RVA: 0x58A4A0 Offset: 0x5898A0 VA: 0x18058A4A0
	public void UpdateBoundsAndPosition() { }

	// RVA: 0x589A30 Offset: 0x588E30 VA: 0x180589A30
	public Vector3 GetLastPlacedNodePosition() { }

	// RVA: 0x58A520 Offset: 0x589920 VA: 0x18058A520
	public int get_PositionCount() { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

	// RVA: 0x58A4C0 Offset: 0x5898C0 VA: 0x18058A4C0
	private static void .cctor() { }

}

public class Client : SingletonComponent<Client>, IClientCallback // TypeDefIndex: 9143
{	// Fields
	public static Translate.Phrase loading_loading; // 0x0
	public static Translate.Phrase loading_connecting; // 0x8
	public static Translate.Phrase loading_connectionaccepted; // 0x10
	public static Translate.Phrase loading_connecting_negotiate; // 0x18
	public static Translate.Phrase loading_level; // 0x20
	public static Translate.Phrase loading_skinnablewarmup; // 0x28
	public static Translate.Phrase loading_preloadcomplete; // 0x30
	public static Translate.Phrase loading_openingscene; // 0x38
	public static Translate.Phrase loading_clientready; // 0x40
	public static Translate.Phrase loading_prefabwarmup; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnConnected; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action OnDisconnected; // 0x58
	private IAuthTicket authTicket; // 0x18
	private IEnumerator currentCoroutine; // 0x20
	private bool connectionRetry; // 0x28
	private static Client.ConnectionProtocol[] config_raknet; // 0x60
	private static Client.ConnectionProtocol[] config_steamworks; // 0x68
	private static Client.ConnectionProtocol[] config_default; // 0x70
	private static Mesh _cubeMesh; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <IsScrubbingDemo>k__BackingField; // 0x80
	public static ulong DemoLocalClient; // 0x88
	private static Reader Demo; // 0x90
	private static float PreDemoPhysicsSteps; // 0x98
	private const float demoTickDistSq = 2500;
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static BasePlayer <DemoSpectatePlayer>k__BackingField; // 0xA0
	public static BaseEntity CurrentEntity; // 0xA8
	public HashSet<uint> subscriptions; // 0x30
	private const long EntityPositionPacketSize = 36;
	private const long EntityFlagsPacketSize = 8;
	private static EventSystem _eventsystem; // 0xB0
	private float LastConfigSaveTime; // 0x38
	private Stopwatch ngTimer; // 0x40

	// Properties
	private bool StatsEnabled { get; }
	public static bool IsPlayingDemo { get; }
	public static bool IsRecordingDemo { get; }
	public static bool IsScrubbingDemo { get; set; }
	public static TimeSpan RecordingTimeElapsed { get; }
	public static string RecordingFilename { get; }
	public static BasePlayer DemoLocalPlayer { get; }
	public static TimeSpan DemoProgress { get; }
	public static TimeSpan DemoLength { get; }
	public static float DemoNormalizedTime { get; }
	public static string DemoName { get; }
	public static DateTime DemoRecordedTime { get; }
	public static BasePlayer DemoSpectatePlayer { get; set; }
	public static EventSystem EventSystem { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x55F7B0 Offset: 0x55EBB0 VA: 0x18055F7B0
	public static void add_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5601C0 Offset: 0x55F5C0 VA: 0x1805601C0
	public static void remove_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x55F8B0 Offset: 0x55ECB0 VA: 0x18055F8B0
	public static void add_OnDisconnected(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5602C0 Offset: 0x55F6C0 VA: 0x1805602C0
	public static void remove_OnDisconnected(Action value) { }

	// RVA: 0x560100 Offset: 0x55F500 VA: 0x180560100
	private bool get_StatsEnabled() { }

	// RVA: 0x55D250 Offset: 0x55C650 VA: 0x18055D250
	private void RegisterIncoming(string type, long bytes) { }

	// RVA: 0x55D390 Offset: 0x55C790 VA: 0x18055D390
	private void RegisterIncoming(string type, string entity, long bytes) { }

	// RVA: 0x55B870 Offset: 0x55AC70 VA: 0x18055B870 Slot: 8
	public void OnNetworkMessage(Message packet) { }

	// RVA: 0x55B730 Offset: 0x55AB30 VA: 0x18055B730
	private void OnMessage(Message packet) { }

	// RVA: 0x55CBC0 Offset: 0x55BFC0 VA: 0x18055CBC0
	private void OnRequestUserInformation(Message packet) { }

	// RVA: 0x559080 Offset: 0x558480 VA: 0x180559080
	private void OnApproved(Message packet) { }

	// RVA: 0x55C830 Offset: 0x55BC30 VA: 0x18055C830
	private void OnRPCMessage(Message packet) { }

	// RVA: 0x5586B0 Offset: 0x557AB0 VA: 0x1805586B0
	private string GetOSName() { }

	// RVA: 0x5556B0 Offset: 0x554AB0 VA: 0x1805556B0
	public void CancelAuthTicket() { }

	// RVA: 0x5584E0 Offset: 0x5578E0 VA: 0x1805584E0
	public IAuthTicket GetAuthTicket(bool cancelOld = True) { }

	// RVA: 0x555770 Offset: 0x554B70 VA: 0x180555770
	private void CancelLoading() { }

	// RVA: 0x55DC80 Offset: 0x55D080 VA: 0x18055DC80
	private Coroutine StartLoading(IEnumerator coroutine) { }

	[AsyncStateMachineAttribute] // RVA: 0xD2100 Offset: 0xD1500 VA: 0x1800D2100
	// RVA: 0x555A10 Offset: 0x554E10 VA: 0x180555A10
	public Task Connect(string strAddress, int port, string protocol, bool hideIpAddress = False) { }

	// RVA: 0x557A90 Offset: 0x556E90 VA: 0x180557A90
	private void DestroyNetworkables() { }

	[IteratorStateMachineAttribute] // RVA: 0xD2280 Offset: 0xD1680 VA: 0x1800D2280
	// RVA: 0x557CB0 Offset: 0x5570B0 VA: 0x180557CB0
	private IEnumerator DoClientConnected(Approval msg) { }

	// RVA: 0x5592B0 Offset: 0x5586B0 VA: 0x1805592B0 Slot: 9
	public void OnClientDisconnected(string strReason) { }

	// RVA: 0x555820 Offset: 0x554C20 VA: 0x180555820
	public static void ClientCleanup() { }

	// RVA: 0x5594F0 Offset: 0x5588F0 VA: 0x1805594F0
	private static void OnConsoleReplicatedVars(Message packet) { }

	// RVA: 0x55D940 Offset: 0x55CD40 VA: 0x18055D940
	private static void SetReplicatedVar(string fullName, string value) { }

	// RVA: 0x55D590 Offset: 0x55C990 VA: 0x18055D590
	private void RunDebugCommands() { }

	// RVA: 0x557D40 Offset: 0x557140 VA: 0x180557D40
	private void DrawColliders() { }

	// RVA: 0x55E760 Offset: 0x55DB60 VA: 0x18055E760
	private void UpdateNetgraph() { }

	// RVA: 0x558590 Offset: 0x557990 VA: 0x180558590
	private Stats GetCurrentNetworkStats() { }

	// RVA: 0x55FF60 Offset: 0x55F360 VA: 0x18055FF60
	public static bool get_IsPlayingDemo() { }

	// RVA: 0x55FFB0 Offset: 0x55F3B0 VA: 0x18055FFB0
	public static bool get_IsRecordingDemo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x560000 Offset: 0x55F400 VA: 0x180560000
	public static bool get_IsScrubbingDemo() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5604A0 Offset: 0x55F8A0 VA: 0x1805604A0
	public static void set_IsScrubbingDemo(bool value) { }

	// RVA: 0x5600B0 Offset: 0x55F4B0 VA: 0x1805600B0
	public static TimeSpan get_RecordingTimeElapsed() { }

	// RVA: 0x560060 Offset: 0x55F460 VA: 0x180560060
	public static string get_RecordingFilename() { }

	// RVA: 0x55FA30 Offset: 0x55EE30 VA: 0x18055FA30
	public static BasePlayer get_DemoLocalPlayer() { }

	// RVA: 0x55FBF0 Offset: 0x55EFF0 VA: 0x18055FBF0
	public static TimeSpan get_DemoProgress() { }

	// RVA: 0x55F9B0 Offset: 0x55EDB0 VA: 0x18055F9B0
	public static TimeSpan get_DemoLength() { }

	// RVA: 0x55FB30 Offset: 0x55EF30 VA: 0x18055FB30
	public static float get_DemoNormalizedTime() { }

	// RVA: 0x55FAC0 Offset: 0x55EEC0 VA: 0x18055FAC0
	public static string get_DemoName() { }

	// RVA: 0x55FC90 Offset: 0x55F090 VA: 0x18055FC90
	public static DateTime get_DemoRecordedTime() { }

	// RVA: 0x55DD60 Offset: 0x55D160 VA: 0x18055DD60
	public void StartPlayingDemo(Reader demo, bool inPlace) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2600 Offset: 0xD1A00 VA: 0x1800D2600
	// RVA: 0x55DCC0 Offset: 0x55D0C0 VA: 0x18055DCC0
	private IEnumerator StartPlayingDemoInternal(Reader demo, bool inPlace) { }

	// RVA: 0x559600 Offset: 0x558A00 VA: 0x180559600
	private void OnDemoKeyframe(Indexer.Keyframe keyframe, HashSet<uint> changedEnts) { }

	// RVA: 0x55E110 Offset: 0x55D510 VA: 0x18055E110
	public void StopRecordingDemo() { }

	// RVA: 0x55DE10 Offset: 0x55D210 VA: 0x18055DE10
	public void StopPlayingDemo(bool finished = False) { }

	// RVA: 0x556CD0 Offset: 0x5560D0 VA: 0x180556CD0
	private void DemoFrame() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x55FD40 Offset: 0x55F140 VA: 0x18055FD40
	public static BasePlayer get_DemoSpectatePlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5603C0 Offset: 0x55F7C0 VA: 0x1805603C0
	private static void set_DemoSpectatePlayer(BasePlayer value) { }

	// RVA: 0x5578E0 Offset: 0x556CE0 VA: 0x1805578E0
	private void DemoSpectateNextPlayer(bool forward) { }

	// RVA: 0x557220 Offset: 0x556620 VA: 0x180557220
	private void DemoLateUpdate(bool isLastCall) { }

	// RVA: 0x557750 Offset: 0x556B50 VA: 0x180557750
	private void DemoPlayerTick(PlayerTick playerTick) { }

	// RVA: 0x55B1B0 Offset: 0x55A5B0 VA: 0x18055B1B0
	private void OnGroupEnter(Message msg) { }

	// RVA: 0x55B2B0 Offset: 0x55A6B0 VA: 0x18055B2B0
	private void OnGroupLeave(Message msg) { }

	// RVA: 0x55A3D0 Offset: 0x5597D0 VA: 0x18055A3D0
	private void OnEntityDestroy(Message msg) { }

	// RVA: 0x55AF50 Offset: 0x55A350 VA: 0x18055AF50
	private void OnGroupDestroy(Message msg) { }

	// RVA: 0x55A7B0 Offset: 0x559BB0 VA: 0x18055A7B0
	private void OnGroupChange(Message msg) { }

	// RVA: 0x55A0E0 Offset: 0x5594E0 VA: 0x18055A0E0
	private void OnEntities(Message packet) { }

	// RVA: 0x555B50 Offset: 0x554F50 VA: 0x180555B50
	private BaseEntity CreateOrUpdateEntity(Entity info, long size) { }

	// RVA: 0x55A630 Offset: 0x559A30 VA: 0x18055A630
	private void OnEntityPosition(Message packet) { }

	// RVA: 0x55E4E0 Offset: 0x55D8E0 VA: 0x18055E4E0
	private void UpdateEntityPosition(uint entID, Vector3 pos, Vector3 rot, float time, uint parentID) { }

	// RVA: 0x55A5B0 Offset: 0x5599B0 VA: 0x18055A5B0
	private void OnEntityFlags(Message packet) { }

	// RVA: 0x55E260 Offset: 0x55D660 VA: 0x18055E260
	private void UpdateEntityFlags(uint entID, int flags) { }

	// RVA: 0x55FE00 Offset: 0x55F200 VA: 0x18055FE00
	public static EventSystem get_EventSystem() { }

	// RVA: 0x5557B0 Offset: 0x554BB0 VA: 0x1805557B0
	private void ClearVisibility() { }

	// RVA: 0x558DD0 Offset: 0x5581D0 VA: 0x180558DD0
	private void NetworkInit() { }

	// RVA: 0x55EAC0 Offset: 0x55DEC0 VA: 0x18055EAC0
	private void Update() { }

	// RVA: 0x558710 Offset: 0x557B10 VA: 0x180558710
	private void LateUpdate() { }

	// RVA: 0x557BD0 Offset: 0x556FD0 VA: 0x180557BD0
	private void Disconnect() { }

	// RVA: 0x55A070 Offset: 0x559470 VA: 0x18055A070
	private void OnDisable() { }

	// RVA: 0x558FB0 Offset: 0x5583B0 VA: 0x180558FB0
	private void OnApplicationQuit() { }

	// RVA: 0x55B3B0 Offset: 0x55A7B0 VA: 0x18055B3B0
	private void OnLeaveServer() { }

	// RVA: 0x55D7B0 Offset: 0x55CBB0 VA: 0x18055D7B0
	private void SaveConfigs(bool force = False) { }

	// RVA: 0x558640 Offset: 0x557A40 VA: 0x180558640
	private static extern uint GetCurrentProcessId() { }

	// RVA: 0x55D1C0 Offset: 0x55C5C0 VA: 0x18055D1C0
	private static extern IntPtr OpenProcess(Client.ProcessAccessFlags processAccess, bool bInheritHandle, uint processId) { }

	// RVA: 0x55E1D0 Offset: 0x55D5D0 VA: 0x18055E1D0
	private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode) { }

	// RVA: 0x55DA40 Offset: 0x55CE40 VA: 0x18055DA40
	private void ShutdownClient() { }

	// RVA: 0x55F6F0 Offset: 0x55EAF0 VA: 0x18055F6F0
	public void .ctor() { }

	// RVA: 0x55F300 Offset: 0x55E700 VA: 0x18055F300
	private static void .cctor() { }

}

private enum Client.ConnectionProtocol // TypeDefIndex: 9144
{	// Fields
	public int value__; // 0x0
	public const Client.ConnectionProtocol Raknet = 0;
	public const Client.ConnectionProtocol Steamworks = 1;

}

public enum Client.ProcessAccessFlags // TypeDefIndex: 9145
{	// Fields
	public uint value__; // 0x0
	public const Client.ProcessAccessFlags Terminate = 1;
	public const Client.ProcessAccessFlags Synchronize = 1048576;

}

private struct Client.<Connect>d__37 : IAsyncStateMachine // TypeDefIndex: 9146
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Client <>4__this; // 0x20
	public string strAddress; // 0x28
	public bool hideIpAddress; // 0x30
	public int port; // 0x34
	public string protocol; // 0x38
	private Client.ConnectionProtocol[] <configs>5__2; // 0x40
	private TaskAwaiter <>u__1; // 0x48
	private int <i>5__3; // 0x50

	// Methods

	// RVA: 0xF2ED0 Offset: 0xF22D0 VA: 0x1800F2ED0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Client.<>c // TypeDefIndex: 9147
{	// Fields
	public static readonly Client.<>c <>9; // 0x0
	public static Func<ConsoleSystem.Command, bool> <>9__39_0; // 0x8

	// Methods

	// RVA: 0x5A35E0 Offset: 0x5A29E0 VA: 0x1805A35E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5A3260 Offset: 0x5A2660 VA: 0x1805A3260
	internal bool <DoClientConnected>b__39_0(ConsoleSystem.Command x) { }

}

private sealed class Client.<DoClientConnected>d__39 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9148
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Approval msg; // 0x20
	public Client <>4__this; // 0x28
	private BenchmarkTimer <>7__wrap1; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A0600 Offset: 0x59FA00 VA: 0x1805A0600 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x59EFD0 Offset: 0x59E3D0 VA: 0x18059EFD0 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x5A06B0 Offset: 0x59FAB0 VA: 0x1805A06B0
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A05B0 Offset: 0x59F9B0 VA: 0x1805A05B0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Client.<StartPlayingDemoInternal>d__78 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9149
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Reader demo; // 0x20
	public Client <>4__this; // 0x28
	public bool inPlace; // 0x30
	private BenchmarkTimer <>7__wrap1; // 0x38
	private BenchmarkTimer <>7__wrap2; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A2E90 Offset: 0x5A2290 VA: 0x1805A2E90 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5A1A70 Offset: 0x5A0E70 VA: 0x1805A1A70 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x5A3070 Offset: 0x5A2470 VA: 0x1805A3070
	private void <>m__Finally1() { }

	// RVA: 0x5A30C0 Offset: 0x5A24C0 VA: 0x1805A30C0
	private void <>m__Finally2() { }

	// RVA: 0x5A3110 Offset: 0x5A2510 VA: 0x1805A3110
	private void <>m__Finally3() { }

	// RVA: 0x5A3160 Offset: 0x5A2560 VA: 0x1805A3160
	private void <>m__Finally4() { }

	// RVA: 0x5A31B0 Offset: 0x5A25B0 VA: 0x1805A31B0
	private void <>m__Finally5() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A2E40 Offset: 0x5A2240 VA: 0x1805A2E40 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct ClientPerformanceReport // TypeDefIndex: 9292
{	// Fields
	public int request_id; // 0x0
	public string user_id; // 0x8
	public float fps_average; // 0x10
	public int fps; // 0x14
	public int frame_id; // 0x18
	public float frame_time; // 0x1C
	public float frame_time_average; // 0x20
	public long memory_system; // 0x28
	public long memory_collections; // 0x30
	public long memory_managed_heap; // 0x38
	public float realtime_since_startup; // 0x40
	public bool streamer_mode; // 0x44
	public int ping; // 0x48
	public int tasks_invokes; // 0x4C
	public int tasks_load_balancer; // 0x50
	public int workshop_skins_queued; // 0x54

}

public class ClientFrametimeReport // TypeDefIndex: 9306
{	// Fields
	public int request_id; // 0x10
	public int start_frame; // 0x14
	public List<int> frame_times; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ClientFrametimeRequest // TypeDefIndex: 9307
{	// Fields
	public int request_id; // 0x10
	public int start_frame; // 0x14
	public int max_frames; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class ClientBuildingManager : BuildingManager // TypeDefIndex: 9827
{	// Methods

	// RVA: 0x5894F0 Offset: 0x5888F0 VA: 0x1805894F0
	public void Cycle() { }

	// RVA: 0x589480 Offset: 0x588880 VA: 0x180589480 Slot: 4
	protected override BuildingManager.Building CreateBuilding(uint id) { }

	// RVA: 0x589610 Offset: 0x588A10 VA: 0x180589610 Slot: 5
	protected override void DisposeBuilding(ref BuildingManager.Building building) { }

	// RVA: 0x589670 Offset: 0x588A70 VA: 0x180589670
	public void .ctor() { }

}

public static class Client // TypeDefIndex: 11646
{	// Fields
	public const byte Default = 0;
	public const byte Tick = 1;

}

public class Client : ConsoleSystem // TypeDefIndex: 11888
{	// Fields
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int maxpeerspersecond; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int maxpacketspersecond_effect; // 0x4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int maxpacketspersecond_voice; // 0x8
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool prediction; // 0xC
	[ClientVar] // RVA: 0x8D7A0 Offset: 0x8CBA0 VA: 0x18008D7A0
	public static int maxunack; // 0x10
	[ClientVar] // RVA: 0x8D850 Offset: 0x8CC50 VA: 0x18008D850
	public static bool pushtotalk; // 0x14
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debugdragdrop; // 0x15
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debuglootsounds; // 0x16
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static float headlerp; // 0x18
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static bool headlerp_inertia; // 0x1C
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static float camlerp; // 0x20
	[ClientVar] // RVA: 0x8DDC0 Offset: 0x8D1C0 VA: 0x18008DDC0
	public static bool camlerptilt; // 0x24
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static float camzoomlerp; // 0x28
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static float camspeed; // 0x2C
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static float camzoomspeed; // 0x30
	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	public static float camlookspeed; // 0x34
	[ClientVar] // RVA: 0x8E1F0 Offset: 0x8D5F0 VA: 0x18008E1F0
	public static float camdist; // 0x38
	[ClientVar] // RVA: 0x8E1F0 Offset: 0x8D5F0 VA: 0x18008E1F0
	public static string cambone; // 0x40
	[ClientVar] // RVA: 0x8E1F0 Offset: 0x8D5F0 VA: 0x18008E1F0
	public static float camfov; // 0x48
	[ClientVar] // RVA: 0x8E1F0 Offset: 0x8D5F0 VA: 0x18008E1F0
	public static Vector3 camoffset; // 0x4C
	[ClientVar] // RVA: 0x8E1F0 Offset: 0x8D5F0 VA: 0x18008E1F0
	public static bool camoffset_relative; // 0x58
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool sortSkinsRecentlyUsed; // 0x59
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool headbob; // 0x5A
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool crosshair; // 0x5B
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool hitcross; // 0x5C
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool hurtpunch; // 0x5D
	private static bool hasAppliedPhysicalCameraDefaults; // 0x5E
	public static Vector2[] CameraSensorSize; // 0x60
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool showCamInfo; // 0x68
	[ClientVar] // RVA: 0x8E860 Offset: 0x8DC60 VA: 0x18008E860
	public static float lookatradius; // 0x6C
	[ClientVar] // RVA: 0x8EA50 Offset: 0x8DE50 VA: 0x18008EA50
	public static int RockSkin; // 0x70
	[ClientVar] // RVA: 0x8EA50 Offset: 0x8DE50 VA: 0x18008EA50
	public static int UnderwearSkin; // 0x74

	// Properties
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float maxreceivetime { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float minreceivefraction { get; set; }
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool camPhysical { get; set; }
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static int camPhysicalSensor { get; set; }
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static float camPhysicalFocalLength { get; set; }

	// Methods

	// RVA: 0x6CDBF0 Offset: 0x6CCFF0 VA: 0x1806CDBF0
	public static float get_maxreceivetime() { }

	// RVA: 0x6CF1B0 Offset: 0x6CE5B0 VA: 0x1806CF1B0
	public static void set_maxreceivetime(float value) { }

	// RVA: 0x6CDC50 Offset: 0x6CD050 VA: 0x1806CDC50
	public static float get_minreceivefraction() { }

	// RVA: 0x6CF270 Offset: 0x6CE670 VA: 0x1806CF270
	public static void set_minreceivefraction(float value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CD1D0 Offset: 0x6CC5D0 VA: 0x1806CD1D0
	public static string connect(string address = "127.0.0.1:28015", string protocol = "", bool hideIpAddress = False) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CD490 Offset: 0x6CC890 VA: 0x1806CD490
	public static string connecthidden(string address = "127.0.0.1:28015", string protocol = "") { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CD7D0 Offset: 0x6CCBD0 VA: 0x1806CD7D0
	public static string fps() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CD570 Offset: 0x6CC970 VA: 0x1806CD570
	public static string disconnect() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CE310 Offset: 0x6CD710 VA: 0x1806CE310
	public static void report() { }

	[ClientVar] // RVA: 0x8F1B0 Offset: 0x8E5B0 VA: 0x18008F1B0
	// RVA: 0x6CE0B0 Offset: 0x6CD4B0 VA: 0x1806CE0B0
	public static string printpos() { }

	[ClientVar] // RVA: 0x8F260 Offset: 0x8E660 VA: 0x18008F260
	// RVA: 0x6CE1D0 Offset: 0x6CD5D0 VA: 0x1806CE1D0
	public static string printrot() { }

	[ClientVar] // RVA: 0x8F340 Offset: 0x8E740 VA: 0x18008F340
	// RVA: 0x6CDD50 Offset: 0x6CD150 VA: 0x1806CDD50
	public static string printeyes() { }

	[ClientVar] // RVA: 0x8F540 Offset: 0x8E940 VA: 0x18008F540
	// RVA: 0x6CDFA0 Offset: 0x6CD3A0 VA: 0x1806CDFA0
	public static string printinput() { }

	[ClientVar] // RVA: 0x8F6D0 Offset: 0x8EAD0 VA: 0x18008F6D0
	// RVA: 0x6CDE90 Offset: 0x6CD290 VA: 0x1806CDE90
	public static string printhead() { }

	// RVA: 0x6CBF50 Offset: 0x6CB350 VA: 0x1806CBF50
	public static string GetClientFolder(string folder) { }

	// RVA: 0x6CDB10 Offset: 0x6CCF10 VA: 0x1806CDB10
	public static bool get_camPhysical() { }

	// RVA: 0x6CED10 Offset: 0x6CE110 VA: 0x1806CED10
	public static void set_camPhysical(bool value) { }

	// RVA: 0x6CD920 Offset: 0x6CCD20 VA: 0x1806CD920
	public static int get_camPhysicalSensor() { }

	// RVA: 0x6CEB70 Offset: 0x6CDF70 VA: 0x1806CEB70
	public static void set_camPhysicalSensor(int value) { }

	// RVA: 0x6CD840 Offset: 0x6CCC40 VA: 0x1806CD840
	public static float get_camPhysicalFocalLength() { }

	// RVA: 0x6CEA90 Offset: 0x6CDE90 VA: 0x1806CEA90
	public static void set_camPhysicalFocalLength(float value) { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x6CD060 Offset: 0x6CC460 VA: 0x1806CD060
	public static void camPhysicalSensorTypes(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x85B40 Offset: 0x84F40 VA: 0x180085B40
	// RVA: 0x6CF5E0 Offset: 0x6CE9E0 VA: 0x1806CF5E0
	public static void sv(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CD500 Offset: 0x6CC900 VA: 0x1806CD500
	public static void consoletoggle() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CDCB0 Offset: 0x6CD0B0 VA: 0x1806CDCB0
	public static int ping() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CCF20 Offset: 0x6CC320 VA: 0x1806CCF20
	public static void benchmark(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CCDD0 Offset: 0x6CC1D0 VA: 0x1806CCDD0
	public static void benchmark_demo(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CF330 Offset: 0x6CE730 VA: 0x1806CF330
	public static void setunderwear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CBF80 Offset: 0x6CB380 VA: 0x1806CBF80
	public static void PlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CC420 Offset: 0x6CB820 VA: 0x1806CC420
	public static void ShufflePlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CC330 Offset: 0x6CB730 VA: 0x1806CC330
	public static void ReportPlayer(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6CC270 Offset: 0x6CB670 VA: 0x1806CC270
	public static void ReportBug(ConsoleSystem.Arg arg) { }

	// RVA: 0x6CCD70 Offset: 0x6CC170 VA: 0x1806CCD70
	public void .ctor() { }

	// RVA: 0x6CC6E0 Offset: 0x6CBAE0 VA: 0x1806CC6E0
	private static void .cctor() { }

}

public enum Client.CameraSensorType // TypeDefIndex: 11889
{	// Fields
	public int value__; // 0x0
	public const Client.CameraSensorType _8Mm = 0;
	public const Client.CameraSensorType Super8Mm = 1;
	public const Client.CameraSensorType _16Mm = 2;
	public const Client.CameraSensorType Super16mm = 3;
	public const Client.CameraSensorType _32mm2Perf = 4;
	public const Client.CameraSensorType _35mmAcademy = 5;
	public const Client.CameraSensorType Super35 = 6;
	public const Client.CameraSensorType _65mmALEXA = 7;
	public const Client.CameraSensorType _70mm = 8;
	public const Client.CameraSensorType _70mmImax = 9;
	public const Client.CameraSensorType ALEXA_LF = 10;
	public const Client.CameraSensorType ALEXA_35 = 11;
	public const Client.CameraSensorType Custom = 12;

}

public static class Client // TypeDefIndex: 12035
{	// Fields
	public const float UseDistance = 2;
	private static Scene _entityScene; // 0x0
	private static Scene _effectScene; // 0x4
	private static Scene _decorScene; // 0x8

	// Properties
	public static Scene EntityScene { get; }
	public static Scene EffectScene { get; }
	public static Scene DecorScene { get; }

	// Methods

	// RVA: 0x4B80F0 Offset: 0x4B74F0 VA: 0x1804B80F0
	public static Scene get_EntityScene() { }

	// RVA: 0x4B8070 Offset: 0x4B7470 VA: 0x1804B8070
	public static Scene get_EffectScene() { }

	// RVA: 0x4B7FF0 Offset: 0x4B73F0 VA: 0x1804B7FF0
	public static Scene get_DecorScene() { }

}

