public struct CreateDeviceIdCallbackInfo : ICallbackInfo // TypeDefIndex: 9556
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref CreateDeviceIdCallbackInfoInternal other) { }

}

