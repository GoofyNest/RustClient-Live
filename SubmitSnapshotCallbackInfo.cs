public struct SubmitSnapshotCallbackInfo : ICallbackInfo // TypeDefIndex: 8803
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <SnapshotId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 

	public Result ResultCode { get; set; }
	public uint SnapshotId { get; set; }
	public object ClientData { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public uint get_SnapshotId() { }

	[CompilerGeneratedAttribute] 
	public void set_SnapshotId(uint value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref SubmitSnapshotCallbackInfoInternal other) { }

}

