public sealed class Canvas : Behaviour // TypeDefIndex: 4736
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x12837

	// Properties
	public RenderMode renderMode { get; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	[NativePropertyAttribute] // RVA: 0xA5B10 Offset: 0xA4F10 VA: 0x1800A5B10
	public Camera worldCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x23037C0 Offset: 0x2302BC0 VA: 0x1823037C0
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2303C50 Offset: 0x2303050 VA: 0x182303C50
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x2303A50 Offset: 0x2302E50 VA: 0x182303A50
	public RenderMode get_renderMode() { }

	// RVA: 0x23038B0 Offset: 0x2302CB0 VA: 0x1823038B0
	public bool get_isRootCanvas() { }

	// RVA: 0x23039C0 Offset: 0x2302DC0 VA: 0x1823039C0
	public Rect get_pixelRect() { }

	// RVA: 0x2303B10 Offset: 0x2302F10 VA: 0x182303B10
	public float get_scaleFactor() { }

	// RVA: 0x2303DE0 Offset: 0x23031E0 VA: 0x182303DE0
	public void set_scaleFactor(float value) { }

	// RVA: 0x2303A10 Offset: 0x2302E10 VA: 0x182303A10
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x2303D90 Offset: 0x2303190 VA: 0x182303D90
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x2303930 Offset: 0x2302D30 VA: 0x182303930
	public bool get_pixelPerfect() { }

	// RVA: 0x2303A90 Offset: 0x2302E90 VA: 0x182303A90
	public int get_renderOrder() { }

	// RVA: 0x23038F0 Offset: 0x2302CF0 VA: 0x1823038F0
	public bool get_overrideSorting() { }

	// RVA: 0x2303D40 Offset: 0x2303140 VA: 0x182303D40
	public void set_overrideSorting(bool value) { }

	// RVA: 0x2303B90 Offset: 0x2302F90 VA: 0x182303B90
	public int get_sortingOrder() { }

	// RVA: 0x2303E70 Offset: 0x2303270 VA: 0x182303E70
	public void set_sortingOrder(int value) { }

	// RVA: 0x2303BD0 Offset: 0x2302FD0 VA: 0x182303BD0
	public int get_targetDisplay() { }

	// RVA: 0x2303B50 Offset: 0x2302F50 VA: 0x182303B50
	public int get_sortingLayerID() { }

	// RVA: 0x2303E30 Offset: 0x2303230 VA: 0x182303E30
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2303870 Offset: 0x2302C70 VA: 0x182303870
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x2303D00 Offset: 0x2303100 VA: 0x182303D00
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x2303AD0 Offset: 0x2302ED0 VA: 0x182303AD0
	public Canvas get_rootCanvas() { }

	// RVA: 0x2303C10 Offset: 0x2303010 VA: 0x182303C10
	public Camera get_worldCamera() { }

	// RVA: 0x2303EB0 Offset: 0x23032B0 VA: 0x182303EB0
	public void set_worldCamera(Camera value) { }

	[FreeFunctionAttribute] // RVA: 0xA5860 Offset: 0xA4C60 VA: 0x1800A5860
	// RVA: 0x2303760 Offset: 0x2302B60 VA: 0x182303760
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xA5970 Offset: 0xA4D70 VA: 0x1800A5970
	// RVA: 0x2303790 Offset: 0x2302B90 VA: 0x182303790
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x2303710 Offset: 0x2302B10 VA: 0x182303710
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2303710 Offset: 0x2302B10 VA: 0x182303710
	private static void SendWillRenderCanvases() { }

	// RVA: 0x18F27E0 Offset: 0x18F1BE0 VA: 0x1818F27E0
	public void .ctor() { }

	// RVA: 0x2303970 Offset: 0x2302D70 VA: 0x182303970
	private void get_pixelRect_Injected(out Rect ret) { }

}

public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 4737
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A76FB0 Offset: 0x1A763B0 VA: 0x181A76FB0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

