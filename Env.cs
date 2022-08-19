public class Env : ConsoleSystem // TypeDefIndex: 11917
{	// Properties
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool cloudmovement { get; set; }
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float cloudrotation { get; set; }
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static float skyrotation { get; set; }
	[ReplicatedVar] // RVA: 0x9A910 Offset: 0x99D10 VA: 0x18009A910
	public static float oceanlevel { get; set; }

	// Methods

	// RVA: 0x6DD570 Offset: 0x6DC970 VA: 0x1806DD570
	public static bool get_cloudmovement() { }

	// RVA: 0x6DD8B0 Offset: 0x6DCCB0 VA: 0x1806DD8B0
	public static void set_cloudmovement(bool value) { }

	// RVA: 0x6DD650 Offset: 0x6DCA50 VA: 0x1806DD650
	public static float get_cloudrotation() { }

	// RVA: 0x6DD990 Offset: 0x6DCD90 VA: 0x1806DD990
	public static void set_cloudrotation(float value) { }

	// RVA: 0x6DD7D0 Offset: 0x6DCBD0 VA: 0x1806DD7D0
	public static float get_skyrotation() { }

	// RVA: 0x6DDB50 Offset: 0x6DCF50 VA: 0x1806DDB50
	public static void set_skyrotation(float value) { }

	// RVA: 0x6DD730 Offset: 0x6DCB30 VA: 0x1806DD730
	public static float get_oceanlevel() { }

	// RVA: 0x6DDAF0 Offset: 0x6DCEF0 VA: 0x1806DDAF0
	public static void set_oceanlevel(float value) { }

	// RVA: 0x6DD510 Offset: 0x6DC910 VA: 0x1806DD510
	public void .ctor() { }

}

