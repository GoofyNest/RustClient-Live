public sealed class OnAudioBeforeRenderCallback : MulticastDelegate // TypeDefIndex: 8678
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AudioBeforeRenderCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref AudioBeforeRenderCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AudioBeforeRenderCallbackInfo data, IAsyncResult result) { }

}

