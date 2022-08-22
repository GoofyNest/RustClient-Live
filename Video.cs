public class Video : RustControl // TypeDefIndex: 7043
{	public RawImage VideoCanvas; // 0x30
	public VideoPlayer VideoPlayer; // 0x38
	public CanvasGroup CanvasGroup; // 0x40
	[RangeAttribute] // RVA: 0x75910 Offset: 0x74D10 VA: 0x180075910
	public float FadeIn; // 0x48
	private uint textureWidth; // 0x4C
	private uint textureHeight; // 0x50
	private Vector2 playerSize; // 0x54


	protected override void Awake() { }

	private void VideoPlayer_errorReceived(VideoPlayer source, string message) { }

	public void PlayUrl(string video) { }

	public void LateUpdate() { }

	private void Cover() { }

	public void Stop() { }

	public void .ctor() { }

}

