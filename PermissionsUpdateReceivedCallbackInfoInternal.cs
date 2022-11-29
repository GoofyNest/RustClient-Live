internal struct PermissionsUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PermissionsUpdateReceivedCallbackInfo>, ISettable<PermissionsUpdateReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9351
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

	public void Set(ref PermissionsUpdateReceivedCallbackInfo other) { }

	public void Set(ref Nullable<PermissionsUpdateReceivedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out PermissionsUpdateReceivedCallbackInfo output) { }

}

