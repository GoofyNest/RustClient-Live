public class TriggerParent : TriggerBase, IServerComponent // TypeDefIndex: 10035
{	[TooltipAttribute] // RVA: 0xB0000 Offset: 0xAF400 VA: 0x1800B0000
	[SerializeField] // RVA: 0xB0000 Offset: 0xAF400 VA: 0x1800B0000
	private bool doClippingCheck; // 0x30
	[TooltipAttribute] // RVA: 0xB0200 Offset: 0xAF600 VA: 0x1800B0200
	public BaseMountable associatedMountable; // 0x38
	[TooltipAttribute] // RVA: 0xB0270 Offset: 0xAF670 VA: 0x1800B0270
	public bool parentMountedPlayers; // 0x40
	[TooltipAttribute] // RVA: 0xB02D0 Offset: 0xAF6D0 VA: 0x1800B02D0
	public bool parentSleepers; // 0x41
	public bool ParentNPCPlayers; // 0x42
	[TooltipAttribute] // RVA: 0xB0440 Offset: 0xAF840 VA: 0x1800B0440
	public bool overrideOtherTriggers; // 0x43
	public const int CLIP_CHECK_MASK = 1218511105;


	public void .ctor() { }

}

