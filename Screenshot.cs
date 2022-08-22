public struct Screenshot // TypeDefIndex: 5556
{	internal ScreenshotHandle Value; // 0x0

}

public class Screenshot : SingletonComponent<Screenshot> // TypeDefIndex: 11332
{	public string screenshotPath; // 0x18
	public int sizeMultiplier; // 0x20
	public static bool TakingScreenshot; // 0x0
	private bool takingScreenshot; // 0x24
	private string savePathName; // 0x28


	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void takescreenshot(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void takehiresscreenshot(ConsoleSystem.Arg arg) { }

	private void TakeScreenshotNormal() { }

	private void TakeHighResScreenshot() { }

	[IteratorStateMachineAttribute] // RVA: 0xA4CA0 Offset: 0xA40A0 VA: 0x1800A4CA0
	private IEnumerator SaveScreenshot(string ext, int resolutionX, int resolutionY, bool withHud, bool withoutHud) { }

	private void GetScreenCallback(Texture2D texture) { }

	[IteratorStateMachineAttribute] // RVA: 0xA4E70 Offset: 0xA4270 VA: 0x1800A4E70
	public static IEnumerator GetScreen(Camera camera, int resolutionX, int resolutionY, Action<Texture2D> finishedCallback, Action renderCallback, bool updateCamera = False) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Screenshot.<SaveScreenshot>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11333
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int resolutionX; // 0x20
	public int resolutionY; // 0x24
	public Screenshot <>4__this; // 0x28
	public bool withHud; // 0x30
	public string ext; // 0x38
	public bool withoutHud; // 0x40
	private string <path>5__2; // 0x48
	private bool <oldNametags>5__3; // 0x50
	private int <i>5__4; // 0x54

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Screenshot.<GetScreen>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11334
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Camera camera; // 0x20
	public int resolutionX; // 0x28
	public int resolutionY; // 0x2C
	public bool updateCamera; // 0x30
	public Action renderCallback; // 0x38
	public Action<Texture2D> finishedCallback; // 0x40
	private PostProcessLayer <post>5__2; // 0x48
	private RenderTexture <rt>5__3; // 0x50
	private float <screenSizeMultiple>5__4; // 0x58
	private float <originalDofBlur>5__5; // 0x5C
	private int <originalAA>5__6; // 0x60
	private RenderTexture <originalRT>5__7; // 0x68
	private int <originalMask>5__8; // 0x70
	private bool <originalBranding>5__9; // 0x74
	private bool <nvgEnabled>5__10; // 0x75

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

