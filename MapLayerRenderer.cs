public class MapLayerRenderer : SingletonComponent<MapLayerRenderer> // TypeDefIndex: 10948
{	private Nullable<int> _underwaterLabFloorCount; // 0x18
	public Camera renderCamera; // 0x20
	public CameraEvent cameraEvent; // 0x28
	public Material renderMaterial; // 0x30
	private Nullable<MapLayer> _currentlyRenderedLayer; // 0x38


	private void RenderTrainLayer() { }

	private CommandBuffer BuildCommandBufferTrainTunnels() { }

	private void RenderUnderwaterLabs(int floor) { }

	public int GetUnderwaterLabFloorCount() { }

	private CommandBuffer BuildCommandBufferUnderwaterLabs(int floor) { }

	public void Render(MapLayer layer) { }

	private void RenderImpl(CommandBuffer cb) { }

	public static MapLayerRenderer GetOrCreate() { }

	public void .ctor() { }

}

private sealed class MapLayerRenderer.<>c // TypeDefIndex: 10949
{	public static readonly MapLayerRenderer.<>c <>9; // 0x0
	public static Func<DungeonBaseInfo, int> <>9__4_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetUnderwaterLabFloorCount>b__4_0(DungeonBaseInfo l) { }

}

