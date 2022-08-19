public sealed class WaitUntil : CustomYieldInstruction // TypeDefIndex: 3542
{	// Fields
	private Func<bool> m_Predicate; // 0x10

	// Properties
	public override bool keepWaiting { get; }

	// Methods

	// RVA: 0x2181700 Offset: 0x2180B00 VA: 0x182181700 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x805E80 Offset: 0x805280 VA: 0x180805E80
	public void .ctor(Func<bool> predicate) { }

}

