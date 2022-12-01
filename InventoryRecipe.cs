public struct InventoryRecipe : IEquatable<InventoryRecipe> // TypeDefIndex: 5252
{
	public InventoryDef Result;
	public InventoryRecipe.Ingredient[] Ingredients;
	public string Source;


	internal static InventoryRecipe FromString(string part, InventoryDef Result) { }

	internal bool ContainsIngredient(InventoryDef inventoryDef) { }

	public override bool Equals(object p) { }

	public override int GetHashCode() { }

	public bool Equals(InventoryRecipe p) { }

}

public struct InventoryRecipe.Ingredient // TypeDefIndex: 5253
{
	public int DefinitionId;
	public InventoryDef Definition;
	public int Count;


	internal static InventoryRecipe.Ingredient FromString(string part) { }

}

private sealed class InventoryRecipe.<>c // TypeDefIndex: 5254
{
	public static readonly InventoryRecipe.<>c <>9;
	public static Func<string, InventoryRecipe.Ingredient> <>9__4_0;
	public static Func<InventoryRecipe.Ingredient, bool> <>9__4_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal InventoryRecipe.Ingredient <FromString>

	internal bool <FromString>

}

private sealed class InventoryRecipe.<>c__DisplayClass5_0 // TypeDefIndex: 5255
{
	public InventoryDef inventoryDef;


	public void .ctor() { }

	internal bool <ContainsIngredient>

}

