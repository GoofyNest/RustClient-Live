public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 3511
{	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0xB372A0 Offset: 0xB366A0 VA: 0x180B372A0 Slot: 5
	public object get_Current() { }

	// RVA: 0x829900 Offset: 0x828D00 VA: 0x180829900 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public void Reset() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

