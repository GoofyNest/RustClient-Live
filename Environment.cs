public static class Environment // TypeDefIndex: 340
{	private const int mono_corlib_version = 1051100001;
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	public static string CurrentDirectory { get; }
	public static int CurrentManagedThreadId { get; }
	public static bool HasShutdownStarted { get; }
	public static string MachineName { get; }
	public static string NewLine { get; }
	private static PlatformID Platform { get; }
	public static OperatingSystem OSVersion { get; }
	public static string StackTrace { get; }
	public static int TickCount { get; }
	public static string UserDomainName { get; }
	public static string UserName { get; }
	public static bool Is64BitProcess { get; }
	public static int ProcessorCount { get; }
	internal static bool IsRunningOnWindows { get; }
	internal static bool IsUnix { get; }


	internal static string GetResourceString(string key) { }

	internal static string GetResourceString(string key, object[] values) { }

	internal static string GetResourceStringEncodingName(int codePage) { }

	public static string get_CurrentDirectory() { }

	public static int get_CurrentManagedThreadId() { }

	public static bool get_HasShutdownStarted() { }

	public static string get_MachineName() { }

	private static string GetNewLine() { }

	public static string get_NewLine() { }

	private static PlatformID get_Platform() { }

	internal static string GetOSVersionString() { }

	public static OperatingSystem get_OSVersion() { }

	internal static Version CreateVersionFromString(string info) { }

	public static string get_StackTrace() { }

	public static int get_TickCount() { }

	public static string get_UserDomainName() { }

	public static string get_UserName() { }

	public static void Exit(int exitCode) { }

	public static string ExpandEnvironmentVariables(string name) { }

	public static string[] GetCommandLineArgs() { }

	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	internal static string internalGetEnvironmentVariable(string variable) { }

	public static string GetEnvironmentVariable(string variable) { }

	private static Hashtable GetEnvironmentVariablesNoCase() { }

	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	private static string GetWindowsFolderPath(int folder) { }

	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	public static string[] GetLogicalDrives() { }

	public static void SetEnvironmentVariable(string variable, string value) { }

	internal static void InternalSetEnvironmentVariable(string variable, string value) { }

	public static void FailFast(string message) { }

	public static void FailFast(string message, Exception exception) { }

	public static bool get_Is64BitProcess() { }

	public static int get_ProcessorCount() { }

	internal static bool get_IsRunningOnWindows() { }

	private static string[] GetLogicalDrivesInternal() { }

	private static string[] GetEnvironmentVariableNames() { }

	internal static string GetMachineConfigPath() { }

	internal static string internalGetHome() { }

	internal static int GetPageSize() { }

	internal static bool get_IsUnix() { }

	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

}

public enum Environment.SpecialFolder // TypeDefIndex: 341
{	public int value__; // 0x0
	public const Environment.SpecialFolder MyDocuments = 5;
	public const Environment.SpecialFolder Desktop = 0;
	public const Environment.SpecialFolder MyComputer = 17;
	public const Environment.SpecialFolder Programs = 2;
	public const Environment.SpecialFolder Personal = 5;
	public const Environment.SpecialFolder Favorites = 6;
	public const Environment.SpecialFolder Startup = 7;
	public const Environment.SpecialFolder Recent = 8;
	public const Environment.SpecialFolder SendTo = 9;
	public const Environment.SpecialFolder StartMenu = 11;
	public const Environment.SpecialFolder MyMusic = 13;
	public const Environment.SpecialFolder DesktopDirectory = 16;
	public const Environment.SpecialFolder Templates = 21;
	public const Environment.SpecialFolder ApplicationData = 26;
	public const Environment.SpecialFolder LocalApplicationData = 28;
	public const Environment.SpecialFolder InternetCache = 32;
	public const Environment.SpecialFolder Cookies = 33;
	public const Environment.SpecialFolder History = 34;
	public const Environment.SpecialFolder CommonApplicationData = 35;
	public const Environment.SpecialFolder System = 37;
	public const Environment.SpecialFolder ProgramFiles = 38;
	public const Environment.SpecialFolder MyPictures = 39;
	public const Environment.SpecialFolder CommonProgramFiles = 43;
	public const Environment.SpecialFolder MyVideos = 14;
	public const Environment.SpecialFolder NetworkShortcuts = 19;
	public const Environment.SpecialFolder Fonts = 20;
	public const Environment.SpecialFolder CommonStartMenu = 22;
	public const Environment.SpecialFolder CommonPrograms = 23;
	public const Environment.SpecialFolder CommonStartup = 24;
	public const Environment.SpecialFolder CommonDesktopDirectory = 25;
	public const Environment.SpecialFolder PrinterShortcuts = 27;
	public const Environment.SpecialFolder Windows = 36;
	public const Environment.SpecialFolder UserProfile = 40;
	public const Environment.SpecialFolder SystemX86 = 41;
	public const Environment.SpecialFolder ProgramFilesX86 = 42;
	public const Environment.SpecialFolder CommonProgramFilesX86 = 44;
	public const Environment.SpecialFolder CommonTemplates = 45;
	public const Environment.SpecialFolder CommonDocuments = 46;
	public const Environment.SpecialFolder CommonAdminTools = 47;
	public const Environment.SpecialFolder AdminTools = 48;
	public const Environment.SpecialFolder CommonMusic = 53;
	public const Environment.SpecialFolder CommonPictures = 54;
	public const Environment.SpecialFolder CommonVideos = 55;
	public const Environment.SpecialFolder Resources = 56;
	public const Environment.SpecialFolder LocalizedResources = 57;
	public const Environment.SpecialFolder CommonOemLinks = 58;
	public const Environment.SpecialFolder CDBurning = 59;

}

public enum Environment.SpecialFolderOption // TypeDefIndex: 342
{	public int value__; // 0x0
	public const Environment.SpecialFolderOption None = 0;
	public const Environment.SpecialFolderOption DoNotVerify = 16384;
	public const Environment.SpecialFolderOption Create = 32768;

}

public class Environment : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6298
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long dateTime; // 0x18
	public float clouds; // 0x20
	public float fog; // 0x24
	public float wind; // 0x28
	public float rain; // 0x2C
	public float engineTime; // 0x30


	public static void ResetToPool(Environment instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Environment instance) { }

	public Environment Copy() { }

	public static Environment Deserialize(Stream stream) { }

	public static Environment DeserializeLengthDelimited(Stream stream) { }

	public static Environment DeserializeLength(Stream stream, int length) { }

	public static Environment Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Environment previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Environment Deserialize(byte[] buffer, Environment instance, bool isDelta = False) { }

	public static Environment Deserialize(Stream stream, Environment instance, bool isDelta) { }

	public static Environment DeserializeLengthDelimited(Stream stream, Environment instance, bool isDelta) { }

	public static Environment DeserializeLength(Stream stream, int length, Environment instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Environment instance, Environment previous) { }

	public static void Serialize(Stream stream, Environment instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Environment instance) { }

	public static void SerializeLengthDelimited(Stream stream, Environment instance) { }

	public void .ctor() { }

}

