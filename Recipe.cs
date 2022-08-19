public class Recipe : ScriptableObject // TypeDefIndex: 10751
{	// Fields
	[HeaderAttribute] // RVA: 0x780E0 Offset: 0x774E0 VA: 0x1800780E0
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

	// Properties
	public string DisplayName { get; }
	public string DisplayDescription { get; }
	public Sprite DisplayIcon { get; }

	// Methods

	// RVA: 0x6AB7D0 Offset: 0x6AABD0 VA: 0x1806AB7D0
	public string get_DisplayName() { }

	// RVA: 0x6AB670 Offset: 0x6AAA70 VA: 0x1806AB670
	public string get_DisplayDescription() { }

	// RVA: 0x6AB730 Offset: 0x6AAB30 VA: 0x1806AB730
	public Sprite get_DisplayIcon() { }

	// RVA: 0x6AB580 Offset: 0x6AA980 VA: 0x1806AB580
	public bool ContainsItem(Item item) { }

	// RVA: 0x6AB650 Offset: 0x6AAA50 VA: 0x1806AB650
	public void .ctor() { }

}

public struct Recipe.RecipeIngredient // TypeDefIndex: 10752
{	// Fields
	public ItemDefinition Ingredient; // 0x0
	public int Count; // 0x8

}

