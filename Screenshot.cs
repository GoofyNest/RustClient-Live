public struct Screenshot // TypeDefIndex: 5557
{
	internal ScreenshotHandle Value; 

}

public class Screenshot : SingletonComponent<Screenshot> // TypeDefIndex: 13028
{
	public string screenshotPath; 
	public int sizeMultiplier; 
	public static bool TakingScreenshot; 
	private bool takingScreenshot; 
	private string savePathName; 


	[ClientVar] 
	public static void takescreenshot(ConsoleSystem.Arg arg) { }

	[ClientVar] 
	public static void takehiresscreenshot(ConsoleSystem.Arg arg) { }

	private void TakeScreenshotNormal() { }

	private void TakeHighResScreenshot() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator SaveScreenshot(string ext, int resolutionX, int resolutionY, bool withHud, bool withoutHud) { }

	private void GetScreenCallback(Texture2D texture) { }

	[IteratorStateMachineAttribute] 
	public static IEnumerator GetScreen(Camera camera, int resolutionX, int resolutionY, Action<Texture2D> finishedCallback, Action renderCallback, bool updateCamera = False) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class Screenshot.<SaveScreenshot>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13029
{
	private int <>1__state; 
	private object <>2__current; 
	public int resolutionX; 
	public int resolutionY; 
	public Screenshot <>4__this; 
	public bool withHud; 
	public string ext; 
	public bool withoutHud; 
	private string <path>5__2; 
	private bool <oldNametags>5__3; 
	private int <i>5__4; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Screenshot.<GetScreen>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13030
{
	private int <>1__state; 
	private object <>2__current; 
	public Camera camera; 
	public int resolutionX; 
	public int resolutionY; 
	public bool updateCamera; 
	public Action renderCallback; 
	public Action<Texture2D> finishedCallback; 
	private PostProcessLayer <post>5__2; 
	private RenderTexture <rt>5__3; 
	private float <screenSizeMultiple>5__4; 
	private float <originalDofBlur>5__5; 
	private int <originalAA>5__6; 
	private RenderTexture <originalRT>5__7; 
	private int <originalMask>5__8; 
	private bool <originalBranding>5__9; 
	private bool <nvgEnabled>5__10; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

