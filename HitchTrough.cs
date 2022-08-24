public class HitchTrough : StorageContainer // TypeDefIndex: 8697
{
	public HitchTrough.HitchSpot[] hitchSpots; 
	public float caloriesToDecaySeconds; 


public override void Load(BaseNetworkable.LoadInfo info) { }

public void .ctor() { }

}

public class HitchTrough.HitchSpot // TypeDefIndex: 8698
{
	public HitchTrough owner; 
	public Transform spot; 
	public EntityRef horse; 


public RidableHorse GetHorse(bool isServer = True) { }

public bool IsOccupied(bool isServer = True) { }

public void SetOccupiedBy(RidableHorse newHorse) { }

public void .ctor() { }

}

