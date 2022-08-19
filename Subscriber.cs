public class Subscriber : Pool.IPooled // TypeDefIndex: 6707
{	// Fields
	internal Manager manager; // 0x10
	internal Connection connection; // 0x18
	public ListHashSet<Group> subscribed; // 0x20

	// Methods

	// RVA: 0x220F580 Offset: 0x220E980 VA: 0x18220F580
	public Group Subscribe(Group group) { }

	// RVA: 0x220F540 Offset: 0x220E940 VA: 0x18220F540
	public Group Subscribe(uint group) { }

	// RVA: 0x220F4E0 Offset: 0x220E8E0 VA: 0x18220F4E0
	public bool IsSubscribed(Group group) { }

	// RVA: 0x220F670 Offset: 0x220EA70 VA: 0x18220F670
	public void UnsubscribeAll() { }

	// RVA: 0x220F7E0 Offset: 0x220EBE0 VA: 0x18220F7E0
	public void Unsubscribe(Group group) { }

	// RVA: 0x220F490 Offset: 0x220E890 VA: 0x18220F490
	public void Destroy() { }

	// RVA: 0x220F4A0 Offset: 0x220E8A0 VA: 0x18220F4A0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x220F870 Offset: 0x220EC70 VA: 0x18220F870
	public void .ctor() { }

}

