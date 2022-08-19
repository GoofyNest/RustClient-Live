public class HttpImage : MonoBehaviour // TypeDefIndex: 7044
{	// Fields
	public static Dictionary<string, UnityWebRequest> RequestCache; // 0x0
	public static Dictionary<string, ValueTuple<Texture2D, Sprite>> TextureCache; // 0x8
	public Texture2D LoadingImage; // 0x18
	public Texture2D MissingImage; // 0x20
	private RawImage rawImage; // 0x28
	private Image image; // 0x30
	private Sprite loadingSprite; // 0x38
	private Sprite missingSprite; // 0x40
	public string Url; // 0x48
	public bool PreserveAspectHeight; // 0x50
	public bool GenerateMipmaps; // 0x51
	public float MaxWidth; // 0x54
	public float MaxHeight; // 0x58

	// Methods

	// RVA: 0xFBC960 Offset: 0xFBBD60 VA: 0x180FBC960
	private void Init() { }

	// RVA: 0xFBD180 Offset: 0xFBC580 VA: 0x180FBD180
	private void Start() { }

	// RVA: 0xFBCE10 Offset: 0xFBC210 VA: 0x180FBCE10
	private void OnDestroy() { }

	// RVA: 0xFBCAC0 Offset: 0xFBBEC0 VA: 0x180FBCAC0
	public bool Load(string url) { }

	[IteratorStateMachineAttribute] // RVA: 0x759C0 Offset: 0x74DC0 VA: 0x1800759C0
	// RVA: 0xFBD430 Offset: 0xFBC830 VA: 0x180FBD430
	private IEnumerator WaitForLoad(string url) { }

	// RVA: 0xFBD220 Offset: 0xFBC620 VA: 0x180FBD220
	private void UpdateImageTexture(ValueTuple<Texture2D, Sprite> tex) { }

	// RVA: 0xFBD070 Offset: 0xFBC470 VA: 0x180FBD070
	public void SetMissingImage() { }

	// RVA: 0xFBCFF0 Offset: 0xFBC3F0 VA: 0x180FBCFF0
	public void SetLoadingImage() { }

	[IteratorStateMachineAttribute] // RVA: 0x75CE0 Offset: 0x750E0 VA: 0x180075CE0
	// RVA: 0xFBD0F0 Offset: 0xFBC4F0 VA: 0x180FBD0F0
	private IEnumerator StartAndWaitForLoad(string url) { }

	// RVA: 0xFBC5C0 Offset: 0xFBB9C0 VA: 0x180FBC5C0
	private void AutosizeForTexture(Texture2D texture) { }

	// RVA: 0xFBCF10 Offset: 0xFBC310 VA: 0x180FBCF10
	private void SetImageEnabled(bool enabled) { }

	// RVA: 0xFBC830 Offset: 0xFBBC30 VA: 0x180FBC830
	private static Sprite CreateSprite(Texture2D texture) { }

	// RVA: 0xFBD560 Offset: 0xFBC960 VA: 0x180FBD560
	public void .ctor() { }

	// RVA: 0xFBD4C0 Offset: 0xFBC8C0 VA: 0x180FBD4C0
	private static void .cctor() { }

}

private sealed class HttpImage.<WaitForLoad>d__17 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7045
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public HttpImage <>4__this; // 0x28

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

	// RVA: 0xFD3F80 Offset: 0xFD3380 VA: 0x180FD3F80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD4160 Offset: 0xFD3560 VA: 0x180FD4160 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class HttpImage.<StartAndWaitForLoad>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7046
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public string url; // 0x20
	public HttpImage <>4__this; // 0x28
	private UnityWebRequest <request>5__2; // 0x30

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

	// RVA: 0xFD26D0 Offset: 0xFD1AD0 VA: 0x180FD26D0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFD2C00 Offset: 0xFD2000 VA: 0x180FD2C00 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

