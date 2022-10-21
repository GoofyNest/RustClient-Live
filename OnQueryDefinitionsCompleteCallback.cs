public sealed class OnQueryDefinitionsCompleteCallback : MulticastDelegate // TypeDefIndex: 9918
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnQueryDefinitionsCompleteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnQueryDefinitionsCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnQueryDefinitionsCompleteCallbackInfo data, IAsyncResult result) { }

}

