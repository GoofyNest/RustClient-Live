public class Spawn : ConsoleSystem // TypeDefIndex: 13653
{
	[ServerVar] 
	public static float min_rate; 
	[ServerVar] 
	public static float max_rate; 
	[ServerVar] 
	public static float min_density; 
	[ServerVar] 
	public static float max_density; 
	[ServerVar] 
	public static float player_base; 
	[ServerVar] 
	public static float player_scale; 
	[ServerVar] 
	public static bool respawn_populations; 
	[ServerVar] 
	public static bool respawn_groups; 
	[ServerVar] 
	public static bool respawn_individuals; 
	[ServerVar] 
	public static float tick_populations; 
	[ServerVar] 
	public static float tick_individuals; 


	[ServerVar] 
	public static void fill_populations(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void fill_groups(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void fill_individuals(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void report(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void scalars(ConsoleSystem.Arg args) { }

	[ServerVar] 
	public static void cargoshipevent(ConsoleSystem.Arg args) { }

	public void .ctor() { }

	private static void .cctor() { }

}

