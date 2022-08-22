internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 393
{	private static int* native_terminal_size; // 0x0
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

	public bool Initialized { get; }
	public ConsoleColor BackgroundColor { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { get; set; }
	public int CursorTop { get; set; }
	public bool KeyAvailable { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }


	private static string TryTermInfoDir(string dir, string term) { }

	private static string SearchTerminfo(string term) { }

	private void WriteConsole(string str) { }

	public void .ctor(string term) { }

	public bool get_Initialized() { }

	public void Init() { }

	private void IncrementX() { }

	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	public void WriteSpecialKey(char c) { }

	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	public bool IsSpecialKey(char c) { }

	private void ChangeColor(string format, ConsoleColor color) { }

	public ConsoleColor get_BackgroundColor() { }

	public void set_BackgroundColor(ConsoleColor value) { }

	public ConsoleColor get_ForegroundColor() { }

	public void set_ForegroundColor(ConsoleColor value) { }

	private void GetCursorPosition() { }

	public int get_BufferWidth() { }

	public int get_CursorLeft() { }

	public void set_CursorLeft(int value) { }

	public int get_CursorTop() { }

	public void set_CursorTop(int value) { }

	public bool get_KeyAvailable() { }

	private void CheckWindowDimensions() { }

	public int get_WindowHeight() { }

	public int get_WindowWidth() { }

	private void AddToBuffer(int b) { }

	private void AdjustBuffer() { }

	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	private object GetKeyFromBuffer(bool cooked) { }

	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	private bool InputPending() { }

	private void QueueEcho(char c) { }

	private void Echo(ConsoleKeyInfo key) { }

	private void EchoFlush() { }

	public int Read([In] [Out] char[] dest, int index, int count) { }

	public ConsoleKeyInfo ReadKey(bool intercept) { }

	public string ReadLine() { }

	public string ReadToEnd() { }

	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	public void SetCursorPosition(int left, int top) { }

	private void CreateKeyMap() { }

	private void InitKeys() { }

	private void AddStringMapping(TermInfoStrings s) { }

	private static void .cctor() { }

}

