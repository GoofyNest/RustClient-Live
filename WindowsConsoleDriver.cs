internal class WindowsConsoleDriver : IConsoleDriver // TypeDefIndex: 428
{
	private IntPtr inputHandle; 
	private IntPtr outputHandle; 
	private short defaultAttribute; 

public ConsoleColor BackgroundColor { get; set; }
public int BufferWidth { get; }
public int CursorLeft { get; set; }
public int CursorTop { get; set; }
public ConsoleColor ForegroundColor { get; set; }
public bool KeyAvailable { get; }


public void .ctor() { }

private static ConsoleColor GetForeground(short attr) { }

private static ConsoleColor GetBackground(short attr) { }

private static short GetAttrForeground(int attr, ConsoleColor color) { }

private static short GetAttrBackground(int attr, ConsoleColor color) { }

public ConsoleColor get_BackgroundColor() { }

public void set_BackgroundColor(ConsoleColor value) { }

public int get_BufferWidth() { }

public int get_CursorLeft() { }

public void set_CursorLeft(int value) { }

public int get_CursorTop() { }

public void set_CursorTop(int value) { }

public ConsoleColor get_ForegroundColor() { }

public void set_ForegroundColor(ConsoleColor value) { }

public bool get_KeyAvailable() { }

public ConsoleKeyInfo ReadKey(bool intercept) { }

public void SetCursorPosition(int left, int top) { }

private static bool IsModifierKey(short virtualKeyCode) { }

private static extern IntPtr GetStdHandle(Handles handle) { }

private static extern bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info) { }

private static extern bool SetConsoleCursorPosition(IntPtr handle, Coord coord) { }

private static extern bool SetConsoleTextAttribute(IntPtr handle, short attribute) { }

private static extern bool PeekConsoleInput(IntPtr handle, out InputRecord record, int length, out int eventsRead) { }

private static extern bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread) { }

}

