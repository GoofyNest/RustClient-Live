internal class BitStack // TypeDefIndex: 1830
{	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x12DD510 Offset: 0x12DC910 VA: 0x1812DD510
	public void .ctor() { }

	// RVA: 0x12DD300 Offset: 0x12DC700 VA: 0x1812DD300
	public void PushBit(bool bit) { }

	// RVA: 0x12DD240 Offset: 0x12DC640 VA: 0x1812DD240
	public bool PopBit() { }

	// RVA: 0x12DD230 Offset: 0x12DC630 VA: 0x1812DD230
	public bool PeekBit() { }

	// RVA: 0x12DD420 Offset: 0x12DC820 VA: 0x1812DD420
	private void PushCurr() { }

	// RVA: 0x12DD2B0 Offset: 0x12DC6B0 VA: 0x1812DD2B0
	private void PopCurr() { }

}

