internal static class AppContextSwitches // TypeDefIndex: 142
{	// Fields
	public static readonly bool ThrowExceptionIfDisposedCancellationTokenSource; // 0x0
	public static readonly bool SetActorAsReferenceWhenCopyingClaimsIdentity; // 0x1
	public static readonly bool NoAsyncCurrentCulture; // 0x2
	public static readonly bool PreserveEventListnerObjectIdentity; // 0x3

}

public class AppDomainUnloadedException : SystemException // TypeDefIndex: 164
{	// Methods

	// RVA: 0x157EDD0 Offset: 0x157E1D0 VA: 0x18157EDD0
	public void .ctor() { }

	// RVA: 0xFD8000 Offset: 0xFD7400 VA: 0x180FD8000
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public class ApplicationException : Exception // TypeDefIndex: 165
{	// Methods

	// RVA: 0x15808E0 Offset: 0x157FCE0 VA: 0x1815808E0
	public void .ctor() { }

	// RVA: 0x1580960 Offset: 0x157FD60 VA: 0x181580960
	public void .ctor(string message) { }

	// RVA: 0x1580850 Offset: 0x157FC50 VA: 0x181580850
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x15809E0 Offset: 0x157FDE0 VA: 0x1815809E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

public sealed class AppDomain : MarshalByRefObject // TypeDefIndex: 337
{	// Fields
	private IntPtr _mono_app_domain; // 0x18
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

	// Properties
	internal AppDomainSetup SetupInformationNoCopy { get; }
	public string BaseDirectory { get; }
	public string FriendlyName { get; }
	public static AppDomain CurrentDomain { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x1580630 Offset: 0x157FA30 VA: 0x181580630
	private AppDomainSetup getSetup() { }

	// RVA: 0x1580630 Offset: 0x157FA30 VA: 0x181580630
	internal AppDomainSetup get_SetupInformationNoCopy() { }

	// RVA: 0x1580640 Offset: 0x157FA40 VA: 0x181580640 Slot: 6
	public string get_BaseDirectory() { }

	// RVA: 0x1580420 Offset: 0x157F820 VA: 0x181580420
	private string getFriendlyName() { }

	// RVA: 0x1580420 Offset: 0x157F820 VA: 0x181580420 Slot: 7
	public string get_FriendlyName() { }

	// RVA: 0x1580610 Offset: 0x157FA10 VA: 0x181580610
	private static AppDomain getCurDomain() { }

	// RVA: 0x1580610 Offset: 0x157FA10 VA: 0x181580610
	public static AppDomain get_CurrentDomain() { }

	// RVA: 0x157F5F0 Offset: 0x157E9F0 VA: 0x18157F5F0
	private Assembly[] GetAssemblies(bool refOnly) { }

	// RVA: 0x157F600 Offset: 0x157EA00 VA: 0x18157F600 Slot: 8
	public Assembly[] GetAssemblies() { }

	// RVA: 0x157F620 Offset: 0x157EA20 VA: 0x18157F620 Slot: 9
	public object GetData(string name) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 5
	public override object InitializeLifetimeService() { }

	// RVA: 0x157FA10 Offset: 0x157EE10 VA: 0x18157FA10
	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly) { }

	// RVA: 0x157FB20 Offset: 0x157EF20 VA: 0x18157FB20 Slot: 10
	public Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x157FA20 Offset: 0x157EE20 VA: 0x18157FA20
	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError) { }

	[ObsoleteAttribute] // RVA: 0x8C670 Offset: 0x8BA70 VA: 0x18008C670
	// RVA: 0x157FB30 Offset: 0x157EF30 VA: 0x18157FB30 Slot: 11
	public Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	// RVA: 0x15800D0 Offset: 0x157F4D0 VA: 0x1815800D0 Slot: 12
	public Assembly Load(string assemblyString) { }

	// RVA: 0x15801D0 Offset: 0x157F5D0 VA: 0x1815801D0
	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly) { }

	// RVA: 0x157F7F0 Offset: 0x157EBF0 VA: 0x18157F7F0
	private static AppDomain InternalSetDomainByID(int domain_id) { }

	// RVA: 0x157F800 Offset: 0x157EC00 VA: 0x18157F800
	private static AppDomain InternalSetDomain(AppDomain context) { }

	// RVA: 0x157F7D0 Offset: 0x157EBD0 VA: 0x18157F7D0
	internal static void InternalPushDomainRefByID(int domain_id) { }

	// RVA: 0x157F7C0 Offset: 0x157EBC0 VA: 0x18157F7C0
	internal static void InternalPopDomainRef() { }

	// RVA: 0x157F7E0 Offset: 0x157EBE0 VA: 0x18157F7E0
	internal static Context InternalSetContext(Context context) { }

	// RVA: 0x157F7A0 Offset: 0x157EBA0 VA: 0x18157F7A0
	internal static Context InternalGetContext() { }

	// RVA: 0x157F7A0 Offset: 0x157EBA0 VA: 0x18157F7A0
	internal static Context InternalGetDefaultContext() { }

	// RVA: 0x157F7B0 Offset: 0x157EBB0 VA: 0x18157F7B0
	internal static string InternalGetProcessGuid(string newguid) { }

	// RVA: 0x157F810 Offset: 0x157EC10 VA: 0x18157F810
	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	// RVA: 0x157F6F0 Offset: 0x157EAF0 VA: 0x18157F6F0
	internal static string GetProcessGuid() { }

	// RVA: 0xD64760 Offset: 0xD63B60 VA: 0x180D64760
	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	// RVA: 0x157F9F0 Offset: 0x157EDF0 VA: 0x18157F9F0
	public bool IsFinalizingForUnload() { }

	// RVA: 0x1580620 Offset: 0x157FA20 VA: 0x181580620
	private int getDomainID() { }

	[ObsoleteAttribute] // RVA: 0x8C860 Offset: 0x8BC60 VA: 0x18008C860
	// RVA: 0x157F610 Offset: 0x157EA10 VA: 0x18157F610
	public static int GetCurrentThreadId() { }

	// RVA: 0x1580420 Offset: 0x157F820 VA: 0x181580420 Slot: 3
	public override string ToString() { }

	// RVA: 0x157EE30 Offset: 0x157E230 VA: 0x18157EE30
	private void DoAssemblyLoad(Assembly assembly) { }

	// RVA: 0x157EF00 Offset: 0x157E300 VA: 0x18157EF00
	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	// RVA: 0x157F340 Offset: 0x157E740 VA: 0x18157F340
	internal Assembly DoTypeResolve(object name_or_tb) { }

	// RVA: 0x157F210 Offset: 0x157E610 VA: 0x18157F210
	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	// RVA: 0x157F1F0 Offset: 0x157E5F0 VA: 0x18157F1F0
	private void DoDomainUnload() { }

	// RVA: 0x157F630 Offset: 0x157EA30 VA: 0x18157F630
	internal byte[] GetMarshalledDomainObjRef() { }

	// RVA: 0x15802F0 Offset: 0x157F6F0 VA: 0x1815802F0
	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1580430 Offset: 0x157F830 VA: 0x181580430 Slot: 13
	public void add_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1580670 Offset: 0x157FA70 VA: 0x181580670 Slot: 14
	public void remove_DomainUnload(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x15804D0 Offset: 0x157F8D0 VA: 0x1815804D0 Slot: 15
	public void add_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1580710 Offset: 0x157FB10 VA: 0x181580710 Slot: 16
	public void remove_ProcessExit(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1580570 Offset: 0x157F970 VA: 0x181580570 Slot: 17
	public void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x15807B0 Offset: 0x157FBB0 VA: 0x1815807B0 Slot: 18
	public void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

}

public sealed class AppDomainSetup // TypeDefIndex: 346
{	// Fields
	private string application_base; // 0x10
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

	// Properties
	public string ApplicationBase { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x157EA70 Offset: 0x157DE70 VA: 0x18157EA70
	private static string GetAppBase(string appBase) { }

	// RVA: 0x157EDC0 Offset: 0x157E1C0 VA: 0x18157EDC0 Slot: 4
	public string get_ApplicationBase() { }

}

internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 1203
{	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x53C500 Offset: 0x53B900 VA: 0x18053C500
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0xFD64C0 Offset: 0xFD58C0 VA: 0x180FD64C0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }

}

public class Application // TypeDefIndex: 3354
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
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

	// Properties
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

	// Methods

	[FreeFunctionAttribute] // RVA: 0x70D00 Offset: 0x70100 VA: 0x180070D00
	// RVA: 0x1817FC0 Offset: 0x18173C0 VA: 0x181817FC0
	public static void Quit(int exitCode) { }

	// RVA: 0x1818000 Offset: 0x1817400 VA: 0x181818000
	public static void Quit() { }

	[FreeFunctionAttribute] // RVA: 0x70EE0 Offset: 0x702E0 VA: 0x180070EE0
	// RVA: 0x1817C70 Offset: 0x1817070 VA: 0x181817C70
	public static bool CanStreamedLevelBeLoaded(string levelName) { }

	[FreeFunctionAttribute] // RVA: 0x71040 Offset: 0x70440 VA: 0x180071040
	// RVA: 0x1818280 Offset: 0x1817680 VA: 0x181818280
	public static bool get_isPlaying() { }

	[FreeFunctionAttribute] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	// RVA: 0x18181C0 Offset: 0x18175C0 VA: 0x1818181C0
	public static string get_dataPath() { }

	[FreeFunctionAttribute] // RVA: 0x711B0 Offset: 0x705B0 VA: 0x1800711B0
	// RVA: 0x1818330 Offset: 0x1817730 VA: 0x181818330
	public static string get_streamingAssetsPath() { }

	[FreeFunctionAttribute] // RVA: 0x71340 Offset: 0x70740 VA: 0x180071340
	// RVA: 0x18182D0 Offset: 0x18176D0 VA: 0x1818182D0
	public static string get_persistentDataPath() { }

	[FreeFunctionAttribute] // RVA: 0x714A0 Offset: 0x708A0 VA: 0x1800714A0
	// RVA: 0x18183C0 Offset: 0x18177C0 VA: 0x1818183C0
	public static string get_unityVersion() { }

	[FreeFunctionAttribute] // RVA: 0x71620 Offset: 0x70A20 VA: 0x180071620
	// RVA: 0x18183F0 Offset: 0x18177F0 VA: 0x1818183F0
	public static string get_version() { }

	[FreeFunctionAttribute] // RVA: 0x717C0 Offset: 0x70BC0 VA: 0x1800717C0
	// RVA: 0x1818160 Offset: 0x1817560 VA: 0x181818160
	public static string get_companyName() { }

	[FreeFunctionAttribute] // RVA: 0x71820 Offset: 0x70C20 VA: 0x180071820
	// RVA: 0x1817F80 Offset: 0x1817380 VA: 0x181817F80
	public static void OpenURL(string url) { }

	[FreeFunctionAttribute] // RVA: 0x71980 Offset: 0x70D80 VA: 0x180071980
	// RVA: 0x1818390 Offset: 0x1817790 VA: 0x181818390
	public static int get_targetFrameRate() { }

	[FreeFunctionAttribute] // RVA: 0x71A90 Offset: 0x70E90 VA: 0x180071A90
	// RVA: 0x18184F0 Offset: 0x18178F0 VA: 0x1818184F0
	public static void set_targetFrameRate(int value) { }

	[FreeFunctionAttribute] // RVA: 0x71C10 Offset: 0x71010 VA: 0x180071C10
	// RVA: 0x1818030 Offset: 0x1817430 VA: 0x181818030
	private static void SetLogCallbackDefined(bool defined) { }

	[FreeFunctionAttribute] // RVA: 0x71D70 Offset: 0x71170 VA: 0x180071D70
	// RVA: 0x1817CB0 Offset: 0x18170B0 VA: 0x181817CB0
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	[FreeFunctionAttribute] // RVA: 0x71F30 Offset: 0x71330 VA: 0x180071F30
	// RVA: 0x1818070 Offset: 0x1817470 VA: 0x181818070
	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

	[FreeFunctionAttribute] // RVA: 0x72120 Offset: 0x71520 VA: 0x180072120
	// RVA: 0x1818190 Offset: 0x1817590 VA: 0x181818190
	public static string get_consoleLogPath() { }

	[FreeFunctionAttribute] // RVA: 0x72200 Offset: 0x71600 VA: 0x180072200
	// RVA: 0x18184B0 Offset: 0x18178B0 VA: 0x1818184B0
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunctionAttribute] // RVA: 0x72380 Offset: 0x71780 VA: 0x180072380
	// RVA: 0x1818300 Offset: 0x1817700 VA: 0x181818300
	public static RuntimePlatform get_platform() { }

	// RVA: 0x1818220 Offset: 0x1817620 VA: 0x181818220
	public static bool get_isMobilePlatform() { }

	[FreeFunctionAttribute] // RVA: 0x73810 Offset: 0x72C10 VA: 0x180073810
	// RVA: 0x1818360 Offset: 0x1817760 VA: 0x181818360
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunctionAttribute] // RVA: 0x739C0 Offset: 0x72DC0 VA: 0x1800739C0
	// RVA: 0x18181F0 Offset: 0x18175F0 VA: 0x1818181F0
	public static NetworkReachability get_internetReachability() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1817A90 Offset: 0x1816E90 VA: 0x181817A90
	internal static void CallLowMemory() { }

	// RVA: 0x18180B0 Offset: 0x18174B0 VA: 0x1818180B0
	public static void add_logMessageReceived(Application.LogCallback value) { }

	// RVA: 0x1818420 Offset: 0x1817820 VA: 0x181818420
	public static void remove_logMessageReceived(Application.LogCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18179D0 Offset: 0x1816DD0 VA: 0x1818179D0
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1817D40 Offset: 0x1817140 VA: 0x181817D40
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1817CF0 Offset: 0x18170F0 VA: 0x181817CF0
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1817F30 Offset: 0x1817330 VA: 0x181817F30
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1817ED0 Offset: 0x18172D0 VA: 0x181817ED0
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1817E70 Offset: 0x1817270 VA: 0x181817E70
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x18182B0 Offset: 0x18176B0 VA: 0x1818182B0
	public static string get_loadedLevelName() { }

	// RVA: 0x48A4F0 Offset: 0x4898F0 VA: 0x18048A4F0
	public static bool get_isEditor() { }

}

public sealed class Application.LowMemoryCallback : MulticastDelegate // TypeDefIndex: 3355
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497060 Offset: 0x496460 VA: 0x180497060 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 3356
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x130AEF0 Offset: 0x130A2F0 VA: 0x18130AEF0 Slot: 12
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	// RVA: 0x182CA20 Offset: 0x182BE20 VA: 0x18182CA20 Slot: 13
	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public struct AppId // TypeDefIndex: 5235
{	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x1D7B50 Offset: 0x1D6F50 VA: 0x1801D7B50 Slot: 3
	public override string ToString() { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static AppId op_Implicit(uint value) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static AppId op_Implicit(int value) { }

	// RVA: 0x6BFDB0 Offset: 0x6BF1B0 VA: 0x1806BFDB0
	public static uint op_Implicit(AppId value) { }

}

internal struct AppResumingFromSuspend_t : ICallbackData // TypeDefIndex: 5333
{	// Fields
	public static int _datasize; // 0x12BF6

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4280 Offset: 0x1E3680 VA: 0x1801E4280 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4270 Offset: 0x1E3670 VA: 0x1801E4270 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1365810 Offset: 0x1364C10 VA: 0x181365810
	private static void .cctor() { }

}

internal struct AppProofOfPurchaseKeyResponse_t : ICallbackData // TypeDefIndex: 5401
{	// Fields
	internal Result Result; // 0x0
	internal uint AppID; // 0x4
	internal uint CchKeyLength; // 0x8
	internal byte[] Key; // 0x10
	public static int _datasize; // 0x0

	// Properties
	public int DataSize { get; }
	public CallbackType CallbackType { get; }

	// Methods

	// RVA: 0x1E4080 Offset: 0x1E3480 VA: 0x1801E4080 Slot: 5
	public int get_DataSize() { }

	// RVA: 0x1E4070 Offset: 0x1E3470 VA: 0x1801E4070 Slot: 4
	public CallbackType get_CallbackType() { }

	// RVA: 0x1365770 Offset: 0x1364B70 VA: 0x181365770
	private static void .cctor() { }

}

public static class Application // TypeDefIndex: 6176
{	// Fields
	private static MonoBehaviour _controller; // 0x0
	public static Manifest Manifest; // 0x8
	public static Dictionary<IPEndPoint, int> ServerMetadata; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static BaseIntegration <Integration>k__BackingField; // 0x18

	// Properties
	public static MonoBehaviour Controller { get; }
	public static BaseIntegration Integration { get; set; }

	// Methods

	// RVA: 0x14E0AE0 Offset: 0x14DFEE0 VA: 0x1814E0AE0
	public static MonoBehaviour get_Controller() { }

	// RVA: 0x14E07D0 Offset: 0x14DFBD0 VA: 0x1814E07D0
	public static void Initialize(BaseIntegration integration) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14E0BE0 Offset: 0x14DFFE0 VA: 0x1814E0BE0
	public static BaseIntegration get_Integration() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14E0C20 Offset: 0x14E0020 VA: 0x1814E0C20
	public static void set_Integration(BaseIntegration value) { }

}

internal class ApplicationControllerMonobehaviour : MonoBehaviour // TypeDefIndex: 6217
{	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void OnApplicationQuit() { }

	// RVA: 0x14E0630 Offset: 0x14DFA30 VA: 0x1814E0630
	public void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public struct AppInfo // TypeDefIndex: 6240
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <Image>k__BackingField; // 0x0

	// Properties
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

	// Methods

	// RVA: 0x1F0FA0 Offset: 0x1F03A0 VA: 0x1801F0FA0
	public int get_Version() { }

	// RVA: 0x1F0B70 Offset: 0x1EFF70 VA: 0x1801F0B70
	public BuildInfo get_Build() { }

	// RVA: 0x1F0E00 Offset: 0x1F0200 VA: 0x1801F0E00
	public string get_Name() { }

	// RVA: 0x1F0E10 Offset: 0x1F0210 VA: 0x1801F0E10
	public string get_Os() { }

	// RVA: 0x1F0B90 Offset: 0x1EFF90 VA: 0x1801F0B90
	public string get_Cpu() { }

	// RVA: 0x1F0B80 Offset: 0x1EFF80 VA: 0x1801F0B80
	public int get_CpuCount() { }

	// RVA: 0x1F0BA0 Offset: 0x1EFFA0 VA: 0x1801F0BA0
	public int get_Mem() { }

	// RVA: 0x1F0BB0 Offset: 0x1EFFB0 VA: 0x1801F0BB0
	public string get_Gpu() { }

	// RVA: 0x1F0BA0 Offset: 0x1EFFA0 VA: 0x1801F0BA0
	public int get_GpuMem() { }

	// RVA: 0x1F0B30 Offset: 0x1EFF30 VA: 0x1801F0B30
	public string get_Arch() { }

	// RVA: 0x1F0EE0 Offset: 0x1F02E0 VA: 0x1801F0EE0
	public string get_UserId() { }

	// RVA: 0x1F0F40 Offset: 0x1F0340 VA: 0x1801F0F40
	public string get_UserName() { }

	// RVA: 0x1F0E20 Offset: 0x1F0220 VA: 0x1801F0E20
	public string get_ServerAddress() { }

	// RVA: 0x1F0E80 Offset: 0x1F0280 VA: 0x1801F0E80
	public string get_ServerName() { }

	// RVA: 0x1F0BC0 Offset: 0x1EFFC0 VA: 0x1801F0BC0
	public string get_LevelName() { }

	// RVA: 0x1F0C20 Offset: 0x1F0020 VA: 0x1801F0C20
	public string get_LevelPos() { }

	// RVA: 0x1F0CE0 Offset: 0x1F00E0 VA: 0x1801F0CE0
	public string get_LevelRot() { }

	// RVA: 0x1F0DA0 Offset: 0x1F01A0 VA: 0x1801F0DA0
	public int get_MinutesPlayed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public string get_Image() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	public void set_Image(string value) { }

}

public class Approval : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6476
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1E1FE10 Offset: 0x1E1F210 VA: 0x181E1FE10
	public static void ResetToPool(Approval instance) { }

	// RVA: 0x1E1FC50 Offset: 0x1E1F050 VA: 0x181E1FC50
	public void ResetToPool() { }

	// RVA: 0x1E1F9E0 Offset: 0x1E1EDE0 VA: 0x181E1F9E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1E540 Offset: 0x1E1D940 VA: 0x181E1E540
	public void CopyTo(Approval instance) { }

	// RVA: 0x1E1E5F0 Offset: 0x1E1D9F0 VA: 0x181E1E5F0
	public Approval Copy() { }

	// RVA: 0x1E1F3B0 Offset: 0x1E1E7B0 VA: 0x181E1F3B0
	public static Approval Deserialize(Stream stream) { }

	// RVA: 0x1E1E6E0 Offset: 0x1E1DAE0 VA: 0x181E1E6E0
	public static Approval DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1ECD0 Offset: 0x1E1E0D0 VA: 0x181E1ECD0
	public static Approval DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1F8C0 Offset: 0x1E1ECC0 VA: 0x181E1F8C0
	public static Approval Deserialize(byte[] buffer) { }

	// RVA: 0x1E1FC10 Offset: 0x1E1F010 VA: 0x181E1FC10
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E20A80 Offset: 0x1E1FE80 VA: 0x181E20A80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E20AA0 Offset: 0x1E1FEA0 VA: 0x181E20AA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Approval previous) { }

	// RVA: 0x1E1FC30 Offset: 0x1E1F030 VA: 0x181E1FC30 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1F2B0 Offset: 0x1E1E6B0 VA: 0x181E1F2B0
	public static Approval Deserialize(byte[] buffer, Approval instance, bool isDelta = False) { }

	// RVA: 0x1E1F430 Offset: 0x1E1E830 VA: 0x181E1F430
	public static Approval Deserialize(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E1E760 Offset: 0x1E1DB60 VA: 0x181E1E760
	public static Approval DeserializeLengthDelimited(Stream stream, Approval instance, bool isDelta) { }

	// RVA: 0x1E1ED60 Offset: 0x1E1E160 VA: 0x181E1ED60
	public static Approval DeserializeLength(Stream stream, int length, Approval instance, bool isDelta) { }

	// RVA: 0x1E1FFD0 Offset: 0x1E1F3D0 VA: 0x181E1FFD0
	public static void SerializeDelta(Stream stream, Approval instance, Approval previous) { }

	// RVA: 0x1E206A0 Offset: 0x1E1FAA0 VA: 0x181E206A0
	public static void Serialize(Stream stream, Approval instance) { }

	// RVA: 0x1E20A70 Offset: 0x1E1FE70 VA: 0x181E20A70
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E20A80 Offset: 0x1E1FE80 VA: 0x181E20A80
	public void ToProto(Stream stream) { }

	// RVA: 0x1E20590 Offset: 0x1E1F990 VA: 0x181E20590
	public static byte[] SerializeToBytes(Approval instance) { }

	// RVA: 0x1E204E0 Offset: 0x1E1F8E0 VA: 0x181E204E0
	public static void SerializeLengthDelimited(Stream stream, Approval instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppRequest : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6511
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1E0DCC0 Offset: 0x1E0D0C0 VA: 0x181E0DCC0
	public static void ResetToPool(AppRequest instance) { }

	// RVA: 0x1E0D970 Offset: 0x1E0CD70 VA: 0x181E0D970
	public void ResetToPool() { }

	// RVA: 0x1E0D8B0 Offset: 0x1E0CCB0 VA: 0x181E0D8B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0BDF0 Offset: 0x1E0B1F0 VA: 0x181E0BDF0
	public void CopyTo(AppRequest instance) { }

	// RVA: 0x1E0C1C0 Offset: 0x1E0B5C0 VA: 0x181E0C1C0
	public AppRequest Copy() { }

	// RVA: 0x1E0D610 Offset: 0x1E0CA10 VA: 0x181E0D610
	public static AppRequest Deserialize(Stream stream) { }

	// RVA: 0x1E0C8D0 Offset: 0x1E0BCD0 VA: 0x181E0C8D0
	public static AppRequest DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E0CFC0 Offset: 0x1E0C3C0 VA: 0x181E0CFC0
	public static AppRequest DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E0D790 Offset: 0x1E0CB90 VA: 0x181E0D790
	public static AppRequest Deserialize(byte[] buffer) { }

	// RVA: 0x1E0D930 Offset: 0x1E0CD30 VA: 0x181E0D930
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E0FC70 Offset: 0x1E0F070 VA: 0x181E0FC70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E0FC90 Offset: 0x1E0F090 VA: 0x181E0FC90 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppRequest previous) { }

	// RVA: 0x1E0D950 Offset: 0x1E0CD50 VA: 0x181E0D950 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E0D690 Offset: 0x1E0CA90 VA: 0x181E0D690
	public static AppRequest Deserialize(byte[] buffer, AppRequest instance, bool isDelta = False) { }

	// RVA: 0x1E0D050 Offset: 0x1E0C450 VA: 0x181E0D050
	public static AppRequest Deserialize(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E0C240 Offset: 0x1E0B640 VA: 0x181E0C240
	public static AppRequest DeserializeLengthDelimited(Stream stream, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E0C950 Offset: 0x1E0BD50 VA: 0x181E0C950
	public static AppRequest DeserializeLength(Stream stream, int length, AppRequest instance, bool isDelta) { }

	// RVA: 0x1E0E010 Offset: 0x1E0D410 VA: 0x181E0E010
	public static void SerializeDelta(Stream stream, AppRequest instance, AppRequest previous) { }

	// RVA: 0x1E0EFC0 Offset: 0x1E0E3C0 VA: 0x181E0EFC0
	public static void Serialize(Stream stream, AppRequest instance) { }

	// RVA: 0x1E0FC60 Offset: 0x1E0F060 VA: 0x181E0FC60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E0FC70 Offset: 0x1E0F070 VA: 0x181E0FC70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E0EEB0 Offset: 0x1E0E2B0 VA: 0x181E0EEB0
	public static byte[] SerializeToBytes(AppRequest instance) { }

	// RVA: 0x1E0EE00 Offset: 0x1E0E200 VA: 0x181E0EE00
	public static void SerializeLengthDelimited(Stream stream, AppRequest instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6512
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppResponse response; // 0x18
	public AppBroadcast broadcast; // 0x20

	// Methods

	// RVA: 0x208D230 Offset: 0x208C630 VA: 0x18208D230
	public static void ResetToPool(AppMessage instance) { }

	// RVA: 0x208D310 Offset: 0x208C710 VA: 0x18208D310
	public void ResetToPool() { }

	// RVA: 0x208D090 Offset: 0x208C490 VA: 0x18208D090 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x208C4A0 Offset: 0x208B8A0 VA: 0x18208C4A0
	public void CopyTo(AppMessage instance) { }

	// RVA: 0x208C560 Offset: 0x208B960 VA: 0x18208C560
	public AppMessage Copy() { }

	// RVA: 0x208D010 Offset: 0x208C410 VA: 0x18208D010
	public static AppMessage Deserialize(Stream stream) { }

	// RVA: 0x208C670 Offset: 0x208BA70 VA: 0x18208C670
	public static AppMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208CBC0 Offset: 0x208BFC0 VA: 0x18208CBC0
	public static AppMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208CC50 Offset: 0x208C050 VA: 0x18208CC50
	public static AppMessage Deserialize(byte[] buffer) { }

	// RVA: 0x208D1F0 Offset: 0x208C5F0 VA: 0x18208D1F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208DAD0 Offset: 0x208CED0 VA: 0x18208DAD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208DAF0 Offset: 0x208CEF0 VA: 0x18208DAF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMessage previous) { }

	// RVA: 0x208D210 Offset: 0x208C610 VA: 0x18208D210 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208CF10 Offset: 0x208C310 VA: 0x18208CF10
	public static AppMessage Deserialize(byte[] buffer, AppMessage instance, bool isDelta = False) { }

	// RVA: 0x208CD70 Offset: 0x208C170 VA: 0x18208CD70
	public static AppMessage Deserialize(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x208C6F0 Offset: 0x208BAF0 VA: 0x18208C6F0
	public static AppMessage DeserializeLengthDelimited(Stream stream, AppMessage instance, bool isDelta) { }

	// RVA: 0x208C970 Offset: 0x208BD70 VA: 0x18208C970
	public static AppMessage DeserializeLength(Stream stream, int length, AppMessage instance, bool isDelta) { }

	// RVA: 0x208D3F0 Offset: 0x208C7F0 VA: 0x18208D3F0
	public static void SerializeDelta(Stream stream, AppMessage instance, AppMessage previous) { }

	// RVA: 0x208D850 Offset: 0x208CC50 VA: 0x18208D850
	public static void Serialize(Stream stream, AppMessage instance) { }

	// RVA: 0x208DAC0 Offset: 0x208CEC0 VA: 0x18208DAC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x208DAD0 Offset: 0x208CED0 VA: 0x18208DAD0
	public void ToProto(Stream stream) { }

	// RVA: 0x208D740 Offset: 0x208CB40 VA: 0x18208D740
	public static byte[] SerializeToBytes(AppMessage instance) { }

	// RVA: 0x208D690 Offset: 0x208CA90 VA: 0x18208D690
	public static void SerializeLengthDelimited(Stream stream, AppMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppResponse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6513
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1E11610 Offset: 0x1E10A10 VA: 0x181E11610
	public static void ResetToPool(AppResponse instance) { }

	// RVA: 0x1E11350 Offset: 0x1E10750 VA: 0x181E11350
	public void ResetToPool() { }

	// RVA: 0x1E11290 Offset: 0x1E10690 VA: 0x181E11290 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E0FCB0 Offset: 0x1E0F0B0 VA: 0x181E0FCB0
	public void CopyTo(AppResponse instance) { }

	// RVA: 0x1E10040 Offset: 0x1E0F440 VA: 0x181E10040
	public AppResponse Copy() { }

	// RVA: 0x1E11110 Offset: 0x1E10510 VA: 0x181E11110
	public static AppResponse Deserialize(Stream stream) { }

	// RVA: 0x1E105D0 Offset: 0x1E0F9D0 VA: 0x181E105D0
	public static AppResponse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E10B30 Offset: 0x1E0FF30 VA: 0x181E10B30
	public static AppResponse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E10BC0 Offset: 0x1E0FFC0 VA: 0x181E10BC0
	public static AppResponse Deserialize(byte[] buffer) { }

	// RVA: 0x1E11310 Offset: 0x1E10710 VA: 0x181E11310
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E12EA0 Offset: 0x1E122A0 VA: 0x181E12EA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E12EC0 Offset: 0x1E122C0 VA: 0x181E12EC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppResponse previous) { }

	// RVA: 0x1E11330 Offset: 0x1E10730 VA: 0x181E11330 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E11190 Offset: 0x1E10590 VA: 0x181E11190
	public static AppResponse Deserialize(byte[] buffer, AppResponse instance, bool isDelta = False) { }

	// RVA: 0x1E10CE0 Offset: 0x1E100E0 VA: 0x181E10CE0
	public static AppResponse Deserialize(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E100C0 Offset: 0x1E0F4C0 VA: 0x181E100C0
	public static AppResponse DeserializeLengthDelimited(Stream stream, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E10650 Offset: 0x1E0FA50 VA: 0x181E10650
	public static AppResponse DeserializeLength(Stream stream, int length, AppResponse instance, bool isDelta) { }

	// RVA: 0x1E118D0 Offset: 0x1E10CD0 VA: 0x181E118D0
	public static void SerializeDelta(Stream stream, AppResponse instance, AppResponse previous) { }

	// RVA: 0x1E124E0 Offset: 0x1E118E0 VA: 0x181E124E0
	public static void Serialize(Stream stream, AppResponse instance) { }

	// RVA: 0x1E12E90 Offset: 0x1E12290 VA: 0x181E12E90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E12EA0 Offset: 0x1E122A0 VA: 0x181E12EA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E123D0 Offset: 0x1E117D0 VA: 0x181E123D0
	public static byte[] SerializeToBytes(AppResponse instance) { }

	// RVA: 0x1E12320 Offset: 0x1E11720 VA: 0x181E12320
	public static void SerializeLengthDelimited(Stream stream, AppResponse instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppBroadcast : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6514
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppTeamChanged teamChanged; // 0x18
	public AppTeamMessage teamMessage; // 0x20
	public AppEntityChanged entityChanged; // 0x28

	// Methods

	// RVA: 0x20108F0 Offset: 0x200FCF0 VA: 0x1820108F0
	public static void ResetToPool(AppBroadcast instance) { }

	// RVA: 0x20107D0 Offset: 0x200FBD0 VA: 0x1820107D0
	public void ResetToPool() { }

	// RVA: 0x2010430 Offset: 0x200F830 VA: 0x182010430 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x200F220 Offset: 0x200E620 VA: 0x18200F220
	public void CopyTo(AppBroadcast instance) { }

	// RVA: 0x200F320 Offset: 0x200E720 VA: 0x18200F320
	public AppBroadcast Copy() { }

	// RVA: 0x200FAC0 Offset: 0x200EEC0 VA: 0x18200FAC0
	public static AppBroadcast Deserialize(Stream stream) { }

	// RVA: 0x200F720 Offset: 0x200EB20 VA: 0x18200F720
	public static AppBroadcast DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x200F7A0 Offset: 0x200EBA0 VA: 0x18200F7A0
	public static AppBroadcast DeserializeLength(Stream stream, int length) { }

	// RVA: 0x200FEC0 Offset: 0x200F2C0 VA: 0x18200FEC0
	public static AppBroadcast Deserialize(byte[] buffer) { }

	// RVA: 0x20105D0 Offset: 0x200F9D0 VA: 0x1820105D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20112D0 Offset: 0x20106D0 VA: 0x1820112D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20112F0 Offset: 0x20106F0 VA: 0x1820112F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppBroadcast previous) { }

	// RVA: 0x20107B0 Offset: 0x200FBB0 VA: 0x1820107B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2010190 Offset: 0x200F590 VA: 0x182010190
	public static AppBroadcast Deserialize(byte[] buffer, AppBroadcast instance, bool isDelta = False) { }

	// RVA: 0x200FCE0 Offset: 0x200F0E0 VA: 0x18200FCE0
	public static AppBroadcast Deserialize(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x200F460 Offset: 0x200E860 VA: 0x18200F460
	public static AppBroadcast DeserializeLengthDelimited(Stream stream, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x200F830 Offset: 0x200EC30 VA: 0x18200F830
	public static AppBroadcast DeserializeLength(Stream stream, int length, AppBroadcast instance, bool isDelta) { }

	// RVA: 0x2010A10 Offset: 0x200FE10 VA: 0x182010A10
	public static void SerializeDelta(Stream stream, AppBroadcast instance, AppBroadcast previous) { }

	// RVA: 0x2010F60 Offset: 0x2010360 VA: 0x182010F60
	public static void Serialize(Stream stream, AppBroadcast instance) { }

	// RVA: 0x20112C0 Offset: 0x20106C0 VA: 0x1820112C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20112D0 Offset: 0x20106D0 VA: 0x1820112D0
	public void ToProto(Stream stream) { }

	// RVA: 0x2010E50 Offset: 0x2010250 VA: 0x182010E50
	public static byte[] SerializeToBytes(AppBroadcast instance) { }

	// RVA: 0x2010DA0 Offset: 0x20101A0 VA: 0x182010DA0
	public static void SerializeLengthDelimited(Stream stream, AppBroadcast instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppEmpty : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6515
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x207B220 Offset: 0x207A620 VA: 0x18207B220
	public static void ResetToPool(AppEmpty instance) { }

	// RVA: 0x207B290 Offset: 0x207A690 VA: 0x18207B290
	public void ResetToPool() { }

	// RVA: 0x207B100 Offset: 0x207A500 VA: 0x18207B100 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void CopyTo(AppEmpty instance) { }

	// RVA: 0x207A850 Offset: 0x2079C50 VA: 0x18207A850
	public AppEmpty Copy() { }

	// RVA: 0x207B080 Offset: 0x207A480 VA: 0x18207B080
	public static AppEmpty Deserialize(Stream stream) { }

	// RVA: 0x207AA80 Offset: 0x2079E80 VA: 0x18207AA80
	public static AppEmpty DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x207ACC0 Offset: 0x207A0C0 VA: 0x18207ACC0
	public static AppEmpty DeserializeLength(Stream stream, int length) { }

	// RVA: 0x207AD50 Offset: 0x207A150 VA: 0x18207AD50
	public static AppEmpty Deserialize(byte[] buffer) { }

	// RVA: 0x207B1E0 Offset: 0x207A5E0 VA: 0x18207B1E0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x207B5E0 Offset: 0x207A9E0 VA: 0x18207B5E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x207B650 Offset: 0x207AA50 VA: 0x18207B650 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEmpty previous) { }

	// RVA: 0x207B200 Offset: 0x207A600 VA: 0x18207B200 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x207AF80 Offset: 0x207A380 VA: 0x18207AF80
	public static AppEmpty Deserialize(byte[] buffer, AppEmpty instance, bool isDelta = False) { }

	// RVA: 0x207AE70 Offset: 0x207A270 VA: 0x18207AE70
	public static AppEmpty Deserialize(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207A8A0 Offset: 0x2079CA0 VA: 0x18207A8A0
	public static AppEmpty DeserializeLengthDelimited(Stream stream, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207AB00 Offset: 0x2079F00 VA: 0x18207AB00
	public static AppEmpty DeserializeLength(Stream stream, int length, AppEmpty instance, bool isDelta) { }

	// RVA: 0x207B300 Offset: 0x207A700 VA: 0x18207B300
	public static void SerializeDelta(Stream stream, AppEmpty instance, AppEmpty previous) { }

	// RVA: 0x207B570 Offset: 0x207A970 VA: 0x18207B570
	public static void Serialize(Stream stream, AppEmpty instance) { }

	// RVA: 0x207B5D0 Offset: 0x207A9D0 VA: 0x18207B5D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x207B5E0 Offset: 0x207A9E0 VA: 0x18207B5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x207B410 Offset: 0x207A810 VA: 0x18207B410
	public static byte[] SerializeToBytes(AppEmpty instance) { }

	// RVA: 0x207B360 Offset: 0x207A760 VA: 0x18207B360
	public static void SerializeLengthDelimited(Stream stream, AppEmpty instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppSendMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6516
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string message; // 0x18

	// Methods

	// RVA: 0x1E13940 Offset: 0x1E12D40 VA: 0x181E13940
	public static void ResetToPool(AppSendMessage instance) { }

	// RVA: 0x1E139D0 Offset: 0x1E12DD0 VA: 0x181E139D0
	public void ResetToPool() { }

	// RVA: 0x1E13880 Offset: 0x1E12C80 VA: 0x181E13880 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D62910 Offset: 0x1D61D10 VA: 0x181D62910
	public void CopyTo(AppSendMessage instance) { }

	// RVA: 0x1E12EE0 Offset: 0x1E122E0 VA: 0x181E12EE0
	public AppSendMessage Copy() { }

	// RVA: 0x1E13590 Offset: 0x1E12990 VA: 0x181E13590
	public static AppSendMessage Deserialize(Stream stream) { }

	// RVA: 0x1E13180 Offset: 0x1E12580 VA: 0x181E13180
	public static AppSendMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E13200 Offset: 0x1E12600 VA: 0x181E13200
	public static AppSendMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E13610 Offset: 0x1E12A10 VA: 0x181E13610
	public static AppSendMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E13900 Offset: 0x1E12D00 VA: 0x181E13900
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E13EC0 Offset: 0x1E132C0 VA: 0x181E13EC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E13EE0 Offset: 0x1E132E0 VA: 0x181E13EE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSendMessage previous) { }

	// RVA: 0x1E13920 Offset: 0x1E12D20 VA: 0x181E13920 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E13490 Offset: 0x1E12890 VA: 0x181E13490
	public static AppSendMessage Deserialize(byte[] buffer, AppSendMessage instance, bool isDelta = False) { }

	// RVA: 0x1E13730 Offset: 0x1E12B30 VA: 0x181E13730
	public static AppSendMessage Deserialize(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E12F60 Offset: 0x1E12360 VA: 0x181E12F60
	public static AppSendMessage DeserializeLengthDelimited(Stream stream, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E13290 Offset: 0x1E12690 VA: 0x181E13290
	public static AppSendMessage DeserializeLength(Stream stream, int length, AppSendMessage instance, bool isDelta) { }

	// RVA: 0x1E13A60 Offset: 0x1E12E60 VA: 0x181E13A60
	public static void SerializeDelta(Stream stream, AppSendMessage instance, AppSendMessage previous) { }

	// RVA: 0x1E13D80 Offset: 0x1E13180 VA: 0x181E13D80
	public static void Serialize(Stream stream, AppSendMessage instance) { }

	// RVA: 0x1E13EB0 Offset: 0x1E132B0 VA: 0x181E13EB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E13EC0 Offset: 0x1E132C0 VA: 0x181E13EC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E13C70 Offset: 0x1E13070 VA: 0x181E13C70
	public static byte[] SerializeToBytes(AppSendMessage instance) { }

	// RVA: 0x1E13BC0 Offset: 0x1E12FC0 VA: 0x181E13BC0
	public static void SerializeLengthDelimited(Stream stream, AppSendMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppSetEntityValue : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6517
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x1E14960 Offset: 0x1E13D60 VA: 0x181E14960
	public static void ResetToPool(AppSetEntityValue instance) { }

	// RVA: 0x1E149E0 Offset: 0x1E13DE0 VA: 0x181E149E0
	public void ResetToPool() { }

	// RVA: 0x1E148A0 Offset: 0x1E13CA0 VA: 0x181E148A0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E13F00 Offset: 0x1E13300 VA: 0x181E13F00
	public void CopyTo(AppSetEntityValue instance) { }

	// RVA: 0x1E13F20 Offset: 0x1E13320 VA: 0x181E13F20
	public AppSetEntityValue Copy() { }

	// RVA: 0x1E14720 Offset: 0x1E13B20 VA: 0x181E14720
	public static AppSetEntityValue Deserialize(Stream stream) { }

	// RVA: 0x1E13F90 Offset: 0x1E13390 VA: 0x181E13F90
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E14430 Offset: 0x1E13830 VA: 0x181E14430
	public static AppSetEntityValue DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E14600 Offset: 0x1E13A00 VA: 0x181E14600
	public static AppSetEntityValue Deserialize(byte[] buffer) { }

	// RVA: 0x1E14920 Offset: 0x1E13D20 VA: 0x181E14920
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E14E70 Offset: 0x1E14270 VA: 0x181E14E70 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E14F40 Offset: 0x1E14340 VA: 0x181E14F40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSetEntityValue previous) { }

	// RVA: 0x1E14940 Offset: 0x1E13D40 VA: 0x181E14940 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E147A0 Offset: 0x1E13BA0 VA: 0x181E147A0
	public static AppSetEntityValue Deserialize(byte[] buffer, AppSetEntityValue instance, bool isDelta = False) { }

	// RVA: 0x1E144C0 Offset: 0x1E138C0 VA: 0x181E144C0
	public static AppSetEntityValue Deserialize(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E14010 Offset: 0x1E13410 VA: 0x181E14010
	public static AppSetEntityValue DeserializeLengthDelimited(Stream stream, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E14230 Offset: 0x1E13630 VA: 0x181E14230
	public static AppSetEntityValue DeserializeLength(Stream stream, int length, AppSetEntityValue instance, bool isDelta) { }

	// RVA: 0x1E14A60 Offset: 0x1E13E60 VA: 0x181E14A60
	public static void SerializeDelta(Stream stream, AppSetEntityValue instance, AppSetEntityValue previous) { }

	// RVA: 0x1E14D90 Offset: 0x1E14190 VA: 0x181E14D90
	public static void Serialize(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x1E14E60 Offset: 0x1E14260 VA: 0x181E14E60
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E14E70 Offset: 0x1E14270 VA: 0x181E14E70
	public void ToProto(Stream stream) { }

	// RVA: 0x1E14BE0 Offset: 0x1E13FE0 VA: 0x181E14BE0
	public static byte[] SerializeToBytes(AppSetEntityValue instance) { }

	// RVA: 0x1E14B30 Offset: 0x1E13F30 VA: 0x181E14B30
	public static void SerializeLengthDelimited(Stream stream, AppSetEntityValue instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppPromoteToLeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6518
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18

	// Methods

	// RVA: 0x208E640 Offset: 0x208DA40 VA: 0x18208E640
	public static void ResetToPool(AppPromoteToLeader instance) { }

	// RVA: 0x208E5C0 Offset: 0x208D9C0 VA: 0x18208E5C0
	public void ResetToPool() { }

	// RVA: 0x208E490 Offset: 0x208D890 VA: 0x18208E490 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F17770 Offset: 0x1F16B70 VA: 0x181F17770
	public void CopyTo(AppPromoteToLeader instance) { }

	// RVA: 0x208DB10 Offset: 0x208CF10 VA: 0x18208DB10
	public AppPromoteToLeader Copy() { }

	// RVA: 0x208E310 Offset: 0x208D710 VA: 0x18208E310
	public static AppPromoteToLeader Deserialize(Stream stream) { }

	// RVA: 0x208DB80 Offset: 0x208CF80 VA: 0x18208DB80
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208DE20 Offset: 0x208D220 VA: 0x18208DE20
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208E1F0 Offset: 0x208D5F0 VA: 0x18208E1F0
	public static AppPromoteToLeader Deserialize(byte[] buffer) { }

	// RVA: 0x208E580 Offset: 0x208D980 VA: 0x18208E580
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208EB10 Offset: 0x208DF10 VA: 0x18208EB10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208EBE0 Offset: 0x208DFE0 VA: 0x18208EBE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppPromoteToLeader previous) { }

	// RVA: 0x208E5A0 Offset: 0x208D9A0 VA: 0x18208E5A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208E390 Offset: 0x208D790 VA: 0x18208E390
	public static AppPromoteToLeader Deserialize(byte[] buffer, AppPromoteToLeader instance, bool isDelta = False) { }

	// RVA: 0x208E0B0 Offset: 0x208D4B0 VA: 0x18208E0B0
	public static AppPromoteToLeader Deserialize(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x208DC00 Offset: 0x208D000 VA: 0x18208DC00
	public static AppPromoteToLeader DeserializeLengthDelimited(Stream stream, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x208DEB0 Offset: 0x208D2B0 VA: 0x18208DEB0
	public static AppPromoteToLeader DeserializeLength(Stream stream, int length, AppPromoteToLeader instance, bool isDelta) { }

	// RVA: 0x208E6C0 Offset: 0x208DAC0 VA: 0x18208E6C0
	public static void SerializeDelta(Stream stream, AppPromoteToLeader instance, AppPromoteToLeader previous) { }

	// RVA: 0x208EA30 Offset: 0x208DE30 VA: 0x18208EA30
	public static void Serialize(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x208EB00 Offset: 0x208DF00 VA: 0x18208EB00
	public byte[] ToProtoBytes() { }

	// RVA: 0x208EB10 Offset: 0x208DF10 VA: 0x18208EB10
	public void ToProto(Stream stream) { }

	// RVA: 0x208E880 Offset: 0x208DC80 VA: 0x18208E880
	public static byte[] SerializeToBytes(AppPromoteToLeader instance) { }

	// RVA: 0x208E7D0 Offset: 0x208DBD0 VA: 0x18208E7D0
	public static void SerializeLengthDelimited(Stream stream, AppPromoteToLeader instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppSuccess : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6519
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11

	// Methods

	// RVA: 0x1E15A70 Offset: 0x1E14E70 VA: 0x181E15A70
	public static void ResetToPool(AppSuccess instance) { }

	// RVA: 0x1E15A00 Offset: 0x1E14E00 VA: 0x181E15A00
	public void ResetToPool() { }

	// RVA: 0x1E15940 Offset: 0x1E14D40 VA: 0x181E15940 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void CopyTo(AppSuccess instance) { }

	// RVA: 0x1E15090 Offset: 0x1E14490 VA: 0x181E15090
	public AppSuccess Copy() { }

	// RVA: 0x1E157C0 Offset: 0x1E14BC0 VA: 0x181E157C0
	public static AppSuccess Deserialize(Stream stream) { }

	// RVA: 0x1E152C0 Offset: 0x1E146C0 VA: 0x181E152C0
	public static AppSuccess DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E15500 Offset: 0x1E14900 VA: 0x181E15500
	public static AppSuccess DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E156A0 Offset: 0x1E14AA0 VA: 0x181E156A0
	public static AppSuccess Deserialize(byte[] buffer) { }

	// RVA: 0x1E159C0 Offset: 0x1E14DC0 VA: 0x181E159C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E15DC0 Offset: 0x1E151C0 VA: 0x181E15DC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E15E30 Offset: 0x1E15230 VA: 0x181E15E30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppSuccess previous) { }

	// RVA: 0x1E159E0 Offset: 0x1E14DE0 VA: 0x181E159E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E15840 Offset: 0x1E14C40 VA: 0x181E15840
	public static AppSuccess Deserialize(byte[] buffer, AppSuccess instance, bool isDelta = False) { }

	// RVA: 0x1E15590 Offset: 0x1E14990 VA: 0x181E15590
	public static AppSuccess Deserialize(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E150E0 Offset: 0x1E144E0 VA: 0x181E150E0
	public static AppSuccess DeserializeLengthDelimited(Stream stream, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E15340 Offset: 0x1E14740 VA: 0x181E15340
	public static AppSuccess DeserializeLength(Stream stream, int length, AppSuccess instance, bool isDelta) { }

	// RVA: 0x1E15AE0 Offset: 0x1E14EE0 VA: 0x181E15AE0
	public static void SerializeDelta(Stream stream, AppSuccess instance, AppSuccess previous) { }

	// RVA: 0x1E15D50 Offset: 0x1E15150 VA: 0x181E15D50
	public static void Serialize(Stream stream, AppSuccess instance) { }

	// RVA: 0x1E15DB0 Offset: 0x1E151B0 VA: 0x181E15DB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E15DC0 Offset: 0x1E151C0 VA: 0x181E15DC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E15BF0 Offset: 0x1E14FF0 VA: 0x181E15BF0
	public static byte[] SerializeToBytes(AppSuccess instance) { }

	// RVA: 0x1E15B40 Offset: 0x1E14F40 VA: 0x181E15B40
	public static void SerializeLengthDelimited(Stream stream, AppSuccess instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppError : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6520
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string error; // 0x18

	// Methods

	// RVA: 0x20814F0 Offset: 0x20808F0 VA: 0x1820814F0
	public static void ResetToPool(AppError instance) { }

	// RVA: 0x2081460 Offset: 0x2080860 VA: 0x182081460
	public void ResetToPool() { }

	// RVA: 0x2081310 Offset: 0x2080710 VA: 0x182081310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D62910 Offset: 0x1D61D10 VA: 0x181D62910
	public void CopyTo(AppError instance) { }

	// RVA: 0x2080970 Offset: 0x207FD70 VA: 0x182080970
	public AppError Copy() { }

	// RVA: 0x2081020 Offset: 0x2080420 VA: 0x182081020
	public static AppError Deserialize(Stream stream) { }

	// RVA: 0x20809F0 Offset: 0x207FDF0 VA: 0x1820809F0
	public static AppError DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2080E90 Offset: 0x2080290 VA: 0x182080E90
	public static AppError DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20811F0 Offset: 0x20805F0 VA: 0x1820811F0
	public static AppError Deserialize(byte[] buffer) { }

	// RVA: 0x2081420 Offset: 0x2080820 VA: 0x182081420
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20819E0 Offset: 0x2080DE0 VA: 0x1820819E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2081A00 Offset: 0x2080E00 VA: 0x182081A00 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppError previous) { }

	// RVA: 0x2081440 Offset: 0x2080840 VA: 0x182081440 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2080F20 Offset: 0x2080320 VA: 0x182080F20
	public static AppError Deserialize(byte[] buffer, AppError instance, bool isDelta = False) { }

	// RVA: 0x20810A0 Offset: 0x20804A0 VA: 0x1820810A0
	public static AppError Deserialize(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x2080A70 Offset: 0x207FE70 VA: 0x182080A70
	public static AppError DeserializeLengthDelimited(Stream stream, AppError instance, bool isDelta) { }

	// RVA: 0x2080C90 Offset: 0x2080090 VA: 0x182080C90
	public static AppError DeserializeLength(Stream stream, int length, AppError instance, bool isDelta) { }

	// RVA: 0x2081580 Offset: 0x2080980 VA: 0x182081580
	public static void SerializeDelta(Stream stream, AppError instance, AppError previous) { }

	// RVA: 0x20818A0 Offset: 0x2080CA0 VA: 0x1820818A0
	public static void Serialize(Stream stream, AppError instance) { }

	// RVA: 0x20819D0 Offset: 0x2080DD0 VA: 0x1820819D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20819E0 Offset: 0x2080DE0 VA: 0x1820819E0
	public void ToProto(Stream stream) { }

	// RVA: 0x2081790 Offset: 0x2080B90 VA: 0x182081790
	public static byte[] SerializeToBytes(AppError instance) { }

	// RVA: 0x20816E0 Offset: 0x2080AE0 VA: 0x1820816E0
	public static void SerializeLengthDelimited(Stream stream, AppError instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppFlag : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6521
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12

	// Methods

	// RVA: 0x2082630 Offset: 0x2081A30 VA: 0x182082630
	public static void ResetToPool(AppFlag instance) { }

	// RVA: 0x20826B0 Offset: 0x2081AB0 VA: 0x1820826B0
	public void ResetToPool() { }

	// RVA: 0x2082500 Offset: 0x2081900 VA: 0x182082500 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E13F00 Offset: 0x1E13300 VA: 0x181E13F00
	public void CopyTo(AppFlag instance) { }

	// RVA: 0x2081B80 Offset: 0x2080F80 VA: 0x182081B80
	public AppFlag Copy() { }

	// RVA: 0x2082480 Offset: 0x2081880 VA: 0x182082480
	public static AppFlag Deserialize(Stream stream) { }

	// RVA: 0x2081E10 Offset: 0x2081210 VA: 0x182081E10
	public static AppFlag DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2081E90 Offset: 0x2081290 VA: 0x182081E90
	public static AppFlag DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2082120 Offset: 0x2081520 VA: 0x182082120
	public static AppFlag Deserialize(byte[] buffer) { }

	// RVA: 0x20825F0 Offset: 0x20819F0 VA: 0x1820825F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2082B40 Offset: 0x2081F40 VA: 0x182082B40 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2082C10 Offset: 0x2082010 VA: 0x182082C10 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppFlag previous) { }

	// RVA: 0x2082610 Offset: 0x2081A10 VA: 0x182082610 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2082240 Offset: 0x2081640 VA: 0x182082240
	public static AppFlag Deserialize(byte[] buffer, AppFlag instance, bool isDelta = False) { }

	// RVA: 0x2082340 Offset: 0x2081740 VA: 0x182082340
	public static AppFlag Deserialize(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2081BF0 Offset: 0x2080FF0 VA: 0x182081BF0
	public static AppFlag DeserializeLengthDelimited(Stream stream, AppFlag instance, bool isDelta) { }

	// RVA: 0x2081F20 Offset: 0x2081320 VA: 0x182081F20
	public static AppFlag DeserializeLength(Stream stream, int length, AppFlag instance, bool isDelta) { }

	// RVA: 0x2082730 Offset: 0x2081B30 VA: 0x182082730
	public static void SerializeDelta(Stream stream, AppFlag instance, AppFlag previous) { }

	// RVA: 0x2082A60 Offset: 0x2081E60 VA: 0x182082A60
	public static void Serialize(Stream stream, AppFlag instance) { }

	// RVA: 0x2082B30 Offset: 0x2081F30 VA: 0x182082B30
	public byte[] ToProtoBytes() { }

	// RVA: 0x2082B40 Offset: 0x2081F40 VA: 0x182082B40
	public void ToProto(Stream stream) { }

	// RVA: 0x20828B0 Offset: 0x2081CB0 VA: 0x1820828B0
	public static byte[] SerializeToBytes(AppFlag instance) { }

	// RVA: 0x2082800 Offset: 0x2081C00 VA: 0x182082800
	public static void SerializeLengthDelimited(Stream stream, AppFlag instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6522
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x2084570 Offset: 0x2083970 VA: 0x182084570
	public static void ResetToPool(AppInfo instance) { }

	// RVA: 0x20843C0 Offset: 0x20837C0 VA: 0x1820843C0
	public void ResetToPool() { }

	// RVA: 0x2084150 Offset: 0x2083550 VA: 0x182084150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2082D60 Offset: 0x2082160 VA: 0x182082D60
	public void CopyTo(AppInfo instance) { }

	// RVA: 0x2082E10 Offset: 0x2082210 VA: 0x182082E10
	public AppInfo Copy() { }

	// RVA: 0x20840D0 Offset: 0x20834D0 VA: 0x1820840D0
	public static AppInfo Deserialize(Stream stream) { }

	// RVA: 0x2083430 Offset: 0x2082830 VA: 0x182083430
	public static AppInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20834B0 Offset: 0x20828B0 VA: 0x1820834B0
	public static AppInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2083B50 Offset: 0x2082F50 VA: 0x182083B50
	public static AppInfo Deserialize(byte[] buffer) { }

	// RVA: 0x2084380 Offset: 0x2083780 VA: 0x182084380
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2085320 Offset: 0x2084720 VA: 0x182085320 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2085340 Offset: 0x2084740 VA: 0x182085340 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppInfo previous) { }

	// RVA: 0x20843A0 Offset: 0x20837A0 VA: 0x1820843A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2083A50 Offset: 0x2082E50 VA: 0x182083A50
	public static AppInfo Deserialize(byte[] buffer, AppInfo instance, bool isDelta = False) { }

	// RVA: 0x2083C70 Offset: 0x2083070 VA: 0x182083C70
	public static AppInfo Deserialize(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2082F00 Offset: 0x2082300 VA: 0x182082F00
	public static AppInfo DeserializeLengthDelimited(Stream stream, AppInfo instance, bool isDelta) { }

	// RVA: 0x2083540 Offset: 0x2082940 VA: 0x182083540
	public static AppInfo DeserializeLength(Stream stream, int length, AppInfo instance, bool isDelta) { }

	// RVA: 0x2084720 Offset: 0x2083B20 VA: 0x182084720
	public static void SerializeDelta(Stream stream, AppInfo instance, AppInfo previous) { }

	// RVA: 0x2084EF0 Offset: 0x20842F0 VA: 0x182084EF0
	public static void Serialize(Stream stream, AppInfo instance) { }

	// RVA: 0x2085310 Offset: 0x2084710 VA: 0x182085310
	public byte[] ToProtoBytes() { }

	// RVA: 0x2085320 Offset: 0x2084720 VA: 0x182085320
	public void ToProto(Stream stream) { }

	// RVA: 0x2084DE0 Offset: 0x20841E0 VA: 0x182084DE0
	public static byte[] SerializeToBytes(AppInfo instance) { }

	// RVA: 0x2084D30 Offset: 0x2084130 VA: 0x182084D30
	public static void SerializeLengthDelimited(Stream stream, AppInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTime : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6523
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float dayLengthMinutes; // 0x14
	public float timeScale; // 0x18
	public float sunrise; // 0x1C
	public float sunset; // 0x20
	public float time; // 0x24

	// Methods

	// RVA: 0x1E1DE80 Offset: 0x1E1D280 VA: 0x181E1DE80
	public static void ResetToPool(AppTime instance) { }

	// RVA: 0x1E1DDD0 Offset: 0x1E1D1D0 VA: 0x181E1DDD0
	public void ResetToPool() { }

	// RVA: 0x1E1DAD0 Offset: 0x1E1CED0 VA: 0x181E1DAD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C720 Offset: 0x1E1BB20 VA: 0x181E1C720
	public void CopyTo(AppTime instance) { }

	// RVA: 0x1E1C760 Offset: 0x1E1BB60 VA: 0x181E1C760
	public AppTime Copy() { }

	// RVA: 0x1E1D270 Offset: 0x1E1C670 VA: 0x181E1D270
	public static AppTime Deserialize(Stream stream) { }

	// RVA: 0x1E1C7E0 Offset: 0x1E1BBE0 VA: 0x181E1C7E0
	public static AppTime DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1CB90 Offset: 0x1E1BF90 VA: 0x181E1CB90
	public static AppTime DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1D770 Offset: 0x1E1CB70 VA: 0x181E1D770
	public static AppTime Deserialize(byte[] buffer) { }

	// RVA: 0x1E1DB50 Offset: 0x1E1CF50 VA: 0x181E1DB50
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1E500 Offset: 0x1E1D900 VA: 0x181E1E500 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1E520 Offset: 0x1E1D920 VA: 0x181E1E520 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTime previous) { }

	// RVA: 0x1E1DDB0 Offset: 0x1E1D1B0 VA: 0x181E1DDB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1CF30 Offset: 0x1E1C330 VA: 0x181E1CF30
	public static AppTime Deserialize(byte[] buffer, AppTime instance, bool isDelta = False) { }

	// RVA: 0x1E1D510 Offset: 0x1E1C910 VA: 0x181E1D510
	public static AppTime Deserialize(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E1C860 Offset: 0x1E1BC60 VA: 0x181E1C860
	public static AppTime DeserializeLengthDelimited(Stream stream, AppTime instance, bool isDelta) { }

	// RVA: 0x1E1CC20 Offset: 0x1E1C020 VA: 0x181E1CC20
	public static AppTime DeserializeLength(Stream stream, int length, AppTime instance, bool isDelta) { }

	// RVA: 0x1E1DF30 Offset: 0x1E1D330 VA: 0x181E1DF30
	public static void SerializeDelta(Stream stream, AppTime instance, AppTime previous) { }

	// RVA: 0x1E1E380 Offset: 0x1E1D780 VA: 0x181E1E380
	public static void Serialize(Stream stream, AppTime instance) { }

	// RVA: 0x1E1E4F0 Offset: 0x1E1D8F0 VA: 0x181E1E4F0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1E500 Offset: 0x1E1D900 VA: 0x181E1E500
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1E270 Offset: 0x1E1D670 VA: 0x181E1E270
	public static byte[] SerializeToBytes(AppTime instance) { }

	// RVA: 0x1E1E1C0 Offset: 0x1E1D5C0 VA: 0x181E1E1C0
	public static void SerializeLengthDelimited(Stream stream, AppTime instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppMap : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6524
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint width; // 0x14
	public uint height; // 0x18
	public byte[] jpgImage; // 0x20
	public int oceanMargin; // 0x28
	public List<AppMap.Monument> monuments; // 0x30
	public string background; // 0x38

	// Methods

	// RVA: 0x2088E70 Offset: 0x2088270 VA: 0x182088E70
	public static void ResetToPool(AppMap instance) { }

	// RVA: 0x2088C40 Offset: 0x2088040 VA: 0x182088C40
	public void ResetToPool() { }

	// RVA: 0x2088850 Offset: 0x2087C50 VA: 0x182088850 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2086DA0 Offset: 0x20861A0 VA: 0x182086DA0
	public void CopyTo(AppMap instance) { }

	// RVA: 0x2086FC0 Offset: 0x20863C0 VA: 0x182086FC0
	public AppMap Copy() { }

	// RVA: 0x2087D70 Offset: 0x2087170 VA: 0x182087D70
	public static AppMap Deserialize(Stream stream) { }

	// RVA: 0x2087470 Offset: 0x2086870 VA: 0x182087470
	public static AppMap DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x20878F0 Offset: 0x2086CF0 VA: 0x1820878F0
	public static AppMap DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2087980 Offset: 0x2086D80 VA: 0x182087980
	public static AppMap Deserialize(byte[] buffer) { }

	// RVA: 0x20888D0 Offset: 0x2087CD0 VA: 0x1820888D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2089990 Offset: 0x2088D90 VA: 0x182089990 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x20899B0 Offset: 0x2088DB0 VA: 0x1820899B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap previous) { }

	// RVA: 0x2088C20 Offset: 0x2088020 VA: 0x182088C20 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2088420 Offset: 0x2087820 VA: 0x182088420
	public static AppMap Deserialize(byte[] buffer, AppMap instance, bool isDelta = False) { }

	// RVA: 0x20880D0 Offset: 0x20874D0 VA: 0x1820880D0
	public static AppMap Deserialize(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x2087040 Offset: 0x2086440 VA: 0x182087040
	public static AppMap DeserializeLengthDelimited(Stream stream, AppMap instance, bool isDelta) { }

	// RVA: 0x20874F0 Offset: 0x20868F0 VA: 0x1820874F0
	public static AppMap DeserializeLength(Stream stream, int length, AppMap instance, bool isDelta) { }

	// RVA: 0x20890A0 Offset: 0x20884A0 VA: 0x1820890A0
	public static void SerializeDelta(Stream stream, AppMap instance, AppMap previous) { }

	// RVA: 0x2089630 Offset: 0x2088A30 VA: 0x182089630
	public static void Serialize(Stream stream, AppMap instance) { }

	// RVA: 0x2089980 Offset: 0x2088D80 VA: 0x182089980
	public byte[] ToProtoBytes() { }

	// RVA: 0x2089990 Offset: 0x2088D90 VA: 0x182089990
	public void ToProto(Stream stream) { }

	// RVA: 0x2089520 Offset: 0x2088920 VA: 0x182089520
	public static byte[] SerializeToBytes(AppMap instance) { }

	// RVA: 0x2089470 Offset: 0x2088870 VA: 0x182089470
	public static void SerializeLengthDelimited(Stream stream, AppMap instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppMap.Monument : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6525
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string token; // 0x18
	public float x; // 0x20
	public float y; // 0x24

	// Methods

	// RVA: 0x2091790 Offset: 0x2090B90 VA: 0x182091790
	public static void ResetToPool(AppMap.Monument instance) { }

	// RVA: 0x2091840 Offset: 0x2090C40 VA: 0x182091840
	public void ResetToPool() { }

	// RVA: 0x2091530 Offset: 0x2090930 VA: 0x182091530 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2090520 Offset: 0x208F920 VA: 0x182090520
	public void CopyTo(AppMap.Monument instance) { }

	// RVA: 0x2090570 Offset: 0x208F970 VA: 0x182090570
	public AppMap.Monument Copy() { }

	// RVA: 0x2090C30 Offset: 0x2090030 VA: 0x182090C30
	public static AppMap.Monument Deserialize(Stream stream) { }

	// RVA: 0x20908A0 Offset: 0x208FCA0 VA: 0x1820908A0
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2090BA0 Offset: 0x208FFA0 VA: 0x182090BA0
	public static AppMap.Monument DeserializeLength(Stream stream, int length) { }

	// RVA: 0x20910C0 Offset: 0x20904C0 VA: 0x1820910C0
	public static AppMap.Monument Deserialize(byte[] buffer) { }

	// RVA: 0x20915B0 Offset: 0x20909B0 VA: 0x1820915B0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2091E80 Offset: 0x2091280 VA: 0x182091E80 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2091EA0 Offset: 0x20912A0 VA: 0x182091EA0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMap.Monument previous) { }

	// RVA: 0x2091770 Offset: 0x2090B70 VA: 0x182091770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2090E30 Offset: 0x2090230 VA: 0x182090E30
	public static AppMap.Monument Deserialize(byte[] buffer, AppMap.Monument instance, bool isDelta = False) { }

	// RVA: 0x2091370 Offset: 0x2090770 VA: 0x182091370
	public static AppMap.Monument Deserialize(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2090600 Offset: 0x208FA00 VA: 0x182090600
	public static AppMap.Monument DeserializeLengthDelimited(Stream stream, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x2090920 Offset: 0x208FD20 VA: 0x182090920
	public static AppMap.Monument DeserializeLength(Stream stream, int length, AppMap.Monument instance, bool isDelta) { }

	// RVA: 0x20918F0 Offset: 0x2090CF0 VA: 0x1820918F0
	public static void SerializeDelta(Stream stream, AppMap.Monument instance, AppMap.Monument previous) { }

	// RVA: 0x2091CE0 Offset: 0x20910E0 VA: 0x182091CE0
	public static void Serialize(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x2091E70 Offset: 0x2091270 VA: 0x182091E70
	public byte[] ToProtoBytes() { }

	// RVA: 0x2091E80 Offset: 0x2091280 VA: 0x182091E80
	public void ToProto(Stream stream) { }

	// RVA: 0x2091BD0 Offset: 0x2090FD0 VA: 0x182091BD0
	public static byte[] SerializeToBytes(AppMap.Monument instance) { }

	// RVA: 0x2091B20 Offset: 0x2090F20 VA: 0x182091B20
	public static void SerializeLengthDelimited(Stream stream, AppMap.Monument instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppEntityInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6526
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppEntityType type; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x207DA80 Offset: 0x207CE80 VA: 0x18207DA80
	public static void ResetToPool(AppEntityInfo instance) { }

	// RVA: 0x207D9D0 Offset: 0x207CDD0 VA: 0x18207D9D0
	public void ResetToPool() { }

	// RVA: 0x207D860 Offset: 0x207CC60 VA: 0x18207D860 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x207B6E0 Offset: 0x207AAE0 VA: 0x18207B6E0
	public void CopyTo(AppEntityInfo instance) { }

	// RVA: 0x207CC70 Offset: 0x207C070 VA: 0x18207CC70
	public AppEntityInfo Copy() { }

	// RVA: 0x207D7E0 Offset: 0x207CBE0 VA: 0x18207D7E0
	public static AppEntityInfo Deserialize(Stream stream) { }

	// RVA: 0x207CD40 Offset: 0x207C140 VA: 0x18207CD40
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x207D330 Offset: 0x207C730 VA: 0x18207D330
	public static AppEntityInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x207D3C0 Offset: 0x207C7C0 VA: 0x18207D3C0
	public static AppEntityInfo Deserialize(byte[] buffer) { }

	// RVA: 0x207D990 Offset: 0x207CD90 VA: 0x18207D990
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x207E140 Offset: 0x207D540 VA: 0x18207E140 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x207E160 Offset: 0x207D560 VA: 0x18207E160 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityInfo previous) { }

	// RVA: 0x207D9B0 Offset: 0x207CDB0 VA: 0x18207D9B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x207D6E0 Offset: 0x207CAE0 VA: 0x18207D6E0
	public static AppEntityInfo Deserialize(byte[] buffer, AppEntityInfo instance, bool isDelta = False) { }

	// RVA: 0x207D4E0 Offset: 0x207C8E0 VA: 0x18207D4E0
	public static AppEntityInfo Deserialize(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x207CDC0 Offset: 0x207C1C0 VA: 0x18207CDC0
	public static AppEntityInfo DeserializeLengthDelimited(Stream stream, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x207D090 Offset: 0x207C490 VA: 0x18207D090
	public static AppEntityInfo DeserializeLength(Stream stream, int length, AppEntityInfo instance, bool isDelta) { }

	// RVA: 0x207DB30 Offset: 0x207CF30 VA: 0x18207DB30
	public static void SerializeDelta(Stream stream, AppEntityInfo instance, AppEntityInfo previous) { }

	// RVA: 0x207DF20 Offset: 0x207D320 VA: 0x18207DF20
	public static void Serialize(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x207E130 Offset: 0x207D530 VA: 0x18207E130
	public byte[] ToProtoBytes() { }

	// RVA: 0x207E140 Offset: 0x207D540 VA: 0x18207E140
	public void ToProto(Stream stream) { }

	// RVA: 0x207DE10 Offset: 0x207D210 VA: 0x18207DE10
	public static byte[] SerializeToBytes(AppEntityInfo instance) { }

	// RVA: 0x207DD60 Offset: 0x207D160 VA: 0x18207DD60
	public static void SerializeLengthDelimited(Stream stream, AppEntityInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppEntityPayload : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6527
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public bool value; // 0x12
	public List<AppEntityPayload.Item> items; // 0x18
	public int capacity; // 0x20
	public bool hasProtection; // 0x24
	public uint protectionExpiry; // 0x28

	// Methods

	// RVA: 0x207FD70 Offset: 0x207F170 VA: 0x18207FD70
	public static void ResetToPool(AppEntityPayload instance) { }

	// RVA: 0x207FF80 Offset: 0x207F380 VA: 0x18207FF80
	public void ResetToPool() { }

	// RVA: 0x207F9E0 Offset: 0x207EDE0 VA: 0x18207F9E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x207E180 Offset: 0x207D580 VA: 0x18207E180
	public void CopyTo(AppEntityPayload instance) { }

	// RVA: 0x207E330 Offset: 0x207D730 VA: 0x18207E330
	public AppEntityPayload Copy() { }

	// RVA: 0x207F000 Offset: 0x207E400 VA: 0x18207F000
	public static AppEntityPayload Deserialize(Stream stream) { }

	// RVA: 0x207E3B0 Offset: 0x207D7B0 VA: 0x18207E3B0
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x207E810 Offset: 0x207DC10 VA: 0x18207E810
	public static AppEntityPayload DeserializeLength(Stream stream, int length) { }

	// RVA: 0x207EC50 Offset: 0x207E050 VA: 0x18207EC50
	public static AppEntityPayload Deserialize(byte[] buffer) { }

	// RVA: 0x207FA60 Offset: 0x207EE60 VA: 0x18207FA60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2080930 Offset: 0x207FD30 VA: 0x182080930 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2080950 Offset: 0x207FD50 VA: 0x182080950 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload previous) { }

	// RVA: 0x207FD50 Offset: 0x207F150 VA: 0x18207FD50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x207F310 Offset: 0x207E710 VA: 0x18207F310
	public static AppEntityPayload Deserialize(byte[] buffer, AppEntityPayload instance, bool isDelta = False) { }

	// RVA: 0x207F6E0 Offset: 0x207EAE0 VA: 0x18207F6E0
	public static AppEntityPayload Deserialize(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x207E430 Offset: 0x207D830 VA: 0x18207E430
	public static AppEntityPayload DeserializeLengthDelimited(Stream stream, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x207E8A0 Offset: 0x207DCA0 VA: 0x18207E8A0
	public static AppEntityPayload DeserializeLength(Stream stream, int length, AppEntityPayload instance, bool isDelta) { }

	// RVA: 0x2080190 Offset: 0x207F590 VA: 0x182080190
	public static void SerializeDelta(Stream stream, AppEntityPayload instance, AppEntityPayload previous) { }

	// RVA: 0x2080670 Offset: 0x207FA70 VA: 0x182080670
	public static void Serialize(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x2080920 Offset: 0x207FD20 VA: 0x182080920
	public byte[] ToProtoBytes() { }

	// RVA: 0x2080930 Offset: 0x207FD30 VA: 0x182080930
	public void ToProto(Stream stream) { }

	// RVA: 0x2080560 Offset: 0x207F960 VA: 0x182080560
	public static byte[] SerializeToBytes(AppEntityPayload instance) { }

	// RVA: 0x20804B0 Offset: 0x207F8B0 VA: 0x1820804B0
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppEntityPayload.Item : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6528
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemId; // 0x14
	public int quantity; // 0x18
	public bool itemIsBlueprint; // 0x1C

	// Methods

	// RVA: 0x208FF10 Offset: 0x208F310 VA: 0x18208FF10
	public static void ResetToPool(AppEntityPayload.Item instance) { }

	// RVA: 0x208FFA0 Offset: 0x208F3A0 VA: 0x18208FFA0
	public void ResetToPool() { }

	// RVA: 0x208FCC0 Offset: 0x208F0C0 VA: 0x18208FCC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D63960 Offset: 0x1D62D60 VA: 0x181D63960
	public void CopyTo(AppEntityPayload.Item instance) { }

	// RVA: 0x208ED90 Offset: 0x208E190 VA: 0x18208ED90
	public AppEntityPayload.Item Copy() { }

	// RVA: 0x208F400 Offset: 0x208E800 VA: 0x18208F400
	public static AppEntityPayload.Item Deserialize(Stream stream) { }

	// RVA: 0x208EE10 Offset: 0x208E210 VA: 0x18208EE10
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208F110 Offset: 0x208E510 VA: 0x18208F110
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208F5F0 Offset: 0x208E9F0 VA: 0x18208F5F0
	public static AppEntityPayload.Item Deserialize(byte[] buffer) { }

	// RVA: 0x208FD40 Offset: 0x208F140 VA: 0x18208FD40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20904E0 Offset: 0x208F8E0 VA: 0x1820904E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2090500 Offset: 0x208F900 VA: 0x182090500 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityPayload.Item previous) { }

	// RVA: 0x208FEF0 Offset: 0x208F2F0 VA: 0x18208FEF0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208FA40 Offset: 0x208EE40 VA: 0x18208FA40
	public static AppEntityPayload.Item Deserialize(byte[] buffer, AppEntityPayload.Item instance, bool isDelta = False) { }

	// RVA: 0x208F890 Offset: 0x208EC90 VA: 0x18208F890
	public static AppEntityPayload.Item Deserialize(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x208EE90 Offset: 0x208E290 VA: 0x18208EE90
	public static AppEntityPayload.Item DeserializeLengthDelimited(Stream stream, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x208F1A0 Offset: 0x208E5A0 VA: 0x18208F1A0
	public static AppEntityPayload.Item DeserializeLength(Stream stream, int length, AppEntityPayload.Item instance, bool isDelta) { }

	// RVA: 0x2090030 Offset: 0x208F430 VA: 0x182090030
	public static void SerializeDelta(Stream stream, AppEntityPayload.Item instance, AppEntityPayload.Item previous) { }

	// RVA: 0x20903B0 Offset: 0x208F7B0 VA: 0x1820903B0
	public static void Serialize(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x20904D0 Offset: 0x208F8D0 VA: 0x1820904D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20904E0 Offset: 0x208F8E0 VA: 0x1820904E0
	public void ToProto(Stream stream) { }

	// RVA: 0x20902A0 Offset: 0x208F6A0 VA: 0x1820902A0
	public static byte[] SerializeToBytes(AppEntityPayload.Item instance) { }

	// RVA: 0x20901F0 Offset: 0x208F5F0 VA: 0x1820901F0
	public static void SerializeLengthDelimited(Stream stream, AppEntityPayload.Item instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6529
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong leaderSteamId; // 0x18
	public List<AppTeamInfo.Member> members; // 0x20
	public List<AppTeamInfo.Note> mapNotes; // 0x28
	public List<AppTeamInfo.Note> leaderMapNotes; // 0x30

	// Methods

	// RVA: 0x1E1A4C0 Offset: 0x1E198C0 VA: 0x181E1A4C0
	public static void ResetToPool(AppTeamInfo instance) { }

	// RVA: 0x1E1A090 Offset: 0x1E19490 VA: 0x181E1A090
	public void ResetToPool() { }

	// RVA: 0x1E19FD0 Offset: 0x1E193D0 VA: 0x181E19FD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E18A00 Offset: 0x1E17E00 VA: 0x181E18A00
	public void CopyTo(AppTeamInfo instance) { }

	// RVA: 0x1E18E50 Offset: 0x1E18250 VA: 0x181E18E50
	public AppTeamInfo Copy() { }

	// RVA: 0x1E19F50 Offset: 0x1E19350 VA: 0x181E19F50
	public static AppTeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1E19390 Offset: 0x1E18790 VA: 0x181E19390
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E19410 Offset: 0x1E18810 VA: 0x181E19410
	public static AppTeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E19E30 Offset: 0x1E19230 VA: 0x181E19E30
	public static AppTeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1E1A050 Offset: 0x1E19450 VA: 0x181E1A050
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1B3F0 Offset: 0x1E1A7F0 VA: 0x181E1B3F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1B410 Offset: 0x1E1A810 VA: 0x181E1B410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo previous) { }

	// RVA: 0x1E1A070 Offset: 0x1E19470 VA: 0x181E1A070 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E19D30 Offset: 0x1E19130 VA: 0x181E19D30
	public static AppTeamInfo Deserialize(byte[] buffer, AppTeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1E19940 Offset: 0x1E18D40 VA: 0x181E19940
	public static AppTeamInfo Deserialize(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E18ED0 Offset: 0x1E182D0 VA: 0x181E18ED0
	public static AppTeamInfo DeserializeLengthDelimited(Stream stream, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E194A0 Offset: 0x1E188A0 VA: 0x181E194A0
	public static AppTeamInfo DeserializeLength(Stream stream, int length, AppTeamInfo instance, bool isDelta) { }

	// RVA: 0x1E1A8F0 Offset: 0x1E19CF0 VA: 0x181E1A8F0
	public static void SerializeDelta(Stream stream, AppTeamInfo instance, AppTeamInfo previous) { }

	// RVA: 0x1E1AF60 Offset: 0x1E1A360 VA: 0x181E1AF60
	public static void Serialize(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x1E1B3E0 Offset: 0x1E1A7E0 VA: 0x181E1B3E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1B3F0 Offset: 0x1E1A7F0 VA: 0x181E1B3F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1AE50 Offset: 0x1E1A250 VA: 0x181E1AE50
	public static byte[] SerializeToBytes(AppTeamInfo instance) { }

	// RVA: 0x1E1ADA0 Offset: 0x1E1A1A0 VA: 0x181E1ADA0
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTeamInfo.Member : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6530
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18
	public string name; // 0x20
	public float x; // 0x28
	public float y; // 0x2C
	public bool isOnline; // 0x30
	public uint spawnTime; // 0x34
	public bool isAlive; // 0x38
	public uint deathTime; // 0x3C

	// Methods

	// RVA: 0x1E228C0 Offset: 0x1E21CC0 VA: 0x181E228C0
	public static void ResetToPool(AppTeamInfo.Member instance) { }

	// RVA: 0x1E227C0 Offset: 0x1E21BC0 VA: 0x181E227C0
	public void ResetToPool() { }

	// RVA: 0x1E223F0 Offset: 0x1E217F0 VA: 0x181E223F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E20AC0 Offset: 0x1E1FEC0 VA: 0x181E20AC0
	public void CopyTo(AppTeamInfo.Member instance) { }

	// RVA: 0x1E20B30 Offset: 0x1E1FF30 VA: 0x181E20B30
	public AppTeamInfo.Member Copy() { }

	// RVA: 0x1E21930 Offset: 0x1E20D30 VA: 0x181E21930
	public static AppTeamInfo.Member Deserialize(Stream stream) { }

	// RVA: 0x1E20BE0 Offset: 0x1E1FFE0 VA: 0x181E20BE0
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E21070 Offset: 0x1E20470 VA: 0x181E21070
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E214F0 Offset: 0x1E208F0 VA: 0x181E214F0
	public static AppTeamInfo.Member Deserialize(byte[] buffer) { }

	// RVA: 0x1E22470 Offset: 0x1E21870 VA: 0x181E22470
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E231A0 Offset: 0x1E225A0 VA: 0x181E231A0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E231C0 Offset: 0x1E225C0 VA: 0x181E231C0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Member previous) { }

	// RVA: 0x1E227A0 Offset: 0x1E21BA0 VA: 0x181E227A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E21FD0 Offset: 0x1E213D0 VA: 0x181E21FD0
	public static AppTeamInfo.Member Deserialize(byte[] buffer, AppTeamInfo.Member instance, bool isDelta = False) { }

	// RVA: 0x1E21CA0 Offset: 0x1E210A0 VA: 0x181E21CA0
	public static AppTeamInfo.Member Deserialize(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E20C60 Offset: 0x1E20060 VA: 0x181E20C60
	public static AppTeamInfo.Member DeserializeLengthDelimited(Stream stream, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E21100 Offset: 0x1E20500 VA: 0x181E21100
	public static AppTeamInfo.Member DeserializeLength(Stream stream, int length, AppTeamInfo.Member instance, bool isDelta) { }

	// RVA: 0x1E229C0 Offset: 0x1E21DC0 VA: 0x181E229C0
	public static void SerializeDelta(Stream stream, AppTeamInfo.Member instance, AppTeamInfo.Member previous) { }

	// RVA: 0x1E22F30 Offset: 0x1E22330 VA: 0x181E22F30
	public static void Serialize(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x1E23190 Offset: 0x1E22590 VA: 0x181E23190
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E231A0 Offset: 0x1E225A0 VA: 0x181E231A0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E22E20 Offset: 0x1E22220 VA: 0x181E22E20
	public static byte[] SerializeToBytes(AppTeamInfo.Member instance) { }

	// RVA: 0x1E22D70 Offset: 0x1E22170 VA: 0x181E22D70
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Member instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTeamInfo.Note : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6531
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int type; // 0x14
	public float x; // 0x18
	public float y; // 0x1C

	// Methods

	// RVA: 0x1E243D0 Offset: 0x1E237D0 VA: 0x181E243D0
	public static void ResetToPool(AppTeamInfo.Note instance) { }

	// RVA: 0x1E24460 Offset: 0x1E23860 VA: 0x181E24460
	public void ResetToPool() { }

	// RVA: 0x1E24180 Offset: 0x1E23580 VA: 0x181E24180 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E231E0 Offset: 0x1E225E0 VA: 0x181E231E0
	public void CopyTo(AppTeamInfo.Note instance) { }

	// RVA: 0x1E23210 Offset: 0x1E22610 VA: 0x181E23210
	public AppTeamInfo.Note Copy() { }

	// RVA: 0x1E23F90 Offset: 0x1E23390 VA: 0x181E23F90
	public static AppTeamInfo.Note Deserialize(Stream stream) { }

	// RVA: 0x1E23290 Offset: 0x1E22690 VA: 0x181E23290
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E23810 Offset: 0x1E22C10 VA: 0x181E23810
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E23CE0 Offset: 0x1E230E0 VA: 0x181E23CE0
	public static AppTeamInfo.Note Deserialize(byte[] buffer) { }

	// RVA: 0x1E24200 Offset: 0x1E23600 VA: 0x181E24200
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E249D0 Offset: 0x1E23DD0 VA: 0x181E249D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E249F0 Offset: 0x1E23DF0 VA: 0x181E249F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamInfo.Note previous) { }

	// RVA: 0x1E243B0 Offset: 0x1E237B0 VA: 0x181E243B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E238A0 Offset: 0x1E22CA0 VA: 0x181E238A0
	public static AppTeamInfo.Note Deserialize(byte[] buffer, AppTeamInfo.Note instance, bool isDelta = False) { }

	// RVA: 0x1E23B30 Offset: 0x1E22F30 VA: 0x181E23B30
	public static AppTeamInfo.Note Deserialize(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E23310 Offset: 0x1E22710 VA: 0x181E23310
	public static AppTeamInfo.Note DeserializeLengthDelimited(Stream stream, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E235A0 Offset: 0x1E229A0 VA: 0x181E235A0
	public static AppTeamInfo.Note DeserializeLength(Stream stream, int length, AppTeamInfo.Note instance, bool isDelta) { }

	// RVA: 0x1E244F0 Offset: 0x1E238F0 VA: 0x181E244F0
	public static void SerializeDelta(Stream stream, AppTeamInfo.Note instance, AppTeamInfo.Note previous) { }

	// RVA: 0x1E24890 Offset: 0x1E23C90 VA: 0x181E24890
	public static void Serialize(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x1E249C0 Offset: 0x1E23DC0 VA: 0x181E249C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E249D0 Offset: 0x1E23DD0 VA: 0x181E249D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E24780 Offset: 0x1E23B80 VA: 0x181E24780
	public static byte[] SerializeToBytes(AppTeamInfo.Note instance) { }

	// RVA: 0x1E246D0 Offset: 0x1E23AD0 VA: 0x181E246D0
	public static void SerializeLengthDelimited(Stream stream, AppTeamInfo.Note instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppChatMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6532
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong steamId; // 0x18
	public string name; // 0x20
	public string message; // 0x28
	public string color; // 0x30
	public uint time; // 0x38

	// Methods

	// RVA: 0x2012BE0 Offset: 0x2011FE0 VA: 0x182012BE0
	public static void ResetToPool(AppChatMessage instance) { }

	// RVA: 0x2012CF0 Offset: 0x20120F0 VA: 0x182012CF0
	public void ResetToPool() { }

	// RVA: 0x20127C0 Offset: 0x2011BC0 VA: 0x1820127C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2011310 Offset: 0x2010710 VA: 0x182011310
	public void CopyTo(AppChatMessage instance) { }

	// RVA: 0x2011380 Offset: 0x2010780 VA: 0x182011380
	public AppChatMessage Copy() { }

	// RVA: 0x2012500 Offset: 0x2011900 VA: 0x182012500
	public static AppChatMessage Deserialize(Stream stream) { }

	// RVA: 0x2011780 Offset: 0x2010B80 VA: 0x182011780
	public static AppChatMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2011800 Offset: 0x2010C00 VA: 0x182011800
	public static AppChatMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2011BC0 Offset: 0x2010FC0 VA: 0x182011BC0
	public static AppChatMessage Deserialize(byte[] buffer) { }

	// RVA: 0x2012950 Offset: 0x2011D50 VA: 0x182012950
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x20135F0 Offset: 0x20129F0 VA: 0x1820135F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2013610 Offset: 0x2012A10 VA: 0x182013610 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppChatMessage previous) { }

	// RVA: 0x2012BC0 Offset: 0x2011FC0 VA: 0x182012BC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x20121B0 Offset: 0x20115B0 VA: 0x1820121B0
	public static AppChatMessage Deserialize(byte[] buffer, AppChatMessage instance, bool isDelta = False) { }

	// RVA: 0x2011F30 Offset: 0x2011330 VA: 0x182011F30
	public static AppChatMessage Deserialize(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2011430 Offset: 0x2010830 VA: 0x182011430
	public static AppChatMessage DeserializeLengthDelimited(Stream stream, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2011890 Offset: 0x2010C90 VA: 0x182011890
	public static AppChatMessage DeserializeLength(Stream stream, int length, AppChatMessage instance, bool isDelta) { }

	// RVA: 0x2012E00 Offset: 0x2012200 VA: 0x182012E00
	public static void SerializeDelta(Stream stream, AppChatMessage instance, AppChatMessage previous) { }

	// RVA: 0x2013320 Offset: 0x2012720 VA: 0x182013320
	public static void Serialize(Stream stream, AppChatMessage instance) { }

	// RVA: 0x20135E0 Offset: 0x20129E0 VA: 0x1820135E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x20135F0 Offset: 0x20129F0 VA: 0x1820135F0
	public void ToProto(Stream stream) { }

	// RVA: 0x2013210 Offset: 0x2012610 VA: 0x182013210
	public static byte[] SerializeToBytes(AppChatMessage instance) { }

	// RVA: 0x2013160 Offset: 0x2012560 VA: 0x182013160
	public static void SerializeLengthDelimited(Stream stream, AppChatMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTeamChat : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6533
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppChatMessage> messages; // 0x18

	// Methods

	// RVA: 0x1E18280 Offset: 0x1E17680 VA: 0x181E18280
	public static void ResetToPool(AppTeamChat instance) { }

	// RVA: 0x1E180D0 Offset: 0x1E174D0 VA: 0x181E180D0
	public void ResetToPool() { }

	// RVA: 0x1E18010 Offset: 0x1E17410 VA: 0x181E18010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E17460 Offset: 0x1E16860 VA: 0x181E17460
	public void CopyTo(AppTeamChat instance) { }

	// RVA: 0x1E17590 Offset: 0x1E16990 VA: 0x181E17590
	public AppTeamChat Copy() { }

	// RVA: 0x1E17E70 Offset: 0x1E17270 VA: 0x181E17E70
	public static AppTeamChat Deserialize(Stream stream) { }

	// RVA: 0x1E17610 Offset: 0x1E16A10 VA: 0x181E17610
	public static AppTeamChat DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E17B50 Offset: 0x1E16F50 VA: 0x181E17B50
	public static AppTeamChat DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E17EF0 Offset: 0x1E172F0 VA: 0x181E17EF0
	public static AppTeamChat Deserialize(byte[] buffer) { }

	// RVA: 0x1E18090 Offset: 0x1E17490 VA: 0x181E18090
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E189C0 Offset: 0x1E17DC0 VA: 0x181E189C0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E189E0 Offset: 0x1E17DE0 VA: 0x181E189E0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChat previous) { }

	// RVA: 0x1E180B0 Offset: 0x1E174B0 VA: 0x181E180B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E17BE0 Offset: 0x1E16FE0 VA: 0x181E17BE0
	public static AppTeamChat Deserialize(byte[] buffer, AppTeamChat instance, bool isDelta = False) { }

	// RVA: 0x1E17CE0 Offset: 0x1E170E0 VA: 0x181E17CE0
	public static AppTeamChat Deserialize(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E17690 Offset: 0x1E16A90 VA: 0x181E17690
	public static AppTeamChat DeserializeLengthDelimited(Stream stream, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E17900 Offset: 0x1E16D00 VA: 0x181E17900
	public static AppTeamChat DeserializeLength(Stream stream, int length, AppTeamChat instance, bool isDelta) { }

	// RVA: 0x1E18430 Offset: 0x1E17830 VA: 0x181E18430
	public static void SerializeDelta(Stream stream, AppTeamChat instance, AppTeamChat previous) { }

	// RVA: 0x1E187D0 Offset: 0x1E17BD0 VA: 0x181E187D0
	public static void Serialize(Stream stream, AppTeamChat instance) { }

	// RVA: 0x1E189B0 Offset: 0x1E17DB0 VA: 0x181E189B0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E189C0 Offset: 0x1E17DC0 VA: 0x181E189C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E186C0 Offset: 0x1E17AC0 VA: 0x181E186C0
	public static byte[] SerializeToBytes(AppTeamChat instance) { }

	// RVA: 0x1E18610 Offset: 0x1E17A10 VA: 0x181E18610
	public static void SerializeLengthDelimited(Stream stream, AppTeamChat instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppMarker : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6534
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x208B320 Offset: 0x208A720 VA: 0x18208B320
	public static void ResetToPool(AppMarker instance) { }

	// RVA: 0x208B080 Offset: 0x208A480 VA: 0x18208B080
	public void ResetToPool() { }

	// RVA: 0x208AFC0 Offset: 0x208A3C0 VA: 0x18208AFC0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x20899D0 Offset: 0x2088DD0 VA: 0x1820899D0
	public void CopyTo(AppMarker instance) { }

	// RVA: 0x2089BE0 Offset: 0x2088FE0 VA: 0x182089BE0
	public AppMarker Copy() { }

	// RVA: 0x208AE40 Offset: 0x208A240 VA: 0x18208AE40
	public static AppMarker Deserialize(Stream stream) { }

	// RVA: 0x208A1F0 Offset: 0x20895F0 VA: 0x18208A1F0
	public static AppMarker DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x208A270 Offset: 0x2089670 VA: 0x18208A270
	public static AppMarker DeserializeLength(Stream stream, int length) { }

	// RVA: 0x208A860 Offset: 0x2089C60 VA: 0x18208A860
	public static AppMarker Deserialize(byte[] buffer) { }

	// RVA: 0x208B040 Offset: 0x208A440 VA: 0x18208B040
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x208C460 Offset: 0x208B860 VA: 0x18208C460 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x208C480 Offset: 0x208B880 VA: 0x18208C480 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker previous) { }

	// RVA: 0x208B060 Offset: 0x208A460 VA: 0x18208B060 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x208AEC0 Offset: 0x208A2C0 VA: 0x18208AEC0
	public static AppMarker Deserialize(byte[] buffer, AppMarker instance, bool isDelta = False) { }

	// RVA: 0x208A980 Offset: 0x2089D80 VA: 0x18208A980
	public static AppMarker Deserialize(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x2089C60 Offset: 0x2089060 VA: 0x182089C60
	public static AppMarker DeserializeLengthDelimited(Stream stream, AppMarker instance, bool isDelta) { }

	// RVA: 0x208A300 Offset: 0x2089700 VA: 0x18208A300
	public static AppMarker DeserializeLength(Stream stream, int length, AppMarker instance, bool isDelta) { }

	// RVA: 0x208B5C0 Offset: 0x208A9C0 VA: 0x18208B5C0
	public static void SerializeDelta(Stream stream, AppMarker instance, AppMarker previous) { }

	// RVA: 0x208BF20 Offset: 0x208B320 VA: 0x18208BF20
	public static void Serialize(Stream stream, AppMarker instance) { }

	// RVA: 0x208C450 Offset: 0x208B850 VA: 0x18208C450
	public byte[] ToProtoBytes() { }

	// RVA: 0x208C460 Offset: 0x208B860 VA: 0x18208C460
	public void ToProto(Stream stream) { }

	// RVA: 0x208BE10 Offset: 0x208B210 VA: 0x18208BE10
	public static byte[] SerializeToBytes(AppMarker instance) { }

	// RVA: 0x208BD60 Offset: 0x208B160 VA: 0x18208BD60
	public static void SerializeLengthDelimited(Stream stream, AppMarker instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppMarker.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6535
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x2093DF0 Offset: 0x20931F0 VA: 0x182093DF0
	public static void ResetToPool(AppMarker.SellOrder instance) { }

	// RVA: 0x2093D00 Offset: 0x2093100 VA: 0x182093D00
	public void ResetToPool() { }

	// RVA: 0x2093900 Offset: 0x2092D00 VA: 0x182093900 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2091EC0 Offset: 0x20912C0 VA: 0x182091EC0
	public void CopyTo(AppMarker.SellOrder instance) { }

	// RVA: 0x2091F10 Offset: 0x2091310 VA: 0x182091F10
	public AppMarker.SellOrder Copy() { }

	// RVA: 0x2092920 Offset: 0x2091D20 VA: 0x182092920
	public static AppMarker.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x2091FB0 Offset: 0x20913B0 VA: 0x182091FB0
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2092890 Offset: 0x2091C90 VA: 0x182092890
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2093480 Offset: 0x2092880 VA: 0x182093480
	public static AppMarker.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x2093980 Offset: 0x2092D80 VA: 0x182093980
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2094640 Offset: 0x2093A40 VA: 0x182094640 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2094660 Offset: 0x2093A60 VA: 0x182094660 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMarker.SellOrder previous) { }

	// RVA: 0x2093CE0 Offset: 0x20930E0 VA: 0x182093CE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2093020 Offset: 0x2092420 VA: 0x182093020
	public static AppMarker.SellOrder Deserialize(byte[] buffer, AppMarker.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x2092CC0 Offset: 0x20920C0 VA: 0x182092CC0
	public static AppMarker.SellOrder Deserialize(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2092030 Offset: 0x2091430 VA: 0x182092030
	public static AppMarker.SellOrder DeserializeLengthDelimited(Stream stream, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2092470 Offset: 0x2091870 VA: 0x182092470
	public static AppMarker.SellOrder DeserializeLength(Stream stream, int length, AppMarker.SellOrder instance, bool isDelta) { }

	// RVA: 0x2093EE0 Offset: 0x20932E0 VA: 0x182093EE0
	public static void SerializeDelta(Stream stream, AppMarker.SellOrder instance, AppMarker.SellOrder previous) { }

	// RVA: 0x2094430 Offset: 0x2093830 VA: 0x182094430
	public static void Serialize(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x2094630 Offset: 0x2093A30 VA: 0x182094630
	public byte[] ToProtoBytes() { }

	// RVA: 0x2094640 Offset: 0x2093A40 VA: 0x182094640
	public void ToProto(Stream stream) { }

	// RVA: 0x2094320 Offset: 0x2093720 VA: 0x182094320
	public static byte[] SerializeToBytes(AppMarker.SellOrder instance) { }

	// RVA: 0x2094270 Offset: 0x2093670 VA: 0x182094270
	public static void SerializeLengthDelimited(Stream stream, AppMarker.SellOrder instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppMapMarkers : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6536
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<AppMarker> markers; // 0x18

	// Methods

	// RVA: 0x2086470 Offset: 0x2085870 VA: 0x182086470
	public static void ResetToPool(AppMapMarkers instance) { }

	// RVA: 0x2086620 Offset: 0x2085A20 VA: 0x182086620
	public void ResetToPool() { }

	// RVA: 0x20861F0 Offset: 0x20855F0 VA: 0x1820861F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x2085360 Offset: 0x2084760 VA: 0x182085360
	public void CopyTo(AppMapMarkers instance) { }

	// RVA: 0x20854F0 Offset: 0x20848F0 VA: 0x1820854F0
	public AppMapMarkers Copy() { }

	// RVA: 0x2085E80 Offset: 0x2085280 VA: 0x182085E80
	public static AppMapMarkers Deserialize(Stream stream) { }

	// RVA: 0x20859B0 Offset: 0x2084DB0 VA: 0x1820859B0
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x2085CD0 Offset: 0x20850D0 VA: 0x182085CD0
	public static AppMapMarkers DeserializeLength(Stream stream, int length) { }

	// RVA: 0x2085D60 Offset: 0x2085160 VA: 0x182085D60
	public static AppMapMarkers Deserialize(byte[] buffer) { }

	// RVA: 0x2086430 Offset: 0x2085830 VA: 0x182086430
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2086D60 Offset: 0x2086160 VA: 0x182086D60 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x2086D80 Offset: 0x2086180 VA: 0x182086D80 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppMapMarkers previous) { }

	// RVA: 0x2086450 Offset: 0x2085850 VA: 0x182086450 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x2085F00 Offset: 0x2085300 VA: 0x182085F00
	public static AppMapMarkers Deserialize(byte[] buffer, AppMapMarkers instance, bool isDelta = False) { }

	// RVA: 0x2086000 Offset: 0x2085400 VA: 0x182086000
	public static AppMapMarkers Deserialize(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x20856E0 Offset: 0x2084AE0 VA: 0x1820856E0
	public static AppMapMarkers DeserializeLengthDelimited(Stream stream, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x2085A30 Offset: 0x2084E30 VA: 0x182085A30
	public static AppMapMarkers DeserializeLength(Stream stream, int length, AppMapMarkers instance, bool isDelta) { }

	// RVA: 0x20867D0 Offset: 0x2085BD0 VA: 0x1820867D0
	public static void SerializeDelta(Stream stream, AppMapMarkers instance, AppMapMarkers previous) { }

	// RVA: 0x2086B70 Offset: 0x2085F70 VA: 0x182086B70
	public static void Serialize(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x2086D50 Offset: 0x2086150 VA: 0x182086D50
	public byte[] ToProtoBytes() { }

	// RVA: 0x2086D60 Offset: 0x2086160 VA: 0x182086D60
	public void ToProto(Stream stream) { }

	// RVA: 0x2086A60 Offset: 0x2085E60 VA: 0x182086A60
	public static byte[] SerializeToBytes(AppMapMarkers instance) { }

	// RVA: 0x20869B0 Offset: 0x2085DB0 VA: 0x1820869B0
	public static void SerializeLengthDelimited(Stream stream, AppMapMarkers instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTeamChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6537
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong playerId; // 0x18
	public AppTeamInfo teamInfo; // 0x20

	// Methods

	// RVA: 0x1E16D50 Offset: 0x1E16150 VA: 0x181E16D50
	public static void ResetToPool(AppTeamChanged instance) { }

	// RVA: 0x1E16CA0 Offset: 0x1E160A0 VA: 0x181E16CA0
	public void ResetToPool() { }

	// RVA: 0x1E16B30 Offset: 0x1E15F30 VA: 0x181E16B30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E15EC0 Offset: 0x1E152C0 VA: 0x181E15EC0
	public void CopyTo(AppTeamChanged instance) { }

	// RVA: 0x1E15F40 Offset: 0x1E15340 VA: 0x181E15F40
	public AppTeamChanged Copy() { }

	// RVA: 0x1E16690 Offset: 0x1E15A90 VA: 0x181E16690
	public static AppTeamChanged Deserialize(Stream stream) { }

	// RVA: 0x1E16010 Offset: 0x1E15410 VA: 0x181E16010
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E16360 Offset: 0x1E15760 VA: 0x181E16360
	public static AppTeamChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E16910 Offset: 0x1E15D10 VA: 0x181E16910
	public static AppTeamChanged Deserialize(byte[] buffer) { }

	// RVA: 0x1E16C60 Offset: 0x1E16060 VA: 0x181E16C60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E17420 Offset: 0x1E16820 VA: 0x181E17420 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E17440 Offset: 0x1E16840 VA: 0x181E17440 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamChanged previous) { }

	// RVA: 0x1E16C80 Offset: 0x1E16080 VA: 0x181E16C80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E16A30 Offset: 0x1E15E30 VA: 0x181E16A30
	public static AppTeamChanged Deserialize(byte[] buffer, AppTeamChanged instance, bool isDelta = False) { }

	// RVA: 0x1E16710 Offset: 0x1E15B10 VA: 0x181E16710
	public static AppTeamChanged Deserialize(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E16090 Offset: 0x1E15490 VA: 0x181E16090
	public static AppTeamChanged DeserializeLengthDelimited(Stream stream, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E163F0 Offset: 0x1E157F0 VA: 0x181E163F0
	public static AppTeamChanged DeserializeLength(Stream stream, int length, AppTeamChanged instance, bool isDelta) { }

	// RVA: 0x1E16E00 Offset: 0x1E16200 VA: 0x181E16E00
	public static void SerializeDelta(Stream stream, AppTeamChanged instance, AppTeamChanged previous) { }

	// RVA: 0x1E17200 Offset: 0x1E16600 VA: 0x181E17200
	public static void Serialize(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x1E17410 Offset: 0x1E16810 VA: 0x181E17410
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E17420 Offset: 0x1E16820 VA: 0x181E17420
	public void ToProto(Stream stream) { }

	// RVA: 0x1E170F0 Offset: 0x1E164F0 VA: 0x181E170F0
	public static byte[] SerializeToBytes(AppTeamChanged instance) { }

	// RVA: 0x1E17040 Offset: 0x1E16440 VA: 0x181E17040
	public static void SerializeLengthDelimited(Stream stream, AppTeamChanged instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppTeamMessage : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6538
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public AppChatMessage message; // 0x18

	// Methods

	// RVA: 0x1E1C0D0 Offset: 0x1E1B4D0 VA: 0x181E1C0D0
	public static void ResetToPool(AppTeamMessage instance) { }

	// RVA: 0x1E1C030 Offset: 0x1E1B430 VA: 0x181E1C030
	public void ResetToPool() { }

	// RVA: 0x1E1BED0 Offset: 0x1E1B2D0 VA: 0x181E1BED0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1B430 Offset: 0x1E1A830 VA: 0x181E1B430
	public void CopyTo(AppTeamMessage instance) { }

	// RVA: 0x1E1B4A0 Offset: 0x1E1A8A0 VA: 0x181E1B4A0
	public AppTeamMessage Copy() { }

	// RVA: 0x1E1BE50 Offset: 0x1E1B250 VA: 0x181E1BE50
	public static AppTeamMessage Deserialize(Stream stream) { }

	// RVA: 0x1E1B570 Offset: 0x1E1A970 VA: 0x181E1B570
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E1BA40 Offset: 0x1E1AE40 VA: 0x181E1BA40
	public static AppTeamMessage DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E1BBD0 Offset: 0x1E1AFD0 VA: 0x181E1BBD0
	public static AppTeamMessage Deserialize(byte[] buffer) { }

	// RVA: 0x1E1BFF0 Offset: 0x1E1B3F0 VA: 0x181E1BFF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E1C6E0 Offset: 0x1E1BAE0 VA: 0x181E1C6E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E1C700 Offset: 0x1E1BB00 VA: 0x181E1C700 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppTeamMessage previous) { }

	// RVA: 0x1E1C010 Offset: 0x1E1B410 VA: 0x181E1C010 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E1BAD0 Offset: 0x1E1AED0 VA: 0x181E1BAD0
	public static AppTeamMessage Deserialize(byte[] buffer, AppTeamMessage instance, bool isDelta = False) { }

	// RVA: 0x1E1BCF0 Offset: 0x1E1B0F0 VA: 0x181E1BCF0
	public static AppTeamMessage Deserialize(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E1B5F0 Offset: 0x1E1A9F0 VA: 0x181E1B5F0
	public static AppTeamMessage DeserializeLengthDelimited(Stream stream, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E1B830 Offset: 0x1E1AC30 VA: 0x181E1B830
	public static AppTeamMessage DeserializeLength(Stream stream, int length, AppTeamMessage instance, bool isDelta) { }

	// RVA: 0x1E1C170 Offset: 0x1E1B570 VA: 0x181E1C170
	public static void SerializeDelta(Stream stream, AppTeamMessage instance, AppTeamMessage previous) { }

	// RVA: 0x1E1C510 Offset: 0x1E1B910 VA: 0x181E1C510
	public static void Serialize(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x1E1C6D0 Offset: 0x1E1BAD0 VA: 0x181E1C6D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E1C6E0 Offset: 0x1E1BAE0 VA: 0x181E1C6E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E1C400 Offset: 0x1E1B800 VA: 0x181E1C400
	public static byte[] SerializeToBytes(AppTeamMessage instance) { }

	// RVA: 0x1E1C350 Offset: 0x1E1B750 VA: 0x181E1C350
	public static void SerializeLengthDelimited(Stream stream, AppTeamMessage instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AppEntityChanged : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6539
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint entityId; // 0x14
	public AppEntityPayload payload; // 0x18

	// Methods

	// RVA: 0x207C570 Offset: 0x207B970 VA: 0x18207C570
	public static void ResetToPool(AppEntityChanged instance) { }

	// RVA: 0x207C4C0 Offset: 0x207B8C0 VA: 0x18207C4C0
	public void ResetToPool() { }

	// RVA: 0x207C350 Offset: 0x207B750 VA: 0x18207C350 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x207B6E0 Offset: 0x207AAE0 VA: 0x18207B6E0
	public void CopyTo(AppEntityChanged instance) { }

	// RVA: 0x207B760 Offset: 0x207AB60 VA: 0x18207B760
	public AppEntityChanged Copy() { }

	// RVA: 0x207BFB0 Offset: 0x207B3B0 VA: 0x18207BFB0
	public static AppEntityChanged Deserialize(Stream stream) { }

	// RVA: 0x207BB00 Offset: 0x207AF00 VA: 0x18207BB00
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x207BE20 Offset: 0x207B220 VA: 0x18207BE20
	public static AppEntityChanged DeserializeLength(Stream stream, int length) { }

	// RVA: 0x207C230 Offset: 0x207B630 VA: 0x18207C230
	public static AppEntityChanged Deserialize(byte[] buffer) { }

	// RVA: 0x207C480 Offset: 0x207B880 VA: 0x18207C480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x207CC30 Offset: 0x207C030 VA: 0x18207CC30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x207CC50 Offset: 0x207C050 VA: 0x18207CC50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AppEntityChanged previous) { }

	// RVA: 0x207C4A0 Offset: 0x207B8A0 VA: 0x18207C4A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x207BEB0 Offset: 0x207B2B0 VA: 0x18207BEB0
	public static AppEntityChanged Deserialize(byte[] buffer, AppEntityChanged instance, bool isDelta = False) { }

	// RVA: 0x207C030 Offset: 0x207B430 VA: 0x18207C030
	public static AppEntityChanged Deserialize(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x207B830 Offset: 0x207AC30 VA: 0x18207B830
	public static AppEntityChanged DeserializeLengthDelimited(Stream stream, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x207BB80 Offset: 0x207AF80 VA: 0x18207BB80
	public static AppEntityChanged DeserializeLength(Stream stream, int length, AppEntityChanged instance, bool isDelta) { }

	// RVA: 0x207C620 Offset: 0x207BA20 VA: 0x18207C620
	public static void SerializeDelta(Stream stream, AppEntityChanged instance, AppEntityChanged previous) { }

	// RVA: 0x207CA10 Offset: 0x207BE10 VA: 0x18207CA10
	public static void Serialize(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x207CC20 Offset: 0x207C020 VA: 0x18207CC20
	public byte[] ToProtoBytes() { }

	// RVA: 0x207CC30 Offset: 0x207C030 VA: 0x18207CC30
	public void ToProto(Stream stream) { }

	// RVA: 0x207C900 Offset: 0x207BD00 VA: 0x18207C900
	public static byte[] SerializeToBytes(AppEntityChanged instance) { }

	// RVA: 0x207C850 Offset: 0x207BC50 VA: 0x18207C850
	public static void SerializeLengthDelimited(Stream stream, AppEntityChanged instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public enum AppEntityType // TypeDefIndex: 6557
{	// Fields
	public int value__; // 0x0
	public const AppEntityType Switch = 1;
	public const AppEntityType Alarm = 2;
	public const AppEntityType StorageMonitor = 3;

}

public enum AppMarkerType // TypeDefIndex: 6558
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public static bool isQuitting; // 0x0
	public static bool isLoading; // 0x1
	public static bool isReceiving; // 0x2
	public static bool isLoadingSave; // 0x3
	public static bool isLoadingPrefabs; // 0x4

	// Properties
	public static string installPath { get; }
	public static string dataPath { get; }

	// Methods

	// RVA: 0x1B98370 Offset: 0x1B97770 VA: 0x181B98370
	public static void Quit() { }

	// RVA: 0x1B983E0 Offset: 0x1B977E0 VA: 0x181B983E0
	public static string get_installPath() { }

	// RVA: 0x1B983D0 Offset: 0x1B977D0 VA: 0x181B983D0
	public static string get_dataPath() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public enum AppCategory // TypeDefIndex: 7672
{	// Fields
	public int value__; // 0x0
	public const AppCategory Invalid = 0;
	public const AppCategory Utility = 1;
	public const AppCategory Game = 2;

}

public static class Approved // TypeDefIndex: 7722
{	// Fields
	private static Dictionary<ulong, ApprovedSkinInfo> _all; // 0x18DC

	// Properties
	public static IReadOnlyDictionary<ulong, ApprovedSkinInfo> All { get; }

	// Methods

	// RVA: 0x374A10 Offset: 0x373E10 VA: 0x180374A10
	private static void Add_2016() { }

	// RVA: 0x39A850 Offset: 0x399C50 VA: 0x18039A850
	private static void Add_December_29_2016() { }

	// RVA: 0x397BF0 Offset: 0x396FF0 VA: 0x180397BF0
	private static void Add_December_22_2016() { }

	// RVA: 0x3932B0 Offset: 0x3926B0 VA: 0x1803932B0
	private static void Add_December_15_2016() { }

	// RVA: 0x39E2F0 Offset: 0x39D6F0 VA: 0x18039E2F0
	private static void Add_December_8_2016() { }

	// RVA: 0x39B780 Offset: 0x39AB80 VA: 0x18039B780
	private static void Add_December_2_2018() { }

	// RVA: 0x3956D0 Offset: 0x394AD0 VA: 0x1803956D0
	private static void Add_December_1_2016() { }

	// RVA: 0x3FD600 Offset: 0x3FCA00 VA: 0x1803FD600
	private static void Add_November_24_2016() { }

	// RVA: 0x3FA430 Offset: 0x3F9830 VA: 0x1803FA430
	private static void Add_November_17_2016() { }

	// RVA: 0x3F8DE0 Offset: 0x3F81E0 VA: 0x1803F8DE0
	private static void Add_November_16_2016() { }

	// RVA: 0x3F6930 Offset: 0x3F5D30 VA: 0x1803F6930
	private static void Add_November_10_2016() { }

	// RVA: 0x401660 Offset: 0x400A60 VA: 0x180401660
	private static void Add_November_3_2016() { }

	// RVA: 0x374A70 Offset: 0x373E70 VA: 0x180374A70
	private static void Add_2017() { }

	// RVA: 0x399DE0 Offset: 0x3991E0 VA: 0x180399DE0
	private static void Add_December_28_2017() { }

	// RVA: 0x3974A0 Offset: 0x3968A0 VA: 0x1803974A0
	private static void Add_December_21_2017() { }

	// RVA: 0x392C30 Offset: 0x392030 VA: 0x180392C30
	private static void Add_December_14_2017() { }

	// RVA: 0x39D880 Offset: 0x39CC80 VA: 0x18039D880
	private static void Add_December_7_2017() { }

	// RVA: 0x400C90 Offset: 0x400090 VA: 0x180400C90
	private static void Add_November_30_2017() { }

	// RVA: 0x3FCDF0 Offset: 0x3FC1F0 VA: 0x1803FCDF0
	private static void Add_November_23_2017() { }

	// RVA: 0x3F99C0 Offset: 0x3F8DC0 VA: 0x1803F99C0
	private static void Add_November_16_2017() { }

	// RVA: 0x402CC0 Offset: 0x4020C0 VA: 0x180402CC0
	private static void Add_November_9_2017() { }

	// RVA: 0x400150 Offset: 0x3FF550 VA: 0x180400150
	private static void Add_November_2_2017() { }

	// RVA: 0x40A640 Offset: 0x409A40 VA: 0x18040A640
	private static void Add_October_26_2017() { }

	// RVA: 0x4073E0 Offset: 0x4067E0 VA: 0x1804073E0
	private static void Add_October_19_2017() { }

	// RVA: 0x4052C0 Offset: 0x4046C0 VA: 0x1804052C0
	private static void Add_October_12_2017() { }

	// RVA: 0x40E180 Offset: 0x40D580 VA: 0x18040E180
	private static void Add_October_5_2017() { }

	// RVA: 0x417360 Offset: 0x416760 VA: 0x180417360
	private static void Add_September_28_2017() { }

	// RVA: 0x414CA0 Offset: 0x4140A0 VA: 0x180414CA0
	private static void Add_September_21_2017() { }

	// RVA: 0x411E80 Offset: 0x411280 VA: 0x180411E80
	private static void Add_September_14_2017() { }

	// RVA: 0x4196C0 Offset: 0x418AC0 VA: 0x1804196C0
	private static void Add_September_7_2017() { }

	// RVA: 0x38D600 Offset: 0x38CA00 VA: 0x18038D600
	private static void Add_August_31_2017() { }

	// RVA: 0x38ABF0 Offset: 0x389FF0 VA: 0x18038ABF0
	private static void Add_August_24_2017() { }

	// RVA: 0x387D00 Offset: 0x387100 VA: 0x180387D00
	private static void Add_August_17_2017() { }

	// RVA: 0x384E00 Offset: 0x384200 VA: 0x180384E00
	private static void Add_August_10_2017() { }

	// RVA: 0x38E3A0 Offset: 0x38D7A0 VA: 0x18038E3A0
	private static void Add_August_3_2017() { }

	// RVA: 0x3C5710 Offset: 0x3C4B10 VA: 0x1803C5710
	private static void Add_July_27_2017() { }

	// RVA: 0x3C2550 Offset: 0x3C1950 VA: 0x1803C2550
	private static void Add_July_20_2017() { }

	// RVA: 0x3BE370 Offset: 0x3BD770 VA: 0x1803BE370
	private static void Add_July_13_2017() { }

	// RVA: 0x3C9290 Offset: 0x3C8690 VA: 0x1803C9290
	private static void Add_July_6_2017() { }

	// RVA: 0x3D48D0 Offset: 0x3D3CD0 VA: 0x1803D48D0
	private static void Add_June_29_2017() { }

	// RVA: 0x3CE360 Offset: 0x3CD760 VA: 0x1803CE360
	private static void Add_June_15_2017() { }

	// RVA: 0x3D7820 Offset: 0x3D6C20 VA: 0x1803D7820
	private static void Add_June_8_2017() { }

	// RVA: 0x3D07E0 Offset: 0x3CFBE0 VA: 0x1803D07E0
	private static void Add_June_1_2017() { }

	// RVA: 0x3F0250 Offset: 0x3EF650 VA: 0x1803F0250
	private static void Add_May_25_2017() { }

	// RVA: 0x3ECB40 Offset: 0x3EBF40 VA: 0x1803ECB40
	private static void Add_May_18_2017() { }

	// RVA: 0x3EA4A0 Offset: 0x3E98A0 VA: 0x1803EA4A0
	private static void Add_May_11_2017() { }

	// RVA: 0x3F4420 Offset: 0x3F3820 VA: 0x1803F4420
	private static void Add_May_4_2017() { }

	// RVA: 0x37E990 Offset: 0x37DD90 VA: 0x18037E990
	private static void Add_April_27_2017() { }

	// RVA: 0x37B810 Offset: 0x37AC10 VA: 0x18037B810
	private static void Add_April_20_2017() { }

	// RVA: 0x377B20 Offset: 0x376F20 VA: 0x180377B20
	private static void Add_April_13_2017() { }

	// RVA: 0x382500 Offset: 0x381900 VA: 0x180382500
	private static void Add_April_6_2017() { }

	// RVA: 0x3E4980 Offset: 0x3E3D80 VA: 0x1803E4980
	private static void Add_March_30_2017() { }

	// RVA: 0x3E05D0 Offset: 0x3DF9D0 VA: 0x1803E05D0
	private static void Add_March_23_2017() { }

	// RVA: 0x3DB770 Offset: 0x3DAB70 VA: 0x1803DB770
	private static void Add_March_15_2017() { }

	// RVA: 0x3E7080 Offset: 0x3E6480 VA: 0x1803E7080
	private static void Add_March_8_2017() { }

	// RVA: 0x3E38C0 Offset: 0x3E2CC0 VA: 0x1803E38C0
	private static void Add_March_2_2017() { }

	// RVA: 0x3A7DA0 Offset: 0x3A71A0 VA: 0x1803A7DA0
	private static void Add_February_23_2017() { }

	// RVA: 0x3A4470 Offset: 0x3A3870 VA: 0x1803A4470
	private static void Add_February_16_2017() { }

	// RVA: 0x3ACC00 Offset: 0x3AC000 VA: 0x1803ACC00
	private static void Add_February_9_2017() { }

	// RVA: 0x3AA460 Offset: 0x3A9860 VA: 0x1803AA460
	private static void Add_February_2_2017() { }

	// RVA: 0x3B4410 Offset: 0x3B3810 VA: 0x1803B4410
	private static void Add_January_18_2017() { }

	// RVA: 0x3B1390 Offset: 0x3B0790 VA: 0x1803B1390
	private static void Add_January_12_2017() { }

	// RVA: 0x3BA190 Offset: 0x3B9590 VA: 0x1803BA190
	private static void Add_January_4_2017() { }

	// RVA: 0x374BE0 Offset: 0x373FE0 VA: 0x180374BE0
	private static void Add_2018() { }

	// RVA: 0x3969E0 Offset: 0x395DE0 VA: 0x1803969E0
	private static void Add_December_20_2018() { }

	// RVA: 0x3924B0 Offset: 0x3918B0 VA: 0x1803924B0
	private static void Add_December_13_2020() { }

	// RVA: 0x39D1F0 Offset: 0x39C5F0 VA: 0x18039D1F0
	private static void Add_December_6_2018() { }

	// RVA: 0x3FFAC0 Offset: 0x3FEEC0 VA: 0x1803FFAC0
	private static void Add_November_29_2018() { }

	// RVA: 0x3FC760 Offset: 0x3FBB60 VA: 0x1803FC760
	private static void Add_November_22_2018() { }

	// RVA: 0x3F8730 Offset: 0x3F7B30 VA: 0x1803F8730
	private static void Add_November_15_2018() { }

	// RVA: 0x403730 Offset: 0x402B30 VA: 0x180403730
	private static void Add_November_9_2018() { }

	// RVA: 0x3FBA40 Offset: 0x3FAE40 VA: 0x1803FBA40
	private static void Add_November_1_2018() { }

	// RVA: 0x40B240 Offset: 0x40A640 VA: 0x18040B240
	private static void Add_October_26_2018() { }

	// RVA: 0x407FE0 Offset: 0x4073E0 VA: 0x180407FE0
	private static void Add_October_19_2018() { }

	// RVA: 0x404580 Offset: 0x403980 VA: 0x180404580
	private static void Add_October_11_2018() { }

	// RVA: 0x40D940 Offset: 0x40CD40 VA: 0x18040D940
	private static void Add_October_4_2018() { }

	// RVA: 0x416CC0 Offset: 0x4160C0 VA: 0x180416CC0
	private static void Add_September_27_2018() { }

	// RVA: 0x414600 Offset: 0x413A00 VA: 0x180414600
	private static void Add_September_20_2018() { }

	// RVA: 0x412830 Offset: 0x411C30 VA: 0x180412830
	private static void Add_September_14_2018() { }

	// RVA: 0x418CB0 Offset: 0x4180B0 VA: 0x180418CB0
	private static void Add_September_5_2018() { }

	// RVA: 0x38A560 Offset: 0x389960 VA: 0x18038A560
	private static void Add_August_23_2018() { }

	// RVA: 0x3874D0 Offset: 0x3868D0 VA: 0x1803874D0
	private static void Add_August_16_2018() { }

	// RVA: 0x38EFA0 Offset: 0x38E3A0 VA: 0x18038EFA0
	private static void Add_August_9_2018() { }

	// RVA: 0x38CC30 Offset: 0x38C030 VA: 0x18038CC30
	private static void Add_August_2_2018() { }

	// RVA: 0x3C4600 Offset: 0x3C3A00 VA: 0x1803C4600
	private static void Add_July_26_2018() { }

	// RVA: 0x3C14E0 Offset: 0x3C08E0 VA: 0x1803C14E0
	private static void Add_July_19_2018() { }

	// RVA: 0x3BD240 Offset: 0x3BC640 VA: 0x1803BD240
	private static void Add_July_12_2018() { }

	// RVA: 0x3C8240 Offset: 0x3C7640 VA: 0x1803C8240
	private static void Add_July_5_2018() { }

	// RVA: 0x3D3A10 Offset: 0x3D2E10 VA: 0x1803D3A10
	private static void Add_June_28_2018() { }

	// RVA: 0x3D1C20 Offset: 0x3D1020 VA: 0x1803D1C20
	private static void Add_June_22_2018() { }

	// RVA: 0x3CD060 Offset: 0x3CC460 VA: 0x1803CD060
	private static void Add_June_14_2018() { }

	// RVA: 0x3D6D90 Offset: 0x3D6190 VA: 0x1803D6D90
	private static void Add_June_7_2018() { }

	// RVA: 0x3F3980 Offset: 0x3F2D80 VA: 0x1803F3980
	private static void Add_May_31_2018() { }

	// RVA: 0x3EF200 Offset: 0x3EE600 VA: 0x1803EF200
	private static void Add_May_24_2018() { }

	// RVA: 0x3F2280 Offset: 0x3F1680 VA: 0x1803F2280
	private static void Add_May_2_2018() { }

	// RVA: 0x37DDF0 Offset: 0x37D1F0 VA: 0x18037DDF0
	private static void Add_April_26_2018() { }

	// RVA: 0x37A630 Offset: 0x379A30 VA: 0x18037A630
	private static void Add_April_19_2018() { }

	// RVA: 0x376F00 Offset: 0x376300 VA: 0x180376F00
	private static void Add_April_12_2018() { }

	// RVA: 0x3812E0 Offset: 0x3806E0 VA: 0x1803812E0
	private static void Add_April_5_2018() { }

	// RVA: 0x3E2EF0 Offset: 0x3E22F0 VA: 0x1803E2EF0
	private static void Add_March_29_2018() { }

	// RVA: 0x3DF540 Offset: 0x3DE940 VA: 0x1803DF540
	private static void Add_March_22_2018() { }

	// RVA: 0x3DC510 Offset: 0x3DB910 VA: 0x1803DC510
	private static void Add_March_15_2018() { }

	// RVA: 0x3E7A30 Offset: 0x3E6E30 VA: 0x1803E7A30
	private static void Add_March_8_2018() { }

	// RVA: 0x3DE420 Offset: 0x3DD820 VA: 0x1803DE420
	private static void Add_March_1_2018() { }

	// RVA: 0x3A71E0 Offset: 0x3A65E0 VA: 0x1803A71E0
	private static void Add_February_22_2018() { }

	// RVA: 0x3A3AC0 Offset: 0x3A2EC0 VA: 0x1803A3AC0
	private static void Add_February_15_2018() { }

	// RVA: 0x3ABBE0 Offset: 0x3AAFE0 VA: 0x1803ABBE0
	private static void Add_February_8_2018() { }

	// RVA: 0x3A60D0 Offset: 0x3A54D0 VA: 0x1803A60D0
	private static void Add_February_1_2018() { }

	// RVA: 0x3B6BB0 Offset: 0x3B5FB0 VA: 0x1803B6BB0
	private static void Add_January_25_2018() { }

	// RVA: 0x3B4DC0 Offset: 0x3B41C0 VA: 0x1803B4DC0
	private static void Add_January_18_2018() { }

	// RVA: 0x3B09D0 Offset: 0x3AFDD0 VA: 0x1803B09D0
	private static void Add_January_11_2018() { }

	// RVA: 0x3BA9A0 Offset: 0x3B9DA0 VA: 0x1803BA9A0
	private static void Add_January_4_2018() { }

	// RVA: 0x374D40 Offset: 0x374140 VA: 0x180374D40
	private static void Add_2019() { }

	// RVA: 0x399730 Offset: 0x398B30 VA: 0x180399730
	private static void Add_December_27_2019() { }

	// RVA: 0x394D10 Offset: 0x394110 VA: 0x180394D10
	private static void Add_December_19_2019() { }

	// RVA: 0x391E10 Offset: 0x391210 VA: 0x180391E10
	private static void Add_December_12_2019() { }

	// RVA: 0x39CB60 Offset: 0x39BF60 VA: 0x18039CB60
	private static void Add_December_5_2019() { }

	// RVA: 0x3FF100 Offset: 0x3FE500 VA: 0x1803FF100
	private static void Add_November_28_2019() { }

	// RVA: 0x3FC0D0 Offset: 0x3FB4D0 VA: 0x1803FC0D0
	private static void Add_November_21_2019() { }

	// RVA: 0x3F8060 Offset: 0x3F7460 VA: 0x1803F8060
	private static void Add_November_14_2019() { }

	// RVA: 0x402490 Offset: 0x401890 VA: 0x180402490
	private static void Add_November_7_2019() { }

	// RVA: 0x40CB40 Offset: 0x40BF40 VA: 0x18040CB40
	private static void Add_October_31_2019() { }

	// RVA: 0x409C30 Offset: 0x409030 VA: 0x180409C30
	private static void Add_October_24_2019() { }

	// RVA: 0x406B80 Offset: 0x405F80 VA: 0x180406B80
	private static void Add_October_18_2019() { }

	// RVA: 0x404C20 Offset: 0x404020 VA: 0x180404C20
	private static void Add_October_11_2019() { }

	// RVA: 0x40D2A0 Offset: 0x40C6A0 VA: 0x18040D2A0
	private static void Add_October_3_2019() { }

	// RVA: 0x416610 Offset: 0x415A10 VA: 0x180416610
	private static void Add_September_26_2019() { }

	// RVA: 0x413D20 Offset: 0x413120 VA: 0x180413D20
	private static void Add_September_19_2019() { }

	// RVA: 0x4117F0 Offset: 0x410BF0 VA: 0x1804117F0
	private static void Add_September_12_2019() { }

	// RVA: 0x41A200 Offset: 0x419600 VA: 0x18041A200
	private static void Add_September_9_2019() { }

	// RVA: 0x38C580 Offset: 0x38B980 VA: 0x18038C580
	private static void Add_August_29_2019() { }

	// RVA: 0x389E10 Offset: 0x389210 VA: 0x180389E10
	private static void Add_August_22_2019() { }

	// RVA: 0x386B00 Offset: 0x385F00 VA: 0x180386B00
	private static void Add_August_15_2019() { }

	// RVA: 0x38F980 Offset: 0x38ED80 VA: 0x18038F980
	private static void Add_August_9_2019() { }

	// RVA: 0x3890F0 Offset: 0x3884F0 VA: 0x1803890F0
	private static void Add_August_1_2019() { }

	// RVA: 0x3C5080 Offset: 0x3C4480 VA: 0x1803C5080
	private static void Add_July_26_2019() { }

	// RVA: 0x3C1EB0 Offset: 0x3C12B0 VA: 0x1803C1EB0
	private static void Add_July_19_2019() { }

	// RVA: 0x3BDC10 Offset: 0x3BD010 VA: 0x1803BDC10
	private static void Add_July_12_2019() { }

	// RVA: 0x3C8C00 Offset: 0x3C8000 VA: 0x1803C8C00
	private static void Add_July_5_2019() { }

	// RVA: 0x3D4230 Offset: 0x3D3630 VA: 0x1803D4230
	private static void Add_June_28_2019() { }

	// RVA: 0x3D1580 Offset: 0x3D0980 VA: 0x1803D1580
	private static void Add_June_21_2019() { }

	// RVA: 0x3CDA50 Offset: 0x3CCE50 VA: 0x1803CDA50
	private static void Add_June_14_2019() { }

	// RVA: 0x3D6710 Offset: 0x3D5B10 VA: 0x1803D6710
	private static void Add_June_6_2019() { }

	// RVA: 0x3F32F0 Offset: 0x3F26F0 VA: 0x1803F32F0
	private static void Add_May_30_2019() { }

	// RVA: 0x3EEB40 Offset: 0x3EDF40 VA: 0x1803EEB40
	private static void Add_May_23_2019() { }

	// RVA: 0x3EC4C0 Offset: 0x3EB8C0 VA: 0x1803EC4C0
	private static void Add_May_16_2019() { }

	// RVA: 0x3F5520 Offset: 0x3F4920 VA: 0x1803F5520
	private static void Add_May_9_2019() { }

	// RVA: 0x3F2C50 Offset: 0x3F2050 VA: 0x1803F2C50
	private static void Add_May_2_2019() { }

	// RVA: 0x37D760 Offset: 0x37CB60 VA: 0x18037D760
	private static void Add_April_25_2019() { }

	// RVA: 0x37B000 Offset: 0x37A400 VA: 0x18037B000
	private static void Add_April_19_2019() { }

	// RVA: 0x376860 Offset: 0x375C60 VA: 0x180376860
	private static void Add_April_11_2019() { }

	// RVA: 0x381E40 Offset: 0x381240 VA: 0x180381E40
	private static void Add_April_5_2019() { }

	// RVA: 0x3E21C0 Offset: 0x3E15C0 VA: 0x1803E21C0
	private static void Add_March_28_2019() { }

	// RVA: 0x3DFF20 Offset: 0x3DF320 VA: 0x1803DFF20
	private static void Add_March_22_2019() { }

	// RVA: 0x3DB0F0 Offset: 0x3DA4F0 VA: 0x1803DB0F0
	private static void Add_March_14_2019() { }

	// RVA: 0x3E69E0 Offset: 0x3E5DE0 VA: 0x1803E69E0
	private static void Add_March_7_2019() { }

	// RVA: 0x3A9DD0 Offset: 0x3A91D0 VA: 0x1803A9DD0
	private static void Add_February_28_2019() { }

	// RVA: 0x3A7700 Offset: 0x3A6B00 VA: 0x1803A7700
	private static void Add_February_22_2019() { }

	// RVA: 0x3A3430 Offset: 0x3A2830 VA: 0x1803A3430
	private static void Add_February_14_2019() { }

	// RVA: 0x3AB7B0 Offset: 0x3AABB0 VA: 0x1803AB7B0
	private static void Add_February_7_2019() { }

	// RVA: 0x3B8A80 Offset: 0x3B7E80 VA: 0x1803B8A80
	private static void Add_January_31_2019() { }

	// RVA: 0x3B64F0 Offset: 0x3B58F0 VA: 0x1803B64F0
	private static void Add_January_24_2019() { }

	// RVA: 0x3B3700 Offset: 0x3B2B00 VA: 0x1803B3700
	private static void Add_January_17_2019() { }

	// RVA: 0x3AFCA0 Offset: 0x3AF0A0 VA: 0x1803AFCA0
	private static void Add_January_10_2019() { }

	// RVA: 0x3B97C0 Offset: 0x3B8BC0 VA: 0x1803B97C0
	private static void Add_January_3_2019() { }

	// RVA: 0x374EC0 Offset: 0x3742C0 VA: 0x180374EC0
	private static void Add_2020() { }

	// RVA: 0x39C490 Offset: 0x39B890 VA: 0x18039C490
	private static void Add_December_31_2020() { }

	// RVA: 0x399130 Offset: 0x398530 VA: 0x180399130
	private static void Add_December_24_2020() { }

	// RVA: 0x3944A0 Offset: 0x3938A0 VA: 0x1803944A0
	private static void Add_December_18_2020() { }

	// RVA: 0x391780 Offset: 0x390B80 VA: 0x180391780
	private static void Add_December_10_2020() { }

	// RVA: 0x390890 Offset: 0x38FC90 VA: 0x180390890
	private static void Add_December_03_2020() { }

	// RVA: 0x3FEA70 Offset: 0x3FDE70 VA: 0x1803FEA70
	private static void Add_November_26_2020() { }

	// RVA: 0x3FAB60 Offset: 0x3F9F60 VA: 0x1803FAB60
	private static void Add_November_19_2020() { }

	// RVA: 0x3F79A0 Offset: 0x3F6DA0 VA: 0x1803F79A0
	private static void Add_November_12_2020() { }

	// RVA: 0x3F62A0 Offset: 0x3F56A0 VA: 0x1803F62A0
	private static void Add_November_05_2020() { }

	// RVA: 0x40C210 Offset: 0x40B610 VA: 0x18040C210
	private static void Add_October_29_2020() { }

	// RVA: 0x409580 Offset: 0x408980 VA: 0x180409580
	private static void Add_October_22_2020() { }

	// RVA: 0x4064C0 Offset: 0x4058C0 VA: 0x1804064C0
	private static void Add_October_16_2020() { }

	// RVA: 0x40EF20 Offset: 0x40E320 VA: 0x18040EF20
	private static void Add_October_8_2020() { }

	// RVA: 0x408810 Offset: 0x407C10 VA: 0x180408810
	private static void Add_October_1_2020() { }

	// RVA: 0x415F80 Offset: 0x415380 VA: 0x180415F80
	private static void Add_September_24_2020() { }

	// RVA: 0x413660 Offset: 0x412A60 VA: 0x180413660
	private static void Add_September_17_2020() { }

	// RVA: 0x410FA0 Offset: 0x4103A0 VA: 0x180410FA0
	private static void Add_September_10_2020() { }

	// RVA: 0x418630 Offset: 0x417A30 VA: 0x180418630
	private static void Add_September_3_2020() { }

	// RVA: 0x38BED0 Offset: 0x38B2D0 VA: 0x18038BED0
	private static void Add_August_27_2020() { }

	// RVA: 0x389770 Offset: 0x388B70 VA: 0x180389770
	private static void Add_August_21_2020() { }

	// RVA: 0x386400 Offset: 0x385800 VA: 0x180386400
	private static void Add_August_13_2020() { }

	// RVA: 0x384620 Offset: 0x383A20 VA: 0x180384620
	private static void Add_August_06_2020() { }

	// RVA: 0x3C7A60 Offset: 0x3C6E60 VA: 0x1803C7A60
	private static void Add_July_31_2020() { }

	// RVA: 0x3C3F00 Offset: 0x3C3300 VA: 0x1803C3F00
	private static void Add_July_24_2020() { }

	// RVA: 0x3C0DE0 Offset: 0x3C01E0 VA: 0x1803C0DE0
	private static void Add_July_17_2020() { }

	// RVA: 0x3CA350 Offset: 0x3C9750 VA: 0x1803CA350
	private static void Add_July_9_2020() { }

	// RVA: 0x3C6FF0 Offset: 0x3C63F0 VA: 0x1803C6FF0
	private static void Add_July_2_2020() { }

	// RVA: 0x3D3360 Offset: 0x3D2760 VA: 0x1803D3360
	private static void Add_June_26_2020() { }

	// RVA: 0x3CFF90 Offset: 0x3CF390 VA: 0x1803CFF90
	private static void Add_June_19_2020() { }

	// RVA: 0x3CC9A0 Offset: 0x3CBDA0 VA: 0x1803CC9A0
	private static void Add_June_11_2020() { }

	// RVA: 0x3D6080 Offset: 0x3D5480 VA: 0x1803D6080
	private static void Add_June_4_2020() { }

	// RVA: 0x3F1BE0 Offset: 0x3F0FE0 VA: 0x1803F1BE0
	private static void Add_May_28_2020() { }

	// RVA: 0x3EE4B0 Offset: 0x3ED8B0 VA: 0x1803EE4B0
	private static void Add_May_21_2020() { }

	// RVA: 0x3EBE10 Offset: 0x3EB210 VA: 0x1803EBE10
	private static void Add_May_14_2020() { }

	// RVA: 0x3F4E90 Offset: 0x3F4290 VA: 0x1803F4E90
	private static void Add_May_8_2020() { }

	// RVA: 0x380C60 Offset: 0x380060 VA: 0x180380C60
	private static void Add_April_30_2020() { }

	// RVA: 0x37D0B0 Offset: 0x37C4B0 VA: 0x18037D0B0
	private static void Add_April_24_2020() { }

	// RVA: 0x379F90 Offset: 0x379390 VA: 0x180379F90
	private static void Add_April_16_2020() { }

	// RVA: 0x382EC0 Offset: 0x3822C0 VA: 0x180382EC0
	private static void Add_April_9_2020() { }

	// RVA: 0x3805E0 Offset: 0x37F9E0 VA: 0x1803805E0
	private static void Add_April_2_2020() { }

	// RVA: 0x3E2850 Offset: 0x3E1C50 VA: 0x1803E2850
	private static void Add_March_28_2020() { }

	// RVA: 0x3DEEB0 Offset: 0x3DE2B0 VA: 0x1803DEEB0
	private static void Add_March_20_2020() { }

	// RVA: 0x3DAA50 Offset: 0x3D9E50 VA: 0x1803DAA50
	private static void Add_March_13_2020() { }

	// RVA: 0x3E6350 Offset: 0x3E5750 VA: 0x1803E6350
	private static void Add_March_5_2020() { }

	// RVA: 0x3A9740 Offset: 0x3A8B40 VA: 0x1803A9740
	private static void Add_February_27_2020() { }

	// RVA: 0x3A6A80 Offset: 0x3A5E80 VA: 0x1803A6A80
	private static void Add_February_21_2020() { }

	// RVA: 0x3A29C0 Offset: 0x3A1DC0 VA: 0x1803A29C0
	private static void Add_February_13_2020() { }

	// RVA: 0x3AB130 Offset: 0x3AA530 VA: 0x1803AB130
	private static void Add_February_6_2020() { }

	// RVA: 0x3B9110 Offset: 0x3B8510 VA: 0x1803B9110
	private static void Add_January_31_2020() { }

	// RVA: 0x3B3D90 Offset: 0x3B3190 VA: 0x1803B3D90
	private static void Add_January_17_2020() { }

	// RVA: 0x3B0340 Offset: 0x3AF740 VA: 0x1803B0340
	private static void Add_January_10_2020() { }

	// RVA: 0x3B83F0 Offset: 0x3B77F0 VA: 0x1803B83F0
	private static void Add_January_2_2020() { }

	// RVA: 0x375040 Offset: 0x374440 VA: 0x180375040
	private static void Add_2021() { }

	// RVA: 0x39BCD0 Offset: 0x39B0D0 VA: 0x18039BCD0
	private static void Add_December_30_2021() { }

	// RVA: 0x3989A0 Offset: 0x397DA0 VA: 0x1803989A0
	private static void Add_December_23_2021() { }

	// RVA: 0x393C60 Offset: 0x393060 VA: 0x180393C60
	private static void Add_December_16_2021() { }

	// RVA: 0x390F30 Offset: 0x390330 VA: 0x180390F30
	private static void Add_December_09_2021() { }

	// RVA: 0x3901B0 Offset: 0x38F5B0 VA: 0x1803901B0
	private static void Add_December_02_2021() { }

	// RVA: 0x3FE380 Offset: 0x3FD780 VA: 0x1803FE380
	private static void Add_November_25_2021() { }

	// RVA: 0x3FB5D0 Offset: 0x3FA9D0 VA: 0x1803FB5D0
	private static void Add_November_19_2021_TWITCHDROPS() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void Add_November_18_2021() { }

	// RVA: 0x3FB240 Offset: 0x3FA640 VA: 0x1803FB240
	private static void Add_November_19_2021_CHARITABLE_RUST() { }

	// RVA: 0x3F71F0 Offset: 0x3F65F0 VA: 0x1803F71F0
	private static void Add_November_11_2021() { }

	// RVA: 0x3F5BD0 Offset: 0x3F4FD0 VA: 0x1803F5BD0
	private static void Add_November_04_2021() { }

	// RVA: 0x40BA80 Offset: 0x40AE80 VA: 0x18040BA80
	private static void Add_October_27_2021() { }

	// RVA: 0x408DF0 Offset: 0x4081F0 VA: 0x180408DF0
	private static void Add_October_21_2021() { }

	// RVA: 0x405E00 Offset: 0x405200 VA: 0x180405E00
	private static void Add_October_14_2021() { }

	// RVA: 0x403E90 Offset: 0x403290 VA: 0x180403E90
	private static void Add_October_07_2021() { }

	// RVA: 0x417F60 Offset: 0x417360 VA: 0x180417F60
	private static void Add_September_30_2021() { }

	// RVA: 0x415710 Offset: 0x414B10 VA: 0x180415710
	private static void Add_September_23_2021() { }

	// RVA: 0x412EC0 Offset: 0x4122C0 VA: 0x180412EC0
	private static void Add_September_16_2021() { }

	// RVA: 0x410710 Offset: 0x40FB10 VA: 0x180410710
	private static void Add_September_09_2021() { }

	// RVA: 0x40FF60 Offset: 0x40F360 VA: 0x18040FF60
	private static void Add_September_02_2021() { }

	// RVA: 0x40F6B0 Offset: 0x40EAB0 VA: 0x18040F6B0
	private static void Add_September_01_2021_STREAMERSKINS() { }

	// RVA: 0x38B7F0 Offset: 0x38ABF0 VA: 0x18038B7F0
	private static void Add_August_26_2021() { }

	// RVA: 0x3886B0 Offset: 0x387AB0 VA: 0x1803886B0
	private static void Add_August_19_2021() { }

	// RVA: 0x385D30 Offset: 0x385130 VA: 0x180385D30
	private static void Add_August_12_2021() { }

	// RVA: 0x3833B0 Offset: 0x3827B0 VA: 0x1803833B0
	private static void Add_August_04_2021() { }

	// RVA: 0x3C6920 Offset: 0x3C5D20 VA: 0x1803C6920
	private static void Add_July_29_2021() { }

	// RVA: 0x3C3820 Offset: 0x3C2C20 VA: 0x1803C3820
	private static void Add_July_22_2021() { }

	// RVA: 0x3BF960 Offset: 0x3BED60 VA: 0x1803BF960
	private static void Add_July_15_2021_STREAMERSKINS() { }

	// RVA: 0x3C0570 Offset: 0x3BF970 VA: 0x1803C0570
	private static void Add_July_15_2021() { }

	// RVA: 0x3BCB60 Offset: 0x3BBF60 VA: 0x1803BCB60
	private static void Add_July_08_2021() { }

	// RVA: 0x3BBA10 Offset: 0x3BAE10 VA: 0x1803BBA10
	private static void Add_July_05_2021_STREAMERSKINS() { }

	// RVA: 0x3BB350 Offset: 0x3BA750 VA: 0x1803BB350
	private static void Add_July_01_2021() { }

	// RVA: 0x3D2C90 Offset: 0x3D2090 VA: 0x1803D2C90
	private static void Add_June_24_2021() { }

	// RVA: 0x3CF720 Offset: 0x3CEB20 VA: 0x1803CF720
	private static void Add_June_17_2021() { }

	// RVA: 0x3CC2C0 Offset: 0x3CB6C0 VA: 0x1803CC2C0
	private static void Add_June_10_2021() { }

	// RVA: 0x3CB540 Offset: 0x3CA940 VA: 0x1803CB540
	private static void Add_June_03_2021() { }

	// RVA: 0x3F1460 Offset: 0x3F0860 VA: 0x1803F1460
	private static void Add_May_27_2021() { }

	// RVA: 0x3EDD40 Offset: 0x3ED140 VA: 0x1803EDD40
	private static void Add_May_20_2021() { }

	// RVA: 0x3EB660 Offset: 0x3EAA60 VA: 0x1803EB660
	private static void Add_May_13_2021() { }

	// RVA: 0x3E9DC0 Offset: 0x3E91C0 VA: 0x1803E9DC0
	private static void Add_May_06_2021() { }

	// RVA: 0x3E8D50 Offset: 0x3E8150 VA: 0x1803E8D50
	private static void Add_May_05_2021_STREAMERSKINS() { }

	// RVA: 0x37FD40 Offset: 0x37F140 VA: 0x18037FD40
	private static void Add_April_29_2021() { }

	// RVA: 0x37C9E0 Offset: 0x37BDE0 VA: 0x18037C9E0
	private static void Add_April_22_2021() { }

	// RVA: 0x3798C0 Offset: 0x378CC0 VA: 0x1803798C0
	private static void Add_April_15_2021() { }

	// RVA: 0x376190 Offset: 0x375590 VA: 0x180376190
	private static void Add_April_09_2021() { }

	// RVA: 0x375320 Offset: 0x374720 VA: 0x180375320
	private static void Add_April_01_2021() { }

	// RVA: 0x3E53F0 Offset: 0x3E47F0 VA: 0x1803E53F0
	private static void Add_March_31_2021_STREAMERSKINS() { }

	// RVA: 0x3E1AF0 Offset: 0x3E0EF0 VA: 0x1803E1AF0
	private static void Add_March_25_2021() { }

	// RVA: 0x3DDD50 Offset: 0x3DD150 VA: 0x1803DDD50
	private static void Add_March_18_2021() { }

	// RVA: 0x3DA380 Offset: 0x3D9780 VA: 0x1803DA380
	private static void Add_March_11_2021() { }

	// RVA: 0x3D9620 Offset: 0x3D8A20 VA: 0x1803D9620
	private static void Add_March_04_2021() { }

	// RVA: 0x3D84F0 Offset: 0x3D78F0 VA: 0x1803D84F0
	private static void Add_March_03_2021_STREAMERSKINS() { }

	// RVA: 0x3A9070 Offset: 0x3A8470 VA: 0x1803A9070
	private static void Add_February_25_2021() { }

	// RVA: 0x3A59D0 Offset: 0x3A4DD0 VA: 0x1803A59D0
	private static void Add_February_18_2021() { }

	// RVA: 0x3A1E80 Offset: 0x3A1280 VA: 0x1803A1E80
	private static void Add_February_11_2021() { }

	// RVA: 0x3A0AF0 Offset: 0x39FEF0 VA: 0x1803A0AF0
	private static void Add_February_10_2021_STREAMERSKINS() { }

	// RVA: 0x3A0410 Offset: 0x39F810 VA: 0x1803A0410
	private static void Add_February_04_2021() { }

	// RVA: 0x39F3C0 Offset: 0x39E7C0 VA: 0x18039F3C0
	private static void Add_February_03_2021_STREAMERSKINS() { }

	// RVA: 0x3B7570 Offset: 0x3B6970 VA: 0x1803B7570
	private static void Add_January_28_2021() { }

	// RVA: 0x3B5E10 Offset: 0x3B5210 VA: 0x1803B5E10
	private static void Add_January_21_2021() { }

	// RVA: 0x3B2CA0 Offset: 0x3B20A0 VA: 0x1803B2CA0
	private static void Add_January_15_2021_STREAMERSKINS() { }

	// RVA: 0x3B25D0 Offset: 0x3B19D0 VA: 0x1803B25D0
	private static void Add_January_14_2021() { }

	// RVA: 0x3AF520 Offset: 0x3AE920 VA: 0x1803AF520
	private static void Add_January_07_2021() { }

	// RVA: 0x3ADB30 Offset: 0x3ACF30 VA: 0x1803ADB30
	private static void Add_January_06_2021_STREAMERSKINS() { }

	// RVA: 0x375210 Offset: 0x374610 VA: 0x180375210
	private static void Add_2022() { }

	// RVA: 0x383D90 Offset: 0x383190 VA: 0x180383D90
	private static void Add_August_04_2022() { }

	// RVA: 0x3C6250 Offset: 0x3C5650 VA: 0x1803C6250
	private static void Add_July_28_2022() { }

	// RVA: 0x3C3090 Offset: 0x3C2490 VA: 0x1803C3090
	private static void Add_July_21_2022() { }

	// RVA: 0x3BF2A0 Offset: 0x3BE6A0 VA: 0x1803BF2A0
	private static void Add_July_14_2022() { }

	// RVA: 0x3BC390 Offset: 0x3BB790 VA: 0x1803BC390
	private static void Add_July_07_2022() { }

	// RVA: 0x3D58D0 Offset: 0x3D4CD0 VA: 0x1803D58D0
	private static void Add_June_30_2022() { }

	// RVA: 0x3D25E0 Offset: 0x3D19E0 VA: 0x1803D25E0
	private static void Add_June_23_2022() { }

	// RVA: 0x3CEDD0 Offset: 0x3CE1D0 VA: 0x1803CEDD0
	private static void Add_June_16_2022() { }

	// RVA: 0x3CBC00 Offset: 0x3CB000 VA: 0x1803CBC00
	private static void Add_June_09_2022() { }

	// RVA: 0x3CAB30 Offset: 0x3C9F30 VA: 0x1803CAB30
	private static void Add_June_02_2022() { }

	// RVA: 0x3F0D90 Offset: 0x3F0190 VA: 0x1803F0D90
	private static void Add_May_26_2022() { }

	// RVA: 0x3ED680 Offset: 0x3ECA80 VA: 0x1803ED680
	private static void Add_May_19_2022() { }

	// RVA: 0x3EAF10 Offset: 0x3EA310 VA: 0x1803EAF10
	private static void Add_May_12_2022() { }

	// RVA: 0x3E96D0 Offset: 0x3E8AD0 VA: 0x1803E96D0
	private static void Add_May_05_2022() { }

	// RVA: 0x3E8580 Offset: 0x3E7980 VA: 0x1803E8580
	private static void Add_May_04_2022_STREAMERSKINS() { }

	// RVA: 0x37F660 Offset: 0x37EA60 VA: 0x18037F660
	private static void Add_April_28_2022() { }

	// RVA: 0x37C280 Offset: 0x37B680 VA: 0x18037C280
	private static void Add_April_21_2022() { }

	// RVA: 0x378E30 Offset: 0x378230 VA: 0x180378E30
	private static void Add_April_14_2022_EASTER() { }

	// RVA: 0x378660 Offset: 0x377A60 VA: 0x180378660
	private static void Add_April_13_2022_STREAMERSKINS() { }

	// RVA: 0x375AA0 Offset: 0x374EA0 VA: 0x180375AA0
	private static void Add_April_07_2022() { }

	// RVA: 0x3E5BC0 Offset: 0x3E4FC0 VA: 0x1803E5BC0
	private static void Add_March_31_2022() { }

	// RVA: 0x3E1370 Offset: 0x3E0770 VA: 0x1803E1370
	private static void Add_March_24_2022() { }

	// RVA: 0x3DD070 Offset: 0x3DC470 VA: 0x1803DD070
	private static void Add_March_17_2022_STREAMERSKINS() { }

	// RVA: 0x3DD690 Offset: 0x3DCA90 VA: 0x1803DD690
	private static void Add_March_17_2022() { }

	// RVA: 0x3D9C10 Offset: 0x3D9010 VA: 0x1803D9C10
	private static void Add_March_10_2022() { }

	// RVA: 0x3D8F50 Offset: 0x3D8350 VA: 0x1803D8F50
	private static void Add_March_03_2022() { }

	// RVA: 0x3A88E0 Offset: 0x3A7CE0 VA: 0x1803A88E0
	private static void Add_February_24_2022() { }

	// RVA: 0x3A5300 Offset: 0x3A4700 VA: 0x1803A5300
	private static void Add_February_17_2022() { }

	// RVA: 0x3A1550 Offset: 0x3A0950 VA: 0x1803A1550
	private static void Add_February_10_2022() { }

	// RVA: 0x39FE20 Offset: 0x39F220 VA: 0x18039FE20
	private static void Add_February_03_2022() { }

	// RVA: 0x39EBF0 Offset: 0x39DFF0 VA: 0x18039EBF0
	private static void Add_February_01_2022_STREAMERSKINS() { }

	// RVA: 0x3B7C30 Offset: 0x3B7030 VA: 0x1803B7C30
	private static void Add_January_28_2022() { }

	// RVA: 0x3B5770 Offset: 0x3B4B70 VA: 0x1803B5770
	private static void Add_January_20_2022() { }

	// RVA: 0x3B1E00 Offset: 0x3B1200 VA: 0x1803B1E00
	private static void Add_January_13_2022() { }

	// RVA: 0x3AE300 Offset: 0x3AD700 VA: 0x1803AE300
	private static void Add_January_06_2022_STREAMERSKINS() { }

	// RVA: 0x3AEE30 Offset: 0x3AE230 VA: 0x1803AEE30
	private static void Add_January_06_2022() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void Add_Unlimited() { }

	// RVA: 0x41AEF0 Offset: 0x41A2F0 VA: 0x18041AEF0
	public static IReadOnlyDictionary<ulong, ApprovedSkinInfo> get_All() { }

	// RVA: 0x41AA80 Offset: 0x419E80 VA: 0x18041AA80
	private static void Initialize() { }

	// RVA: 0x41A890 Offset: 0x419C90 VA: 0x18041A890
	private static void Add(ApprovedSkinInfo skin) { }

	// RVA: 0x41A980 Offset: 0x419D80 VA: 0x18041A980
	public static ApprovedSkinInfo FindByInventoryId(int id) { }

	// RVA: 0x41A8F0 Offset: 0x419CF0 VA: 0x18041A8F0
	private static void EnsureInitialized() { }

}

public class ApprovedSkinInfo // TypeDefIndex: 7738
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public ulong get_InventoryId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B1160 Offset: 0x8B0560 VA: 0x1808B1160
	private void set_InventoryId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Desc() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_Desc(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public ulong get_WorkshopdId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86650 Offset: 0xE85A50 VA: 0x180E86650
	private void set_WorkshopdId(ulong value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA178C0 Offset: 0xA16CC0 VA: 0x180A178C0
	internal Price get_Price() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA17E80 Offset: 0xA17280 VA: 0x180A17E80
	private void set_Price(Price value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB9D210 Offset: 0xB9C610 VA: 0x180B9D210
	public bool get_Tradable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86640 Offset: 0xE85A40 VA: 0x180E86640
	private void set_Tradable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	public DropChance get_DropChance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	private void set_DropChance(DropChance value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC45090 Offset: 0xC44490 VA: 0x180C45090
	public bool get_Marketable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE86630 Offset: 0xE85A30 VA: 0x180E86630
	private void set_Marketable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	public Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	private void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	public bool get_AllowInCrates() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	private void set_AllowInCrates(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB9D230 Offset: 0xB9C630 VA: 0x180B9D230
	public bool get_IsLimitedTimeOffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x82B450 Offset: 0x82A850 VA: 0x18082B450
	private void set_IsLimitedTimeOffer(bool value) { }

	// RVA: 0xE85BD0 Offset: 0xE84FD0 VA: 0x180E85BD0
	public void .ctor(ulong WorkshopdId, string Name, string Desc, string ItemName) { }

	// RVA: 0xE85BA0 Offset: 0xE84FA0 VA: 0x180E85BA0
	public ApprovedSkinInfo Store(Price Price, bool CanBeTraded, bool CanBeSold) { }

	// RVA: 0xE85BB0 Offset: 0xE84FB0 VA: 0x180E85BB0
	public ApprovedSkinInfo TimeLimited() { }

	// RVA: 0xE85BC0 Offset: 0xE84FC0 VA: 0x180E85BC0
	public ApprovedSkinInfo Unlimited() { }

	// RVA: 0xE85B90 Offset: 0xE84F90 VA: 0x180E85B90
	public ApprovedSkinInfo NoCrate() { }

	// RVA: 0xE85B70 Offset: 0xE84F70 VA: 0x180E85B70
	public ApprovedSkinInfo Drops(DropChance DropChance) { }

	// RVA: 0xE85B80 Offset: 0xE84F80 VA: 0x180E85B80
	public ApprovedSkinInfo ItemId(ulong InventoryId) { }

	// RVA: 0xE85D80 Offset: 0xE85180 VA: 0x180E85D80
	public static ItemSchema.Item op_Implicit(ApprovedSkinInfo o) { }

}

private sealed class ApprovedSkinInfo.<>c__DisplayClass44_0 // TypeDefIndex: 7739
{	// Fields
	public string ItemName; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE941B0 Offset: 0xE935B0 VA: 0x180E941B0
	internal bool <.ctor>b__0(Skinnable x) { }

}

public abstract class AppIOEntity : IOEntity // TypeDefIndex: 8306
{	// Fields
	private Option __menuOption_Menu_Pair; // 0x288

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x8289D0 Offset: 0x827DD0 VA: 0x1808289D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x828F20 Offset: 0x828320 VA: 0x180828F20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x828DD0 Offset: 0x8281D0 VA: 0x180828DD0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	[BaseEntity.Menu.Description] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	[BaseEntity.Menu.Icon] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	[BaseEntity.Menu.ShowIf] // RVA: 0xB0330 Offset: 0xAF730 VA: 0x1800B0330
	// RVA: 0x828D30 Offset: 0x828130 VA: 0x180828D30
	public void Menu_Pair(BasePlayer player) { }

	// RVA: 0x828D70 Offset: 0x828170 VA: 0x180828D70
	public bool Menu_ShowIf(BasePlayer player) { }

	// RVA: 0x828EC0 Offset: 0x8282C0 VA: 0x180828EC0
	protected void .ctor() { }

}

public class ApplyTerrainAnchors : MonoBehaviour // TypeDefIndex: 10372
{	// Methods

	// RVA: 0x829030 Offset: 0x828430 VA: 0x180829030
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ApplyTerrainModifiers : MonoBehaviour // TypeDefIndex: 10573
{	// Methods

	// RVA: 0x829130 Offset: 0x828530 VA: 0x180829130
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class ApplyTweakUIChanges : MonoBehaviour // TypeDefIndex: 11131
{	// Fields
	public Button ApplyButton; // 0x18
	public TweakUIBase[] Options; // 0x20

	// Methods

	// RVA: 0x829310 Offset: 0x828710 VA: 0x180829310
	private void OnEnable() { }

	// RVA: 0x829230 Offset: 0x828630 VA: 0x180829230
	public void Apply() { }

	// RVA: 0x8293A0 Offset: 0x8287A0 VA: 0x1808293A0
	public void SetDirty() { }

	// RVA: 0x829320 Offset: 0x828720 VA: 0x180829320
	public void SetClean() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class App : ConsoleSystem // TypeDefIndex: 11878
{	// Fields
	[ServerVar] // RVA: 0x818D0 Offset: 0x80CD0 VA: 0x1800818D0
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

	// Methods

	// RVA: 0x6C88F0 Offset: 0x6C7CF0 VA: 0x1806C88F0
	public void .ctor() { }

	// RVA: 0x6C87F0 Offset: 0x6C7BF0 VA: 0x1806C87F0
	private static void .cctor() { }

}

