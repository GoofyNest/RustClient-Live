public class Alert // TypeDefIndex: 1736
{	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public AlertLevel get_Level() { }

	// RVA: 0xF86260 Offset: 0xF85660 VA: 0x180F86260
	public AlertDescription get_Description() { }

	// RVA: 0x1AA94E0 Offset: 0x1AA88E0 VA: 0x181AA94E0
	public void .ctor(AlertDescription description) { }

	// RVA: 0x1AA9580 Offset: 0x1AA8980 VA: 0x181AA9580
	private void inferAlertLevel() { }

	// RVA: 0x1AA9460 Offset: 0x1AA8860 VA: 0x181AA9460 Slot: 3
	public override string ToString() { }

}

