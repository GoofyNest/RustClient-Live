public static class MapImageRenderer // TypeDefIndex: 10755
{
	private static readonly Vector3 StartColor; 
	private static readonly Vector4 WaterColor; 
	private static readonly Vector4 GravelColor; 
	private static readonly Vector4 DirtColor; 
	private static readonly Vector4 SandColor; 
	private static readonly Vector4 GrassColor; 
	private static readonly Vector4 ForestColor; 
	private static readonly Vector4 RockColor; 
	private static readonly Vector4 SnowColor; 
	private static readonly Vector4 PebbleColor; 
	private static readonly Vector4 OffShoreColor; 
	private static readonly Vector3 SunDirection; 
	private const float SunPower = 0,65;
	private const float Brightness = 1,05;
	private const float Contrast = 0,94;
	private const float OceanWaterLevel = 0;
	private static readonly Vector3 Half; 


	public static byte[] Render(out int imageWidth, out int imageHeight, out Color background, float scale = 0,5, bool lossy = True) { }

	private static byte[] EncodeToFile(int width, int height, Color[] pixels, bool lossy) { }

	private static Vector3 UnpackNormal(Vector4 value) { }

	private static void .cctor() { }

}

private struct MapImageRenderer.Array2D<T> // TypeDefIndex: 10756
{
	private readonly T[] _items; 
	private readonly int _width; 
	private readonly int _height; 

	public T Item { get; }


	public void .ctor(T[] items, int width, int height) { }
	/* GenericInstMethod :
	|
	|-MapImageRenderer.Array2D<object>..ctor
	|-MapImageRenderer.Array2D<Color>..ctor
	*/

	public ref T get_Item(int x, int y) { }
	/* GenericInstMethod :
	|
	|-MapImageRenderer.Array2D<object>.get_Item
	|
	|-MapImageRenderer.Array2D<Color>.get_Item
	*/

}

private sealed class MapImageRenderer.<>c__DisplayClass17_0 // TypeDefIndex: 10757
{
	public TerrainHeightMap terrainHeightMap; 
	public TerrainSplatMap terrainSplatMap; 
	public float invMapRes; 
	public int mapRes; 
	public MapImageRenderer.Array2D<Color> output; 


	public void .ctor() { }

	internal float <Render>g__GetHeight|0(float x, float y) { }

	internal Vector3 <Render>g__GetNormal|1(float x, float y) { }

	internal float <Render>g__GetSplat|2(float x, float y, int mask) { }

	internal void <Render>b__3(int y) { }

}

