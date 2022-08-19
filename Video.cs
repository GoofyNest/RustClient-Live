public class Video : RustControl // TypeDefIndex: 7043
{	// Fields
	public RawImage VideoCanvas; // 0x30
	public VideoPlayer VideoPlayer; // 0x38
	public CanvasGroup CanvasGroup; // 0x40
	[RangeAttribute] // RVA: 0x75910 Offset: 0x74D10 VA: 0x180075910
	public float FadeIn; // 0x48
	private uint textureWidth; // 0x4C
	private uint textureHeight; // 0x50
	private Vector2 playerSize; // 0x54

	// Methods

	// RVA: 0xFD4470 Offset: 0xFD3870 VA: 0x180FD4470 Slot: 4
	protected override void Awake() { }

	// RVA: 0xFD5110 Offset: 0xFD4510 VA: 0x180FD5110
	private void VideoPlayer_errorReceived(VideoPlayer source, string message) { }

	// RVA: 0xFD5040 Offset: 0xFD4440 VA: 0x180FD5040
	public void PlayUrl(string video) { }

	// RVA: 0xFD4D80 Offset: 0xFD4180 VA: 0x180FD4D80
	public void LateUpdate() { }

	// RVA: 0xFD4500 Offset: 0xFD3900 VA: 0x180FD4500
	private void Cover() { }

	// RVA: 0xFD50B0 Offset: 0xFD44B0 VA: 0x180FD50B0
	public void Stop() { }

	// RVA: 0xFD5180 Offset: 0xFD4580 VA: 0x180FD5180
	public void .ctor() { }

}

