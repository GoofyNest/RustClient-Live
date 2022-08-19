public class RenderTexture : Texture // TypeDefIndex: 3450
{	// Properties
	public override int width { get; set; }
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

	// Methods

	// RVA: 0x19AD870 Offset: 0x19ACC70 VA: 0x1819AD870 Slot: 5
	public override int get_width() { }

	// RVA: 0x19ADB80 Offset: 0x19ACF80 VA: 0x1819ADB80 Slot: 6
	public override void set_width(int value) { }

	// RVA: 0x19AD7B0 Offset: 0x19ACBB0 VA: 0x1819AD7B0 Slot: 7
	public override int get_height() { }

	// RVA: 0x19ADAB0 Offset: 0x19ACEB0 VA: 0x1819ADAB0 Slot: 8
	public override void set_height(int value) { }

	// RVA: 0x19AD6B0 Offset: 0x19ACAB0 VA: 0x1819AD6B0 Slot: 9
	public override TextureDimension get_dimension() { }

	// RVA: 0x19AD9E0 Offset: 0x19ACDE0 VA: 0x1819AD9E0 Slot: 10
	public override void set_dimension(TextureDimension value) { }

	// RVA: 0x19AD770 Offset: 0x19ACB70 VA: 0x1819AD770
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x19ADA70 Offset: 0x19ACE70 VA: 0x1819ADA70
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x19ADAF0 Offset: 0x19ACEF0 VA: 0x1819ADAF0
	public void set_useMipMap(bool value) { }

	// RVA: 0x19AD7F0 Offset: 0x19ACBF0 VA: 0x1819AD7F0
	public bool get_sRGB() { }

	// RVA: 0x19AD730 Offset: 0x19ACB30 VA: 0x1819AD730
	public RenderTextureFormat get_format() { }

	// RVA: 0x19AD8B0 Offset: 0x19ACCB0 VA: 0x1819AD8B0
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x19AD830 Offset: 0x19ACC30 VA: 0x1819AD830
	public int get_volumeDepth() { }

	// RVA: 0x19ADB40 Offset: 0x19ACF40 VA: 0x1819ADB40
	public void set_volumeDepth(int value) { }

	// RVA: 0x19AD6F0 Offset: 0x19ACAF0 VA: 0x1819AD6F0
	public bool get_enableRandomWrite() { }

	// RVA: 0x19ADA20 Offset: 0x19ACE20 VA: 0x1819ADA20
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void set_isPowerOfTwo(bool value) { }

	[FreeFunctionAttribute] // RVA: 0xA31E0 Offset: 0xA25E0 VA: 0x1800A31E0
	// RVA: 0x19ABE20 Offset: 0x19AB220 VA: 0x1819ABE20
	private static RenderTexture GetActive() { }

	[FreeFunctionAttribute] // RVA: 0xA3260 Offset: 0xA2660 VA: 0x1800A3260
	// RVA: 0x19AC700 Offset: 0x19ABB00 VA: 0x1819AC700
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x19ABE20 Offset: 0x19AB220 VA: 0x1819ABE20
	public static RenderTexture get_active() { }

	// RVA: 0x19AC700 Offset: 0x19ABB00 VA: 0x1819AC700
	public static void set_active(RenderTexture value) { }

	[FreeFunctionAttribute] // RVA: 0xA3320 Offset: 0xA2720 VA: 0x1800A3320
	// RVA: 0x19ABEA0 Offset: 0x19AB2A0 VA: 0x1819ABEA0
	private RenderBuffer GetColorBuffer() { }

	[FreeFunctionAttribute] // RVA: 0xA33C0 Offset: 0xA27C0 VA: 0x1800A33C0
	// RVA: 0x19AC0A0 Offset: 0x19AB4A0 VA: 0x1819AC0A0
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x19AD520 Offset: 0x19AC920 VA: 0x1819AD520
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x19AD580 Offset: 0x19AC980 VA: 0x1819AD580
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x19ABDC0 Offset: 0x19AB1C0 VA: 0x1819ABDC0
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x19AC640 Offset: 0x19ABA40 VA: 0x1819AC640
	public void MarkRestoreExpected() { }

	// RVA: 0x19ABD80 Offset: 0x19AB180 VA: 0x1819ABD80
	public void DiscardContents() { }

	// RVA: 0x19ABD40 Offset: 0x19AB140 VA: 0x1819ABD40
	public bool Create() { }

	// RVA: 0x19AC6C0 Offset: 0x19ABAC0 VA: 0x1819AC6C0
	public void Release() { }

	// RVA: 0x19AC600 Offset: 0x19ABA00 VA: 0x1819AC600
	public bool IsCreated() { }

	// RVA: 0x19AC7E0 Offset: 0x19ABBE0 VA: 0x1819AC7E0
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunctionAttribute] // RVA: 0xA3460 Offset: 0xA2860 VA: 0x1800A3460
	// RVA: 0x19AC5C0 Offset: 0x19AB9C0 VA: 0x1819AC5C0
	private static void Internal_Create(RenderTexture rt) { }

	[NativeNameAttribute] // RVA: 0xA3540 Offset: 0xA2940 VA: 0x1800A3540
	// RVA: 0x19AC790 Offset: 0x19ABB90 VA: 0x1819AC790
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeNameAttribute] // RVA: 0xA35F0 Offset: 0xA29F0 VA: 0x1800A35F0
	// RVA: 0x19AC140 Offset: 0x19AB540 VA: 0x1819AC140
	private RenderTextureDescriptor GetDescriptor() { }

	[FreeFunctionAttribute] // RVA: 0xA36D0 Offset: 0xA2AD0 VA: 0x1800A36D0
	// RVA: 0x19AC370 Offset: 0x19AB770 VA: 0x1819AC370
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	[FreeFunctionAttribute] // RVA: 0xA3760 Offset: 0xA2B60 VA: 0x1800A3760
	// RVA: 0x19AC680 Offset: 0x19ABA80 VA: 0x1819AC680
	public static void ReleaseTemporary(RenderTexture temp) { }

	[FreeFunctionAttribute] // RVA: 0xA3880 Offset: 0xA2C80 VA: 0x1800A3880
	// RVA: 0x19AD5E0 Offset: 0x19AC9E0 VA: 0x1819AD5E0
	public int get_depth() { }

	[FreeFunctionAttribute] // RVA: 0xA3980 Offset: 0xA2D80 VA: 0x1800A3980
	// RVA: 0x19AD900 Offset: 0x19ACD00 VA: 0x1819AD900
	public void set_depth(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AD490 Offset: 0x19AC890 VA: 0x1819AD490
	protected internal void .ctor() { }

	// RVA: 0x19AD350 Offset: 0x19AC750 VA: 0x1819AD350
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x19ACE00 Offset: 0x19AC200 VA: 0x1819ACE00
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x19AD260 Offset: 0x19AC660 VA: 0x1819AD260
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x19AD030 Offset: 0x19AC430 VA: 0x1819AD030
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x19ACAE0 Offset: 0x19ABEE0 VA: 0x1819ACAE0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x19ACDA0 Offset: 0x19AC1A0 VA: 0x1819ACDA0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19ACA80 Offset: 0x19ABE80 VA: 0x1819ACA80
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AD200 Offset: 0x19AC600 VA: 0x1819AD200
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AD2E0 Offset: 0x19AC6E0 VA: 0x1819AD2E0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x19AD620 Offset: 0x19ACA20 VA: 0x1819AD620
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x19AD940 Offset: 0x19ACD40 VA: 0x1819AD940
	public void set_descriptor(RenderTextureDescriptor value) { }

	// RVA: 0x19AC830 Offset: 0x19ABC30 VA: 0x1819AC830
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x19ABEF0 Offset: 0x19AB2F0 VA: 0x1819ABEF0
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x19AC530 Offset: 0x19AB930 VA: 0x1819AC530
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x19AC1A0 Offset: 0x19AB5A0 VA: 0x1819AC1A0
	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = False) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AC460 Offset: 0x19AB860 VA: 0x1819AC460
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AC4D0 Offset: 0x19AB8D0 VA: 0x1819AC4D0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AC400 Offset: 0x19AB800 VA: 0x1819AC400
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19AC3B0 Offset: 0x19AB7B0 VA: 0x1819AC3B0
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x19ABE50 Offset: 0x19AB250 VA: 0x1819ABE50
	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19AC050 Offset: 0x19AB450 VA: 0x1819AC050
	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x19AC740 Offset: 0x19ABB40 VA: 0x1819AC740
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x19AC0F0 Offset: 0x19AB4F0 VA: 0x1819AC0F0
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x19AC330 Offset: 0x19AB730 VA: 0x1819AC330
	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

}

