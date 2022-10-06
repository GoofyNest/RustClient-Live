public struct RedeemEntitlementsCallbackInfo : ICallbackInfo // TypeDefIndex: 9500
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <RedeemedEntitlementIdsCount>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public uint RedeemedEntitlementIdsCount { get; set; }


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
	public uint get_RedeemedEntitlementIdsCount() { }

	[CompilerGeneratedAttribute] 
	public void set_RedeemedEntitlementIdsCount(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref RedeemEntitlementsCallbackInfoInternal other) { }

}

