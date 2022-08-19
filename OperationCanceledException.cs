public class OperationCanceledException : SystemException // TypeDefIndex: 282
{	// Fields
	private CancellationToken _cancellationToken; // 0x88

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x167ECE0 Offset: 0x167E0E0 VA: 0x18167ECE0
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x167EC00 Offset: 0x167E000 VA: 0x18167EC00
	public void .ctor() { }

	// RVA: 0x167EC60 Offset: 0x167E060 VA: 0x18167EC60
	public void .ctor(string message) { }

	// RVA: 0x167EC90 Offset: 0x167E090 VA: 0x18167EC90
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0xFD8000 Offset: 0xFD7400 VA: 0x180FD8000
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

