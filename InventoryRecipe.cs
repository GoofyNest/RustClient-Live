public struct InventoryRecipe : IEquatable<InventoryRecipe> // TypeDefIndex: 5246
{	// Fields
	public InventoryDef Result; // 0x0
	public InventoryRecipe.Ingredient[] Ingredients; // 0x8
	public string Source; // 0x10

	// Methods

	// RVA: 0xDDCCD0 Offset: 0xDDC0D0 VA: 0x180DDCCD0
	internal static InventoryRecipe FromString(string part, InventoryDef Result) { }

	// RVA: 0x122CE0 Offset: 0x1220E0 VA: 0x180122CE0
	internal bool ContainsIngredient(InventoryDef inventoryDef) { }

	// RVA: 0x122D60 Offset: 0x122160 VA: 0x180122D60 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x122E10 Offset: 0x122210 VA: 0x180122E10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x122CF0 Offset: 0x1220F0 VA: 0x180122CF0 Slot: 4
	public bool Equals(InventoryRecipe p) { }

}

public struct InventoryRecipe.Ingredient // TypeDefIndex: 5247
{	// Fields
	public int DefinitionId; // 0x0
	public InventoryDef Definition; // 0x8
	public int Count; // 0x10

	// Methods

	// RVA: 0xDDB310 Offset: 0xDDA710 VA: 0x180DDB310
	internal static InventoryRecipe.Ingredient FromString(string part) { }

}

private sealed class InventoryRecipe.<>c // TypeDefIndex: 5248
{	// Fields
	public static readonly InventoryRecipe.<>c <>9; // 0x0
	public static Func<string, InventoryRecipe.Ingredient> <>9__4_0; // 0x8
	public static Func<InventoryRecipe.Ingredient, bool> <>9__4_1; // 0x10

	// Methods

	// RVA: 0xDEB360 Offset: 0xDEA760 VA: 0x180DEB360
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEA250 Offset: 0xDE9650 VA: 0x180DEA250
	internal InventoryRecipe.Ingredient <FromString>b__4_0(string x) { }

	// RVA: 0xDEA290 Offset: 0xDE9690 VA: 0x180DEA290
	internal bool <FromString>b__4_1(InventoryRecipe.Ingredient x) { }

}

private sealed class InventoryRecipe.<>c__DisplayClass5_0 // TypeDefIndex: 5249
{	// Fields
	public InventoryDef inventoryDef; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xDEB220 Offset: 0xDEA620 VA: 0x180DEB220
	internal bool <ContainsIngredient>b__0(InventoryRecipe.Ingredient x) { }

}

