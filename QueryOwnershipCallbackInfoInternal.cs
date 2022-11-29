internal struct QueryOwnershipCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipCallbackInfo>, ISettable<QueryOwnershipCallbackInfo>, IDisposable // TypeDefIndex: 9503
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ItemOwnership; 
	private uint m_ItemOwnershipCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public ItemOwnership[] ItemOwnership { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public ItemOwnership[] get_ItemOwnership() { }

	public void set_ItemOwnership(ItemOwnership[] value) { }

	public void Set(ref QueryOwnershipCallbackInfo other) { }

	public void Set(ref Nullable<QueryOwnershipCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryOwnershipCallbackInfo output) { }

}

