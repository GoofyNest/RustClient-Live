public class TriggerHurtEx : TriggerBase, IServerComponent, IHurtTrigger // TypeDefIndex: 12444
{
	public float repeatRate; 
	[HeaderAttribute] 
	public List<DamageTypeEntry> damageOnEnter; 
	public GameObjectRef effectOnEnter; 
	public TriggerHurtEx.HurtType hurtTypeOnEnter; 
	[HeaderAttribute] 
	public List<DamageTypeEntry> damageOnTimer; 
	public GameObjectRef effectOnTimer; 
	public TriggerHurtEx.HurtType hurtTypeOnTimer; 
	[HeaderAttribute] 
	public List<DamageTypeEntry> damageOnMove; 
	public GameObjectRef effectOnMove; 
	public TriggerHurtEx.HurtType hurtTypeOnMove; 
	[HeaderAttribute] 
	public List<DamageTypeEntry> damageOnLeave; 
	public GameObjectRef effectOnLeave; 
	public TriggerHurtEx.HurtType hurtTypeOnLeave; 
	public bool damageEnabled; 


	public void .ctor() { }

}

public enum TriggerHurtEx.HurtType // TypeDefIndex: 12445
{
	public int value__; 
	public const TriggerHurtEx.HurtType Simple = 0;
	public const TriggerHurtEx.HurtType IncludeBleedingAndScreenShake = 1;

}

