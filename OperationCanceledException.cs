public class OperationCanceledException : SystemException // TypeDefIndex: 282
{	private CancellationToken _cancellationToken; // 0x88

	public CancellationToken CancellationToken { get; set; }


	public CancellationToken get_CancellationToken() { }

	private void set_CancellationToken(CancellationToken value) { }

	public void .ctor() { }

	public void .ctor(string message) { }

	public void .ctor(string message, CancellationToken token) { }

	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

