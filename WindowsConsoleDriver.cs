internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 428
{	// Fields
	private IntPtr inputHandle; // 0x10
	private IntPtr outputHandle; // 0x18
	private short defaultAttribute; // 0x20

	// Properties
	public ConsoleColor BackgroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { get; set; }
	public int CursorTop { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public bool KeyAvailable { get; }

	// Methods

	// RVA: 0x21450A0 Offset: 0x21444A0 VA: 0x1821450A0
	public void .ctor() { }

	// RVA: 0x2144980 Offset: 0x2143D80 VA: 0x182144980
	private static ConsoleColor GetForeground(short attr) { }

	// RVA: 0x21448D0 Offset: 0x2143CD0 VA: 0x1821448D0
	private static ConsoleColor GetBackground(short attr) { }

	// RVA: 0x21448C0 Offset: 0x2143CC0 VA: 0x1821448C0
	private static short GetAttrForeground(int attr, ConsoleColor color) { }

	// RVA: 0x21448B0 Offset: 0x2143CB0 VA: 0x1821448B0
	private static short GetAttrBackground(int attr, ConsoleColor color) { }

	// RVA: 0x2145180 Offset: 0x2144580 VA: 0x182145180 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x21457D0 Offset: 0x2144BD0 VA: 0x1821457D0 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x2145220 Offset: 0x2144620 VA: 0x182145220 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x21452C0 Offset: 0x21446C0 VA: 0x1821452C0 Slot: 14
	public int get_CursorLeft() { }

	// RVA: 0x21458A0 Offset: 0x2144CA0 VA: 0x1821458A0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x2145360 Offset: 0x2144760 VA: 0x182145360 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x2145970 Offset: 0x2144D70 VA: 0x182145970 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x2145410 Offset: 0x2144810 VA: 0x182145410 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x2145A40 Offset: 0x2144E40 VA: 0x182145A40 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x21454B0 Offset: 0x21448B0 VA: 0x1821454B0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x2144C70 Offset: 0x2144070 VA: 0x182144C70 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x2144FF0 Offset: 0x21443F0 VA: 0x182144FF0 Slot: 15
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x2144A20 Offset: 0x2143E20 VA: 0x182144A20
	private static bool IsModifierKey(short virtualKeyCode) { }

	// RVA: 0x2144990 Offset: 0x2143D90 VA: 0x182144990
	private static extern IntPtr GetStdHandle(Handles handle) { }

	// RVA: 0x21448E0 Offset: 0x2143CE0 VA: 0x1821448E0
	private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

	// RVA: 0x2144EB0 Offset: 0x21442B0 VA: 0x182144EB0
	private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord) { }

	// RVA: 0x2144F50 Offset: 0x2144350 VA: 0x182144F50
	private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

	// RVA: 0x2144A50 Offset: 0x2143E50 VA: 0x182144A50
	private static extern bool PeekConsoleInput(IntPtr handle, out InputRecord record, int length, out int eventsRead) { }

	// RVA: 0x2144B60 Offset: 0x2143F60 VA: 0x182144B60
	private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

}

