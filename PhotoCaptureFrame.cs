public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 3615
{
	private IntPtr m_NativePtr; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private int <dataLength>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private bool <hasLocationData>k__BackingField; 
	[DebuggerBrowsableAttribute] 
	[CompilerGeneratedAttribute] 
	private CapturePixelFormat <pixelFormat>k__BackingField; 

	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }


	[CompilerGeneratedAttribute] 
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] 
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] 
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] 
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] 
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] 
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] 
	private CapturePixelFormat GetCapturePixelFormat() { }

	internal void .ctor(IntPtr nativePtr) { }

	private void Cleanup() { }

	[NativeNameAttribute] 
	[NativeConditionalAttribute] 
	[ThreadAndSerializationSafeAttribute] 
	private void Dispose_Internal() { }

	public void Dispose() { }

	protected override void Finalize() { }

}

