public class HttpImage : MonoBehaviour // TypeDefIndex: 7088
{
	public static Dictionary<string, UnityWebRequest> RequestCache;
	public static Dictionary<string, ValueTuple<Texture2D, Sprite>> TextureCache;
	public Texture2D LoadingImage;
	public Texture2D MissingImage;
	private RawImage rawImage;
	private Image image;
	private Sprite loadingSprite;
	private Sprite missingSprite;
	public string Url;
	public bool AutosizeHeight;
	public bool GenerateMipmaps;
	public float MaxWidth;
	public float MaxHeight;


	private void Init() { }

	private void Start() { }

	private void OnDestroy() { }

	public bool Load(string url) { }

	[IteratorStateMachineAttribute]
	private IEnumerator WaitForLoad(string url) { }

	private void UpdateImageTexture(ValueTuple<Texture2D, Sprite> tex) { }

	public void SetMissingImage() { }

	public void SetLoadingImage() { }

	[IteratorStateMachineAttribute]
	private IEnumerator StartAndWaitForLoad(string url) { }

	private void AutosizeForTexture(Texture2D texture) { }

	private void SetImageEnabled(bool enabled) { }

	private static Sprite CreateSprite(Texture2D texture) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class HttpImage.<WaitForLoad>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7089
{
	private int <>1__state;
	private object <>2__current;
	public string url;
	public HttpImage <>4__this;

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

private sealed class HttpImage.<StartAndWaitForLoad>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7090
{
	private int <>1__state;
	private object <>2__current;
	public string url;
	public HttpImage <>4__this;
	private UnityWebRequest <request>5__2;

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

