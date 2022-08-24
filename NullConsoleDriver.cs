internal class NullConsoleDriver : IConsoleDriver // TypeDefIndex: 378
{
	private static readonly ConsoleKeyInfo EmptyConsoleKeyInfo; 

public ConsoleColor BackgroundColor { get; set; }
public int BufferWidth { get; }
public int CursorLeft { set; }
public int CursorTop { get; set; }
public ConsoleColor ForegroundColor { get; set; }
public bool KeyAvailable { get; }


public ConsoleColor get_BackgroundColor() { }

public void set_BackgroundColor(ConsoleColor value) { }

public int get_BufferWidth() { }

public void set_CursorLeft(int value) { }

public int get_CursorTop() { }

public void set_CursorTop(int value) { }

public ConsoleColor get_ForegroundColor() { }

public void set_ForegroundColor(ConsoleColor value) { }

public bool get_KeyAvailable() { }

public ConsoleKeyInfo ReadKey(bool intercept) { }

public void .ctor() { }

private static void .cctor() { }

}

