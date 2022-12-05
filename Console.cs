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

public class ConsoleSystem // TypeDefIndex: 6918
{

public class ConsoleSystem
	public static bool HasChanges;
	public static Func<bool> ClientCanRunAdminCommands;
	public static Func<string, bool> OnSendToServer;
	[CompilerGeneratedAttribute]
	private static Action<string, string> OnReplicatedVarChanged;
	public static string LastError;
	public static ConsoleSystem.Arg CurrentArgs;
	private static List<string> ignoredCommands;


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

public class ConsoleSystem.Arg // TypeDefIndex: 6919
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

public class ConsoleSystem.Factory : Attribute // TypeDefIndex: 6920
{
	public string Name;


	public void .ctor(string systemName) { }

}

public class ConsoleSystem.Command // TypeDefIndex: 6921
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

public static class ConsoleSystem.Index // TypeDefIndex: 6924
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

public static class ConsoleSystem.Index.Server // TypeDefIndex: 6925
{
	public static Dictionary<string, ConsoleSystem.Command> Dict;
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict;
	public static List<ConsoleSystem.Command> Replicated;


	public static ConsoleSystem.Command Find(string strName) { }

	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Client // TypeDefIndex: 6926
{
	public static Dictionary<string, ConsoleSystem.Command> Dict;
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict;


	public static ConsoleSystem.Command Find(string strName) { }

	private static void .cctor() { }

}

private sealed class ConsoleSystem.Index.<>c // TypeDefIndex: 6927
{
	public static readonly ConsoleSystem.Index.<>c <>9;
	public static Action<ConsoleSystem.Command> <>9__4_1;
	public static Action<string, bool> <>9__4_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal void <Initialize>

	internal void <Initialize>

	internal string <.cctor>

	internal string <.cctor>

}

public struct ConsoleSystem.Option // TypeDefIndex: 6928
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

private sealed class ConsoleSystem.<>c // TypeDefIndex: 6929
{
	public static readonly ConsoleSystem.<>c <>9;
	public static Func<ConsoleSystem.Command, bool> <>9__22_0;
	public static Func<ConsoleSystem.Command, bool> <>9__22_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <SaveToConfigString>

	internal bool <SaveToConfigString>

}

public class ConsoleVar : Attribute // TypeDefIndex: 6930
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

public class ConsoleGen // TypeDefIndex: 10015
{
	public static ConsoleSystem.Command[] All;


	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class ConsoleGen.<>c // TypeDefIndex: 10016
{
	public static readonly ConsoleGen.<>c <>9;


	private static void .cctor() { }

	public void .ctor() { }

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal string <.cctor>

	internal void <.cctor>

	internal void <.cctor>

}

public static class ConsoleNetwork // TypeDefIndex: 11111
{

	internal static void Init() { }

	public static bool ClientRunOnServer(string strCommand) { }

	internal static void OnConsoleMessageFromServer(Message packet) { }

	internal static void OnConsoleCommandfromServer(Message packet) { }

}

public class ConsoleUI : SingletonComponent<ConsoleUI> // TypeDefIndex: 12604
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

private sealed class ConsoleUI.<>c__DisplayClass16_0 // TypeDefIndex: 12605
{
	public Button btn;
	public ConsoleUI <>4__this;


	public void .ctor() { }

	internal void <Awake>

}

private sealed class ConsoleUI.<>c__DisplayClass22_0 // TypeDefIndex: 12606
{
	public string str;


	public void .ctor() { }

	internal bool <OnTextTypes>

}

private sealed class ConsoleUI.<SetSelected>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 12607
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

public class ConsoleInput // TypeDefIndex: 13486
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

public class ConsoleWindow // TypeDefIndex: 13487
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

public class Console : ConsoleSystem // TypeDefIndex: 13699
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

