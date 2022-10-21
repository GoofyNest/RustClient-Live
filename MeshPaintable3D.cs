public class MeshPaintable3D : BaseMeshPaintable // TypeDefIndex: 10922
{
	[ClientVar] 
	public static float brushScale; 
	[ClientVar] 
	public static float uvBufferScale; 
	public string replacementTextureName; 
	public int textureWidth; 
	public int textureHeight; 
	public Camera cameraPreview; 
	public Camera camera3D; 
	private CommandBuffer _commandBuffer; 
	private Material _uvMaterial; 
	private RenderTexture _uvBuffer; 
	private float _uvFactor; 
	private Texture2D _uvTexture; 
	private Texture2D _paintTexture; 
	private int _lastDrawTime; 
	private RectInt _areaClamp; 
	[CompilerGeneratedAttribute] 
	private bool <HasChanges>k__BackingField; 

	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }


	public void OnDestroy() { }

	public override Texture2D get_TargetTexture() { }

	public override void set_TargetTexture(Texture2D value) { }

	[CompilerGeneratedAttribute] 
	public override bool get_HasChanges() { }

	[CompilerGeneratedAttribute] 
	public override void set_HasChanges(bool value) { }

	public override void Init(MeshPaintableSource source, bool isSelected) { }

	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	public override void Clear() { }

	public override void Apply() { }

	public override bool ShouldHit(RaycastHit info) { }

	private void PrepareForDrawing() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct MeshPaintable3D.DrawTextureJob : IJobParallelFor // TypeDefIndex: 10923
{
	public int textureWidth; 
	public int2 textureMaxPos; 
	[ReadOnlyAttribute] 
	[NativeDisableParallelForRestrictionAttribute] 
	public NativeArray<Color32> textureData; 
	public Color textureColor; 
	public float textureScaleX; 
	public float textureScaleY; 
	public int uvWidth; 
	public int2 uvMaxPos; 
	[ReadOnlyAttribute] 
	[NativeDisableParallelForRestrictionAttribute] 
	public NativeArray<half2> uvData; 
	public int paintWidth; 
	public int paintHeight; 
	[ReadOnlyAttribute] 
	[NativeDisableParallelForRestrictionAttribute] 
	[DeallocateOnJobCompletionAttribute] 
	public NativeArray<Color32> paintDataCurrent; 
	[WriteOnlyAttribute] 
	[NativeDisableParallelForRestrictionAttribute] 
	public NativeArray<Color32> paintDataNew; 
	public int startX; 
	public int startY; 
	public int endX; 
	public RectInt areaClamp; 
	public bool isPaintBrush; 


	public void Execute(int index) { }

	private float2 SampleUv(float x, float y) { }

	private Color SampleTexture(float x, float y) { }

	private static Color ToColor(float4 color) { }

	private static float4 ToFloat4(Color color) { }

}

