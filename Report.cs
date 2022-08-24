public class Report // TypeDefIndex: 6189
{
	[CompilerGeneratedAttribute] 
	private string <release>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <message>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <platform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <event_id>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Dictionary<string, string> <tags>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Report.StackTrace <stacktrace>k__BackingField; 

public string release { get; set; }
public string message { get; set; }
public string platform { get; set; }
public string event_id { get; set; }
public Dictionary<string, string> tags { get; set; }
public Report.StackTrace stacktrace { get; set; }


	[CompilerGeneratedAttribute] 
public string get_release() { }

	[CompilerGeneratedAttribute] 
public void set_release(string value) { }

	[CompilerGeneratedAttribute] 
public string get_message() { }

	[CompilerGeneratedAttribute] 
public void set_message(string value) { }

	[CompilerGeneratedAttribute] 
public string get_platform() { }

	[CompilerGeneratedAttribute] 
public void set_platform(string value) { }

	[CompilerGeneratedAttribute] 
public string get_event_id() { }

	[CompilerGeneratedAttribute] 
public void set_event_id(string value) { }

	[CompilerGeneratedAttribute] 
public Dictionary<string, string> get_tags() { }

	[CompilerGeneratedAttribute] 
public void set_tags(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] 
public Report.StackTrace get_stacktrace() { }

	[CompilerGeneratedAttribute] 
public void set_stacktrace(Report.StackTrace value) { }

public void .ctor() { }

}

public class Report.StackTrace // TypeDefIndex: 6190
{
	[CompilerGeneratedAttribute] 
	private Report.StackTrace.StackFrame[] <frames>k__BackingField; 

public Report.StackTrace.StackFrame[] frames { get; set; }


	[CompilerGeneratedAttribute] 
public Report.StackTrace.StackFrame[] get_frames() { }

	[CompilerGeneratedAttribute] 
public void set_frames(Report.StackTrace.StackFrame[] value) { }

public void .ctor() { }

public void .ctor(string unityStack) { }

}

public class Report.StackTrace.StackFrame // TypeDefIndex: 6191
{
	[CompilerGeneratedAttribute] 
	private int <colno>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <filename>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <function>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <lineno>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <module>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <context_line>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <in_app>k__BackingField; 

public int colno { get; set; }
public string filename { get; set; }
public string function { get; set; }
public int lineno { get; set; }
public string module { get; set; }
public string context_line { get; set; }
public bool in_app { get; set; }


	[CompilerGeneratedAttribute] 
public int get_colno() { }

	[CompilerGeneratedAttribute] 
public void set_colno(int value) { }

	[CompilerGeneratedAttribute] 
public string get_filename() { }

	[CompilerGeneratedAttribute] 
private void set_filename(string value) { }

	[CompilerGeneratedAttribute] 
public string get_function() { }

	[CompilerGeneratedAttribute] 
private void set_function(string value) { }

	[CompilerGeneratedAttribute] 
public int get_lineno() { }

	[CompilerGeneratedAttribute] 
private void set_lineno(int value) { }

	[CompilerGeneratedAttribute] 
public string get_module() { }

	[CompilerGeneratedAttribute] 
private void set_module(string value) { }

	[CompilerGeneratedAttribute] 
public string get_context_line() { }

	[CompilerGeneratedAttribute] 
private void set_context_line(string value) { }

	[CompilerGeneratedAttribute] 
public bool get_in_app() { }

	[CompilerGeneratedAttribute] 
private void set_in_app(bool value) { }

public void .ctor(StackFrame x) { }

public void .ctor(string x) { }

private static bool IsSystemModuleName(string moduleName) { }

}

private sealed class Report.StackTrace.<>c // TypeDefIndex: 6192
{
	public static readonly Report.StackTrace.<>c <>9; 
	public static Func<StackFrame, Report.StackTrace.StackFrame> <>9__4_0; 
	public static Func<string, Report.StackTrace.StackFrame> <>9__5_0; 


private static void .cctor() { }

public void .ctor() { }

internal Report.StackTrace.StackFrame <.ctor>b__4_0(StackFrame x) { }

internal Report.StackTrace.StackFrame <.ctor>b__5_0(string x) { }

}

public enum ReportType // TypeDefIndex: 6243
{
	public int value__; 
public const ReportType General = 0;
public const ReportType Bug = 1;
public const ReportType Cheat = 2;
public const ReportType Abuse = 3;
public const ReportType Idea = 4;
public const ReportType OffensiveContent = 5;
public const ReportType FIRST = 0;
public const ReportType LAST = 5;

}

public class ReportBug : UIDialog // TypeDefIndex: 12039
{
	public GameObject GetInformation; 
	public GameObject Finished; 
	public RustInput Subject; 
	public RustInput Message; 
	public RustButton ReportButton; 
	public RustButtonGroup Category; 
	public RustIcon ProgressIcon; 
	public RustText ProgressText; 
	public RawImage ScreenshotImage; 
	public GameObject ScreenshotRoot; 
	public UIBackgroundBlur BlurController; 
	public RustButton SubmitButton; 
	public GameObject SubmitErrorRoot; 
	public RustText CooldownText; 
	public RustText ContentMissingText; 
	private Texture2D reportScreenshot; 
	private static TimeSince lastOffensiveContentReport; 
	private static bool hasSubmittedOffensiveContentReport; 
private const float MinimumTimeBetweenOffensiveContentReports = 180;
	private BaseEntity possibleUgcCandidate; 


public override void OpenDialog() { }

	[IteratorStateMachineAttribute] 
private IEnumerator CaptureScreenshot() { }

public void Cancel() { }

public override void CloseDialog() { }

public void ChangePlayer() { }

public void UpdateGetInformation() { }

private void Update() { }

public void ReportPlayer() { }

	[AsyncStateMachineAttribute] 
public void SendReport() { }

public void OnChangedSelectedOption(Option option) { }

public void .ctor() { }

private static void .cctor() { }

}

public static class ReportBug.Phrases // TypeDefIndex: 12040
{
	public static Translate.Phrase Initializing; 
	public static Translate.Phrase SendingReport; 
	public static Translate.Phrase Success; 


private static void .cctor() { }

}

private sealed class ReportBug.<CaptureScreenshot>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12041
{
	private int <>1__state; 
	private object <>2__current; 
	public ReportBug <>4__this; 

private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

}

private struct ReportBug.<SendReport>d__29 : IAsyncStateMachine // TypeDefIndex: 12042
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public ReportBug <>4__this; 
	private Feedback <feedback>5__2; 
	private TaskAwaiter<string> <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ReportPlayer : UIDialog // TypeDefIndex: 12043
{
	public GameObject FindPlayer; 
	public GameObject GetInformation; 
	public GameObject Finished; 
	public GameObject RecentlyReported; 
	public Dropdown ReasonDropdown; 
	public RustInput Subject; 
	public RustInput Message; 
	public RustButton ReportButton; 
	public SteamUserButton SteamUserButton; 
	public RustIcon ProgressIcon; 
	public RustText ProgressText; 
	public static Option[] ReportReasons; 
	private ulong SteamId; 
	private static Dictionary<ulong, TimeSince> reportTimes; 


public override void OpenDialog() { }

public void ChooseSteamId(ulong steamid, string steamName = "") { }

public void Cancel() { }

public void ChangePlayer() { }

public void UpdateGetInformation() { }

private bool HasRecentlyReported(ulong id) { }

	[AsyncStateMachineAttribute] 
public void SendReport() { }

public void .ctor() { }

private static void .cctor() { }

}

public static class ReportPlayer.Phrases // TypeDefIndex: 12044
{
	public static Translate.Phrase Initializing; 
	public static Translate.Phrase SendingReport; 
	public static Translate.Phrase Success; 


private static void .cctor() { }

}

private struct ReportPlayer.<SendReport>d__21 : IAsyncStateMachine // TypeDefIndex: 12045
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public ReportPlayer <>4__this; 
	private Feedback <feedback>5__2; 
	private TaskAwaiter<string> <>u__1; 


private void MoveNext() { }

	[DebuggerHiddenAttribute] 
private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

