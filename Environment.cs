public static class Environment // TypeDefIndex: 340
{	// Fields
	private const int mono_corlib_version = 1051100001;
	private static string nl; // 0x0
	private static OperatingSystem os; // 0x8

	// Properties
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

	// Methods

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	internal static string GetResourceString(string key) { }

	// RVA: 0x10D59E0 Offset: 0x10D4DE0 VA: 0x1810D59E0
	internal static string GetResourceString(string key, object[] values) { }

	// RVA: 0x10D58E0 Offset: 0x10D4CE0 VA: 0x1810D58E0
	internal static string GetResourceStringEncodingName(int codePage) { }

	// RVA: 0x10D6470 Offset: 0x10D5870 VA: 0x1810D6470
	public static string get_CurrentDirectory() { }

	// RVA: 0x10D6480 Offset: 0x10D5880 VA: 0x1810D6480
	public static int get_CurrentManagedThreadId() { }

	// RVA: 0x10D64B0 Offset: 0x10D58B0 VA: 0x1810D64B0
	public static bool get_HasShutdownStarted() { }

	// RVA: 0x10D6530 Offset: 0x10D5930 VA: 0x1810D6530
	public static string get_MachineName() { }

	// RVA: 0x10D58B0 Offset: 0x10D4CB0 VA: 0x1810D58B0
	private static string GetNewLine() { }

	// RVA: 0x10D6540 Offset: 0x10D5940 VA: 0x1810D6540
	public static string get_NewLine() { }

	// RVA: 0x10D6830 Offset: 0x10D5C30 VA: 0x1810D6830
	private static PlatformID get_Platform() { }

	// RVA: 0x10D58C0 Offset: 0x10D4CC0 VA: 0x1810D58C0
	internal static string GetOSVersionString() { }

	// RVA: 0x10D65B0 Offset: 0x10D59B0 VA: 0x1810D65B0
	public static OperatingSystem get_OSVersion() { }

	// RVA: 0x10D50C0 Offset: 0x10D44C0 VA: 0x1810D50C0
	internal static Version CreateVersionFromString(string info) { }

	// RVA: 0x10D6850 Offset: 0x10D5C50 VA: 0x1810D6850
	public static string get_StackTrace() { }

	// RVA: 0x10D68C0 Offset: 0x10D5CC0 VA: 0x1810D68C0
	public static int get_TickCount() { }

	// RVA: 0x10D6530 Offset: 0x10D5930 VA: 0x1810D6530
	public static string get_UserDomainName() { }

	// RVA: 0x10D68D0 Offset: 0x10D5CD0 VA: 0x1810D68D0
	public static string get_UserName() { }

	// RVA: 0x10D5270 Offset: 0x10D4670 VA: 0x1810D5270
	public static void Exit(int exitCode) { }

	// RVA: 0x10D5280 Offset: 0x10D4680 VA: 0x1810D5280
	public static string ExpandEnvironmentVariables(string name) { }

	// RVA: 0x10D56E0 Offset: 0x10D4AE0 VA: 0x1810D56E0
	public static string[] GetCommandLineArgs() { }

	// RVA: 0x10D69B0 Offset: 0x10D5DB0 VA: 0x1810D69B0
	internal static string internalGetEnvironmentVariable_native(IntPtr variable) { }

	// RVA: 0x10D68E0 Offset: 0x10D5CE0 VA: 0x1810D68E0
	internal static string internalGetEnvironmentVariable(string variable) { }

	// RVA: 0x10D5700 Offset: 0x10D4B00 VA: 0x1810D5700
	public static string GetEnvironmentVariable(string variable) { }

	// RVA: 0x10D5710 Offset: 0x10D4B10 VA: 0x1810D5710
	private static Hashtable GetEnvironmentVariablesNoCase() { }

	// RVA: 0x10D5800 Offset: 0x10D4C00 VA: 0x1810D5800
	public static string GetFolderPath(Environment.SpecialFolder folder) { }

	// RVA: 0x10D5AE0 Offset: 0x10D4EE0 VA: 0x1810D5AE0
	private static string GetWindowsFolderPath(int folder) { }

	// RVA: 0x10D5840 Offset: 0x10D4C40 VA: 0x1810D5840
	public static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10D5B00 Offset: 0x10D4F00 VA: 0x1810D5B00
	private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback) { }

	// RVA: 0x10D5FF0 Offset: 0x10D53F0 VA: 0x1810D5FF0
	internal static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) { }

	// RVA: 0x10D5890 Offset: 0x10D4C90 VA: 0x1810D5890
	public static string[] GetLogicalDrives() { }

	// RVA: 0x10D5E80 Offset: 0x10D5280 VA: 0x1810D5E80
	public static void SetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10D5AF0 Offset: 0x10D4EF0 VA: 0x1810D5AF0
	internal static void InternalSetEnvironmentVariable(string variable, string value) { }

	// RVA: 0x10D5630 Offset: 0x10D4A30 VA: 0x1810D5630
	public static void FailFast(string message) { }

	// RVA: 0x10D5680 Offset: 0x10D4A80 VA: 0x1810D5680
	public static void FailFast(string message, Exception exception) { }

	// RVA: 0x10D64C0 Offset: 0x10D58C0 VA: 0x1810D64C0
	public static bool get_Is64BitProcess() { }

	// RVA: 0x10D6840 Offset: 0x10D5C40 VA: 0x1810D6840
	public static int get_ProcessorCount() { }

	// RVA: 0x10D64E0 Offset: 0x10D58E0 VA: 0x1810D64E0
	internal static bool get_IsRunningOnWindows() { }

	// RVA: 0x10D5890 Offset: 0x10D4C90 VA: 0x1810D5890
	private static string[] GetLogicalDrivesInternal() { }

	// RVA: 0x10D56F0 Offset: 0x10D4AF0 VA: 0x1810D56F0
	private static string[] GetEnvironmentVariableNames() { }

	// RVA: 0x10D58A0 Offset: 0x10D4CA0 VA: 0x1810D58A0
	internal static string GetMachineConfigPath() { }

	// RVA: 0x10D69C0 Offset: 0x10D5DC0 VA: 0x1810D69C0
	internal static string internalGetHome() { }

	// RVA: 0x10D58D0 Offset: 0x10D4CD0 VA: 0x1810D58D0
	internal static int GetPageSize() { }

	// RVA: 0x10D6500 Offset: 0x10D5900 VA: 0x1810D6500
	internal static bool get_IsUnix() { }

	// RVA: 0x10D5A50 Offset: 0x10D4E50 VA: 0x1810D5A50
	internal static string GetStackTrace(Exception e, bool needFileInfo) { }

}

public enum Environment.SpecialFolder // TypeDefIndex: 341
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const Environment.SpecialFolderOption None = 0;
	public const Environment.SpecialFolderOption DoNotVerify = 16384;
	public const Environment.SpecialFolderOption Create = 32768;

}

public class Environment : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6298
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long dateTime; // 0x18
	public float clouds; // 0x20
	public float fog; // 0x24
	public float wind; // 0x28
	public float rain; // 0x2C
	public float engineTime; // 0x30

	// Methods

	// RVA: 0x1D52950 Offset: 0x1D51D50 VA: 0x181D52950
	public static void ResetToPool(Environment instance) { }

	// RVA: 0x1D52890 Offset: 0x1D51C90 VA: 0x181D52890
	public void ResetToPool() { }

	// RVA: 0x1D52490 Offset: 0x1D51890 VA: 0x181D52490 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D50F50 Offset: 0x1D50350 VA: 0x181D50F50
	public void CopyTo(Environment instance) { }

	// RVA: 0x1D50F90 Offset: 0x1D50390 VA: 0x181D50F90
	public Environment Copy() { }

	// RVA: 0x1D517F0 Offset: 0x1D50BF0 VA: 0x181D517F0
	public static Environment Deserialize(Stream stream) { }

	// RVA: 0x1D51020 Offset: 0x1D50420 VA: 0x181D51020
	public static Environment DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D51760 Offset: 0x1D50B60 VA: 0x181D51760
	public static Environment DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D520F0 Offset: 0x1D514F0 VA: 0x181D520F0
	public static Environment Deserialize(byte[] buffer) { }

	// RVA: 0x1D525D0 Offset: 0x1D519D0 VA: 0x181D525D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D53040 Offset: 0x1D52440 VA: 0x181D53040 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D53060 Offset: 0x1D52460 VA: 0x181D53060 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Environment previous) { }

	// RVA: 0x1D52870 Offset: 0x1D51C70 VA: 0x181D52870 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D51D70 Offset: 0x1D51170 VA: 0x181D51D70
	public static Environment Deserialize(byte[] buffer, Environment instance, bool isDelta = False) { }

	// RVA: 0x1D51AD0 Offset: 0x1D50ED0 VA: 0x181D51AD0
	public static Environment Deserialize(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D510A0 Offset: 0x1D504A0 VA: 0x181D510A0
	public static Environment DeserializeLengthDelimited(Stream stream, Environment instance, bool isDelta) { }

	// RVA: 0x1D51410 Offset: 0x1D50810 VA: 0x181D51410
	public static Environment DeserializeLength(Stream stream, int length, Environment instance, bool isDelta) { }

	// RVA: 0x1D52A10 Offset: 0x1D51E10 VA: 0x181D52A10
	public static void SerializeDelta(Stream stream, Environment instance, Environment previous) { }

	// RVA: 0x1D52E90 Offset: 0x1D52290 VA: 0x181D52E90
	public static void Serialize(Stream stream, Environment instance) { }

	// RVA: 0x1D53030 Offset: 0x1D52430 VA: 0x181D53030
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D53040 Offset: 0x1D52440 VA: 0x181D53040
	public void ToProto(Stream stream) { }

	// RVA: 0x1D52D80 Offset: 0x1D52180 VA: 0x181D52D80
	public static byte[] SerializeToBytes(Environment instance) { }

	// RVA: 0x1D52CD0 Offset: 0x1D520D0 VA: 0x181D52CD0
	public static void SerializeLengthDelimited(Stream stream, Environment instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

