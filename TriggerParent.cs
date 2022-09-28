public class TriggerParent : TriggerBase, IServerComponent // TypeDefIndex: 11710
{
	[TooltipAttribute] 
	[SerializeField] 
	private bool doClippingCheck; 
	[TooltipAttribute] 
	public BaseMountable associatedMountable; 
	[TooltipAttribute] 
	public bool parentMountedPlayers; 
	[TooltipAttribute] 
	public bool parentSleepers; 
	public bool ParentNPCPlayers; 
	[TooltipAttribute] 
	public bool overrideOtherTriggers; 
	public const int CLIP_CHECK_MASK = 1218511105;


	public void .ctor() { }

}

