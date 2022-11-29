internal struct QueryAgeGateCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryAgeGateCallbackInfo>, ISettable<QueryAgeGateCallbackInfo>, IDisposable // TypeDefIndex: 9353
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_CountryCode; 
	private uint m_AgeOfConsent; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String CountryCode { get; set; }
	public uint AgeOfConsent { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_CountryCode() { }

	public void set_CountryCode(Utf8String value) { }

	public uint get_AgeOfConsent() { }

	public void set_AgeOfConsent(uint value) { }

	public void Set(ref QueryAgeGateCallbackInfo other) { }

	public void Set(ref Nullable<QueryAgeGateCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryAgeGateCallbackInfo output) { }

}

