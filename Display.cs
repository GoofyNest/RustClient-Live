public class Display // TypeDefIndex: 3383
{	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x10

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public RenderBuffer colorBuffer { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x1824C50 Offset: 0x1824050 VA: 0x181824C50
	internal void .ctor() { }

	// RVA: 0x1824C90 Offset: 0x1824090 VA: 0x181824C90
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x1824E60 Offset: 0x1824260 VA: 0x181824E60
	public int get_renderingWidth() { }

	// RVA: 0x1824DD0 Offset: 0x18241D0 VA: 0x181824DD0
	public int get_renderingHeight() { }

	// RVA: 0x1824F80 Offset: 0x1824380 VA: 0x181824F80
	public int get_systemWidth() { }

	// RVA: 0x1824EF0 Offset: 0x18242F0 VA: 0x181824EF0
	public int get_systemHeight() { }

	// RVA: 0x1824CC0 Offset: 0x18240C0 VA: 0x181824CC0
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x1824A10 Offset: 0x1823E10 VA: 0x181824A10
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x1824D70 Offset: 0x1824170 VA: 0x181824D70
	public static Display get_main() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18247D0 Offset: 0x1823BD0 VA: 0x1818247D0
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1824480 Offset: 0x1823880 VA: 0x181824480
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute] // RVA: 0x830F0 Offset: 0x824F0 VA: 0x1800830F0
	// RVA: 0x1824770 Offset: 0x1823B70 VA: 0x181824770
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83230 Offset: 0x82630 VA: 0x180083230
	// RVA: 0x1824710 Offset: 0x1823B10 VA: 0x181824710
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute] // RVA: 0x83390 Offset: 0x82790 VA: 0x180083390
	// RVA: 0x18246B0 Offset: 0x1823AB0 VA: 0x1818246B0
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute] // RVA: 0x83400 Offset: 0x82800 VA: 0x180083400
	// RVA: 0x18249B0 Offset: 0x1823DB0 VA: 0x1818249B0
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x1824AF0 Offset: 0x1823EF0 VA: 0x181824AF0
	private static void .cctor() { }

}

public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 3384
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497060 Offset: 0x496460 VA: 0x180497060 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x497020 Offset: 0x496420 VA: 0x180497020 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

