public class TriggerHurtNotChild : TriggerBase, IServerComponent, IHurtTrigger // TypeDefIndex: 10033
{
	public float DamagePerSecond; 
	public float DamageTickRate; 
	public float DamageDelay; 
	public DamageType damageType; 
	public bool ignoreNPC; 
	public float npcMultiplier; 
	public float resourceMultiplier; 
	public bool triggerHitImpacts; 
	public bool RequireUpAxis; 
	public BaseEntity SourceEntity; 
	public bool UseSourceEntityDamageMultiplier; 
	public bool ignoreAllVehicleMounted; 
	public float activationDelay; 


	public void .ctor() { }

}

