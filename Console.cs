public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 186
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 187
{
	private ConsoleSpecialKey _type; 
	private bool _cancel; 

	public bool Cancel { get; }


	internal void .ctor(ConsoleSpecialKey type) { }

	public bool get_Cancel() { }

	internal void .ctor() { }

}

public enum ConsoleColor // TypeDefIndex: 188
{
	public int value__; 
	public const ConsoleColor Black = 0;
	public const ConsoleColor DarkBlue = 1;
	public const ConsoleColor DarkGreen = 2;
	public const ConsoleColor DarkCyan = 3;
	public const ConsoleColor DarkRed = 4;
	public const ConsoleColor DarkMagenta = 5;
	public const ConsoleColor DarkYellow = 6;
	public const ConsoleColor Gray = 7;
	public const ConsoleColor DarkGray = 8;
	public const ConsoleColor Blue = 9;
	public const ConsoleColor Green = 10;
	public const ConsoleColor Cyan = 11;
	public const ConsoleColor Red = 12;
	public const ConsoleColor Magenta = 13;
	public const ConsoleColor Yellow = 14;
	public const ConsoleColor White = 15;

}

public enum ConsoleKey // TypeDefIndex: 189
{
	public int value__; 
	public const ConsoleKey Backspace = 8;
	public const ConsoleKey Tab = 9;
	public const ConsoleKey Clear = 12;
	public const ConsoleKey Enter = 13;
	public const ConsoleKey Pause = 19;
	public const ConsoleKey Escape = 27;
	public const ConsoleKey Spacebar = 32;
	public const ConsoleKey PageUp = 33;
	public const ConsoleKey PageDown = 34;
	public const ConsoleKey End = 35;
	public const ConsoleKey Home = 36;
	public const ConsoleKey LeftArrow = 37;
	public const ConsoleKey UpArrow = 38;
	public const ConsoleKey RightArrow = 39;
	public const ConsoleKey DownArrow = 40;
	public const ConsoleKey Select = 41;
	public const ConsoleKey Print = 42;
	public const ConsoleKey Execute = 43;
	public const ConsoleKey PrintScreen = 44;
	public const ConsoleKey Insert = 45;
	public const ConsoleKey Delete = 46;
	public const ConsoleKey Help = 47;
	public const ConsoleKey D0 = 48;
	public const ConsoleKey D1 = 49;
	public const ConsoleKey D2 = 50;
	public const ConsoleKey D3 = 51;
	public const ConsoleKey D4 = 52;
	public const ConsoleKey D5 = 53;
	public const ConsoleKey D6 = 54;
	public const ConsoleKey D7 = 55;
	public const ConsoleKey D8 = 56;
	public const ConsoleKey D9 = 57;
	public const ConsoleKey A = 65;
	public const ConsoleKey B = 66;
	public const ConsoleKey C = 67;
	public const ConsoleKey D = 68;
	public const ConsoleKey E = 69;
	public const ConsoleKey F = 70;
	public const ConsoleKey G = 71;
	public const ConsoleKey H = 72;
	public const ConsoleKey I = 73;
	public const ConsoleKey J = 74;
	public const ConsoleKey K = 75;
	public const ConsoleKey L = 76;
	public const ConsoleKey M = 77;
	public const ConsoleKey N = 78;
	public const ConsoleKey O = 79;
	public const ConsoleKey P = 80;
	public const ConsoleKey Q = 81;
	public const ConsoleKey R = 82;
	public const ConsoleKey S = 83;
	public const ConsoleKey T = 84;
	public const ConsoleKey U = 85;
	public const ConsoleKey V = 86;
	public const ConsoleKey W = 87;
	public const ConsoleKey X = 88;
	public const ConsoleKey Y = 89;
	public const ConsoleKey Z = 90;
	public const ConsoleKey LeftWindows = 91;
	public const ConsoleKey RightWindows = 92;
	public const ConsoleKey Applications = 93;
	public const ConsoleKey Sleep = 95;
	public const ConsoleKey NumPad0 = 96;
	public const ConsoleKey NumPad1 = 97;
	public const ConsoleKey NumPad2 = 98;
	public const ConsoleKey NumPad3 = 99;
	public const ConsoleKey NumPad4 = 100;
	public const ConsoleKey NumPad5 = 101;
	public const ConsoleKey NumPad6 = 102;
	public const ConsoleKey NumPad7 = 103;
	public const ConsoleKey NumPad8 = 104;
	public const ConsoleKey NumPad9 = 105;
	public const ConsoleKey Multiply = 106;
	public const ConsoleKey Add = 107;
	public const ConsoleKey Separator = 108;
	public const ConsoleKey Subtract = 109;
	public const ConsoleKey Decimal = 110;
	public const ConsoleKey Divide = 111;
	public const ConsoleKey F1 = 112;
	public const ConsoleKey F2 = 113;
	public const ConsoleKey F3 = 114;
	public const ConsoleKey F4 = 115;
	public const ConsoleKey F5 = 116;
	public const ConsoleKey F6 = 117;
	public const ConsoleKey F7 = 118;
	public const ConsoleKey F8 = 119;
	public const ConsoleKey F9 = 120;
	public const ConsoleKey F10 = 121;
	public const ConsoleKey F11 = 122;
	public const ConsoleKey F12 = 123;
	public const ConsoleKey F13 = 124;
	public const ConsoleKey F14 = 125;
	public const ConsoleKey F15 = 126;
	public const ConsoleKey F16 = 127;
	public const ConsoleKey F17 = 128;
	public const ConsoleKey F18 = 129;
	public const ConsoleKey F19 = 130;
	public const ConsoleKey F20 = 131;
	public const ConsoleKey F21 = 132;
	public const ConsoleKey F22 = 133;
	public const ConsoleKey F23 = 134;
	public const ConsoleKey F24 = 135;
	public const ConsoleKey BrowserBack = 166;
	public const ConsoleKey BrowserForward = 167;
	public const ConsoleKey BrowserRefresh = 168;
	public const ConsoleKey BrowserStop = 169;
	public const ConsoleKey BrowserSearch = 170;
	public const ConsoleKey BrowserFavorites = 171;
	public const ConsoleKey BrowserHome = 172;
	public const ConsoleKey VolumeMute = 173;
	public const ConsoleKey VolumeDown = 174;
	public const ConsoleKey VolumeUp = 175;
	public const ConsoleKey MediaNext = 176;
	public const ConsoleKey MediaPrevious = 177;
	public const ConsoleKey MediaStop = 178;
	public const ConsoleKey MediaPlay = 179;
	public const ConsoleKey LaunchMail = 180;
	public const ConsoleKey LaunchMediaSelect = 181;
	public const ConsoleKey LaunchApp1 = 182;
	public const ConsoleKey LaunchApp2 = 183;
	public const ConsoleKey Oem1 = 186;
	public const ConsoleKey OemPlus = 187;
	public const ConsoleKey OemComma = 188;
	public const ConsoleKey OemMinus = 189;
	public const ConsoleKey OemPeriod = 190;
	public const ConsoleKey Oem2 = 191;
	public const ConsoleKey Oem3 = 192;
	public const ConsoleKey Oem4 = 219;
	public const ConsoleKey Oem5 = 220;
	public const ConsoleKey Oem6 = 221;
	public const ConsoleKey Oem7 = 222;
	public const ConsoleKey Oem8 = 223;
	public const ConsoleKey Oem102 = 226;
	public const ConsoleKey Process = 229;
	public const ConsoleKey Packet = 231;
	public const ConsoleKey Attention = 246;
	public const ConsoleKey CrSel = 247;
	public const ConsoleKey ExSel = 248;
	public const ConsoleKey EraseEndOfFile = 249;
	public const ConsoleKey Play = 250;
	public const ConsoleKey Zoom = 251;
	public const ConsoleKey NoName = 252;
	public const ConsoleKey Pa1 = 253;
	public const ConsoleKey OemClear = 254;

}

public struct ConsoleKeyInfo // TypeDefIndex: 190
{
	private char _keyChar; 
	private ConsoleKey _key; 
	private ConsoleModifiers _mods; 

	public char KeyChar { get; }
	public ConsoleKey Key { get; }


	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	public char get_KeyChar() { }

	public ConsoleKey get_Key() { }

	public override bool Equals(object value) { }

	public bool Equals(ConsoleKeyInfo obj) { }

	public override int GetHashCode() { }

}

public enum ConsoleModifiers // TypeDefIndex: 191
{
	public int value__; 
	public const ConsoleModifiers Alt = 1;
	public const ConsoleModifiers Shift = 2;
	public const ConsoleModifiers Control = 4;

}

public enum ConsoleSpecialKey // TypeDefIndex: 192
{
	public int value__; 
	public const ConsoleSpecialKey ControlC = 0;
	public const ConsoleSpecialKey ControlBreak = 1;

}

public static class Console // TypeDefIndex: 350
{
	internal static TextWriter stdout; 
	private static TextWriter stderr; 
	private static TextReader stdin; 
	private static Encoding inputEncoding; 
	private static Encoding outputEncoding; 
	private static ConsoleCancelEventHandler cancel_event; 
	private static readonly Console.InternalCancelHandler cancel_handler; 

	public static TextWriter Error { get; }
	public static TextWriter Out { get; }
	public static Encoding InputEncoding { get; }
	public static Encoding OutputEncoding { get; set; }
	public static ConsoleColor BackgroundColor { get; set; }
	public static int BufferWidth { get; }
	public static int CursorLeft { set; }
	public static int CursorTop { get; set; }
	public static ConsoleColor ForegroundColor { get; set; }
	public static bool KeyAvailable { get; }


	private static void .cctor() { }

	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	public static TextWriter get_Error() { }

	public static TextWriter get_Out() { }

	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	public static Stream OpenStandardError(int bufferSize) { }

	public static Stream OpenStandardInput(int bufferSize) { }

	public static Stream OpenStandardOutput(int bufferSize) { }

	public static void SetOut(TextWriter newOut) { }

	public static void Write(string value) { }

	public static void WriteLine(object value) { }

	public static void WriteLine(string value) { }

	public static Encoding get_InputEncoding() { }

	public static Encoding get_OutputEncoding() { }

	public static void set_OutputEncoding(Encoding value) { }

	public static ConsoleColor get_BackgroundColor() { }

	public static void set_BackgroundColor(ConsoleColor value) { }

	public static int get_BufferWidth() { }

	public static void set_CursorLeft(int value) { }

	public static int get_CursorTop() { }

	public static void set_CursorTop(int value) { }

	public static ConsoleColor get_ForegroundColor() { }

	public static void set_ForegroundColor(ConsoleColor value) { }

	public static bool get_KeyAvailable() { }

	public static ConsoleKeyInfo ReadKey() { }

	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	internal static void DoConsoleCancelEvent() { }

}

private class Console.WindowsConsole // TypeDefIndex: 351
{
	public static bool ctrlHandlerAdded; 
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; 


	private static extern int GetConsoleCP() { }

	private static extern int GetConsoleOutputCP() { }

	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	public static int GetInputCodePage() { }

	public static int GetOutputCodePage() { }

	private static void .cctor() { }

}

private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{

	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(int keyCode) { }

	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 353
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

internal static class ConsoleDriver // TypeDefIndex: 354
{
	internal static IConsoleDriver driver; 
	private static bool is_console; 
	private static bool called_isatty; 

	public static ConsoleColor BackgroundColor { get; set; }
	public static int BufferWidth { get; }
	public static int CursorLeft { set; }
	public static int CursorTop { get; set; }
	public static bool KeyAvailable { get; }
	public static ConsoleColor ForegroundColor { get; set; }
	public static bool IsConsole { get; }


	private static void .cctor() { }

	private static IConsoleDriver CreateNullConsoleDriver() { }

	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	public static ConsoleColor get_BackgroundColor() { }

	public static void set_BackgroundColor(ConsoleColor value) { }

	public static int get_BufferWidth() { }

	public static void set_CursorLeft(int value) { }

	public static int get_CursorTop() { }

	public static void set_CursorTop(int value) { }

	public static bool get_KeyAvailable() { }

	public static ConsoleColor get_ForegroundColor() { }

	public static void set_ForegroundColor(ConsoleColor value) { }

	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	public static bool get_IsConsole() { }

	private static bool Isatty(IntPtr handle) { }

	internal static int InternalKeyAvailable(int ms_timeout) { }

	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	internal static bool SetEcho(bool wantEcho) { }

}

internal struct ConsoleScreenBufferInfo // TypeDefIndex: 426
{
	public Coord Size; 
	public Coord CursorPosition; 
	public short Attribute; 
	public SmallRect Window; 
	public Coord MaxWindowSize; 

}

public class ConsoleSystem // TypeDefIndex: 6879
{

public class ConsoleSystem
	public static bool HasChanges; 
	public static Func<bool> ClientCanRunAdminCommands; 
	public static Func<string, bool> OnSendToServer; 
	[CompilerGeneratedAttribute] 
	private static Action<string, string> OnReplicatedVarChanged; 
	public static string LastError; 
	public static ConsoleSystem.Arg CurrentArgs; 


	public static void UpdateValuesFromCommandLine() { }

	internal static bool SendToServer(string command) { }

	[CompilerGeneratedAttribute] 
	public static void add_OnReplicatedVarChanged(Action<string, string> value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_OnReplicatedVarChanged(Action<string, string> value) { }

	public static void RunFile(ConsoleSystem.Option options, string strFile) { }

	public static string Run(ConsoleSystem.Option options, string strCommand, object[] args) { }

	private static bool Internal(ConsoleSystem.Arg arg) { }

	public static string BuildCommand(string strCommand, object[] args) { }

	public static string SaveToConfigString(bool bServer) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class ConsoleSystem.Arg // TypeDefIndex: 6880
{
	public ConsoleSystem.Option Option; 
	public ConsoleSystem.Command cmd; 
	public string FullString; 
	public string[] Args; 
	public bool Invalid; 
	public string Reply; 

	public bool IsClientside { get; }
	public bool IsServerside { get; }
	public Connection Connection { get; }
	public bool IsConnectionAdmin { get; }
	public bool IsAdmin { get; }
	public bool IsRcon { get; }


	public bool get_IsClientside() { }

	public bool get_IsServerside() { }

	public Connection get_Connection() { }

	public bool get_IsConnectionAdmin() { }

	public bool get_IsAdmin() { }

	public bool get_IsRcon() { }

	internal void .ctor(ConsoleSystem.Option options, string rconCommand) { }

	internal void BuildCommand(string command) { }

	internal bool HasPermission() { }

	internal bool CanSeeInFind(ConsoleSystem.Command command) { }

	public void ReplyWith(string strValue) { }

	public void ReplyWith(object obj) { }

	public bool HasArgs(int iMinimum = 1) { }

	public bool HasArg(string value) { }

	public string GetString(int iArg, string def = "") { }

	public int GetInt(int iArg, int def = 0) { }

	public ulong GetULong(int iArg, ulong def = 0) { }

	public bool TryGetUInt(int iArg, out uint value) { }

	public uint GetUInt(int iArg, uint def = 0) { }

	public ulong GetUInt64(int iArg, ulong def = 0) { }

	public float GetFloat(int iArg, float def = 0) { }

	public bool GetBool(int iArg, bool def = False) { }

	public long GetTimestamp(int iArg, long def = 0) { }

	public long GetTicks(int iArg, long def = 0) { }

	public void ReplyWithObject(object rval) { }

	public Vector3 GetVector3(int iArg, Vector3 def) { }

	public Color GetColor(int iArg, Color def) { }

}

public class ConsoleSystem.Factory : Attribute // TypeDefIndex: 6881
{
	public string Name; 


	public void .ctor(string systemName) { }

}

public class ConsoleSystem.Command // TypeDefIndex: 6882
{
	public string Name; 
	public string Parent; 
	public string FullName; 
	public Func<string> GetOveride; 
	public Action<string> SetOveride; 
	public Action<ConsoleSystem.Arg> Call; 
	public bool Variable; 
	public string Default; 
	public bool Saved; 
	public bool ServerAdmin; 
	public bool ServerUser; 
	public bool Replicated; 
	public bool ShowInAdminUI; 
	public bool ClientAdmin; 
	public bool Client; 
	public bool ClientInfo; 
	public bool AllowRunFromServer; 
	public string Description; 
	public string Arguments; 
	[CompilerGeneratedAttribute] 
	private Action<ConsoleSystem.Command> OnValueChanged; 

	public bool Server { get; }
	public string String { get; }
	public int AsInt { get; }
	public float AsFloat { get; }
	public bool AsBool { get; }
	public Vector3 AsVector3 { get; }


	public bool get_Server() { }

	[CompilerGeneratedAttribute] 
	public void add_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	public void .ctor() { }

	private void ValueChanged() { }

	private void DefaultCall(ConsoleSystem.Arg arg) { }

	public string get_String() { }

	public int get_AsInt() { }

	public float get_AsFloat() { }

	public bool get_AsBool() { }

	public Vector3 get_AsVector3() { }

	public void Set(string value) { }

	public void Set(float f) { }

	public void Set(bool val) { }

}

public static class ConsoleSystem.Index // TypeDefIndex: 6885
{
	private static readonly Memoized<string, string> WithGlobal; 
	private static readonly Memoized<string, string> WithoutGlobal; 
	[CompilerGeneratedAttribute] 
	private static ConsoleSystem.Command[] <All>k__BackingField; 

	public static ConsoleSystem.Command[] All { get; set; }


	public static void Initialize(ConsoleSystem.Command[] Commands) { }

	public static void Reset() { }

	[CompilerGeneratedAttribute] 
	public static ConsoleSystem.Command[] get_All() { }

	[CompilerGeneratedAttribute] 
	private static void set_All(ConsoleSystem.Command[] value) { }

	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Server // TypeDefIndex: 6886
{
	public static Dictionary<string, ConsoleSystem.Command> Dict; 
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; 
	public static List<ConsoleSystem.Command> Replicated; 


	public static ConsoleSystem.Command Find(string strName) { }

	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Client // TypeDefIndex: 6887
{
	public static Dictionary<string, ConsoleSystem.Command> Dict; 
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; 


	public static ConsoleSystem.Command Find(string strName) { }

	private static void .cctor() { }

}

private sealed class ConsoleSystem.Index.<>c // TypeDefIndex: 6888
{
	public static readonly ConsoleSystem.Index.<>c <>9; 
	public static Action<ConsoleSystem.Command> <>9__4_1; 
	public static Action<string, bool> <>9__4_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Initialize>b__4_1(ConsoleSystem.Command command) { }

	internal void <Initialize>b__4_0(string strCommand, bool pressed) { }

	internal string <.cctor>b__10_0(string s) { }

	internal string <.cctor>b__10_1(string s) { }

}

public struct ConsoleSystem.Option // TypeDefIndex: 6889
{
	[CompilerGeneratedAttribute] 
	private bool <IsServer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsClient>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <ForwardtoServerOnMissing>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <PrintOutput>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsUnrestricted>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <FromRcon>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsFromServer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Connection <Connection>k__BackingField; 

	public static ConsoleSystem.Option Unrestricted { get; }
	public static ConsoleSystem.Option Client { get; }
	public static ConsoleSystem.Option Server { get; }
	public bool IsServer { get; set; }
	public bool IsClient { get; set; }
	public bool ForwardtoServerOnMissing { get; set; }
	public bool PrintOutput { get; set; }
	public bool IsUnrestricted { get; set; }
	public bool FromRcon { get; set; }
	public bool IsFromServer { get; set; }
	public Connection Connection { get; set; }


	public static ConsoleSystem.Option get_Unrestricted() { }

	public static ConsoleSystem.Option get_Client() { }

	public static ConsoleSystem.Option get_Server() { }

	[CompilerGeneratedAttribute] 
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] 
	public void set_IsServer(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsClient() { }

	[CompilerGeneratedAttribute] 
	public void set_IsClient(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_ForwardtoServerOnMissing() { }

	[CompilerGeneratedAttribute] 
	public void set_ForwardtoServerOnMissing(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_PrintOutput() { }

	[CompilerGeneratedAttribute] 
	public void set_PrintOutput(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsUnrestricted() { }

	[CompilerGeneratedAttribute] 
	public void set_IsUnrestricted(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_FromRcon() { }

	[CompilerGeneratedAttribute] 
	public void set_FromRcon(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsFromServer() { }

	[CompilerGeneratedAttribute] 
	public void set_IsFromServer(bool value) { }

	[CompilerGeneratedAttribute] 
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] 
	public void set_Connection(Connection value) { }

	public ConsoleSystem.Option Quiet() { }

	public ConsoleSystem.Option FromServer() { }

	public ConsoleSystem.Option FromConnection(Connection connection) { }

}

private sealed class ConsoleSystem.<>c // TypeDefIndex: 6890
{
	public static readonly ConsoleSystem.<>c <>9; 
	public static Func<ConsoleSystem.Command, bool> <>9__21_0; 
	public static Func<ConsoleSystem.Command, bool> <>9__21_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <SaveToConfigString>b__21_0(ConsoleSystem.Command x) { }

	internal bool <SaveToConfigString>b__21_1(ConsoleSystem.Command x) { }

}

public class ConsoleVar : Attribute // TypeDefIndex: 6891
{
	public string Name; 
	public bool ClientAdmin; 
	public bool ServerAdmin; 
	public bool ServerUser; 
	public bool Saved; 
	public string Help; 
	public bool ClientInfo; 
	public bool Replicated; 
	public bool Clientside; 
	public bool Serverside; 
	public bool EditorOnly; 
	public bool AllowRunFromServer; 
	public string Default; 
	public string[] PreprocessorConditions; 
	public bool ShowInAdminUI; 


	public void .ctor() { }

}

public class ConsoleGen // TypeDefIndex: 8300
{
	public static ConsoleSystem.Command[] All; 


	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class ConsoleGen.<>c // TypeDefIndex: 8301
{
	public static readonly ConsoleGen.<>c <>9; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <.cctor>b__2_0() { }

	internal void <.cctor>b__2_1(string str) { }

	internal string <.cctor>b__2_2() { }

	internal void <.cctor>b__2_3(string str) { }

	internal string <.cctor>b__2_4() { }

	internal void <.cctor>b__2_5(string str) { }

	internal string <.cctor>b__2_6() { }

	internal void <.cctor>b__2_7(string str) { }

	internal string <.cctor>b__2_8() { }

	internal void <.cctor>b__2_9(string str) { }

	internal string <.cctor>b__2_10() { }

	internal void <.cctor>b__2_11(string str) { }

	internal string <.cctor>b__2_12() { }

	internal void <.cctor>b__2_13(string str) { }

	internal string <.cctor>b__2_14() { }

	internal void <.cctor>b__2_15(string str) { }

	internal string <.cctor>b__2_16() { }

	internal void <.cctor>b__2_17(string str) { }

	internal string <.cctor>b__2_18() { }

	internal void <.cctor>b__2_19(string str) { }

	internal string <.cctor>b__2_20() { }

	internal void <.cctor>b__2_21(string str) { }

	internal string <.cctor>b__2_22() { }

	internal void <.cctor>b__2_23(string str) { }

	internal string <.cctor>b__2_24() { }

	internal void <.cctor>b__2_25(string str) { }

	internal string <.cctor>b__2_26() { }

	internal void <.cctor>b__2_27(string str) { }

	internal string <.cctor>b__2_28() { }

	internal void <.cctor>b__2_29(string str) { }

	internal string <.cctor>b__2_30() { }

	internal void <.cctor>b__2_31(string str) { }

	internal string <.cctor>b__2_32() { }

	internal void <.cctor>b__2_33(string str) { }

	internal string <.cctor>b__2_34() { }

	internal void <.cctor>b__2_35(string str) { }

	internal string <.cctor>b__2_36() { }

	internal void <.cctor>b__2_37(string str) { }

	internal string <.cctor>b__2_38() { }

	internal void <.cctor>b__2_39(string str) { }

	internal string <.cctor>b__2_40() { }

	internal void <.cctor>b__2_41(string str) { }

	internal string <.cctor>b__2_42() { }

	internal void <.cctor>b__2_43(string str) { }

	internal string <.cctor>b__2_44() { }

	internal void <.cctor>b__2_45(string str) { }

	internal string <.cctor>b__2_46() { }

	internal void <.cctor>b__2_47(string str) { }

	internal string <.cctor>b__2_48() { }

	internal void <.cctor>b__2_49(string str) { }

	internal string <.cctor>b__2_50() { }

	internal void <.cctor>b__2_51(string str) { }

	internal string <.cctor>b__2_52() { }

	internal void <.cctor>b__2_53(string str) { }

	internal string <.cctor>b__2_54() { }

	internal void <.cctor>b__2_55(string str) { }

	internal string <.cctor>b__2_56() { }

	internal void <.cctor>b__2_57(string str) { }

	internal string <.cctor>b__2_58() { }

	internal void <.cctor>b__2_59(string str) { }

	internal string <.cctor>b__2_60() { }

	internal void <.cctor>b__2_61(string str) { }

	internal string <.cctor>b__2_62() { }

	internal void <.cctor>b__2_63(string str) { }

	internal string <.cctor>b__2_64() { }

	internal void <.cctor>b__2_65(string str) { }

	internal string <.cctor>b__2_66() { }

	internal void <.cctor>b__2_67(string str) { }

	internal string <.cctor>b__2_68() { }

	internal void <.cctor>b__2_69(string str) { }

	internal string <.cctor>b__2_70() { }

	internal void <.cctor>b__2_71(string str) { }

	internal string <.cctor>b__2_72() { }

	internal void <.cctor>b__2_73(string str) { }

	internal string <.cctor>b__2_74() { }

	internal void <.cctor>b__2_75(string str) { }

	internal string <.cctor>b__2_76() { }

	internal void <.cctor>b__2_77(string str) { }

	internal string <.cctor>b__2_78() { }

	internal void <.cctor>b__2_79(string str) { }

	internal string <.cctor>b__2_80() { }

	internal void <.cctor>b__2_81(string str) { }

	internal string <.cctor>b__2_82() { }

	internal void <.cctor>b__2_83(string str) { }

	internal string <.cctor>b__2_84() { }

	internal void <.cctor>b__2_85(string str) { }

	internal string <.cctor>b__2_86() { }

	internal void <.cctor>b__2_87(string str) { }

	internal string <.cctor>b__2_88() { }

	internal void <.cctor>b__2_89(string str) { }

	internal string <.cctor>b__2_90() { }

	internal void <.cctor>b__2_91(string str) { }

	internal string <.cctor>b__2_92() { }

	internal void <.cctor>b__2_93(string str) { }

	internal string <.cctor>b__2_94() { }

	internal void <.cctor>b__2_95(string str) { }

	internal string <.cctor>b__2_96() { }

	internal void <.cctor>b__2_97(string str) { }

	internal string <.cctor>b__2_98() { }

	internal void <.cctor>b__2_99(string str) { }

	internal string <.cctor>b__2_100() { }

	internal void <.cctor>b__2_101(string str) { }

	internal string <.cctor>b__2_102() { }

	internal void <.cctor>b__2_103(string str) { }

	internal string <.cctor>b__2_104() { }

	internal void <.cctor>b__2_105(string str) { }

	internal string <.cctor>b__2_106() { }

	internal void <.cctor>b__2_107(string str) { }

	internal string <.cctor>b__2_108() { }

	internal void <.cctor>b__2_109(string str) { }

	internal string <.cctor>b__2_110() { }

	internal void <.cctor>b__2_111(string str) { }

	internal string <.cctor>b__2_112() { }

	internal void <.cctor>b__2_113(string str) { }

	internal void <.cctor>b__2_114(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_115(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_116(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_117(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_118() { }

	internal void <.cctor>b__2_119(string str) { }

	internal string <.cctor>b__2_120() { }

	internal void <.cctor>b__2_121(string str) { }

	internal string <.cctor>b__2_122() { }

	internal void <.cctor>b__2_123(string str) { }

	internal string <.cctor>b__2_124() { }

	internal void <.cctor>b__2_125(string str) { }

	internal string <.cctor>b__2_126() { }

	internal void <.cctor>b__2_127(string str) { }

	internal string <.cctor>b__2_128() { }

	internal void <.cctor>b__2_129(string str) { }

	internal string <.cctor>b__2_130() { }

	internal void <.cctor>b__2_131(string str) { }

	internal void <.cctor>b__2_132(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_133(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_134(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_135(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_136() { }

	internal void <.cctor>b__2_137(string str) { }

	internal string <.cctor>b__2_138() { }

	internal void <.cctor>b__2_139(string str) { }

	internal string <.cctor>b__2_140() { }

	internal void <.cctor>b__2_141(string str) { }

	internal void <.cctor>b__2_142(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_143(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_144() { }

	internal void <.cctor>b__2_145(string str) { }

	internal string <.cctor>b__2_146() { }

	internal void <.cctor>b__2_147(string str) { }

	internal string <.cctor>b__2_148() { }

	internal void <.cctor>b__2_149(string str) { }

	internal void <.cctor>b__2_150(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_151(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_152() { }

	internal void <.cctor>b__2_153(string str) { }

	internal string <.cctor>b__2_154() { }

	internal void <.cctor>b__2_155(string str) { }

	internal string <.cctor>b__2_156() { }

	internal void <.cctor>b__2_157(string str) { }

	internal string <.cctor>b__2_158() { }

	internal void <.cctor>b__2_159(string str) { }

	internal string <.cctor>b__2_160() { }

	internal void <.cctor>b__2_161(string str) { }

	internal string <.cctor>b__2_162() { }

	internal void <.cctor>b__2_163(string str) { }

	internal void <.cctor>b__2_164(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_165() { }

	internal void <.cctor>b__2_166(string str) { }

	internal string <.cctor>b__2_167() { }

	internal void <.cctor>b__2_168(string str) { }

	internal string <.cctor>b__2_169() { }

	internal void <.cctor>b__2_170(string str) { }

	internal string <.cctor>b__2_171() { }

	internal void <.cctor>b__2_172(string str) { }

	internal string <.cctor>b__2_173() { }

	internal void <.cctor>b__2_174(string str) { }

	internal string <.cctor>b__2_175() { }

	internal void <.cctor>b__2_176(string str) { }

	internal string <.cctor>b__2_177() { }

	internal void <.cctor>b__2_178(string str) { }

	internal string <.cctor>b__2_179() { }

	internal void <.cctor>b__2_180(string str) { }

	internal string <.cctor>b__2_181() { }

	internal void <.cctor>b__2_182(string str) { }

	internal string <.cctor>b__2_183() { }

	internal void <.cctor>b__2_184(string str) { }

	internal string <.cctor>b__2_185() { }

	internal void <.cctor>b__2_186(string str) { }

	internal string <.cctor>b__2_187() { }

	internal void <.cctor>b__2_188(string str) { }

	internal void <.cctor>b__2_189(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_190(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_191() { }

	internal void <.cctor>b__2_192(string str) { }

	internal string <.cctor>b__2_193() { }

	internal void <.cctor>b__2_194(string str) { }

	internal string <.cctor>b__2_195() { }

	internal void <.cctor>b__2_196(string str) { }

	internal void <.cctor>b__2_197(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_198(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_199() { }

	internal void <.cctor>b__2_200(string str) { }

	internal string <.cctor>b__2_201() { }

	internal void <.cctor>b__2_202(string str) { }

	internal string <.cctor>b__2_203() { }

	internal void <.cctor>b__2_204(string str) { }

	internal string <.cctor>b__2_205() { }

	internal void <.cctor>b__2_206(string str) { }

	internal string <.cctor>b__2_207() { }

	internal void <.cctor>b__2_208(string str) { }

	internal string <.cctor>b__2_209() { }

	internal void <.cctor>b__2_210(string str) { }

	internal void <.cctor>b__2_211(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_212(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_213(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_214() { }

	internal void <.cctor>b__2_215(string str) { }

	internal string <.cctor>b__2_216() { }

	internal void <.cctor>b__2_217(string str) { }

	internal string <.cctor>b__2_218() { }

	internal void <.cctor>b__2_219(string str) { }

	internal void <.cctor>b__2_220(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_221() { }

	internal void <.cctor>b__2_222(string str) { }

	internal void <.cctor>b__2_223(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_224(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_225(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_226(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_227(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_228(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_229() { }

	internal void <.cctor>b__2_230(string str) { }

	internal string <.cctor>b__2_231() { }

	internal void <.cctor>b__2_232(string str) { }

	internal string <.cctor>b__2_233() { }

	internal void <.cctor>b__2_234(string str) { }

	internal string <.cctor>b__2_235() { }

	internal void <.cctor>b__2_236(string str) { }

	internal string <.cctor>b__2_237() { }

	internal void <.cctor>b__2_238(string str) { }

	internal string <.cctor>b__2_239() { }

	internal void <.cctor>b__2_240(string str) { }

	internal string <.cctor>b__2_241() { }

	internal void <.cctor>b__2_242(string str) { }

	internal string <.cctor>b__2_243() { }

	internal void <.cctor>b__2_244(string str) { }

	internal string <.cctor>b__2_245() { }

	internal void <.cctor>b__2_246(string str) { }

	internal string <.cctor>b__2_247() { }

	internal void <.cctor>b__2_248(string str) { }

	internal string <.cctor>b__2_249() { }

	internal void <.cctor>b__2_250(string str) { }

	internal void <.cctor>b__2_251(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_252() { }

	internal void <.cctor>b__2_253(string str) { }

	internal string <.cctor>b__2_254() { }

	internal void <.cctor>b__2_255(string str) { }

	internal string <.cctor>b__2_256() { }

	internal void <.cctor>b__2_257(string str) { }

	internal void <.cctor>b__2_258(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_259(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_260(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_261() { }

	internal void <.cctor>b__2_262(string str) { }

	internal string <.cctor>b__2_263() { }

	internal void <.cctor>b__2_264(string str) { }

	internal string <.cctor>b__2_265() { }

	internal void <.cctor>b__2_266(string str) { }

	internal void <.cctor>b__2_267(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_268(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_269() { }

	internal void <.cctor>b__2_270(string str) { }

	internal string <.cctor>b__2_271() { }

	internal void <.cctor>b__2_272(string str) { }

	internal string <.cctor>b__2_273() { }

	internal void <.cctor>b__2_274(string str) { }

	internal string <.cctor>b__2_275() { }

	internal void <.cctor>b__2_276(string str) { }

	internal string <.cctor>b__2_277() { }

	internal void <.cctor>b__2_278(string str) { }

	internal string <.cctor>b__2_279() { }

	internal void <.cctor>b__2_280(string str) { }

	internal string <.cctor>b__2_281() { }

	internal void <.cctor>b__2_282(string str) { }

	internal string <.cctor>b__2_283() { }

	internal void <.cctor>b__2_284(string str) { }

	internal string <.cctor>b__2_285() { }

	internal void <.cctor>b__2_286(string str) { }

	internal string <.cctor>b__2_287() { }

	internal void <.cctor>b__2_288(string str) { }

	internal string <.cctor>b__2_289() { }

	internal void <.cctor>b__2_290(string str) { }

	internal string <.cctor>b__2_291() { }

	internal void <.cctor>b__2_292(string str) { }

	internal void <.cctor>b__2_293(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_294(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_295() { }

	internal void <.cctor>b__2_296(string str) { }

	internal void <.cctor>b__2_297(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_298(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_299(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_300(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_301(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_302() { }

	internal void <.cctor>b__2_303(string str) { }

	internal void <.cctor>b__2_304(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_305(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_306(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_307() { }

	internal void <.cctor>b__2_308(string str) { }

	internal void <.cctor>b__2_309(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_310() { }

	internal void <.cctor>b__2_311(string str) { }

	internal void <.cctor>b__2_312(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_313() { }

	internal void <.cctor>b__2_314(string str) { }

	internal void <.cctor>b__2_315(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_316() { }

	internal void <.cctor>b__2_317(string str) { }

	internal void <.cctor>b__2_318(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_319(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_320() { }

	internal void <.cctor>b__2_321(string str) { }

	internal string <.cctor>b__2_322() { }

	internal void <.cctor>b__2_323(string str) { }

	internal string <.cctor>b__2_324() { }

	internal void <.cctor>b__2_325(string str) { }

	internal string <.cctor>b__2_326() { }

	internal void <.cctor>b__2_327(string str) { }

	internal string <.cctor>b__2_328() { }

	internal void <.cctor>b__2_329(string str) { }

	internal string <.cctor>b__2_330() { }

	internal void <.cctor>b__2_331(string str) { }

	internal string <.cctor>b__2_332() { }

	internal void <.cctor>b__2_333(string str) { }

	internal string <.cctor>b__2_334() { }

	internal void <.cctor>b__2_335(string str) { }

	internal string <.cctor>b__2_336() { }

	internal void <.cctor>b__2_337(string str) { }

	internal string <.cctor>b__2_338() { }

	internal void <.cctor>b__2_339(string str) { }

	internal string <.cctor>b__2_340() { }

	internal void <.cctor>b__2_341(string str) { }

	internal void <.cctor>b__2_342(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_343(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_344(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_345(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_346(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_347(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_348() { }

	internal void <.cctor>b__2_349(string str) { }

	internal string <.cctor>b__2_350() { }

	internal void <.cctor>b__2_351(string str) { }

	internal string <.cctor>b__2_352() { }

	internal void <.cctor>b__2_353(string str) { }

	internal void <.cctor>b__2_354(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_355() { }

	internal void <.cctor>b__2_356(string str) { }

	internal string <.cctor>b__2_357() { }

	internal void <.cctor>b__2_358(string str) { }

	internal string <.cctor>b__2_359() { }

	internal void <.cctor>b__2_360(string str) { }

	internal void <.cctor>b__2_361(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_362() { }

	internal void <.cctor>b__2_363(string str) { }

	internal string <.cctor>b__2_364() { }

	internal void <.cctor>b__2_365(string str) { }

	internal string <.cctor>b__2_366() { }

	internal void <.cctor>b__2_367(string str) { }

	internal string <.cctor>b__2_368() { }

	internal void <.cctor>b__2_369(string str) { }

	internal void <.cctor>b__2_370(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_371(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_372(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_373(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_374(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_375(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_376() { }

	internal void <.cctor>b__2_377(string str) { }

	internal string <.cctor>b__2_378() { }

	internal void <.cctor>b__2_379(string str) { }

	internal string <.cctor>b__2_380() { }

	internal void <.cctor>b__2_381(string str) { }

	internal string <.cctor>b__2_382() { }

	internal void <.cctor>b__2_383(string str) { }

	internal string <.cctor>b__2_384() { }

	internal void <.cctor>b__2_385(string str) { }

	internal string <.cctor>b__2_386() { }

	internal void <.cctor>b__2_387(string str) { }

	internal void <.cctor>b__2_388(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_389(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_390(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_391(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_392(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_393() { }

	internal void <.cctor>b__2_394(string str) { }

	internal void <.cctor>b__2_395(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_396(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_397() { }

	internal void <.cctor>b__2_398(string str) { }

	internal string <.cctor>b__2_399() { }

	internal void <.cctor>b__2_400(string str) { }

	internal string <.cctor>b__2_401() { }

	internal void <.cctor>b__2_402(string str) { }

	internal void <.cctor>b__2_403(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_404() { }

	internal void <.cctor>b__2_405(string str) { }

	internal string <.cctor>b__2_406() { }

	internal void <.cctor>b__2_407(string str) { }

	internal void <.cctor>b__2_408(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_409(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_410(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_411() { }

	internal void <.cctor>b__2_412(string str) { }

	internal void <.cctor>b__2_413(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_414() { }

	internal void <.cctor>b__2_415(string str) { }

	internal void <.cctor>b__2_416(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_417() { }

	internal void <.cctor>b__2_418(string str) { }

	internal string <.cctor>b__2_419() { }

	internal void <.cctor>b__2_420(string str) { }

	internal void <.cctor>b__2_421(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_422() { }

	internal void <.cctor>b__2_423(string str) { }

	internal string <.cctor>b__2_424() { }

	internal void <.cctor>b__2_425(string str) { }

	internal string <.cctor>b__2_426() { }

	internal void <.cctor>b__2_427(string str) { }

	internal string <.cctor>b__2_428() { }

	internal void <.cctor>b__2_429(string str) { }

	internal void <.cctor>b__2_430(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_431() { }

	internal void <.cctor>b__2_432(string str) { }

	internal string <.cctor>b__2_433() { }

	internal void <.cctor>b__2_434(string str) { }

	internal void <.cctor>b__2_435(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_436(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_437(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_438(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_439(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_440(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_441(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_442(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_443() { }

	internal void <.cctor>b__2_444(string str) { }

	internal void <.cctor>b__2_445(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_446(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_447() { }

	internal void <.cctor>b__2_448(string str) { }

	internal void <.cctor>b__2_449(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_450(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_451() { }

	internal void <.cctor>b__2_452(string str) { }

	internal string <.cctor>b__2_453() { }

	internal void <.cctor>b__2_454(string str) { }

	internal string <.cctor>b__2_455() { }

	internal void <.cctor>b__2_456(string str) { }

	internal void <.cctor>b__2_457(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_458() { }

	internal void <.cctor>b__2_459(string str) { }

	internal string <.cctor>b__2_460() { }

	internal void <.cctor>b__2_461(string str) { }

	internal string <.cctor>b__2_462() { }

	internal void <.cctor>b__2_463(string str) { }

	internal string <.cctor>b__2_464() { }

	internal void <.cctor>b__2_465(string str) { }

	internal string <.cctor>b__2_466() { }

	internal void <.cctor>b__2_467(string str) { }

	internal string <.cctor>b__2_468() { }

	internal void <.cctor>b__2_469(string str) { }

	internal string <.cctor>b__2_470() { }

	internal void <.cctor>b__2_471(string str) { }

	internal string <.cctor>b__2_472() { }

	internal void <.cctor>b__2_473(string str) { }

	internal string <.cctor>b__2_474() { }

	internal void <.cctor>b__2_475(string str) { }

	internal string <.cctor>b__2_476() { }

	internal void <.cctor>b__2_477(string str) { }

	internal string <.cctor>b__2_478() { }

	internal void <.cctor>b__2_479(string str) { }

	internal string <.cctor>b__2_480() { }

	internal void <.cctor>b__2_481(string str) { }

	internal void <.cctor>b__2_482(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_483(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_484(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_485(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_486(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_487(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_488(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_489(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_490(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_491(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_492(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_493(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_494(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_495(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_496() { }

	internal void <.cctor>b__2_497(string str) { }

	internal string <.cctor>b__2_498() { }

	internal void <.cctor>b__2_499(string str) { }

	internal string <.cctor>b__2_500() { }

	internal void <.cctor>b__2_501(string str) { }

	internal string <.cctor>b__2_502() { }

	internal void <.cctor>b__2_503(string str) { }

	internal string <.cctor>b__2_504() { }

	internal void <.cctor>b__2_505(string str) { }

	internal string <.cctor>b__2_506() { }

	internal void <.cctor>b__2_507(string str) { }

	internal string <.cctor>b__2_508() { }

	internal void <.cctor>b__2_509(string str) { }

	internal string <.cctor>b__2_510() { }

	internal void <.cctor>b__2_511(string str) { }

	internal void <.cctor>b__2_512(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_513() { }

	internal void <.cctor>b__2_514(string str) { }

	internal string <.cctor>b__2_515() { }

	internal void <.cctor>b__2_516(string str) { }

	internal void <.cctor>b__2_517(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_518() { }

	internal void <.cctor>b__2_519(string str) { }

	internal string <.cctor>b__2_520() { }

	internal void <.cctor>b__2_521(string str) { }

	internal string <.cctor>b__2_522() { }

	internal void <.cctor>b__2_523(string str) { }

	internal string <.cctor>b__2_524() { }

	internal void <.cctor>b__2_525(string str) { }

	internal void <.cctor>b__2_526(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_527() { }

	internal void <.cctor>b__2_528(string str) { }

	internal string <.cctor>b__2_529() { }

	internal void <.cctor>b__2_530(string str) { }

	internal string <.cctor>b__2_531() { }

	internal void <.cctor>b__2_532(string str) { }

	internal string <.cctor>b__2_533() { }

	internal void <.cctor>b__2_534(string str) { }

	internal string <.cctor>b__2_535() { }

	internal void <.cctor>b__2_536(string str) { }

	internal void <.cctor>b__2_537(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_538() { }

	internal void <.cctor>b__2_539(string str) { }

	internal string <.cctor>b__2_540() { }

	internal void <.cctor>b__2_541(string str) { }

	internal void <.cctor>b__2_542(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_543(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_544() { }

	internal void <.cctor>b__2_545(string str) { }

	internal void <.cctor>b__2_546(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_547() { }

	internal void <.cctor>b__2_548(string str) { }

	internal string <.cctor>b__2_549() { }

	internal void <.cctor>b__2_550(string str) { }

	internal string <.cctor>b__2_551() { }

	internal void <.cctor>b__2_552(string str) { }

	internal string <.cctor>b__2_553() { }

	internal void <.cctor>b__2_554(string str) { }

	internal void <.cctor>b__2_555(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_556() { }

	internal void <.cctor>b__2_557(string str) { }

	internal string <.cctor>b__2_558() { }

	internal void <.cctor>b__2_559(string str) { }

	internal string <.cctor>b__2_560() { }

	internal void <.cctor>b__2_561(string str) { }

	internal void <.cctor>b__2_562(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_563(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_564(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_565() { }

	internal void <.cctor>b__2_566(string str) { }

	internal string <.cctor>b__2_567() { }

	internal void <.cctor>b__2_568(string str) { }

	internal string <.cctor>b__2_569() { }

	internal void <.cctor>b__2_570(string str) { }

	internal string <.cctor>b__2_571() { }

	internal void <.cctor>b__2_572(string str) { }

	internal string <.cctor>b__2_573() { }

	internal void <.cctor>b__2_574(string str) { }

	internal string <.cctor>b__2_575() { }

	internal void <.cctor>b__2_576(string str) { }

	internal string <.cctor>b__2_577() { }

	internal void <.cctor>b__2_578(string str) { }

	internal void <.cctor>b__2_579(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_580() { }

	internal void <.cctor>b__2_581(string str) { }

	internal void <.cctor>b__2_582(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_583(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_584(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_585(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_586() { }

	internal void <.cctor>b__2_587(string str) { }

	internal string <.cctor>b__2_588() { }

	internal void <.cctor>b__2_589(string str) { }

	internal void <.cctor>b__2_590(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_591() { }

	internal void <.cctor>b__2_592(string str) { }

	internal void <.cctor>b__2_593(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_594() { }

	internal void <.cctor>b__2_595(string str) { }

	internal string <.cctor>b__2_596() { }

	internal void <.cctor>b__2_597(string str) { }

	internal string <.cctor>b__2_598() { }

	internal void <.cctor>b__2_599(string str) { }

	internal string <.cctor>b__2_600() { }

	internal void <.cctor>b__2_601(string str) { }

	internal string <.cctor>b__2_602() { }

	internal void <.cctor>b__2_603(string str) { }

	internal string <.cctor>b__2_604() { }

	internal void <.cctor>b__2_605(string str) { }

	internal string <.cctor>b__2_606() { }

	internal void <.cctor>b__2_607(string str) { }

	internal string <.cctor>b__2_608() { }

	internal void <.cctor>b__2_609(string str) { }

	internal string <.cctor>b__2_610() { }

	internal void <.cctor>b__2_611(string str) { }

	internal string <.cctor>b__2_612() { }

	internal void <.cctor>b__2_613(string str) { }

	internal string <.cctor>b__2_614() { }

	internal void <.cctor>b__2_615(string str) { }

	internal string <.cctor>b__2_616() { }

	internal void <.cctor>b__2_617(string str) { }

	internal string <.cctor>b__2_618() { }

	internal void <.cctor>b__2_619(string str) { }

	internal string <.cctor>b__2_620() { }

	internal void <.cctor>b__2_621(string str) { }

	internal void <.cctor>b__2_622(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_623(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_624() { }

	internal void <.cctor>b__2_625(string str) { }

	internal string <.cctor>b__2_626() { }

	internal void <.cctor>b__2_627(string str) { }

	internal void <.cctor>b__2_628(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_629() { }

	internal void <.cctor>b__2_630(string str) { }

	internal string <.cctor>b__2_631() { }

	internal void <.cctor>b__2_632(string str) { }

	internal string <.cctor>b__2_633() { }

	internal void <.cctor>b__2_634(string str) { }

	internal string <.cctor>b__2_635() { }

	internal void <.cctor>b__2_636(string str) { }

	internal string <.cctor>b__2_637() { }

	internal void <.cctor>b__2_638(string str) { }

	internal string <.cctor>b__2_639() { }

	internal void <.cctor>b__2_640(string str) { }

	internal string <.cctor>b__2_641() { }

	internal void <.cctor>b__2_642(string str) { }

	internal string <.cctor>b__2_643() { }

	internal void <.cctor>b__2_644(string str) { }

	internal string <.cctor>b__2_645() { }

	internal void <.cctor>b__2_646(string str) { }

	internal string <.cctor>b__2_647() { }

	internal void <.cctor>b__2_648(string str) { }

	internal string <.cctor>b__2_649() { }

	internal void <.cctor>b__2_650(string str) { }

	internal string <.cctor>b__2_651() { }

	internal void <.cctor>b__2_652(string str) { }

	internal string <.cctor>b__2_653() { }

	internal void <.cctor>b__2_654(string str) { }

	internal string <.cctor>b__2_655() { }

	internal void <.cctor>b__2_656(string str) { }

	internal string <.cctor>b__2_657() { }

	internal void <.cctor>b__2_658(string str) { }

	internal string <.cctor>b__2_659() { }

	internal void <.cctor>b__2_660(string str) { }

	internal string <.cctor>b__2_661() { }

	internal void <.cctor>b__2_662(string str) { }

	internal void <.cctor>b__2_663(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_664(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_665(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_666() { }

	internal void <.cctor>b__2_667(string str) { }

	internal void <.cctor>b__2_668(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_669() { }

	internal void <.cctor>b__2_670(string str) { }

	internal void <.cctor>b__2_671(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_672() { }

	internal void <.cctor>b__2_673(string str) { }

	internal string <.cctor>b__2_674() { }

	internal void <.cctor>b__2_675(string str) { }

	internal string <.cctor>b__2_676() { }

	internal void <.cctor>b__2_677(string str) { }

	internal string <.cctor>b__2_678() { }

	internal void <.cctor>b__2_679(string str) { }

	internal string <.cctor>b__2_680() { }

	internal void <.cctor>b__2_681(string str) { }

	internal string <.cctor>b__2_682() { }

	internal void <.cctor>b__2_683(string str) { }

	internal string <.cctor>b__2_684() { }

	internal void <.cctor>b__2_685(string str) { }

	internal string <.cctor>b__2_686() { }

	internal void <.cctor>b__2_687(string str) { }

	internal string <.cctor>b__2_688() { }

	internal void <.cctor>b__2_689(string str) { }

	internal string <.cctor>b__2_690() { }

	internal void <.cctor>b__2_691(string str) { }

	internal string <.cctor>b__2_692() { }

	internal void <.cctor>b__2_693(string str) { }

	internal string <.cctor>b__2_694() { }

	internal void <.cctor>b__2_695(string str) { }

	internal string <.cctor>b__2_696() { }

	internal void <.cctor>b__2_697(string str) { }

	internal string <.cctor>b__2_698() { }

	internal void <.cctor>b__2_699(string str) { }

	internal string <.cctor>b__2_700() { }

	internal void <.cctor>b__2_701(string str) { }

	internal string <.cctor>b__2_702() { }

	internal void <.cctor>b__2_703(string str) { }

	internal string <.cctor>b__2_704() { }

	internal void <.cctor>b__2_705(string str) { }

	internal string <.cctor>b__2_706() { }

	internal void <.cctor>b__2_707(string str) { }

	internal void <.cctor>b__2_708(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_709() { }

	internal void <.cctor>b__2_710(string str) { }

	internal string <.cctor>b__2_711() { }

	internal void <.cctor>b__2_712(string str) { }

	internal string <.cctor>b__2_713() { }

	internal void <.cctor>b__2_714(string str) { }

	internal string <.cctor>b__2_715() { }

	internal void <.cctor>b__2_716(string str) { }

	internal void <.cctor>b__2_717(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_718() { }

	internal void <.cctor>b__2_719(string str) { }

	internal string <.cctor>b__2_720() { }

	internal void <.cctor>b__2_721(string str) { }

	internal string <.cctor>b__2_722() { }

	internal void <.cctor>b__2_723(string str) { }

	internal string <.cctor>b__2_724() { }

	internal void <.cctor>b__2_725(string str) { }

	internal string <.cctor>b__2_726() { }

	internal void <.cctor>b__2_727(string str) { }

	internal string <.cctor>b__2_728() { }

	internal void <.cctor>b__2_729(string str) { }

	internal string <.cctor>b__2_730() { }

	internal void <.cctor>b__2_731(string str) { }

	internal string <.cctor>b__2_732() { }

	internal void <.cctor>b__2_733(string str) { }

	internal void <.cctor>b__2_734(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_735(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_736() { }

	internal void <.cctor>b__2_737(string str) { }

	internal string <.cctor>b__2_738() { }

	internal void <.cctor>b__2_739(string str) { }

	internal string <.cctor>b__2_740() { }

	internal void <.cctor>b__2_741(string str) { }

	internal string <.cctor>b__2_742() { }

	internal void <.cctor>b__2_743(string str) { }

	internal string <.cctor>b__2_744() { }

	internal void <.cctor>b__2_745(string str) { }

	internal string <.cctor>b__2_746() { }

	internal void <.cctor>b__2_747(string str) { }

	internal string <.cctor>b__2_748() { }

	internal void <.cctor>b__2_749(string str) { }

	internal void <.cctor>b__2_750(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_751(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_752() { }

	internal void <.cctor>b__2_753(string str) { }

	internal string <.cctor>b__2_754() { }

	internal void <.cctor>b__2_755(string str) { }

	internal void <.cctor>b__2_756(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_757(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_758(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_759(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_760(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_761(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_762(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_763() { }

	internal void <.cctor>b__2_764(string str) { }

	internal void <.cctor>b__2_765(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_766(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_767(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_768(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_769(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_770(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_771() { }

	internal void <.cctor>b__2_772(string str) { }

	internal void <.cctor>b__2_773(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_774(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_775(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_776(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_777(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_778(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_779(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_780(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_781() { }

	internal void <.cctor>b__2_782(string str) { }

	internal string <.cctor>b__2_783() { }

	internal void <.cctor>b__2_784(string str) { }

	internal string <.cctor>b__2_785() { }

	internal void <.cctor>b__2_786(string str) { }

	internal string <.cctor>b__2_787() { }

	internal void <.cctor>b__2_788(string str) { }

	internal string <.cctor>b__2_789() { }

	internal void <.cctor>b__2_790(string str) { }

	internal string <.cctor>b__2_791() { }

	internal void <.cctor>b__2_792(string str) { }

	internal string <.cctor>b__2_793() { }

	internal void <.cctor>b__2_794(string str) { }

	internal string <.cctor>b__2_795() { }

	internal void <.cctor>b__2_796(string str) { }

	internal string <.cctor>b__2_797() { }

	internal void <.cctor>b__2_798(string str) { }

	internal string <.cctor>b__2_799() { }

	internal void <.cctor>b__2_800(string str) { }

	internal string <.cctor>b__2_801() { }

	internal void <.cctor>b__2_802(string str) { }

	internal string <.cctor>b__2_803() { }

	internal void <.cctor>b__2_804(string str) { }

	internal void <.cctor>b__2_805(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_806(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_807(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_808(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_809(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_810() { }

	internal void <.cctor>b__2_811(string str) { }

	internal string <.cctor>b__2_812() { }

	internal void <.cctor>b__2_813(string str) { }

	internal void <.cctor>b__2_814(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_815() { }

	internal void <.cctor>b__2_816(string str) { }

	internal string <.cctor>b__2_817() { }

	internal void <.cctor>b__2_818(string str) { }

	internal string <.cctor>b__2_819() { }

	internal void <.cctor>b__2_820(string str) { }

	internal string <.cctor>b__2_821() { }

	internal void <.cctor>b__2_822(string str) { }

	internal string <.cctor>b__2_823() { }

	internal void <.cctor>b__2_824(string str) { }

	internal string <.cctor>b__2_825() { }

	internal void <.cctor>b__2_826(string str) { }

	internal string <.cctor>b__2_827() { }

	internal void <.cctor>b__2_828(string str) { }

	internal void <.cctor>b__2_829(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_830(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_831(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_832(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_833(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_834() { }

	internal void <.cctor>b__2_835(string str) { }

	internal string <.cctor>b__2_836() { }

	internal void <.cctor>b__2_837(string str) { }

	internal string <.cctor>b__2_838() { }

	internal void <.cctor>b__2_839(string str) { }

	internal string <.cctor>b__2_840() { }

	internal void <.cctor>b__2_841(string str) { }

	internal string <.cctor>b__2_842() { }

	internal void <.cctor>b__2_843(string str) { }

	internal string <.cctor>b__2_844() { }

	internal void <.cctor>b__2_845(string str) { }

	internal string <.cctor>b__2_846() { }

	internal void <.cctor>b__2_847(string str) { }

	internal string <.cctor>b__2_848() { }

	internal void <.cctor>b__2_849(string str) { }

	internal void <.cctor>b__2_850(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_851(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_852(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_853() { }

	internal void <.cctor>b__2_854(string str) { }

	internal string <.cctor>b__2_855() { }

	internal void <.cctor>b__2_856(string str) { }

	internal string <.cctor>b__2_857() { }

	internal void <.cctor>b__2_858(string str) { }

	internal string <.cctor>b__2_859() { }

	internal void <.cctor>b__2_860(string str) { }

	internal string <.cctor>b__2_861() { }

	internal void <.cctor>b__2_862(string str) { }

	internal void <.cctor>b__2_863(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_864() { }

	internal void <.cctor>b__2_865(string str) { }

	internal string <.cctor>b__2_866() { }

	internal void <.cctor>b__2_867(string str) { }

	internal string <.cctor>b__2_868() { }

	internal void <.cctor>b__2_869(string str) { }

	internal void <.cctor>b__2_870(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_871() { }

	internal void <.cctor>b__2_872(string str) { }

	internal string <.cctor>b__2_873() { }

	internal void <.cctor>b__2_874(string str) { }

	internal string <.cctor>b__2_875() { }

	internal void <.cctor>b__2_876(string str) { }

	internal string <.cctor>b__2_877() { }

	internal void <.cctor>b__2_878(string str) { }

	internal string <.cctor>b__2_879() { }

	internal void <.cctor>b__2_880(string str) { }

	internal string <.cctor>b__2_881() { }

	internal void <.cctor>b__2_882(string str) { }

	internal string <.cctor>b__2_883() { }

	internal void <.cctor>b__2_884(string str) { }

	internal string <.cctor>b__2_885() { }

	internal void <.cctor>b__2_886(string str) { }

	internal string <.cctor>b__2_887() { }

	internal void <.cctor>b__2_888(string str) { }

	internal string <.cctor>b__2_889() { }

	internal void <.cctor>b__2_890(string str) { }

	internal void <.cctor>b__2_891(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_892(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_893(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_894() { }

	internal void <.cctor>b__2_895(string str) { }

	internal string <.cctor>b__2_896() { }

	internal void <.cctor>b__2_897(string str) { }

	internal void <.cctor>b__2_898(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_899() { }

	internal void <.cctor>b__2_900(string str) { }

	internal string <.cctor>b__2_901() { }

	internal void <.cctor>b__2_902(string str) { }

	internal void <.cctor>b__2_903(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_904(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_905(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_906(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_907(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_908() { }

	internal void <.cctor>b__2_909(string str) { }

	internal string <.cctor>b__2_910() { }

	internal void <.cctor>b__2_911(string str) { }

	internal string <.cctor>b__2_912() { }

	internal void <.cctor>b__2_913(string str) { }

	internal string <.cctor>b__2_914() { }

	internal void <.cctor>b__2_915(string str) { }

	internal string <.cctor>b__2_916() { }

	internal void <.cctor>b__2_917(string str) { }

	internal string <.cctor>b__2_918() { }

	internal void <.cctor>b__2_919(string str) { }

	internal string <.cctor>b__2_920() { }

	internal void <.cctor>b__2_921(string str) { }

	internal string <.cctor>b__2_922() { }

	internal void <.cctor>b__2_923(string str) { }

	internal string <.cctor>b__2_924() { }

	internal void <.cctor>b__2_925(string str) { }

	internal string <.cctor>b__2_926() { }

	internal void <.cctor>b__2_927(string str) { }

	internal string <.cctor>b__2_928() { }

	internal void <.cctor>b__2_929(string str) { }

	internal string <.cctor>b__2_930() { }

	internal void <.cctor>b__2_931(string str) { }

	internal string <.cctor>b__2_932() { }

	internal void <.cctor>b__2_933(string str) { }

	internal void <.cctor>b__2_934(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_935(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_936() { }

	internal void <.cctor>b__2_937(string str) { }

	internal void <.cctor>b__2_938(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_939() { }

	internal void <.cctor>b__2_940(string str) { }

	internal string <.cctor>b__2_941() { }

	internal void <.cctor>b__2_942(string str) { }

	internal string <.cctor>b__2_943() { }

	internal void <.cctor>b__2_944(string str) { }

	internal string <.cctor>b__2_945() { }

	internal void <.cctor>b__2_946(string str) { }

	internal string <.cctor>b__2_947() { }

	internal void <.cctor>b__2_948(string str) { }

	internal string <.cctor>b__2_949() { }

	internal void <.cctor>b__2_950(string str) { }

	internal string <.cctor>b__2_951() { }

	internal void <.cctor>b__2_952(string str) { }

	internal string <.cctor>b__2_953() { }

	internal void <.cctor>b__2_954(string str) { }

	internal string <.cctor>b__2_955() { }

	internal void <.cctor>b__2_956(string str) { }

	internal string <.cctor>b__2_957() { }

	internal void <.cctor>b__2_958(string str) { }

	internal string <.cctor>b__2_959() { }

	internal void <.cctor>b__2_960(string str) { }

	internal string <.cctor>b__2_961() { }

	internal void <.cctor>b__2_962(string str) { }

	internal string <.cctor>b__2_963() { }

	internal void <.cctor>b__2_964(string str) { }

	internal string <.cctor>b__2_965() { }

	internal void <.cctor>b__2_966(string str) { }

	internal string <.cctor>b__2_967() { }

	internal void <.cctor>b__2_968(string str) { }

	internal string <.cctor>b__2_969() { }

	internal void <.cctor>b__2_970(string str) { }

	internal string <.cctor>b__2_971() { }

	internal void <.cctor>b__2_972(string str) { }

	internal string <.cctor>b__2_973() { }

	internal void <.cctor>b__2_974(string str) { }

	internal string <.cctor>b__2_975() { }

	internal void <.cctor>b__2_976(string str) { }

	internal string <.cctor>b__2_977() { }

	internal void <.cctor>b__2_978(string str) { }

	internal string <.cctor>b__2_979() { }

	internal void <.cctor>b__2_980(string str) { }

	internal string <.cctor>b__2_981() { }

	internal void <.cctor>b__2_982(string str) { }

	internal string <.cctor>b__2_983() { }

	internal void <.cctor>b__2_984(string str) { }

	internal string <.cctor>b__2_985() { }

	internal void <.cctor>b__2_986(string str) { }

	internal string <.cctor>b__2_987() { }

	internal void <.cctor>b__2_988(string str) { }

	internal string <.cctor>b__2_989() { }

	internal void <.cctor>b__2_990(string str) { }

	internal string <.cctor>b__2_991() { }

	internal void <.cctor>b__2_992(string str) { }

	internal string <.cctor>b__2_993() { }

	internal void <.cctor>b__2_994(string str) { }

	internal string <.cctor>b__2_995() { }

	internal void <.cctor>b__2_996(string str) { }

	internal string <.cctor>b__2_997() { }

	internal void <.cctor>b__2_998(string str) { }

	internal void <.cctor>b__2_999(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1000() { }

	internal void <.cctor>b__2_1001(string str) { }

	internal string <.cctor>b__2_1002() { }

	internal void <.cctor>b__2_1003(string str) { }

	internal string <.cctor>b__2_1004() { }

	internal void <.cctor>b__2_1005(string str) { }

	internal string <.cctor>b__2_1006() { }

	internal void <.cctor>b__2_1007(string str) { }

	internal void <.cctor>b__2_1008(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1009(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1010() { }

	internal void <.cctor>b__2_1011(string str) { }

	internal string <.cctor>b__2_1012() { }

	internal void <.cctor>b__2_1013(string str) { }

	internal string <.cctor>b__2_1014() { }

	internal void <.cctor>b__2_1015(string str) { }

	internal void <.cctor>b__2_1016(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1017() { }

	internal void <.cctor>b__2_1018(string str) { }

	internal void <.cctor>b__2_1019(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1020(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1021(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1022(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1023() { }

	internal void <.cctor>b__2_1024(string str) { }

	internal void <.cctor>b__2_1025(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1026() { }

	internal void <.cctor>b__2_1027(string str) { }

	internal string <.cctor>b__2_1028() { }

	internal void <.cctor>b__2_1029(string str) { }

	internal string <.cctor>b__2_1030() { }

	internal void <.cctor>b__2_1031(string str) { }

	internal string <.cctor>b__2_1032() { }

	internal void <.cctor>b__2_1033(string str) { }

	internal string <.cctor>b__2_1034() { }

	internal void <.cctor>b__2_1035(string str) { }

	internal string <.cctor>b__2_1036() { }

	internal void <.cctor>b__2_1037(string str) { }

	internal string <.cctor>b__2_1038() { }

	internal void <.cctor>b__2_1039(string str) { }

	internal string <.cctor>b__2_1040() { }

	internal void <.cctor>b__2_1041(string str) { }

	internal string <.cctor>b__2_1042() { }

	internal void <.cctor>b__2_1043(string str) { }

	internal string <.cctor>b__2_1044() { }

	internal void <.cctor>b__2_1045(string str) { }

	internal string <.cctor>b__2_1046() { }

	internal void <.cctor>b__2_1047(string str) { }

	internal string <.cctor>b__2_1048() { }

	internal void <.cctor>b__2_1049(string str) { }

	internal void <.cctor>b__2_1050(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1051(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1052() { }

	internal void <.cctor>b__2_1053(string str) { }

	internal string <.cctor>b__2_1054() { }

	internal void <.cctor>b__2_1055(string str) { }

	internal string <.cctor>b__2_1056() { }

	internal void <.cctor>b__2_1057(string str) { }

	internal string <.cctor>b__2_1058() { }

	internal void <.cctor>b__2_1059(string str) { }

	internal string <.cctor>b__2_1060() { }

	internal void <.cctor>b__2_1061(string str) { }

	internal void <.cctor>b__2_1062(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1063(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1064(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1065() { }

	internal void <.cctor>b__2_1066(string str) { }

	internal void <.cctor>b__2_1067(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1068(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1069() { }

	internal void <.cctor>b__2_1070(string str) { }

	internal string <.cctor>b__2_1071() { }

	internal void <.cctor>b__2_1072(string str) { }

	internal void <.cctor>b__2_1073(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1074() { }

	internal void <.cctor>b__2_1075(string str) { }

	internal string <.cctor>b__2_1076() { }

	internal void <.cctor>b__2_1077(string str) { }

	internal string <.cctor>b__2_1078() { }

	internal void <.cctor>b__2_1079(string str) { }

	internal string <.cctor>b__2_1080() { }

	internal void <.cctor>b__2_1081(string str) { }

	internal void <.cctor>b__2_1082(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1083(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1084(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1085(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1086(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1087(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1088(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1089(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1090(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1091() { }

	internal void <.cctor>b__2_1092(string str) { }

	internal string <.cctor>b__2_1093() { }

	internal void <.cctor>b__2_1094(string str) { }

	internal void <.cctor>b__2_1095(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1096(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1097() { }

	internal void <.cctor>b__2_1098(string str) { }

	internal string <.cctor>b__2_1099() { }

	internal void <.cctor>b__2_1100(string str) { }

	internal string <.cctor>b__2_1101() { }

	internal void <.cctor>b__2_1102(string str) { }

	internal string <.cctor>b__2_1103() { }

	internal void <.cctor>b__2_1104(string str) { }

	internal string <.cctor>b__2_1105() { }

	internal void <.cctor>b__2_1106(string str) { }

	internal string <.cctor>b__2_1107() { }

	internal void <.cctor>b__2_1108(string str) { }

	internal string <.cctor>b__2_1109() { }

	internal void <.cctor>b__2_1110(string str) { }

	internal string <.cctor>b__2_1111() { }

	internal void <.cctor>b__2_1112(string str) { }

	internal void <.cctor>b__2_1113(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1114(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1115() { }

	internal void <.cctor>b__2_1116(string str) { }

	internal string <.cctor>b__2_1117() { }

	internal void <.cctor>b__2_1118(string str) { }

	internal string <.cctor>b__2_1119() { }

	internal void <.cctor>b__2_1120(string str) { }

	internal void <.cctor>b__2_1121(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1122(ConsoleSystem.Arg arg) { }

	internal void <.cctor>b__2_1123(ConsoleSystem.Arg arg) { }

	internal string <.cctor>b__2_1124() { }

	internal void <.cctor>b__2_1125(string str) { }

	internal string <.cctor>b__2_1126() { }

	internal void <.cctor>b__2_1127(string str) { }

	internal string <.cctor>b__2_1128() { }

	internal void <.cctor>b__2_1129(string str) { }

	internal string <.cctor>b__2_1130() { }

	internal void <.cctor>b__2_1131(string str) { }

	internal string <.cctor>b__2_1132() { }

	internal void <.cctor>b__2_1133(string str) { }

	internal string <.cctor>b__2_1134() { }

	internal void <.cctor>b__2_1135(string str) { }

	internal string <.cctor>b__2_1136() { }

	internal void <.cctor>b__2_1137(string str) { }

	internal string <.cctor>b__2_1138() { }

	internal void <.cctor>b__2_1139(string str) { }

	internal string <.cctor>b__2_1140() { }

	internal void <.cctor>b__2_1141(string str) { }

	internal void <.cctor>b__2_1142(ConsoleSystem.Arg arg) { }

}

public static class ConsoleNetwork // TypeDefIndex: 9373
{

	internal static void Init() { }

	public static bool ClientRunOnServer(string strCommand) { }

	internal static void OnConsoleMessageFromServer(Message packet) { }

	internal static void OnConsoleCommandfromServer(Message packet) { }

}

public class ConsoleUI : SingletonComponent<ConsoleUI> // TypeDefIndex: 10846
{
	public RustText text; 
	public InputField outputField; 
	public InputField inputField; 
	public GameObject AutocompleteDropDown; 
	public GameObject ItemTemplate; 
	public Color errorColor; 
	public Color warningColor; 
	public Color inputColor; 
	private TextBuffer buffer; 
	private TextBuffer history; 
	private string historyTemp; 
	private string historyText; 
	private int historyIndex; 
	private Button[] autocompleteButtons; 
	private int autocompleteIndex; 
	private bool dirty; 


	protected override void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void Update() { }

	public void SetTextSize(float newSize) { }

	public void CloseAutocomplete() { }

	public void OnTextTypes(string str) { }

	private void AutocompleteButtonClicked(Button button) { }

	private void OnOpenDevTools() { }

	private void OutputHandler_OnMessage(string message, string stack, LogType type = 0) { }

	private void Log(string message) { }

	private void Refresh() { }

	private void LoadHistory(int delta) { }

	public void SubmitCommand(string command) { }

	private void SelectInputField(bool updateAutoComplete = False) { }

	[IteratorStateMachineAttribute] 
	private IEnumerator SetSelected(bool updateAutoComplete = False) { }

	public void ClearContents() { }

	public void Copy() { }

	public void OpenLogFolder() { }

	public void OpenLogFile() { }

	public void .ctor() { }

}

private sealed class ConsoleUI.<>c__DisplayClass16_0 // TypeDefIndex: 10847
{
	public Button btn; 
	public ConsoleUI <>4__this; 


	public void .ctor() { }

	internal void <Awake>b__0() { }

}

private sealed class ConsoleUI.<>c__DisplayClass22_0 // TypeDefIndex: 10848
{
	public string str; 


	public void .ctor() { }

	internal bool <OnTextTypes>b__0(ConsoleSystem.Command x) { }

}

private sealed class ConsoleUI.<SetSelected>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10849
{
	private int <>1__state; 
	private object <>2__current; 
	public ConsoleUI <>4__this; 
	public bool updateAutoComplete; 

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

public class ConsoleInput // TypeDefIndex: 11705
{
	[CompilerGeneratedAttribute] 
	private Action<string> OnInputText; 
	public string inputString; 
	public string[] statusText; 
	internal float nextUpdate; 

	public bool valid { get; }
	public int lineWidth { get; }


	[CompilerGeneratedAttribute] 
	public void add_OnInputText(Action<string> value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnInputText(Action<string> value) { }

	public bool get_valid() { }

	public int get_lineWidth() { }

	public void ClearLine(int numLines) { }

	public void RedrawInputLine() { }

	internal void OnBackspace() { }

	internal void OnEscape() { }

	internal void OnEnter() { }

	public void Update() { }

	public void .ctor() { }

}

public class ConsoleWindow // TypeDefIndex: 11706
{
	private TextWriter oldOutput; 
	private const int STD_INPUT_HANDLE = -10;
	private const int STD_OUTPUT_HANDLE = -11;


	public void Initialize() { }

	public void Shutdown() { }

	public void SetTitle(string strName) { }

	private static extern bool AttachConsole(uint dwProcessId) { }

	private static extern bool AllocConsole() { }

	private static extern bool FreeConsole() { }

	private static extern IntPtr GetStdHandle(int nStdHandle) { }

	private static extern bool SetConsoleTitleA(string lpConsoleTitle) { }

	public void .ctor() { }

}

public class Console : ConsoleSystem // TypeDefIndex: 11918
{
	[ClientVar] 
	[HelpAttribute] 
	public static bool erroroverlay; 


	[ClientVar] 
	public static void clear(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void copy(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

