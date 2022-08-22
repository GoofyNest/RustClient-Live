public class BaseFirework : BaseCombatEntity, IIgniteable // TypeDefIndex: 8271
{	public float fuseLength; // 0x240
	public float activityLength; // 0x244
	public const BaseEntity.Flags Flag_Spent = 65536;
	public float corpseDuration; // 0x248
	public bool limitActiveCount; // 0x24C


	public bool IsLit() { }

	public bool IsExhausted() { }

	public override bool CanPickup(BasePlayer player) { }

	public void .ctor() { }

}

