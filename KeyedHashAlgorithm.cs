public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 968
{	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x16FD750 Offset: 0x16FCB50 VA: 0x1816FD750 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FD7D0 Offset: 0x16FCBD0 VA: 0x1816FD7D0 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x16FD850 Offset: 0x16FCC50 VA: 0x1816FD850 Slot: 20
	public virtual void set_Key(byte[] value) { }

}

