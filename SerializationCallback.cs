public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 6008
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object o, StreamingContext context) { }

	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

