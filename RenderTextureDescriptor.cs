public struct RenderTextureDescriptor // TypeDefIndex: 3452
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <width>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <height>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <msaaSamples>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <volumeDepth>k__BackingField; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private int <mipCount>k__BackingField; 
	private GraphicsFormat _graphicsFormat; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private GraphicsFormat <stencilFormat>k__BackingField; 
	private int _depthBufferBits; 
	private static int[] depthFormatBits; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private TextureDimension <dimension>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VRTextureUsage <vrUsage>k__BackingField; 
	private RenderTextureCreationFlags _flags; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private RenderTextureMemoryless <memoryless>k__BackingField; 

	public int width { get; set; }
	public int height { get; set; }
	public int msaaSamples { get; set; }
	public int volumeDepth { get; set; }
	public int mipCount { set; }
	public GraphicsFormat graphicsFormat { get; set; }
	public RenderTextureFormat colorFormat { get; set; }
	public bool sRGB { get; set; }
	public int depthBufferBits { get; set; }
	public TextureDimension dimension { get; set; }
	public ShadowSamplingMode shadowSamplingMode { get; set; }
	public VRTextureUsage vrUsage { get; set; }
	public RenderTextureMemoryless memoryless { get; set; }
	public bool useMipMap { get; set; }
	public bool autoGenerateMips { get; set; }
	public bool enableRandomWrite { get; set; }
	internal bool createdFromScript { set; }
	public bool useDynamicScale { set; }


	[CompilerGeneratedAttribute] 
	public int get_width() { }

	[CompilerGeneratedAttribute] 
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_height() { }

	[CompilerGeneratedAttribute] 
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] 
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] 
	public void set_volumeDepth(int value) { }

	[CompilerGeneratedAttribute] 
	public void set_mipCount(int value) { }

	public GraphicsFormat get_graphicsFormat() { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public RenderTextureFormat get_colorFormat() { }

	public void set_colorFormat(RenderTextureFormat value) { }

	public bool get_sRGB() { }

	public void set_sRGB(bool value) { }

	public int get_depthBufferBits() { }

	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] 
	public TextureDimension get_dimension() { }

	[CompilerGeneratedAttribute] 
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] 
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGeneratedAttribute] 
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGeneratedAttribute] 
	public VRTextureUsage get_vrUsage() { }

	[CompilerGeneratedAttribute] 
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] 
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGeneratedAttribute] 
	public void set_memoryless(RenderTextureMemoryless value) { }

	public void .ctor(int width, int height) { }

	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	public bool get_useMipMap() { }

	public void set_useMipMap(bool value) { }

	public bool get_autoGenerateMips() { }

	public void set_autoGenerateMips(bool value) { }

	public bool get_enableRandomWrite() { }

	public void set_enableRandomWrite(bool value) { }

	internal void set_createdFromScript(bool value) { }

	public void set_useDynamicScale(bool value) { }

	private static void .cctor() { }

}

