internal struct OnQueryNATTypeCompleteInfoInternal : ICallbackInfoInternal, IGettable<OnQueryNATTypeCompleteInfo>, ISettable<OnQueryNATTypeCompleteInfo>, IDisposable // TypeDefIndex: 8941
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private NATType m_NATType; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public NATType NATType { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public NATType get_NATType() { }

	public void set_NATType(NATType value) { }

	public void Set(ref OnQueryNATTypeCompleteInfo other) { }

	public void Set(ref Nullable<OnQueryNATTypeCompleteInfo> other) { }

	public void Dispose() { }

	public void Get(out OnQueryNATTypeCompleteInfo output) { }

}

