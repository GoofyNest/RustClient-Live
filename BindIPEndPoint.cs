public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 2989
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x154C990 Offset: 0x154BD90 VA: 0x18154C990 Slot: 12
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }

	// RVA: 0x154C900 Offset: 0x154BD00 VA: 0x18154C900 Slot: 13
	public virtual IAsyncResult BeginInvoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual IPEndPoint EndInvoke(IAsyncResult result) { }

}

