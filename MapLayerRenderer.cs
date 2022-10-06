public class MapLayerRenderer : SingletonComponent<MapLayerRenderer> // TypeDefIndex: 12669
{
	private Nullable<int> _underwaterLabFloorCount; 
	public Camera renderCamera; 
	public CameraEvent cameraEvent; 
	public Material renderMaterial; 
	private Nullable<MapLayer> _currentlyRenderedLayer; 


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

private sealed class MapLayerRenderer.<>c // TypeDefIndex: 12670
{
	public static readonly MapLayerRenderer.<>c <>9; 
	public static Func<DungeonBaseInfo, int> <>9__4_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetUnderwaterLabFloorCount>b__4_0(DungeonBaseInfo l) { }

}

