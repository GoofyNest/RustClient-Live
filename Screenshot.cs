public struct Screenshot // TypeDefIndex: 5556
{	// Fields
	internal ScreenshotHandle Value; // 0x0

}

public class Screenshot : SingletonComponent<Screenshot> // TypeDefIndex: 11332
{	// Fields
	public string screenshotPath; // 0x18
	public int sizeMultiplier; // 0x20
	public static bool TakingScreenshot; // 0x0
	private bool takingScreenshot; // 0x24
	private string savePathName; // 0x28

	// Methods

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x4A23F0 Offset: 0x4A17F0 VA: 0x1804A23F0
	public static void takescreenshot(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x4A2300 Offset: 0x4A1700 VA: 0x1804A2300
	public static void takehiresscreenshot(ConsoleSystem.Arg arg) { }

	// RVA: 0x4A2220 Offset: 0x4A1620 VA: 0x1804A2220
	private void TakeScreenshotNormal() { }

	// RVA: 0x4A2190 Offset: 0x4A1590 VA: 0x1804A2190
	private void TakeHighResScreenshot() { }

	[IteratorStateMachineAttribute] // RVA: 0xA4CA0 Offset: 0xA40A0 VA: 0x1800A4CA0
	// RVA: 0x4A20D0 Offset: 0x4A14D0 VA: 0x1804A20D0
	private IEnumerator SaveScreenshot(string ext, int resolutionX, int resolutionY, bool withHud, bool withoutHud) { }

	// RVA: 0x4A1F00 Offset: 0x4A1300 VA: 0x1804A1F00
	private void GetScreenCallback(Texture2D texture) { }

	[IteratorStateMachineAttribute] // RVA: 0xA4E70 Offset: 0xA4270 VA: 0x1800A4E70
	// RVA: 0x4A2010 Offset: 0x4A1410 VA: 0x1804A2010
	public static IEnumerator GetScreen(Camera camera, int resolutionX, int resolutionY, Action<Texture2D> finishedCallback, Action renderCallback, bool updateCamera = False) { }

	// RVA: 0x4A22A0 Offset: 0x4A16A0 VA: 0x1804A22A0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private sealed class Screenshot.<SaveScreenshot>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11333
{	// Fields
	private int <>1__state; // 0x10
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

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4AFD80 Offset: 0x4AF180 VA: 0x1804AFD80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B05A0 Offset: 0x4AF9A0 VA: 0x1804B05A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Screenshot.<GetScreen>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11334
{	// Fields
	private int <>1__state; // 0x10
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

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x4AE130 Offset: 0x4AD530 VA: 0x1804AE130 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4AEBC0 Offset: 0x4ADFC0 VA: 0x1804AEBC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

