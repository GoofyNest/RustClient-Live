public class SpawnHandler : SingletonComponent<SpawnHandler> // TypeDefIndex: 11763
{
	public float TickInterval;
	public int MinSpawnsPerTick;
	public int MaxSpawnsPerTick;
	public LayerMask PlacementMask;
	public LayerMask PlacementCheckMask;
	public float PlacementCheckHeight;
	public LayerMask RadiusCheckMask;
	public float RadiusCheckDistance;
	public LayerMask BoundsCheckMask;
	public SpawnFilter CharacterSpawn;
	public float CharacterSpawnCutoff;
	public SpawnPopulation[] SpawnPopulations;
	internal SpawnDistribution[] SpawnDistributions;
	internal SpawnDistribution CharDistribution;
	internal List<ISpawnGroup> SpawnGroups;
	internal List<SpawnIndividual> SpawnIndividuals;
	[ReadOnlyAttribute]
	public SpawnPopulation[] ConvarSpawnPopulations;


	public void .ctor() { }

}

