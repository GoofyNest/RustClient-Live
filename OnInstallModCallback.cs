public sealed class OnInstallModCallback : MulticastDelegate // TypeDefIndex: 8983
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref InstallModCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref InstallModCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref InstallModCallbackInfo data, IAsyncResult result) { }

}

