internal struct CreateDeviceIdOptionsInternal : ISettable<CreateDeviceIdOptions>, IDisposable // TypeDefIndex: 9568
{
	private int m_ApiVersion; 
	private IntPtr m_DeviceModel; 

	public Utf8String DeviceModel { set; }


	public void set_DeviceModel(Utf8String value) { }

	public void Set(ref CreateDeviceIdOptions other) { }

	public void Set(ref Nullable<CreateDeviceIdOptions> other) { }

	public void Dispose() { }

}

