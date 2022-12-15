internal sealed class OnAudioBeforeRenderCallbackInternal : MulticastDelegate // TypeDefIndex: 8681
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioBeforeRenderCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioBeforeRenderCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioBeforeRenderCallbackInfoInternal data, IAsyncResult result) { }

}

