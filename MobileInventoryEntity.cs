public class MobileInventoryEntity : BaseEntity // TypeDefIndex: 9449
{	// Fields
	public SoundDefinition ringingLoop; // 0x168
	public SoundDefinition silentLoop; // 0x170
	public const BaseEntity.Flags Ringing = 128;
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private Sound ringingSound; // 0x178

	// Methods

	// RVA: 0x76A6C0 Offset: 0x769AC0 VA: 0x18076A6C0 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x76A640 Offset: 0x769A40 VA: 0x18076A640
	private SoundDefinition GetRingSound() { }

	// RVA: 0x76AA70 Offset: 0x769E70 VA: 0x18076AA70
	public void .ctor() { }

	// RVA: 0x76AA30 Offset: 0x769E30 VA: 0x18076AA30
	private static void .cctor() { }

}

