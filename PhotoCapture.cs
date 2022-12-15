public class PhotoCapture : IDisposable // TypeDefIndex: 3610
{
	internal IntPtr m_NativePtr;
	private static readonly long HR_SUCCESS;


	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute]
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute]
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute]
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute]
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute]
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	public void Dispose() { }

	[NativeConditionalAttribute]
	[NativeNameAttribute]
	private void Dispose_Internal() { }

	protected override void Finalize() { }

	[NativeConditionalAttribute]
	[ThreadAndSerializationSafeAttribute]
	[NativeNameAttribute]
	private void DisposeThreaded_Internal() { }

	private static void .cctor() { }

}

public enum PhotoCapture.CaptureResultType // TypeDefIndex: 3611
{
	public int value__;
	public const PhotoCapture.CaptureResultType Success = 0;
	public const PhotoCapture.CaptureResultType UnknownError = 1;

}

public struct PhotoCapture.PhotoCaptureResult // TypeDefIndex: 3612
{
	public PhotoCapture.CaptureResultType resultType;
	public long hResult;

}

public sealed class PhotoCapture.OnCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3613
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture captureObject) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture captureObject, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3614
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3615
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3616
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3617
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

