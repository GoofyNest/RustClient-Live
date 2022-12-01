public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 6017
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }

	public virtual IAsyncResult BeginInvoke(object o, StreamingContext context, ErrorContext errorContext, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

