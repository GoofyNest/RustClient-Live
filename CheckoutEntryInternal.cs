internal struct CheckoutEntryInternal : IGettable<CheckoutEntry>, ISettable<CheckoutEntry>, IDisposable // TypeDefIndex: 9382
{
	private int m_ApiVersion; 
	private IntPtr m_OfferId; 

	public Utf8String OfferId { get; set; }


	public Utf8String get_OfferId() { }

	public void set_OfferId(Utf8String value) { }

	public void Set(ref CheckoutEntry other) { }

	public void Set(ref Nullable<CheckoutEntry> other) { }

	public void Dispose() { }

	public void Get(out CheckoutEntry output) { }

}

