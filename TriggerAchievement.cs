public class TriggerAchievement : TriggerBase // TypeDefIndex: 11777
{
	public string statToIncrease;
	public string achievementOnEnter;
	public string requiredVehicleName;
	[TooltipAttribute]
	public bool serverSide;
	private List<ulong> triggeredPlayers;


	public void OnPuzzleReset() { }

	public void Reset() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	public void .ctor() { }

}

