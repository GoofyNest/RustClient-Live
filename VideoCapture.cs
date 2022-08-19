public class VideoCapture : IDisposable // TypeDefIndex: 3616
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2181540 Offset: 0x2180940 VA: 0x182181540
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x21810E0 Offset: 0x21804E0 VA: 0x1821810E0
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1824C90 Offset: 0x1824090 VA: 0x181824C90
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2181360 Offset: 0x2180760 VA: 0x182181360
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2181450 Offset: 0x2180850 VA: 0x182181450
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2181180 Offset: 0x2180580 VA: 0x182181180
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2181270 Offset: 0x2180670 VA: 0x182181270
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x2180F70 Offset: 0x2180370 VA: 0x182180F70 Slot: 4
	public void Dispose() { }

	[NativeMethodAttribute] // RVA: 0xDD860 Offset: 0xDCC60 VA: 0x1800DD860
	[NativeConditionalAttribute] // RVA: 0xDD860 Offset: 0xDCC60 VA: 0x1800DD860
	// RVA: 0x2180F30 Offset: 0x2180330 VA: 0x182180F30
	private void Dispose_Internal() { }

	// RVA: 0x2181000 Offset: 0x2180400 VA: 0x182181000 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDD9E0 Offset: 0xDCDE0 VA: 0x1800DD9E0
	[NativeConditionalAttribute] // RVA: 0xDD9E0 Offset: 0xDCDE0 VA: 0x1800DD9E0
	[NativeMethodAttribute] // RVA: 0xDD9E0 Offset: 0xDCDE0 VA: 0x1800DD9E0
	// RVA: 0x2180EF0 Offset: 0x21802F0 VA: 0x182180EF0
	private void DisposeThreaded_Internal() { }

	// RVA: 0x21815E0 Offset: 0x21809E0 VA: 0x1821815E0
	private static void .cctor() { }

}

public enum VideoCapture.CaptureResultType // TypeDefIndex: 3617
{	// Fields
	public int value__; // 0x0
	public const VideoCapture.CaptureResultType Success = 0;
	public const VideoCapture.CaptureResultType UnknownError = 1;

}

public struct VideoCapture.VideoCaptureResult // TypeDefIndex: 3618
{	// Fields
	public VideoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8

}

public sealed class VideoCapture.OnVideoCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3619
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(VideoCapture captureObject) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture captureObject, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3620
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21733B0 Offset: 0x21727B0 VA: 0x1821733B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3621
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2173430 Offset: 0x2172830 VA: 0x182173430 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3622
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21732B0 Offset: 0x21726B0 VA: 0x1821732B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3623
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2173330 Offset: 0x2172730 VA: 0x182173330 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

