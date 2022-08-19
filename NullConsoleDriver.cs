internal class NullConsoleDriver : IConsoleDriver // TypeDefIndex: 378
{	// Fields
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; // 0x2B0AAB0

	// Properties
	public ConsoleColor BackgroundColor { get; set; }
	public int BufferWidth { get; }
	public int CursorLeft { set; }
	public int CursorTop { get; set; }
	public ConsoleColor ForegroundColor { get; set; }
	public bool KeyAvailable { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 4
	public ConsoleColor get_BackgroundColor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void set_BackgroundColor(ConsoleColor value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 6
	public int get_BufferWidth() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public void set_CursorLeft(int value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 8
	public int get_CursorTop() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	public void set_CursorTop(int value) { }

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80 Slot: 10
	public ConsoleColor get_ForegroundColor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 11
	public void set_ForegroundColor(ConsoleColor value) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 12
	public bool get_KeyAvailable() { }

	// RVA: 0x16747A0 Offset: 0x1673BA0 VA: 0x1816747A0 Slot: 13
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void .ctor() { }

	// RVA: 0x1674810 Offset: 0x1673C10 VA: 0x181674810
	private static void .cctor() { }

}

