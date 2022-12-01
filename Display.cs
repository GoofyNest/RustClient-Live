public class Display // TypeDefIndex: 3384
{
	internal IntPtr nativeDisplay;
	public static Display[] displays;
	private static Display _mainDisplay;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated;

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

	[RequiredByNativeCodeAttribute]
	private static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCodeAttribute]
	private static void FireDisplaysUpdated() { }

	[FreeFunctionAttribute]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunctionAttribute]
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[FreeFunctionAttribute]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	private static void .cctor() { }

}

public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 3385
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

