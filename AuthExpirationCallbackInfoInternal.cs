internal struct AuthExpirationCallbackInfoInternal : ICallbackInfoInternal, IGettable<AuthExpirationCallbackInfo>, ISettable<AuthExpirationCallbackInfo>, IDisposable // TypeDefIndex: 9553
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref AuthExpirationCallbackInfo other) { }

	public void Set(ref Nullable<AuthExpirationCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out AuthExpirationCallbackInfo output) { }

}

