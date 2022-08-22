internal sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 1024
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(StreamingContext context) { }

	public virtual IAsyncResult BeginInvoke(StreamingContext context, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

