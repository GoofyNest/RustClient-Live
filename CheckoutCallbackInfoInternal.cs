internal struct CheckoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<CheckoutCallbackInfo>, ISettable<CheckoutCallbackInfo>, IDisposable // TypeDefIndex: 9428
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_TransactionId;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String TransactionId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public Utf8String get_TransactionId() { }

	public void set_TransactionId(Utf8String value) { }

	public void Set(ref CheckoutCallbackInfo other) { }

	public void Set(ref Nullable<CheckoutCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out CheckoutCallbackInfo output) { }

}

