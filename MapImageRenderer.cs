public static class MapImageRenderer // TypeDefIndex: 10744
{	private static readonly Vector3 StartColor; // 0x0
	private static readonly Vector4 WaterColor; // 0xC
	private static readonly Vector4 GravelColor; // 0x1C
	private static readonly Vector4 DirtColor; // 0x2C
	private static readonly Vector4 SandColor; // 0x3C
	private static readonly Vector4 GrassColor; // 0x4C
	private static readonly Vector4 ForestColor; // 0x5C
	private static readonly Vector4 RockColor; // 0x6C
	private static readonly Vector4 SnowColor; // 0x7C
	private static readonly Vector4 PebbleColor; // 0x8C
	private static readonly Vector4 OffShoreColor; // 0x9C
	private static readonly Vector3 SunDirection; // 0xAC
	private const float SunPower = 0,65;
	private const float Brightness = 1,05;
	private const float Contrast = 0,94;
	private const float OceanWaterLevel = 0;
	private static readonly Vector3 Half; // 0xB8


	public static byte[] Render(out int imageWidth, out int imageHeight, out Color background, float scale = 0,5, bool lossy = True) { }

	private static byte[] EncodeToFile(int width, int height, Color[] pixels, bool lossy) { }

	private static Vector3 UnpackNormal(Vector4 value) { }

	private static void .cctor() { }

}

private struct MapImageRenderer.Array2D<T> // TypeDefIndex: 10745
{	private readonly T[] _items; // 0x0
	private readonly int _width; // 0x0
	private readonly int _height; // 0x0

	public T Item { get; }


	public void .ctor(T[] items, int width, int height) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF9C90 Offset: 0xF9090 VA: 0x1800F9C90
	|-MapImageRenderer.Array2D<object>..ctor
	|-MapImageRenderer.Array2D<Color>..ctor
	*/

	public ref T get_Item(int x, int y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x210D70 Offset: 0x210170 VA: 0x180210D70
	|-MapImageRenderer.Array2D<object>.get_Item
	|
	|-RVA: 0x210CA0 Offset: 0x2100A0 VA: 0x180210CA0
	|-MapImageRenderer.Array2D<Color>.get_Item
	*/

}

private sealed class MapImageRenderer.<>c__DisplayClass17_0 // TypeDefIndex: 10746
{	public TerrainHeightMap terrainHeightMap; // 0x10
	public TerrainSplatMap terrainSplatMap; // 0x18
	public float invMapRes; // 0x20
	public int mapRes; // 0x24
	public MapImageRenderer.Array2D<Color> output; // 0x28


	public void .ctor() { }

	internal float <Render>g__GetHeight|0(float x, float y) { }

	internal Vector3 <Render>g__GetNormal|1(float x, float y) { }

	internal float <Render>g__GetSplat|2(float x, float y, int mask) { }

	internal void <Render>b__3(int y) { }

}

