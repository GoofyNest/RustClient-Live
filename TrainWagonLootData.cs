public class TrainWagonLootData : ScriptableObject // TypeDefIndex: 11528
{
	[SerializeField]
	private TrainWagonLootData.LootOption[] oreOptions;
	[SerializeField]
	[ReadOnlyAttribute]
	private TrainWagonLootData.LootOption lootWagonContent;
	[SerializeField]
	private TrainWagonLootData.LootOption fuelWagonContent;
	public static TrainWagonLootData instance;
	private const int LOOT_WAGON_INDEX = 1000;
	private const int FUEL_WAGON_INDEX = 1001;


	[RuntimeInitializeOnLoadMethodAttribute]
	private static void Init() { }

	public TrainWagonLootData.LootOption GetLootOption(TrainCarUnloadable.WagonType wagonType, out int index) { }

	public bool TryGetLootFromIndex(int index, out TrainWagonLootData.LootOption lootOption) { }

	public bool TryGetIndexFromLoot(TrainWagonLootData.LootOption lootOption, out int index) { }

	public void .ctor() { }

}

public class TrainWagonLootData.LootOption // TypeDefIndex: 11529
{
	public bool showsFX;
	public ItemDefinition lootItem;
	[FormerlySerializedAsAttribute]
	public int maxLootAmount;
	public int minLootAmount;
	public Material lootMaterial;
	public float spawnWeighting;
	public Color fxTint;
	[FormerlySerializedAsAttribute]
	public Color particleFXTint;


	public void .ctor() { }

}

