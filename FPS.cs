public class FPS : ConsoleSystem // TypeDefIndex: 13738
{
	private static int _limit;
	[ClientVar]
	public static bool limitInBackground;
	[ClientVar]
	public static bool limitInMenu;
	public const int CappedFrameRateWhileInBackground = 15;
	private static int m_graph;

	[ClientVar]
	[ServerVar]
	public static int limit { get; set; }
	[ClientVar]
	public static int graph { get; set; }


	public static int get_limit() { }

	public static void set_limit(int value) { }

	public static int get_graph() { }

	public static void set_graph(int value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

