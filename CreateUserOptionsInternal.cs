internal struct CreateUserOptionsInternal : ISettable<CreateUserOptions>, IDisposable // TypeDefIndex: 9331
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_DateOfBirth;
	private IntPtr m_ParentEmail;

	public ProductUserId LocalUserId { set; }
	public Utf8String DateOfBirth { set; }
	public Utf8String ParentEmail { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_DateOfBirth(Utf8String value) { }

	public void set_ParentEmail(Utf8String value) { }

	public void Set(ref CreateUserOptions other) { }

	public void Set(ref Nullable<CreateUserOptions> other) { }

	public void Dispose() { }

}

internal struct CreateUserOptionsInternal : ISettable<CreateUserOptions>, IDisposable // TypeDefIndex: 9574
{
	private int m_ApiVersion;
	private IntPtr m_ContinuanceToken;

	public ContinuanceToken ContinuanceToken { set; }


	public void set_ContinuanceToken(ContinuanceToken value) { }

	public void Set(ref CreateUserOptions other) { }

	public void Set(ref Nullable<CreateUserOptions> other) { }

	public void Dispose() { }

}

