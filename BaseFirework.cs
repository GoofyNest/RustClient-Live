public class BaseFirework : BaseCombatEntity, IIgniteable // TypeDefIndex: 8271
{	// Fields
	public float fuseLength; // 0x240
	public float activityLength; // 0x244
	public const BaseEntity.Flags Flag_Spent = 65536;
	public float corpseDuration; // 0x248
	public bool limitActiveCount; // 0x24C

	// Methods

	// RVA: 0x7F7FF0 Offset: 0x7F73F0 VA: 0x1807F7FF0
	public bool IsLit() { }

	// RVA: 0x7FF8A0 Offset: 0x7FECA0 VA: 0x1807FF8A0
	public bool IsExhausted() { }

	// RVA: 0x7FF7F0 Offset: 0x7FEBF0 VA: 0x1807FF7F0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x7FF8B0 Offset: 0x7FECB0 VA: 0x1807FF8B0
	public void .ctor() { }

}

