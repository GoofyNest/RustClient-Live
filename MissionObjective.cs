public class MissionObjective : ScriptableObject // TypeDefIndex: 10218
{
	public void .ctor() { }

}

public class MissionObjective_AcquireItem : MissionObjective // TypeDefIndex: 10219
{	public string itemShortname; // 0x18
	public int targetItemAmount; // 0x20


	public void .ctor() { }

}

public class MissionObjective_FreeCrate : MissionObjective // TypeDefIndex: 10220
{	public int targetAmount; // 0x18


	public void .ctor() { }

}

public class MissionObjective_Harvest : MissionObjective // TypeDefIndex: 10221
{	public string[] itemShortnames; // 0x18
	public int targetItemAmount; // 0x20


	public void .ctor() { }

}

public class MissionObjective_KillEntity : MissionObjective // TypeDefIndex: 10222
{	public string[] targetPrefabIDs; // 0x18
	public int numToKill; // 0x20
	public bool shouldUpdateMissionLocation; // 0x24


	public void .ctor() { }

}

public class MissionObjective_Move : MissionObjective // TypeDefIndex: 10223
{	public string positionName; // 0x18
	public float distForCompletion; // 0x20
	public bool use2D; // 0x24


	public void .ctor() { }

}

public class MissionObjective_SpeakWith : MissionObjective // TypeDefIndex: 10224
{	public ItemAmount[] requiredReturnItems; // 0x18
	public bool destroyReturnItems; // 0x20


	public void .ctor() { }

}

