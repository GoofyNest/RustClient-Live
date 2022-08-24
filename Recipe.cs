public class Recipe : ScriptableObject // TypeDefIndex: 10751
{
	[HeaderAttribute] 
	public ItemDefinition ProducedItem; 
	public int ProducedItemCount; 
	public bool CanQueueMultiple; 
	[HeaderAttribute] 
	public GameObjectRef SpawnedItem; 
	public string SpawnedItemName; 
	public string SpawnedItemDescription; 
	public Sprite SpawnedItemIcon; 
	[HeaderAttribute] 
	public bool RequiresBlueprint; 
	public Recipe.RecipeIngredient[] Ingredients; 
	public float MixingDuration; 

	public string DisplayName { get; }
	public string DisplayDescription { get; }
	public Sprite DisplayIcon { get; }


	public string get_DisplayName() { }

	public string get_DisplayDescription() { }

	public Sprite get_DisplayIcon() { }

	public bool ContainsItem(Item item) { }

	public void .ctor() { }

}

public struct Recipe.RecipeIngredient // TypeDefIndex: 10752
{
	public ItemDefinition Ingredient; 
	public int Count; 

}

