public struct WriteFileDataCallbackInfo : ICallbackInfo // TypeDefIndex: 8931
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <Filename>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <DataBufferLengthBytes>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }
	public uint DataBufferLengthBytes { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_Filename() { }

	[CompilerGeneratedAttribute]
	public void set_Filename(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public uint get_DataBufferLengthBytes() { }

	[CompilerGeneratedAttribute]
	public void set_DataBufferLengthBytes(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref WriteFileDataCallbackInfoInternal other) { }

}

