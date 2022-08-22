public class Display // TypeDefIndex: 3383
{	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }


	internal void .ctor() { }

	internal void .ctor(IntPtr nativeDisplay) { }

	public int get_renderingWidth() { }

	public int get_renderingHeight() { }

	public int get_systemWidth() { }

	public int get_systemHeight() { }

	public RenderBuffer get_colorBuffer() { }

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x830F0 Offset: 0x824F0 VA: 0x1800830F0
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83230 Offset: 0x82630 VA: 0x180083230
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83390 Offset: 0x82790 VA: 0x180083390
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x83400 Offset: 0x82800 VA: 0x180083400
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	private static void .cctor() { }

}

public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 3384
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

