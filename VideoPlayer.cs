public sealed class VideoPlayer : Behaviour // TypeDefIndex: 4788
{
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VideoPlayer.EventHandler prepareCompleted; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VideoPlayer.EventHandler loopPointReached; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private VideoPlayer.EventHandler started; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private VideoPlayer.EventHandler frameDropped; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VideoPlayer.ErrorEventHandler errorReceived; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private VideoPlayer.EventHandler seekCompleted; 
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private VideoPlayer.TimeEventHandler clockResyncOccurred; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private VideoPlayer.FrameReadyEventHandler frameReady; 

	[NativeNameAttribute] 
	public string url { set; }
	[NativeHeaderAttribute] 
	public Texture texture { get; }
	public bool isPrepared { get; }
	[NativeNameAttribute] 
	public long frame { get; }
	public uint width { get; }
	public uint height { get; }


	public void set_url(string value) { }

	public Texture get_texture() { }

	[NativeNameAttribute] 
	public bool get_isPrepared() { }

	public void Play() { }

	public void Stop() { }

	public long get_frame() { }

	public uint get_width() { }

	public uint get_height() { }

	[CompilerGeneratedAttribute] 
	public void add_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[CompilerGeneratedAttribute] 
	public void remove_errorReceived(VideoPlayer.ErrorEventHandler value) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeStartedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds) { }

}

public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4789
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 4790
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source, string message) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4791
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4792
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoPlayer source, double seconds) { }

	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

