public class Report // TypeDefIndex: 6189
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <release>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <message>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <platform>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <event_id>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Dictionary<string, string> <tags>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Report.StackTrace <stacktrace>k__BackingField; // 0x38

	public string release { get; set; }
	public string message { get; set; }
	public string platform { get; set; }
	public string event_id { get; set; }
	public Dictionary<string, string> tags { get; set; }
	public Report.StackTrace stacktrace { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_release() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_release(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_message() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_message(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_platform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_platform(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_event_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_event_id(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Dictionary<string, string> get_tags() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_tags(Dictionary<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Report.StackTrace get_stacktrace() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_stacktrace(Report.StackTrace value) { }

	public void .ctor() { }

}

public class Report.StackTrace // TypeDefIndex: 6190
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Report.StackTrace.StackFrame[] <frames>k__BackingField; // 0x10

	public Report.StackTrace.StackFrame[] frames { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Report.StackTrace.StackFrame[] get_frames() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_frames(Report.StackTrace.StackFrame[] value) { }

	public void .ctor() { }

	public void .ctor(string unityStack) { }

}

public class Report.StackTrace.StackFrame // TypeDefIndex: 6191
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <colno>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <filename>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <function>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <lineno>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <module>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <context_line>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <in_app>k__BackingField; // 0x40

	public int colno { get; set; }
	public string filename { get; set; }
	public string function { get; set; }
	public int lineno { get; set; }
	public string module { get; set; }
	public string context_line { get; set; }
	public bool in_app { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_colno() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_colno(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_filename() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_filename(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_function() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_function(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_lineno() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_lineno(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_module() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_module(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_context_line() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_context_line(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_in_app() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_in_app(bool value) { }

	public void .ctor(StackFrame x) { }

	public void .ctor(string x) { }

	private static bool IsSystemModuleName(string moduleName) { }

}

private sealed class Report.StackTrace.<>c // TypeDefIndex: 6192
{	public static readonly Report.StackTrace.<>c <>9; // 0x0
	public static Func<StackFrame, Report.StackTrace.StackFrame> <>9__4_0; // 0x8
	public static Func<string, Report.StackTrace.StackFrame> <>9__5_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal Report.StackTrace.StackFrame <.ctor>b__4_0(StackFrame x) { }

	internal Report.StackTrace.StackFrame <.ctor>b__5_0(string x) { }

}

public enum ReportType // TypeDefIndex: 6243
{	public int value__; // 0x0
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
{	public GameObject GetInformation; // 0x30
	public GameObject Finished; // 0x38
	public RustInput Subject; // 0x40
	public RustInput Message; // 0x48
	public RustButton ReportButton; // 0x50
	public RustButtonGroup Category; // 0x58
	public RustIcon ProgressIcon; // 0x60
	public RustText ProgressText; // 0x68
	public RawImage ScreenshotImage; // 0x70
	public GameObject ScreenshotRoot; // 0x78
	public UIBackgroundBlur BlurController; // 0x80
	public RustButton SubmitButton; // 0x88
	public GameObject SubmitErrorRoot; // 0x90
	public RustText CooldownText; // 0x98
	public RustText ContentMissingText; // 0xA0
	private Texture2D reportScreenshot; // 0xA8
	private static TimeSince lastOffensiveContentReport; // 0x0
	private static bool hasSubmittedOffensiveContentReport; // 0x4
	private const float MinimumTimeBetweenOffensiveContentReports = 180;
	private BaseEntity possibleUgcCandidate; // 0xB0


	public override void OpenDialog() { }

	[IteratorStateMachineAttribute] // RVA: 0xD06C0 Offset: 0xCFAC0 VA: 0x1800D06C0
	private IEnumerator CaptureScreenshot() { }

	public void Cancel() { }

	public override void CloseDialog() { }

	public void ChangePlayer() { }

	public void UpdateGetInformation() { }

	private void Update() { }

	public void ReportPlayer() { }

	[AsyncStateMachineAttribute] // RVA: 0xD07E0 Offset: 0xCFBE0 VA: 0x1800D07E0
	public void SendReport() { }

	public void OnChangedSelectedOption(Option option) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public static class ReportBug.Phrases // TypeDefIndex: 12040
{	public static Translate.Phrase Initializing; // 0x0
	public static Translate.Phrase SendingReport; // 0x8
	public static Translate.Phrase Success; // 0x10


	private static void .cctor() { }

}

private sealed class ReportBug.<CaptureScreenshot>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12041
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ReportBug <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private struct ReportBug.<SendReport>d__29 : IAsyncStateMachine // TypeDefIndex: 12042
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ReportBug <>4__this; // 0x28
	private Feedback <feedback>5__2; // 0x30
	private TaskAwaiter<string> <>u__1; // 0x70


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class ReportPlayer : UIDialog // TypeDefIndex: 12043
{	public GameObject FindPlayer; // 0x30
	public GameObject GetInformation; // 0x38
	public GameObject Finished; // 0x40
	public GameObject RecentlyReported; // 0x48
	public Dropdown ReasonDropdown; // 0x50
	public RustInput Subject; // 0x58
	public RustInput Message; // 0x60
	public RustButton ReportButton; // 0x68
	public SteamUserButton SteamUserButton; // 0x70
	public RustIcon ProgressIcon; // 0x78
	public RustText ProgressText; // 0x80
	public static Option[] ReportReasons; // 0x0
	private ulong SteamId; // 0x88
	private static Dictionary<ulong, TimeSince> reportTimes; // 0x8


	public override void OpenDialog() { }

	public void ChooseSteamId(ulong steamid, string steamName = "") { }

	public void Cancel() { }

	public void ChangePlayer() { }

	public void UpdateGetInformation() { }

	private bool HasRecentlyReported(ulong id) { }

	[AsyncStateMachineAttribute] // RVA: 0xD0F90 Offset: 0xD0390 VA: 0x1800D0F90
	public void SendReport() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public static class ReportPlayer.Phrases // TypeDefIndex: 12044
{	public static Translate.Phrase Initializing; // 0x0
	public static Translate.Phrase SendingReport; // 0x8
	public static Translate.Phrase Success; // 0x10


	private static void .cctor() { }

}

private struct ReportPlayer.<SendReport>d__21 : IAsyncStateMachine // TypeDefIndex: 12045
{	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ReportPlayer <>4__this; // 0x28
	private Feedback <feedback>5__2; // 0x30
	private TaskAwaiter<string> <>u__1; // 0x70


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

