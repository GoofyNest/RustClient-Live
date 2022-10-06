public sealed class TransactionCompletedEventHandler : MulticastDelegate // TypeDefIndex: 3978
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, TransactionEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, TransactionEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

