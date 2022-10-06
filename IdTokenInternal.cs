internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, IDisposable // TypeDefIndex: 9578
{
	private int m_ApiVersion; 
	private IntPtr m_ProductUserId; 
	private IntPtr m_JsonWebToken; 

	public ProductUserId ProductUserId { get; set; }
	public Utf8String JsonWebToken { get; set; }


	public ProductUserId get_ProductUserId() { }

	public void set_ProductUserId(ProductUserId value) { }

	public Utf8String get_JsonWebToken() { }

	public void set_JsonWebToken(Utf8String value) { }

	public void Set(ref IdToken other) { }

	public void Set(ref Nullable<IdToken> other) { }

	public void Dispose() { }

	public void Get(out IdToken output) { }

}

internal struct IdTokenInternal : IGettable<IdToken>, ISettable<IdToken>, IDisposable // TypeDefIndex: 9653
{
	private int m_ApiVersion; 
	private IntPtr m_AccountId; 
	private IntPtr m_JsonWebToken; 

	public EpicAccountId AccountId { get; set; }
	public Utf8String JsonWebToken { get; set; }


	public EpicAccountId get_AccountId() { }

	public void set_AccountId(EpicAccountId value) { }

	public Utf8String get_JsonWebToken() { }

	public void set_JsonWebToken(Utf8String value) { }

	public void Set(ref IdToken other) { }

	public void Set(ref Nullable<IdToken> other) { }

	public void Dispose() { }

	public void Get(out IdToken output) { }

}

