public class FPS : ConsoleSystem // TypeDefIndex: 11919
{	// Fields
	private static int m_graph; // 0x1F7F0

	// Properties
	[ClientVar] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[ServerVar] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int graph { get; set; }

	// Methods

	// RVA: 0x6DDD20 Offset: 0x6DD120 VA: 0x1806DDD20
	public static int get_limit() { }

	// RVA: 0x6DDE60 Offset: 0x6DD260 VA: 0x1806DDE60
	public static void set_limit(int value) { }

	// RVA: 0x6DDCE0 Offset: 0x6DD0E0 VA: 0x1806DDCE0
	public static int get_graph() { }

	// RVA: 0x6DDD30 Offset: 0x6DD130 VA: 0x1806DDD30
	public static void set_graph(int value) { }

	// RVA: 0x6DDC80 Offset: 0x6DD080 VA: 0x1806DDC80
	public void .ctor() { }

}

