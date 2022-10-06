public sealed class OnQueryActivePlayerSanctionsCallback : MulticastDelegate // TypeDefIndex: 8613
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref QueryActivePlayerSanctionsCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref QueryActivePlayerSanctionsCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref QueryActivePlayerSanctionsCallbackInfo data, IAsyncResult result) { }

}

