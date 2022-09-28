public sealed class OnTransferDeviceIdAccountCallback : MulticastDelegate // TypeDefIndex: 9573
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref TransferDeviceIdAccountCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref TransferDeviceIdAccountCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref TransferDeviceIdAccountCallbackInfo data, IAsyncResult result) { }

}

