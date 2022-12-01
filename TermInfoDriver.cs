internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 393
{
	private static int* native_terminal_size;
	private static int terminal_size;
	private static readonly string[] locations;
	private TermInfoReader reader;
	private int cursorLeft;
	private int cursorTop;
	private string title;
	private string titleFormat;
	private bool cursorVisible;
	private string csrVisible;
	private string csrInvisible;
	private string clear;
	private string bell;
	private string term;
	private StreamReader stdin;
	private CStreamWriter stdout;
	private int windowWidth;
	private int windowHeight;
	private int bufferHeight;
	private int bufferWidth;
	private char[] buffer;
	private int readpos;
	private int writepos;
	private string keypadXmit;
	private string keypadLocal;
	private bool inited;
	private object initLock;
	private bool initKeys;
	private string origPair;
	private string origColors;
	private string cursorAddress;
	private ConsoleColor fgcolor;
	private ConsoleColor bgcolor;
	private string setfgcolor;
	private string setbgcolor;
	private int maxColors;
	private bool noGetPosition;
	private Hashtable keymap;
	private ByteMatcher rootmap;
	private int rl_startx;
	private int rl_starty;
	private byte[] control_characters;
	private static readonly int[] _consoleColorToAnsiCode;
	private char[] echobuf;
	private int echon;

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

