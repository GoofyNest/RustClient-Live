internal static class AppContextSwitches // TypeDefIndex: 142
{	public static readonly bool ThrowExceptionIfDisposedCancellationTokenSource; // 0x0
	public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity; // 0x1
	public static readonly bool NoAsyncCurrentCulture; // 0x2
	public static readonly bool PreserveEventListnerObjectIdentity; // 0x3

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
{	private IntPtr _mono_app_domain; // 0x18
	private static string _process_guid; // 0x0
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Dictionary<string, object> type_resolve_in_progress; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Dictionary<string, object> assembly_resolve_in_progress; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Dictionary<string, object> assembly_resolve_in_progress_refonly; // 0x80000010
	private object _evidence; // 0x20
	private object _granted; // 0x28
	private int _principalPolicy; // 0x30
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static object _principal; // 0x80000018
	private static AppDomain default_domain; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AssemblyLoadEventHandler AssemblyLoad; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ResolveEventHandler AssemblyResolve; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler DomainUnload; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler ProcessExit; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ResolveEventHandler ResourceResolve; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ResolveEventHandler TypeResolve; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private UnhandledExceptionEventHandler UnhandledException; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EventHandler<FirstChanceExceptionEventArgs> FirstChanceException; // 0x70
	private object _domain_manager; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; // 0x80
	private object _activation; // 0x88
	private object _applicationIdentity; // 0x90
	private List<string> compatibility_switch; // 0x98

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

	[ObsoleteAttribute] // RVA: 0x8C670 Offset: 0x8BA70 VA: 0x18008C670
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

	[ObsoleteAttribute] // RVA: 0x8C860 Offset: 0x8BC60 VA: 0x18008C860
	public static int GetCurrentThreadId() { }

	public override string ToString() { }

	private void DoAssemblyLoad(Assembly assembly) { }

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	internal Assembly DoTypeResolve(object name_or_tb) { }

	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	private void DoDomainUnload() { }

	internal byte[] GetMarshalledDomainObjRef() { }

	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

}

public sealed class AppDomainSetup // TypeDefIndex: 346
{	private string application_base; // 0x10
	private string application_name; // 0x18
	private string cache_path; // 0x20
	private string configuration_file; // 0x28
	private string dynamic_base; // 0x30
	private string license_file; // 0x38
	private string private_bin_path; // 0x40
	private string private_bin_path_probe; // 0x48
	private string shadow_copy_directories; // 0x50
	private string shadow_copy_files; // 0x58
	private bool publisher_policy; // 0x60
	private bool path_changed; // 0x61
	private int loader_optimization; // 0x64
	private bool disallow_binding_redirects; // 0x68
	private bool disallow_code_downloads; // 0x69
	private object _activationArguments; // 0x70
	private object domain_initializer; // 0x78
	private object application_trust; // 0x80
	private string[] domain_initializer_args; // 0x88
	private bool disallow_appbase_probe; // 0x90
	private byte[] configuration_bytes; // 0x98
	private byte[] serialized_non_primitives; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <TargetFrameworkName>k__BackingField; // 0xA8

	public string ApplicationBase { get; }


	public void .ctor() { }

	private static string GetAppBase(string appBase) { }

	public string get_ApplicationBase() { }

}

internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1203
{	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	public IActivator NextActivator { get; }


	public void .ctor(string activationUrl, IActivator next) { }

	public IActivator get_NextActivator() { }

	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

public class Application // TypeDefIndex: 3354
{	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Application.LowMemoryCallback lowMemory; // 0x0
	private static Application.LogCallback s_LogCallbackHandler; // 0x8
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<bool> focusChanged; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action<string> deepLinkActivated; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Func<bool> wantsToQuit; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Action quitting; // 0x30

	public static bool isPlaying { get; }
	public static string dataPath { get; }
	public static string streamingAssetsPath { get; }
	[SecurityCriticalAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
	[ObsoleteAttribute] // RVA: 0x75730 Offset: 0x74B30 VA: 0x180075730
	public static string loadedLevelName { get; }
	public static bool isEditor { get; }


	[FreeFunctionAttribute] // RVA: 0x70D00 Offset: 0x70100 VA: 0x180070D00
	public static void Quit(int exitCode) { }

	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0x70EE0 Offset: 0x702E0 VA: 0x180070EE0
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute] // RVA: 0x71040 Offset: 0x70440 VA: 0x180071040
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x711B0 Offset: 0x705B0 VA: 0x1800711B0
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x71340 Offset: 0x70740 VA: 0x180071340
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x714A0 Offset: 0x708A0 VA: 0x1800714A0
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0x71620 Offset: 0x70A20 VA: 0x180071620
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0x717C0 Offset: 0x70BC0 VA: 0x1800717C0
	public static string get_companyName() { }

	[FreeFunctionAttribute] // RVA: 0x71820 Offset: 0x70C20 VA: 0x180071820
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x71980 Offset: 0x70D80 VA: 0x180071980
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0x71A90 Offset: 0x70E90 VA: 0x180071A90
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0x71C10 Offset: 0x71010 VA: 0x180071C10
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0x71D70 Offset: 0x71170 VA: 0x180071D70
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute] // RVA: 0x71F30 Offset: 0x71330 VA: 0x180071F30
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute] // RVA: 0x72120 Offset: 0x71520 VA: 0x180072120
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute] // RVA: 0x72200 Offset: 0x71600 VA: 0x180072200
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x72380 Offset: 0x71780 VA: 0x180072380
	public static RuntimePlatform get_platform() { }

	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0x73810 Offset: 0x72C10 VA: 0x180073810
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0x739C0 Offset: 0x72DC0 VA: 0x1800739C0
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void CallLowMemory() { }

	public static void add_logMessageReceived(Application.LogCallback value) { }

	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

public struct AppId // TypeDefIndex: 5235
{	public uint Value; // 0x0


	public override string ToString() { }

	public static AppId op_Implicit(uint value) { }

	public static AppId op_Implicit(int value) { }

	public static uint op_Implicit(AppId value) { }

}

internal struct AppResumingFromSuspend_t : ICallbackData // TypeDefIndex: 5333
{	public static int _datasize; // 0x12BF6

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

internal struct AppProofOfPurchaseKeyResponse_t : ICallbackData // TypeDefIndex: 5401
{	internal Result Result; // 0x0
	internal uint AppID; // 0x4
	internal uint CchKeyLength; // 0x8
	internal byte[] Key; // 0x10
	public static int _datasize; // 0x0

	public int DataSize { get; }
	public CallbackType CallbackType { get; }


	public int get_DataSize() { }

	public CallbackType get_CallbackType() { }

	private static void .cctor() { }

}

public static class Application // TypeDefIndex: 6176
{	private static MonoBehaviour _controller; // 0x0
	public static Manifest Manifest; // 0x8
	public static Dictionary<IPEndPoint, int> ServerMetadata; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static BaseIntegration <Integration>k__BackingField; // 0x18

	public static MonoBehaviour Controller { get; }
	public static BaseIntegration Integration { get; set; }


	public static MonoBehaviour get_Controller() { }

	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_Integration(BaseIntegration value) { }

}

internal class ApplicationControllerMonobehaviour : MonoBehaviour // TypeDefIndex: 6217
{
	public void OnApplicationQuit() { }

	public void Update() { }

	public void .ctor() { }

}

public struct AppInfo // TypeDefIndex: 6240
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Image>k__BackingField; // 0x0

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Image(string value) { }

}

public class Approval : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6476
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string level; // 0x18
	public string hostname; // 0x20
	public bool modded; // 0x28
	public bool official; // 0x29
	public ulong steamid; // 0x30
	public uint ipaddress; // 0x38
	public int port; // 0x3C
	public uint levelSeed; // 0x40
	public uint levelSize; // 0x44
	public string checksum; // 0x48
	public uint encryption; // 0x50
	public string levelUrl; // 0x58
	public bool levelTransfer; // 0x60


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

public class AppRequest : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6511
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seq; // 0x14
	public ulong playerId; // 0x18
	public int playerToken; // 0x20
	public uint entityId; // 0x24
	public AppEmpty getInfo; // 0x28
	public AppEmpty getTime; // 0x30
	public AppEmpty getMap; // 0x38
	public AppEmpty getTeamInfo; // 0x40
	public AppEmpty getTeamChat; // 0x48
	public AppSendMessage sendTeamMessage; // 0x50
	public AppEmpty getEntityInfo; // 0x58
	public AppSetEntityValue setEntityValue; // 0x60
	public AppEmpty checkSubscription; // 0x68
	public AppFlag setSubscription; // 0x70
	public AppEmpty getMapMarkers; // 0x78
	public AppPromoteToLeader promoteToLeader; // 0x80


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

public class AppMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6512
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppResponse response; // 0x18
	public AppBroadcast broadcast; // 0x20


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

public class AppResponse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6513
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint seq; // 0x14
	public AppSuccess success; // 0x18
	public AppError error; // 0x20
	public AppInfo info; // 0x28
	public AppTime time; // 0x30
	public AppMap map; // 0x38
	public AppTeamInfo teamInfo; // 0x40
	public AppTeamChat teamChat; // 0x48
	public AppEntityInfo entityInfo; // 0x50
	public AppFlag flag; // 0x58
	public AppMapMarkers mapMarkers; // 0x60


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

public class AppBroadcast : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6514
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppTeamChanged teamChanged; // 0x18
	public AppTeamMessage teamMessage; // 0x20
	public AppEntityChanged entityChanged; // 0x28


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

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6515
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11


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

public class AppSendMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6516
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string message; // 0x18


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

public class AppSetEntityValue : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6517
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12


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

public class AppPromoteToLeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6518
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18


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

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6519
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11


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

public class AppError : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6520
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string error; // 0x18


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

public class AppFlag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6521
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12


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

public class AppInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6522
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18
	public string headerImage; // 0x20
	public string url; // 0x28
	public string map; // 0x30
	public uint mapSize; // 0x38
	public uint wipeTime; // 0x3C
	public uint players; // 0x40
	public uint maxPlayers; // 0x44
	public uint queuedPlayers; // 0x48
	public uint seed; // 0x4C
	public uint salt; // 0x50
	public string logoImage; // 0x58


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

public class AppTime : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6523
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float dayLengthMinutes; // 0x14
	public float timeScale; // 0x18
	public float sunrise; // 0x1C
	public float sunset; // 0x20
	public float time; // 0x24


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

public class AppMap : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6524
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint width; // 0x14
	public uint height; // 0x18
	public byte[] jpgImage; // 0x20
	public int oceanMargin; // 0x28
	public List<AppMap.Monument> monuments; // 0x30
	public string background; // 0x38


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

public class AppMap.Monument : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6525
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string token; // 0x18
	public float x; // 0x20
	public float y; // 0x24


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

public class AppEntityInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6526
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppEntityType type; // 0x14
	public AppEntityPayload payload; // 0x18


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

public class AppEntityPayload : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6527
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12
	public List<AppEntityPayload.Item> items; // 0x18
	public int capacity; // 0x20
	public bool hasProtection; // 0x24
	public uint protectionExpiry; // 0x28


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

public class AppEntityPayload.Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6528
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemId; // 0x14
	public int quantity; // 0x18
	public bool itemIsBlueprint; // 0x1C


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

public class AppTeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6529
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong leaderSteamId; // 0x18
	public List<AppTeamInfo.Member> members; // 0x20
	public List<AppTeamInfo.Note> mapNotes; // 0x28
	public List<AppTeamInfo.Note> leaderMapNotes; // 0x30


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

public class AppTeamInfo.Member : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6530
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18
	public string name; // 0x20
	public float x; // 0x28
	public float y; // 0x2C
	public bool isOnline; // 0x30
	public uint spawnTime; // 0x34
	public bool isAlive; // 0x38
	public uint deathTime; // 0x3C


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

public class AppTeamInfo.Note : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6531
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public float x; // 0x18
	public float y; // 0x1C


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

public class AppChatMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6532
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18
	public string name; // 0x20
	public string message; // 0x28
	public string color; // 0x30
	public uint time; // 0x38


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

public class AppTeamChat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6533
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppChatMessage> messages; // 0x18


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

public class AppMarker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6534
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint id; // 0x14
	public AppMarkerType type; // 0x18
	public float x; // 0x1C
	public float y; // 0x20
	public ulong steamId; // 0x28
	public float rotation; // 0x30
	public float radius; // 0x34
	public Vector4 color1; // 0x38
	public Vector4 color2; // 0x48
	public float alpha; // 0x58
	public string name; // 0x60
	public bool outOfStock; // 0x68
	public List<AppMarker.SellOrder> sellOrders; // 0x70


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

public class AppMarker.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6535
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemId; // 0x14
	public int quantity; // 0x18
	public int currencyId; // 0x1C
	public int costPerItem; // 0x20
	public int amountInStock; // 0x24
	public bool itemIsBlueprint; // 0x28
	public bool currencyIsBlueprint; // 0x29
	public float itemCondition; // 0x2C
	public float itemConditionMax; // 0x30


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

public class AppMapMarkers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6536
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppMarker> markers; // 0x18


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

public class AppTeamChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6537
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerId; // 0x18
	public AppTeamInfo teamInfo; // 0x20


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

public class AppTeamMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6538
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppChatMessage message; // 0x18


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

public class AppEntityChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6539
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entityId; // 0x14
	public AppEntityPayload payload; // 0x18


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

public enum AppEntityType // TypeDefIndex: 6557
{	public int value__; // 0x0
	public const AppEntityType Switch = 1;
	public const AppEntityType Alarm = 2;
	public const AppEntityType StorageMonitor = 3;

}

public enum AppMarkerType // TypeDefIndex: 6558
{	public int value__; // 0x0
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

public static class Application // TypeDefIndex: 6613
{	public static bool isQuitting; // 0x0
	public static bool isLoading; // 0x1
	public static bool isReceiving; // 0x2
	public static bool isLoadingSave; // 0x3
	public static bool isLoadingPrefabs; // 0x4

	public static string installPath { get; }
	public static string dataPath { get; }


	public static void Quit() { }

	public static string get_installPath() { }

	public static string get_dataPath() { }

	private static void .cctor() { }

}

public enum AppCategory // TypeDefIndex: 7672
{	public int value__; // 0x0
	public const AppCategory Invalid = 0;
	public const AppCategory Utility = 1;
	public const AppCategory Game = 2;

}

public static class Approved // TypeDefIndex: 7722
{	private static Dictionary<ulong, ApprovedSkinInfo> _all; // 0x18DC

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

public class ApprovedSkinInfo // TypeDefIndex: 7738
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <InventoryId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Desc>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Name>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ulong <WorkshopdId>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Price <Price>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Tradable>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DropChance <DropChance>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Marketable>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Skinnable <Skinnable>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <AllowInCrates>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsLimitedTimeOffer>k__BackingField; // 0x49

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_InventoryId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_InventoryId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Desc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Desc(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal Price get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Marketable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_AllowInCrates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_AllowInCrates(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

private sealed class ApprovedSkinInfo.<>c__DisplayClass44_0 // TypeDefIndex: 7739
{	public string ItemName; // 0x10


	public void .ctor() { }

	internal bool <.ctor>b__0(Skinnable x) { }

}

public abstract class AppIOEntity : IOEntity // TypeDefIndex: 8306
{	private Option __menuOption_Menu_Pair; // 0x288

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	[BaseEntity.Menu.Description] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	[BaseEntity.Menu.Icon] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	public void Menu_Pair(BasePlayer player) { }

	public bool Menu_ShowIf(BasePlayer player) { }

	protected void .ctor() { }

}

public class ApplyTerrainAnchors : MonoBehaviour // TypeDefIndex: 10372
{
	protected void Awake() { }

	public void .ctor() { }

}

public class ApplyTerrainModifiers : MonoBehaviour // TypeDefIndex: 10573
{
	protected void Awake() { }

	public void .ctor() { }

}

public class ApplyTweakUIChanges : MonoBehaviour // TypeDefIndex: 11131
{	public Button ApplyButton; // 0x18
	public TweakUIBase[] Options; // 0x20


	private void OnEnable() { }

	public void Apply() { }

	public void SetDirty() { }

	public void SetClean() { }

	public void .ctor() { }

}

public class App : ConsoleSystem // TypeDefIndex: 11878
{	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string listenip; // 0x0
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int port; // 0x8
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static string publicip; // 0x10
	[ServerVar] // RVA: 0x86290 Offset: 0x85690 VA: 0x180086290
	public static bool update; // 0x18
	[ServerVar] // RVA: 0x863A0 Offset: 0x857A0 VA: 0x1800863A0
	public static bool notifications; // 0x19
	[ServerVar] // RVA: 0x864C0 Offset: 0x858C0 VA: 0x1800864C0
	public static int queuelimit; // 0x1C
	[ReplicatedVar] // RVA: 0x878D0 Offset: 0x86CD0 VA: 0x1800878D0
	public static string serverid; // 0x20
	[ServerVar] // RVA: 0x87A00 Offset: 0x86E00 VA: 0x180087A00
	public static float alarmcooldown; // 0x28
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int maxconnections; // 0x2C
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
	public static int maxconnectionsperip; // 0x30


	public void .ctor() { }

	private static void .cctor() { }

}

