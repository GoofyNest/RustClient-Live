public static class TerrainBiome // TypeDefIndex: 7781
{
public static class TerrainBiome // TypeDefIndex: 7781
	public const int COUNT = 4;
	public const int EVERYTHING = -1;
	public const int NOTHING = 0;
	public const int ARID = 1;
	public const int TEMPERATE = 2;
	public const int TUNDRA = 4;
	public const int ARCTIC = 8;
	public const int ARID_IDX = 0;
	public const int TEMPERATE_IDX = 1;
	public const int TUNDRA_IDX = 2;
	public const int ARCTIC_IDX = 3;
	private static Dictionary<int, int> type2index; // 0x2B0AA98


	public static int TypeToIndex(int id) { }

	public static int IndexToType(int idx) { }

	private static void .cctor() { }

}

public enum TerrainBiome.Enum // TypeDefIndex: 7782
{	public int value__; // 0x0
	public const TerrainBiome.Enum Arid = 1;
	public const TerrainBiome.Enum Temperate = 2;
	public const TerrainBiome.Enum Tundra = 4;
	public const TerrainBiome.Enum Arctic = 8;

}

