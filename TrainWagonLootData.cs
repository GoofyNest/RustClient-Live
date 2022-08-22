public class TrainWagonLootData : ScriptableObject // TypeDefIndex: 9775
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainWagonLootData.LootOption[] oreOptions; // 0x18
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainWagonLootData.LootOption lootWagonContent; // 0x20
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TrainWagonLootData.LootOption fuelWagonContent; // 0x28
	public static TrainWagonLootData instance; // 0x0
	private const int LOOT_WAGON_INDEX = 1000;
	private const int FUEL_WAGON_INDEX = 1001;


	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x982E0 Offset: 0x976E0 VA: 0x1800982E0
	private static void Init() { }

	public TrainWagonLootData.LootOption GetLootOption(TrainCarUnloadable.WagonType wagonType, out int index) { }

	public bool TryGetLootFromIndex(int index, out TrainWagonLootData.LootOption lootOption) { }

	public bool TryGetIndexFromLoot(TrainWagonLootData.LootOption lootOption, out int index) { }

	public void .ctor() { }

}

public class TrainWagonLootData.LootOption // TypeDefIndex: 9776
{	public bool showsFX; // 0x10
	public ItemDefinition lootItem; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x98380 Offset: 0x97780 VA: 0x180098380
	public int maxLootAmount; // 0x20
	public int minLootAmount; // 0x24
	public Material lootMaterial; // 0x28
	public float spawnWeighting; // 0x30
	public Color fxTint; // 0x34
	[FormerlySerializedAsAttribute] // RVA: 0x984A0 Offset: 0x978A0 VA: 0x1800984A0
	public Color particleFXTint; // 0x44


	public void .ctor() { }

}

