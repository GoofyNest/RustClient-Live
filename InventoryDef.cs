public class InventoryDef : IEquatable<InventoryDef> // TypeDefIndex: 5239
{	// Fields
	internal InventoryDefId _id; // 0x10
	internal Dictionary<string, string> _properties; // 0x18
	private InventoryRecipe[] _recContaining; // 0x20

	// Properties
	public int Id { get; }
	public string Name { get; }
	public string Description { get; }
	public string IconUrl { get; }
	public string IconUrlLarge { get; }
	public string PriceCategory { get; }
	public string Type { get; }
	public bool IsGenerator { get; }
	public string ExchangeSchema { get; }
	public bool Marketable { get; }
	public int LocalPrice { get; }
	public string LocalPriceFormatted { get; }

	// Methods

	// RVA: 0xDDBCA0 Offset: 0xDDB0A0 VA: 0x180DDBCA0
	public void .ctor(InventoryDefId defId) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Id() { }

	// RVA: 0xDDC040 Offset: 0xDDB440 VA: 0x180DDC040
	public string get_Name() { }

	// RVA: 0xDDBCD0 Offset: 0xDDB0D0 VA: 0x180DDBCD0
	public string get_Description() { }

	// RVA: 0xDDBD90 Offset: 0xDDB190 VA: 0x180DDBD90
	public string get_IconUrl() { }

	// RVA: 0xDDBD50 Offset: 0xDDB150 VA: 0x180DDBD50
	public string get_IconUrlLarge() { }

	// RVA: 0xDDC080 Offset: 0xDDB480 VA: 0x180DDC080
	public string get_PriceCategory() { }

	// RVA: 0xDDC0C0 Offset: 0xDDB4C0 VA: 0x180DDC0C0
	public string get_Type() { }

	// RVA: 0xDDBDD0 Offset: 0xDDB1D0 VA: 0x180DDBDD0
	public bool get_IsGenerator() { }

	// RVA: 0xDDBD10 Offset: 0xDDB110 VA: 0x180DDBD10
	public string get_ExchangeSchema() { }

	// RVA: 0xDDBAE0 Offset: 0xDDAEE0 VA: 0x180DDBAE0
	public InventoryRecipe[] GetRecipes() { }

	// RVA: 0xDDBFA0 Offset: 0xDDB3A0 VA: 0x180DDBFA0
	public bool get_Marketable() { }

	// RVA: 0xDDB690 Offset: 0xDDAA90 VA: 0x180DDB690
	public string GetProperty(string name) { }

	// RVA: 0xDDB600 Offset: 0xDDAA00 VA: 0x180DDB600
	public bool GetBoolProperty(string name) { }

	// RVA: -1 Offset: -1
	public T GetProperty<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E7F10 Offset: 0x5E7310 VA: 0x1805E7F10
	|-InventoryDef.GetProperty<string>
	|-InventoryDef.GetProperty<object>
	|
	|-RVA: 0x5E8040 Offset: 0x5E7440 VA: 0x1805E8040
	|-InventoryDef.GetProperty<ulong>
	*/

	// RVA: 0xDDBF30 Offset: 0xDDB330 VA: 0x180DDBF30
	public int get_LocalPrice() { }

	// RVA: 0xDDBE40 Offset: 0xDDB240 VA: 0x180DDBE40
	public string get_LocalPriceFormatted() { }

	// RVA: 0xDDB7D0 Offset: 0xDDABD0 VA: 0x180DDB7D0
	public InventoryRecipe[] GetRecipesContainingThis() { }

	// RVA: 0xDDC100 Offset: 0xDDB500 VA: 0x180DDC100
	public static bool op_Equality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDDC170 Offset: 0xDDB570 VA: 0x180DDC170
	public static bool op_Inequality(InventoryDef a, InventoryDef b) { }

	// RVA: 0xDDB4F0 Offset: 0xDDA8F0 VA: 0x180DDB4F0 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0xDDB670 Offset: 0xDDAA70 VA: 0x180DDB670 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xDDB5B0 Offset: 0xDDA9B0 VA: 0x180DDB5B0 Slot: 4
	public bool Equals(InventoryDef p) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDDBC60 Offset: 0xDDB060 VA: 0x180DDBC60
	private InventoryRecipe <GetRecipes>b__21_0(string x) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xDDBC40 Offset: 0xDDB040 VA: 0x180DDBC40
	private bool <GetRecipesContainingThis>b__44_3(InventoryRecipe x) { }

}

private sealed class InventoryDef.<>c // TypeDefIndex: 5240
{	// Fields
	public static readonly InventoryDef.<>c <>9; // 0x0
	public static Func<InventoryDef, InventoryRecipe[]> <>9__44_0; // 0x8
	public static Func<InventoryRecipe[], bool> <>9__44_1; // 0x10
	public static Func<InventoryRecipe[], IEnumerable<InventoryRecipe>> <>9__44_2; // 0x18

	// Methods

	// RVA: 0xDEB3C0 Offset: 0xDEA7C0 VA: 0x180DEB3C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA360 Offset: 0xDE9760 VA: 0x180DEA360
	internal InventoryRecipe[] <GetRecipesContainingThis>b__44_0(InventoryDef x) { }

	// RVA: 0xDEA4D0 Offset: 0xDE98D0 VA: 0x180DEA4D0
	internal bool <GetRecipesContainingThis>b__44_1(InventoryRecipe[] x) { }

	// RVA: 0x7B2BE0 Offset: 0x7B1FE0 VA: 0x1807B2BE0
	internal IEnumerable<InventoryRecipe> <GetRecipesContainingThis>b__44_2(InventoryRecipe[] x) { }

}

