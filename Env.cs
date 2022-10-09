public class Env : ConsoleSystem // TypeDefIndex: 13658
{
	[ClientVar] 
	public static bool cloudmovement { get; set; }
	[ClientVar] 
	public static float cloudrotation { get; set; }
	[ClientVar] 
	public static float skyrotation { get; set; }
	[ReplicatedVar] 
	public static float oceanlevel { get; set; }


	public static bool get_cloudmovement() { }

	public static void set_cloudmovement(bool value) { }

	public static float get_cloudrotation() { }

	public static void set_cloudrotation(float value) { }

	public static float get_skyrotation() { }

	public static void set_skyrotation(float value) { }

	public static float get_oceanlevel() { }

	public static void set_oceanlevel(float value) { }

	public void .ctor() { }

}

