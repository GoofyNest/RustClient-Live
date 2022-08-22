public struct InventoryRecipe : IEquatable<InventoryRecipe> // TypeDefIndex: 5246
{	public InventoryDef Result; // 0x0
	public InventoryRecipe.Ingredient[] Ingredients; // 0x8
	public string Source; // 0x10


	internal static InventoryRecipe FromString(string part, InventoryDef Result) { }

	internal bool ContainsIngredient(InventoryDef inventoryDef) { }

	public override bool Equals(object p) { }

	public override int GetHashCode() { }

	public bool Equals(InventoryRecipe p) { }

}

public struct InventoryRecipe.Ingredient // TypeDefIndex: 5247
{	public int DefinitionId; // 0x0
	public InventoryDef Definition; // 0x8
	public int Count; // 0x10


	internal static InventoryRecipe.Ingredient FromString(string part) { }

}

private sealed class InventoryRecipe.<>c // TypeDefIndex: 5248
{	public static readonly InventoryRecipe.<>c <>9; // 0x0
	public static Func<string, InventoryRecipe.Ingredient> <>9__4_0; // 0x8
	public static Func<InventoryRecipe.Ingredient, bool> <>9__4_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal InventoryRecipe.Ingredient <FromString>b__4_0(string x) { }

	internal bool <FromString>b__4_1(InventoryRecipe.Ingredient x) { }

}

private sealed class InventoryRecipe.<>c__DisplayClass5_0 // TypeDefIndex: 5249
{	public InventoryDef inventoryDef; // 0x10


	public void .ctor() { }

	internal bool <ContainsIngredient>b__0(InventoryRecipe.Ingredient x) { }

}

