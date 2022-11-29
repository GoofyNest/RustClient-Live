public struct UpdateSessionCallbackInfo : ICallbackInfo // TypeDefIndex: 8613
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String SessionName { get; set; }
	public Utf8String SessionId { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionName() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionId() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionId(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref UpdateSessionCallbackInfoInternal other) { }

}

