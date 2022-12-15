public class BaseFirework : BaseCombatEntity, IIgniteable // TypeDefIndex: 9989
{
	public float fuseLength;
	public float activityLength;
	public const BaseEntity.Flags Flag_Spent = 65536;
	public float corpseDuration;
	public bool limitActiveCount;


	public bool IsLit() { }

	public bool IsExhausted() { }

	public override bool CanPickup(BasePlayer player) { }

	public void .ctor() { }

}

