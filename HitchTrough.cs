public class HitchTrough : StorageContainer // TypeDefIndex: 8697
{	public HitchTrough.HitchSpot[] hitchSpots; // 0x3D0
	public float caloriesToDecaySeconds; // 0x3D8


	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

}

public class HitchTrough.HitchSpot // TypeDefIndex: 8698
{	public HitchTrough owner; // 0x10
	public Transform spot; // 0x18
	public EntityRef horse; // 0x20


	public RidableHorse GetHorse(bool isServer = True) { }

	public bool IsOccupied(bool isServer = True) { }

	public void SetOccupiedBy(RidableHorse newHorse) { }

	public void .ctor() { }

}

