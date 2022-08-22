internal static class GADevice // TypeDefIndex: 5675
{	private static readonly string _buildPlatform; // 0x0
	private static readonly string _deviceModel; // 0x8
	private static string _writablepath; // 0x10
	private static readonly string _osVersion; // 0x18
	private static readonly string _deviceManufacturer; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <SdkGameEngineVersion>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <GameEngineVersion>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <ConnectionType>k__BackingField; // 0x38

	private static string SdkGameEngineVersion { get; set; }
	public static string GameEngineVersion { get; set; }
	public static string ConnectionType { get; set; }
	public static string RelevantSdkVersion { get; }
	public static string BuildPlatform { get; }
	public static string OSVersion { get; }
	public static string DeviceManufacturer { get; }
	public static string WritablePath { get; }


	public static void Touch() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string get_SdkGameEngineVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_SdkGameEngineVersion(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string get_GameEngineVersion() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_GameEngineVersion(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static string get_ConnectionType() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void set_ConnectionType(string value) { }

	public static string get_RelevantSdkVersion() { }

	public static string get_BuildPlatform() { }

	public static string get_OSVersion() { }

	public static string get_DeviceManufacturer() { }

	public static string get_WritablePath() { }

	public static void UpdateConnectionType() { }

	private static string GetOSVersionString() { }

	private static string GetPersistentPath() { }

	private static string UnityRuntimePlatformToString(RuntimePlatform platform) { }

	private static void .cctor() { }

}

