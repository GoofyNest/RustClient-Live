public sealed class OnHardMuteMemberCallback : MulticastDelegate // TypeDefIndex: 9202
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref HardMuteMemberCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref HardMuteMemberCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref HardMuteMemberCallbackInfo data, IAsyncResult result) { }

}

