public class TriggerAchievement : TriggerBase // TypeDefIndex: 10016
{	// Fields
	public string statToIncrease; // 0x30
	public string achievementOnEnter; // 0x38
	public string requiredVehicleName; // 0x40
	[TooltipAttribute] // RVA: 0xAFFA0 Offset: 0xAF3A0 VA: 0x1800AFFA0
	public bool serverSide; // 0x48
	private List<ulong> triggeredPlayers; // 0x50

	// Methods

	// RVA: 0x9FE2A0 Offset: 0x9FD6A0 VA: 0x1809FE2A0
	public void OnPuzzleReset() { }

	// RVA: 0x9FE2A0 Offset: 0x9FD6A0 VA: 0x1809FE2A0
	public void Reset() { }

	// RVA: 0x9FDFB0 Offset: 0x9FD3B0 VA: 0x1809FDFB0 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x9FE0F0 Offset: 0x9FD4F0 VA: 0x1809FE0F0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x9FE2F0 Offset: 0x9FD6F0 VA: 0x1809FE2F0
	public void .ctor() { }

}

