public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
{
// Namespace: UnityEngine
[ObsoleteAttribute] // RVA: 0xB4BE0 Offset: 0xB3FE0 VA: 0x1800B4BE0
public class WWW : CustomYieldInstruction, IDisposable // TypeDefIndex: 4755
	// Fields
	private UnityWebRequest _uwr; // 0x10

	// Properties
	public string error { get; }
	public bool isDone { get; }
	public string text { get; }
	public Texture2D texture { get; }
	public string url { get; }
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2314D70 Offset: 0x2314170 VA: 0x182314D70
	public static string UnEscapeURL(string s) { }

	// RVA: 0x2314DA0 Offset: 0x23141A0 VA: 0x182314DA0
	public static string UnEscapeURL(string s, Encoding e) { }

	// RVA: 0x2314E90 Offset: 0x2314290 VA: 0x182314E90
	public void .ctor(string url) { }

	// RVA: 0x2315150 Offset: 0x2314550 VA: 0x182315150
	public void .ctor(string url, WWWForm form) { }

	// RVA: 0x2314EF0 Offset: 0x23142F0 VA: 0x182314EF0
	public void .ctor(string url, byte[] postData, Dictionary<string, string> headers) { }

	// RVA: 0x23151D0 Offset: 0x23145D0 VA: 0x1823151D0
	public string get_error() { }

	// RVA: 0x23152E0 Offset: 0x23146E0 VA: 0x1823152E0
	public bool get_isDone() { }

	// RVA: 0x2315330 Offset: 0x2314730 VA: 0x182315330
	public string get_text() { }

	// RVA: 0x2314C10 Offset: 0x2314010 VA: 0x182314C10
	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	// RVA: 0x23153B0 Offset: 0x23147B0 VA: 0x1823153B0
	public Texture2D get_texture() { }

	// RVA: 0x23154B0 Offset: 0x23148B0 VA: 0x1823154B0
	public string get_url() { }

	// RVA: 0x2315300 Offset: 0x2314700 VA: 0x182315300 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x2314D30 Offset: 0x2314130 VA: 0x182314D30 Slot: 8
	public void Dispose() { }

	// RVA: 0x2314DB0 Offset: 0x23141B0 VA: 0x182314DB0
	private bool WaitUntilDoneIfPossible() { }

}

