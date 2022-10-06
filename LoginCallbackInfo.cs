public struct LoginCallbackInfo : ICallbackInfo // TypeDefIndex: 9583
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ContinuanceToken <ContinuanceToken>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }


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

	[CompilerGeneratedAttribute] 
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGeneratedAttribute] 
	public void set_ContinuanceToken(ContinuanceToken value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LoginCallbackInfoInternal other) { }

}

public struct LoginCallbackInfo : ICallbackInfo // TypeDefIndex: 9659
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
	private ContinuanceToken <ContinuanceToken>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<AccountFeatureRestrictedInfo> <AccountFeatureRestrictedInfo>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <SelectedAccountId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }
	public Nullable<AccountFeatureRestrictedInfo> AccountFeatureRestrictedInfo { get; set; }
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
	public ContinuanceToken get_ContinuanceToken() { }

	[CompilerGeneratedAttribute] 
	public void set_ContinuanceToken(ContinuanceToken value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<AccountFeatureRestrictedInfo> get_AccountFeatureRestrictedInfo() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountFeatureRestrictedInfo(Nullable<AccountFeatureRestrictedInfo> value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_SelectedAccountId() { }

	[CompilerGeneratedAttribute] 
	public void set_SelectedAccountId(EpicAccountId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LoginCallbackInfoInternal other) { }

}

