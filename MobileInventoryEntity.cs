public class MobileInventoryEntity : BaseEntity // TypeDefIndex: 9449
{	public SoundDefinition ringingLoop; // 0x168
	public SoundDefinition silentLoop; // 0x170
	public const BaseEntity.Flags Ringing = 128;
	public static BaseEntity.Flags Flag_Silent; // 0x0
	private Sound ringingSound; // 0x178


	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private SoundDefinition GetRingSound() { }

	public void .ctor() { }

	private static void .cctor() { }

}

