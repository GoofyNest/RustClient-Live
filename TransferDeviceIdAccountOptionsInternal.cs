internal struct TransferDeviceIdAccountOptionsInternal : ISettable<TransferDeviceIdAccountOptions>, IDisposable // TypeDefIndex: 9634
{
	private int m_ApiVersion; 
	private IntPtr m_PrimaryLocalUserId; 
	private IntPtr m_LocalDeviceUserId; 
	private IntPtr m_ProductUserIdToPreserve; 

	public ProductUserId PrimaryLocalUserId { set; }
	public ProductUserId LocalDeviceUserId { set; }
	public ProductUserId ProductUserIdToPreserve { set; }


	public void set_PrimaryLocalUserId(ProductUserId value) { }

	public void set_LocalDeviceUserId(ProductUserId value) { }

	public void set_ProductUserIdToPreserve(ProductUserId value) { }

	public void Set(ref TransferDeviceIdAccountOptions other) { }

	public void Set(ref Nullable<TransferDeviceIdAccountOptions> other) { }

	public void Dispose() { }

}

