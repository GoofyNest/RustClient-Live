public class HitchTrough : StorageContainer // TypeDefIndex: 8697
{	// Fields
	public HitchTrough.HitchSpot[] hitchSpots; // 0x3D0
	public float caloriesToDecaySeconds; // 0x3D8

	// Methods

	// RVA: 0x75B0C0 Offset: 0x75A4C0 VA: 0x18075B0C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x75B190 Offset: 0x75A590 VA: 0x18075B190
	public void .ctor() { }

}

public class HitchTrough.HitchSpot // TypeDefIndex: 8698
{	// Fields
	public HitchTrough owner; // 0x10
	public Transform spot; // 0x18
	public EntityRef horse; // 0x20

	// Methods

	// RVA: 0x75B010 Offset: 0x75A410 VA: 0x18075B010
	public RidableHorse GetHorse(bool isServer = True) { }

	// RVA: 0x75B0A0 Offset: 0x75A4A0 VA: 0x18075B0A0
	public bool IsOccupied(bool isServer = True) { }

	// RVA: 0x75B0B0 Offset: 0x75A4B0 VA: 0x18075B0B0
	public void SetOccupiedBy(RidableHorse newHorse) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

