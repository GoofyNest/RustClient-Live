public struct InventoryRecipe : IEquatable<InventoryRecipe> // TypeDefIndex: 5247
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

public struct InventoryRecipe.Ingredient // TypeDefIndex: 5248
{
	public int DefinitionId; 
	public InventoryDef Definition; 
	public int Count; 


	internal static InventoryRecipe.Ingredient FromString(string part) { }

}

private sealed class InventoryRecipe.<>c // TypeDefIndex: 5249
{
	public static readonly InventoryRecipe.<>c <>9; 
	public static Func<string, InventoryRecipe.Ingredient> <>9__4_0; 
	public static Func<InventoryRecipe.Ingredient, bool> <>9__4_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal InventoryRecipe.Ingredient <FromString>b__4_0(string x) { }

	internal bool <FromString>b__4_1(InventoryRecipe.Ingredient x) { }

}

private sealed class InventoryRecipe.<>c__DisplayClass5_0 // TypeDefIndex: 5250
{
	public InventoryDef inventoryDef; 


	public void .ctor() { }

	internal bool <ContainsIngredient>b__0(InventoryRecipe.Ingredient x) { }

}

