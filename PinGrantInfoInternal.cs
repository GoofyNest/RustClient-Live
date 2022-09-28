internal struct PinGrantInfoInternal : IGettable<PinGrantInfo>, ISettable<PinGrantInfo>, IDisposable // TypeDefIndex: 9653
{
	private int m_ApiVersion; 
	private IntPtr m_UserCode; 
	private IntPtr m_VerificationURI; 
	private int m_ExpiresIn; 
	private IntPtr m_VerificationURIComplete; 

	public Utf8String UserCode { get; set; }
	public Utf8String VerificationURI { get; set; }
	public int ExpiresIn { get; set; }
	public Utf8String VerificationURIComplete { get; set; }


	public Utf8String get_UserCode() { }

	public void set_UserCode(Utf8String value) { }

	public Utf8String get_VerificationURI() { }

	public void set_VerificationURI(Utf8String value) { }

	public int get_ExpiresIn() { }

	public void set_ExpiresIn(int value) { }

	public Utf8String get_VerificationURIComplete() { }

	public void set_VerificationURIComplete(Utf8String value) { }

	public void Set(ref PinGrantInfo other) { }

	public void Set(ref Nullable<PinGrantInfo> other) { }

	public void Dispose() { }

	public void Get(out PinGrantInfo output) { }

}

