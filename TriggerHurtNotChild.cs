public class TriggerHurtNotChild : TriggerBase, IServerComponent, IHurtTrigger // TypeDefIndex: 10026
{	// Fields
	public float DamagePerSecond; // 0x30
	public float DamageTickRate; // 0x34
	public float DamageDelay; // 0x38
	public DamageType damageType; // 0x3C
	public bool ignoreNPC; // 0x40
	public float npcMultiplier; // 0x44
	public float resourceMultiplier; // 0x48
	public bool triggerHitImpacts; // 0x4C
	public bool RequireUpAxis; // 0x4D
	public BaseEntity SourceEntity; // 0x50
	public bool UseSourceEntityDamageMultiplier; // 0x58
	public bool ignoreAllVehicleMounted; // 0x59
	public float activationDelay; // 0x5C

	// Methods

	// RVA: 0xA00170 Offset: 0x9FF570 VA: 0x180A00170
	public void .ctor() { }

}

