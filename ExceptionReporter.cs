public class ExceptionReporter : MonoBehaviour // TypeDefIndex: 6193
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <Disabled>k__BackingField; // 0x0
	private static readonly Stopwatch LastReportTime; // 0x8
	private static int _reportsSentCounter; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <PublicKey>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <SecretKey>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <Host>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static string <ProjectId>k__BackingField; // 0x30

	// Properties
	public static bool Disabled { get; set; }
	public static string PublicKey { get; set; }
	public static string SecretKey { get; set; }
	public static string Host { get; set; }
	public static string ProjectId { get; set; }
	private static Dictionary<string, string> Headers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EAD40 Offset: 0x14EA140 VA: 0x1814EAD40
	public static bool get_Disabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB440 Offset: 0x14EA840 VA: 0x1814EB440
	public static void set_Disabled(bool value) { }

	// RVA: 0x14E9DD0 Offset: 0x14E91D0 VA: 0x1814E9DD0
	internal static void InstallHooks() { }

	// RVA: 0x14E9E30 Offset: 0x14E9230 VA: 0x1814E9E30
	private static void OnLogMessage(string message, string stackTrace, LogType type) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB380 Offset: 0x14EA780 VA: 0x1814EB380
	public static string get_PublicKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB580 Offset: 0x14EA980 VA: 0x1814EB580
	private static void set_PublicKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB3E0 Offset: 0x14EA7E0 VA: 0x1814EB3E0
	public static string get_SecretKey() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB5F0 Offset: 0x14EA9F0 VA: 0x1814EB5F0
	private static void set_SecretKey(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB200 Offset: 0x14EA600 VA: 0x1814EB200
	public static string get_Host() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB4A0 Offset: 0x14EA8A0 VA: 0x1814EB4A0
	private static void set_Host(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB2C0 Offset: 0x14EA6C0 VA: 0x1814EB2C0
	public static string get_ProjectId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14EB510 Offset: 0x14EA910 VA: 0x1814EB510
	private static void set_ProjectId(string value) { }

	// RVA: 0x14E9B20 Offset: 0x14E8F20 VA: 0x1814E9B20
	public static void InitializeFromUrl(string url) { }

	// RVA: 0x14EA300 Offset: 0x14E9700 VA: 0x1814EA300
	public static void SendReport(string exception, string stacktrace) { }

	// RVA: 0x14EADA0 Offset: 0x14EA1A0 VA: 0x1814EADA0
	private static Dictionary<string, string> get_Headers() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x14EACD0 Offset: 0x14EA0D0 VA: 0x1814EACD0
	private static void .cctor() { }

}

