internal class MD4Managed : MD4 // TypeDefIndex: 69
{	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1747130 Offset: 0x1746530 VA: 0x181747130
	public void .ctor() { }

	// RVA: 0x1746490 Offset: 0x1745890 VA: 0x181746490 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1746150 Offset: 0x1745550 VA: 0x181746150 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1746310 Offset: 0x1745710 VA: 0x181746310 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x17470A0 Offset: 0x17464A0 VA: 0x1817470A0
	private byte[] Padding(int nLength) { }

	// RVA: 0x1746080 Offset: 0x1745480 VA: 0x181746080
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x17460E0 Offset: 0x17454E0 VA: 0x1817460E0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1746140 Offset: 0x1745540 VA: 0x181746140
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1747110 Offset: 0x1746510 VA: 0x181747110
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1746040 Offset: 0x1745440 VA: 0x181746040
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1746090 Offset: 0x1745490 VA: 0x181746090
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x17460F0 Offset: 0x17454F0 VA: 0x1817460F0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1745EF0 Offset: 0x17452F0 VA: 0x181745EF0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1745DE0 Offset: 0x17451E0 VA: 0x181745DE0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x17465D0 Offset: 0x17459D0 VA: 0x1817465D0
	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

public class MD4Managed : MD4 // TypeDefIndex: 1756
{	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1AB2AB0 Offset: 0x1AB1EB0 VA: 0x181AB2AB0
	public void .ctor() { }

	// RVA: 0x1746490 Offset: 0x1745890 VA: 0x181746490 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1746150 Offset: 0x1745550 VA: 0x181746150 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1AB28C0 Offset: 0x1AB1CC0 VA: 0x181AB28C0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1AB2A40 Offset: 0x1AB1E40 VA: 0x181AB2A40
	private byte[] Padding(int nLength) { }

	// RVA: 0x1746080 Offset: 0x1745480 VA: 0x181746080
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x17460E0 Offset: 0x17454E0 VA: 0x1817460E0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1746140 Offset: 0x1745540 VA: 0x181746140
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1747110 Offset: 0x1746510 VA: 0x181747110
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1746040 Offset: 0x1745440 VA: 0x181746040
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1746090 Offset: 0x1745490 VA: 0x181746090
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x17460F0 Offset: 0x17454F0 VA: 0x1817460F0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1745EF0 Offset: 0x17452F0 VA: 0x181745EF0
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1745DE0 Offset: 0x17451E0 VA: 0x181745DE0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x17465D0 Offset: 0x17459D0 VA: 0x1817465D0
	private void MD4Transform(uint[] state, byte[] block, int index) { }

}

