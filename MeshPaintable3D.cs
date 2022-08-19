public class MeshPaintable3D : BaseMeshPaintable // TypeDefIndex: 9204
{	// Fields
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float brushScale; // 0x0
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float uvBufferScale; // 0x4
	public string replacementTextureName; // 0x18
	public int textureWidth; // 0x20
	public int textureHeight; // 0x24
	public Camera cameraPreview; // 0x28
	public Camera camera3D; // 0x30
	private CommandBuffer _commandBuffer; // 0x38
	private Material _uvMaterial; // 0x40
	private RenderTexture _uvBuffer; // 0x48
	private float _uvFactor; // 0x50
	private Texture2D _uvTexture; // 0x58
	private Texture2D _paintTexture; // 0x60
	private int _lastDrawTime; // 0x68
	private RectInt _areaClamp; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <HasChanges>k__BackingField; // 0x7C

	// Properties
	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }

	// Methods

	// RVA: 0x961100 Offset: 0x960500 VA: 0x180961100
	public void OnDestroy() { }

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9619E0 Offset: 0x960DE0 VA: 0x1809619E0 Slot: 6
	public override bool get_HasChanges() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9619F0 Offset: 0x960DF0 VA: 0x1809619F0 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x960A80 Offset: 0x95FE80 VA: 0x180960A80 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x960440 Offset: 0x95F840 VA: 0x180960440 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x960360 Offset: 0x95F760 VA: 0x180960360 Slot: 9
	public override void Clear() { }

	// RVA: 0x9602C0 Offset: 0x95F6C0 VA: 0x1809602C0 Slot: 10
	public override void Apply() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x961320 Offset: 0x960720 VA: 0x180961320
	private void PrepareForDrawing() { }

	// RVA: 0x961960 Offset: 0x960D60 VA: 0x180961960
	public void .ctor() { }

	// RVA: 0x961910 Offset: 0x960D10 VA: 0x180961910
	private static void .cctor() { }

}

private struct MeshPaintable3D.DrawTextureJob : IJobParallelFor // TypeDefIndex: 9205
{	// Fields
	public int textureWidth; // 0x0
	public int2 textureMaxPos; // 0x4
	[ReadOnlyAttribute] // RVA: 0xD9A30 Offset: 0xD8E30 VA: 0x1800D9A30
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9A30 Offset: 0xD8E30 VA: 0x1800D9A30
	public NativeArray<Color32> textureData; // 0x10
	public Color textureColor; // 0x20
	public float textureScaleX; // 0x30
	public float textureScaleY; // 0x34
	public int uvWidth; // 0x38
	public int2 uvMaxPos; // 0x3C
	[ReadOnlyAttribute] // RVA: 0xD9A30 Offset: 0xD8E30 VA: 0x1800D9A30
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9A30 Offset: 0xD8E30 VA: 0x1800D9A30
	public NativeArray<half2> uvData; // 0x48
	public int paintWidth; // 0x58
	public int paintHeight; // 0x5C
	[ReadOnlyAttribute] // RVA: 0xD9CD0 Offset: 0xD90D0 VA: 0x1800D9CD0
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0xD9CD0 Offset: 0xD90D0 VA: 0x1800D9CD0
	[DeallocateOnJobCompletionAttribute] // RVA: 0xD9CD0 Offset: 0xD90D0 VA: 0x1800D9CD0
	public NativeArray<Color32> paintDataCurrent; // 0x60
	[WriteOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeDisableParallelForRestrictionAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<Color32> paintDataNew; // 0x70
	public int startX; // 0x80
	public int startY; // 0x84
	public int endX; // 0x88
	public RectInt areaClamp; // 0x8C
	public bool isPaintBrush; // 0x9C

	// Methods

	// RVA: 0xFA630 Offset: 0xF9A30 VA: 0x1800FA630 Slot: 4
	public void Execute(int index) { }

	// RVA: 0xFA670 Offset: 0xF9A70 VA: 0x1800FA670
	private float2 SampleUv(float x, float y) { }

	// RVA: 0xFA640 Offset: 0xF9A40 VA: 0x1800FA640
	private Color SampleTexture(float x, float y) { }

	// RVA: 0x953360 Offset: 0x952760 VA: 0x180953360
	private static Color ToColor(float4 color) { }

	// RVA: 0x9533A0 Offset: 0x9527A0 VA: 0x1809533A0
	private static float4 ToFloat4(Color color) { }

}

