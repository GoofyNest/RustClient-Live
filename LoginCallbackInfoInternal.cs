internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>, ISettable<LoginCallbackInfo>, IDisposable // TypeDefIndex: 9598
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_ContinuanceToken;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ContinuanceToken get_ContinuanceToken() { }

	public void set_ContinuanceToken(ContinuanceToken value) { }

	public void Set(ref LoginCallbackInfo other) { }

	public void Set(ref Nullable<LoginCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LoginCallbackInfo output) { }

}

internal struct LoginCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginCallbackInfo>, ISettable<LoginCallbackInfo>, IDisposable // TypeDefIndex: 9674
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_PinGrantInfo;
	private IntPtr m_ContinuanceToken;
	private IntPtr m_AccountFeatureRestrictedInfo;
	private IntPtr m_SelectedAccountId;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public ContinuanceToken ContinuanceToken { get; set; }
	public Nullable<AccountFeatureRestrictedInfo> AccountFeatureRestrictedInfo { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	public ContinuanceToken get_ContinuanceToken() { }

	public void set_ContinuanceToken(ContinuanceToken value) { }

	public Nullable<AccountFeatureRestrictedInfo> get_AccountFeatureRestrictedInfo() { }

	public void set_AccountFeatureRestrictedInfo(Nullable<AccountFeatureRestrictedInfo> value) { }

	public EpicAccountId get_SelectedAccountId() { }

	public void set_SelectedAccountId(EpicAccountId value) { }

	public void Set(ref LoginCallbackInfo other) { }

	public void Set(ref Nullable<LoginCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LoginCallbackInfo output) { }

}

