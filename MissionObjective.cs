public class MissionObjective : ScriptableObject // TypeDefIndex: 11965
{

	public void .ctor() { }

}

public class MissionObjective_AcquireItem : MissionObjective // TypeDefIndex: 11966
{
	public string itemShortname; 
	public int targetItemAmount; 


	public void .ctor() { }

}

public class MissionObjective_FreeCrate : MissionObjective // TypeDefIndex: 11967
{
	public int targetAmount; 


	public void .ctor() { }

}

public class MissionObjective_Harvest : MissionObjective // TypeDefIndex: 11968
{
	public string[] itemShortnames; 
	public int targetItemAmount; 


	public void .ctor() { }

}

public class MissionObjective_KillEntity : MissionObjective // TypeDefIndex: 11969
{
	public string[] targetPrefabIDs; 
	public int numToKill; 
	public bool shouldUpdateMissionLocation; 


	public void .ctor() { }

}

public class MissionObjective_Move : MissionObjective // TypeDefIndex: 11970
{
	public string positionName; 
	public float distForCompletion; 
	public bool use2D; 


	public void .ctor() { }

}

public class MissionObjective_SpeakWith : MissionObjective // TypeDefIndex: 11971
{
	public ItemAmount[] requiredReturnItems; 
	public bool destroyReturnItems; 


	public void .ctor() { }

}

