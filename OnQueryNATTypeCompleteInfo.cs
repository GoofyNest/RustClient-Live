public struct OnQueryNATTypeCompleteInfo : ICallbackInfo // TypeDefIndex: 8986
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private NATType <NATType>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public NATType NATType { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public NATType get_NATType() { }

	[CompilerGeneratedAttribute]
	public void set_NATType(NATType value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnQueryNATTypeCompleteInfoInternal other) { }

}

