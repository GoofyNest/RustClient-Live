public class ByteArrayContent : HttpContent // TypeDefIndex: 5736
{
// Namespace: 
internal class <Module> // TypeDefIndex: 5733

// Namespace: 
internal class <Module> // TypeDefIndex: 5734

// Namespace: 
internal class <Module> // TypeDefIndex: 5735

// Namespace: System.Net.Http
public class ByteArrayContent : HttpContent // TypeDefIndex: 5736
	// Fields
	private readonly byte[] content; // 0x30
	private readonly int offset; // 0x38
	private readonly int count; // 0x3C

	// Methods

	// RVA: 0x107F770 Offset: 0x107EB70 VA: 0x18107F770
	public void .ctor(byte[] content) { }

	// RVA: 0x107F670 Offset: 0x107EA70 VA: 0x18107F670 Slot: 5
	protected override Task<Stream> CreateContentReadStreamAsync() { }

	// RVA: 0x107F720 Offset: 0x107EB20 VA: 0x18107F720 Slot: 7
	protected internal override Task SerializeToStreamAsync(Stream stream, TransportContext context) { }

	// RVA: 0x107F760 Offset: 0x107EB60 VA: 0x18107F760 Slot: 8
	protected internal override bool TryComputeLength(out long length) { }

}

