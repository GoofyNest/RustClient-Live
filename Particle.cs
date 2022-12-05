public class Particle : ConsoleSystem // TypeDefIndex: 13756
{
	private static float m_quality;
	[ClientVar]
	public static bool simulationspace;
	[ClientVar]
	public static bool ik;

	[ClientVar]
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }


	public static float get_quality() { }

	public static void set_quality(float value) { }

	public static float get_lod() { }

	public static float get_cull() { }

	public void .ctor() { }

	private static void .cctor() { }

}

