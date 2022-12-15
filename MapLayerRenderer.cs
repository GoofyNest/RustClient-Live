public class MapLayerRenderer : SingletonComponent<MapLayerRenderer> // TypeDefIndex: 12736
{
	private Nullable<uint> _currentlyRenderedDungeon;
	private Nullable<int> _underwaterLabFloorCount;
	public Camera renderCamera;
	public CameraEvent cameraEvent;
	public Material renderMaterial;
	private Nullable<MapLayer> _currentlyRenderedLayer;


	private void RenderDungeonsLayer() { }

	private CommandBuffer BuildCommandBufferDungeons(ProceduralDynamicDungeon closest) { }

	public static ProceduralDynamicDungeon FindDungeon(Vector3 position, float maxDist = 200) { }

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

private sealed class MapLayerRenderer.<>c // TypeDefIndex: 12737
{
	public static readonly MapLayerRenderer.<>c <>9;
	public static Func<DungeonBaseInfo, int> <>9__8_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal int <GetUnderwaterLabFloorCount>

}

