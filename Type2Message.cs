public class Type2Message : MessageBase // TypeDefIndex: 1732
{	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1AC0000 Offset: 0x1ABF400 VA: 0x181AC0000
	public void .ctor(byte[] message) { }

	// RVA: 0x1ABFE30 Offset: 0x1ABF230 VA: 0x181ABFE30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AC00A0 Offset: 0x1ABF4A0 VA: 0x181AC00A0
	public byte[] get_Nonce() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_TargetName() { }

	// RVA: 0x1AC0120 Offset: 0x1ABF520 VA: 0x181AC0120
	public byte[] get_TargetInfo() { }

	// RVA: 0x1ABFCA0 Offset: 0x1ABF0A0 VA: 0x181ABFCA0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1ABFED0 Offset: 0x1ABF2D0 VA: 0x181ABFED0 Slot: 5
	public override byte[] GetBytes() { }

}

