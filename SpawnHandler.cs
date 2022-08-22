public class SpawnHandler : SingletonComponent<SpawnHandler> // TypeDefIndex: 10011
{	public float TickInterval; // 0x18
	public int MinSpawnsPerTick; // 0x1C
	public int MaxSpawnsPerTick; // 0x20
	public LayerMask PlacementMask; // 0x24
	public LayerMask PlacementCheckMask; // 0x28
	public float PlacementCheckHeight; // 0x2C
	public LayerMask RadiusCheckMask; // 0x30
	public float RadiusCheckDistance; // 0x34
	public LayerMask BoundsCheckMask; // 0x38
	public SpawnFilter CharacterSpawn; // 0x40
	public float CharacterSpawnCutoff; // 0x48
	public SpawnPopulation[] SpawnPopulations; // 0x50
	internal SpawnDistribution[] SpawnDistributions; // 0x58
	internal SpawnDistribution CharDistribution; // 0x60
	internal List<ISpawnGroup> SpawnGroups; // 0x68
	internal List<SpawnIndividual> SpawnIndividuals; // 0x70
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public SpawnPopulation[] ConvarSpawnPopulations; // 0x78


	public void .ctor() { }

}

