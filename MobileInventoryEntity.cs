public class MobileInventoryEntity : BaseEntity // TypeDefIndex: 9453
{
	public SoundDefinition ringingLoop; 
	public SoundDefinition silentLoop; 
	public const BaseEntity.Flags Ringing = 128;
	public static BaseEntity.Flags Flag_Silent; 
	private Sound ringingSound; 


	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private SoundDefinition GetRingSound() { }

	public void .ctor() { }

	private static void .cctor() { }

}

