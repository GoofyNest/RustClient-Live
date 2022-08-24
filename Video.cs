public class Video : RustControl // TypeDefIndex: 7043
{
	public RawImage VideoCanvas; 
	public VideoPlayer VideoPlayer; 
	public CanvasGroup CanvasGroup; 
	[RangeAttribute] 
	public float FadeIn; 
	private uint textureWidth; 
	private uint textureHeight; 
	private Vector2 playerSize; 


	protected override void Awake() { }

	private void VideoPlayer_errorReceived(VideoPlayer source, string message) { }

	public void PlayUrl(string video) { }

	public void LateUpdate() { }

	private void Cover() { }

	public void Stop() { }

	public void .ctor() { }

}

