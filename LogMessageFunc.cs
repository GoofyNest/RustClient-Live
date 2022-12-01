public sealed class LogMessageFunc : MulticastDelegate // TypeDefIndex: 9058
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref LogMessage message) { }

	public virtual IAsyncResult BeginInvoke(ref LogMessage message, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref LogMessage message, IAsyncResult result) { }

}

