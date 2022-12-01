internal static class AppContextSwitches // TypeDefIndex: 142
{
	public static readonly bool ThrowExceptionIfDisposedCancellationTokenSource;
	public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity;
	public static readonly bool NoAsyncCurrentCulture;
	public static readonly bool PreserveEventListnerObjectIdentity;

}

public class AppDomainUnloadedException : SystemException // TypeDefIndex: 164
{

	public void .ctor() { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ApplicationException : Exception // TypeDefIndex: 165
{

	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, Exception innerException) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 337
{
	private IntPtr _mono_app_domain;
	private static string _process_guid;
	[ThreadStaticAttribute]
	private static Dictionary<string, object> type_resolve_in_progress;
	[ThreadStaticAttribute]
	private static Dictionary<string, object> assembly_resolve_in_progress;
	[ThreadStaticAttribute]
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly;
	private object _evidence;
	private object _granted;
	private int _principalPolicy;
	[ThreadStaticAttribute]
	private static object _principal;
	private static AppDomain default_domain;
	[CompilerGeneratedAttribute]
	private AssemblyLoadEventHandler AssemblyLoad;
	[CompilerGeneratedAttribute]
	private ResolveEventHandler AssemblyResolve;
	[CompilerGeneratedAttribute]
	private EventHandler DomainUnload;
	[CompilerGeneratedAttribute]
	private EventHandler ProcessExit;
	[CompilerGeneratedAttribute]
	private ResolveEventHandler ResourceResolve;
	[CompilerGeneratedAttribute]
	private ResolveEventHandler TypeResolve;
	[CompilerGeneratedAttribute]
	private UnhandledExceptionEventHandler UnhandledException;
	[CompilerGeneratedAttribute]
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException;
	private object _domain_manager;
	[CompilerGeneratedAttribute]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve;
	private object _activation;
	private object _applicationIdentity;
	private List<string> compatibility_switch;

	internal AppDomainSetup SetupInformationNoCopy { get; }
	public string BaseDirectory { get; }
	public string FriendlyName { get; }
	public static AppDomain CurrentDomain { get; }


	private void .ctor() { }

	private AppDomainSetup getSetup() { }

	internal AppDomainSetup get_SetupInformationNoCopy() { }

	public string get_BaseDirectory() { }

	private string getFriendlyName() { }

	public string get_FriendlyName() { }

	private static AppDomain getCurDomain() { }

	public static AppDomain get_CurrentDomain() { }

	private Assembly[] GetAssemblies(bool refOnly) { }

	public Assembly[] GetAssemblies() { }

	public object GetData(string name) { }

	public override object InitializeLifetimeService() { }

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	public Assembly Load(AssemblyName assemblyRef) { }

	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	[ObsoleteAttribute]
	public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	public Assembly Load(string assemblyString) { }

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	private static AppDomain InternalSetDomainByID(int domain_id) { }

	private static AppDomain InternalSetDomain(AppDomain context) { }

	internal static void InternalPushDomainRefByID(int domain_id) { }

	internal static void InternalPopDomainRef() { }

	internal static Context InternalSetContext(Context context) { }

	internal static Context InternalGetContext() { }

	internal static Context InternalGetDefaultContext() { }

	internal static string InternalGetProcessGuid(string newguid) { }

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	internal static string GetProcessGuid() { }

	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	public bool IsFinalizingForUnload() { }

	private int getDomainID() { }

	[ObsoleteAttribute]
	public static int GetCurrentThreadId() { }

	public override string ToString() { }

	private void DoAssemblyLoad(Assembly assembly) { }

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	internal Assembly DoTypeResolve(object name_or_tb) { }

	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	private void DoDomainUnload() { }

	internal byte[] GetMarshalledDomainObjRef() { }

	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute]
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute]
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute]
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute]
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute]
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute]
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

}

public sealed class AppDomainSetup // TypeDefIndex: 346
{
	private string application_base;
	private string application_name;
	private string cache_path;
	private string configuration_file;
	private string dynamic_base;
	private string license_file;
	private string private_bin_path;
	private string private_bin_path_probe;
	private string shadow_copy_directories;
	private string shadow_copy_files;
	private bool publisher_policy;
	private bool path_changed;
	private int loader_optimization;
	private bool disallow_binding_redirects;
	private bool disallow_code_downloads;
	private object _activationArguments;
	private object domain_initializer;
	private object application_trust;
	private string[] domain_initializer_args;
	private bool disallow_appbase_probe;
	private byte[] configuration_bytes;
	private byte[] serialized_non_primitives;
	[CompilerGeneratedAttribute]
	private string <TargetFrameworkName>k__BackingField;

	public string ApplicationBase { get; }


	public void .ctor() { }

	private static string GetAppBase(string appBase) { }

	public string get_ApplicationBase() { }

}

internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1203
{
	private string _activationUrl;
	private IActivator _next;

	public IActivator NextActivator { get; }


	public void .ctor(string activationUrl, IActivator next) { }

	public IActivator get_NextActivator() { }

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

public class Application // TypeDefIndex: 3354
{
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static Application.LowMemoryCallback lowMemory;
	private static Application.LogCallback s_LogCallbackHandler;
	private static Application.LogCallback s_LogCallbackHandlerThreaded;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static Action<bool> focusChanged;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static Action<string> deepLinkActivated;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private static Func<bool> wantsToQuit;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private static Action quitting;

	public static bool isPlaying { get; }
	public static bool isFocused { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	[SecurityCriticalAttribute]
	public static string persistentDataPath { get; }
	public static string unityVersion { get; }
	public static string version { get; }
	public static string companyName { get; }
	public static int targetFrameRate { get; set; }
	public static string consoleLogPath { get; }
	public static ThreadPriority backgroundLoadingPriority { set; }
	public static RuntimePlatform platform { get; }
	public static bool isMobilePlatform { get; }
	public static SystemLanguage systemLanguage { get; }
	public static NetworkReachability internetReachability { get; }
	[ObsoleteAttribute]
	public static string loadedLevelName { get; }
	public static bool isEditor { get; }


	[FreeFunctionAttribute]
	public static void Quit(int exitCode) { }

	public static void Quit() { }

	[FreeFunctionAttribute]
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute]
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute]
	public static bool get_isFocused() { }

	[FreeFunctionAttribute]
	public static string get_dataPath() { }

	[FreeFunctionAttribute]
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute]
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute]
	public static string get_unityVersion() { }

	[FreeFunctionAttribute]
	public static string get_version() { }

	[FreeFunctionAttribute]
	public static string get_companyName() { }

	[FreeFunctionAttribute]
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute]
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute]
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute]
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute]
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute]
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute]
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute]
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute]
	public static RuntimePlatform get_platform() { }

	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute]
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute]
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute]
	internal static void CallLowMemory() { }

	public static void add_logMessageReceived(Application.LogCallback value) { }

	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	public static void add_onBeforeRender(UnityAction value) { }

	public static void remove_onBeforeRender(UnityAction value) { }

	[RequiredByNativeCodeAttribute]
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute]
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute]
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute]
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute]
	internal static void InvokeDeepLinkActivated(string url) { }

	public static string get_loadedLevelName() { }

	public static bool get_isEditor() { }

}

public sealed class Application.LowMemoryCallback : MulticastDelegate // TypeDefIndex: 3355
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 3356
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public struct AppId // TypeDefIndex: 5241
{
	public uint Value;


	public override string ToString() { }

	public static AppId op_Implicit(uint value) { }

	public static AppId op_Implicit(int value) { }

	public static uint op_Implicit(AppId value) { }

}

internal struct AppResumingFromSuspend_t : ICallbackData // TypeDefIndex: 5341
{
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct AppProofOfPurchaseKeyResponse_t : ICallbackData // TypeDefIndex: 5409
{
	internal Result Result;
	internal uint AppID;
	internal uint CchKeyLength;
	internal byte[] Key;
	public static int _datasize;

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public static class Application // TypeDefIndex: 6185
{
	private static MonoBehaviour _controller;
	public static Manifest Manifest;
	public static Dictionary<IPEndPoint, int> ServerMetadata;
	[CompilerGeneratedAttribute]
	private static BaseIntegration <Integration>k__BackingField;

	public static MonoBehaviour Controller { get; }
	public static BaseIntegration Integration { get; set; }


	public static MonoBehaviour get_Controller() { }

	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute]
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute]
	public static void set_Integration(BaseIntegration value) { }

}

internal class ApplicationControllerMonobehaviour : MonoBehaviour // TypeDefIndex: 6226
{

	public void OnApplicationQuit() { }

	public void Update() { }

	public void .ctor() { }

}

public struct AppInfo // TypeDefIndex: 6249
{
	[CompilerGeneratedAttribute]
	private string <Image>k__BackingField;

	public int Version { get; }
	public BuildInfo Build { get; }
	public string Name { get; }
	public string Os { get; }
	public string Cpu { get; }
	public int CpuCount { get; }
	public int Mem { get; }
	public string Gpu { get; }
	public int GpuMem { get; }
	public string Arch { get; }
	public string UserId { get; }
	public string UserName { get; }
	public string ServerAddress { get; }
	public string ServerName { get; }
	public string LevelName { get; }
	public string LevelPos { get; }
	public string LevelRot { get; }
	public int MinutesPlayed { get; }
	public string Image { get; set; }


	public int get_Version() { }

	public BuildInfo get_Build() { }

	public string get_Name() { }

	public string get_Os() { }

	public string get_Cpu() { }

	public int get_CpuCount() { }

	public int get_Mem() { }

	public string get_Gpu() { }

	public int get_GpuMem() { }

	public string get_Arch() { }

	public string get_UserId() { }

	public string get_UserName() { }

	public string get_ServerAddress() { }

	public string get_ServerName() { }

	public string get_LevelName() { }

	public string get_LevelPos() { }

	public string get_LevelRot() { }

	public int get_MinutesPlayed() { }

	[CompilerGeneratedAttribute]
	public string get_Image() { }

	[CompilerGeneratedAttribute]
	public void set_Image(string value) { }

}

public class Approval : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6488
{
	public bool ShouldPool;
	private bool _disposed;
	public string level;
	public string hostname;
	public bool modded;
	public bool official;
	public ulong steamid;
	public uint ipaddress;
	public int port;
	public uint levelSeed;
	public uint levelSize;
	public string checksum;
	public uint encryption;
	public string levelUrl;
	public bool levelTransfer;


	public static void ResetToPool(Approval instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Approval instance) { }

	public Approval Copy() { }

	public static Approval Deserialize(Stream stream) { }

	public static Approval DeserializeLengthDelimited(Stream stream) { }

	public static Approval DeserializeLength(Stream stream, int length) { }

	public static Approval Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Approval previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Approval Deserialize(byte[] buffer, Approval instance, bool isDelta = False) { }

	public static Approval Deserialize(Stream stream, Approval instance, bool isDelta) { }

	public static Approval DeserializeLengthDelimited(Stream stream, Approval instance, bool isDelta) { }

	public static Approval DeserializeLength(Stream stream, int length, Approval instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Approval instance, Approval previous) { }

	public static void Serialize(Stream stream, Approval instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Approval instance) { }

	public static void SerializeLengthDelimited(Stream stream, Approval instance) { }

	public void .ctor() { }

}

public class AppRequest : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6523
{
	public bool ShouldPool;
	private bool _disposed;
	public uint seq;
	public ulong playerId;
	public int playerToken;
	public uint entityId;
	public AppEmpty getInfo;
	public AppEmpty getTime;
	public AppEmpty getMap;
	public AppEmpty getTeamInfo;
	public AppEmpty getTeamChat;
	public AppSendMessage sendTeamMessage;
	public AppEmpty getEntityInfo;
	public AppSetEntityValue setEntityValue;
	public AppEmpty checkSubscription;
	public AppFlag setSubscription;
	public AppEmpty getMapMarkers;
	public AppPromoteToLeader promoteToLeader;


	public static void ResetToPool(AppRequest instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppRequest instance) { }

	public AppRequest Copy() { }

	public static AppRequest Deserialize(Stream stream) { }

	public static AppRequest DeserializeLengthDelimited(Stream stream) { }

	public static AppRequest DeserializeLength(Stream stream, int length) { }

	public static AppRequest Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppRequest previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppRequest Deserialize(byte[] buffer, AppRequest instance, bool isDelta = False) { }

	public static AppRequest Deserialize(Stream stream, AppRequest instance, bool isDelta) { }

	public static AppRequest DeserializeLengthDelimited(Stream stream, AppRequest instance, bool isDelta) { }

	public static AppRequest DeserializeLength(Stream stream, int length, AppRequest instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppRequest instance, AppRequest previous) { }

	public static void Serialize(Stream stream, AppRequest instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppRequest instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppRequest instance) { }

	public void .ctor() { }

}

public class AppMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6524
{
	public bool ShouldPool;
	private bool _disposed;
	public AppResponse response;
	public AppBroadcast broadcast;


	public static void ResetToPool(AppMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppMessage instance) { }

	public AppMessage Copy() { }

	public static AppMessage Deserialize(Stream stream) { }

	public static AppMessage DeserializeLengthDelimited(Stream stream) { }

	public static AppMessage DeserializeLength(Stream stream, int length) { }

	public static AppMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppMessage Deserialize(byte[] buffer, AppMessage instance, bool isDelta = False) { }

	public static AppMessage Deserialize(Stream stream, AppMessage instance, bool isDelta) { }

	public static AppMessage DeserializeLengthDelimited(Stream stream, AppMessage instance, bool isDelta) { }

	public static AppMessage DeserializeLength(Stream stream, int length, AppMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppMessage instance, AppMessage previous) { }

	public static void Serialize(Stream stream, AppMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppMessage instance) { }

	public void .ctor() { }

}

public class AppResponse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6525
{
	public bool ShouldPool;
	private bool _disposed;
	public uint seq;
	public AppSuccess success;
	public AppError error;
	public AppInfo info;
	public AppTime time;
	public AppMap map;
	public AppTeamInfo teamInfo;
	public AppTeamChat teamChat;
	public AppEntityInfo entityInfo;
	public AppFlag flag;
	public AppMapMarkers mapMarkers;


	public static void ResetToPool(AppResponse instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppResponse instance) { }

	public AppResponse Copy() { }

	public static AppResponse Deserialize(Stream stream) { }

	public static AppResponse DeserializeLengthDelimited(Stream stream) { }

	public static AppResponse DeserializeLength(Stream stream, int length) { }

	public static AppResponse Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppResponse previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppResponse Deserialize(byte[] buffer, AppResponse instance, bool isDelta = False) { }

	public static AppResponse Deserialize(Stream stream, AppResponse instance, bool isDelta) { }

	public static AppResponse DeserializeLengthDelimited(Stream stream, AppResponse instance, bool isDelta) { }

	public static AppResponse DeserializeLength(Stream stream, int length, AppResponse instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppResponse instance, AppResponse previous) { }

	public static void Serialize(Stream stream, AppResponse instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppResponse instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppResponse instance) { }

	public void .ctor() { }

}

public class AppBroadcast : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6526
{
	public bool ShouldPool;
	private bool _disposed;
	public AppTeamChanged teamChanged;
	public AppTeamMessage teamMessage;
	public AppEntityChanged entityChanged;


	public static void ResetToPool(AppBroadcast instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppBroadcast instance) { }

	public AppBroadcast Copy() { }

	public static AppBroadcast Deserialize(Stream stream) { }

	public static AppBroadcast DeserializeLengthDelimited(Stream stream) { }

	public static AppBroadcast DeserializeLength(Stream stream, int length) { }

	public static AppBroadcast Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppBroadcast previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppBroadcast Deserialize(byte[] buffer, AppBroadcast instance, bool isDelta = False) { }

	public static AppBroadcast Deserialize(Stream stream, AppBroadcast instance, bool isDelta) { }

	public static AppBroadcast DeserializeLengthDelimited(Stream stream, AppBroadcast instance, bool isDelta) { }

	public static AppBroadcast DeserializeLength(Stream stream, int length, AppBroadcast instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppBroadcast instance, AppBroadcast previous) { }

	public static void Serialize(Stream stream, AppBroadcast instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppBroadcast instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppBroadcast instance) { }

	public void .ctor() { }

}

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6527
{
	public bool ShouldPool;
	private bool _disposed;


	public static void ResetToPool(AppEmpty instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppEmpty instance) { }

	public AppEmpty Copy() { }

	public static AppEmpty Deserialize(Stream stream) { }

	public static AppEmpty DeserializeLengthDelimited(Stream stream) { }

	public static AppEmpty DeserializeLength(Stream stream, int length) { }

	public static AppEmpty Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppEmpty previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppEmpty Deserialize(byte[] buffer, AppEmpty instance, bool isDelta = False) { }

	public static AppEmpty Deserialize(Stream stream, AppEmpty instance, bool isDelta) { }

	public static AppEmpty DeserializeLengthDelimited(Stream stream, AppEmpty instance, bool isDelta) { }

	public static AppEmpty DeserializeLength(Stream stream, int length, AppEmpty instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppEmpty instance, AppEmpty previous) { }

	public static void Serialize(Stream stream, AppEmpty instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppEmpty instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppEmpty instance) { }

	public void .ctor() { }

}

public class AppSendMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6528
{
	public bool ShouldPool;
	private bool _disposed;
	public string message;


	public static void ResetToPool(AppSendMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppSendMessage instance) { }

	public AppSendMessage Copy() { }

	public static AppSendMessage Deserialize(Stream stream) { }

	public static AppSendMessage DeserializeLengthDelimited(Stream stream) { }

	public static AppSendMessage DeserializeLength(Stream stream, int length) { }

	public static AppSendMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppSendMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppSendMessage Deserialize(byte[] buffer, AppSendMessage instance, bool isDelta = False) { }

	public static AppSendMessage Deserialize(Stream stream, AppSendMessage instance, bool isDelta) { }

	public static AppSendMessage DeserializeLengthDelimited(Stream stream, AppSendMessage instance, bool isDelta) { }

	public static AppSendMessage DeserializeLength(Stream stream, int length, AppSendMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppSendMessage instance, AppSendMessage previous) { }

	public static void Serialize(Stream stream, AppSendMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppSendMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppSendMessage instance) { }

	public void .ctor() { }

}

public class AppSetEntityValue : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6529
{
	public bool ShouldPool;
	private bool _disposed;
	public bool value;


	public static void ResetToPool(AppSetEntityValue instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppSetEntityValue instance) { }

	public AppSetEntityValue Copy() { }

	public static AppSetEntityValue Deserialize(Stream stream) { }

	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream) { }

	public static AppSetEntityValue DeserializeLength(Stream stream, int length) { }

	public static AppSetEntityValue Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppSetEntityValue previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppSetEntityValue Deserialize(byte[] buffer, AppSetEntityValue instance, bool isDelta = False) { }

	public static AppSetEntityValue Deserialize(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	public static AppSetEntityValue DeserializeLength(Stream stream, int length, AppSetEntityValue instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppSetEntityValue instance, AppSetEntityValue previous) { }

	public static void Serialize(Stream stream, AppSetEntityValue instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppSetEntityValue instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppSetEntityValue instance) { }

	public void .ctor() { }

}

public class AppPromoteToLeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6530
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong steamId;


	public static void ResetToPool(AppPromoteToLeader instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppPromoteToLeader instance) { }

	public AppPromoteToLeader Copy() { }

	public static AppPromoteToLeader Deserialize(Stream stream) { }

	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream) { }

	public static AppPromoteToLeader DeserializeLength(Stream stream, int length) { }

	public static AppPromoteToLeader Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppPromoteToLeader previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppPromoteToLeader Deserialize(byte[] buffer, AppPromoteToLeader instance, bool isDelta = False) { }

	public static AppPromoteToLeader Deserialize(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	public static AppPromoteToLeader DeserializeLength(Stream stream, int length, AppPromoteToLeader instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppPromoteToLeader instance, AppPromoteToLeader previous) { }

	public static void Serialize(Stream stream, AppPromoteToLeader instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppPromoteToLeader instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppPromoteToLeader instance) { }

	public void .ctor() { }

}

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6531
{
	public bool ShouldPool;
	private bool _disposed;


	public static void ResetToPool(AppSuccess instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppSuccess instance) { }

	public AppSuccess Copy() { }

	public static AppSuccess Deserialize(Stream stream) { }

	public static AppSuccess DeserializeLengthDelimited(Stream stream) { }

	public static AppSuccess DeserializeLength(Stream stream, int length) { }

	public static AppSuccess Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppSuccess previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppSuccess Deserialize(byte[] buffer, AppSuccess instance, bool isDelta = False) { }

	public static AppSuccess Deserialize(Stream stream, AppSuccess instance, bool isDelta) { }

	public static AppSuccess DeserializeLengthDelimited(Stream stream, AppSuccess instance, bool isDelta) { }

	public static AppSuccess DeserializeLength(Stream stream, int length, AppSuccess instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppSuccess instance, AppSuccess previous) { }

	public static void Serialize(Stream stream, AppSuccess instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppSuccess instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppSuccess instance) { }

	public void .ctor() { }

}

public class AppError : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6532
{
	public bool ShouldPool;
	private bool _disposed;
	public string error;


	public static void ResetToPool(AppError instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppError instance) { }

	public AppError Copy() { }

	public static AppError Deserialize(Stream stream) { }

	public static AppError DeserializeLengthDelimited(Stream stream) { }

	public static AppError DeserializeLength(Stream stream, int length) { }

	public static AppError Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppError previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppError Deserialize(byte[] buffer, AppError instance, bool isDelta = False) { }

	public static AppError Deserialize(Stream stream, AppError instance, bool isDelta) { }

	public static AppError DeserializeLengthDelimited(Stream stream, AppError instance, bool isDelta) { }

	public static AppError DeserializeLength(Stream stream, int length, AppError instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppError instance, AppError previous) { }

	public static void Serialize(Stream stream, AppError instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppError instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppError instance) { }

	public void .ctor() { }

}

public class AppFlag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6533
{
	public bool ShouldPool;
	private bool _disposed;
	public bool value;


	public static void ResetToPool(AppFlag instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppFlag instance) { }

	public AppFlag Copy() { }

	public static AppFlag Deserialize(Stream stream) { }

	public static AppFlag DeserializeLengthDelimited(Stream stream) { }

	public static AppFlag DeserializeLength(Stream stream, int length) { }

	public static AppFlag Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppFlag previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppFlag Deserialize(byte[] buffer, AppFlag instance, bool isDelta = False) { }

	public static AppFlag Deserialize(Stream stream, AppFlag instance, bool isDelta) { }

	public static AppFlag DeserializeLengthDelimited(Stream stream, AppFlag instance, bool isDelta) { }

	public static AppFlag DeserializeLength(Stream stream, int length, AppFlag instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppFlag instance, AppFlag previous) { }

	public static void Serialize(Stream stream, AppFlag instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppFlag instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppFlag instance) { }

	public void .ctor() { }

}

public class AppInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6534
{
	public bool ShouldPool;
	private bool _disposed;
	public string name;
	public string headerImage;
	public string url;
	public string map;
	public uint mapSize;
	public uint wipeTime;
	public uint players;
	public uint maxPlayers;
	public uint queuedPlayers;
	public uint seed;
	public uint salt;
	public string logoImage;


	public static void ResetToPool(AppInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppInfo instance) { }

	public AppInfo Copy() { }

	public static AppInfo Deserialize(Stream stream) { }

	public static AppInfo DeserializeLengthDelimited(Stream stream) { }

	public static AppInfo DeserializeLength(Stream stream, int length) { }

	public static AppInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppInfo Deserialize(byte[] buffer, AppInfo instance, bool isDelta = False) { }

	public static AppInfo Deserialize(Stream stream, AppInfo instance, bool isDelta) { }

	public static AppInfo DeserializeLengthDelimited(Stream stream, AppInfo instance, bool isDelta) { }

	public static AppInfo DeserializeLength(Stream stream, int length, AppInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppInfo instance, AppInfo previous) { }

	public static void Serialize(Stream stream, AppInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppInfo instance) { }

	public void .ctor() { }

}

public class AppTime : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6535
{
	public bool ShouldPool;
	private bool _disposed;
	public float dayLengthMinutes;
	public float timeScale;
	public float sunrise;
	public float sunset;
	public float time;


	public static void ResetToPool(AppTime instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTime instance) { }

	public AppTime Copy() { }

	public static AppTime Deserialize(Stream stream) { }

	public static AppTime DeserializeLengthDelimited(Stream stream) { }

	public static AppTime DeserializeLength(Stream stream, int length) { }

	public static AppTime Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTime previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTime Deserialize(byte[] buffer, AppTime instance, bool isDelta = False) { }

	public static AppTime Deserialize(Stream stream, AppTime instance, bool isDelta) { }

	public static AppTime DeserializeLengthDelimited(Stream stream, AppTime instance, bool isDelta) { }

	public static AppTime DeserializeLength(Stream stream, int length, AppTime instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTime instance, AppTime previous) { }

	public static void Serialize(Stream stream, AppTime instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTime instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTime instance) { }

	public void .ctor() { }

}

public class AppMap : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6536
{
	public bool ShouldPool;
	private bool _disposed;
	public uint width;
	public uint height;
	public byte[] jpgImage;
	public int oceanMargin;
	public List<AppMap.Monument> monuments;
	public string background;


	public static void ResetToPool(AppMap instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppMap instance) { }

	public AppMap Copy() { }

	public static AppMap Deserialize(Stream stream) { }

	public static AppMap DeserializeLengthDelimited(Stream stream) { }

	public static AppMap DeserializeLength(Stream stream, int length) { }

	public static AppMap Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppMap previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppMap Deserialize(byte[] buffer, AppMap instance, bool isDelta = False) { }

	public static AppMap Deserialize(Stream stream, AppMap instance, bool isDelta) { }

	public static AppMap DeserializeLengthDelimited(Stream stream, AppMap instance, bool isDelta) { }

	public static AppMap DeserializeLength(Stream stream, int length, AppMap instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppMap instance, AppMap previous) { }

	public static void Serialize(Stream stream, AppMap instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppMap instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppMap instance) { }

	public void .ctor() { }

}

public class AppMap.Monument : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6537
{
	public bool ShouldPool;
	private bool _disposed;
	public string token;
	public float x;
	public float y;


	public static void ResetToPool(AppMap.Monument instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppMap.Monument instance) { }

	public AppMap.Monument Copy() { }

	public static AppMap.Monument Deserialize(Stream stream) { }

	public static AppMap.Monument DeserializeLengthDelimited(Stream stream) { }

	public static AppMap.Monument DeserializeLength(Stream stream, int length) { }

	public static AppMap.Monument Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppMap.Monument previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppMap.Monument Deserialize(byte[] buffer, AppMap.Monument instance, bool isDelta = False) { }

	public static AppMap.Monument Deserialize(Stream stream, AppMap.Monument instance, bool isDelta) { }

	public static AppMap.Monument DeserializeLengthDelimited(Stream stream, AppMap.Monument instance, bool isDelta) { }

	public static AppMap.Monument DeserializeLength(Stream stream, int length, AppMap.Monument instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppMap.Monument instance, AppMap.Monument previous) { }

	public static void Serialize(Stream stream, AppMap.Monument instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppMap.Monument instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppMap.Monument instance) { }

	public void .ctor() { }

}

public class AppEntityInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6538
{
	public bool ShouldPool;
	private bool _disposed;
	public AppEntityType type;
	public AppEntityPayload payload;


	public static void ResetToPool(AppEntityInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppEntityInfo instance) { }

	public AppEntityInfo Copy() { }

	public static AppEntityInfo Deserialize(Stream stream) { }

	public static AppEntityInfo DeserializeLengthDelimited(Stream stream) { }

	public static AppEntityInfo DeserializeLength(Stream stream, int length) { }

	public static AppEntityInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppEntityInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppEntityInfo Deserialize(byte[] buffer, AppEntityInfo instance, bool isDelta = False) { }

	public static AppEntityInfo Deserialize(Stream stream, AppEntityInfo instance, bool isDelta) { }

	public static AppEntityInfo DeserializeLengthDelimited(Stream stream, AppEntityInfo instance, bool isDelta) { }

	public static AppEntityInfo DeserializeLength(Stream stream, int length, AppEntityInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppEntityInfo instance, AppEntityInfo previous) { }

	public static void Serialize(Stream stream, AppEntityInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppEntityInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppEntityInfo instance) { }

	public void .ctor() { }

}

public class AppEntityPayload : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6539
{
	public bool ShouldPool;
	private bool _disposed;
	public bool value;
	public List<AppEntityPayload.Item> items;
	public int capacity;
	public bool hasProtection;
	public uint protectionExpiry;


	public static void ResetToPool(AppEntityPayload instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppEntityPayload instance) { }

	public AppEntityPayload Copy() { }

	public static AppEntityPayload Deserialize(Stream stream) { }

	public static AppEntityPayload DeserializeLengthDelimited(Stream stream) { }

	public static AppEntityPayload DeserializeLength(Stream stream, int length) { }

	public static AppEntityPayload Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppEntityPayload Deserialize(byte[] buffer, AppEntityPayload instance, bool isDelta = False) { }

	public static AppEntityPayload Deserialize(Stream stream, AppEntityPayload instance, bool isDelta) { }

	public static AppEntityPayload DeserializeLengthDelimited(Stream stream, AppEntityPayload instance, bool isDelta) { }

	public static AppEntityPayload DeserializeLength(Stream stream, int length, AppEntityPayload instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppEntityPayload instance, AppEntityPayload previous) { }

	public static void Serialize(Stream stream, AppEntityPayload instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppEntityPayload instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload instance) { }

	public void .ctor() { }

}

public class AppEntityPayload.Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6540
{
	public bool ShouldPool;
	private bool _disposed;
	public int itemId;
	public int quantity;
	public bool itemIsBlueprint;


	public static void ResetToPool(AppEntityPayload.Item instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppEntityPayload.Item instance) { }

	public AppEntityPayload.Item Copy() { }

	public static AppEntityPayload.Item Deserialize(Stream stream) { }

	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream) { }

	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length) { }

	public static AppEntityPayload.Item Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload.Item previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppEntityPayload.Item Deserialize(byte[] buffer, AppEntityPayload.Item instance, bool isDelta = False) { }

	public static AppEntityPayload.Item Deserialize(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length, AppEntityPayload.Item instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppEntityPayload.Item instance, AppEntityPayload.Item previous) { }

	public static void Serialize(Stream stream, AppEntityPayload.Item instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppEntityPayload.Item instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload.Item instance) { }

	public void .ctor() { }

}

public class AppTeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6541
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong leaderSteamId;
	public List<AppTeamInfo.Member> members;
	public List<AppTeamInfo.Note> mapNotes;
	public List<AppTeamInfo.Note> leaderMapNotes;


	public static void ResetToPool(AppTeamInfo instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTeamInfo instance) { }

	public AppTeamInfo Copy() { }

	public static AppTeamInfo Deserialize(Stream stream) { }

	public static AppTeamInfo DeserializeLengthDelimited(Stream stream) { }

	public static AppTeamInfo DeserializeLength(Stream stream, int length) { }

	public static AppTeamInfo Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTeamInfo Deserialize(byte[] buffer, AppTeamInfo instance, bool isDelta = False) { }

	public static AppTeamInfo Deserialize(Stream stream, AppTeamInfo instance, bool isDelta) { }

	public static AppTeamInfo DeserializeLengthDelimited(Stream stream, AppTeamInfo instance, bool isDelta) { }

	public static AppTeamInfo DeserializeLength(Stream stream, int length, AppTeamInfo instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTeamInfo instance, AppTeamInfo previous) { }

	public static void Serialize(Stream stream, AppTeamInfo instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTeamInfo instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo instance) { }

	public void .ctor() { }

}

public class AppTeamInfo.Member : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6542
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong steamId;
	public string name;
	public float x;
	public float y;
	public bool isOnline;
	public uint spawnTime;
	public bool isAlive;
	public uint deathTime;


	public static void ResetToPool(AppTeamInfo.Member instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTeamInfo.Member instance) { }

	public AppTeamInfo.Member Copy() { }

	public static AppTeamInfo.Member Deserialize(Stream stream) { }

	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream) { }

	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length) { }

	public static AppTeamInfo.Member Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Member previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTeamInfo.Member Deserialize(byte[] buffer, AppTeamInfo.Member instance, bool isDelta = False) { }

	public static AppTeamInfo.Member Deserialize(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length, AppTeamInfo.Member instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTeamInfo.Member instance, AppTeamInfo.Member previous) { }

	public static void Serialize(Stream stream, AppTeamInfo.Member instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTeamInfo.Member instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Member instance) { }

	public void .ctor() { }

}

public class AppTeamInfo.Note : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6543
{
	public bool ShouldPool;
	private bool _disposed;
	public int type;
	public float x;
	public float y;


	public static void ResetToPool(AppTeamInfo.Note instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTeamInfo.Note instance) { }

	public AppTeamInfo.Note Copy() { }

	public static AppTeamInfo.Note Deserialize(Stream stream) { }

	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream) { }

	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length) { }

	public static AppTeamInfo.Note Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Note previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTeamInfo.Note Deserialize(byte[] buffer, AppTeamInfo.Note instance, bool isDelta = False) { }

	public static AppTeamInfo.Note Deserialize(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length, AppTeamInfo.Note instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTeamInfo.Note instance, AppTeamInfo.Note previous) { }

	public static void Serialize(Stream stream, AppTeamInfo.Note instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTeamInfo.Note instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Note instance) { }

	public void .ctor() { }

}

public class AppChatMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6544
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong steamId;
	public string name;
	public string message;
	public string color;
	public uint time;


	public static void ResetToPool(AppChatMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppChatMessage instance) { }

	public AppChatMessage Copy() { }

	public static AppChatMessage Deserialize(Stream stream) { }

	public static AppChatMessage DeserializeLengthDelimited(Stream stream) { }

	public static AppChatMessage DeserializeLength(Stream stream, int length) { }

	public static AppChatMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppChatMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppChatMessage Deserialize(byte[] buffer, AppChatMessage instance, bool isDelta = False) { }

	public static AppChatMessage Deserialize(Stream stream, AppChatMessage instance, bool isDelta) { }

	public static AppChatMessage DeserializeLengthDelimited(Stream stream, AppChatMessage instance, bool isDelta) { }

	public static AppChatMessage DeserializeLength(Stream stream, int length, AppChatMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppChatMessage instance, AppChatMessage previous) { }

	public static void Serialize(Stream stream, AppChatMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppChatMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppChatMessage instance) { }

	public void .ctor() { }

}

public class AppTeamChat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6545
{
	public bool ShouldPool;
	private bool _disposed;
	public List<AppChatMessage> messages;


	public static void ResetToPool(AppTeamChat instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTeamChat instance) { }

	public AppTeamChat Copy() { }

	public static AppTeamChat Deserialize(Stream stream) { }

	public static AppTeamChat DeserializeLengthDelimited(Stream stream) { }

	public static AppTeamChat DeserializeLength(Stream stream, int length) { }

	public static AppTeamChat Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTeamChat previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTeamChat Deserialize(byte[] buffer, AppTeamChat instance, bool isDelta = False) { }

	public static AppTeamChat Deserialize(Stream stream, AppTeamChat instance, bool isDelta) { }

	public static AppTeamChat DeserializeLengthDelimited(Stream stream, AppTeamChat instance, bool isDelta) { }

	public static AppTeamChat DeserializeLength(Stream stream, int length, AppTeamChat instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTeamChat instance, AppTeamChat previous) { }

	public static void Serialize(Stream stream, AppTeamChat instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTeamChat instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTeamChat instance) { }

	public void .ctor() { }

}

public class AppMarker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6546
{
	public bool ShouldPool;
	private bool _disposed;
	public uint id;
	public AppMarkerType type;
	public float x;
	public float y;
	public ulong steamId;
	public float rotation;
	public float radius;
	public Vector4 color1;
	public Vector4 color2;
	public float alpha;
	public string name;
	public bool outOfStock;
	public List<AppMarker.SellOrder> sellOrders;


	public static void ResetToPool(AppMarker instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppMarker instance) { }

	public AppMarker Copy() { }

	public static AppMarker Deserialize(Stream stream) { }

	public static AppMarker DeserializeLengthDelimited(Stream stream) { }

	public static AppMarker DeserializeLength(Stream stream, int length) { }

	public static AppMarker Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppMarker previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppMarker Deserialize(byte[] buffer, AppMarker instance, bool isDelta = False) { }

	public static AppMarker Deserialize(Stream stream, AppMarker instance, bool isDelta) { }

	public static AppMarker DeserializeLengthDelimited(Stream stream, AppMarker instance, bool isDelta) { }

	public static AppMarker DeserializeLength(Stream stream, int length, AppMarker instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppMarker instance, AppMarker previous) { }

	public static void Serialize(Stream stream, AppMarker instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppMarker instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppMarker instance) { }

	public void .ctor() { }

}

public class AppMarker.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6547
{
	public bool ShouldPool;
	private bool _disposed;
	public int itemId;
	public int quantity;
	public int currencyId;
	public int costPerItem;
	public int amountInStock;
	public bool itemIsBlueprint;
	public bool currencyIsBlueprint;
	public float itemCondition;
	public float itemConditionMax;


	public static void ResetToPool(AppMarker.SellOrder instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppMarker.SellOrder instance) { }

	public AppMarker.SellOrder Copy() { }

	public static AppMarker.SellOrder Deserialize(Stream stream) { }

	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream) { }

	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length) { }

	public static AppMarker.SellOrder Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppMarker.SellOrder previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppMarker.SellOrder Deserialize(byte[] buffer, AppMarker.SellOrder instance, bool isDelta = False) { }

	public static AppMarker.SellOrder Deserialize(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length, AppMarker.SellOrder instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppMarker.SellOrder instance, AppMarker.SellOrder previous) { }

	public static void Serialize(Stream stream, AppMarker.SellOrder instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppMarker.SellOrder instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppMarker.SellOrder instance) { }

	public void .ctor() { }

}

public class AppMapMarkers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6548
{
	public bool ShouldPool;
	private bool _disposed;
	public List<AppMarker> markers;


	public static void ResetToPool(AppMapMarkers instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppMapMarkers instance) { }

	public AppMapMarkers Copy() { }

	public static AppMapMarkers Deserialize(Stream stream) { }

	public static AppMapMarkers DeserializeLengthDelimited(Stream stream) { }

	public static AppMapMarkers DeserializeLength(Stream stream, int length) { }

	public static AppMapMarkers Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppMapMarkers previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppMapMarkers Deserialize(byte[] buffer, AppMapMarkers instance, bool isDelta = False) { }

	public static AppMapMarkers Deserialize(Stream stream, AppMapMarkers instance, bool isDelta) { }

	public static AppMapMarkers DeserializeLengthDelimited(Stream stream, AppMapMarkers instance, bool isDelta) { }

	public static AppMapMarkers DeserializeLength(Stream stream, int length, AppMapMarkers instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppMapMarkers instance, AppMapMarkers previous) { }

	public static void Serialize(Stream stream, AppMapMarkers instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppMapMarkers instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppMapMarkers instance) { }

	public void .ctor() { }

}

public class AppTeamChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6549
{
	public bool ShouldPool;
	private bool _disposed;
	public ulong playerId;
	public AppTeamInfo teamInfo;


	public static void ResetToPool(AppTeamChanged instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTeamChanged instance) { }

	public AppTeamChanged Copy() { }

	public static AppTeamChanged Deserialize(Stream stream) { }

	public static AppTeamChanged DeserializeLengthDelimited(Stream stream) { }

	public static AppTeamChanged DeserializeLength(Stream stream, int length) { }

	public static AppTeamChanged Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTeamChanged previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTeamChanged Deserialize(byte[] buffer, AppTeamChanged instance, bool isDelta = False) { }

	public static AppTeamChanged Deserialize(Stream stream, AppTeamChanged instance, bool isDelta) { }

	public static AppTeamChanged DeserializeLengthDelimited(Stream stream, AppTeamChanged instance, bool isDelta) { }

	public static AppTeamChanged DeserializeLength(Stream stream, int length, AppTeamChanged instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTeamChanged instance, AppTeamChanged previous) { }

	public static void Serialize(Stream stream, AppTeamChanged instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTeamChanged instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTeamChanged instance) { }

	public void .ctor() { }

}

public class AppTeamMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6550
{
	public bool ShouldPool;
	private bool _disposed;
	public AppChatMessage message;


	public static void ResetToPool(AppTeamMessage instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppTeamMessage instance) { }

	public AppTeamMessage Copy() { }

	public static AppTeamMessage Deserialize(Stream stream) { }

	public static AppTeamMessage DeserializeLengthDelimited(Stream stream) { }

	public static AppTeamMessage DeserializeLength(Stream stream, int length) { }

	public static AppTeamMessage Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppTeamMessage previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppTeamMessage Deserialize(byte[] buffer, AppTeamMessage instance, bool isDelta = False) { }

	public static AppTeamMessage Deserialize(Stream stream, AppTeamMessage instance, bool isDelta) { }

	public static AppTeamMessage DeserializeLengthDelimited(Stream stream, AppTeamMessage instance, bool isDelta) { }

	public static AppTeamMessage DeserializeLength(Stream stream, int length, AppTeamMessage instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppTeamMessage instance, AppTeamMessage previous) { }

	public static void Serialize(Stream stream, AppTeamMessage instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppTeamMessage instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppTeamMessage instance) { }

	public void .ctor() { }

}

public class AppEntityChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6551
{
	public bool ShouldPool;
	private bool _disposed;
	public uint entityId;
	public AppEntityPayload payload;


	public static void ResetToPool(AppEntityChanged instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AppEntityChanged instance) { }

	public AppEntityChanged Copy() { }

	public static AppEntityChanged Deserialize(Stream stream) { }

	public static AppEntityChanged DeserializeLengthDelimited(Stream stream) { }

	public static AppEntityChanged DeserializeLength(Stream stream, int length) { }

	public static AppEntityChanged Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AppEntityChanged previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AppEntityChanged Deserialize(byte[] buffer, AppEntityChanged instance, bool isDelta = False) { }

	public static AppEntityChanged Deserialize(Stream stream, AppEntityChanged instance, bool isDelta) { }

	public static AppEntityChanged DeserializeLengthDelimited(Stream stream, AppEntityChanged instance, bool isDelta) { }

	public static AppEntityChanged DeserializeLength(Stream stream, int length, AppEntityChanged instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AppEntityChanged instance, AppEntityChanged previous) { }

	public static void Serialize(Stream stream, AppEntityChanged instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AppEntityChanged instance) { }

	public static void SerializeLengthDelimited(Stream stream, AppEntityChanged instance) { }

	public void .ctor() { }

}

public enum AppEntityType // TypeDefIndex: 6569
{
	public int value__;
	public const AppEntityType Switch = 1;
	public const AppEntityType Alarm = 2;
	public const AppEntityType StorageMonitor = 3;

}

public enum AppMarkerType // TypeDefIndex: 6570
{
	public int value__;
	public const AppMarkerType Undefined = 0;
	public const AppMarkerType Player = 1;
	public const AppMarkerType Explosion = 2;
	public const AppMarkerType VendingMachine = 3;
	public const AppMarkerType CH47 = 4;
	public const AppMarkerType CargoShip = 5;
	public const AppMarkerType Crate = 6;
	public const AppMarkerType GenericRadius = 7;
	public const AppMarkerType PatrolHelicopter = 8;

}

public static class Application // TypeDefIndex: 6625
{
	public static bool isQuitting;
	public static bool isLoading;
	public static bool isReceiving;
	public static bool isLoadingSave;
	public static bool isLoadingPrefabs;

	public static string installPath { get; }
	public static string dataPath { get; }


	public static void Quit() { }

	public static string get_installPath() { }

	public static string get_dataPath() { }

	private static void .cctor() { }

}

public enum AppCategory // TypeDefIndex: 7688
{
	public int value__;
	public const AppCategory Invalid = 0;
	public const AppCategory Utility = 1;
	public const AppCategory Game = 2;

}

public static class Approved // TypeDefIndex: 7738
{
	private static Dictionary<ulong, ApprovedSkinInfo> _all;

	public static IReadOnlyDictionary<ulong, ApprovedSkinInfo> All { get; }


	private static void Add_2016() { }

	private static void Add_December_29_2016() { }

	private static void Add_December_22_2016() { }

	private static void Add_December_15_2016() { }

	private static void Add_December_8_2016() { }

	private static void Add_December_2_2018() { }

	private static void Add_December_1_2016() { }

	private static void Add_November_24_2016() { }

	private static void Add_November_17_2016() { }

	private static void Add_November_16_2016() { }

	private static void Add_November_10_2016() { }

	private static void Add_November_3_2016() { }

	private static void Add_2017() { }

	private static void Add_December_28_2017() { }

	private static void Add_December_21_2017() { }

	private static void Add_December_14_2017() { }

	private static void Add_December_7_2017() { }

	private static void Add_November_30_2017() { }

	private static void Add_November_23_2017() { }

	private static void Add_November_16_2017() { }

	private static void Add_November_9_2017() { }

	private static void Add_November_2_2017() { }

	private static void Add_October_26_2017() { }

	private static void Add_October_19_2017() { }

	private static void Add_October_12_2017() { }

	private static void Add_October_5_2017() { }

	private static void Add_September_28_2017() { }

	private static void Add_September_21_2017() { }

	private static void Add_September_14_2017() { }

	private static void Add_September_7_2017() { }

	private static void Add_August_31_2017() { }

	private static void Add_August_24_2017() { }

	private static void Add_August_17_2017() { }

	private static void Add_August_10_2017() { }

	private static void Add_August_3_2017() { }

	private static void Add_July_27_2017() { }

	private static void Add_July_20_2017() { }

	private static void Add_July_13_2017() { }

	private static void Add_July_6_2017() { }

	private static void Add_June_29_2017() { }

	private static void Add_June_15_2017() { }

	private static void Add_June_8_2017() { }

	private static void Add_June_1_2017() { }

	private static void Add_May_25_2017() { }

	private static void Add_May_18_2017() { }

	private static void Add_May_11_2017() { }

	private static void Add_May_4_2017() { }

	private static void Add_April_27_2017() { }

	private static void Add_April_20_2017() { }

	private static void Add_April_13_2017() { }

	private static void Add_April_6_2017() { }

	private static void Add_March_30_2017() { }

	private static void Add_March_23_2017() { }

	private static void Add_March_15_2017() { }

	private static void Add_March_8_2017() { }

	private static void Add_March_2_2017() { }

	private static void Add_February_23_2017() { }

	private static void Add_February_16_2017() { }

	private static void Add_February_9_2017() { }

	private static void Add_February_2_2017() { }

	private static void Add_January_18_2017() { }

	private static void Add_January_12_2017() { }

	private static void Add_January_4_2017() { }

	private static void Add_2018() { }

	private static void Add_December_20_2018() { }

	private static void Add_December_13_2020() { }

	private static void Add_December_6_2018() { }

	private static void Add_November_29_2018() { }

	private static void Add_November_22_2018() { }

	private static void Add_November_15_2018() { }

	private static void Add_November_9_2018() { }

	private static void Add_November_1_2018() { }

	private static void Add_October_26_2018() { }

	private static void Add_October_19_2018() { }

	private static void Add_October_11_2018() { }

	private static void Add_October_4_2018() { }

	private static void Add_September_27_2018() { }

	private static void Add_September_20_2018() { }

	private static void Add_September_14_2018() { }

	private static void Add_September_5_2018() { }

	private static void Add_August_23_2018() { }

	private static void Add_August_16_2018() { }

	private static void Add_August_9_2018() { }

	private static void Add_August_2_2018() { }

	private static void Add_July_26_2018() { }

	private static void Add_July_19_2018() { }

	private static void Add_July_12_2018() { }

	private static void Add_July_5_2018() { }

	private static void Add_June_28_2018() { }

	private static void Add_June_22_2018() { }

	private static void Add_June_14_2018() { }

	private static void Add_June_7_2018() { }

	private static void Add_May_31_2018() { }

	private static void Add_May_24_2018() { }

	private static void Add_May_2_2018() { }

	private static void Add_April_26_2018() { }

	private static void Add_April_19_2018() { }

	private static void Add_April_12_2018() { }

	private static void Add_April_5_2018() { }

	private static void Add_March_29_2018() { }

	private static void Add_March_22_2018() { }

	private static void Add_March_15_2018() { }

	private static void Add_March_8_2018() { }

	private static void Add_March_1_2018() { }

	private static void Add_February_22_2018() { }

	private static void Add_February_15_2018() { }

	private static void Add_February_8_2018() { }

	private static void Add_February_1_2018() { }

	private static void Add_January_25_2018() { }

	private static void Add_January_18_2018() { }

	private static void Add_January_11_2018() { }

	private static void Add_January_4_2018() { }

	private static void Add_2019() { }

	private static void Add_December_27_2019() { }

	private static void Add_December_19_2019() { }

	private static void Add_December_12_2019() { }

	private static void Add_December_5_2019() { }

	private static void Add_November_28_2019() { }

	private static void Add_November_21_2019() { }

	private static void Add_November_14_2019() { }

	private static void Add_November_7_2019() { }

	private static void Add_October_31_2019() { }

	private static void Add_October_24_2019() { }

	private static void Add_October_18_2019() { }

	private static void Add_October_11_2019() { }

	private static void Add_October_3_2019() { }

	private static void Add_September_26_2019() { }

	private static void Add_September_19_2019() { }

	private static void Add_September_12_2019() { }

	private static void Add_September_9_2019() { }

	private static void Add_August_29_2019() { }

	private static void Add_August_22_2019() { }

	private static void Add_August_15_2019() { }

	private static void Add_August_9_2019() { }

	private static void Add_August_1_2019() { }

	private static void Add_July_26_2019() { }

	private static void Add_July_19_2019() { }

	private static void Add_July_12_2019() { }

	private static void Add_July_5_2019() { }

	private static void Add_June_28_2019() { }

	private static void Add_June_21_2019() { }

	private static void Add_June_14_2019() { }

	private static void Add_June_6_2019() { }

	private static void Add_May_30_2019() { }

	private static void Add_May_23_2019() { }

	private static void Add_May_16_2019() { }

	private static void Add_May_9_2019() { }

	private static void Add_May_2_2019() { }

	private static void Add_April_25_2019() { }

	private static void Add_April_19_2019() { }

	private static void Add_April_11_2019() { }

	private static void Add_April_5_2019() { }

	private static void Add_March_28_2019() { }

	private static void Add_March_22_2019() { }

	private static void Add_March_14_2019() { }

	private static void Add_March_7_2019() { }

	private static void Add_February_28_2019() { }

	private static void Add_February_22_2019() { }

	private static void Add_February_14_2019() { }

	private static void Add_February_7_2019() { }

	private static void Add_January_31_2019() { }

	private static void Add_January_24_2019() { }

	private static void Add_January_17_2019() { }

	private static void Add_January_10_2019() { }

	private static void Add_January_3_2019() { }

	private static void Add_2020() { }

	private static void Add_December_31_2020() { }

	private static void Add_December_24_2020() { }

	private static void Add_December_18_2020() { }

	private static void Add_December_10_2020() { }

	private static void Add_December_03_2020() { }

	private static void Add_November_26_2020() { }

	private static void Add_November_19_2020() { }

	private static void Add_November_12_2020() { }

	private static void Add_November_05_2020() { }

	private static void Add_October_29_2020() { }

	private static void Add_October_22_2020() { }

	private static void Add_October_16_2020() { }

	private static void Add_October_8_2020() { }

	private static void Add_October_1_2020() { }

	private static void Add_September_24_2020() { }

	private static void Add_September_17_2020() { }

	private static void Add_September_10_2020() { }

	private static void Add_September_3_2020() { }

	private static void Add_August_27_2020() { }

	private static void Add_August_21_2020() { }

	private static void Add_August_13_2020() { }

	private static void Add_August_06_2020() { }

	private static void Add_July_31_2020() { }

	private static void Add_July_24_2020() { }

	private static void Add_July_17_2020() { }

	private static void Add_July_9_2020() { }

	private static void Add_July_2_2020() { }

	private static void Add_June_26_2020() { }

	private static void Add_June_19_2020() { }

	private static void Add_June_11_2020() { }

	private static void Add_June_4_2020() { }

	private static void Add_May_28_2020() { }

	private static void Add_May_21_2020() { }

	private static void Add_May_14_2020() { }

	private static void Add_May_8_2020() { }

	private static void Add_April_30_2020() { }

	private static void Add_April_24_2020() { }

	private static void Add_April_16_2020() { }

	private static void Add_April_9_2020() { }

	private static void Add_April_2_2020() { }

	private static void Add_March_28_2020() { }

	private static void Add_March_20_2020() { }

	private static void Add_March_13_2020() { }

	private static void Add_March_5_2020() { }

	private static void Add_February_27_2020() { }

	private static void Add_February_21_2020() { }

	private static void Add_February_13_2020() { }

	private static void Add_February_6_2020() { }

	private static void Add_January_31_2020() { }

	private static void Add_January_17_2020() { }

	private static void Add_January_10_2020() { }

	private static void Add_January_2_2020() { }

	private static void Add_2021() { }

	private static void Add_December_30_2021() { }

	private static void Add_December_23_2021() { }

	private static void Add_December_16_2021() { }

	private static void Add_December_09_2021() { }

	private static void Add_December_02_2021() { }

	private static void Add_November_25_2021() { }

	private static void Add_November_19_2021_TWITCHDROPS() { }

	private static void Add_November_18_2021() { }

	private static void Add_November_19_2021_CHARITABLE_RUST() { }

	private static void Add_November_11_2021() { }

	private static void Add_November_04_2021() { }

	private static void Add_October_27_2021() { }

	private static void Add_October_21_2021() { }

	private static void Add_October_14_2021() { }

	private static void Add_October_07_2021() { }

	private static void Add_September_30_2021() { }

	private static void Add_September_23_2021() { }

	private static void Add_September_16_2021() { }

	private static void Add_September_09_2021() { }

	private static void Add_September_02_2021() { }

	private static void Add_September_01_2021_STREAMERSKINS() { }

	private static void Add_August_26_2021() { }

	private static void Add_August_19_2021() { }

	private static void Add_August_12_2021() { }

	private static void Add_August_04_2021() { }

	private static void Add_July_29_2021() { }

	private static void Add_July_22_2021() { }

	private static void Add_July_15_2021_STREAMERSKINS() { }

	private static void Add_July_15_2021() { }

	private static void Add_July_08_2021() { }

	private static void Add_July_05_2021_STREAMERSKINS() { }

	private static void Add_July_01_2021() { }

	private static void Add_June_24_2021() { }

	private static void Add_June_17_2021() { }

	private static void Add_June_10_2021() { }

	private static void Add_June_03_2021() { }

	private static void Add_May_27_2021() { }

	private static void Add_May_20_2021() { }

	private static void Add_May_13_2021() { }

	private static void Add_May_06_2021() { }

	private static void Add_May_05_2021_STREAMERSKINS() { }

	private static void Add_April_29_2021() { }

	private static void Add_April_22_2021() { }

	private static void Add_April_15_2021() { }

	private static void Add_April_09_2021() { }

	private static void Add_April_01_2021() { }

	private static void Add_March_31_2021_STREAMERSKINS() { }

	private static void Add_March_25_2021() { }

	private static void Add_March_18_2021() { }

	private static void Add_March_11_2021() { }

	private static void Add_March_04_2021() { }

	private static void Add_March_03_2021_STREAMERSKINS() { }

	private static void Add_February_25_2021() { }

	private static void Add_February_18_2021() { }

	private static void Add_February_11_2021() { }

	private static void Add_February_10_2021_STREAMERSKINS() { }

	private static void Add_February_04_2021() { }

	private static void Add_February_03_2021_STREAMERSKINS() { }

	private static void Add_January_28_2021() { }

	private static void Add_January_21_2021() { }

	private static void Add_January_15_2021_STREAMERSKINS() { }

	private static void Add_January_14_2021() { }

	private static void Add_January_07_2021() { }

	private static void Add_January_06_2021_STREAMERSKINS() { }

	private static void Add_2022() { }

	private static void Add_November_24_2022() { }

	private static void Add_november_18_CHARITABLERUST_FORSALE() { }

	private static void Add_November_18_2022() { }

	private static void Add_November_10_2022_CHARITABLERUST() { }

	private static void Add_November_10_2022() { }

	private static void Add_November_03_2022() { }

	private static void Add_October_27_2022() { }

	private static void Add_October_20_2022() { }

	private static void Add_October_13_2022() { }

	private static void Add_October_06_2022() { }

	private static void Add_October_04_2022_STREAMERSKINS() { }

	private static void Add_September_28_2022() { }

	private static void Add_September_22_2022() { }

	private static void Add_September_15_2022() { }

	private static void Add_September_08_2022() { }

	private static void Add_September_01_2022() { }

	private static void Add_August_25_2022() { }

	private static void Add_August_18_2022() { }

	private static void Add_August_11_2022() { }

	private static void Add_August_08_2022_STREAMERSKINS() { }

	private static void Add_August_04_2022() { }

	private static void Add_July_28_2022() { }

	private static void Add_July_21_2022() { }

	private static void Add_July_14_2022() { }

	private static void Add_July_07_2022() { }

	private static void Add_June_30_2022() { }

	private static void Add_June_23_2022() { }

	private static void Add_June_16_2022() { }

	private static void Add_June_09_2022() { }

	private static void Add_June_02_2022() { }

	private static void Add_May_26_2022() { }

	private static void Add_May_19_2022() { }

	private static void Add_May_12_2022() { }

	private static void Add_May_05_2022() { }

	private static void Add_May_04_2022_STREAMERSKINS() { }

	private static void Add_April_28_2022() { }

	private static void Add_April_21_2022() { }

	private static void Add_April_14_2022_EASTER() { }

	private static void Add_April_13_2022_STREAMERSKINS() { }

	private static void Add_April_07_2022() { }

	private static void Add_March_31_2022() { }

	private static void Add_March_24_2022() { }

	private static void Add_March_17_2022_STREAMERSKINS() { }

	private static void Add_March_17_2022() { }

	private static void Add_March_10_2022() { }

	private static void Add_March_03_2022() { }

	private static void Add_February_24_2022() { }

	private static void Add_February_17_2022() { }

	private static void Add_February_10_2022() { }

	private static void Add_February_03_2022() { }

	private static void Add_February_01_2022_STREAMERSKINS() { }

	private static void Add_January_28_2022() { }

	private static void Add_January_20_2022() { }

	private static void Add_January_13_2022() { }

	private static void Add_January_06_2022_STREAMERSKINS() { }

	private static void Add_January_06_2022() { }

	private static void Add_Unlimited() { }

	public static IReadOnlyDictionary<ulong, ApprovedSkinInfo> get_All() { }

	private static void Initialize() { }

	private static void Add(ApprovedSkinInfo skin) { }

	public static ApprovedSkinInfo FindByInventoryId(int id) { }

	private static void EnsureInitialized() { }

}

public class ApprovedSkinInfo // TypeDefIndex: 7754
{
	[CompilerGeneratedAttribute]
	private ulong <InventoryId>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <Desc>k__BackingField;
	[CompilerGeneratedAttribute]
	private string <Name>k__BackingField;
	[CompilerGeneratedAttribute]
	private ulong <WorkshopdId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Price <Price>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <Tradable>k__BackingField;
	[CompilerGeneratedAttribute]
	private DropChance <DropChance>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <Marketable>k__BackingField;
	[CompilerGeneratedAttribute]
	private Skinnable <Skinnable>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <AllowInCrates>k__BackingField;
	[CompilerGeneratedAttribute]
	private bool <IsLimitedTimeOffer>k__BackingField;

	public ulong InventoryId { get; set; }
	public string Desc { get; set; }
	public string Name { get; set; }
	public ulong WorkshopdId { get; set; }
	internal Price Price { get; set; }
	public bool Tradable { get; set; }
	public DropChance DropChance { get; set; }
	public bool Marketable { get; set; }
	public Skinnable Skinnable { get; set; }
	public bool AllowInCrates { get; set; }
	public bool IsLimitedTimeOffer { get; set; }


	[CompilerGeneratedAttribute]
	public ulong get_InventoryId() { }

	[CompilerGeneratedAttribute]
	private void set_InventoryId(ulong value) { }

	[CompilerGeneratedAttribute]
	public string get_Desc() { }

	[CompilerGeneratedAttribute]
	private void set_Desc(string value) { }

	[CompilerGeneratedAttribute]
	public string get_Name() { }

	[CompilerGeneratedAttribute]
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute]
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute]
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute]
	internal Price get_Price() { }

	[CompilerGeneratedAttribute]
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute]
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute]
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute]
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute]
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute]
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute]
	private void set_Marketable(bool value) { }

	[CompilerGeneratedAttribute]
	public Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute]
	private void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute]
	public bool get_AllowInCrates() { }

	[CompilerGeneratedAttribute]
	private void set_AllowInCrates(bool value) { }

	[CompilerGeneratedAttribute]
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute]
	private void set_IsLimitedTimeOffer(bool value) { }

	public void .ctor(ulong WorkshopdId, string Name, string Desc, string ItemName) { }

	public ApprovedSkinInfo Store(Price Price, bool CanBeTraded, bool CanBeSold) { }

	public ApprovedSkinInfo TimeLimited() { }

	public ApprovedSkinInfo Unlimited() { }

	public ApprovedSkinInfo NoCrate() { }

	public ApprovedSkinInfo Drops(DropChance DropChance) { }

	public ApprovedSkinInfo ItemId(ulong InventoryId) { }

	public static ItemSchema.Item op_Implicit(ApprovedSkinInfo o) { }

}

private sealed class ApprovedSkinInfo.<>c__DisplayClass44_0 // TypeDefIndex: 7755
{
	public string ItemName;


	public void .ctor() { }

	internal bool <.ctor>

}

public enum ApplicationStatus // TypeDefIndex: 9864
{
	public int value__;
	public const ApplicationStatus BackgroundConstrained = 0;
	public const ApplicationStatus BackgroundUnconstrained = 1;
	public const ApplicationStatus BackgroundSuspended = 2;
	public const ApplicationStatus Foreground = 3;

}

public abstract class AppIOEntity : IOEntity // TypeDefIndex: 10022
{
	private Option __menuOption_Menu_Pair;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_Pair(BasePlayer player) { }

	public bool Menu_ShowIf(BasePlayer player) { }

	protected void .ctor() { }

}

public class ApplyTerrainAnchors : MonoBehaviour // TypeDefIndex: 12130
{

	protected void Awake() { }

	public void .ctor() { }

}

public class ApplyTerrainModifiers : MonoBehaviour // TypeDefIndex: 12332
{

	protected void Awake() { }

	public void .ctor() { }

}

public class ApplyTweakUIChanges : MonoBehaviour // TypeDefIndex: 12925
{
	public Button ApplyButton;
	public TweakUIBase[] Options;


	private void OnEnable() { }

	public void Apply() { }

	public void SetDirty() { }

	public void SetClean() { }

	public void .ctor() { }

}

public class App : ConsoleSystem // TypeDefIndex: 13686
{
	[ServerVar]
	public static string listenip;
	[ServerVar]
	public static int port;
	[ServerVar]
	public static string publicip;
	[ServerVar]
	public static bool update;
	[ServerVar]
	public static bool notifications;
	[ServerVar]
	public static int queuelimit;
	[ReplicatedVar]
	public static string serverid;
	[ServerVar]
	public static float alarmcooldown;
	[ServerVar]
	public static int maxconnections;
	[ServerVar]
	public static int maxconnectionsperip;


	public void .ctor() { }

	private static void .cctor() { }

}

