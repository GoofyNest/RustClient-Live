public class InventoryDef : IEquatable<InventoryDef> // TypeDefIndex: 5240
{
	internal InventoryDefId _id; 
	internal Dictionary<string, string> _properties; 
	private InventoryRecipe[] _recContaining; 

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


	public void .ctor(InventoryDefId defId) { }

	public int get_Id() { }

	public string get_Name() { }

	public string get_Description() { }

	public string get_IconUrl() { }

	public string get_IconUrlLarge() { }

	public string get_PriceCategory() { }

	public string get_Type() { }

	public bool get_IsGenerator() { }

	public string get_ExchangeSchema() { }

	public InventoryRecipe[] GetRecipes() { }

	public bool get_Marketable() { }

	public string GetProperty(string name) { }

	public bool GetBoolProperty(string name) { }

	public T GetProperty<T>(string name) { }
	/* GenericInstMethod :
	|
	|-InventoryDef.GetProperty<string>
	|-InventoryDef.GetProperty<object>
	|
	|-InventoryDef.GetProperty<ulong>
	*/

	public int get_LocalPrice() { }

	public string get_LocalPriceFormatted() { }

	public InventoryRecipe[] GetRecipesContainingThis() { }

	public static bool op_Equality(InventoryDef a, InventoryDef b) { }

	public static bool op_Inequality(InventoryDef a, InventoryDef b) { }

	public override bool Equals(object p) { }

	public override int GetHashCode() { }

	public bool Equals(InventoryDef p) { }

	[CompilerGeneratedAttribute] 
	private InventoryRecipe <GetRecipes>b__21_0(string x) { }

	[CompilerGeneratedAttribute] 
	private bool <GetRecipesContainingThis>b__44_3(InventoryRecipe x) { }

}

private sealed class InventoryDef.<>c // TypeDefIndex: 5241
{
	public static readonly InventoryDef.<>c <>9; 
	public static Func<InventoryDef, InventoryRecipe[]> <>9__44_0; 
	public static Func<InventoryRecipe[], bool> <>9__44_1; 
	public static Func<InventoryRecipe[], IEnumerable<InventoryRecipe>> <>9__44_2; 


	private static void .cctor() { }

	public void .ctor() { }

	internal InventoryRecipe[] <GetRecipesContainingThis>b__44_0(InventoryDef x) { }

	internal bool <GetRecipesContainingThis>b__44_1(InventoryRecipe[] x) { }

	internal IEnumerable<InventoryRecipe> <GetRecipesContainingThis>b__44_2(InventoryRecipe[] x) { }

}

