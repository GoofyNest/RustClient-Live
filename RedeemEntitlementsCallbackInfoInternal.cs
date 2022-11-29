internal struct RedeemEntitlementsCallbackInfoInternal : ICallbackInfoInternal, IGettable<RedeemEntitlementsCallbackInfo>, ISettable<RedeemEntitlementsCallbackInfo>, IDisposable // TypeDefIndex: 9511
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private uint m_RedeemedEntitlementIdsCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public uint RedeemedEntitlementIdsCount { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public uint get_RedeemedEntitlementIdsCount() { }

	public void set_RedeemedEntitlementIdsCount(uint value) { }

	public void Set(ref RedeemEntitlementsCallbackInfo other) { }

	public void Set(ref Nullable<RedeemEntitlementsCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out RedeemEntitlementsCallbackInfo output) { }

}

