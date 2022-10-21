public struct LinkAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 9580
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LinkAccountCallbackInfoInternal other) { }

}

public struct LinkAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 9655
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<PinGrantInfo> <PinGrantInfo>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <SelectedAccountId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	[CompilerGeneratedAttribute] 
	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_SelectedAccountId() { }

	[CompilerGeneratedAttribute] 
	public void set_SelectedAccountId(EpicAccountId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LinkAccountCallbackInfoInternal other) { }

}

