internal struct AccountFeatureRestrictedInfoInternal : IGettable<AccountFeatureRestrictedInfo>, ISettable<AccountFeatureRestrictedInfo>, IDisposable // TypeDefIndex: 9636
{
	private int m_ApiVersion; 
	private IntPtr m_VerificationURI; 

	public Utf8String VerificationURI { get; set; }


	public Utf8String get_VerificationURI() { }

	public void set_VerificationURI(Utf8String value) { }

	public void Set(ref AccountFeatureRestrictedInfo other) { }

	public void Set(ref Nullable<AccountFeatureRestrictedInfo> other) { }

	public void Dispose() { }

	public void Get(out AccountFeatureRestrictedInfo output) { }

}

