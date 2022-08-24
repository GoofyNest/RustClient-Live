public class Inventory : ConsoleSystem // TypeDefIndex: 11934
{
	private static float _quickCraftDelay; 

	[ClientVar] 
	public static float quickcraftdelay { get; set; }


	[ClientVar] 
	[ServerVar] 
	public static void defs(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	[ServerVar] 
	public static void reloaddefs(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void toggle() { }

	[ClientVar] 
	public static void examineheld() { }

	[ClientVar] 
	public static void togglecrafting() { }

	[ClientVar] 
	public static void ResetCraftCounts() { }

	[ClientVar] 
	public static void ListCraftCounts() { }

	public static float get_quickcraftdelay() { }

	public static void set_quickcraftdelay(float value) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Inventory.<>c // TypeDefIndex: 11935
{
	public static readonly Inventory.<>c <>9; 
	public static Func<InventoryDef, string> <>9__0_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal string <defs>b__0_0(InventoryDef x) { }

}

