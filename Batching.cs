public class Batching : ConsoleSystem // TypeDefIndex: 13619
{
	[ClientVar] 
	public static bool renderers; 
	[ClientVar] 
	public static bool renderer_threading; 
	[ClientVar] 
	public static int renderer_capacity; 
	[ClientVar] 
	public static int renderer_vertices; 
	[ClientVar] 
	public static int renderer_submeshes; 
	[ServerVar] 
	[ClientVar] 
	public static int verbose; 


	[ClientVar] 
	public static void refresh_renderers(ConsoleSystem.Arg args) { }

	[ClientVar] 
	public static void print_renderers(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

