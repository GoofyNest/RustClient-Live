public class RenderTexture : Texture // TypeDefIndex: 3450
{	public override int width { get; set; }
	public override int height { get; set; }
	public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] // RVA: 0xA44A0 Offset: 0xA38A0 VA: 0x1800A44A0
	public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] // RVA: 0xA4640 Offset: 0xA3A40 VA: 0x1800A4640
	public bool useMipMap { set; }
	[NativePropertyAttribute] // RVA: 0xA4730 Offset: 0xA3B30 VA: 0x1800A4730
	public bool sRGB { get; }
	public RenderTextureFormat format { get; }
	public bool autoGenerateMips { set; }
	public int volumeDepth { get; set; }
	public bool enableRandomWrite { get; set; }
	public bool isPowerOfTwo { set; }
	public static RenderTexture active { get; set; }
	public RenderBuffer colorBuffer { get; }
	public RenderBuffer depthBuffer { get; }
	public int depth { get; set; }
	public RenderTextureDescriptor descriptor { get; set; }


	public override int get_width() { }

	public override void set_width(int value) { }

	public override int get_height() { }

	public override void set_height(int value) { }

	public override TextureDimension get_dimension() { }

	public override void set_dimension(TextureDimension value) { }

	public GraphicsFormat get_graphicsFormat() { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public void set_useMipMap(bool value) { }

	public bool get_sRGB() { }

	public RenderTextureFormat get_format() { }

	public void set_autoGenerateMips(bool value) { }

	public int get_volumeDepth() { }

	public void set_volumeDepth(int value) { }

	public bool get_enableRandomWrite() { }

	public void set_enableRandomWrite(bool value) { }

	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA31E0 Offset: 0xA25E0 VA: 0x1800A31E0
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA3260 Offset: 0xA2660 VA: 0x1800A3260
	private static void SetActive(RenderTexture rt) { }

	public static RenderTexture get_active() { }

	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3320 Offset: 0xA2720 VA: 0x1800A3320
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA33C0 Offset: 0xA27C0 VA: 0x1800A33C0
	private RenderBuffer GetDepthBuffer() { }

	public RenderBuffer get_colorBuffer() { }

	public RenderBuffer get_depthBuffer() { }

	public void DiscardContents(bool discardColor, bool discardDepth) { }

	public void MarkRestoreExpected() { }

	public void DiscardContents() { }

	public bool Create() { }

	public void Release() { }

	public bool IsCreated() { }

	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA3460 Offset: 0xA2860 VA: 0x1800A3460
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA3540 Offset: 0xA2940 VA: 0x1800A3540
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA35F0 Offset: 0xA29F0 VA: 0x1800A35F0
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA36D0 Offset: 0xA2AD0 VA: 0x1800A36D0
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA3760 Offset: 0xA2B60 VA: 0x1800A3760
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA3880 Offset: 0xA2C80 VA: 0x1800A3880
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3980 Offset: 0xA2D80 VA: 0x1800A3980
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	protected internal void .ctor() { }

	public void .ctor(RenderTextureDescriptor desc) { }

	public void .ctor(RenderTexture textureToCopy) { }

	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public RenderTextureDescriptor get_descriptor() { }

	public void set_descriptor(RenderTextureDescriptor value) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static RenderTexture GetTemporary(int width, int height) { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

