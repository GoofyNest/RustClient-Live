public class VideoCapture : IDisposable // TypeDefIndex: 3619
{
	internal IntPtr m_NativePtr; 
	private static readonly long HR_SUCCESS; 


	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] 
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	public void Dispose() { }

	[NativeConditionalAttribute] 
	[NativeMethodAttribute] 
	private void Dispose_Internal() { }

	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] 
	[NativeMethodAttribute] 
	[NativeConditionalAttribute] 
	private void DisposeThreaded_Internal() { }

	private static void .cctor() { }

}

public enum VideoCapture.CaptureResultType // TypeDefIndex: 3620
{
	public int value__; 
	public const VideoCapture.CaptureResultType Success = 0;
	public const VideoCapture.CaptureResultType UnknownError = 1;

}

public struct VideoCapture.VideoCaptureResult // TypeDefIndex: 3621
{
	public VideoCapture.CaptureResultType resultType; 
	public long hResult; 

}

public sealed class VideoCapture.OnVideoCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3622
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture captureObject) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture captureObject, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3623
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3624
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3625
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3626
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

