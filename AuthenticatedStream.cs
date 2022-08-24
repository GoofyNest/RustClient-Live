public abstract class AuthenticatedStream : Stream // TypeDefIndex: 3067
{
	private Stream _InnerStream; 
	private bool _LeaveStreamOpen; 

	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }


	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	protected Stream get_InnerStream() { }

	protected override void Dispose(bool disposing) { }

	public abstract bool get_IsAuthenticated();

}

