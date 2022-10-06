public sealed class OnUninstallModCallback : MulticastDelegate // TypeDefIndex: 9019
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UninstallModCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UninstallModCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UninstallModCallbackInfo data, IAsyncResult result) { }

}

