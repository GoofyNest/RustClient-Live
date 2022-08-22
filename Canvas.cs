public sealed class Canvas : Behaviour // TypeDefIndex: 4736
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x12837

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	public RenderMode get_renderMode() { }

	public bool get_isRootCanvas() { }

	public Rect get_pixelRect() { }

	public float get_scaleFactor() { }

	public void set_scaleFactor(float value) { }

	public float get_referencePixelsPerUnit() { }

	public void set_referencePixelsPerUnit(float value) { }

	public bool get_pixelPerfect() { }

	public int get_renderOrder() { }

	public bool get_overrideSorting() { }

	public void set_overrideSorting(bool value) { }

	public int get_sortingOrder() { }

	public void set_sortingOrder(int value) { }

	public int get_targetDisplay() { }

	public int get_sortingLayerID() { }

	public void set_sortingLayerID(int value) { }

	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	public Canvas get_rootCanvas() { }

	public Camera get_worldCamera() { }

	public void set_worldCamera(Camera value) { }

	[FreeFunctionAttribute] // RVA: 0xA5860 Offset: 0xA4C60 VA: 0x1800A5860
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xA5970 Offset: 0xA4D70 VA: 0x1800A5970
	public static Material GetETC1SupportedCanvasMaterial() { }

	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void SendWillRenderCanvases() { }

	public void .ctor() { }

	private void get_pixelRect_Injected(out Rect ret) { }

}

public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 4737
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

