public class PhotoCapture : IDisposable // TypeDefIndex: 3607
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2173F90 Offset: 0x2173390 VA: 0x182173F90
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173D10 Offset: 0x2173110 VA: 0x182173D10
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1824C90 Offset: 0x1824090 VA: 0x181824C90
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173DB0 Offset: 0x21731B0 VA: 0x182173DB0
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173EA0 Offset: 0x21732A0 VA: 0x182173EA0
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173A20 Offset: 0x2172E20 VA: 0x182173A20
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2173B10 Offset: 0x2172F10 VA: 0x182173B10
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x21738B0 Offset: 0x2172CB0 VA: 0x1821738B0 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDABA0 Offset: 0xD9FA0 VA: 0x1800DABA0
	[NativeNameAttribute] // RVA: 0xDABA0 Offset: 0xD9FA0 VA: 0x1800DABA0
	// RVA: 0x2173870 Offset: 0x2172C70 VA: 0x182173870
	private void Dispose_Internal() { }

	// RVA: 0x2173940 Offset: 0x2172D40 VA: 0x182173940 Slot: 1
	protected override void Finalize() { }

	[NativeNameAttribute] // RVA: 0xDAD80 Offset: 0xDA180 VA: 0x1800DAD80
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDAD80 Offset: 0xDA180 VA: 0x1800DAD80
	[NativeConditionalAttribute] // RVA: 0xDAD80 Offset: 0xDA180 VA: 0x1800DAD80
	// RVA: 0x2173830 Offset: 0x2172C30 VA: 0x182173830
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2174030 Offset: 0x2173430 VA: 0x182174030
	private static void .cctor() { }

}

public enum PhotoCapture.CaptureResultType // TypeDefIndex: 3608
{	// Fields
	public int value__; // 0x0
	public const PhotoCapture.CaptureResultType Success = 0;
	public const PhotoCapture.CaptureResultType UnknownError = 1;

}

public struct PhotoCapture.PhotoCaptureResult // TypeDefIndex: 3609
{	// Fields
	public PhotoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8

}

public sealed class PhotoCapture.OnCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3610
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x497240 Offset: 0x496640 VA: 0x180497240 Slot: 12
	public virtual void Invoke(PhotoCapture captureObject) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture captureObject, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3611
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x21731B0 Offset: 0x21725B0 VA: 0x1821731B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3612
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2173230 Offset: 0x2172630 VA: 0x182173230 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3613
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2172E70 Offset: 0x2172270 VA: 0x182172E70 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2172DF0 Offset: 0x21721F0 VA: 0x182172DF0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3614
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A390D0 Offset: 0x1A384D0 VA: 0x181A390D0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	// RVA: 0x2173120 Offset: 0x2172520 VA: 0x182173120 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

