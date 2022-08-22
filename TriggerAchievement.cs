public class TriggerAchievement : TriggerBase // TypeDefIndex: 10016
{	public string statToIncrease; // 0x30
	public string achievementOnEnter; // 0x38
	public string requiredVehicleName; // 0x40
	[TooltipAttribute] // RVA: 0xAFFA0 Offset: 0xAF3A0 VA: 0x1800AFFA0
	public bool serverSide; // 0x48
	private List<ulong> triggeredPlayers; // 0x50


	public void OnPuzzleReset() { }

	public void Reset() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	public void .ctor() { }

}

