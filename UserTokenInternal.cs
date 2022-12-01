internal struct UserTokenInternal : IGettable<UserToken>, ISettable<UserToken>, IDisposable // TypeDefIndex: 8760
{
	private int m_ApiVersion;
	private IntPtr m_ProductUserId;
	private IntPtr m_Token;

	public ProductUserId ProductUserId { get; set; }
	public Utf8String Token { get; set; }


	public ProductUserId get_ProductUserId() { }

	public void set_ProductUserId(ProductUserId value) { }

	public Utf8String get_Token() { }

	public void set_Token(Utf8String value) { }

	public void Set(ref UserToken other) { }

	public void Set(ref Nullable<UserToken> other) { }

	public void Dispose() { }

	public void Get(out UserToken output) { }

}

