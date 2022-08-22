public class Recipe : ScriptableObject // TypeDefIndex: 10751
{	[HeaderAttribute] // RVA: 0x780E0 Offset: 0x774E0 VA: 0x1800780E0
	public ItemDefinition ProducedItem; // 0x18
	public int ProducedItemCount; // 0x20
	public bool CanQueueMultiple; // 0x24
	[HeaderAttribute] // RVA: 0x782B0 Offset: 0x776B0 VA: 0x1800782B0
	public GameObjectRef SpawnedItem; // 0x28
	public string SpawnedItemName; // 0x30
	public string SpawnedItemDescription; // 0x38
	public Sprite SpawnedItemIcon; // 0x40
	[HeaderAttribute] // RVA: 0x71D40 Offset: 0x71140 VA: 0x180071D40
	public bool RequiresBlueprint; // 0x48
	public Recipe.RecipeIngredient[] Ingredients; // 0x50
	public float MixingDuration; // 0x58

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
{	public ItemDefinition Ingredient; // 0x0
	public int Count; // 0x8

}

