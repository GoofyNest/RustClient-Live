public class MapLayerRenderer : SingletonComponent<MapLayerRenderer> // TypeDefIndex: 10948
{	// Fields
	private Nullable<int> _underwaterLabFloorCount; // 0x18
	public Camera renderCamera; // 0x20
	public CameraEvent cameraEvent; // 0x28
	public Material renderMaterial; // 0x30
	private Nullable<MapLayer> _currentlyRenderedLayer; // 0x38

	// Methods

	// RVA: 0x57FC50 Offset: 0x57F050 VA: 0x18057FC50
	private void RenderTrainLayer() { }

	// RVA: 0x57F010 Offset: 0x57E410 VA: 0x18057F010
	private CommandBuffer BuildCommandBufferTrainTunnels() { }

	// RVA: 0x57FD30 Offset: 0x57F130 VA: 0x18057FD30
	private void RenderUnderwaterLabs(int floor) { }

	// RVA: 0x57F9D0 Offset: 0x57EDD0 VA: 0x18057F9D0
	public int GetUnderwaterLabFloorCount() { }

	// RVA: 0x57F350 Offset: 0x57E750 VA: 0x18057F350
	private CommandBuffer BuildCommandBufferUnderwaterLabs(int floor) { }

	// RVA: 0x57FE10 Offset: 0x57F210 VA: 0x18057FE10
	public void Render(MapLayer layer) { }

	// RVA: 0x57FB80 Offset: 0x57EF80 VA: 0x18057FB80
	private void RenderImpl(CommandBuffer cb) { }

	// RVA: 0x57F800 Offset: 0x57EC00 VA: 0x18057F800
	public static MapLayerRenderer GetOrCreate() { }

	// RVA: 0x57FEB0 Offset: 0x57F2B0 VA: 0x18057FEB0
	public void .ctor() { }

}

private sealed class MapLayerRenderer.<>c // TypeDefIndex: 10949
{	// Fields
	public static readonly MapLayerRenderer.<>c <>9; // 0x0
	public static Func<DungeonBaseInfo, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x589290 Offset: 0x588690 VA: 0x180589290
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5883D0 Offset: 0x5877D0 VA: 0x1805883D0
	internal int <GetUnderwaterLabFloorCount>b__4_0(DungeonBaseInfo l) { }

}

