public struct RenderTextureDescriptor // TypeDefIndex: 3451
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <width>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <msaaSamples>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private int <volumeDepth>k__BackingField; // 0xC
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	private int _depthBufferBits; // 0x1C
	private static int[] depthFormatBits; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public int get_width() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3A80 Offset: 0xF2E80 VA: 0x1800F3A80
	public void set_width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x14B670 Offset: 0x14AA70 VA: 0x18014B670
	public int get_height() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DDF0 Offset: 0x19D1F0 VA: 0x18019DDF0
	public void set_height(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_msaaSamples() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DDE0 Offset: 0x19D1E0 VA: 0x18019DDE0
	public void set_msaaSamples(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1AE2C0 Offset: 0x1AD6C0 VA: 0x1801AE2C0
	public int get_volumeDepth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x222700 Offset: 0x221B00 VA: 0x180222700
	public void set_volumeDepth(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1202F0 Offset: 0x11F6F0 VA: 0x1801202F0
	public void set_mipCount(int value) { }

	// RVA: 0x212190 Offset: 0x211590 VA: 0x180212190
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x222610 Offset: 0x221A10 VA: 0x180222610
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x2224B0 Offset: 0x2218B0 VA: 0x1802224B0
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x222520 Offset: 0x221920 VA: 0x180222520
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x2224E0 Offset: 0x2218E0 VA: 0x1802224E0
	public bool get_sRGB() { }

	// RVA: 0x222650 Offset: 0x221A50 VA: 0x180222650
	public void set_sRGB(bool value) { }

	// RVA: 0x2224C0 Offset: 0x2218C0 VA: 0x1802224C0
	public int get_depthBufferBits() { }

	// RVA: 0x2225D0 Offset: 0x2219D0 VA: 0x1802225D0
	public void set_depthBufferBits(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12C050 Offset: 0x12B450 VA: 0x18012C050
	public TextureDimension get_dimension() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1EEF50 Offset: 0x1EE350 VA: 0x1801EEF50
	public void set_dimension(TextureDimension value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1E4AB0 Offset: 0x1E3EB0 VA: 0x1801E4AB0
	public ShadowSamplingMode get_shadowSamplingMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2226B0 Offset: 0x221AB0 VA: 0x1802226B0
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DC0 Offset: 0xF31C0 VA: 0x1800F3DC0
	public VRTextureUsage get_vrUsage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF3DF0 Offset: 0xF31F0 VA: 0x1800F3DF0
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D0ED0 Offset: 0x1D02D0 VA: 0x1801D0ED0
	public RenderTextureMemoryless get_memoryless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1D8530 Offset: 0x1D7930 VA: 0x1801D8530
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x222370 Offset: 0x221770 VA: 0x180222370
	public void .ctor(int width, int height) { }

	// RVA: 0x2222E0 Offset: 0x2216E0 VA: 0x1802222E0
	public void .ctor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x222490 Offset: 0x221890 VA: 0x180222490
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	// RVA: 0x2222D0 Offset: 0x2216D0 VA: 0x1802222D0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	// RVA: 0x2222B0 Offset: 0x2216B0 VA: 0x1802222B0
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x2224F0 Offset: 0x2218F0 VA: 0x1802224F0
	public bool get_useMipMap() { }

	// RVA: 0x2226E0 Offset: 0x221AE0 VA: 0x1802226E0
	public void set_useMipMap(bool value) { }

	// RVA: 0x2224A0 Offset: 0x2218A0 VA: 0x1802224A0
	public bool get_autoGenerateMips() { }

	// RVA: 0x222500 Offset: 0x221900 VA: 0x180222500
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x2224D0 Offset: 0x2218D0 VA: 0x1802224D0
	public bool get_enableRandomWrite() { }

	// RVA: 0x2225F0 Offset: 0x2219F0 VA: 0x1802225F0
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x2225B0 Offset: 0x2219B0 VA: 0x1802225B0
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x2226C0 Offset: 0x221AC0 VA: 0x1802226C0
	public void set_useDynamicScale(bool value) { }

	// RVA: 0x19AB770 Offset: 0x19AAB70 VA: 0x1819AB770
	private static void .cctor() { }

}

