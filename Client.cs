internal class ClientIdentity : Identity // TypeDefIndex: 1134
{
	private WeakReference _proxyReference; 

	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }


	public void .ctor(string objectUri, ObjRef objRef) { }

	public MarshalByRefObject get_ClientProxy() { }

	public void set_ClientProxy(MarshalByRefObject value) { }

	public override ObjRef CreateObjRef(Type requestedType) { }

	public string get_TargetUri() { }

}

internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 1146
{
	private MarshalByRefObject _targetThis; 


	public void .ctor(string objectUri, Type objectType) { }

	public MarshalByRefObject GetServerObject() { }

	public void SetClientProxy(MarshalByRefObject obj) { }

	public override void OnLifetimeExpired() { }

	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 1230
{
	private Context _context; 


	public void .ctor(Context ctx) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 1231
{
	private IMessageSink _replySink; 
	private Context _context; 


	public void .ctor(Context ctx, IMessageSink replySink) { }

	public IMessage SyncProcessMessage(IMessage msg) { }

	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

}

internal struct ClientGameServerDeny_t : ICallbackData // TypeDefIndex: 5296
{
	internal uint AppID; 
	internal uint GameServerIP; 
	internal ushort GameServerPort; 
	internal ushort Secure; 
	internal uint Reason; 
	public static int _datasize; 

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public class ClientReady : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6494
{
	public bool ShouldPool; 
	private bool _disposed; 
	public List<ClientReady.ClientInfo> clientInfo; 


	public static void ResetToPool(ClientReady instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ClientReady instance) { }

	public ClientReady Copy() { }

	public static ClientReady Deserialize(Stream stream) { }

	public static ClientReady DeserializeLengthDelimited(Stream stream) { }

	public static ClientReady DeserializeLength(Stream stream, int length) { }

	public static ClientReady Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ClientReady previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ClientReady Deserialize(byte[] buffer, ClientReady instance, bool isDelta = False) { }

	public static ClientReady Deserialize(Stream stream, ClientReady instance, bool isDelta) { }

	public static ClientReady DeserializeLengthDelimited(Stream stream, ClientReady instance, bool isDelta) { }

	public static ClientReady DeserializeLength(Stream stream, int length, ClientReady instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ClientReady instance, ClientReady previous) { }

	public static void Serialize(Stream stream, ClientReady instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ClientReady instance) { }

	public static void SerializeLengthDelimited(Stream stream, ClientReady instance) { }

	public void .ctor() { }

}

public class ClientReady.ClientInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6495
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string name; 
	public string value; 


	public static void ResetToPool(ClientReady.ClientInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(ClientReady.ClientInfo instance) { }

	public ClientReady.ClientInfo Copy() { }

	public static ClientReady.ClientInfo Deserialize(Stream stream) { }

	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream) { }

	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length) { }

	public static ClientReady.ClientInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, ClientReady.ClientInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static ClientReady.ClientInfo Deserialize(byte[] buffer, ClientReady.ClientInfo instance, bool isDelta = False) { }

	public static ClientReady.ClientInfo Deserialize(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	public static ClientReady.ClientInfo DeserializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance, bool isDelta) { }

	public static ClientReady.ClientInfo DeserializeLength(Stream stream, int length, ClientReady.ClientInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, ClientReady.ClientInfo instance, ClientReady.ClientInfo previous) { }

	public static void Serialize(Stream stream, ClientReady.ClientInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(ClientReady.ClientInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, ClientReady.ClientInfo instance) { }

	public void .ctor() { }

}

public class Client : BaseNetwork // TypeDefIndex: 6687
{
	public static float MaxReceiveTime; 
	public static float MinReceiveFraction; 
	[CompilerGeneratedAttribute] 
	private Connection <Connection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private readonly bool <IsPlaying>k__BackingField; 
	public Manager visibility; 
	public static string disconnectReason; 
	[CompilerGeneratedAttribute] 
	private string <ConnectedAddress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ConnectedPort>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <ServerName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsOfficialServer>k__BackingField; 
	public Stats IncomingStats; 
	public IClientCallback callbackHandler; 

	public Connection Connection { get; set; }
	public virtual bool IsPlaying { get; }
	public string ConnectedAddress { get; set; }
	public int ConnectedPort { get; set; }
	public string ServerName { get; set; }
	public bool IsOfficialServer { get; set; }
	public bool IsRecording { get; }
	public string RecordFilename { get; }
	public TimeSpan RecordTimeElapsed { get; }


	[CompilerGeneratedAttribute] 
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] 
	protected void set_Connection(Connection value) { }

	[CompilerGeneratedAttribute] 
	public virtual bool get_IsPlaying() { }

	[CompilerGeneratedAttribute] 
	public string get_ConnectedAddress() { }

	[CompilerGeneratedAttribute] 
	public void set_ConnectedAddress(string value) { }

	[CompilerGeneratedAttribute] 
	public int get_ConnectedPort() { }

	[CompilerGeneratedAttribute] 
	public void set_ConnectedPort(int value) { }

	[CompilerGeneratedAttribute] 
	public string get_ServerName() { }

	[CompilerGeneratedAttribute] 
	public void set_ServerName(string value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsOfficialServer() { }

	[CompilerGeneratedAttribute] 
	public void set_IsOfficialServer(bool value) { }

	public virtual bool Connect(string strURL, int port) { }

	public virtual void Cycle() { }

	public virtual void Disconnect(string reason, bool sendReasonToServer = True) { }

	public virtual bool IsConnected() { }

	protected void OnDisconnected(string str) { }

	public Networkable CreateNetworkable(uint networkID, uint networkGroup) { }

	public void DestroyNetworkable(ref Networkable networkable) { }

	public void SetupNetworkable(Networkable net) { }

	public virtual int GetLastPing() { }

	public bool get_IsRecording() { }

	public string get_RecordFilename() { }

	public TimeSpan get_RecordTimeElapsed() { }

	public bool StartRecording(string targetFilename, IDemoHeader header) { }

	public void StopRecording() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ClientVar : ConsoleVar // TypeDefIndex: 6894
{

	public void .ctor() { }

}

public enum ClientIntegrityViolationType // TypeDefIndex: 7140
{
	public int value__; 
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
{
	private Peer peer; 
	public static byte[] ReusableBytes; 
	private Stopwatch cycleTimer; 


	public override bool IsConnected() { }

	public override bool Connect(string strURL, int port) { }

	internal bool HandleRaknetPacket(byte type) { }

	protected void HandleMessage() { }

	public override void Cycle() { }

	public override void Disconnect(string reason, bool sendReasonToServer) { }

	public override string GetDebug(Connection connection) { }

	public override ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	public override int GetLastPing() { }

	public override void Send(SendInfo sendinfo, MemoryStream data) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ClientIOLine : BaseMonoBehaviour // TypeDefIndex: 8884
{
	public RendererLOD _lod; 
	public LineRenderer _line; 
	public Material directionalMaterial; 
	public Material defaultMaterial; 
	public IOEntity.IOType lineType; 
	public static List<ClientIOLine> _allLines; 
	public WireTool.WireColour colour; 
	public IOEntity ownerIOEnt; 

	public int PositionCount { get; }


	public void SetIOEntityOwner(IOEntity newOwner) { }

	public void OnEnable() { }

	public void OnDisable() { }

	public static void SetDirectionVisibleAll(bool isVisible, IOEntity.IOType forType) { }

	public static void SetDirectionVisibleSingle(bool isVisible, ClientIOLine line) { }

	public void Clear() { }

	public void DelayedDirectionTest() { }

	public void SetDirectionVisible(bool isVisible) { }

	public void SetVisible(bool isVisible) { }

	public void SetLineCullDistance(float length) { }

	public void SetPositions(Vector3[] positions, float[] slackLevels) { }

	public void AddPosition(Vector3 worldPos) { }

	public void SetLastNodePosition(Vector3 worldPos) { }

	public void RemoveLastPosition() { }

	public float GetLength() { }

	public void UpdateBoundsAndPosition() { }

	public Vector3 GetLastPlacedNodePosition() { }

	public int get_PositionCount() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Client : SingletonComponent<Client>, IClientCallback // TypeDefIndex: 9143
{
	public static Translate.Phrase loading_loading; 
	public static Translate.Phrase loading_connecting; 
	public static Translate.Phrase loading_connectionaccepted; 
	public static Translate.Phrase loading_connecting_negotiate; 
	public static Translate.Phrase loading_level; 
	public static Translate.Phrase loading_skinnablewarmup; 
	public static Translate.Phrase loading_preloadcomplete; 
	public static Translate.Phrase loading_openingscene; 
	public static Translate.Phrase loading_clientready; 
	public static Translate.Phrase loading_prefabwarmup; 
	[CompilerGeneratedAttribute] 
	private static Action OnConnected; 
	[CompilerGeneratedAttribute] 
	private static Action OnDisconnected; 
	private IAuthTicket authTicket; 
	private IEnumerator currentCoroutine; 
	private bool connectionRetry; 
	private static Client.ConnectionProtocol[] config_raknet; 
	private static Client.ConnectionProtocol[] config_steamworks; 
	private static Client.ConnectionProtocol[] config_default; 
	private static Mesh _cubeMesh; 
	[CompilerGeneratedAttribute] 
	private static bool <IsScrubbingDemo>k__BackingField; 
	public static ulong DemoLocalClient; 
	private static Reader Demo; 
	private static float PreDemoPhysicsSteps; 
	private const float demoTickDistSq = 2500;
	[CompilerGeneratedAttribute] 
	private static BasePlayer <DemoSpectatePlayer>k__BackingField; 
	public static BaseEntity CurrentEntity; 
	public HashSet<uint> subscriptions; 
	private const long EntityPositionPacketSize = 36;
	private const long EntityFlagsPacketSize = 8;
	private static EventSystem _eventsystem; 
	private float LastConfigSaveTime; 
	private Stopwatch ngTimer; 

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


	[CompilerGeneratedAttribute] 
	public static void add_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_OnConnected(Action value) { }

	[CompilerGeneratedAttribute] 
	public static void add_OnDisconnected(Action value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_OnDisconnected(Action value) { }

	private bool get_StatsEnabled() { }

	private void RegisterIncoming(string type, long bytes) { }

	private void RegisterIncoming(string type, string entity, long bytes) { }

	public void OnNetworkMessage(Message packet) { }

	private void OnMessage(Message packet) { }

	private void OnRequestUserInformation(Message packet) { }

	private void OnApproved(Message packet) { }

	private void OnRPCMessage(Message packet) { }

	private string GetOSName() { }

	public void CancelAuthTicket() { }

	public IAuthTicket GetAuthTicket(bool cancelOld = True) { }

	private void CancelLoading() { }

	private Coroutine StartLoading(IEnumerator coroutine) { }

	[AsyncStateMachineAttribute] 
	public Task Connect(string strAddress, int port, string protocol, bool hideIpAddress = False) { }

	private void DestroyNetworkables() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator DoClientConnected(Approval msg) { }

	public void OnClientDisconnected(string strReason) { }

	public static void ClientCleanup() { }

	private static void OnConsoleReplicatedVars(Message packet) { }

	private static void SetReplicatedVar(string fullName, string value) { }

	private void RunDebugCommands() { }

	private void DrawColliders() { }

	private void UpdateNetgraph() { }

	private Stats GetCurrentNetworkStats() { }

	public static bool get_IsPlayingDemo() { }

	public static bool get_IsRecordingDemo() { }

	[CompilerGeneratedAttribute] 
	public static bool get_IsScrubbingDemo() { }

	[CompilerGeneratedAttribute] 
	public static void set_IsScrubbingDemo(bool value) { }

	public static TimeSpan get_RecordingTimeElapsed() { }

	public static string get_RecordingFilename() { }

	public static BasePlayer get_DemoLocalPlayer() { }

	public static TimeSpan get_DemoProgress() { }

	public static TimeSpan get_DemoLength() { }

	public static float get_DemoNormalizedTime() { }

	public static string get_DemoName() { }

	public static DateTime get_DemoRecordedTime() { }

	public void StartPlayingDemo(Reader demo, bool inPlace) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator StartPlayingDemoInternal(Reader demo, bool inPlace) { }

	private void OnDemoKeyframe(Indexer.Keyframe keyframe, HashSet<uint> changedEnts) { }

	public void StopRecordingDemo() { }

	public void StopPlayingDemo(bool finished = False) { }

	private void DemoFrame() { }

	[CompilerGeneratedAttribute] 
	public static BasePlayer get_DemoSpectatePlayer() { }

	[CompilerGeneratedAttribute] 
	private static void set_DemoSpectatePlayer(BasePlayer value) { }

	private void DemoSpectateNextPlayer(bool forward) { }

	private void DemoLateUpdate(bool isLastCall) { }

	private void DemoPlayerTick(PlayerTick playerTick) { }

	private void OnGroupEnter(Message msg) { }

	private void OnGroupLeave(Message msg) { }

	private void OnEntityDestroy(Message msg) { }

	private void OnGroupDestroy(Message msg) { }

	private void OnGroupChange(Message msg) { }

	private void OnEntities(Message packet) { }

	private BaseEntity CreateOrUpdateEntity(Entity info, long size) { }

	private void OnEntityPosition(Message packet) { }

	private void UpdateEntityPosition(uint entID, Vector3 pos, Vector3 rot, float time, uint parentID) { }

	private void OnEntityFlags(Message packet) { }

	private void UpdateEntityFlags(uint entID, int flags) { }

	public static EventSystem get_EventSystem() { }

	private void ClearVisibility() { }

	private void NetworkInit() { }

	private void Update() { }

	private void LateUpdate() { }

	private void Disconnect() { }

	private void OnDisable() { }

	private void OnApplicationQuit() { }

	private void OnLeaveServer() { }

	private void SaveConfigs(bool force = False) { }

	private static extern uint GetCurrentProcessId() { }

	private static extern IntPtr OpenProcess(Client.ProcessAccessFlags processAccess, bool bInheritHandle, uint processId) { }

	private static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode) { }

	private void ShutdownClient() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private enum Client.ConnectionProtocol // TypeDefIndex: 9144
{
	public int value__; 
	public const Client.ConnectionProtocol Raknet = 0;
	public const Client.ConnectionProtocol Steamworks = 1;

}

public enum Client.ProcessAccessFlags // TypeDefIndex: 9145
{
	public uint value__; 
	public const Client.ProcessAccessFlags Terminate = 1;
	public const Client.ProcessAccessFlags Synchronize = 1048576;

}

private struct Client.<Connect>d__37 : IAsyncStateMachine // TypeDefIndex: 9146
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public Client <>4__this; 
	public string strAddress; 
	public bool hideIpAddress; 
	public int port; 
	public string protocol; 
	private Client.ConnectionProtocol[] <configs>5__2; 
	private TaskAwaiter <>u__1; 
	private int <i>5__3; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private sealed class Client.<>c // TypeDefIndex: 9147
{
	public static readonly Client.<>c <>9; 
	public static Func<ConsoleSystem.Command, bool> <>9__39_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <DoClientConnected>b__39_0(ConsoleSystem.Command x) { }

}

private sealed class Client.<DoClientConnected>d__39 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9148
{
	private int <>1__state; 
	private object <>2__current; 
	public Approval msg; 
	public Client <>4__this; 
	private BenchmarkTimer <>7__wrap1; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Client.<StartPlayingDemoInternal>d__78 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9149
{
	private int <>1__state; 
	private object <>2__current; 
	public Reader demo; 
	public Client <>4__this; 
	public bool inPlace; 
	private BenchmarkTimer <>7__wrap1; 
	private BenchmarkTimer <>7__wrap2; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	private void <>m__Finally2() { }

	private void <>m__Finally3() { }

	private void <>m__Finally4() { }

	private void <>m__Finally5() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public struct ClientPerformanceReport // TypeDefIndex: 9292
{
	public int request_id; 
	public string user_id; 
	public float fps_average; 
	public int fps; 
	public int frame_id; 
	public float frame_time; 
	public float frame_time_average; 
	public long memory_system; 
	public long memory_collections; 
	public long memory_managed_heap; 
	public float realtime_since_startup; 
	public bool streamer_mode; 
	public int ping; 
	public int tasks_invokes; 
	public int tasks_load_balancer; 
	public int workshop_skins_queued; 

}

public class ClientFrametimeReport // TypeDefIndex: 9306
{
	public int request_id; 
	public int start_frame; 
	public List<int> frame_times; 


	public void .ctor() { }

}

public class ClientFrametimeRequest // TypeDefIndex: 9307
{
	public int request_id; 
	public int start_frame; 
	public int max_frames; 


	public void .ctor() { }

}

public class ClientBuildingManager : BuildingManager // TypeDefIndex: 9827
{

	public void Cycle() { }

	protected override BuildingManager.Building CreateBuilding(uint id) { }

	protected override void DisposeBuilding(ref BuildingManager.Building building) { }

	public void .ctor() { }

}

public static class Client // TypeDefIndex: 11646
{
	public const byte Default = 0;
	public const byte Tick = 1;

}

public class Client : ConsoleSystem // TypeDefIndex: 11888
{
	[ClientVar] 
	public static int maxpeerspersecond; 
	[ClientVar] 
	public static int maxpacketspersecond_effect; 
	[ClientVar] 
	public static int maxpacketspersecond_voice; 
	[ClientVar] 
	public static bool prediction; 
	[ClientVar] 
	public static int maxunack; 
	[ClientVar] 
	public static bool pushtotalk; 
	[ClientVar] 
	public static bool debugdragdrop; 
	[ClientVar] 
	public static bool debuglootsounds; 
	[ClientVar] 
	public static float headlerp; 
	[ClientVar] 
	public static bool headlerp_inertia; 
	[ClientVar] 
	public static float camlerp; 
	[ClientVar] 
	public static bool camlerptilt; 
	[ClientVar] 
	public static float camzoomlerp; 
	[ClientVar] 
	public static float camspeed; 
	[ClientVar] 
	public static float camzoomspeed; 
	[ClientVar] 
	public static float camlookspeed; 
	[ClientVar] 
	public static float camdist; 
	[ClientVar] 
	public static string cambone; 
	[ClientVar] 
	public static float camfov; 
	[ClientVar] 
	public static Vector3 camoffset; 
	[ClientVar] 
	public static bool camoffset_relative; 
	[ClientVar] 
	public static bool sortSkinsRecentlyUsed; 
	[ClientVar] 
	public static bool headbob; 
	[ClientVar] 
	public static bool crosshair; 
	[ClientVar] 
	public static bool hitcross; 
	[ClientVar] 
	public static bool hurtpunch; 
	private static bool hasAppliedPhysicalCameraDefaults; 
	public static Vector2[] CameraSensorSize; 
	[ClientVar] 
	public static bool showCamInfo; 
	[ClientVar] 
	public static float lookatradius; 
	[ClientVar] 
	public static int RockSkin; 
	[ClientVar] 
	public static int UnderwearSkin; 

	[ClientVar] 
	public static float maxreceivetime { get; set; }
	[ClientVar] 
	public static float minreceivefraction { get; set; }
	[ClientVar] 
	public static bool camPhysical { get; set; }
	[ClientVar] 
	public static int camPhysicalSensor { get; set; }
	[ClientVar] 
	public static float camPhysicalFocalLength { get; set; }


	public static float get_maxreceivetime() { }

	public static void set_maxreceivetime(float value) { }

	public static float get_minreceivefraction() { }

	public static void set_minreceivefraction(float value) { }

	[ClientVar] 
	public static string connect(string address = "127.0.0.1:28015", string protocol = "", bool hideIpAddress = False) { }

	[ClientVar] 
	public static string connecthidden(string address = "127.0.0.1:28015", string protocol = "") { }

	[ClientVar] 
	public static string fps() { }

	[ClientVar] 
	public static string disconnect() { }

	[ClientVar] 
	public static void report() { }

	[ClientVar] 
	public static string printpos() { }

	[ClientVar] 
	public static string printrot() { }

	[ClientVar] 
	public static string printeyes() { }

	[ClientVar] 
	public static string printinput() { }

	[ClientVar] 
	public static string printhead() { }

	public static string GetClientFolder(string folder) { }

	public static bool get_camPhysical() { }

	public static void set_camPhysical(bool value) { }

	public static int get_camPhysicalSensor() { }

	public static void set_camPhysicalSensor(int value) { }

	public static float get_camPhysicalFocalLength() { }

	public static void set_camPhysicalFocalLength(float value) { }

	[ClientVar] 
	public static void camPhysicalSensorTypes(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void sv(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void consoletoggle() { }

	[ClientVar] 
	public static int ping() { }

	[ClientVar] 
	public static void benchmark(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void benchmark_demo(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void setunderwear(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void PlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ShufflePlayerSeed(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ReportPlayer(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void ReportBug(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Client.CameraSensorType // TypeDefIndex: 11889
{
	public int value__; 
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
{
	public const float UseDistance = 2;
	private static Scene _entityScene; 
	private static Scene _effectScene; 
	private static Scene _decorScene; 

	public static Scene EntityScene { get; }
	public static Scene EffectScene { get; }
	public static Scene DecorScene { get; }


	public static Scene get_EntityScene() { }

	public static Scene get_EffectScene() { }

	public static Scene get_DecorScene() { }

}

