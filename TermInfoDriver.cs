internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 393
{	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private ConsoleColor bgcolor; // 0xD4
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public ConsoleColor BackgroundColor { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { get; set; }
	public int CursorTop { get; set; }
	public bool KeyAvailable { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x18BBC20 Offset: 0x18BB020 VA: 0x1818BBC20
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x18BB870 Offset: 0x18BAC70 VA: 0x1818BB870
	private static string SearchTerminfo(string term) { }

	// RVA: 0x18BBF30 Offset: 0x18BB330 VA: 0x1818BBF30
	private void WriteConsole(string str) { }

	// RVA: 0x18BC3D0 Offset: 0x18BB7D0 VA: 0x1818BC3D0
	public void .ctor(string term) { }

	// RVA: 0xC26F70 Offset: 0xC26370 VA: 0x180C26F70 Slot: 14
	public bool get_Initialized() { }

	// RVA: 0x18BA4B0 Offset: 0x18B98B0 VA: 0x1818BA4B0 Slot: 15
	public void Init() { }

	// RVA: 0x18BA250 Offset: 0x18B9650 VA: 0x1818BA250
	private void IncrementX() { }

	// RVA: 0x18BBF60 Offset: 0x18BB360 VA: 0x1818BBF60
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18BC140 Offset: 0x18BB540 VA: 0x1818BC140
	public void WriteSpecialKey(char c) { }

	// RVA: 0x18BAE10 Offset: 0x18BA210 VA: 0x1818BAE10
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x18BADC0 Offset: 0x18BA1C0 VA: 0x1818BADC0
	public bool IsSpecialKey(char c) { }

	// RVA: 0x18B6FC0 Offset: 0x18B63C0 VA: 0x1818B6FC0
	private void ChangeColor(string format, ConsoleColor color) { }

	// RVA: 0x18BC960 Offset: 0x18BBD60 VA: 0x1818BC960 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x18BCB50 Offset: 0x18BBF50 VA: 0x1818BCB50 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x18BCA30 Offset: 0x18BBE30 VA: 0x1818BCA30 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x18BCC60 Offset: 0x18BC060 VA: 0x1818BCC60 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x18B9BD0 Offset: 0x18B8FD0 VA: 0x1818B9BD0
	private void GetCursorPosition() { }

	// RVA: 0x18BC9A0 Offset: 0x18BBDA0 VA: 0x1818BC9A0 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x18BC9D0 Offset: 0x18BBDD0 VA: 0x1818BC9D0 Slot: 16
	public int get_CursorLeft() { }

	// RVA: 0x18BCBA0 Offset: 0x18BBFA0 VA: 0x1818BCBA0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x18BCA00 Offset: 0x18BBE00 VA: 0x1818BCA00 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x18BCC00 Offset: 0x18BC000 VA: 0x1818BCC00 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x18BCA70 Offset: 0x18BBE70 VA: 0x1818BCA70 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x18B7140 Offset: 0x18B6540 VA: 0x1818B7140
	private void CheckWindowDimensions() { }

	// RVA: 0x18BCAF0 Offset: 0x18BBEF0 VA: 0x1818BCAF0 Slot: 17
	public int get_WindowHeight() { }

	// RVA: 0x18BCB20 Offset: 0x18BBF20 VA: 0x1818BCB20 Slot: 18
	public int get_WindowWidth() { }

	// RVA: 0x18B6EA0 Offset: 0x18B62A0 VA: 0x1818B6EA0
	private void AddToBuffer(int b) { }

	// RVA: 0x18B6FA0 Offset: 0x18B63A0 VA: 0x1818B6FA0
	private void AdjustBuffer() { }

	// RVA: 0x18B72C0 Offset: 0x18B66C0 VA: 0x1818B72C0
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x18B9EB0 Offset: 0x18B92B0 VA: 0x1818B9EB0
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x18BB010 Offset: 0x18BA410 VA: 0x1818BB010
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x18BAD80 Offset: 0x18BA180 VA: 0x1818BAD80
	private bool InputPending() { }

	// RVA: 0x18BAF10 Offset: 0x18BA310 VA: 0x1818BAF10
	private void QueueEcho(char c) { }

	// RVA: 0x18B9A40 Offset: 0x18B8E40 VA: 0x1818B9A40
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x18B99F0 Offset: 0x18B8DF0 VA: 0x1818B99F0
	private void EchoFlush() { }

	// RVA: 0x18BB530 Offset: 0x18BA930 VA: 0x1818BB530
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x18BB220 Offset: 0x18BA620 VA: 0x1818BB220 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x18BB2D0 Offset: 0x18BA6D0 VA: 0x1818BB2D0 Slot: 19
	public string ReadLine() { }

	// RVA: 0x18BB2E0 Offset: 0x18BA6E0 VA: 0x1818BB2E0
	public string ReadToEnd() { }

	// RVA: 0x18BB2F0 Offset: 0x18BA6F0 VA: 0x1818BB2F0
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x18BBA10 Offset: 0x18BAE10 VA: 0x1818BBA10 Slot: 20
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x18B7400 Offset: 0x18B6800 VA: 0x1818B7400
	private void CreateKeyMap() { }

	// RVA: 0x18BA2E0 Offset: 0x18B96E0 VA: 0x1818BA2E0
	private void InitKeys() { }

	// RVA: 0x18B6E50 Offset: 0x18B6250 VA: 0x1818B6E50
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x18BC190 Offset: 0x18BB590 VA: 0x1818BC190
	private static void .cctor() { }

}

