public class CinematicEntity : BaseEntity // TypeDefIndex: 9274
{	// Fields
	private const BaseEntity.Flags HideMesh = 128;
	public GameObject[] DisableObjects; // 0x168
	private static List<CinematicEntity> clientList; // 0x0
	public static Nullable<bool> demoOverride; // 0x8

	// Methods

	// RVA: 0x554D50 Offset: 0x554150 VA: 0x180554D50 Slot: 13
	public override void ClientOnEnable() { }

	[ClientVar] // RVA: 0xE6820 Offset: 0xE5C20 VA: 0x1800E6820
	// RVA: 0x554E90 Offset: 0x554290 VA: 0x180554E90
	public static void DemoHideObjects(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x555320 Offset: 0x554720 VA: 0x180555320
	public static void RemoveDemoOverride() { }

	// RVA: 0x555080 Offset: 0x554480 VA: 0x180555080 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x5551D0 Offset: 0x5545D0 VA: 0x1805551D0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x5554F0 Offset: 0x5548F0 VA: 0x1805554F0
	private void ToggleObjects(bool state) { }

	// RVA: 0x555650 Offset: 0x554A50 VA: 0x180555650
	public void .ctor() { }

	// RVA: 0x5555D0 Offset: 0x5549D0 VA: 0x1805555D0
	private static void .cctor() { }

}

