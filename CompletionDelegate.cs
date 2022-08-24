internal sealed class CompletionDelegate : MulticastDelegate // TypeDefIndex: 2957
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(byte[] responseBytes, Exception exception, object State) { }

	public virtual IAsyncResult BeginInvoke(byte[] responseBytes, Exception exception, object State, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

