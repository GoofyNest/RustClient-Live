public class MissionObjective : ScriptableObject // TypeDefIndex: 10225
{

	public void .ctor() { }

}

public class MissionObjective_AcquireItem : MissionObjective // TypeDefIndex: 10226
{
	public string itemShortname; 
	public int targetItemAmount; 


	public void .ctor() { }

}

public class MissionObjective_FreeCrate : MissionObjective // TypeDefIndex: 10227
{
	public int targetAmount; 


	public void .ctor() { }

}

public class MissionObjective_Harvest : MissionObjective // TypeDefIndex: 10228
{
	public string[] itemShortnames; 
	public int targetItemAmount; 


	public void .ctor() { }

}

public class MissionObjective_KillEntity : MissionObjective // TypeDefIndex: 10229
{
	public string[] targetPrefabIDs; 
	public int numToKill; 
	public bool shouldUpdateMissionLocation; 


	public void .ctor() { }

}

public class MissionObjective_Move : MissionObjective // TypeDefIndex: 10230
{
	public string positionName; 
	public float distForCompletion; 
	public bool use2D; 


	public void .ctor() { }

}

public class MissionObjective_SpeakWith : MissionObjective // TypeDefIndex: 10231
{
	public ItemAmount[] requiredReturnItems; 
	public bool destroyReturnItems; 


	public void .ctor() { }

}

