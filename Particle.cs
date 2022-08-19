public class Particle : ConsoleSystem // TypeDefIndex: 11947
{	// Fields
	private static float m_quality; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool simulationspace; // 0x4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool ik; // 0x5

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quality { get; set; }
	public static float lod { get; }
	public static float cull { get; }

	// Methods

	// RVA: 0x3662E0 Offset: 0x3656E0 VA: 0x1803662E0
	public static float get_quality() { }

	// RVA: 0x366340 Offset: 0x365740 VA: 0x180366340
	public static void set_quality(float value) { }

	// RVA: 0x366230 Offset: 0x365630 VA: 0x180366230
	public static float get_lod() { }

	// RVA: 0x366150 Offset: 0x365550 VA: 0x180366150
	public static float get_cull() { }

	// RVA: 0x3660F0 Offset: 0x3654F0 VA: 0x1803660F0
	public void .ctor() { }

	// RVA: 0x366090 Offset: 0x365490 VA: 0x180366090
	private static void .cctor() { }

}

