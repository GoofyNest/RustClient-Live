public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 186
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 187
{	// Fields
	private ConsoleSpecialKey _type; // 0x10
	private bool _cancel; // 0x14

	// Properties
	public bool Cancel { get; }

	// Methods

	// RVA: 0x144D880 Offset: 0x144CC80 VA: 0x18144D880
	internal void .ctor(ConsoleSpecialKey type) { }

	// RVA: 0x9EF9E0 Offset: 0x9EEDE0 VA: 0x1809EF9E0
	public bool get_Cancel() { }

	// RVA: 0x144D850 Offset: 0x144CC50 VA: 0x18144D850
	internal void .ctor() { }

}

public enum ConsoleColor // TypeDefIndex: 188
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	private char _keyChar; // 0x0
	private ConsoleKey _key; // 0x4
	private ConsoleModifiers _mods; // 0x8

	// Properties
	public char KeyChar { get; }
	public ConsoleKey Key { get; }

	// Methods

	// RVA: 0x1EF570 Offset: 0x1EE970 VA: 0x1801EF570
	public void .ctor(char keyChar, ConsoleKey key, bool shift, bool alt, bool control) { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10
	public char get_KeyChar() { }

	// RVA: 0x14B670 Offset: 0x14AA70 VA: 0x18014B670
	public ConsoleKey get_Key() { }

	// RVA: 0x1EF470 Offset: 0x1EE870 VA: 0x1801EF470 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1EF520 Offset: 0x1EE920 VA: 0x1801EF520
	public bool Equals(ConsoleKeyInfo obj) { }

	// RVA: 0x1EF560 Offset: 0x1EE960 VA: 0x1801EF560 Slot: 2
	public override int GetHashCode() { }

}

public enum ConsoleModifiers // TypeDefIndex: 191
{	// Fields
	public int value__; // 0x0
	public const ConsoleModifiers Alt = 1;
	public const ConsoleModifiers Shift = 2;
	public const ConsoleModifiers Control = 4;

}

public enum ConsoleSpecialKey // TypeDefIndex: 192
{	// Fields
	public int value__; // 0x0
	public const ConsoleSpecialKey ControlC = 0;
	public const ConsoleSpecialKey ControlBreak = 1;

}

public static class Console // TypeDefIndex: 350
{	// Fields
	internal static TextWriter stdout; // 0x0
	private static TextWriter stderr; // 0x8
	private static TextReader stdin; // 0x10
	private static Encoding inputEncoding; // 0x18
	private static Encoding outputEncoding; // 0x20
	private static ConsoleCancelEventHandler cancel_event; // 0x28
	private static readonly Console.InternalCancelHandler cancel_handler; // 0x30

	// Properties
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

	// Methods

	// RVA: 0x144F060 Offset: 0x144E460 VA: 0x18144F060
	private static void .cctor() { }

	// RVA: 0x144EB00 Offset: 0x144DF00 VA: 0x18144EB00
	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

	// RVA: 0x144F4A0 Offset: 0x144E8A0 VA: 0x18144F4A0
	public static TextWriter get_Error() { }

	// RVA: 0x144F6E0 Offset: 0x144EAE0 VA: 0x18144F6E0
	public static TextWriter get_Out() { }

	// RVA: 0x144E6C0 Offset: 0x144DAC0 VA: 0x18144E6C0
	private static Stream Open(IntPtr handle, FileAccess access, int bufferSize) { }

	// RVA: 0x144E510 Offset: 0x144D910 VA: 0x18144E510
	public static Stream OpenStandardError(int bufferSize) { }

	// RVA: 0x144E5A0 Offset: 0x144D9A0 VA: 0x18144E5A0
	public static Stream OpenStandardInput(int bufferSize) { }

	// RVA: 0x144E630 Offset: 0x144DA30 VA: 0x18144E630
	public static Stream OpenStandardOutput(int bufferSize) { }

	// RVA: 0x144EA60 Offset: 0x144DE60 VA: 0x18144EA60
	public static void SetOut(TextWriter newOut) { }

	// RVA: 0x144EFE0 Offset: 0x144E3E0 VA: 0x18144EFE0
	public static void Write(string value) { }

	// RVA: 0x144EEE0 Offset: 0x144E2E0 VA: 0x18144EEE0
	public static void WriteLine(object value) { }

	// RVA: 0x144EF60 Offset: 0x144E360 VA: 0x18144EF60
	public static void WriteLine(string value) { }

	// RVA: 0x144F5C0 Offset: 0x144E9C0 VA: 0x18144F5C0
	public static Encoding get_InputEncoding() { }

	// RVA: 0x144F740 Offset: 0x144EB40 VA: 0x18144F740
	public static Encoding get_OutputEncoding() { }

	// RVA: 0x144FB20 Offset: 0x144EF20 VA: 0x18144FB20
	public static void set_OutputEncoding(Encoding value) { }

	// RVA: 0x144F260 Offset: 0x144E660 VA: 0x18144F260
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x144F7A0 Offset: 0x144EBA0 VA: 0x18144F7A0
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x144F320 Offset: 0x144E720 VA: 0x18144F320
	public static int get_BufferWidth() { }

	// RVA: 0x144F8A0 Offset: 0x144ECA0 VA: 0x18144F8A0
	public static void set_CursorLeft(int value) { }

	// RVA: 0x144F3E0 Offset: 0x144E7E0 VA: 0x18144F3E0
	public static int get_CursorTop() { }

	// RVA: 0x144F960 Offset: 0x144ED60 VA: 0x18144F960
	public static void set_CursorTop(int value) { }

	// RVA: 0x144F500 Offset: 0x144E900 VA: 0x18144F500
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x144FA20 Offset: 0x144EE20 VA: 0x18144FA20
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x144F620 Offset: 0x144EA20 VA: 0x18144F620
	public static bool get_KeyAvailable() { }

	// RVA: 0x144E8E0 Offset: 0x144DCE0 VA: 0x18144E8E0
	public static ConsoleKeyInfo ReadKey() { }

	// RVA: 0x144E790 Offset: 0x144DB90 VA: 0x18144E790
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x144E340 Offset: 0x144D740 VA: 0x18144E340
	internal static void DoConsoleCancelEvent() { }

}

private class Console.WindowsConsole // TypeDefIndex: 351
{	// Fields
	public static bool ctrlHandlerAdded; // 0x0
	private static Console.WindowsConsole.WindowsCancelHandler cancelHandler; // 0x8

	// Methods

	// RVA: 0x1468B90 Offset: 0x1467F90 VA: 0x181468B90
	private static extern int GetConsoleCP() { }

	// RVA: 0x1468C00 Offset: 0x1468000 VA: 0x181468C00
	private static extern int GetConsoleOutputCP() { }

	// RVA: 0x1468B30 Offset: 0x1467F30 VA: 0x181468B30
	private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

	// RVA: 0x1468C70 Offset: 0x1468070 VA: 0x181468C70
	public static int GetInputCodePage() { }

	// RVA: 0x1468D10 Offset: 0x1468110 VA: 0x181468D10
	public static int GetOutputCodePage() { }

	// RVA: 0x1468DB0 Offset: 0x14681B0 VA: 0x181468DB0
	private static void .cctor() { }

}

private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1468840 Offset: 0x1467C40 VA: 0x181468840 Slot: 12
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x14687C0 Offset: 0x1467BC0 VA: 0x1814687C0 Slot: 13
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0xFF1100 Offset: 0xFF0500 VA: 0x180FF1100 Slot: 14
	public virtual bool EndInvoke(IAsyncResult result) { }

}

private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 353
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x145EF20 Offset: 0x145E320 VA: 0x18145EF20 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

internal static class ConsoleDriver // TypeDefIndex: 354
{	// Fields
	internal static IConsoleDriver driver; // 0x0
	private static bool is_console; // 0x8
	private static bool called_isatty; // 0x9

	// Properties
	public static ConsoleColor BackgroundColor { get; set; }
	public static int BufferWidth { get; }
	public static int CursorLeft { set; }
	public static int CursorTop { get; set; }
	public static bool KeyAvailable { get; }
	public static ConsoleColor ForegroundColor { get; set; }
	public static bool IsConsole { get; }

	// Methods

	// RVA: 0x144DB30 Offset: 0x144CF30 VA: 0x18144DB30
	private static void .cctor() { }

	// RVA: 0x144D8F0 Offset: 0x144CCF0 VA: 0x18144D8F0
	private static IConsoleDriver CreateNullConsoleDriver() { }

	// RVA: 0x144D9A0 Offset: 0x144CDA0 VA: 0x18144D9A0
	private static IConsoleDriver CreateWindowsConsoleDriver() { }

	// RVA: 0x144D940 Offset: 0x144CD40 VA: 0x18144D940
	private static IConsoleDriver CreateTermInfoDriver(string term) { }

	// RVA: 0x144DBF0 Offset: 0x144CFF0 VA: 0x18144DBF0
	public static ConsoleColor get_BackgroundColor() { }

	// RVA: 0x144DFF0 Offset: 0x144D3F0 VA: 0x18144DFF0
	public static void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x144DC60 Offset: 0x144D060 VA: 0x18144DC60
	public static int get_BufferWidth() { }

	// RVA: 0x144E0B0 Offset: 0x144D4B0 VA: 0x18144E0B0
	public static void set_CursorLeft(int value) { }

	// RVA: 0x144DCE0 Offset: 0x144D0E0 VA: 0x18144DCE0
	public static int get_CursorTop() { }

	// RVA: 0x144E130 Offset: 0x144D530 VA: 0x18144E130
	public static void set_CursorTop(int value) { }

	// RVA: 0x144DF70 Offset: 0x144D370 VA: 0x18144DF70
	public static bool get_KeyAvailable() { }

	// RVA: 0x144DD60 Offset: 0x144D160 VA: 0x18144DD60
	public static ConsoleColor get_ForegroundColor() { }

	// RVA: 0x144E1B0 Offset: 0x144D5B0 VA: 0x18144E1B0
	public static void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x144DA00 Offset: 0x144CE00 VA: 0x18144DA00
	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x144DDE0 Offset: 0x144D1E0 VA: 0x18144DDE0
	public static bool get_IsConsole() { }

	// RVA: 0x144D9F0 Offset: 0x144CDF0 VA: 0x18144D9F0
	private static bool Isatty(IntPtr handle) { }

	// RVA: 0x10D8C30 Offset: 0x10D8030 VA: 0x1810D8C30
	internal static int InternalKeyAvailable(int ms_timeout) { }

	// RVA: 0x144DB20 Offset: 0x144CF20 VA: 0x18144DB20
	internal static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address) { }

	// RVA: 0x144DB10 Offset: 0x144CF10 VA: 0x18144DB10
	internal static bool SetEcho(bool wantEcho) { }

}

internal struct ConsoleScreenBufferInfo // TypeDefIndex: 426
{	// Fields
	public Coord Size; // 0x0
	public Coord CursorPosition; // 0x4
	public short Attribute; // 0x8
	public SmallRect Window; // 0xA
	public Coord MaxWindowSize; // 0x12

}

public class ConsoleSystem // TypeDefIndex: 6878
{
// Namespace: 
public class ConsoleSystem // TypeDefIndex: 6878
	// Fields
	public static bool HasChanges; // 0x0
	public static Func<bool> ClientCanRunAdminCommands; // 0x8
	public static Func<string, bool> OnSendToServer; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static Action<string, string> OnReplicatedVarChanged; // 0x18
	public static string LastError; // 0x20
	public static ConsoleSystem.Arg CurrentArgs; // 0x28

	// Methods

	// RVA: 0x22AF260 Offset: 0x22AE660 VA: 0x1822AF260
	public static void UpdateValuesFromCommandLine() { }

	// RVA: 0x22AF1B0 Offset: 0x22AE5B0 VA: 0x1822AF1B0
	internal static bool SendToServer(string command) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22AF4C0 Offset: 0x22AE8C0 VA: 0x1822AF4C0
	public static void add_OnReplicatedVarChanged(Action<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22AF5C0 Offset: 0x22AE9C0 VA: 0x1822AF5C0
	public static void remove_OnReplicatedVarChanged(Action<string, string> value) { }

	// RVA: 0x22AE820 Offset: 0x22ADC20 VA: 0x1822AE820
	public static void RunFile(ConsoleSystem.Option options, string strFile) { }

	// RVA: 0x22AE9B0 Offset: 0x22ADDB0 VA: 0x1822AE9B0
	public static string Run(ConsoleSystem.Option options, string strCommand, object[] args) { }

	// RVA: 0x22AE220 Offset: 0x22AD620 VA: 0x1822AE220
	private static bool Internal(ConsoleSystem.Arg arg) { }

	// RVA: 0x22ADDB0 Offset: 0x22AD1B0 VA: 0x1822ADDB0
	public static string BuildCommand(string strCommand, object[] args) { }

	// RVA: 0x22AEDB0 Offset: 0x22AE1B0 VA: 0x1822AEDB0
	public static string SaveToConfigString(bool bServer) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class ConsoleSystem.Arg // TypeDefIndex: 6879
{	// Fields
	public ConsoleSystem.Option Option; // 0x10
	public ConsoleSystem.Command cmd; // 0x20
	public string FullString; // 0x28
	public string[] Args; // 0x30
	public bool Invalid; // 0x38
	public string Reply; // 0x40

	// Properties
	public bool IsClientside { get; }
	public bool IsServerside { get; }
	public Connection Connection { get; }
	public bool IsConnectionAdmin { get; }
	public bool IsAdmin { get; }
	public bool IsRcon { get; }

	// Methods

	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public bool get_IsClientside() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public bool get_IsServerside() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Connection get_Connection() { }

	// RVA: 0x22ACBF0 Offset: 0x22ABFF0 VA: 0x1822ACBF0
	public bool get_IsConnectionAdmin() { }

	// RVA: 0x22ACBC0 Offset: 0x22ABFC0 VA: 0x1822ACBC0
	public bool get_IsAdmin() { }

	// RVA: 0x139FE10 Offset: 0x139F210 VA: 0x18139FE10
	public bool get_IsRcon() { }

	// RVA: 0x22ACB20 Offset: 0x22ABF20 VA: 0x1822ACB20
	internal void .ctor(ConsoleSystem.Option options, string rconCommand) { }

	// RVA: 0x22ABB30 Offset: 0x22AAF30 VA: 0x1822ABB30
	internal void BuildCommand(string command) { }

	// RVA: 0x22AC800 Offset: 0x22ABC00 VA: 0x1822AC800
	internal bool HasPermission() { }

	// RVA: 0x22ABF50 Offset: 0x22AB350 VA: 0x1822ABF50
	internal bool CanSeeInFind(ConsoleSystem.Command command) { }

	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void ReplyWith(string strValue) { }

	// RVA: 0x22ACA40 Offset: 0x22ABE40 VA: 0x1822ACA40
	public void ReplyWith(object obj) { }

	// RVA: 0x22AC7E0 Offset: 0x22ABBE0 VA: 0x1822AC7E0
	public bool HasArgs(int iMinimum = 1) { }

	// RVA: 0x22AC780 Offset: 0x22ABB80 VA: 0x1822AC780
	public bool HasArg(string value) { }

	// RVA: 0x22AC250 Offset: 0x22AB650 VA: 0x1822AC250
	public string GetString(int iArg, string def = "") { }

	// RVA: 0x22AC1E0 Offset: 0x22AB5E0 VA: 0x1822AC1E0
	public int GetInt(int iArg, int def = 0) { }

	// RVA: 0x22AC610 Offset: 0x22ABA10 VA: 0x1822AC610
	public ulong GetULong(int iArg, ulong def = 0) { }

	// RVA: 0x22ACAC0 Offset: 0x22ABEC0 VA: 0x1822ACAC0
	public bool TryGetUInt(int iArg, out uint value) { }

	// RVA: 0x22AC690 Offset: 0x22ABA90 VA: 0x1822AC690
	public uint GetUInt(int iArg, uint def = 0) { }

	// RVA: 0x22AC610 Offset: 0x22ABA10 VA: 0x1822AC610
	public ulong GetUInt64(int iArg, ulong def = 0) { }

	// RVA: 0x22AC160 Offset: 0x22AB560 VA: 0x1822AC160
	public float GetFloat(int iArg, float def = 0) { }

	// RVA: 0x22ABF80 Offset: 0x22AB380 VA: 0x1822ABF80
	public bool GetBool(int iArg, bool def = False) { }

	// RVA: 0x22AC430 Offset: 0x22AB830 VA: 0x1822AC430
	public long GetTimestamp(int iArg, long def = 0) { }

	// RVA: 0x22AC2A0 Offset: 0x22AB6A0 VA: 0x1822AC2A0
	public long GetTicks(int iArg, long def = 0) { }

	// RVA: 0x22AC980 Offset: 0x22ABD80 VA: 0x1822AC980
	public void ReplyWithObject(object rval) { }

	// RVA: 0x22AC700 Offset: 0x22ABB00 VA: 0x1822AC700
	public Vector3 GetVector3(int iArg, Vector3 def) { }

	// RVA: 0x22AC0F0 Offset: 0x22AB4F0 VA: 0x1822AC0F0
	public Color GetColor(int iArg, Color def) { }

}

public class ConsoleSystem.Factory : Attribute // TypeDefIndex: 6880
{	// Fields
	public string Name; // 0x10

	// Methods

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(string systemName) { }

}

public class ConsoleSystem.Command // TypeDefIndex: 6881
{	// Fields
	public string Name; // 0x10
	public string Parent; // 0x18
	public string FullName; // 0x20
	public Func<string> GetOveride; // 0x28
	public Action<string> SetOveride; // 0x30
	public Action<ConsoleSystem.Arg> Call; // 0x38
	public bool Variable; // 0x40
	public string Default; // 0x48
	public bool Saved; // 0x50
	public bool ServerAdmin; // 0x51
	public bool ServerUser; // 0x52
	public bool Replicated; // 0x53
	public bool ShowInAdminUI; // 0x54
	public bool ClientAdmin; // 0x55
	public bool Client; // 0x56
	public bool ClientInfo; // 0x57
	public bool AllowRunFromServer; // 0x58
	public string Description; // 0x60
	public string Arguments; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<ConsoleSystem.Command> OnValueChanged; // 0x70

	// Properties
	public bool Server { get; }
	public string String { get; }
	public int AsInt { get; }
	public float AsFloat { get; }
	public bool AsBool { get; }
	public Vector3 AsVector3 { get; }

	// Methods

	// RVA: 0x22AD7E0 Offset: 0x22ACBE0 VA: 0x1822AD7E0
	public bool get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22AD510 Offset: 0x22AC910 VA: 0x1822AD510
	public void add_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22AD840 Offset: 0x22ACC40 VA: 0x1822AD840
	public void remove_OnValueChanged(Action<ConsoleSystem.Command> value) { }

	// RVA: 0x22AD460 Offset: 0x22AC860 VA: 0x1822AD460
	public void .ctor() { }

	// RVA: 0x22AD280 Offset: 0x22AC680 VA: 0x1822AD280
	private void ValueChanged() { }

	// RVA: 0x22ACF50 Offset: 0x22AC350 VA: 0x1822ACF50
	private void DefaultCall(ConsoleSystem.Arg arg) { }

	// RVA: 0x22AD7F0 Offset: 0x22ACBF0 VA: 0x1822AD7F0
	public string get_String() { }

	// RVA: 0x22AD6D0 Offset: 0x22ACAD0 VA: 0x1822AD6D0
	public int get_AsInt() { }

	// RVA: 0x22AD640 Offset: 0x22ACA40 VA: 0x1822AD640
	public float get_AsFloat() { }

	// RVA: 0x22AD5B0 Offset: 0x22AC9B0 VA: 0x1822AD5B0
	public bool get_AsBool() { }

	// RVA: 0x22AD760 Offset: 0x22ACB60 VA: 0x1822AD760
	public Vector3 get_AsVector3() { }

	// RVA: 0x22AD0E0 Offset: 0x22AC4E0 VA: 0x1822AD0E0
	public void Set(string value) { }

	// RVA: 0x22AD1D0 Offset: 0x22AC5D0 VA: 0x1822AD1D0
	public void Set(float f) { }

	// RVA: 0x22AD000 Offset: 0x22AC400 VA: 0x1822AD000
	public void Set(bool val) { }

}

public static class ConsoleSystem.Index // TypeDefIndex: 6884
{	// Fields
	private static readonly Memoized<string, string> WithGlobal; // 0x0
	private static readonly Memoized<string, string> WithoutGlobal; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static ConsoleSystem.Command[] <All>k__BackingField; // 0x10

	// Properties
	public static ConsoleSystem.Command[] All { get; set; }

	// Methods

	// RVA: 0x22AF6C0 Offset: 0x22AEAC0 VA: 0x1822AF6C0
	public static void Initialize(ConsoleSystem.Command[] Commands) { }

	// RVA: 0x22AFE50 Offset: 0x22AF250 VA: 0x1822AFE50
	public static void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22B0140 Offset: 0x22AF540 VA: 0x1822B0140
	public static ConsoleSystem.Command[] get_All() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22B01A0 Offset: 0x22AF5A0 VA: 0x1822B01A0
	private static void set_All(ConsoleSystem.Command[] value) { }

	// RVA: 0x22B0000 Offset: 0x22AF400 VA: 0x1822B0000
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Server // TypeDefIndex: 6885
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8
	public static List<ConsoleSystem.Command> Replicated; // 0x10

	// Methods

	// RVA: 0x22B0320 Offset: 0x22AF720 VA: 0x1822B0320
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22B0460 Offset: 0x22AF860 VA: 0x1822B0460
	private static void .cctor() { }

}

public static class ConsoleSystem.Index.Client // TypeDefIndex: 6886
{	// Fields
	public static Dictionary<string, ConsoleSystem.Command> Dict; // 0x0
	public static Dictionary<string, ConsoleSystem.Command> GlobalDict; // 0x8

	// Methods

	// RVA: 0x22ACC30 Offset: 0x22AC030 VA: 0x1822ACC30
	public static ConsoleSystem.Command Find(string strName) { }

	// RVA: 0x22ACDE0 Offset: 0x22AC1E0 VA: 0x1822ACDE0
	private static void .cctor() { }

}

private sealed class ConsoleSystem.Index.<>c // TypeDefIndex: 6887
{	// Fields
	public static readonly ConsoleSystem.Index.<>c <>9; // 0x0
	public static Action<ConsoleSystem.Command> <>9__4_1; // 0x8
	public static Action<string, bool> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x22B0AB0 Offset: 0x22AFEB0 VA: 0x1822B0AB0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22B0810 Offset: 0x22AFC10 VA: 0x1822B0810
	internal void <Initialize>b__4_1(ConsoleSystem.Command command) { }

	// RVA: 0x22B0610 Offset: 0x22AFA10 VA: 0x1822B0610
	internal void <Initialize>b__4_0(string strCommand, bool pressed) { }

	// RVA: 0x22B0940 Offset: 0x22AFD40 VA: 0x1822B0940
	internal string <.cctor>b__10_0(string s) { }

	// RVA: 0x22B0980 Offset: 0x22AFD80 VA: 0x1822B0980
	internal string <.cctor>b__10_1(string s) { }

}

public struct ConsoleSystem.Option // TypeDefIndex: 6888
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsServer>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsClient>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <ForwardtoServerOnMissing>k__BackingField; // 0x2
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <PrintOutput>k__BackingField; // 0x3
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsUnrestricted>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <FromRcon>k__BackingField; // 0x5
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsFromServer>k__BackingField; // 0x6
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Connection <Connection>k__BackingField; // 0x8

	// Properties
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

	// Methods

	// RVA: 0x22B0270 Offset: 0x22AF670 VA: 0x1822B0270
	public static ConsoleSystem.Option get_Unrestricted() { }

	// RVA: 0x22B0230 Offset: 0x22AF630 VA: 0x1822B0230
	public static ConsoleSystem.Option get_Client() { }

	// RVA: 0x22B0250 Offset: 0x22AF650 VA: 0x1822B0250
	public static ConsoleSystem.Option get_Server() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14CAA0 Offset: 0x14BEA0 VA: 0x18014CAA0
	public bool get_IsServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2049E0 Offset: 0x203DE0 VA: 0x1802049E0
	public void set_IsServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1FA030 Offset: 0x1F9430 VA: 0x1801FA030
	public bool get_IsClient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236BF0 Offset: 0x235FF0 VA: 0x180236BF0
	public void set_IsClient(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x120F50 Offset: 0x120350 VA: 0x180120F50
	public bool get_ForwardtoServerOnMissing() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x236BE0 Offset: 0x235FE0 VA: 0x180236BE0
	public void set_ForwardtoServerOnMissing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x120F00 Offset: 0x120300 VA: 0x180120F00
	public bool get_PrintOutput() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23AD90 Offset: 0x23A190 VA: 0x18023AD90
	public void set_PrintOutput(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x120F20 Offset: 0x120320 VA: 0x180120F20
	public bool get_IsUnrestricted() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x123040 Offset: 0x122440 VA: 0x180123040
	public void set_IsUnrestricted(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x120F30 Offset: 0x120330 VA: 0x180120F30
	public bool get_FromRcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23AD70 Offset: 0x23A170 VA: 0x18023AD70
	public void set_FromRcon(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23AD60 Offset: 0x23A160 VA: 0x18023AD60
	public bool get_IsFromServer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23AD80 Offset: 0x23A180 VA: 0x18023AD80
	public void set_IsFromServer(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DB0 Offset: 0xF31B0 VA: 0x1800F3DB0
	public Connection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1390 Offset: 0xF0790 VA: 0x1800F1390
	public void set_Connection(Connection value) { }

	// RVA: 0x23AD50 Offset: 0x23A150 VA: 0x18023AD50
	public ConsoleSystem.Option Quiet() { }

	// RVA: 0x23AD40 Offset: 0x23A140 VA: 0x18023AD40
	public ConsoleSystem.Option FromServer() { }

	// RVA: 0x23AD00 Offset: 0x23A100 VA: 0x18023AD00
	public ConsoleSystem.Option FromConnection(Connection connection) { }

}

private sealed class ConsoleSystem.<>c // TypeDefIndex: 6889
{	// Fields
	public static readonly ConsoleSystem.<>c <>9; // 0x0
	public static Func<ConsoleSystem.Command, bool> <>9__21_0; // 0x8
	public static Func<ConsoleSystem.Command, bool> <>9__21_1; // 0x10

	// Methods

	// RVA: 0x22B0A50 Offset: 0x22AFE50 VA: 0x1822B0A50
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22B08E0 Offset: 0x22AFCE0 VA: 0x1822B08E0
	internal bool <SaveToConfigString>b__21_0(ConsoleSystem.Command x) { }

	// RVA: 0x22B0910 Offset: 0x22AFD10 VA: 0x1822B0910
	internal bool <SaveToConfigString>b__21_1(ConsoleSystem.Command x) { }

}

public class ConsoleVar : Attribute // TypeDefIndex: 6890
{	// Fields
	public string Name; // 0x10
	public bool ClientAdmin; // 0x18
	public bool ServerAdmin; // 0x19
	public bool ServerUser; // 0x1A
	public bool Saved; // 0x1B
	public string Help; // 0x20
	public bool ClientInfo; // 0x28
	public bool Replicated; // 0x29
	public bool Clientside; // 0x2A
	public bool Serverside; // 0x2B
	public bool EditorOnly; // 0x2C
	public bool AllowRunFromServer; // 0x2D
	public string Default; // 0x30
	public string[] PreprocessorConditions; // 0x38
	public bool ShowInAdminUI; // 0x40

	// Methods

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public class ConsoleGen // TypeDefIndex: 8299
{	// Fields
	public static ConsoleSystem.Command[] All; // 0x2B0AA98

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2FC150 Offset: 0x2FB550 VA: 0x1802FC150
	private static void .cctor() { }

}

private sealed class ConsoleGen.<>c // TypeDefIndex: 8300
{	// Fields
	public static readonly ConsoleGen.<>c <>9; // 0x2130

	// Methods

	// RVA: 0xE24910 Offset: 0xE23D10 VA: 0x180E24910
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xE02B60 Offset: 0xE01F60 VA: 0x180E02B60
	internal string <.cctor>b__2_0() { }

	// RVA: 0xE09BA0 Offset: 0xE08FA0 VA: 0x180E09BA0
	internal void <.cctor>b__2_1(string str) { }

	// RVA: 0xE0D310 Offset: 0xE0C710 VA: 0x180E0D310
	internal string <.cctor>b__2_2() { }

	// RVA: 0xE10800 Offset: 0xE0FC00 VA: 0x180E10800
	internal void <.cctor>b__2_3(string str) { }

	// RVA: 0xE13800 Offset: 0xE12C00 VA: 0x180E13800
	internal string <.cctor>b__2_4() { }

	// RVA: 0xE16EC0 Offset: 0xE162C0 VA: 0x180E16EC0
	internal void <.cctor>b__2_5(string str) { }

	// RVA: 0xE1A980 Offset: 0xE19D80 VA: 0x180E1A980
	internal string <.cctor>b__2_6() { }

	// RVA: 0xE1DD00 Offset: 0xE1D100 VA: 0x180E1DD00
	internal void <.cctor>b__2_7(string str) { }

	// RVA: 0xE21190 Offset: 0xE20590 VA: 0x180E21190
	internal string <.cctor>b__2_8() { }

	// RVA: 0xE24860 Offset: 0xE23C60 VA: 0x180E24860
	internal void <.cctor>b__2_9(string str) { }

	// RVA: 0xE05C40 Offset: 0xE05040 VA: 0x180E05C40
	internal string <.cctor>b__2_10() { }

	// RVA: 0xE06F70 Offset: 0xE06370 VA: 0x180E06F70
	internal void <.cctor>b__2_11(string str) { }

	// RVA: 0xE07510 Offset: 0xE06910 VA: 0x180E07510
	internal string <.cctor>b__2_12() { }

	// RVA: 0xE07A10 Offset: 0xE06E10 VA: 0x180E07A10
	internal void <.cctor>b__2_13(string str) { }

	// RVA: 0xE07FA0 Offset: 0xE073A0 VA: 0x180E07FA0
	internal string <.cctor>b__2_14() { }

	// RVA: 0xE084E0 Offset: 0xE078E0 VA: 0x180E084E0
	internal void <.cctor>b__2_15(string str) { }

	// RVA: 0xE08A50 Offset: 0xE07E50 VA: 0x180E08A50
	internal string <.cctor>b__2_16() { }

	// RVA: 0xE08FF0 Offset: 0xE083F0 VA: 0x180E08FF0
	internal void <.cctor>b__2_17(string str) { }

	// RVA: 0xE095F0 Offset: 0xE089F0 VA: 0x180E095F0
	internal string <.cctor>b__2_18() { }

	// RVA: 0xE09AF0 Offset: 0xE08EF0 VA: 0x180E09AF0
	internal void <.cctor>b__2_19(string str) { }

	// RVA: 0xE0A140 Offset: 0xE09540 VA: 0x180E0A140
	internal string <.cctor>b__2_20() { }

	// RVA: 0xE0A610 Offset: 0xE09A10 VA: 0x180E0A610
	internal void <.cctor>b__2_21(string str) { }

	// RVA: 0xE0AAF0 Offset: 0xE09EF0 VA: 0x180E0AAF0
	internal string <.cctor>b__2_22() { }

	// RVA: 0xE0B090 Offset: 0xE0A490 VA: 0x180E0B090
	internal void <.cctor>b__2_23(string str) { }

	// RVA: 0xE0B600 Offset: 0xE0AA00 VA: 0x180E0B600
	internal string <.cctor>b__2_24() { }

	// RVA: 0xE0BBD0 Offset: 0xE0AFD0 VA: 0x180E0BBD0
	internal void <.cctor>b__2_25(string str) { }

	// RVA: 0xE0C170 Offset: 0xE0B570 VA: 0x180E0C170
	internal string <.cctor>b__2_26() { }

	// RVA: 0xE0C700 Offset: 0xE0BB00 VA: 0x180E0C700
	internal void <.cctor>b__2_27(string str) { }

	// RVA: 0xE0CD50 Offset: 0xE0C150 VA: 0x180E0CD50
	internal string <.cctor>b__2_28() { }

	// RVA: 0xE0D260 Offset: 0xE0C660 VA: 0x180E0D260
	internal void <.cctor>b__2_29(string str) { }

	// RVA: 0xE0D7A0 Offset: 0xE0CBA0 VA: 0x180E0D7A0
	internal string <.cctor>b__2_30() { }

	// RVA: 0xE0DCC0 Offset: 0xE0D0C0 VA: 0x180E0DCC0
	internal void <.cctor>b__2_31(string str) { }

	// RVA: 0xE0E2E0 Offset: 0xE0D6E0 VA: 0x180E0E2E0
	internal string <.cctor>b__2_32() { }

	// RVA: 0xE0E750 Offset: 0xE0DB50 VA: 0x180E0E750
	internal void <.cctor>b__2_33(string str) { }

	// RVA: 0xE0EB40 Offset: 0xE0DF40 VA: 0x180E0EB40
	internal string <.cctor>b__2_34() { }

	// RVA: 0xE0F0B0 Offset: 0xE0E4B0 VA: 0x180E0F0B0
	internal void <.cctor>b__2_35(string str) { }

	// RVA: 0xE0F690 Offset: 0xE0EA90 VA: 0x180E0F690
	internal string <.cctor>b__2_36() { }

	// RVA: 0xE0FBF0 Offset: 0xE0EFF0 VA: 0x180E0FBF0
	internal void <.cctor>b__2_37(string str) { }

	// RVA: 0xE10190 Offset: 0xE0F590 VA: 0x180E10190
	internal string <.cctor>b__2_38() { }

	// RVA: 0xE10750 Offset: 0xE0FB50 VA: 0x180E10750
	internal void <.cctor>b__2_39(string str) { }

	// RVA: 0xE10CF0 Offset: 0xE100F0 VA: 0x180E10CF0
	internal string <.cctor>b__2_40() { }

	// RVA: 0xE11210 Offset: 0xE10610 VA: 0x180E11210
	internal void <.cctor>b__2_41(string str) { }

	// RVA: 0xE11800 Offset: 0xE10C00 VA: 0x180E11800
	internal string <.cctor>b__2_42() { }

	// RVA: 0xE11D00 Offset: 0xE11100 VA: 0x180E11D00
	internal void <.cctor>b__2_43(string str) { }

	// RVA: 0xE122C0 Offset: 0xE116C0 VA: 0x180E122C0
	internal string <.cctor>b__2_44() { }

	// RVA: 0xE12840 Offset: 0xE11C40 VA: 0x180E12840
	internal void <.cctor>b__2_45(string str) { }

	// RVA: 0xE12DF0 Offset: 0xE121F0 VA: 0x180E12DF0
	internal string <.cctor>b__2_46() { }

	// RVA: 0xE132E0 Offset: 0xE126E0 VA: 0x180E132E0
	internal void <.cctor>b__2_47(string str) { }

	// RVA: 0xE13480 Offset: 0xE12880 VA: 0x180E13480
	internal string <.cctor>b__2_48() { }

	// RVA: 0xE13750 Offset: 0xE12B50 VA: 0x180E13750
	internal void <.cctor>b__2_49(string str) { }

	// RVA: 0xE13D00 Offset: 0xE13100 VA: 0x180E13D00
	internal string <.cctor>b__2_50() { }

	// RVA: 0xE14210 Offset: 0xE13610 VA: 0x180E14210
	internal void <.cctor>b__2_51(string str) { }

	// RVA: 0xE147B0 Offset: 0xE13BB0 VA: 0x180E147B0
	internal string <.cctor>b__2_52() { }

	// RVA: 0xE14CD0 Offset: 0xE140D0 VA: 0x180E14CD0
	internal void <.cctor>b__2_53(string str) { }

	// RVA: 0xE15250 Offset: 0xE14650 VA: 0x180E15250
	internal string <.cctor>b__2_54() { }

	// RVA: 0xE157D0 Offset: 0xE14BD0 VA: 0x180E157D0
	internal void <.cctor>b__2_55(string str) { }

	// RVA: 0xE15DC0 Offset: 0xE151C0 VA: 0x180E15DC0
	internal string <.cctor>b__2_56() { }

	// RVA: 0xE162D0 Offset: 0xE156D0 VA: 0x180E162D0
	internal void <.cctor>b__2_57(string str) { }

	// RVA: 0xE16890 Offset: 0xE15C90 VA: 0x180E16890
	internal string <.cctor>b__2_58() { }

	// RVA: 0xE16E10 Offset: 0xE16210 VA: 0x180E16E10
	internal void <.cctor>b__2_59(string str) { }

	// RVA: 0xE17440 Offset: 0xE16840 VA: 0x180E17440
	internal string <.cctor>b__2_60() { }

	// RVA: 0xE17960 Offset: 0xE16D60 VA: 0x180E17960
	internal void <.cctor>b__2_61(string str) { }

	// RVA: 0xE17FD0 Offset: 0xE173D0 VA: 0x180E17FD0
	internal string <.cctor>b__2_62() { }

	// RVA: 0xE18660 Offset: 0xE17A60 VA: 0x180E18660
	internal void <.cctor>b__2_63(string str) { }

	// RVA: 0xE18C00 Offset: 0xE18000 VA: 0x180E18C00
	internal string <.cctor>b__2_64() { }

	// RVA: 0xE191B0 Offset: 0xE185B0 VA: 0x180E191B0
	internal void <.cctor>b__2_65(string str) { }

	// RVA: 0xE19740 Offset: 0xE18B40 VA: 0x180E19740
	internal string <.cctor>b__2_66() { }

	// RVA: 0xE19D10 Offset: 0xE19110 VA: 0x180E19D10
	internal void <.cctor>b__2_67(string str) { }

	// RVA: 0xE1A2A0 Offset: 0xE196A0 VA: 0x180E1A2A0
	internal string <.cctor>b__2_68() { }

	// RVA: 0xE1A8D0 Offset: 0xE19CD0 VA: 0x180E1A8D0
	internal void <.cctor>b__2_69(string str) { }

	// RVA: 0xE1AEF0 Offset: 0xE1A2F0 VA: 0x180E1AEF0
	internal string <.cctor>b__2_70() { }

	// RVA: 0xE1B460 Offset: 0xE1A860 VA: 0x180E1B460
	internal void <.cctor>b__2_71(string str) { }

	// RVA: 0xE1B9F0 Offset: 0xE1ADF0 VA: 0x180E1B9F0
	internal string <.cctor>b__2_72() { }

	// RVA: 0xE1BF90 Offset: 0xE1B390 VA: 0x180E1BF90
	internal void <.cctor>b__2_73(string str) { }

	// RVA: 0xE1C540 Offset: 0xE1B940 VA: 0x180E1C540
	internal string <.cctor>b__2_74() { }

	// RVA: 0xE1C9B0 Offset: 0xE1BDB0 VA: 0x180E1C9B0
	internal void <.cctor>b__2_75(string str) { }

	// RVA: 0xE1CD70 Offset: 0xE1C170 VA: 0x180E1CD70
	internal string <.cctor>b__2_76() { }

	// RVA: 0xE1D290 Offset: 0xE1C690 VA: 0x180E1D290
	internal void <.cctor>b__2_77(string str) { }

	// RVA: 0xE1D870 Offset: 0xE1CC70 VA: 0x180E1D870
	internal string <.cctor>b__2_78() { }

	// RVA: 0xE1DC50 Offset: 0xE1D050 VA: 0x180E1DC50
	internal void <.cctor>b__2_79(string str) { }

	// RVA: 0xE1E270 Offset: 0xE1D670 VA: 0x180E1E270
	internal string <.cctor>b__2_80() { }

	// RVA: 0xE1E790 Offset: 0xE1DB90 VA: 0x180E1E790
	internal void <.cctor>b__2_81(string str) { }

	// RVA: 0xE1EBC0 Offset: 0xE1DFC0 VA: 0x180E1EBC0
	internal string <.cctor>b__2_82() { }

	// RVA: 0xE1F100 Offset: 0xE1E500 VA: 0x180E1F100
	internal void <.cctor>b__2_83(string str) { }

	// RVA: 0xE1F630 Offset: 0xE1EA30 VA: 0x180E1F630
	internal string <.cctor>b__2_84() { }

	// RVA: 0xE1FC00 Offset: 0xE1F000 VA: 0x180E1FC00
	internal void <.cctor>b__2_85(string str) { }

	// RVA: 0xE201C0 Offset: 0xE1F5C0 VA: 0x180E201C0
	internal string <.cctor>b__2_86() { }

	// RVA: 0xE20760 Offset: 0xE1FB60 VA: 0x180E20760
	internal void <.cctor>b__2_87(string str) { }

	// RVA: 0xE20C90 Offset: 0xE20090 VA: 0x180E20C90
	internal string <.cctor>b__2_88() { }

	// RVA: 0xE210E0 Offset: 0xE204E0 VA: 0x180E210E0
	internal void <.cctor>b__2_89(string str) { }

	// RVA: 0xE21770 Offset: 0xE20B70 VA: 0x180E21770
	internal string <.cctor>b__2_90() { }

	// RVA: 0xE21D20 Offset: 0xE21120 VA: 0x180E21D20
	internal void <.cctor>b__2_91(string str) { }

	// RVA: 0xE221F0 Offset: 0xE215F0 VA: 0x180E221F0
	internal string <.cctor>b__2_92() { }

	// RVA: 0xE227C0 Offset: 0xE21BC0 VA: 0x180E227C0
	internal void <.cctor>b__2_93(string str) { }

	// RVA: 0xE22D70 Offset: 0xE22170 VA: 0x180E22D70
	internal string <.cctor>b__2_94() { }

	// RVA: 0xE232C0 Offset: 0xE226C0 VA: 0x180E232C0
	internal void <.cctor>b__2_95(string str) { }

	// RVA: 0xE23820 Offset: 0xE22C20 VA: 0x180E23820
	internal string <.cctor>b__2_96() { }

	// RVA: 0xE23D50 Offset: 0xE23150 VA: 0x180E23D50
	internal void <.cctor>b__2_97(string str) { }

	// RVA: 0xE242B0 Offset: 0xE236B0 VA: 0x180E242B0
	internal string <.cctor>b__2_98() { }

	// RVA: 0xE247B0 Offset: 0xE23BB0 VA: 0x180E247B0
	internal void <.cctor>b__2_99(string str) { }

	// RVA: 0xE03000 Offset: 0xE02400 VA: 0x180E03000
	internal string <.cctor>b__2_100() { }

	// RVA: 0xE034C0 Offset: 0xE028C0 VA: 0x180E034C0
	internal void <.cctor>b__2_101(string str) { }

	// RVA: 0xE03900 Offset: 0xE02D00 VA: 0x180E03900
	internal string <.cctor>b__2_102() { }

	// RVA: 0xE03C00 Offset: 0xE03000 VA: 0x180E03C00
	internal void <.cctor>b__2_103(string str) { }

	// RVA: 0xE04100 Offset: 0xE03500 VA: 0x180E04100
	internal string <.cctor>b__2_104() { }

	// RVA: 0xE046E0 Offset: 0xE03AE0 VA: 0x180E046E0
	internal void <.cctor>b__2_105(string str) { }

	// RVA: 0xE04D40 Offset: 0xE04140 VA: 0x180E04D40
	internal string <.cctor>b__2_106() { }

	// RVA: 0xE05090 Offset: 0xE04490 VA: 0x180E05090
	internal void <.cctor>b__2_107(string str) { }

	// RVA: 0xE055F0 Offset: 0xE049F0 VA: 0x180E055F0
	internal string <.cctor>b__2_108() { }

	// RVA: 0xE05B90 Offset: 0xE04F90 VA: 0x180E05B90
	internal void <.cctor>b__2_109(string str) { }

	// RVA: 0xE06140 Offset: 0xE05540 VA: 0x180E06140
	internal string <.cctor>b__2_110() { }

	// RVA: 0xE06690 Offset: 0xE05A90 VA: 0x180E06690
	internal void <.cctor>b__2_111(string str) { }

	// RVA: 0xE06C50 Offset: 0xE06050 VA: 0x180E06C50
	internal string <.cctor>b__2_112() { }

	// RVA: 0xE06CC0 Offset: 0xE060C0 VA: 0x180E06CC0
	internal void <.cctor>b__2_113(string str) { }

	// RVA: 0xE06D70 Offset: 0xE06170 VA: 0x180E06D70
	internal void <.cctor>b__2_114(ConsoleSystem.Arg arg) { }

	// RVA: 0xE06DD0 Offset: 0xE061D0 VA: 0x180E06DD0
	internal void <.cctor>b__2_115(ConsoleSystem.Arg arg) { }

	// RVA: 0xE06E20 Offset: 0xE06220 VA: 0x180E06E20
	internal void <.cctor>b__2_116(ConsoleSystem.Arg arg) { }

	// RVA: 0xE06E50 Offset: 0xE06250 VA: 0x180E06E50
	internal void <.cctor>b__2_117(ConsoleSystem.Arg arg) { }

	// RVA: 0xE06E60 Offset: 0xE06260 VA: 0x180E06E60
	internal string <.cctor>b__2_118() { }

	// RVA: 0xE06EC0 Offset: 0xE062C0 VA: 0x180E06EC0
	internal void <.cctor>b__2_119(string str) { }

	// RVA: 0xE07020 Offset: 0xE06420 VA: 0x180E07020
	internal string <.cctor>b__2_120() { }

	// RVA: 0xE07080 Offset: 0xE06480 VA: 0x180E07080
	internal void <.cctor>b__2_121(string str) { }

	// RVA: 0xE07110 Offset: 0xE06510 VA: 0x180E07110
	internal string <.cctor>b__2_122() { }

	// RVA: 0xE07170 Offset: 0xE06570 VA: 0x180E07170
	internal void <.cctor>b__2_123(string str) { }

	// RVA: 0xE07200 Offset: 0xE06600 VA: 0x180E07200
	internal string <.cctor>b__2_124() { }

	// RVA: 0xE07260 Offset: 0xE06660 VA: 0x180E07260
	internal void <.cctor>b__2_125(string str) { }

	// RVA: 0xE07310 Offset: 0xE06710 VA: 0x180E07310
	internal string <.cctor>b__2_126() { }

	// RVA: 0xE07370 Offset: 0xE06770 VA: 0x180E07370
	internal void <.cctor>b__2_127(string str) { }

	// RVA: 0xE07400 Offset: 0xE06800 VA: 0x180E07400
	internal string <.cctor>b__2_128() { }

	// RVA: 0xE07460 Offset: 0xE06860 VA: 0x180E07460
	internal void <.cctor>b__2_129(string str) { }

	// RVA: 0xE07590 Offset: 0xE06990 VA: 0x180E07590
	internal string <.cctor>b__2_130() { }

	// RVA: 0xE075F0 Offset: 0xE069F0 VA: 0x180E075F0
	internal void <.cctor>b__2_131(string str) { }

	// RVA: 0xE076A0 Offset: 0xE06AA0 VA: 0x180E076A0
	internal void <.cctor>b__2_132(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07700 Offset: 0xE06B00 VA: 0x180E07700
	internal void <.cctor>b__2_133(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07760 Offset: 0xE06B60 VA: 0x180E07760
	internal void <.cctor>b__2_134(ConsoleSystem.Arg arg) { }

	// RVA: 0xE077C0 Offset: 0xE06BC0 VA: 0x180E077C0
	internal void <.cctor>b__2_135(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07820 Offset: 0xE06C20 VA: 0x180E07820
	internal string <.cctor>b__2_136() { }

	// RVA: 0xE07880 Offset: 0xE06C80 VA: 0x180E07880
	internal void <.cctor>b__2_137(string str) { }

	// RVA: 0xE07910 Offset: 0xE06D10 VA: 0x180E07910
	internal string <.cctor>b__2_138() { }

	// RVA: 0xE07970 Offset: 0xE06D70 VA: 0x180E07970
	internal void <.cctor>b__2_139(string str) { }

	// RVA: 0xE07AC0 Offset: 0xE06EC0 VA: 0x180E07AC0
	internal string <.cctor>b__2_140() { }

	// RVA: 0xE07B20 Offset: 0xE06F20 VA: 0x180E07B20
	internal void <.cctor>b__2_141(string str) { }

	// RVA: 0xE07BC0 Offset: 0xE06FC0 VA: 0x180E07BC0
	internal void <.cctor>b__2_142(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07C30 Offset: 0xE07030 VA: 0x180E07C30
	internal void <.cctor>b__2_143(ConsoleSystem.Arg arg) { }

	// RVA: 0xE07C90 Offset: 0xE07090 VA: 0x180E07C90
	internal string <.cctor>b__2_144() { }

	// RVA: 0xE07CF0 Offset: 0xE070F0 VA: 0x180E07CF0
	internal void <.cctor>b__2_145(string str) { }

	// RVA: 0xE07D90 Offset: 0xE07190 VA: 0x180E07D90
	internal string <.cctor>b__2_146() { }

	// RVA: 0xE07DF0 Offset: 0xE071F0 VA: 0x180E07DF0
	internal void <.cctor>b__2_147(string str) { }

	// RVA: 0xE07EA0 Offset: 0xE072A0 VA: 0x180E07EA0
	internal string <.cctor>b__2_148() { }

	// RVA: 0xE07F00 Offset: 0xE07300 VA: 0x180E07F00
	internal void <.cctor>b__2_149(string str) { }

	// RVA: 0xE08020 Offset: 0xE07420 VA: 0x180E08020
	internal void <.cctor>b__2_150(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08080 Offset: 0xE07480 VA: 0x180E08080
	internal void <.cctor>b__2_151(ConsoleSystem.Arg arg) { }

	// RVA: 0xE080E0 Offset: 0xE074E0 VA: 0x180E080E0
	internal string <.cctor>b__2_152() { }

	// RVA: 0xE08140 Offset: 0xE07540 VA: 0x180E08140
	internal void <.cctor>b__2_153(string str) { }

	// RVA: 0xE081E0 Offset: 0xE075E0 VA: 0x180E081E0
	internal string <.cctor>b__2_154() { }

	// RVA: 0xE08240 Offset: 0xE07640 VA: 0x180E08240
	internal void <.cctor>b__2_155(string str) { }

	// RVA: 0xE082E0 Offset: 0xE076E0 VA: 0x180E082E0
	internal string <.cctor>b__2_156() { }

	// RVA: 0xE08340 Offset: 0xE07740 VA: 0x180E08340
	internal void <.cctor>b__2_157(string str) { }

	// RVA: 0xE083E0 Offset: 0xE077E0 VA: 0x180E083E0
	internal string <.cctor>b__2_158() { }

	// RVA: 0xE08440 Offset: 0xE07840 VA: 0x180E08440
	internal void <.cctor>b__2_159(string str) { }

	// RVA: 0xE08590 Offset: 0xE07990 VA: 0x180E08590
	internal string <.cctor>b__2_160() { }

	// RVA: 0xE085F0 Offset: 0xE079F0 VA: 0x180E085F0
	internal void <.cctor>b__2_161(string str) { }

	// RVA: 0xE086A0 Offset: 0xE07AA0 VA: 0x180E086A0
	internal string <.cctor>b__2_162() { }

	// RVA: 0xE08700 Offset: 0xE07B00 VA: 0x180E08700
	internal void <.cctor>b__2_163(string str) { }

	// RVA: 0xE087A0 Offset: 0xE07BA0 VA: 0x180E087A0
	internal void <.cctor>b__2_164(ConsoleSystem.Arg arg) { }

	// RVA: 0xE08800 Offset: 0xE07C00 VA: 0x180E08800
	internal string <.cctor>b__2_165() { }

	// RVA: 0xE08880 Offset: 0xE07C80 VA: 0x180E08880
	internal void <.cctor>b__2_166(string str) { }

	// RVA: 0xE088F0 Offset: 0xE07CF0 VA: 0x180E088F0
	internal string <.cctor>b__2_167() { }

	// RVA: 0xE08950 Offset: 0xE07D50 VA: 0x180E08950
	internal void <.cctor>b__2_168(string str) { }

	// RVA: 0xE089F0 Offset: 0xE07DF0 VA: 0x180E089F0
	internal string <.cctor>b__2_169() { }

	// RVA: 0xE08AD0 Offset: 0xE07ED0 VA: 0x180E08AD0
	internal void <.cctor>b__2_170(string str) { }

	// RVA: 0xE08B70 Offset: 0xE07F70 VA: 0x180E08B70
	internal string <.cctor>b__2_171() { }

	// RVA: 0xE08BD0 Offset: 0xE07FD0 VA: 0x180E08BD0
	internal void <.cctor>b__2_172(string str) { }

	// RVA: 0xE08C70 Offset: 0xE08070 VA: 0x180E08C70
	internal string <.cctor>b__2_173() { }

	// RVA: 0xE08CD0 Offset: 0xE080D0 VA: 0x180E08CD0
	internal void <.cctor>b__2_174(string str) { }

	// RVA: 0xE08D80 Offset: 0xE08180 VA: 0x180E08D80
	internal string <.cctor>b__2_175() { }

	// RVA: 0xE08DE0 Offset: 0xE081E0 VA: 0x180E08DE0
	internal void <.cctor>b__2_176(string str) { }

	// RVA: 0xE08E90 Offset: 0xE08290 VA: 0x180E08E90
	internal string <.cctor>b__2_177() { }

	// RVA: 0xE08EF0 Offset: 0xE082F0 VA: 0x180E08EF0
	internal void <.cctor>b__2_178(string str) { }

	// RVA: 0xE08F90 Offset: 0xE08390 VA: 0x180E08F90
	internal string <.cctor>b__2_179() { }

	// RVA: 0xE090A0 Offset: 0xE084A0 VA: 0x180E090A0
	internal void <.cctor>b__2_180(string str) { }

	// RVA: 0xE09150 Offset: 0xE08550 VA: 0x180E09150
	internal string <.cctor>b__2_181() { }

	// RVA: 0xE091B0 Offset: 0xE085B0 VA: 0x180E091B0
	internal void <.cctor>b__2_182(string str) { }

	// RVA: 0xE09260 Offset: 0xE08660 VA: 0x180E09260
	internal string <.cctor>b__2_183() { }

	// RVA: 0xE092C0 Offset: 0xE086C0 VA: 0x180E092C0
	internal void <.cctor>b__2_184(string str) { }

	// RVA: 0xE09370 Offset: 0xE08770 VA: 0x180E09370
	internal string <.cctor>b__2_185() { }

	// RVA: 0xE093D0 Offset: 0xE087D0 VA: 0x180E093D0
	internal void <.cctor>b__2_186(string str) { }

	// RVA: 0xE09480 Offset: 0xE08880 VA: 0x180E09480
	internal string <.cctor>b__2_187() { }

	// RVA: 0xE094E0 Offset: 0xE088E0 VA: 0x180E094E0
	internal void <.cctor>b__2_188(string str) { }

	// RVA: 0xE09590 Offset: 0xE08990 VA: 0x180E09590
	internal void <.cctor>b__2_189(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09670 Offset: 0xE08A70 VA: 0x180E09670
	internal void <.cctor>b__2_190(ConsoleSystem.Arg arg) { }

	// RVA: 0xE096D0 Offset: 0xE08AD0 VA: 0x180E096D0
	internal string <.cctor>b__2_191() { }

	// RVA: 0xE09730 Offset: 0xE08B30 VA: 0x180E09730
	internal void <.cctor>b__2_192(string str) { }

	// RVA: 0xE097B0 Offset: 0xE08BB0 VA: 0x180E097B0
	internal string <.cctor>b__2_193() { }

	// RVA: 0xE09810 Offset: 0xE08C10 VA: 0x180E09810
	internal void <.cctor>b__2_194(string str) { }

	// RVA: 0xE098C0 Offset: 0xE08CC0 VA: 0x180E098C0
	internal string <.cctor>b__2_195() { }

	// RVA: 0xE09920 Offset: 0xE08D20 VA: 0x180E09920
	internal void <.cctor>b__2_196(string str) { }

	// RVA: 0xE099D0 Offset: 0xE08DD0 VA: 0x180E099D0
	internal void <.cctor>b__2_197(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09A30 Offset: 0xE08E30 VA: 0x180E09A30
	internal void <.cctor>b__2_198(ConsoleSystem.Arg arg) { }

	// RVA: 0xE09A90 Offset: 0xE08E90 VA: 0x180E09A90
	internal string <.cctor>b__2_199() { }

	// RVA: 0xE09C40 Offset: 0xE09040 VA: 0x180E09C40
	internal void <.cctor>b__2_200(string str) { }

	// RVA: 0xE09CE0 Offset: 0xE090E0 VA: 0x180E09CE0
	internal string <.cctor>b__2_201() { }

	// RVA: 0xE09D40 Offset: 0xE09140 VA: 0x180E09D40
	internal void <.cctor>b__2_202(string str) { }

	// RVA: 0xE09DE0 Offset: 0xE091E0 VA: 0x180E09DE0
	internal string <.cctor>b__2_203() { }

	// RVA: 0xE09E40 Offset: 0xE09240 VA: 0x180E09E40
	internal void <.cctor>b__2_204(string str) { }

	// RVA: 0xE09EE0 Offset: 0xE092E0 VA: 0x180E09EE0
	internal string <.cctor>b__2_205() { }

	// RVA: 0xE09F40 Offset: 0xE09340 VA: 0x180E09F40
	internal void <.cctor>b__2_206(string str) { }

	// RVA: 0xE09FE0 Offset: 0xE093E0 VA: 0x180E09FE0
	internal string <.cctor>b__2_207() { }

	// RVA: 0xE0A040 Offset: 0xE09440 VA: 0x180E0A040
	internal void <.cctor>b__2_208(string str) { }

	// RVA: 0xE0A0E0 Offset: 0xE094E0 VA: 0x180E0A0E0
	internal string <.cctor>b__2_209() { }

	// RVA: 0xE0A1C0 Offset: 0xE095C0 VA: 0x180E0A1C0
	internal void <.cctor>b__2_210(string str) { }

	// RVA: 0xE0A260 Offset: 0xE09660 VA: 0x180E0A260
	internal void <.cctor>b__2_211(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A2C0 Offset: 0xE096C0 VA: 0x180E0A2C0
	internal void <.cctor>b__2_212(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A320 Offset: 0xE09720 VA: 0x180E0A320
	internal void <.cctor>b__2_213(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A370 Offset: 0xE09770 VA: 0x180E0A370
	internal string <.cctor>b__2_214() { }

	// RVA: 0xE0A3D0 Offset: 0xE097D0 VA: 0x180E0A3D0
	internal void <.cctor>b__2_215(string str) { }

	// RVA: 0xE0A470 Offset: 0xE09870 VA: 0x180E0A470
	internal void <.cctor>b__2_216(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A4D0 Offset: 0xE098D0 VA: 0x180E0A4D0
	internal string <.cctor>b__2_217() { }

	// RVA: 0xE0A530 Offset: 0xE09930 VA: 0x180E0A530
	internal void <.cctor>b__2_218(string str) { }

	// RVA: 0xE0A5B0 Offset: 0xE099B0 VA: 0x180E0A5B0
	internal void <.cctor>b__2_219(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A6C0 Offset: 0xE09AC0 VA: 0x180E0A6C0
	internal void <.cctor>b__2_220(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A710 Offset: 0xE09B10 VA: 0x180E0A710
	internal void <.cctor>b__2_221(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A770 Offset: 0xE09B70 VA: 0x180E0A770
	internal void <.cctor>b__2_222(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A7D0 Offset: 0xE09BD0 VA: 0x180E0A7D0
	internal void <.cctor>b__2_223(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A830 Offset: 0xE09C30 VA: 0x180E0A830
	internal void <.cctor>b__2_224(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0A890 Offset: 0xE09C90 VA: 0x180E0A890
	internal string <.cctor>b__2_225() { }

	// RVA: 0xE0A910 Offset: 0xE09D10 VA: 0x180E0A910
	internal void <.cctor>b__2_226(string str) { }

	// RVA: 0xE0A980 Offset: 0xE09D80 VA: 0x180E0A980
	internal string <.cctor>b__2_227() { }

	// RVA: 0xE0A9E0 Offset: 0xE09DE0 VA: 0x180E0A9E0
	internal void <.cctor>b__2_228(string str) { }

	// RVA: 0xE0AA90 Offset: 0xE09E90 VA: 0x180E0AA90
	internal string <.cctor>b__2_229() { }

	// RVA: 0xE0AB70 Offset: 0xE09F70 VA: 0x180E0AB70
	internal void <.cctor>b__2_230(string str) { }

	// RVA: 0xE0AC20 Offset: 0xE0A020 VA: 0x180E0AC20
	internal string <.cctor>b__2_231() { }

	// RVA: 0xE0AC80 Offset: 0xE0A080 VA: 0x180E0AC80
	internal void <.cctor>b__2_232(string str) { }

	// RVA: 0xE0AD30 Offset: 0xE0A130 VA: 0x180E0AD30
	internal string <.cctor>b__2_233() { }

	// RVA: 0xE0AD90 Offset: 0xE0A190 VA: 0x180E0AD90
	internal void <.cctor>b__2_234(string str) { }

	// RVA: 0xE0AE30 Offset: 0xE0A230 VA: 0x180E0AE30
	internal string <.cctor>b__2_235() { }

	// RVA: 0xE0AE90 Offset: 0xE0A290 VA: 0x180E0AE90
	internal void <.cctor>b__2_236(string str) { }

	// RVA: 0xE0AF40 Offset: 0xE0A340 VA: 0x180E0AF40
	internal string <.cctor>b__2_237() { }

	// RVA: 0xE0AFA0 Offset: 0xE0A3A0 VA: 0x180E0AFA0
	internal void <.cctor>b__2_238(string str) { }

	// RVA: 0xE0B030 Offset: 0xE0A430 VA: 0x180E0B030
	internal string <.cctor>b__2_239() { }

	// RVA: 0xE0B140 Offset: 0xE0A540 VA: 0x180E0B140
	internal void <.cctor>b__2_240(string str) { }

	// RVA: 0xE0B1E0 Offset: 0xE0A5E0 VA: 0x180E0B1E0
	internal string <.cctor>b__2_241() { }

	// RVA: 0xE0B240 Offset: 0xE0A640 VA: 0x180E0B240
	internal void <.cctor>b__2_242(string str) { }

	// RVA: 0xE0B2C0 Offset: 0xE0A6C0 VA: 0x180E0B2C0
	internal string <.cctor>b__2_243() { }

	// RVA: 0xE0B320 Offset: 0xE0A720 VA: 0x180E0B320
	internal void <.cctor>b__2_244(string str) { }

	// RVA: 0xE0B3B0 Offset: 0xE0A7B0 VA: 0x180E0B3B0
	internal string <.cctor>b__2_245() { }

	// RVA: 0xE0B410 Offset: 0xE0A810 VA: 0x180E0B410
	internal void <.cctor>b__2_246(string str) { }

	// RVA: 0xE0B490 Offset: 0xE0A890 VA: 0x180E0B490
	internal void <.cctor>b__2_247(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B4F0 Offset: 0xE0A8F0 VA: 0x180E0B4F0
	internal string <.cctor>b__2_248() { }

	// RVA: 0xE0B550 Offset: 0xE0A950 VA: 0x180E0B550
	internal void <.cctor>b__2_249(string str) { }

	// RVA: 0xE0B680 Offset: 0xE0AA80 VA: 0x180E0B680
	internal string <.cctor>b__2_250() { }

	// RVA: 0xE0B6E0 Offset: 0xE0AAE0 VA: 0x180E0B6E0
	internal void <.cctor>b__2_251(string str) { }

	// RVA: 0xE0B790 Offset: 0xE0AB90 VA: 0x180E0B790
	internal string <.cctor>b__2_252() { }

	// RVA: 0xE0B7F0 Offset: 0xE0ABF0 VA: 0x180E0B7F0
	internal void <.cctor>b__2_253(string str) { }

	// RVA: 0xE0B8A0 Offset: 0xE0ACA0 VA: 0x180E0B8A0
	internal void <.cctor>b__2_254(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0B960 Offset: 0xE0AD60 VA: 0x180E0B960
	internal void <.cctor>b__2_255(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BA20 Offset: 0xE0AE20 VA: 0x180E0BA20
	internal void <.cctor>b__2_256(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BA70 Offset: 0xE0AE70 VA: 0x180E0BA70
	internal string <.cctor>b__2_257() { }

	// RVA: 0xE0BAD0 Offset: 0xE0AED0 VA: 0x180E0BAD0
	internal void <.cctor>b__2_258(string str) { }

	// RVA: 0xE0BB70 Offset: 0xE0AF70 VA: 0x180E0BB70
	internal string <.cctor>b__2_259() { }

	// RVA: 0xE0BC80 Offset: 0xE0B080 VA: 0x180E0BC80
	internal void <.cctor>b__2_260(string str) { }

	// RVA: 0xE0BD20 Offset: 0xE0B120 VA: 0x180E0BD20
	internal string <.cctor>b__2_261() { }

	// RVA: 0xE0BD80 Offset: 0xE0B180 VA: 0x180E0BD80
	internal void <.cctor>b__2_262(string str) { }

	// RVA: 0xE0BE20 Offset: 0xE0B220 VA: 0x180E0BE20
	internal void <.cctor>b__2_263(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BE90 Offset: 0xE0B290 VA: 0x180E0BE90
	internal void <.cctor>b__2_264(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0BF00 Offset: 0xE0B300 VA: 0x180E0BF00
	internal string <.cctor>b__2_265() { }

	// RVA: 0xE0BF60 Offset: 0xE0B360 VA: 0x180E0BF60
	internal void <.cctor>b__2_266(string str) { }

	// RVA: 0xE0C000 Offset: 0xE0B400 VA: 0x180E0C000
	internal string <.cctor>b__2_267() { }

	// RVA: 0xE0C060 Offset: 0xE0B460 VA: 0x180E0C060
	internal void <.cctor>b__2_268(string str) { }

	// RVA: 0xE0C110 Offset: 0xE0B510 VA: 0x180E0C110
	internal string <.cctor>b__2_269() { }

	// RVA: 0xE0C1F0 Offset: 0xE0B5F0 VA: 0x180E0C1F0
	internal void <.cctor>b__2_270(string str) { }

	// RVA: 0xE0C290 Offset: 0xE0B690 VA: 0x180E0C290
	internal string <.cctor>b__2_271() { }

	// RVA: 0xE0C2F0 Offset: 0xE0B6F0 VA: 0x180E0C2F0
	internal void <.cctor>b__2_272(string str) { }

	// RVA: 0xE0C390 Offset: 0xE0B790 VA: 0x180E0C390
	internal string <.cctor>b__2_273() { }

	// RVA: 0xE0C3F0 Offset: 0xE0B7F0 VA: 0x180E0C3F0
	internal void <.cctor>b__2_274(string str) { }

	// RVA: 0xE0C490 Offset: 0xE0B890 VA: 0x180E0C490
	internal string <.cctor>b__2_275() { }

	// RVA: 0xE0C4F0 Offset: 0xE0B8F0 VA: 0x180E0C4F0
	internal void <.cctor>b__2_276(string str) { }

	// RVA: 0xE0C5A0 Offset: 0xE0B9A0 VA: 0x180E0C5A0
	internal string <.cctor>b__2_277() { }

	// RVA: 0xE0C600 Offset: 0xE0BA00 VA: 0x180E0C600
	internal void <.cctor>b__2_278(string str) { }

	// RVA: 0xE0C6A0 Offset: 0xE0BAA0 VA: 0x180E0C6A0
	internal string <.cctor>b__2_279() { }

	// RVA: 0xE0C7B0 Offset: 0xE0BBB0 VA: 0x180E0C7B0
	internal void <.cctor>b__2_280(string str) { }

	// RVA: 0xE0C850 Offset: 0xE0BC50 VA: 0x180E0C850
	internal string <.cctor>b__2_281() { }

	// RVA: 0xE0C8B0 Offset: 0xE0BCB0 VA: 0x180E0C8B0
	internal void <.cctor>b__2_282(string str) { }

	// RVA: 0xE0C950 Offset: 0xE0BD50 VA: 0x180E0C950
	internal string <.cctor>b__2_283() { }

	// RVA: 0xE0CA00 Offset: 0xE0BE00 VA: 0x180E0CA00
	internal void <.cctor>b__2_284(string str) { }

	// RVA: 0xE0CA90 Offset: 0xE0BE90 VA: 0x180E0CA90
	internal string <.cctor>b__2_285() { }

	// RVA: 0xE0CAF0 Offset: 0xE0BEF0 VA: 0x180E0CAF0
	internal void <.cctor>b__2_286(string str) { }

	// RVA: 0xE0CB90 Offset: 0xE0BF90 VA: 0x180E0CB90
	internal string <.cctor>b__2_287() { }

	// RVA: 0xE0CC40 Offset: 0xE0C040 VA: 0x180E0CC40
	internal void <.cctor>b__2_288(string str) { }

	// RVA: 0xE0CCD0 Offset: 0xE0C0D0 VA: 0x180E0CCD0
	internal void <.cctor>b__2_289(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CDD0 Offset: 0xE0C1D0 VA: 0x180E0CDD0
	internal void <.cctor>b__2_290(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CE30 Offset: 0xE0C230 VA: 0x180E0CE30
	internal string <.cctor>b__2_291() { }

	// RVA: 0xE0CE90 Offset: 0xE0C290 VA: 0x180E0CE90
	internal void <.cctor>b__2_292(string str) { }

	// RVA: 0xE0CF30 Offset: 0xE0C330 VA: 0x180E0CF30
	internal void <.cctor>b__2_293(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0CFA0 Offset: 0xE0C3A0 VA: 0x180E0CFA0
	internal void <.cctor>b__2_294(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D010 Offset: 0xE0C410 VA: 0x180E0D010
	internal void <.cctor>b__2_295(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D080 Offset: 0xE0C480 VA: 0x180E0D080
	internal void <.cctor>b__2_296(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D0F0 Offset: 0xE0C4F0 VA: 0x180E0D0F0
	internal void <.cctor>b__2_297(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D160 Offset: 0xE0C560 VA: 0x180E0D160
	internal string <.cctor>b__2_298() { }

	// RVA: 0xE0D1C0 Offset: 0xE0C5C0 VA: 0x180E0D1C0
	internal void <.cctor>b__2_299(string str) { }

	// RVA: 0xE0D370 Offset: 0xE0C770 VA: 0x180E0D370
	internal void <.cctor>b__2_300(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D3C0 Offset: 0xE0C7C0 VA: 0x180E0D3C0
	internal void <.cctor>b__2_301(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D420 Offset: 0xE0C820 VA: 0x180E0D420
	internal void <.cctor>b__2_302(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D480 Offset: 0xE0C880 VA: 0x180E0D480
	internal string <.cctor>b__2_303() { }

	// RVA: 0xE0D4E0 Offset: 0xE0C8E0 VA: 0x180E0D4E0
	internal void <.cctor>b__2_304(string str) { }

	// RVA: 0xE0D580 Offset: 0xE0C980 VA: 0x180E0D580
	internal void <.cctor>b__2_305(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D5E0 Offset: 0xE0C9E0 VA: 0x180E0D5E0
	internal string <.cctor>b__2_306() { }

	// RVA: 0xE0D640 Offset: 0xE0CA40 VA: 0x180E0D640
	internal void <.cctor>b__2_307(string str) { }

	// RVA: 0xE0D6E0 Offset: 0xE0CAE0 VA: 0x180E0D6E0
	internal void <.cctor>b__2_308(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D740 Offset: 0xE0CB40 VA: 0x180E0D740
	internal string <.cctor>b__2_309() { }

	// RVA: 0xE0D820 Offset: 0xE0CC20 VA: 0x180E0D820
	internal void <.cctor>b__2_310(string str) { }

	// RVA: 0xE0D8C0 Offset: 0xE0CCC0 VA: 0x180E0D8C0
	internal void <.cctor>b__2_311(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0D920 Offset: 0xE0CD20 VA: 0x180E0D920
	internal string <.cctor>b__2_312() { }

	// RVA: 0xE0D980 Offset: 0xE0CD80 VA: 0x180E0D980
	internal void <.cctor>b__2_313(string str) { }

	// RVA: 0xE0DA20 Offset: 0xE0CE20 VA: 0x180E0DA20
	internal void <.cctor>b__2_314(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0DA80 Offset: 0xE0CE80 VA: 0x180E0DA80
	internal void <.cctor>b__2_315(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0DAE0 Offset: 0xE0CEE0 VA: 0x180E0DAE0
	internal string <.cctor>b__2_316() { }

	// RVA: 0xE0DB40 Offset: 0xE0CF40 VA: 0x180E0DB40
	internal void <.cctor>b__2_317(string str) { }

	// RVA: 0xE0DBE0 Offset: 0xE0CFE0 VA: 0x180E0DBE0
	internal string <.cctor>b__2_318() { }

	// RVA: 0xE0DC40 Offset: 0xE0D040 VA: 0x180E0DC40
	internal void <.cctor>b__2_319(string str) { }

	// RVA: 0xE0DD70 Offset: 0xE0D170 VA: 0x180E0DD70
	internal string <.cctor>b__2_320() { }

	// RVA: 0xE0DDD0 Offset: 0xE0D1D0 VA: 0x180E0DDD0
	internal void <.cctor>b__2_321(string str) { }

	// RVA: 0xE0DE80 Offset: 0xE0D280 VA: 0x180E0DE80
	internal string <.cctor>b__2_322() { }

	// RVA: 0xE0DEE0 Offset: 0xE0D2E0 VA: 0x180E0DEE0
	internal void <.cctor>b__2_323(string str) { }

	// RVA: 0xE0DF90 Offset: 0xE0D390 VA: 0x180E0DF90
	internal string <.cctor>b__2_324() { }

	// RVA: 0xE0DFF0 Offset: 0xE0D3F0 VA: 0x180E0DFF0
	internal void <.cctor>b__2_325(string str) { }

	// RVA: 0xE0E0A0 Offset: 0xE0D4A0 VA: 0x180E0E0A0
	internal string <.cctor>b__2_326() { }

	// RVA: 0xE0E100 Offset: 0xE0D500 VA: 0x180E0E100
	internal void <.cctor>b__2_327(string str) { }

	// RVA: 0xE0E1B0 Offset: 0xE0D5B0 VA: 0x180E0E1B0
	internal string <.cctor>b__2_328() { }

	// RVA: 0xE0E260 Offset: 0xE0D660 VA: 0x180E0E260
	internal void <.cctor>b__2_329(string str) { }

	// RVA: 0xE0E360 Offset: 0xE0D760 VA: 0x180E0E360
	internal string <.cctor>b__2_330() { }

	// RVA: 0xE0E3C0 Offset: 0xE0D7C0 VA: 0x180E0E3C0
	internal void <.cctor>b__2_331(string str) { }

	// RVA: 0xE0E470 Offset: 0xE0D870 VA: 0x180E0E470
	internal string <.cctor>b__2_332() { }

	// RVA: 0xE0E4D0 Offset: 0xE0D8D0 VA: 0x180E0E4D0
	internal void <.cctor>b__2_333(string str) { }

	// RVA: 0xE0E570 Offset: 0xE0D970 VA: 0x180E0E570
	internal string <.cctor>b__2_334() { }

	// RVA: 0xE0E5D0 Offset: 0xE0D9D0 VA: 0x180E0E5D0
	internal void <.cctor>b__2_335(string str) { }

	// RVA: 0xE0E650 Offset: 0xE0DA50 VA: 0x180E0E650
	internal string <.cctor>b__2_336() { }

	// RVA: 0xE0E6B0 Offset: 0xE0DAB0 VA: 0x180E0E6B0
	internal void <.cctor>b__2_337(string str) { }

	// RVA: 0xE0E730 Offset: 0xE0DB30 VA: 0x180E0E730
	internal void <.cctor>b__2_338(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E740 Offset: 0xE0DB40 VA: 0x180E0E740
	internal void <.cctor>b__2_339(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E800 Offset: 0xE0DC00 VA: 0x180E0E800
	internal void <.cctor>b__2_340(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E810 Offset: 0xE0DC10 VA: 0x180E0E810
	internal void <.cctor>b__2_341(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E820 Offset: 0xE0DC20 VA: 0x180E0E820
	internal void <.cctor>b__2_342(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E830 Offset: 0xE0DC30 VA: 0x180E0E830
	internal void <.cctor>b__2_343(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0E840 Offset: 0xE0DC40 VA: 0x180E0E840
	internal string <.cctor>b__2_344() { }

	// RVA: 0xE0E8A0 Offset: 0xE0DCA0 VA: 0x180E0E8A0
	internal void <.cctor>b__2_345(string str) { }

	// RVA: 0xE0E940 Offset: 0xE0DD40 VA: 0x180E0E940
	internal string <.cctor>b__2_346() { }

	// RVA: 0xE0E9A0 Offset: 0xE0DDA0 VA: 0x180E0E9A0
	internal void <.cctor>b__2_347(string str) { }

	// RVA: 0xE0EA40 Offset: 0xE0DE40 VA: 0x180E0EA40
	internal string <.cctor>b__2_348() { }

	// RVA: 0xE0EAA0 Offset: 0xE0DEA0 VA: 0x180E0EAA0
	internal void <.cctor>b__2_349(string str) { }

	// RVA: 0xE0EBC0 Offset: 0xE0DFC0 VA: 0x180E0EBC0
	internal void <.cctor>b__2_350(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EC20 Offset: 0xE0E020 VA: 0x180E0EC20
	internal string <.cctor>b__2_351() { }

	// RVA: 0xE0EC80 Offset: 0xE0E080 VA: 0x180E0EC80
	internal void <.cctor>b__2_352(string str) { }

	// RVA: 0xE0ED20 Offset: 0xE0E120 VA: 0x180E0ED20
	internal string <.cctor>b__2_353() { }

	// RVA: 0xE0ED80 Offset: 0xE0E180 VA: 0x180E0ED80
	internal void <.cctor>b__2_354(string str) { }

	// RVA: 0xE0EE20 Offset: 0xE0E220 VA: 0x180E0EE20
	internal string <.cctor>b__2_355() { }

	// RVA: 0xE0EE80 Offset: 0xE0E280 VA: 0x180E0EE80
	internal void <.cctor>b__2_356(string str) { }

	// RVA: 0xE0EF20 Offset: 0xE0E320 VA: 0x180E0EF20
	internal void <.cctor>b__2_357(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0EF80 Offset: 0xE0E380 VA: 0x180E0EF80
	internal string <.cctor>b__2_358() { }

	// RVA: 0xE0F000 Offset: 0xE0E400 VA: 0x180E0F000
	internal void <.cctor>b__2_359(string str) { }

	// RVA: 0xE0F160 Offset: 0xE0E560 VA: 0x180E0F160
	internal string <.cctor>b__2_360() { }

	// RVA: 0xE0F1E0 Offset: 0xE0E5E0 VA: 0x180E0F1E0
	internal void <.cctor>b__2_361(string str) { }

	// RVA: 0xE0F290 Offset: 0xE0E690 VA: 0x180E0F290
	internal string <.cctor>b__2_362() { }

	// RVA: 0xE0F310 Offset: 0xE0E710 VA: 0x180E0F310
	internal void <.cctor>b__2_363(string str) { }

	// RVA: 0xE0F3C0 Offset: 0xE0E7C0 VA: 0x180E0F3C0
	internal string <.cctor>b__2_364() { }

	// RVA: 0xE0F420 Offset: 0xE0E820 VA: 0x180E0F420
	internal void <.cctor>b__2_365(string str) { }

	// RVA: 0xE0F4D0 Offset: 0xE0E8D0 VA: 0x180E0F4D0
	internal void <.cctor>b__2_366(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F540 Offset: 0xE0E940 VA: 0x180E0F540
	internal void <.cctor>b__2_367(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F5B0 Offset: 0xE0E9B0 VA: 0x180E0F5B0
	internal void <.cctor>b__2_368(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F620 Offset: 0xE0EA20 VA: 0x180E0F620
	internal void <.cctor>b__2_369(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F710 Offset: 0xE0EB10 VA: 0x180E0F710
	internal void <.cctor>b__2_370(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F770 Offset: 0xE0EB70 VA: 0x180E0F770
	internal void <.cctor>b__2_371(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0F7D0 Offset: 0xE0EBD0 VA: 0x180E0F7D0
	internal string <.cctor>b__2_372() { }

	// RVA: 0xE0F830 Offset: 0xE0EC30 VA: 0x180E0F830
	internal void <.cctor>b__2_373(string str) { }

	// RVA: 0xE0F8D0 Offset: 0xE0ECD0 VA: 0x180E0F8D0
	internal string <.cctor>b__2_374() { }

	// RVA: 0xE0F930 Offset: 0xE0ED30 VA: 0x180E0F930
	internal void <.cctor>b__2_375(string str) { }

	// RVA: 0xE0F9D0 Offset: 0xE0EDD0 VA: 0x180E0F9D0
	internal string <.cctor>b__2_376() { }

	// RVA: 0xE0FA50 Offset: 0xE0EE50 VA: 0x180E0FA50
	internal void <.cctor>b__2_377(string str) { }

	// RVA: 0xE0FB00 Offset: 0xE0EF00 VA: 0x180E0FB00
	internal string <.cctor>b__2_378() { }

	// RVA: 0xE0FB60 Offset: 0xE0EF60 VA: 0x180E0FB60
	internal void <.cctor>b__2_379(string str) { }

	// RVA: 0xE0FCA0 Offset: 0xE0F0A0 VA: 0x180E0FCA0
	internal string <.cctor>b__2_380() { }

	// RVA: 0xE0FD00 Offset: 0xE0F100 VA: 0x180E0FD00
	internal void <.cctor>b__2_381(string str) { }

	// RVA: 0xE0FDA0 Offset: 0xE0F1A0 VA: 0x180E0FDA0
	internal string <.cctor>b__2_382() { }

	// RVA: 0xE0FE20 Offset: 0xE0F220 VA: 0x180E0FE20
	internal void <.cctor>b__2_383(string str) { }

	// RVA: 0xE0FED0 Offset: 0xE0F2D0 VA: 0x180E0FED0
	internal void <.cctor>b__2_384(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FF30 Offset: 0xE0F330 VA: 0x180E0FF30
	internal void <.cctor>b__2_385(ConsoleSystem.Arg arg) { }

	// RVA: 0xE0FF90 Offset: 0xE0F390 VA: 0x180E0FF90
	internal void <.cctor>b__2_386(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10060 Offset: 0xE0F460 VA: 0x180E10060
	internal void <.cctor>b__2_387(ConsoleSystem.Arg arg) { }

	// RVA: 0xE100B0 Offset: 0xE0F4B0 VA: 0x180E100B0
	internal void <.cctor>b__2_388(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10110 Offset: 0xE0F510 VA: 0x180E10110
	internal string <.cctor>b__2_389() { }

	// RVA: 0xE10210 Offset: 0xE0F610 VA: 0x180E10210
	internal void <.cctor>b__2_390(string str) { }

	// RVA: 0xE102C0 Offset: 0xE0F6C0 VA: 0x180E102C0
	internal void <.cctor>b__2_391(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10320 Offset: 0xE0F720 VA: 0x180E10320
	internal void <.cctor>b__2_392(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10380 Offset: 0xE0F780 VA: 0x180E10380
	internal string <.cctor>b__2_393() { }

	// RVA: 0xE10400 Offset: 0xE0F800 VA: 0x180E10400
	internal void <.cctor>b__2_394(string str) { }

	// RVA: 0xE104B0 Offset: 0xE0F8B0 VA: 0x180E104B0
	internal string <.cctor>b__2_395() { }

	// RVA: 0xE10530 Offset: 0xE0F930 VA: 0x180E10530
	internal void <.cctor>b__2_396(string str) { }

	// RVA: 0xE105E0 Offset: 0xE0F9E0 VA: 0x180E105E0
	internal string <.cctor>b__2_397() { }

	// RVA: 0xE10640 Offset: 0xE0FA40 VA: 0x180E10640
	internal void <.cctor>b__2_398(string str) { }

	// RVA: 0xE106E0 Offset: 0xE0FAE0 VA: 0x180E106E0
	internal void <.cctor>b__2_399(ConsoleSystem.Arg arg) { }

	// RVA: 0xE108A0 Offset: 0xE0FCA0 VA: 0x180E108A0
	internal string <.cctor>b__2_400() { }

	// RVA: 0xE10920 Offset: 0xE0FD20 VA: 0x180E10920
	internal void <.cctor>b__2_401(string str) { }

	// RVA: 0xE10990 Offset: 0xE0FD90 VA: 0x180E10990
	internal string <.cctor>b__2_402() { }

	// RVA: 0xE109F0 Offset: 0xE0FDF0 VA: 0x180E109F0
	internal void <.cctor>b__2_403(string str) { }

	// RVA: 0xE10A70 Offset: 0xE0FE70 VA: 0x180E10A70
	internal void <.cctor>b__2_404(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10AD0 Offset: 0xE0FED0 VA: 0x180E10AD0
	internal void <.cctor>b__2_405(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10B30 Offset: 0xE0FF30 VA: 0x180E10B30
	internal void <.cctor>b__2_406(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10B90 Offset: 0xE0FF90 VA: 0x180E10B90
	internal string <.cctor>b__2_407() { }

	// RVA: 0xE10BF0 Offset: 0xE0FFF0 VA: 0x180E10BF0
	internal void <.cctor>b__2_408(string str) { }

	// RVA: 0xE10C90 Offset: 0xE10090 VA: 0x180E10C90
	internal void <.cctor>b__2_409(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10D70 Offset: 0xE10170 VA: 0x180E10D70
	internal string <.cctor>b__2_410() { }

	// RVA: 0xE10DD0 Offset: 0xE101D0 VA: 0x180E10DD0
	internal void <.cctor>b__2_411(string str) { }

	// RVA: 0xE10E50 Offset: 0xE10250 VA: 0x180E10E50
	internal void <.cctor>b__2_412(ConsoleSystem.Arg arg) { }

	// RVA: 0xE10EB0 Offset: 0xE102B0 VA: 0x180E10EB0
	internal string <.cctor>b__2_413() { }

	// RVA: 0xE10F10 Offset: 0xE10310 VA: 0x180E10F10
	internal void <.cctor>b__2_414(string str) { }

	// RVA: 0xE10FB0 Offset: 0xE103B0 VA: 0x180E10FB0
	internal string <.cctor>b__2_415() { }

	// RVA: 0xE11010 Offset: 0xE10410 VA: 0x180E11010
	internal void <.cctor>b__2_416(string str) { }

	// RVA: 0xE110B0 Offset: 0xE104B0 VA: 0x180E110B0
	internal void <.cctor>b__2_417(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11110 Offset: 0xE10510 VA: 0x180E11110
	internal string <.cctor>b__2_418() { }

	// RVA: 0xE11170 Offset: 0xE10570 VA: 0x180E11170
	internal void <.cctor>b__2_419(string str) { }

	// RVA: 0xE112C0 Offset: 0xE106C0 VA: 0x180E112C0
	internal string <.cctor>b__2_420() { }

	// RVA: 0xE11320 Offset: 0xE10720 VA: 0x180E11320
	internal void <.cctor>b__2_421(string str) { }

	// RVA: 0xE113C0 Offset: 0xE107C0 VA: 0x180E113C0
	internal string <.cctor>b__2_422() { }

	// RVA: 0xE11470 Offset: 0xE10870 VA: 0x180E11470
	internal void <.cctor>b__2_423(string str) { }

	// RVA: 0xE11500 Offset: 0xE10900 VA: 0x180E11500
	internal string <.cctor>b__2_424() { }

	// RVA: 0xE11560 Offset: 0xE10960 VA: 0x180E11560
	internal void <.cctor>b__2_425(string str) { }

	// RVA: 0xE11600 Offset: 0xE10A00 VA: 0x180E11600
	internal void <.cctor>b__2_426(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11650 Offset: 0xE10A50 VA: 0x180E11650
	internal string <.cctor>b__2_427() { }

	// RVA: 0xE116B0 Offset: 0xE10AB0 VA: 0x180E116B0
	internal void <.cctor>b__2_428(string str) { }

	// RVA: 0xE11750 Offset: 0xE10B50 VA: 0x180E11750
	internal string <.cctor>b__2_429() { }

	// RVA: 0xE11880 Offset: 0xE10C80 VA: 0x180E11880
	internal void <.cctor>b__2_430(string str) { }

	// RVA: 0xE11900 Offset: 0xE10D00 VA: 0x180E11900
	internal void <.cctor>b__2_431(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11990 Offset: 0xE10D90 VA: 0x180E11990
	internal void <.cctor>b__2_432(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11A00 Offset: 0xE10E00 VA: 0x180E11A00
	internal void <.cctor>b__2_433(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11A90 Offset: 0xE10E90 VA: 0x180E11A90
	internal void <.cctor>b__2_434(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11B00 Offset: 0xE10F00 VA: 0x180E11B00
	internal void <.cctor>b__2_435(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11B50 Offset: 0xE10F50 VA: 0x180E11B50
	internal void <.cctor>b__2_436(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11BE0 Offset: 0xE10FE0 VA: 0x180E11BE0
	internal void <.cctor>b__2_437(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11C30 Offset: 0xE11030 VA: 0x180E11C30
	internal void <.cctor>b__2_438(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11CA0 Offset: 0xE110A0 VA: 0x180E11CA0
	internal string <.cctor>b__2_439() { }

	// RVA: 0xE11DB0 Offset: 0xE111B0 VA: 0x180E11DB0
	internal void <.cctor>b__2_440(string str) { }

	// RVA: 0xE11E50 Offset: 0xE11250 VA: 0x180E11E50
	internal void <.cctor>b__2_441(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11EE0 Offset: 0xE112E0 VA: 0x180E11EE0
	internal void <.cctor>b__2_442(ConsoleSystem.Arg arg) { }

	// RVA: 0xE11F50 Offset: 0xE11350 VA: 0x180E11F50
	internal string <.cctor>b__2_443() { }

	// RVA: 0xE11FB0 Offset: 0xE113B0 VA: 0x180E11FB0
	internal void <.cctor>b__2_444(string str) { }

	// RVA: 0xE12060 Offset: 0xE11460 VA: 0x180E12060
	internal void <.cctor>b__2_445(ConsoleSystem.Arg arg) { }

	// RVA: 0xE120C0 Offset: 0xE114C0 VA: 0x180E120C0
	internal void <.cctor>b__2_446(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12130 Offset: 0xE11530 VA: 0x180E12130
	internal string <.cctor>b__2_447() { }

	// RVA: 0xE121E0 Offset: 0xE115E0 VA: 0x180E121E0
	internal void <.cctor>b__2_448(string str) { }

	// RVA: 0xE12260 Offset: 0xE11660 VA: 0x180E12260
	internal string <.cctor>b__2_449() { }

	// RVA: 0xE12340 Offset: 0xE11740 VA: 0x180E12340
	internal void <.cctor>b__2_450(string str) { }

	// RVA: 0xE123E0 Offset: 0xE117E0 VA: 0x180E123E0
	internal string <.cctor>b__2_451() { }

	// RVA: 0xE12440 Offset: 0xE11840 VA: 0x180E12440
	internal void <.cctor>b__2_452(string str) { }

	// RVA: 0xE124E0 Offset: 0xE118E0 VA: 0x180E124E0
	internal void <.cctor>b__2_453(ConsoleSystem.Arg arg) { }

	// RVA: 0xE12540 Offset: 0xE11940 VA: 0x180E12540
	internal string <.cctor>b__2_454() { }

	// RVA: 0xE125A0 Offset: 0xE119A0 VA: 0x180E125A0
	internal void <.cctor>b__2_455(string str) { }

	// RVA: 0xE12640 Offset: 0xE11A40 VA: 0x180E12640
	internal string <.cctor>b__2_456() { }

	// RVA: 0xE126A0 Offset: 0xE11AA0 VA: 0x180E126A0
	internal void <.cctor>b__2_457(string str) { }

	// RVA: 0xE12740 Offset: 0xE11B40 VA: 0x180E12740
	internal string <.cctor>b__2_458() { }

	// RVA: 0xE127A0 Offset: 0xE11BA0 VA: 0x180E127A0
	internal void <.cctor>b__2_459(string str) { }

	// RVA: 0xE128F0 Offset: 0xE11CF0 VA: 0x180E128F0
	internal string <.cctor>b__2_460() { }

	// RVA: 0xE12950 Offset: 0xE11D50 VA: 0x180E12950
	internal void <.cctor>b__2_461(string str) { }

	// RVA: 0xE129F0 Offset: 0xE11DF0 VA: 0x180E129F0
	internal string <.cctor>b__2_462() { }

	// RVA: 0xE12A50 Offset: 0xE11E50 VA: 0x180E12A50
	internal void <.cctor>b__2_463(string str) { }

	// RVA: 0xE12AF0 Offset: 0xE11EF0 VA: 0x180E12AF0
	internal string <.cctor>b__2_464() { }

	// RVA: 0xE12B50 Offset: 0xE11F50 VA: 0x180E12B50
	internal void <.cctor>b__2_465(string str) { }

	// RVA: 0xE12BF0 Offset: 0xE11FF0 VA: 0x180E12BF0
	internal string <.cctor>b__2_466() { }

	// RVA: 0xE12C50 Offset: 0xE12050 VA: 0x180E12C50
	internal void <.cctor>b__2_467(string str) { }

	// RVA: 0xE12CF0 Offset: 0xE120F0 VA: 0x180E12CF0
	internal string <.cctor>b__2_468() { }

	// RVA: 0xE12D50 Offset: 0xE12150 VA: 0x180E12D50
	internal void <.cctor>b__2_469(string str) { }

	// RVA: 0xE12E70 Offset: 0xE12270 VA: 0x180E12E70
	internal string <.cctor>b__2_470() { }

	// RVA: 0xE12ED0 Offset: 0xE122D0 VA: 0x180E12ED0
	internal void <.cctor>b__2_471(string str) { }

	// RVA: 0xE12F70 Offset: 0xE12370 VA: 0x180E12F70
	internal string <.cctor>b__2_472() { }

	// RVA: 0xE12FD0 Offset: 0xE123D0 VA: 0x180E12FD0
	internal void <.cctor>b__2_473(string str) { }

	// RVA: 0xE13070 Offset: 0xE12470 VA: 0x180E13070
	internal string <.cctor>b__2_474() { }

	// RVA: 0xE130D0 Offset: 0xE124D0 VA: 0x180E130D0
	internal void <.cctor>b__2_475(string str) { }

	// RVA: 0xE13170 Offset: 0xE12570 VA: 0x180E13170
	internal string <.cctor>b__2_476() { }

	// RVA: 0xE131D0 Offset: 0xE125D0 VA: 0x180E131D0
	internal void <.cctor>b__2_477(string str) { }

	// RVA: 0xE13270 Offset: 0xE12670 VA: 0x180E13270
	internal void <.cctor>b__2_478(ConsoleSystem.Arg arg) { }

	// RVA: 0xE132D0 Offset: 0xE126D0 VA: 0x180E132D0
	internal void <.cctor>b__2_479(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13390 Offset: 0xE12790 VA: 0x180E13390
	internal void <.cctor>b__2_480(ConsoleSystem.Arg arg) { }

	// RVA: 0xE133A0 Offset: 0xE127A0 VA: 0x180E133A0
	internal void <.cctor>b__2_481(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13400 Offset: 0xE12800 VA: 0x180E13400
	internal void <.cctor>b__2_482(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13410 Offset: 0xE12810 VA: 0x180E13410
	internal void <.cctor>b__2_483(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13420 Offset: 0xE12820 VA: 0x180E13420
	internal void <.cctor>b__2_484(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13430 Offset: 0xE12830 VA: 0x180E13430
	internal void <.cctor>b__2_485(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13440 Offset: 0xE12840 VA: 0x180E13440
	internal void <.cctor>b__2_486(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13450 Offset: 0xE12850 VA: 0x180E13450
	internal void <.cctor>b__2_487(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13460 Offset: 0xE12860 VA: 0x180E13460
	internal void <.cctor>b__2_488(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13470 Offset: 0xE12870 VA: 0x180E13470
	internal void <.cctor>b__2_489(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13500 Offset: 0xE12900 VA: 0x180E13500
	internal void <.cctor>b__2_490(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13510 Offset: 0xE12910 VA: 0x180E13510
	internal void <.cctor>b__2_491(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13520 Offset: 0xE12920 VA: 0x180E13520
	internal string <.cctor>b__2_492() { }

	// RVA: 0xE13540 Offset: 0xE12940 VA: 0x180E13540
	internal void <.cctor>b__2_493(string str) { }

	// RVA: 0xE135A0 Offset: 0xE129A0 VA: 0x180E135A0
	internal string <.cctor>b__2_494() { }

	// RVA: 0xE135D0 Offset: 0xE129D0 VA: 0x180E135D0
	internal void <.cctor>b__2_495(string str) { }

	// RVA: 0xE13630 Offset: 0xE12A30 VA: 0x180E13630
	internal string <.cctor>b__2_496() { }

	// RVA: 0xE13660 Offset: 0xE12A60 VA: 0x180E13660
	internal void <.cctor>b__2_497(string str) { }

	// RVA: 0xE136C0 Offset: 0xE12AC0 VA: 0x180E136C0
	internal string <.cctor>b__2_498() { }

	// RVA: 0xE136F0 Offset: 0xE12AF0 VA: 0x180E136F0
	internal void <.cctor>b__2_499(string str) { }

	// RVA: 0xE13880 Offset: 0xE12C80 VA: 0x180E13880
	internal string <.cctor>b__2_500() { }

	// RVA: 0xE138F0 Offset: 0xE12CF0 VA: 0x180E138F0
	internal void <.cctor>b__2_501(string str) { }

	// RVA: 0xE139A0 Offset: 0xE12DA0 VA: 0x180E139A0
	internal string <.cctor>b__2_502() { }

	// RVA: 0xE13A10 Offset: 0xE12E10 VA: 0x180E13A10
	internal void <.cctor>b__2_503(string str) { }

	// RVA: 0xE13AC0 Offset: 0xE12EC0 VA: 0x180E13AC0
	internal string <.cctor>b__2_504() { }

	// RVA: 0xE13B10 Offset: 0xE12F10 VA: 0x180E13B10
	internal void <.cctor>b__2_505(string str) { }

	// RVA: 0xE13B70 Offset: 0xE12F70 VA: 0x180E13B70
	internal string <.cctor>b__2_506() { }

	// RVA: 0xE13B90 Offset: 0xE12F90 VA: 0x180E13B90
	internal void <.cctor>b__2_507(string str) { }

	// RVA: 0xE13BF0 Offset: 0xE12FF0 VA: 0x180E13BF0
	internal void <.cctor>b__2_508(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13C50 Offset: 0xE13050 VA: 0x180E13C50
	internal string <.cctor>b__2_509() { }

	// RVA: 0xE13D80 Offset: 0xE13180 VA: 0x180E13D80
	internal void <.cctor>b__2_510(string str) { }

	// RVA: 0xE13E00 Offset: 0xE13200 VA: 0x180E13E00
	internal string <.cctor>b__2_511() { }

	// RVA: 0xE13E60 Offset: 0xE13260 VA: 0x180E13E60
	internal void <.cctor>b__2_512(string str) { }

	// RVA: 0xE13F00 Offset: 0xE13300 VA: 0x180E13F00
	internal void <.cctor>b__2_513(ConsoleSystem.Arg arg) { }

	// RVA: 0xE13F50 Offset: 0xE13350 VA: 0x180E13F50
	internal string <.cctor>b__2_514() { }

	// RVA: 0xE13FB0 Offset: 0xE133B0 VA: 0x180E13FB0
	internal void <.cctor>b__2_515(string str) { }

	// RVA: 0xE14050 Offset: 0xE13450 VA: 0x180E14050
	internal string <.cctor>b__2_516() { }

	// RVA: 0xE140B0 Offset: 0xE134B0 VA: 0x180E140B0
	internal void <.cctor>b__2_517(string str) { }

	// RVA: 0xE14130 Offset: 0xE13530 VA: 0x180E14130
	internal string <.cctor>b__2_518() { }

	// RVA: 0xE14190 Offset: 0xE13590 VA: 0x180E14190
	internal void <.cctor>b__2_519(string str) { }

	// RVA: 0xE142C0 Offset: 0xE136C0 VA: 0x180E142C0
	internal string <.cctor>b__2_520() { }

	// RVA: 0xE14320 Offset: 0xE13720 VA: 0x180E14320
	internal void <.cctor>b__2_521(string str) { }

	// RVA: 0xE143A0 Offset: 0xE137A0 VA: 0x180E143A0
	internal void <.cctor>b__2_522(ConsoleSystem.Arg arg) { }

	// RVA: 0xE143F0 Offset: 0xE137F0 VA: 0x180E143F0
	internal string <.cctor>b__2_523() { }

	// RVA: 0xE14450 Offset: 0xE13850 VA: 0x180E14450
	internal void <.cctor>b__2_524(string str) { }

	// RVA: 0xE144F0 Offset: 0xE138F0 VA: 0x180E144F0
	internal string <.cctor>b__2_525() { }

	// RVA: 0xE14550 Offset: 0xE13950 VA: 0x180E14550
	internal void <.cctor>b__2_526(string str) { }

	// RVA: 0xE145D0 Offset: 0xE139D0 VA: 0x180E145D0
	internal string <.cctor>b__2_527() { }

	// RVA: 0xE14680 Offset: 0xE13A80 VA: 0x180E14680
	internal void <.cctor>b__2_528(string str) { }

	// RVA: 0xE14700 Offset: 0xE13B00 VA: 0x180E14700
	internal string <.cctor>b__2_529() { }

	// RVA: 0xE14830 Offset: 0xE13C30 VA: 0x180E14830
	internal void <.cctor>b__2_530(string str) { }

	// RVA: 0xE148B0 Offset: 0xE13CB0 VA: 0x180E148B0
	internal void <.cctor>b__2_531(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14910 Offset: 0xE13D10 VA: 0x180E14910
	internal string <.cctor>b__2_532() { }

	// RVA: 0xE14970 Offset: 0xE13D70 VA: 0x180E14970
	internal void <.cctor>b__2_533(string str) { }

	// RVA: 0xE14A50 Offset: 0xE13E50 VA: 0x180E14A50
	internal void <.cctor>b__2_534(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14AB0 Offset: 0xE13EB0 VA: 0x180E14AB0
	internal void <.cctor>b__2_535(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14B10 Offset: 0xE13F10 VA: 0x180E14B10
	internal string <.cctor>b__2_536() { }

	// RVA: 0xE14B70 Offset: 0xE13F70 VA: 0x180E14B70
	internal void <.cctor>b__2_537(string str) { }

	// RVA: 0xE14C10 Offset: 0xE14010 VA: 0x180E14C10
	internal void <.cctor>b__2_538(ConsoleSystem.Arg arg) { }

	// RVA: 0xE14C70 Offset: 0xE14070 VA: 0x180E14C70
	internal string <.cctor>b__2_539() { }

	// RVA: 0xE14D80 Offset: 0xE14180 VA: 0x180E14D80
	internal void <.cctor>b__2_540(string str) { }

	// RVA: 0xE14E20 Offset: 0xE14220 VA: 0x180E14E20
	internal string <.cctor>b__2_541() { }

	// RVA: 0xE14E90 Offset: 0xE14290 VA: 0x180E14E90
	internal void <.cctor>b__2_542(string str) { }

	// RVA: 0xE14EF0 Offset: 0xE142F0 VA: 0x180E14EF0
	internal string <.cctor>b__2_543() { }

	// RVA: 0xE14F50 Offset: 0xE14350 VA: 0x180E14F50
	internal void <.cctor>b__2_544(string str) { }

	// RVA: 0xE14FF0 Offset: 0xE143F0 VA: 0x180E14FF0
	internal string <.cctor>b__2_545() { }

	// RVA: 0xE15050 Offset: 0xE14450 VA: 0x180E15050
	internal void <.cctor>b__2_546(string str) { }

	// RVA: 0xE150F0 Offset: 0xE144F0 VA: 0x180E150F0
	internal void <.cctor>b__2_547(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15150 Offset: 0xE14550 VA: 0x180E15150
	internal string <.cctor>b__2_548() { }

	// RVA: 0xE151B0 Offset: 0xE145B0 VA: 0x180E151B0
	internal void <.cctor>b__2_549(string str) { }

	// RVA: 0xE152D0 Offset: 0xE146D0 VA: 0x180E152D0
	internal string <.cctor>b__2_550() { }

	// RVA: 0xE15330 Offset: 0xE14730 VA: 0x180E15330
	internal void <.cctor>b__2_551(string str) { }

	// RVA: 0xE153D0 Offset: 0xE147D0 VA: 0x180E153D0
	internal string <.cctor>b__2_552() { }

	// RVA: 0xE15480 Offset: 0xE14880 VA: 0x180E15480
	internal void <.cctor>b__2_553(string str) { }

	// RVA: 0xE15500 Offset: 0xE14900 VA: 0x180E15500
	internal void <.cctor>b__2_554(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15560 Offset: 0xE14960 VA: 0x180E15560
	internal void <.cctor>b__2_555(ConsoleSystem.Arg arg) { }

	// RVA: 0xE155C0 Offset: 0xE149C0 VA: 0x180E155C0
	internal void <.cctor>b__2_556(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15620 Offset: 0xE14A20 VA: 0x180E15620
	internal string <.cctor>b__2_557() { }

	// RVA: 0xE15680 Offset: 0xE14A80 VA: 0x180E15680
	internal void <.cctor>b__2_558(string str) { }

	// RVA: 0xE15720 Offset: 0xE14B20 VA: 0x180E15720
	internal string <.cctor>b__2_559() { }

	// RVA: 0xE15880 Offset: 0xE14C80 VA: 0x180E15880
	internal void <.cctor>b__2_560(string str) { }

	// RVA: 0xE15960 Offset: 0xE14D60 VA: 0x180E15960
	internal string <.cctor>b__2_561() { }

	// RVA: 0xE159C0 Offset: 0xE14DC0 VA: 0x180E159C0
	internal void <.cctor>b__2_562(string str) { }

	// RVA: 0xE15A60 Offset: 0xE14E60 VA: 0x180E15A60
	internal string <.cctor>b__2_563() { }

	// RVA: 0xE15AC0 Offset: 0xE14EC0 VA: 0x180E15AC0
	internal void <.cctor>b__2_564(string str) { }

	// RVA: 0xE15B60 Offset: 0xE14F60 VA: 0x180E15B60
	internal string <.cctor>b__2_565() { }

	// RVA: 0xE15BC0 Offset: 0xE14FC0 VA: 0x180E15BC0
	internal void <.cctor>b__2_566(string str) { }

	// RVA: 0xE15C60 Offset: 0xE15060 VA: 0x180E15C60
	internal string <.cctor>b__2_567() { }

	// RVA: 0xE15CC0 Offset: 0xE150C0 VA: 0x180E15CC0
	internal void <.cctor>b__2_568(string str) { }

	// RVA: 0xE15D60 Offset: 0xE15160 VA: 0x180E15D60
	internal string <.cctor>b__2_569() { }

	// RVA: 0xE15E40 Offset: 0xE15240 VA: 0x180E15E40
	internal void <.cctor>b__2_570(string str) { }

	// RVA: 0xE15EE0 Offset: 0xE152E0 VA: 0x180E15EE0
	internal void <.cctor>b__2_571(ConsoleSystem.Arg arg) { }

	// RVA: 0xE15F40 Offset: 0xE15340 VA: 0x180E15F40
	internal string <.cctor>b__2_572() { }

	// RVA: 0xE15FA0 Offset: 0xE153A0 VA: 0x180E15FA0
	internal void <.cctor>b__2_573(string str) { }

	// RVA: 0xE16040 Offset: 0xE15440 VA: 0x180E16040
	internal void <.cctor>b__2_574(ConsoleSystem.Arg arg) { }

	// RVA: 0xE160A0 Offset: 0xE154A0 VA: 0x180E160A0
	internal void <.cctor>b__2_575(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16100 Offset: 0xE15500 VA: 0x180E16100
	internal void <.cctor>b__2_576(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16160 Offset: 0xE15560 VA: 0x180E16160
	internal void <.cctor>b__2_577(ConsoleSystem.Arg arg) { }

	// RVA: 0xE161C0 Offset: 0xE155C0 VA: 0x180E161C0
	internal string <.cctor>b__2_578() { }

	// RVA: 0xE16220 Offset: 0xE15620 VA: 0x180E16220
	internal void <.cctor>b__2_579(string str) { }

	// RVA: 0xE16380 Offset: 0xE15780 VA: 0x180E16380
	internal void <.cctor>b__2_580(ConsoleSystem.Arg arg) { }

	// RVA: 0xE163E0 Offset: 0xE157E0 VA: 0x180E163E0
	internal string <.cctor>b__2_581() { }

	// RVA: 0xE16440 Offset: 0xE15840 VA: 0x180E16440
	internal void <.cctor>b__2_582(string str) { }

	// RVA: 0xE164E0 Offset: 0xE158E0 VA: 0x180E164E0
	internal void <.cctor>b__2_583(ConsoleSystem.Arg arg) { }

	// RVA: 0xE16530 Offset: 0xE15930 VA: 0x180E16530
	internal string <.cctor>b__2_584() { }

	// RVA: 0xE165E0 Offset: 0xE159E0 VA: 0x180E165E0
	internal void <.cctor>b__2_585(string str) { }

	// RVA: 0xE16660 Offset: 0xE15A60 VA: 0x180E16660
	internal string <.cctor>b__2_586() { }

	// RVA: 0xE166C0 Offset: 0xE15AC0 VA: 0x180E166C0
	internal void <.cctor>b__2_587(string str) { }

	// RVA: 0xE16760 Offset: 0xE15B60 VA: 0x180E16760
	internal string <.cctor>b__2_588() { }

	// RVA: 0xE16810 Offset: 0xE15C10 VA: 0x180E16810
	internal void <.cctor>b__2_589(string str) { }

	// RVA: 0xE16910 Offset: 0xE15D10 VA: 0x180E16910
	internal string <.cctor>b__2_590() { }

	// RVA: 0xE16970 Offset: 0xE15D70 VA: 0x180E16970
	internal void <.cctor>b__2_591(string str) { }

	// RVA: 0xE16A10 Offset: 0xE15E10 VA: 0x180E16A10
	internal string <.cctor>b__2_592() { }

	// RVA: 0xE16A70 Offset: 0xE15E70 VA: 0x180E16A70
	internal void <.cctor>b__2_593(string str) { }

	// RVA: 0xE16B10 Offset: 0xE15F10 VA: 0x180E16B10
	internal string <.cctor>b__2_594() { }

	// RVA: 0xE16B70 Offset: 0xE15F70 VA: 0x180E16B70
	internal void <.cctor>b__2_595(string str) { }

	// RVA: 0xE16C10 Offset: 0xE16010 VA: 0x180E16C10
	internal string <.cctor>b__2_596() { }

	// RVA: 0xE16C70 Offset: 0xE16070 VA: 0x180E16C70
	internal void <.cctor>b__2_597(string str) { }

	// RVA: 0xE16D10 Offset: 0xE16110 VA: 0x180E16D10
	internal string <.cctor>b__2_598() { }

	// RVA: 0xE16D70 Offset: 0xE16170 VA: 0x180E16D70
	internal void <.cctor>b__2_599(string str) { }

	// RVA: 0xE16F20 Offset: 0xE16320 VA: 0x180E16F20
	internal string <.cctor>b__2_600() { }

	// RVA: 0xE16F80 Offset: 0xE16380 VA: 0x180E16F80
	internal void <.cctor>b__2_601(string str) { }

	// RVA: 0xE17020 Offset: 0xE16420 VA: 0x180E17020
	internal string <.cctor>b__2_602() { }

	// RVA: 0xE17080 Offset: 0xE16480 VA: 0x180E17080
	internal void <.cctor>b__2_603(string str) { }

	// RVA: 0xE17120 Offset: 0xE16520 VA: 0x180E17120
	internal string <.cctor>b__2_604() { }

	// RVA: 0xE17180 Offset: 0xE16580 VA: 0x180E17180
	internal void <.cctor>b__2_605(string str) { }

	// RVA: 0xE17230 Offset: 0xE16630 VA: 0x180E17230
	internal string <.cctor>b__2_606() { }

	// RVA: 0xE17290 Offset: 0xE16690 VA: 0x180E17290
	internal void <.cctor>b__2_607(string str) { }

	// RVA: 0xE17340 Offset: 0xE16740 VA: 0x180E17340
	internal string <.cctor>b__2_608() { }

	// RVA: 0xE173A0 Offset: 0xE167A0 VA: 0x180E173A0
	internal void <.cctor>b__2_609(string str) { }

	// RVA: 0xE174C0 Offset: 0xE168C0 VA: 0x180E174C0
	internal string <.cctor>b__2_610() { }

	// RVA: 0xE17520 Offset: 0xE16920 VA: 0x180E17520
	internal void <.cctor>b__2_611(string str) { }

	// RVA: 0xE175D0 Offset: 0xE169D0 VA: 0x180E175D0
	internal void <.cctor>b__2_612(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17630 Offset: 0xE16A30 VA: 0x180E17630
	internal void <.cctor>b__2_613(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17690 Offset: 0xE16A90 VA: 0x180E17690
	internal string <.cctor>b__2_614() { }

	// RVA: 0xE176F0 Offset: 0xE16AF0 VA: 0x180E176F0
	internal void <.cctor>b__2_615(string str) { }

	// RVA: 0xE177A0 Offset: 0xE16BA0 VA: 0x180E177A0
	internal string <.cctor>b__2_616() { }

	// RVA: 0xE17800 Offset: 0xE16C00 VA: 0x180E17800
	internal void <.cctor>b__2_617(string str) { }

	// RVA: 0xE178A0 Offset: 0xE16CA0 VA: 0x180E178A0
	internal void <.cctor>b__2_618(ConsoleSystem.Arg arg) { }

	// RVA: 0xE17900 Offset: 0xE16D00 VA: 0x180E17900
	internal string <.cctor>b__2_619() { }

	// RVA: 0xE17A10 Offset: 0xE16E10 VA: 0x180E17A10
	internal void <.cctor>b__2_620(string str) { }

	// RVA: 0xE17AC0 Offset: 0xE16EC0 VA: 0x180E17AC0
	internal string <.cctor>b__2_621() { }

	// RVA: 0xE17B70 Offset: 0xE16F70 VA: 0x180E17B70
	internal void <.cctor>b__2_622(string str) { }

	// RVA: 0xE17C00 Offset: 0xE17000 VA: 0x180E17C00
	internal string <.cctor>b__2_623() { }

	// RVA: 0xE17C60 Offset: 0xE17060 VA: 0x180E17C60
	internal void <.cctor>b__2_624(string str) { }

	// RVA: 0xE17D00 Offset: 0xE17100 VA: 0x180E17D00
	internal string <.cctor>b__2_625() { }

	// RVA: 0xE17D60 Offset: 0xE17160 VA: 0x180E17D60
	internal void <.cctor>b__2_626(string str) { }

	// RVA: 0xE17E00 Offset: 0xE17200 VA: 0x180E17E00
	internal string <.cctor>b__2_627() { }

	// RVA: 0xE17EB0 Offset: 0xE172B0 VA: 0x180E17EB0
	internal void <.cctor>b__2_628(string str) { }

	// RVA: 0xE17F30 Offset: 0xE17330 VA: 0x180E17F30
	internal string <.cctor>b__2_629() { }

	// RVA: 0xE18050 Offset: 0xE17450 VA: 0x180E18050
	internal void <.cctor>b__2_630(string str) { }

	// RVA: 0xE18110 Offset: 0xE17510 VA: 0x180E18110
	internal string <.cctor>b__2_631() { }

	// RVA: 0xE181C0 Offset: 0xE175C0 VA: 0x180E181C0
	internal void <.cctor>b__2_632(string str) { }

	// RVA: 0xE18290 Offset: 0xE17690 VA: 0x180E18290
	internal string <.cctor>b__2_633() { }

	// RVA: 0xE18330 Offset: 0xE17730 VA: 0x180E18330
	internal void <.cctor>b__2_634(string str) { }

	// RVA: 0xE183F0 Offset: 0xE177F0 VA: 0x180E183F0
	internal string <.cctor>b__2_635() { }

	// RVA: 0xE18450 Offset: 0xE17850 VA: 0x180E18450
	internal void <.cctor>b__2_636(string str) { }

	// RVA: 0xE18510 Offset: 0xE17910 VA: 0x180E18510
	internal string <.cctor>b__2_637() { }

	// RVA: 0xE18570 Offset: 0xE17970 VA: 0x180E18570
	internal void <.cctor>b__2_638(string str) { }

	// RVA: 0xE18600 Offset: 0xE17A00 VA: 0x180E18600
	internal string <.cctor>b__2_639() { }

	// RVA: 0xE18710 Offset: 0xE17B10 VA: 0x180E18710
	internal void <.cctor>b__2_640(string str) { }

	// RVA: 0xE18790 Offset: 0xE17B90 VA: 0x180E18790
	internal string <.cctor>b__2_641() { }

	// RVA: 0xE18840 Offset: 0xE17C40 VA: 0x180E18840
	internal void <.cctor>b__2_642(string str) { }

	// RVA: 0xE188C0 Offset: 0xE17CC0 VA: 0x180E188C0
	internal string <.cctor>b__2_643() { }

	// RVA: 0xE18920 Offset: 0xE17D20 VA: 0x180E18920
	internal void <.cctor>b__2_644(string str) { }

	// RVA: 0xE189A0 Offset: 0xE17DA0 VA: 0x180E189A0
	internal string <.cctor>b__2_645() { }

	// RVA: 0xE18A00 Offset: 0xE17E00 VA: 0x180E18A00
	internal void <.cctor>b__2_646(string str) { }

	// RVA: 0xE18AA0 Offset: 0xE17EA0 VA: 0x180E18AA0
	internal string <.cctor>b__2_647() { }

	// RVA: 0xE18B00 Offset: 0xE17F00 VA: 0x180E18B00
	internal void <.cctor>b__2_648(string str) { }

	// RVA: 0xE18BA0 Offset: 0xE17FA0 VA: 0x180E18BA0
	internal string <.cctor>b__2_649() { }

	// RVA: 0xE18C80 Offset: 0xE18080 VA: 0x180E18C80
	internal void <.cctor>b__2_650(string str) { }

	// RVA: 0xE18D20 Offset: 0xE18120 VA: 0x180E18D20
	internal string <.cctor>b__2_651() { }

	// RVA: 0xE18DD0 Offset: 0xE181D0 VA: 0x180E18DD0
	internal void <.cctor>b__2_652(string str) { }

	// RVA: 0xE18E60 Offset: 0xE18260 VA: 0x180E18E60
	internal void <.cctor>b__2_653(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18EC0 Offset: 0xE182C0 VA: 0x180E18EC0
	internal void <.cctor>b__2_654(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18F20 Offset: 0xE18320 VA: 0x180E18F20
	internal void <.cctor>b__2_655(ConsoleSystem.Arg arg) { }

	// RVA: 0xE18F70 Offset: 0xE18370 VA: 0x180E18F70
	internal string <.cctor>b__2_656() { }

	// RVA: 0xE19020 Offset: 0xE18420 VA: 0x180E19020
	internal void <.cctor>b__2_657(string str) { }

	// RVA: 0xE190A0 Offset: 0xE184A0 VA: 0x180E190A0
	internal void <.cctor>b__2_658(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19100 Offset: 0xE18500 VA: 0x180E19100
	internal string <.cctor>b__2_659() { }

	// RVA: 0xE19260 Offset: 0xE18660 VA: 0x180E19260
	internal void <.cctor>b__2_660(string str) { }

	// RVA: 0xE192E0 Offset: 0xE186E0 VA: 0x180E192E0
	internal void <.cctor>b__2_661(ConsoleSystem.Arg arg) { }

	// RVA: 0xE19340 Offset: 0xE18740 VA: 0x180E19340
	internal string <.cctor>b__2_662() { }

	// RVA: 0xE193A0 Offset: 0xE187A0 VA: 0x180E193A0
	internal void <.cctor>b__2_663(string str) { }

	// RVA: 0xE19420 Offset: 0xE18820 VA: 0x180E19420
	internal string <.cctor>b__2_664() { }

	// RVA: 0xE19480 Offset: 0xE18880 VA: 0x180E19480
	internal void <.cctor>b__2_665(string str) { }

	// RVA: 0xE19500 Offset: 0xE18900 VA: 0x180E19500
	internal string <.cctor>b__2_666() { }

	// RVA: 0xE195B0 Offset: 0xE189B0 VA: 0x180E195B0
	internal void <.cctor>b__2_667(string str) { }

	// RVA: 0xE19640 Offset: 0xE18A40 VA: 0x180E19640
	internal string <.cctor>b__2_668() { }

	// RVA: 0xE196A0 Offset: 0xE18AA0 VA: 0x180E196A0
	internal void <.cctor>b__2_669(string str) { }

	// RVA: 0xE197C0 Offset: 0xE18BC0 VA: 0x180E197C0
	internal string <.cctor>b__2_670() { }

	// RVA: 0xE19820 Offset: 0xE18C20 VA: 0x180E19820
	internal void <.cctor>b__2_671(string str) { }

	// RVA: 0xE198C0 Offset: 0xE18CC0 VA: 0x180E198C0
	internal string <.cctor>b__2_672() { }

	// RVA: 0xE19970 Offset: 0xE18D70 VA: 0x180E19970
	internal void <.cctor>b__2_673(string str) { }

	// RVA: 0xE199F0 Offset: 0xE18DF0 VA: 0x180E199F0
	internal string <.cctor>b__2_674() { }

	// RVA: 0xE19A50 Offset: 0xE18E50 VA: 0x180E19A50
	internal void <.cctor>b__2_675(string str) { }

	// RVA: 0xE19AD0 Offset: 0xE18ED0 VA: 0x180E19AD0
	internal string <.cctor>b__2_676() { }

	// RVA: 0xE19B80 Offset: 0xE18F80 VA: 0x180E19B80
	internal void <.cctor>b__2_677(string str) { }

	// RVA: 0xE19C10 Offset: 0xE19010 VA: 0x180E19C10
	internal string <.cctor>b__2_678() { }

	// RVA: 0xE19C70 Offset: 0xE19070 VA: 0x180E19C70
	internal void <.cctor>b__2_679(string str) { }

	// RVA: 0xE19DC0 Offset: 0xE191C0 VA: 0x180E19DC0
	internal string <.cctor>b__2_680() { }

	// RVA: 0xE19E20 Offset: 0xE19220 VA: 0x180E19E20
	internal void <.cctor>b__2_681(string str) { }

	// RVA: 0xE19EC0 Offset: 0xE192C0 VA: 0x180E19EC0
	internal string <.cctor>b__2_682() { }

	// RVA: 0xE19F20 Offset: 0xE19320 VA: 0x180E19F20
	internal void <.cctor>b__2_683(string str) { }

	// RVA: 0xE19FC0 Offset: 0xE193C0 VA: 0x180E19FC0
	internal string <.cctor>b__2_684() { }

	// RVA: 0xE1A020 Offset: 0xE19420 VA: 0x180E1A020
	internal void <.cctor>b__2_685(string str) { }

	// RVA: 0xE1A0C0 Offset: 0xE194C0 VA: 0x180E1A0C0
	internal string <.cctor>b__2_686() { }

	// RVA: 0xE1A120 Offset: 0xE19520 VA: 0x180E1A120
	internal void <.cctor>b__2_687(string str) { }

	// RVA: 0xE1A1C0 Offset: 0xE195C0 VA: 0x180E1A1C0
	internal string <.cctor>b__2_688() { }

	// RVA: 0xE1A220 Offset: 0xE19620 VA: 0x180E1A220
	internal void <.cctor>b__2_689(string str) { }

	// RVA: 0xE1A320 Offset: 0xE19720 VA: 0x180E1A320
	internal string <.cctor>b__2_690() { }

	// RVA: 0xE1A3D0 Offset: 0xE197D0 VA: 0x180E1A3D0
	internal void <.cctor>b__2_691(string str) { }

	// RVA: 0xE1A450 Offset: 0xE19850 VA: 0x180E1A450
	internal string <.cctor>b__2_692() { }

	// RVA: 0xE1A4B0 Offset: 0xE198B0 VA: 0x180E1A4B0
	internal void <.cctor>b__2_693(string str) { }

	// RVA: 0xE1A550 Offset: 0xE19950 VA: 0x180E1A550
	internal string <.cctor>b__2_694() { }

	// RVA: 0xE1A600 Offset: 0xE19A00 VA: 0x180E1A600
	internal void <.cctor>b__2_695(string str) { }

	// RVA: 0xE1A690 Offset: 0xE19A90 VA: 0x180E1A690
	internal string <.cctor>b__2_696() { }

	// RVA: 0xE1A740 Offset: 0xE19B40 VA: 0x180E1A740
	internal void <.cctor>b__2_697(string str) { }

	// RVA: 0xE1A7C0 Offset: 0xE19BC0 VA: 0x180E1A7C0
	internal void <.cctor>b__2_698(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1A820 Offset: 0xE19C20 VA: 0x180E1A820
	internal string <.cctor>b__2_699() { }

	// RVA: 0xE1AA00 Offset: 0xE19E00 VA: 0x180E1AA00
	internal void <.cctor>b__2_700(string str) { }

	// RVA: 0xE1AA90 Offset: 0xE19E90 VA: 0x180E1AA90
	internal string <.cctor>b__2_701() { }

	// RVA: 0xE1AB40 Offset: 0xE19F40 VA: 0x180E1AB40
	internal void <.cctor>b__2_702(string str) { }

	// RVA: 0xE1ABD0 Offset: 0xE19FD0 VA: 0x180E1ABD0
	internal string <.cctor>b__2_703() { }

	// RVA: 0xE1AC50 Offset: 0xE1A050 VA: 0x180E1AC50
	internal void <.cctor>b__2_704(string str) { }

	// RVA: 0xE1ACC0 Offset: 0xE1A0C0 VA: 0x180E1ACC0
	internal string <.cctor>b__2_705() { }

	// RVA: 0xE1AD40 Offset: 0xE1A140 VA: 0x180E1AD40
	internal void <.cctor>b__2_706(string str) { }

	// RVA: 0xE1ADA0 Offset: 0xE1A1A0 VA: 0x180E1ADA0
	internal void <.cctor>b__2_707(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1AE00 Offset: 0xE1A200 VA: 0x180E1AE00
	internal string <.cctor>b__2_708() { }

	// RVA: 0xE1AE80 Offset: 0xE1A280 VA: 0x180E1AE80
	internal void <.cctor>b__2_709(string str) { }

	// RVA: 0xE1AF70 Offset: 0xE1A370 VA: 0x180E1AF70
	internal string <.cctor>b__2_710() { }

	// RVA: 0xE1AFF0 Offset: 0xE1A3F0 VA: 0x180E1AFF0
	internal void <.cctor>b__2_711(string str) { }

	// RVA: 0xE1B060 Offset: 0xE1A460 VA: 0x180E1B060
	internal string <.cctor>b__2_712() { }

	// RVA: 0xE1B0E0 Offset: 0xE1A4E0 VA: 0x180E1B0E0
	internal void <.cctor>b__2_713(string str) { }

	// RVA: 0xE1B150 Offset: 0xE1A550 VA: 0x180E1B150
	internal string <.cctor>b__2_714() { }

	// RVA: 0xE1B1B0 Offset: 0xE1A5B0 VA: 0x180E1B1B0
	internal void <.cctor>b__2_715(string str) { }

	// RVA: 0xE1B250 Offset: 0xE1A650 VA: 0x180E1B250
	internal string <.cctor>b__2_716() { }

	// RVA: 0xE1B2B0 Offset: 0xE1A6B0 VA: 0x180E1B2B0
	internal void <.cctor>b__2_717(string str) { }

	// RVA: 0xE1B350 Offset: 0xE1A750 VA: 0x180E1B350
	internal string <.cctor>b__2_718() { }

	// RVA: 0xE1B3B0 Offset: 0xE1A7B0 VA: 0x180E1B3B0
	internal void <.cctor>b__2_719(string str) { }

	// RVA: 0xE1B510 Offset: 0xE1A910 VA: 0x180E1B510
	internal string <.cctor>b__2_720() { }

	// RVA: 0xE1B570 Offset: 0xE1A970 VA: 0x180E1B570
	internal void <.cctor>b__2_721(string str) { }

	// RVA: 0xE1B610 Offset: 0xE1AA10 VA: 0x180E1B610
	internal string <.cctor>b__2_722() { }

	// RVA: 0xE1B670 Offset: 0xE1AA70 VA: 0x180E1B670
	internal void <.cctor>b__2_723(string str) { }

	// RVA: 0xE1B710 Offset: 0xE1AB10 VA: 0x180E1B710
	internal void <.cctor>b__2_724(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B780 Offset: 0xE1AB80 VA: 0x180E1B780
	internal void <.cctor>b__2_725(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1B7E0 Offset: 0xE1ABE0 VA: 0x180E1B7E0
	internal string <.cctor>b__2_726() { }

	// RVA: 0xE1B840 Offset: 0xE1AC40 VA: 0x180E1B840
	internal void <.cctor>b__2_727(string str) { }

	// RVA: 0xE1B8E0 Offset: 0xE1ACE0 VA: 0x180E1B8E0
	internal string <.cctor>b__2_728() { }

	// RVA: 0xE1B940 Offset: 0xE1AD40 VA: 0x180E1B940
	internal void <.cctor>b__2_729(string str) { }

	// RVA: 0xE1BA70 Offset: 0xE1AE70 VA: 0x180E1BA70
	internal string <.cctor>b__2_730() { }

	// RVA: 0xE1BAD0 Offset: 0xE1AED0 VA: 0x180E1BAD0
	internal void <.cctor>b__2_731(string str) { }

	// RVA: 0xE1BB80 Offset: 0xE1AF80 VA: 0x180E1BB80
	internal string <.cctor>b__2_732() { }

	// RVA: 0xE1BBE0 Offset: 0xE1AFE0 VA: 0x180E1BBE0
	internal void <.cctor>b__2_733(string str) { }

	// RVA: 0xE1BC80 Offset: 0xE1B080 VA: 0x180E1BC80
	internal string <.cctor>b__2_734() { }

	// RVA: 0xE1BCE0 Offset: 0xE1B0E0 VA: 0x180E1BCE0
	internal void <.cctor>b__2_735(string str) { }

	// RVA: 0xE1BD80 Offset: 0xE1B180 VA: 0x180E1BD80
	internal string <.cctor>b__2_736() { }

	// RVA: 0xE1BDE0 Offset: 0xE1B1E0 VA: 0x180E1BDE0
	internal void <.cctor>b__2_737(string str) { }

	// RVA: 0xE1BE80 Offset: 0xE1B280 VA: 0x180E1BE80
	internal string <.cctor>b__2_738() { }

	// RVA: 0xE1BEE0 Offset: 0xE1B2E0 VA: 0x180E1BEE0
	internal void <.cctor>b__2_739(string str) { }

	// RVA: 0xE1C040 Offset: 0xE1B440 VA: 0x180E1C040
	internal void <.cctor>b__2_740(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C0A0 Offset: 0xE1B4A0 VA: 0x180E1C0A0
	internal void <.cctor>b__2_741(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C100 Offset: 0xE1B500 VA: 0x180E1C100
	internal string <.cctor>b__2_742() { }

	// RVA: 0xE1C1B0 Offset: 0xE1B5B0 VA: 0x180E1C1B0
	internal void <.cctor>b__2_743(string str) { }

	// RVA: 0xE1C230 Offset: 0xE1B630 VA: 0x180E1C230
	internal string <.cctor>b__2_744() { }

	// RVA: 0xE1C2E0 Offset: 0xE1B6E0 VA: 0x180E1C2E0
	internal void <.cctor>b__2_745(string str) { }

	// RVA: 0xE1C3C0 Offset: 0xE1B7C0 VA: 0x180E1C3C0
	internal void <.cctor>b__2_746(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C420 Offset: 0xE1B820 VA: 0x180E1C420
	internal void <.cctor>b__2_747(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C480 Offset: 0xE1B880 VA: 0x180E1C480
	internal void <.cctor>b__2_748(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C4E0 Offset: 0xE1B8E0 VA: 0x180E1C4E0
	internal void <.cctor>b__2_749(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C5C0 Offset: 0xE1B9C0 VA: 0x180E1C5C0
	internal void <.cctor>b__2_750(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C620 Offset: 0xE1BA20 VA: 0x180E1C620
	internal void <.cctor>b__2_751(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C680 Offset: 0xE1BA80 VA: 0x180E1C680
	internal void <.cctor>b__2_752(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C6E0 Offset: 0xE1BAE0 VA: 0x180E1C6E0
	internal string <.cctor>b__2_753() { }

	// RVA: 0xE1C740 Offset: 0xE1BB40 VA: 0x180E1C740
	internal void <.cctor>b__2_754(string str) { }

	// RVA: 0xE1C7E0 Offset: 0xE1BBE0 VA: 0x180E1C7E0
	internal void <.cctor>b__2_755(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C840 Offset: 0xE1BC40 VA: 0x180E1C840
	internal void <.cctor>b__2_756(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C8A0 Offset: 0xE1BCA0 VA: 0x180E1C8A0
	internal void <.cctor>b__2_757(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C900 Offset: 0xE1BD00 VA: 0x180E1C900
	internal void <.cctor>b__2_758(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1C960 Offset: 0xE1BD60 VA: 0x180E1C960
	internal void <.cctor>b__2_759(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CA60 Offset: 0xE1BE60 VA: 0x180E1CA60
	internal void <.cctor>b__2_760(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CAB0 Offset: 0xE1BEB0 VA: 0x180E1CAB0
	internal string <.cctor>b__2_761() { }

	// RVA: 0xE1CB60 Offset: 0xE1BF60 VA: 0x180E1CB60
	internal void <.cctor>b__2_762(string str) { }

	// RVA: 0xE1CBF0 Offset: 0xE1BFF0 VA: 0x180E1CBF0
	internal void <.cctor>b__2_763(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CC50 Offset: 0xE1C050 VA: 0x180E1CC50
	internal void <.cctor>b__2_764(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CCA0 Offset: 0xE1C0A0 VA: 0x180E1CCA0
	internal void <.cctor>b__2_765(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CCF0 Offset: 0xE1C0F0 VA: 0x180E1CCF0
	internal void <.cctor>b__2_766(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CD40 Offset: 0xE1C140 VA: 0x180E1CD40
	internal void <.cctor>b__2_767(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CD50 Offset: 0xE1C150 VA: 0x180E1CD50
	internal void <.cctor>b__2_768(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CD60 Offset: 0xE1C160 VA: 0x180E1CD60
	internal void <.cctor>b__2_769(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CDF0 Offset: 0xE1C1F0 VA: 0x180E1CDF0
	internal void <.cctor>b__2_770(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1CE00 Offset: 0xE1C200 VA: 0x180E1CE00
	internal string <.cctor>b__2_771() { }

	// RVA: 0xE1CE60 Offset: 0xE1C260 VA: 0x180E1CE60
	internal void <.cctor>b__2_772(string str) { }

	// RVA: 0xE1CF00 Offset: 0xE1C300 VA: 0x180E1CF00
	internal string <.cctor>b__2_773() { }

	// RVA: 0xE1CF60 Offset: 0xE1C360 VA: 0x180E1CF60
	internal void <.cctor>b__2_774(string str) { }

	// RVA: 0xE1D010 Offset: 0xE1C410 VA: 0x180E1D010
	internal string <.cctor>b__2_775() { }

	// RVA: 0xE1D070 Offset: 0xE1C470 VA: 0x180E1D070
	internal void <.cctor>b__2_776(string str) { }

	// RVA: 0xE1D120 Offset: 0xE1C520 VA: 0x180E1D120
	internal string <.cctor>b__2_777() { }

	// RVA: 0xE1D180 Offset: 0xE1C580 VA: 0x180E1D180
	internal void <.cctor>b__2_778(string str) { }

	// RVA: 0xE1D230 Offset: 0xE1C630 VA: 0x180E1D230
	internal string <.cctor>b__2_779() { }

	// RVA: 0xE1D340 Offset: 0xE1C740 VA: 0x180E1D340
	internal void <.cctor>b__2_780(string str) { }

	// RVA: 0xE1D3D0 Offset: 0xE1C7D0 VA: 0x180E1D3D0
	internal string <.cctor>b__2_781() { }

	// RVA: 0xE1D470 Offset: 0xE1C870 VA: 0x180E1D470
	internal void <.cctor>b__2_782(string str) { }

	// RVA: 0xE1D530 Offset: 0xE1C930 VA: 0x180E1D530
	internal string <.cctor>b__2_783() { }

	// RVA: 0xE1D590 Offset: 0xE1C990 VA: 0x180E1D590
	internal void <.cctor>b__2_784(string str) { }

	// RVA: 0xE1D630 Offset: 0xE1CA30 VA: 0x180E1D630
	internal string <.cctor>b__2_785() { }

	// RVA: 0xE1D690 Offset: 0xE1CA90 VA: 0x180E1D690
	internal void <.cctor>b__2_786(string str) { }

	// RVA: 0xE1D720 Offset: 0xE1CB20 VA: 0x180E1D720
	internal string <.cctor>b__2_787() { }

	// RVA: 0xE1D780 Offset: 0xE1CB80 VA: 0x180E1D780
	internal void <.cctor>b__2_788(string str) { }

	// RVA: 0xE1D810 Offset: 0xE1CC10 VA: 0x180E1D810
	internal string <.cctor>b__2_789() { }

	// RVA: 0xE1D8F0 Offset: 0xE1CCF0 VA: 0x180E1D8F0
	internal void <.cctor>b__2_790(string str) { }

	// RVA: 0xE1D980 Offset: 0xE1CD80 VA: 0x180E1D980
	internal string <.cctor>b__2_791() { }

	// RVA: 0xE1D9E0 Offset: 0xE1CDE0 VA: 0x180E1D9E0
	internal void <.cctor>b__2_792(string str) { }

	// RVA: 0xE1DA70 Offset: 0xE1CE70 VA: 0x180E1DA70
	internal string <.cctor>b__2_793() { }

	// RVA: 0xE1DB10 Offset: 0xE1CF10 VA: 0x180E1DB10
	internal void <.cctor>b__2_794(string str) { }

	// RVA: 0xE1DB90 Offset: 0xE1CF90 VA: 0x180E1DB90
	internal void <.cctor>b__2_795(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1DBF0 Offset: 0xE1CFF0 VA: 0x180E1DBF0
	internal void <.cctor>b__2_796(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1DC20 Offset: 0xE1D020 VA: 0x180E1DC20
	internal void <.cctor>b__2_797(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1DC30 Offset: 0xE1D030 VA: 0x180E1DC30
	internal void <.cctor>b__2_798(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1DC40 Offset: 0xE1D040 VA: 0x180E1DC40
	internal void <.cctor>b__2_799(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1DD70 Offset: 0xE1D170 VA: 0x180E1DD70
	internal string <.cctor>b__2_800() { }

	// RVA: 0xE1DE20 Offset: 0xE1D220 VA: 0x180E1DE20
	internal void <.cctor>b__2_801(string str) { }

	// RVA: 0xE1DEB0 Offset: 0xE1D2B0 VA: 0x180E1DEB0
	internal string <.cctor>b__2_802() { }

	// RVA: 0xE1DF10 Offset: 0xE1D310 VA: 0x180E1DF10
	internal void <.cctor>b__2_803(string str) { }

	// RVA: 0xE1DFB0 Offset: 0xE1D3B0 VA: 0x180E1DFB0
	internal void <.cctor>b__2_804(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E010 Offset: 0xE1D410 VA: 0x180E1E010
	internal string <.cctor>b__2_805() { }

	// RVA: 0xE1E070 Offset: 0xE1D470 VA: 0x180E1E070
	internal void <.cctor>b__2_806(string str) { }

	// RVA: 0xE1E110 Offset: 0xE1D510 VA: 0x180E1E110
	internal string <.cctor>b__2_807() { }

	// RVA: 0xE1E170 Offset: 0xE1D570 VA: 0x180E1E170
	internal void <.cctor>b__2_808(string str) { }

	// RVA: 0xE1E210 Offset: 0xE1D610 VA: 0x180E1E210
	internal string <.cctor>b__2_809() { }

	// RVA: 0xE1E2F0 Offset: 0xE1D6F0 VA: 0x180E1E2F0
	internal void <.cctor>b__2_810(string str) { }

	// RVA: 0xE1E390 Offset: 0xE1D790 VA: 0x180E1E390
	internal string <.cctor>b__2_811() { }

	// RVA: 0xE1E3F0 Offset: 0xE1D7F0 VA: 0x180E1E3F0
	internal void <.cctor>b__2_812(string str) { }

	// RVA: 0xE1E490 Offset: 0xE1D890 VA: 0x180E1E490
	internal string <.cctor>b__2_813() { }

	// RVA: 0xE1E510 Offset: 0xE1D910 VA: 0x180E1E510
	internal void <.cctor>b__2_814(string str) { }

	// RVA: 0xE1E580 Offset: 0xE1D980 VA: 0x180E1E580
	internal string <.cctor>b__2_815() { }

	// RVA: 0xE1E600 Offset: 0xE1DA00 VA: 0x180E1E600
	internal void <.cctor>b__2_816(string str) { }

	// RVA: 0xE1E670 Offset: 0xE1DA70 VA: 0x180E1E670
	internal string <.cctor>b__2_817() { }

	// RVA: 0xE1E6D0 Offset: 0xE1DAD0 VA: 0x180E1E6D0
	internal void <.cctor>b__2_818(string str) { }

	// RVA: 0xE1E780 Offset: 0xE1DB80 VA: 0x180E1E780
	internal void <.cctor>b__2_819(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E840 Offset: 0xE1DC40 VA: 0x180E1E840
	internal void <.cctor>b__2_820(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E850 Offset: 0xE1DC50 VA: 0x180E1E850
	internal void <.cctor>b__2_821(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E860 Offset: 0xE1DC60 VA: 0x180E1E860
	internal void <.cctor>b__2_822(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E870 Offset: 0xE1DC70 VA: 0x180E1E870
	internal void <.cctor>b__2_823(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1E880 Offset: 0xE1DC80 VA: 0x180E1E880
	internal string <.cctor>b__2_824() { }

	// RVA: 0xE1E8E0 Offset: 0xE1DCE0 VA: 0x180E1E8E0
	internal void <.cctor>b__2_825(string str) { }

	// RVA: 0xE1E980 Offset: 0xE1DD80 VA: 0x180E1E980
	internal string <.cctor>b__2_826() { }

	// RVA: 0xE1EA30 Offset: 0xE1DE30 VA: 0x180E1EA30
	internal void <.cctor>b__2_827(string str) { }

	// RVA: 0xE1EAC0 Offset: 0xE1DEC0 VA: 0x180E1EAC0
	internal string <.cctor>b__2_828() { }

	// RVA: 0xE1EB20 Offset: 0xE1DF20 VA: 0x180E1EB20
	internal void <.cctor>b__2_829(string str) { }

	// RVA: 0xE1EC40 Offset: 0xE1E040 VA: 0x180E1EC40
	internal string <.cctor>b__2_830() { }

	// RVA: 0xE1ECA0 Offset: 0xE1E0A0 VA: 0x180E1ECA0
	internal void <.cctor>b__2_831(string str) { }

	// RVA: 0xE1ED20 Offset: 0xE1E120 VA: 0x180E1ED20
	internal string <.cctor>b__2_832() { }

	// RVA: 0xE1ED80 Offset: 0xE1E180 VA: 0x180E1ED80
	internal void <.cctor>b__2_833(string str) { }

	// RVA: 0xE1EE20 Offset: 0xE1E220 VA: 0x180E1EE20
	internal string <.cctor>b__2_834() { }

	// RVA: 0xE1EE80 Offset: 0xE1E280 VA: 0x180E1EE80
	internal void <.cctor>b__2_835(string str) { }

	// RVA: 0xE1EF10 Offset: 0xE1E310 VA: 0x180E1EF10
	internal string <.cctor>b__2_836() { }

	// RVA: 0xE1EF70 Offset: 0xE1E370 VA: 0x180E1EF70
	internal void <.cctor>b__2_837(string str) { }

	// RVA: 0xE1F010 Offset: 0xE1E410 VA: 0x180E1F010
	internal string <.cctor>b__2_838() { }

	// RVA: 0xE1F070 Offset: 0xE1E470 VA: 0x180E1F070
	internal void <.cctor>b__2_839(string str) { }

	// RVA: 0xE1F1B0 Offset: 0xE1E5B0 VA: 0x180E1F1B0
	internal void <.cctor>b__2_840(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F210 Offset: 0xE1E610 VA: 0x180E1F210
	internal void <.cctor>b__2_841(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F270 Offset: 0xE1E670 VA: 0x180E1F270
	internal void <.cctor>b__2_842(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F2D0 Offset: 0xE1E6D0 VA: 0x180E1F2D0
	internal string <.cctor>b__2_843() { }

	// RVA: 0xE1F330 Offset: 0xE1E730 VA: 0x180E1F330
	internal void <.cctor>b__2_844(string str) { }

	// RVA: 0xE1F3D0 Offset: 0xE1E7D0 VA: 0x180E1F3D0
	internal string <.cctor>b__2_845() { }

	// RVA: 0xE1F430 Offset: 0xE1E830 VA: 0x180E1F430
	internal void <.cctor>b__2_846(string str) { }

	// RVA: 0xE1F4D0 Offset: 0xE1E8D0 VA: 0x180E1F4D0
	internal string <.cctor>b__2_847() { }

	// RVA: 0xE1F530 Offset: 0xE1E930 VA: 0x180E1F530
	internal void <.cctor>b__2_848(string str) { }

	// RVA: 0xE1F5D0 Offset: 0xE1E9D0 VA: 0x180E1F5D0
	internal string <.cctor>b__2_849() { }

	// RVA: 0xE1F6B0 Offset: 0xE1EAB0 VA: 0x180E1F6B0
	internal void <.cctor>b__2_850(string str) { }

	// RVA: 0xE1F760 Offset: 0xE1EB60 VA: 0x180E1F760
	internal string <.cctor>b__2_851() { }

	// RVA: 0xE1F7C0 Offset: 0xE1EBC0 VA: 0x180E1F7C0
	internal void <.cctor>b__2_852(string str) { }

	// RVA: 0xE1F870 Offset: 0xE1EC70 VA: 0x180E1F870
	internal void <.cctor>b__2_853(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1F8D0 Offset: 0xE1ECD0 VA: 0x180E1F8D0
	internal string <.cctor>b__2_854() { }

	// RVA: 0xE1F930 Offset: 0xE1ED30 VA: 0x180E1F930
	internal void <.cctor>b__2_855(string str) { }

	// RVA: 0xE1F9E0 Offset: 0xE1EDE0 VA: 0x180E1F9E0
	internal string <.cctor>b__2_856() { }

	// RVA: 0xE1FA40 Offset: 0xE1EE40 VA: 0x180E1FA40
	internal void <.cctor>b__2_857(string str) { }

	// RVA: 0xE1FAF0 Offset: 0xE1EEF0 VA: 0x180E1FAF0
	internal string <.cctor>b__2_858() { }

	// RVA: 0xE1FB50 Offset: 0xE1EF50 VA: 0x180E1FB50
	internal void <.cctor>b__2_859(string str) { }

	// RVA: 0xE1FCB0 Offset: 0xE1F0B0 VA: 0x180E1FCB0
	internal void <.cctor>b__2_860(ConsoleSystem.Arg arg) { }

	// RVA: 0xE1FD10 Offset: 0xE1F110 VA: 0x180E1FD10
	internal string <.cctor>b__2_861() { }

	// RVA: 0xE1FD70 Offset: 0xE1F170 VA: 0x180E1FD70
	internal void <.cctor>b__2_862(string str) { }

	// RVA: 0xE1FE10 Offset: 0xE1F210 VA: 0x180E1FE10
	internal string <.cctor>b__2_863() { }

	// RVA: 0xE1FE70 Offset: 0xE1F270 VA: 0x180E1FE70
	internal void <.cctor>b__2_864(string str) { }

	// RVA: 0xE1FF10 Offset: 0xE1F310 VA: 0x180E1FF10
	internal string <.cctor>b__2_865() { }

	// RVA: 0xE1FF70 Offset: 0xE1F370 VA: 0x180E1FF70
	internal void <.cctor>b__2_866(string str) { }

	// RVA: 0xE20010 Offset: 0xE1F410 VA: 0x180E20010
	internal string <.cctor>b__2_867() { }

	// RVA: 0xE20070 Offset: 0xE1F470 VA: 0x180E20070
	internal void <.cctor>b__2_868(string str) { }

	// RVA: 0xE20110 Offset: 0xE1F510 VA: 0x180E20110
	internal string <.cctor>b__2_869() { }

	// RVA: 0xE20240 Offset: 0xE1F640 VA: 0x180E20240
	internal void <.cctor>b__2_870(string str) { }

	// RVA: 0xE202C0 Offset: 0xE1F6C0 VA: 0x180E202C0
	internal string <.cctor>b__2_871() { }

	// RVA: 0xE20320 Offset: 0xE1F720 VA: 0x180E20320
	internal void <.cctor>b__2_872(string str) { }

	// RVA: 0xE203D0 Offset: 0xE1F7D0 VA: 0x180E203D0
	internal string <.cctor>b__2_873() { }

	// RVA: 0xE20430 Offset: 0xE1F830 VA: 0x180E20430
	internal void <.cctor>b__2_874(string str) { }

	// RVA: 0xE204E0 Offset: 0xE1F8E0 VA: 0x180E204E0
	internal string <.cctor>b__2_875() { }

	// RVA: 0xE20540 Offset: 0xE1F940 VA: 0x180E20540
	internal void <.cctor>b__2_876(string str) { }

	// RVA: 0xE205F0 Offset: 0xE1F9F0 VA: 0x180E205F0
	internal string <.cctor>b__2_877() { }

	// RVA: 0xE20650 Offset: 0xE1FA50 VA: 0x180E20650
	internal void <.cctor>b__2_878(string str) { }

	// RVA: 0xE20700 Offset: 0xE1FB00 VA: 0x180E20700
	internal string <.cctor>b__2_879() { }

	// RVA: 0xE20810 Offset: 0xE1FC10 VA: 0x180E20810
	internal void <.cctor>b__2_880(string str) { }

	// RVA: 0xE208B0 Offset: 0xE1FCB0 VA: 0x180E208B0
	internal void <.cctor>b__2_881(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20910 Offset: 0xE1FD10 VA: 0x180E20910
	internal void <.cctor>b__2_882(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20970 Offset: 0xE1FD70 VA: 0x180E20970
	internal void <.cctor>b__2_883(ConsoleSystem.Arg arg) { }

	// RVA: 0xE209D0 Offset: 0xE1FDD0 VA: 0x180E209D0
	internal string <.cctor>b__2_884() { }

	// RVA: 0xE20A30 Offset: 0xE1FE30 VA: 0x180E20A30
	internal void <.cctor>b__2_885(string str) { }

	// RVA: 0xE20AD0 Offset: 0xE1FED0 VA: 0x180E20AD0
	internal string <.cctor>b__2_886() { }

	// RVA: 0xE20B30 Offset: 0xE1FF30 VA: 0x180E20B30
	internal void <.cctor>b__2_887(string str) { }

	// RVA: 0xE20BD0 Offset: 0xE1FFD0 VA: 0x180E20BD0
	internal void <.cctor>b__2_888(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20C30 Offset: 0xE20030 VA: 0x180E20C30
	internal string <.cctor>b__2_889() { }

	// RVA: 0xE20D10 Offset: 0xE20110 VA: 0x180E20D10
	internal void <.cctor>b__2_890(string str) { }

	// RVA: 0xE20DB0 Offset: 0xE201B0 VA: 0x180E20DB0
	internal string <.cctor>b__2_891() { }

	// RVA: 0xE20E10 Offset: 0xE20210 VA: 0x180E20E10
	internal void <.cctor>b__2_892(string str) { }

	// RVA: 0xE20EB0 Offset: 0xE202B0 VA: 0x180E20EB0
	internal void <.cctor>b__2_893(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20F10 Offset: 0xE20310 VA: 0x180E20F10
	internal void <.cctor>b__2_894(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20F70 Offset: 0xE20370 VA: 0x180E20F70
	internal void <.cctor>b__2_895(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20FD0 Offset: 0xE203D0 VA: 0x180E20FD0
	internal void <.cctor>b__2_896(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20FD0 Offset: 0xE203D0 VA: 0x180E20FD0
	internal void <.cctor>b__2_897(ConsoleSystem.Arg arg) { }

	// RVA: 0xE20FE0 Offset: 0xE203E0 VA: 0x180E20FE0
	internal string <.cctor>b__2_898() { }

	// RVA: 0xE21040 Offset: 0xE20440 VA: 0x180E21040
	internal void <.cctor>b__2_899(string str) { }

	// RVA: 0xE21210 Offset: 0xE20610 VA: 0x180E21210
	internal string <.cctor>b__2_900() { }

	// RVA: 0xE21270 Offset: 0xE20670 VA: 0x180E21270
	internal void <.cctor>b__2_901(string str) { }

	// RVA: 0xE21310 Offset: 0xE20710 VA: 0x180E21310
	internal string <.cctor>b__2_902() { }

	// RVA: 0xE213B0 Offset: 0xE207B0 VA: 0x180E213B0
	internal void <.cctor>b__2_903(string str) { }

	// RVA: 0xE21430 Offset: 0xE20830 VA: 0x180E21430
	internal string <.cctor>b__2_904() { }

	// RVA: 0xE21490 Offset: 0xE20890 VA: 0x180E21490
	internal void <.cctor>b__2_905(string str) { }

	// RVA: 0xE21510 Offset: 0xE20910 VA: 0x180E21510
	internal string <.cctor>b__2_906() { }

	// RVA: 0xE215C0 Offset: 0xE209C0 VA: 0x180E215C0
	internal void <.cctor>b__2_907(string str) { }

	// RVA: 0xE21650 Offset: 0xE20A50 VA: 0x180E21650
	internal string <.cctor>b__2_908() { }

	// RVA: 0xE216B0 Offset: 0xE20AB0 VA: 0x180E216B0
	internal void <.cctor>b__2_909(string str) { }

	// RVA: 0xE217F0 Offset: 0xE20BF0 VA: 0x180E217F0
	internal string <.cctor>b__2_910() { }

	// RVA: 0xE21850 Offset: 0xE20C50 VA: 0x180E21850
	internal void <.cctor>b__2_911(string str) { }

	// RVA: 0xE21910 Offset: 0xE20D10 VA: 0x180E21910
	internal string <.cctor>b__2_912() { }

	// RVA: 0xE21990 Offset: 0xE20D90 VA: 0x180E21990
	internal void <.cctor>b__2_913(string str) { }

	// RVA: 0xE21A00 Offset: 0xE20E00 VA: 0x180E21A00
	internal string <.cctor>b__2_914() { }

	// RVA: 0xE21A60 Offset: 0xE20E60 VA: 0x180E21A60
	internal void <.cctor>b__2_915(string str) { }

	// RVA: 0xE21B20 Offset: 0xE20F20 VA: 0x180E21B20
	internal string <.cctor>b__2_916() { }

	// RVA: 0xE21B80 Offset: 0xE20F80 VA: 0x180E21B80
	internal void <.cctor>b__2_917(string str) { }

	// RVA: 0xE21C20 Offset: 0xE21020 VA: 0x180E21C20
	internal string <.cctor>b__2_918() { }

	// RVA: 0xE21C80 Offset: 0xE21080 VA: 0x180E21C80
	internal void <.cctor>b__2_919(string str) { }

	// RVA: 0xE21DD0 Offset: 0xE211D0 VA: 0x180E21DD0
	internal string <.cctor>b__2_920() { }

	// RVA: 0xE21E30 Offset: 0xE21230 VA: 0x180E21E30
	internal void <.cctor>b__2_921(string str) { }

	// RVA: 0xE21ED0 Offset: 0xE212D0 VA: 0x180E21ED0
	internal string <.cctor>b__2_922() { }

	// RVA: 0xE21F30 Offset: 0xE21330 VA: 0x180E21F30
	internal void <.cctor>b__2_923(string str) { }

	// RVA: 0xE21FE0 Offset: 0xE213E0 VA: 0x180E21FE0
	internal void <.cctor>b__2_924(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22010 Offset: 0xE21410 VA: 0x180E22010
	internal void <.cctor>b__2_925(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22020 Offset: 0xE21420 VA: 0x180E22020
	internal string <.cctor>b__2_926() { }

	// RVA: 0xE22080 Offset: 0xE21480 VA: 0x180E22080
	internal void <.cctor>b__2_927(string str) { }

	// RVA: 0xE22130 Offset: 0xE21530 VA: 0x180E22130
	internal void <.cctor>b__2_928(ConsoleSystem.Arg arg) { }

	// RVA: 0xE22190 Offset: 0xE21590 VA: 0x180E22190
	internal string <.cctor>b__2_929() { }

	// RVA: 0xE22270 Offset: 0xE21670 VA: 0x180E22270
	internal void <.cctor>b__2_930(string str) { }

	// RVA: 0xE222F0 Offset: 0xE216F0 VA: 0x180E222F0
	internal string <.cctor>b__2_931() { }

	// RVA: 0xE22350 Offset: 0xE21750 VA: 0x180E22350
	internal void <.cctor>b__2_932(string str) { }

	// RVA: 0xE223F0 Offset: 0xE217F0 VA: 0x180E223F0
	internal string <.cctor>b__2_933() { }

	// RVA: 0xE224A0 Offset: 0xE218A0 VA: 0x180E224A0
	internal void <.cctor>b__2_934(string str) { }

	// RVA: 0xE22520 Offset: 0xE21920 VA: 0x180E22520
	internal string <.cctor>b__2_935() { }

	// RVA: 0xE225D0 Offset: 0xE219D0 VA: 0x180E225D0
	internal void <.cctor>b__2_936(string str) { }

	// RVA: 0xE22660 Offset: 0xE21A60 VA: 0x180E22660
	internal string <.cctor>b__2_937() { }

	// RVA: 0xE226C0 Offset: 0xE21AC0 VA: 0x180E226C0
	internal void <.cctor>b__2_938(string str) { }

	// RVA: 0xE22760 Offset: 0xE21B60 VA: 0x180E22760
	internal string <.cctor>b__2_939() { }

	// RVA: 0xE22870 Offset: 0xE21C70 VA: 0x180E22870
	internal void <.cctor>b__2_940(string str) { }

	// RVA: 0xE22910 Offset: 0xE21D10 VA: 0x180E22910
	internal string <.cctor>b__2_941() { }

	// RVA: 0xE22970 Offset: 0xE21D70 VA: 0x180E22970
	internal void <.cctor>b__2_942(string str) { }

	// RVA: 0xE22A10 Offset: 0xE21E10 VA: 0x180E22A10
	internal string <.cctor>b__2_943() { }

	// RVA: 0xE22A70 Offset: 0xE21E70 VA: 0x180E22A70
	internal void <.cctor>b__2_944(string str) { }

	// RVA: 0xE22B10 Offset: 0xE21F10 VA: 0x180E22B10
	internal string <.cctor>b__2_945() { }

	// RVA: 0xE22B70 Offset: 0xE21F70 VA: 0x180E22B70
	internal void <.cctor>b__2_946(string str) { }

	// RVA: 0xE22C10 Offset: 0xE22010 VA: 0x180E22C10
	internal string <.cctor>b__2_947() { }

	// RVA: 0xE22C70 Offset: 0xE22070 VA: 0x180E22C70
	internal void <.cctor>b__2_948(string str) { }

	// RVA: 0xE22D10 Offset: 0xE22110 VA: 0x180E22D10
	internal string <.cctor>b__2_949() { }

	// RVA: 0xE22DF0 Offset: 0xE221F0 VA: 0x180E22DF0
	internal void <.cctor>b__2_950(string str) { }

	// RVA: 0xE22E90 Offset: 0xE22290 VA: 0x180E22E90
	internal string <.cctor>b__2_951() { }

	// RVA: 0xE22EF0 Offset: 0xE222F0 VA: 0x180E22EF0
	internal void <.cctor>b__2_952(string str) { }

	// RVA: 0xE22F90 Offset: 0xE22390 VA: 0x180E22F90
	internal string <.cctor>b__2_953() { }

	// RVA: 0xE22FF0 Offset: 0xE223F0 VA: 0x180E22FF0
	internal void <.cctor>b__2_954(string str) { }

	// RVA: 0xE23080 Offset: 0xE22480 VA: 0x180E23080
	internal string <.cctor>b__2_955() { }

	// RVA: 0xE230E0 Offset: 0xE224E0 VA: 0x180E230E0
	internal void <.cctor>b__2_956(string str) { }

	// RVA: 0xE23170 Offset: 0xE22570 VA: 0x180E23170
	internal string <.cctor>b__2_957() { }

	// RVA: 0xE231D0 Offset: 0xE225D0 VA: 0x180E231D0
	internal void <.cctor>b__2_958(string str) { }

	// RVA: 0xE23260 Offset: 0xE22660 VA: 0x180E23260
	internal string <.cctor>b__2_959() { }

	// RVA: 0xE23370 Offset: 0xE22770 VA: 0x180E23370
	internal void <.cctor>b__2_960(string str) { }

	// RVA: 0xE23400 Offset: 0xE22800 VA: 0x180E23400
	internal string <.cctor>b__2_961() { }

	// RVA: 0xE23460 Offset: 0xE22860 VA: 0x180E23460
	internal void <.cctor>b__2_962(string str) { }

	// RVA: 0xE234F0 Offset: 0xE228F0 VA: 0x180E234F0
	internal string <.cctor>b__2_963() { }

	// RVA: 0xE23550 Offset: 0xE22950 VA: 0x180E23550
	internal void <.cctor>b__2_964(string str) { }

	// RVA: 0xE235E0 Offset: 0xE229E0 VA: 0x180E235E0
	internal string <.cctor>b__2_965() { }

	// RVA: 0xE23640 Offset: 0xE22A40 VA: 0x180E23640
	internal void <.cctor>b__2_966(string str) { }

	// RVA: 0xE236D0 Offset: 0xE22AD0 VA: 0x180E236D0
	internal string <.cctor>b__2_967() { }

	// RVA: 0xE23730 Offset: 0xE22B30 VA: 0x180E23730
	internal void <.cctor>b__2_968(string str) { }

	// RVA: 0xE237C0 Offset: 0xE22BC0 VA: 0x180E237C0
	internal string <.cctor>b__2_969() { }

	// RVA: 0xE238A0 Offset: 0xE22CA0 VA: 0x180E238A0
	internal void <.cctor>b__2_970(string str) { }

	// RVA: 0xE23930 Offset: 0xE22D30 VA: 0x180E23930
	internal string <.cctor>b__2_971() { }

	// RVA: 0xE23990 Offset: 0xE22D90 VA: 0x180E23990
	internal void <.cctor>b__2_972(string str) { }

	// RVA: 0xE23A20 Offset: 0xE22E20 VA: 0x180E23A20
	internal string <.cctor>b__2_973() { }

	// RVA: 0xE23A80 Offset: 0xE22E80 VA: 0x180E23A80
	internal void <.cctor>b__2_974(string str) { }

	// RVA: 0xE23B10 Offset: 0xE22F10 VA: 0x180E23B10
	internal string <.cctor>b__2_975() { }

	// RVA: 0xE23B70 Offset: 0xE22F70 VA: 0x180E23B70
	internal void <.cctor>b__2_976(string str) { }

	// RVA: 0xE23C00 Offset: 0xE23000 VA: 0x180E23C00
	internal string <.cctor>b__2_977() { }

	// RVA: 0xE23C60 Offset: 0xE23060 VA: 0x180E23C60
	internal void <.cctor>b__2_978(string str) { }

	// RVA: 0xE23CF0 Offset: 0xE230F0 VA: 0x180E23CF0
	internal string <.cctor>b__2_979() { }

	// RVA: 0xE23E00 Offset: 0xE23200 VA: 0x180E23E00
	internal void <.cctor>b__2_980(string str) { }

	// RVA: 0xE23E90 Offset: 0xE23290 VA: 0x180E23E90
	internal string <.cctor>b__2_981() { }

	// RVA: 0xE23EF0 Offset: 0xE232F0 VA: 0x180E23EF0
	internal void <.cctor>b__2_982(string str) { }

	// RVA: 0xE23F80 Offset: 0xE23380 VA: 0x180E23F80
	internal string <.cctor>b__2_983() { }

	// RVA: 0xE23FE0 Offset: 0xE233E0 VA: 0x180E23FE0
	internal void <.cctor>b__2_984(string str) { }

	// RVA: 0xE24070 Offset: 0xE23470 VA: 0x180E24070
	internal string <.cctor>b__2_985() { }

	// RVA: 0xE240D0 Offset: 0xE234D0 VA: 0x180E240D0
	internal void <.cctor>b__2_986(string str) { }

	// RVA: 0xE24160 Offset: 0xE23560 VA: 0x180E24160
	internal string <.cctor>b__2_987() { }

	// RVA: 0xE241C0 Offset: 0xE235C0 VA: 0x180E241C0
	internal void <.cctor>b__2_988(string str) { }

	// RVA: 0xE24250 Offset: 0xE23650 VA: 0x180E24250
	internal void <.cctor>b__2_989(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24330 Offset: 0xE23730 VA: 0x180E24330
	internal string <.cctor>b__2_990() { }

	// RVA: 0xE24390 Offset: 0xE23790 VA: 0x180E24390
	internal void <.cctor>b__2_991(string str) { }

	// RVA: 0xE24420 Offset: 0xE23820 VA: 0x180E24420
	internal string <.cctor>b__2_992() { }

	// RVA: 0xE24480 Offset: 0xE23880 VA: 0x180E24480
	internal void <.cctor>b__2_993(string str) { }

	// RVA: 0xE24510 Offset: 0xE23910 VA: 0x180E24510
	internal string <.cctor>b__2_994() { }

	// RVA: 0xE24570 Offset: 0xE23970 VA: 0x180E24570
	internal void <.cctor>b__2_995(string str) { }

	// RVA: 0xE24600 Offset: 0xE23A00 VA: 0x180E24600
	internal string <.cctor>b__2_996() { }

	// RVA: 0xE24660 Offset: 0xE23A60 VA: 0x180E24660
	internal void <.cctor>b__2_997(string str) { }

	// RVA: 0xE246F0 Offset: 0xE23AF0 VA: 0x180E246F0
	internal void <.cctor>b__2_998(ConsoleSystem.Arg arg) { }

	// RVA: 0xE24750 Offset: 0xE23B50 VA: 0x180E24750
	internal void <.cctor>b__2_999(ConsoleSystem.Arg arg) { }

	// RVA: 0xE02BC0 Offset: 0xE01FC0 VA: 0x180E02BC0
	internal string <.cctor>b__2_1000() { }

	// RVA: 0xE02C20 Offset: 0xE02020 VA: 0x180E02C20
	internal void <.cctor>b__2_1001(string str) { }

	// RVA: 0xE02CB0 Offset: 0xE020B0 VA: 0x180E02CB0
	internal string <.cctor>b__2_1002() { }

	// RVA: 0xE02D10 Offset: 0xE02110 VA: 0x180E02D10
	internal void <.cctor>b__2_1003(string str) { }

	// RVA: 0xE02DA0 Offset: 0xE021A0 VA: 0x180E02DA0
	internal string <.cctor>b__2_1004() { }

	// RVA: 0xE02E00 Offset: 0xE02200 VA: 0x180E02E00
	internal void <.cctor>b__2_1005(string str) { }

	// RVA: 0xE02E90 Offset: 0xE02290 VA: 0x180E02E90
	internal void <.cctor>b__2_1006(ConsoleSystem.Arg arg) { }

	// RVA: 0xE02EA0 Offset: 0xE022A0 VA: 0x180E02EA0
	internal string <.cctor>b__2_1007() { }

	// RVA: 0xE02F00 Offset: 0xE02300 VA: 0x180E02F00
	internal void <.cctor>b__2_1008(string str) { }

	// RVA: 0xE02FA0 Offset: 0xE023A0 VA: 0x180E02FA0
	internal void <.cctor>b__2_1009(ConsoleSystem.Arg arg) { }

	// RVA: 0xE03080 Offset: 0xE02480 VA: 0x180E03080
	internal void <.cctor>b__2_1010(ConsoleSystem.Arg arg) { }

	// RVA: 0xE030E0 Offset: 0xE024E0 VA: 0x180E030E0
	internal void <.cctor>b__2_1011(ConsoleSystem.Arg arg) { }

	// RVA: 0xE03140 Offset: 0xE02540 VA: 0x180E03140
	internal void <.cctor>b__2_1012(ConsoleSystem.Arg arg) { }

	// RVA: 0xE031A0 Offset: 0xE025A0 VA: 0x180E031A0
	internal string <.cctor>b__2_1013() { }

	// RVA: 0xE03200 Offset: 0xE02600 VA: 0x180E03200
	internal void <.cctor>b__2_1014(string str) { }

	// RVA: 0xE032A0 Offset: 0xE026A0 VA: 0x180E032A0
	internal void <.cctor>b__2_1015(ConsoleSystem.Arg arg) { }

	// RVA: 0xE032B0 Offset: 0xE026B0 VA: 0x180E032B0
	internal string <.cctor>b__2_1016() { }

	// RVA: 0xE03310 Offset: 0xE02710 VA: 0x180E03310
	internal void <.cctor>b__2_1017(string str) { }

	// RVA: 0xE033B0 Offset: 0xE027B0 VA: 0x180E033B0
	internal string <.cctor>b__2_1018() { }

	// RVA: 0xE03410 Offset: 0xE02810 VA: 0x180E03410
	internal void <.cctor>b__2_1019(string str) { }

	// RVA: 0xE03570 Offset: 0xE02970 VA: 0x180E03570
	internal string <.cctor>b__2_1020() { }

	// RVA: 0xE035D0 Offset: 0xE029D0 VA: 0x180E035D0
	internal void <.cctor>b__2_1021(string str) { }

	// RVA: 0xE03680 Offset: 0xE02A80 VA: 0x180E03680
	internal string <.cctor>b__2_1022() { }

	// RVA: 0xE036E0 Offset: 0xE02AE0 VA: 0x180E036E0
	internal void <.cctor>b__2_1023(string str) { }

	// RVA: 0xE03780 Offset: 0xE02B80 VA: 0x180E03780
	internal string <.cctor>b__2_1024() { }

	// RVA: 0xE037A0 Offset: 0xE02BA0 VA: 0x180E037A0
	internal void <.cctor>b__2_1025(string str) { }

	// RVA: 0xE03800 Offset: 0xE02C00 VA: 0x180E03800
	internal string <.cctor>b__2_1026() { }

	// RVA: 0xE03820 Offset: 0xE02C20 VA: 0x180E03820
	internal void <.cctor>b__2_1027(string str) { }

	// RVA: 0xE03880 Offset: 0xE02C80 VA: 0x180E03880
	internal string <.cctor>b__2_1028() { }

	// RVA: 0xE038A0 Offset: 0xE02CA0 VA: 0x180E038A0
	internal void <.cctor>b__2_1029(string str) { }

	// RVA: 0xE03980 Offset: 0xE02D80 VA: 0x180E03980
	internal string <.cctor>b__2_1030() { }

	// RVA: 0xE039A0 Offset: 0xE02DA0 VA: 0x180E039A0
	internal void <.cctor>b__2_1031(string str) { }

	// RVA: 0xE03A00 Offset: 0xE02E00 VA: 0x180E03A00
	internal string <.cctor>b__2_1032() { }

	// RVA: 0xE03A20 Offset: 0xE02E20 VA: 0x180E03A20
	internal void <.cctor>b__2_1033(string str) { }

	// RVA: 0xE03A80 Offset: 0xE02E80 VA: 0x180E03A80
	internal string <.cctor>b__2_1034() { }

	// RVA: 0xE03AA0 Offset: 0xE02EA0 VA: 0x180E03AA0
	internal void <.cctor>b__2_1035(string str) { }

	// RVA: 0xE03B00 Offset: 0xE02F00 VA: 0x180E03B00
	internal string <.cctor>b__2_1036() { }

	// RVA: 0xE03B20 Offset: 0xE02F20 VA: 0x180E03B20
	internal void <.cctor>b__2_1037(string str) { }

	// RVA: 0xE03B80 Offset: 0xE02F80 VA: 0x180E03B80
	internal string <.cctor>b__2_1038() { }

	// RVA: 0xE03BA0 Offset: 0xE02FA0 VA: 0x180E03BA0
	internal void <.cctor>b__2_1039(string str) { }

	// RVA: 0xE03CB0 Offset: 0xE030B0 VA: 0x180E03CB0
	internal void <.cctor>b__2_1040(ConsoleSystem.Arg arg) { }

	// RVA: 0xE03CC0 Offset: 0xE030C0 VA: 0x180E03CC0
	internal void <.cctor>b__2_1041(ConsoleSystem.Arg arg) { }

	// RVA: 0xE03CF0 Offset: 0xE030F0 VA: 0x180E03CF0
	internal string <.cctor>b__2_1042() { }

	// RVA: 0xE03D50 Offset: 0xE03150 VA: 0x180E03D50
	internal void <.cctor>b__2_1043(string str) { }

	// RVA: 0xE03DF0 Offset: 0xE031F0 VA: 0x180E03DF0
	internal string <.cctor>b__2_1044() { }

	// RVA: 0xE03E50 Offset: 0xE03250 VA: 0x180E03E50
	internal void <.cctor>b__2_1045(string str) { }

	// RVA: 0xE03EF0 Offset: 0xE032F0 VA: 0x180E03EF0
	internal string <.cctor>b__2_1046() { }

	// RVA: 0xE03F50 Offset: 0xE03350 VA: 0x180E03F50
	internal void <.cctor>b__2_1047(string str) { }

	// RVA: 0xE04000 Offset: 0xE03400 VA: 0x180E04000
	internal string <.cctor>b__2_1048() { }

	// RVA: 0xE04060 Offset: 0xE03460 VA: 0x180E04060
	internal void <.cctor>b__2_1049(string str) { }

	// RVA: 0xE04180 Offset: 0xE03580 VA: 0x180E04180
	internal string <.cctor>b__2_1050() { }

	// RVA: 0xE041E0 Offset: 0xE035E0 VA: 0x180E041E0
	internal void <.cctor>b__2_1051(string str) { }

	// RVA: 0xE04290 Offset: 0xE03690 VA: 0x180E04290
	internal void <.cctor>b__2_1052(ConsoleSystem.Arg arg) { }

	// RVA: 0xE042E0 Offset: 0xE036E0 VA: 0x180E042E0
	internal void <.cctor>b__2_1053(ConsoleSystem.Arg arg) { }

	// RVA: 0xE043A0 Offset: 0xE037A0 VA: 0x180E043A0
	internal void <.cctor>b__2_1054(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04420 Offset: 0xE03820 VA: 0x180E04420
	internal string <.cctor>b__2_1055() { }

	// RVA: 0xE04480 Offset: 0xE03880 VA: 0x180E04480
	internal void <.cctor>b__2_1056(string str) { }

	// RVA: 0xE04520 Offset: 0xE03920 VA: 0x180E04520
	internal void <.cctor>b__2_1057(ConsoleSystem.Arg arg) { }

	// RVA: 0xE045C0 Offset: 0xE039C0 VA: 0x180E045C0
	internal void <.cctor>b__2_1058(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04680 Offset: 0xE03A80 VA: 0x180E04680
	internal string <.cctor>b__2_1059() { }

	// RVA: 0xE04790 Offset: 0xE03B90 VA: 0x180E04790
	internal void <.cctor>b__2_1060(string str) { }

	// RVA: 0xE04830 Offset: 0xE03C30 VA: 0x180E04830
	internal string <.cctor>b__2_1061() { }

	// RVA: 0xE04890 Offset: 0xE03C90 VA: 0x180E04890
	internal void <.cctor>b__2_1062(string str) { }

	// RVA: 0xE04940 Offset: 0xE03D40 VA: 0x180E04940
	internal void <.cctor>b__2_1063(ConsoleSystem.Arg arg) { }

	// RVA: 0xE049A0 Offset: 0xE03DA0 VA: 0x180E049A0
	internal string <.cctor>b__2_1064() { }

	// RVA: 0xE04A00 Offset: 0xE03E00 VA: 0x180E04A00
	internal void <.cctor>b__2_1065(string str) { }

	// RVA: 0xE04AA0 Offset: 0xE03EA0 VA: 0x180E04AA0
	internal string <.cctor>b__2_1066() { }

	// RVA: 0xE04B50 Offset: 0xE03F50 VA: 0x180E04B50
	internal void <.cctor>b__2_1067(string str) { }

	// RVA: 0xE04C30 Offset: 0xE04030 VA: 0x180E04C30
	internal string <.cctor>b__2_1068() { }

	// RVA: 0xE04C90 Offset: 0xE04090 VA: 0x180E04C90
	internal void <.cctor>b__2_1069(string str) { }

	// RVA: 0xE04DC0 Offset: 0xE041C0 VA: 0x180E04DC0
	internal string <.cctor>b__2_1070() { }

	// RVA: 0xE04E20 Offset: 0xE04220 VA: 0x180E04E20
	internal void <.cctor>b__2_1071(string str) { }

	// RVA: 0xE04ED0 Offset: 0xE042D0 VA: 0x180E04ED0
	internal void <.cctor>b__2_1072(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04EE0 Offset: 0xE042E0 VA: 0x180E04EE0
	internal void <.cctor>b__2_1073(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04EF0 Offset: 0xE042F0 VA: 0x180E04EF0
	internal void <.cctor>b__2_1074(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04F00 Offset: 0xE04300 VA: 0x180E04F00
	internal void <.cctor>b__2_1075(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04F10 Offset: 0xE04310 VA: 0x180E04F10
	internal void <.cctor>b__2_1076(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04F70 Offset: 0xE04370 VA: 0x180E04F70
	internal void <.cctor>b__2_1077(ConsoleSystem.Arg arg) { }

	// RVA: 0xE04FD0 Offset: 0xE043D0 VA: 0x180E04FD0
	internal void <.cctor>b__2_1078(ConsoleSystem.Arg arg) { }

	// RVA: 0xE05030 Offset: 0xE04430 VA: 0x180E05030
	internal void <.cctor>b__2_1079(ConsoleSystem.Arg arg) { }

	// RVA: 0xE05140 Offset: 0xE04540 VA: 0x180E05140
	internal void <.cctor>b__2_1080(ConsoleSystem.Arg arg) { }

	// RVA: 0xE051A0 Offset: 0xE045A0 VA: 0x180E051A0
	internal string <.cctor>b__2_1081() { }

	// RVA: 0xE05200 Offset: 0xE04600 VA: 0x180E05200
	internal void <.cctor>b__2_1082(string str) { }

	// RVA: 0xE052A0 Offset: 0xE046A0 VA: 0x180E052A0
	internal string <.cctor>b__2_1083() { }

	// RVA: 0xE05350 Offset: 0xE04750 VA: 0x180E05350
	internal void <.cctor>b__2_1084(string str) { }

	// RVA: 0xE053D0 Offset: 0xE047D0 VA: 0x180E053D0
	internal void <.cctor>b__2_1085(ConsoleSystem.Arg arg) { }

	// RVA: 0xE05430 Offset: 0xE04830 VA: 0x180E05430
	internal void <.cctor>b__2_1086(ConsoleSystem.Arg arg) { }

	// RVA: 0xE05490 Offset: 0xE04890 VA: 0x180E05490
	internal string <.cctor>b__2_1087() { }

	// RVA: 0xE054F0 Offset: 0xE048F0 VA: 0x180E054F0
	internal void <.cctor>b__2_1088(string str) { }

	// RVA: 0xE05590 Offset: 0xE04990 VA: 0x180E05590
	internal string <.cctor>b__2_1089() { }

	// RVA: 0xE05670 Offset: 0xE04A70 VA: 0x180E05670
	internal void <.cctor>b__2_1090(string str) { }

	// RVA: 0xE05720 Offset: 0xE04B20 VA: 0x180E05720
	internal string <.cctor>b__2_1091() { }

	// RVA: 0xE05780 Offset: 0xE04B80 VA: 0x180E05780
	internal void <.cctor>b__2_1092(string str) { }

	// RVA: 0xE05830 Offset: 0xE04C30 VA: 0x180E05830
	internal string <.cctor>b__2_1093() { }

	// RVA: 0xE05890 Offset: 0xE04C90 VA: 0x180E05890
	internal void <.cctor>b__2_1094(string str) { }

	// RVA: 0xE05930 Offset: 0xE04D30 VA: 0x180E05930
	internal string <.cctor>b__2_1095() { }

	// RVA: 0xE05990 Offset: 0xE04D90 VA: 0x180E05990
	internal void <.cctor>b__2_1096(string str) { }

	// RVA: 0xE05A40 Offset: 0xE04E40 VA: 0x180E05A40
	internal string <.cctor>b__2_1097() { }

	// RVA: 0xE05AA0 Offset: 0xE04EA0 VA: 0x180E05AA0
	internal void <.cctor>b__2_1098(string str) { }

	// RVA: 0xE05B30 Offset: 0xE04F30 VA: 0x180E05B30
	internal string <.cctor>b__2_1099() { }

	// RVA: 0xE05CC0 Offset: 0xE050C0 VA: 0x180E05CC0
	internal void <.cctor>b__2_1100(string str) { }

	// RVA: 0xE05D50 Offset: 0xE05150 VA: 0x180E05D50
	internal void <.cctor>b__2_1101(ConsoleSystem.Arg arg) { }

	// RVA: 0xE05DB0 Offset: 0xE051B0 VA: 0x180E05DB0
	internal void <.cctor>b__2_1102(ConsoleSystem.Arg arg) { }

	// RVA: 0xE05E10 Offset: 0xE05210 VA: 0x180E05E10
	internal string <.cctor>b__2_1103() { }

	// RVA: 0xE05E70 Offset: 0xE05270 VA: 0x180E05E70
	internal void <.cctor>b__2_1104(string str) { }

	// RVA: 0xE05F10 Offset: 0xE05310 VA: 0x180E05F10
	internal string <.cctor>b__2_1105() { }

	// RVA: 0xE05F70 Offset: 0xE05370 VA: 0x180E05F70
	internal void <.cctor>b__2_1106(string str) { }

	// RVA: 0xE06010 Offset: 0xE05410 VA: 0x180E06010
	internal string <.cctor>b__2_1107() { }

	// RVA: 0xE06090 Offset: 0xE05490 VA: 0x180E06090
	internal void <.cctor>b__2_1108(string str) { }

	// RVA: 0xE060F0 Offset: 0xE054F0 VA: 0x180E060F0
	internal void <.cctor>b__2_1109(ConsoleSystem.Arg arg) { }

	// RVA: 0xE061A0 Offset: 0xE055A0 VA: 0x180E061A0
	internal void <.cctor>b__2_1110(ConsoleSystem.Arg arg) { }

	// RVA: 0xE06200 Offset: 0xE05600 VA: 0x180E06200
	internal void <.cctor>b__2_1111(ConsoleSystem.Arg arg) { }

	// RVA: 0xE06260 Offset: 0xE05660 VA: 0x180E06260
	internal string <.cctor>b__2_1112() { }

	// RVA: 0xE06310 Offset: 0xE05710 VA: 0x180E06310
	internal void <.cctor>b__2_1113(string str) { }

	// RVA: 0xE06390 Offset: 0xE05790 VA: 0x180E06390
	internal string <.cctor>b__2_1114() { }

	// RVA: 0xE063F0 Offset: 0xE057F0 VA: 0x180E063F0
	internal void <.cctor>b__2_1115(string str) { }

	// RVA: 0xE06490 Offset: 0xE05890 VA: 0x180E06490
	internal string <.cctor>b__2_1116() { }

	// RVA: 0xE064F0 Offset: 0xE058F0 VA: 0x180E064F0
	internal void <.cctor>b__2_1117(string str) { }

	// RVA: 0xE06590 Offset: 0xE05990 VA: 0x180E06590
	internal string <.cctor>b__2_1118() { }

	// RVA: 0xE065F0 Offset: 0xE059F0 VA: 0x180E065F0
	internal void <.cctor>b__2_1119(string str) { }

	// RVA: 0xE06740 Offset: 0xE05B40 VA: 0x180E06740
	internal string <.cctor>b__2_1120() { }

	// RVA: 0xE067A0 Offset: 0xE05BA0 VA: 0x180E067A0
	internal void <.cctor>b__2_1121(string str) { }

	// RVA: 0xE06850 Offset: 0xE05C50 VA: 0x180E06850
	internal string <.cctor>b__2_1122() { }

	// RVA: 0xE068B0 Offset: 0xE05CB0 VA: 0x180E068B0
	internal void <.cctor>b__2_1123(string str) { }

	// RVA: 0xE06950 Offset: 0xE05D50 VA: 0x180E06950
	internal string <.cctor>b__2_1124() { }

	// RVA: 0xE069B0 Offset: 0xE05DB0 VA: 0x180E069B0
	internal void <.cctor>b__2_1125(string str) { }

	// RVA: 0xE06A50 Offset: 0xE05E50 VA: 0x180E06A50
	internal string <.cctor>b__2_1126() { }

	// RVA: 0xE06AB0 Offset: 0xE05EB0 VA: 0x180E06AB0
	internal void <.cctor>b__2_1127(string str) { }

	// RVA: 0xE06B50 Offset: 0xE05F50 VA: 0x180E06B50
	internal string <.cctor>b__2_1128() { }

	// RVA: 0xE06BB0 Offset: 0xE05FB0 VA: 0x180E06BB0
	internal void <.cctor>b__2_1129(string str) { }

	// RVA: 0xE06CB0 Offset: 0xE060B0 VA: 0x180E06CB0
	internal void <.cctor>b__2_1130(ConsoleSystem.Arg arg) { }

}

public static class ConsoleNetwork // TypeDefIndex: 9369
{	// Methods

	// RVA: 0x509490 Offset: 0x508890 VA: 0x180509490
	internal static void Init() { }

	// RVA: 0x509250 Offset: 0x508650 VA: 0x180509250
	public static bool ClientRunOnServer(string strCommand) { }

	// RVA: 0x509620 Offset: 0x508A20 VA: 0x180509620
	internal static void OnConsoleMessageFromServer(Message packet) { }

	// RVA: 0x509520 Offset: 0x508920 VA: 0x180509520
	internal static void OnConsoleCommandfromServer(Message packet) { }

}

public class ConsoleUI : SingletonComponent<ConsoleUI> // TypeDefIndex: 10835
{	// Fields
	public RustText text; // 0x18
	public InputField outputField; // 0x20
	public InputField inputField; // 0x28
	public GameObject AutocompleteDropDown; // 0x30
	public GameObject ItemTemplate; // 0x38
	public Color errorColor; // 0x40
	public Color warningColor; // 0x50
	public Color inputColor; // 0x60
	private TextBuffer buffer; // 0x70
	private TextBuffer history; // 0x78
	private string historyTemp; // 0x80
	private string historyText; // 0x88
	private int historyIndex; // 0x90
	private Button[] autocompleteButtons; // 0x98
	private int autocompleteIndex; // 0xA0
	private bool dirty; // 0xA4

	// Methods

	// RVA: 0x509700 Offset: 0x508B00 VA: 0x180509700 Slot: 6
	protected override void Awake() { }

	// RVA: 0x509F50 Offset: 0x509350 VA: 0x180509F50
	protected void OnEnable() { }

	// RVA: 0x509E50 Offset: 0x509250 VA: 0x180509E50
	protected void OnDisable() { }

	// RVA: 0x50B1E0 Offset: 0x50A5E0 VA: 0x18050B1E0
	protected void Update() { }

	// RVA: 0x5099E0 Offset: 0x508DE0 VA: 0x1805099E0
	public void CloseAutocomplete() { }

	// RVA: 0x50A0D0 Offset: 0x5094D0 VA: 0x18050A0D0
	public void OnTextTypes(string str) { }

	// RVA: 0x5096A0 Offset: 0x508AA0 VA: 0x1805096A0
	private void AutocompleteButtonClicked(Button button) { }

	// RVA: 0x509FF0 Offset: 0x5093F0 VA: 0x180509FF0
	private void OnOpenDevTools() { }

	// RVA: 0x50A7C0 Offset: 0x509BC0 VA: 0x18050A7C0
	private void OutputHandler_OnMessage(string message, string stack, LogType type = 0) { }

	// RVA: 0x509DC0 Offset: 0x5091C0 VA: 0x180509DC0
	private void Log(string message) { }

	// RVA: 0x50AC90 Offset: 0x50A090 VA: 0x18050AC90
	private void Refresh() { }

	// RVA: 0x509C80 Offset: 0x509080 VA: 0x180509C80
	private void LoadHistory(int delta) { }

	// RVA: 0x50ADE0 Offset: 0x50A1E0 VA: 0x18050ADE0
	public void SubmitCommand(string command) { }

	// RVA: 0x50ACE0 Offset: 0x50A0E0 VA: 0x18050ACE0
	private void SelectInputField(bool updateAutoComplete = False) { }

	[IteratorStateMachineAttribute] // RVA: 0x7F3B0 Offset: 0x7E7B0 VA: 0x18007F3B0
	// RVA: 0x50AD60 Offset: 0x50A160 VA: 0x18050AD60
	private IEnumerator SetSelected(bool updateAutoComplete = False) { }

	// RVA: 0x509980 Offset: 0x508D80 VA: 0x180509980
	public void ClearContents() { }

	// RVA: 0x509AF0 Offset: 0x508EF0 VA: 0x180509AF0
	public void Copy() { }

	// RVA: 0x50A700 Offset: 0x509B00 VA: 0x18050A700
	public void OpenLogFolder() { }

	// RVA: 0x50A640 Offset: 0x509A40 VA: 0x18050A640
	public void OpenLogFile() { }

	// RVA: 0x50B670 Offset: 0x50AA70 VA: 0x18050B670
	public void .ctor() { }

}

private sealed class ConsoleUI.<>c__DisplayClass16_0 // TypeDefIndex: 10836
{	// Fields
	public Button btn; // 0x10
	public ConsoleUI <>4__this; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5257A0 Offset: 0x524BA0 VA: 0x1805257A0
	internal void <Awake>b__0() { }

}

private sealed class ConsoleUI.<>c__DisplayClass21_0 // TypeDefIndex: 10837
{	// Fields
	public string str; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x525800 Offset: 0x524C00 VA: 0x180525800
	internal bool <OnTextTypes>b__0(ConsoleSystem.Command x) { }

}

private sealed class ConsoleUI.<SetSelected>d__30 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10838
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ConsoleUI <>4__this; // 0x20
	public bool updateAutoComplete; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x5254C0 Offset: 0x5248C0 VA: 0x1805254C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5256A0 Offset: 0x524AA0 VA: 0x1805256A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class ConsoleInput // TypeDefIndex: 11677
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action<string> OnInputText; // 0x10
	public string inputString; // 0x18
	public string[] statusText; // 0x20
	internal float nextUpdate; // 0x28

	// Properties
	public bool valid { get; }
	public int lineWidth { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x892400 Offset: 0x891800 VA: 0x180892400
	public void add_OnInputText(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x892540 Offset: 0x891940 VA: 0x180892540
	public void remove_OnInputText(Action<string> value) { }

	// RVA: 0x8924F0 Offset: 0x8918F0 VA: 0x1808924F0
	public bool get_valid() { }

	// RVA: 0x8924A0 Offset: 0x8918A0 VA: 0x1808924A0
	public int get_lineWidth() { }

	// RVA: 0x8919B0 Offset: 0x890DB0 VA: 0x1808919B0
	public void ClearLine(int numLines) { }

	// RVA: 0x891C10 Offset: 0x891010 VA: 0x180891C10
	public void RedrawInputLine() { }

	// RVA: 0x891A80 Offset: 0x890E80 VA: 0x180891A80
	internal void OnBackspace() { }

	// RVA: 0x891BC0 Offset: 0x890FC0 VA: 0x180891BC0
	internal void OnEscape() { }

	// RVA: 0x891AE0 Offset: 0x890EE0 VA: 0x180891AE0
	internal void OnEnter() { }

	// RVA: 0x891F90 Offset: 0x891390 VA: 0x180891F90
	public void Update() { }

	// RVA: 0x892250 Offset: 0x891650 VA: 0x180892250
	public void .ctor() { }

}

public class ConsoleWindow // TypeDefIndex: 11678
{	// Fields
	private TextWriter oldOutput; // 0x10
	private const int STD_INPUT_HANDLE = -10;
	private const int STD_OUTPUT_HANDLE = -11;

	// Methods

	// RVA: 0x892800 Offset: 0x891C00 VA: 0x180892800
	public void Initialize() { }

	// RVA: 0x892C70 Offset: 0x892070 VA: 0x180892C70
	public void Shutdown() { }

	// RVA: 0x892BE0 Offset: 0x891FE0 VA: 0x180892BE0
	public void SetTitle(string strName) { }

	// RVA: 0x892660 Offset: 0x891A60 VA: 0x180892660
	private static extern bool AttachConsole(uint dwProcessId) { }

	// RVA: 0x8925E0 Offset: 0x8919E0 VA: 0x1808925E0
	private static extern bool AllocConsole() { }

	// RVA: 0x8926F0 Offset: 0x891AF0 VA: 0x1808926F0
	private static extern bool FreeConsole() { }

	// RVA: 0x892770 Offset: 0x891B70 VA: 0x180892770
	private static extern IntPtr GetStdHandle(int nStdHandle) { }

	// RVA: 0x892B40 Offset: 0x891F40 VA: 0x180892B40
	private static extern bool SetConsoleTitleA(string lpConsoleTitle) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class Console : ConsoleSystem // TypeDefIndex: 11890
{	// Fields
	[ClientVar] // RVA: 0x907A0 Offset: 0x8FBA0 VA: 0x1800907A0
	[HelpAttribute] // RVA: 0x907A0 Offset: 0x8FBA0 VA: 0x1800907A0
	public static bool erroroverlay; // 0x1F760

	// Methods

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D22A0 Offset: 0x6D16A0 VA: 0x1806D22A0
	public static void clear(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D2310 Offset: 0x6D1710 VA: 0x1806D2310
	public static void copy(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D2240 Offset: 0x6D1640 VA: 0x1806D2240
	public void .ctor() { }

	// RVA: 0x6D2200 Offset: 0x6D1600 VA: 0x1806D2200
	private static void .cctor() { }

}

