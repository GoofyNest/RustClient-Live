public class TerrainGenerator : SingletonComponent<TerrainGenerator> // TypeDefIndex: 10568
{	public TerrainConfig config; // 0x18
	private const float HeightMapRes = 1;
	private const float SplatMapRes = 0,5;
	private const float BaseMapRes = 0,01;


	public static int GetHeightMapRes() { }

	public static int GetSplatMapRes() { }

	public static int GetBaseMapRes() { }

	public GameObject CreateTerrain() { }

	public GameObject CreateTerrain(int heightmapResolution, int alphamapResolution) { }

	public void .ctor() { }

}

