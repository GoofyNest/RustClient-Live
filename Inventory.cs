public class Inventory : ConsoleSystem // TypeDefIndex: 11934
{	// Fields
	private static float _quickCraftDelay; // 0x1F840

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quickcraftdelay { get; set; }

	// Methods

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x363140 Offset: 0x362540 VA: 0x180363140
	public static void defs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	// RVA: 0x3634F0 Offset: 0x3628F0 VA: 0x1803634F0
	public static void reloaddefs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x3635B0 Offset: 0x3629B0 VA: 0x1803635B0
	public static void toggle() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x363340 Offset: 0x362740 VA: 0x180363340
	public static void examineheld() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x363610 Offset: 0x362A10 VA: 0x180363610
	public static void togglecrafting() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x363020 Offset: 0x362420 VA: 0x180363020
	public static void ResetCraftCounts() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x362FA0 Offset: 0x3623A0 VA: 0x180362FA0
	public static void ListCraftCounts() { }

	// RVA: 0x363490 Offset: 0x362890 VA: 0x180363490
	public static float get_quickcraftdelay() { }

	// RVA: 0x363500 Offset: 0x362900 VA: 0x180363500
	public static void set_quickcraftdelay(float value) { }

	// RVA: 0x3630E0 Offset: 0x3624E0 VA: 0x1803630E0
	public void .ctor() { }

	// RVA: 0x3630A0 Offset: 0x3624A0 VA: 0x1803630A0
	private static void .cctor() { }

}

private sealed class Inventory.<>c // TypeDefIndex: 11935
{	// Fields
	public static readonly Inventory.<>c <>9; // 0x0
	public static Func<InventoryDef, string> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x36C0A0 Offset: 0x36B4A0 VA: 0x18036C0A0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x36BEE0 Offset: 0x36B2E0 VA: 0x18036BEE0
	internal string <defs>b__0_0(InventoryDef x) { }

}

