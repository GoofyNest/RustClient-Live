internal struct GetExternalAccountMappingsOptionsInternal : ISettable<GetExternalAccountMappingsOptions>, IDisposable // TypeDefIndex: 9586
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private ExternalAccountType m_AccountIdType;
	private IntPtr m_TargetExternalUserId;

	public ProductUserId LocalUserId { set; }
	public ExternalAccountType AccountIdType { set; }
	public Utf8String TargetExternalUserId { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_AccountIdType(ExternalAccountType value) { }

	public void set_TargetExternalUserId(Utf8String value) { }

	public void Set(ref GetExternalAccountMappingsOptions other) { }

	public void Set(ref Nullable<GetExternalAccountMappingsOptions> other) { }

	public void Dispose() { }

}

