public class ExceptionReporter : MonoBehaviour // TypeDefIndex: 6193
{
	[CompilerGeneratedAttribute] 
	private static bool <Disabled>k__BackingField; 
	private static readonly Stopwatch LastReportTime; 
	private static int _reportsSentCounter; 
	[CompilerGeneratedAttribute] 
	private static string <PublicKey>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <SecretKey>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <Host>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static string <ProjectId>k__BackingField; 

public static bool Disabled { get; set; }
public static string PublicKey { get; set; }
public static string SecretKey { get; set; }
public static string Host { get; set; }
public static string ProjectId { get; set; }
private static Dictionary<string, string> Headers { get; }


	[CompilerGeneratedAttribute] 
public static bool get_Disabled() { }

	[CompilerGeneratedAttribute] 
public static void set_Disabled(bool value) { }

internal static void InstallHooks() { }

private static void OnLogMessage(string message, string stackTrace, LogType type) { }

	[CompilerGeneratedAttribute] 
public static string get_PublicKey() { }

	[CompilerGeneratedAttribute] 
private static void set_PublicKey(string value) { }

	[CompilerGeneratedAttribute] 
public static string get_SecretKey() { }

	[CompilerGeneratedAttribute] 
private static void set_SecretKey(string value) { }

	[CompilerGeneratedAttribute] 
public static string get_Host() { }

	[CompilerGeneratedAttribute] 
private static void set_Host(string value) { }

	[CompilerGeneratedAttribute] 
public static string get_ProjectId() { }

	[CompilerGeneratedAttribute] 
private static void set_ProjectId(string value) { }

public static void InitializeFromUrl(string url) { }

public static void SendReport(string exception, string stacktrace) { }

private static Dictionary<string, string> get_Headers() { }

public void .ctor() { }

private static void .cctor() { }

}

