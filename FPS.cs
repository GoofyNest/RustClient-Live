public class FPS : ConsoleSystem // TypeDefIndex: 11919
{	private static int m_graph; // 0x1F7F0

	[ClientVar] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[ServerVar] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	public static int limit { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static int graph { get; set; }


	public static int get_limit() { }

	public static void set_limit(int value) { }

	public static int get_graph() { }

	public static void set_graph(int value) { }

	public void .ctor() { }

}

