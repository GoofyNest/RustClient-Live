public class TerrainGenerator : SingletonComponent<TerrainGenerator> // TypeDefIndex: 10568
{	// Fields
	public TerrainConfig config; // 0x18
	private const float HeightMapRes = 1;
	private const float SplatMapRes = 0,5;
	private const float BaseMapRes = 0,01;

	// Methods

	// RVA: 0x113B5E0 Offset: 0x113A9E0 VA: 0x18113B5E0
	public static int GetHeightMapRes() { }

	// RVA: 0x113B680 Offset: 0x113AA80 VA: 0x18113B680
	public static int GetSplatMapRes() { }

	// RVA: 0x113B540 Offset: 0x113A940 VA: 0x18113B540
	public static int GetBaseMapRes() { }

	// RVA: 0x113B3E0 Offset: 0x113A7E0 VA: 0x18113B3E0
	public GameObject CreateTerrain() { }

	// RVA: 0x113AD00 Offset: 0x113A100 VA: 0x18113AD00
	public GameObject CreateTerrain(int heightmapResolution, int alphamapResolution) { }

	// RVA: 0x113B720 Offset: 0x113AB20 VA: 0x18113B720
	public void .ctor() { }

}

