internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyIdTokenCallbackInfo>, ISettable<VerifyIdTokenCallbackInfo>, IDisposable // TypeDefIndex: 9646
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_ProductUserId;
	private int m_IsAccountInfoPresent;
	private ExternalAccountType m_AccountIdType;
	private IntPtr m_AccountId;
	private IntPtr m_Platform;
	private IntPtr m_DeviceType;
	private IntPtr m_ClientId;
	private IntPtr m_ProductId;
	private IntPtr m_SandboxId;
	private IntPtr m_DeploymentId;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId ProductUserId { get; set; }
	public bool IsAccountInfoPresent { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Utf8String AccountId { get; set; }
	public Utf8String Platform { get; set; }
	public Utf8String DeviceType { get; set; }
	public Utf8String ClientId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public Utf8String DeploymentId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_ProductUserId() { }

	public void set_ProductUserId(ProductUserId value) { }

	public bool get_IsAccountInfoPresent() { }

	public void set_IsAccountInfoPresent(bool value) { }

	public ExternalAccountType get_AccountIdType() { }

	public void set_AccountIdType(ExternalAccountType value) { }

	public Utf8String get_AccountId() { }

	public void set_AccountId(Utf8String value) { }

	public Utf8String get_Platform() { }

	public void set_Platform(Utf8String value) { }

	public Utf8String get_DeviceType() { }

	public void set_DeviceType(Utf8String value) { }

	public Utf8String get_ClientId() { }

	public void set_ClientId(Utf8String value) { }

	public Utf8String get_ProductId() { }

	public void set_ProductId(Utf8String value) { }

	public Utf8String get_SandboxId() { }

	public void set_SandboxId(Utf8String value) { }

	public Utf8String get_DeploymentId() { }

	public void set_DeploymentId(Utf8String value) { }

	public void Set(ref VerifyIdTokenCallbackInfo other) { }

	public void Set(ref Nullable<VerifyIdTokenCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out VerifyIdTokenCallbackInfo output) { }

}

internal struct VerifyIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<VerifyIdTokenCallbackInfo>, ISettable<VerifyIdTokenCallbackInfo>, IDisposable // TypeDefIndex: 9709
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_ApplicationId;
	private IntPtr m_ClientId;
	private IntPtr m_ProductId;
	private IntPtr m_SandboxId;
	private IntPtr m_DeploymentId;
	private IntPtr m_DisplayName;
	private int m_IsExternalAccountInfoPresent;
	private ExternalAccountType m_ExternalAccountIdType;
	private IntPtr m_ExternalAccountId;
	private IntPtr m_ExternalAccountDisplayName;
	private IntPtr m_Platform;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String ApplicationId { get; set; }
	public Utf8String ClientId { get; set; }
	public Utf8String ProductId { get; set; }
	public Utf8String SandboxId { get; set; }
	public Utf8String DeploymentId { get; set; }
	public Utf8String DisplayName { get; set; }
	public bool IsExternalAccountInfoPresent { get; set; }
	public ExternalAccountType ExternalAccountIdType { get; set; }
	public Utf8String ExternalAccountId { get; set; }
	public Utf8String ExternalAccountDisplayName { get; set; }
	public Utf8String Platform { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_ApplicationId() { }

	public void set_ApplicationId(Utf8String value) { }

	public Utf8String get_ClientId() { }

	public void set_ClientId(Utf8String value) { }

	public Utf8String get_ProductId() { }

	public void set_ProductId(Utf8String value) { }

	public Utf8String get_SandboxId() { }

	public void set_SandboxId(Utf8String value) { }

	public Utf8String get_DeploymentId() { }

	public void set_DeploymentId(Utf8String value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public bool get_IsExternalAccountInfoPresent() { }

	public void set_IsExternalAccountInfoPresent(bool value) { }

	public ExternalAccountType get_ExternalAccountIdType() { }

	public void set_ExternalAccountIdType(ExternalAccountType value) { }

	public Utf8String get_ExternalAccountId() { }

	public void set_ExternalAccountId(Utf8String value) { }

	public Utf8String get_ExternalAccountDisplayName() { }

	public void set_ExternalAccountDisplayName(Utf8String value) { }

	public Utf8String get_Platform() { }

	public void set_Platform(Utf8String value) { }

	public void Set(ref VerifyIdTokenCallbackInfo other) { }

	public void Set(ref Nullable<VerifyIdTokenCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out VerifyIdTokenCallbackInfo output) { }

}

