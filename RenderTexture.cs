public class RenderTexture : Texture // TypeDefIndex: 3450
{
public override int width { get; set; }
public override int height { get; set; }
public override TextureDimension dimension { get; set; }
	[NativePropertyAttribute] 
public GraphicsFormat graphicsFormat { get; set; }
	[NativePropertyAttribute] 
public bool useMipMap { set; }
	[NativePropertyAttribute] 
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

	[FreeFunctionAttribute] 
private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] 
private static void SetActive(RenderTexture rt) { }

public static RenderTexture get_active() { }

public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] 
private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] 
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

	[FreeFunctionAttribute] 
private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] 
private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] 
private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] 
private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] 
public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] 
public int get_depth() { }

	[FreeFunctionAttribute] 
public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] 
protected internal void .ctor() { }

public void .ctor(RenderTextureDescriptor desc) { }

public void .ctor(RenderTexture textureToCopy) { }

public void .ctor(int width, int height, int depth, DefaultFormat format) { }

public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] 
public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] 
public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] 
public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

public RenderTextureDescriptor get_descriptor() { }

public void set_descriptor(RenderTextureDescriptor value) { }

private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] 
public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] 
public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] 
public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] 
public static RenderTexture GetTemporary(int width, int height) { }

private void GetColorBuffer_Injected(out RenderBuffer ret) { }

private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

