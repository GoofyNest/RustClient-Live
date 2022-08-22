public class Inventory : ConsoleSystem // TypeDefIndex: 11934
{	private static float _quickCraftDelay; // 0x1F840

	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static float quickcraftdelay { get; set; }


	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static void defs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	[ServerVar] // RVA: 0x93490 Offset: 0x92890 VA: 0x180093490
	public static void reloaddefs(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void toggle() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void examineheld() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void togglecrafting() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void ResetCraftCounts() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void ListCraftCounts() { }

	public static float get_quickcraftdelay() { }

	public static void set_quickcraftdelay(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Inventory.<>c // TypeDefIndex: 11935
{	public static readonly Inventory.<>c <>9; // 0x0
	public static Func<InventoryDef, string> <>9__0_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal string <defs>b__0_0(InventoryDef x) { }

}

