public class MusicChangeIntensity : MonoBehaviour // TypeDefIndex: 8999
{	// Fields
	public float raiseTo; // 0x18
	public List<MusicChangeIntensity.DistanceIntensity> distanceIntensities; // 0x20
	public float tickInterval; // 0x28
	private float lastTick; // 0x2C

	// Methods

	// RVA: 0x7BB240 Offset: 0x7BA640 VA: 0x1807BB240
	private void OnEnable() { }

	// RVA: 0x7BB5B0 Offset: 0x7BA9B0 VA: 0x1807BB5B0
	private void Update() { }

	// RVA: 0x7BB270 Offset: 0x7BA670 VA: 0x1807BB270
	private void Tick() { }

	// RVA: 0x7BB600 Offset: 0x7BAA00 VA: 0x1807BB600
	public void .ctor() { }

}

public class MusicChangeIntensity.DistanceIntensity // TypeDefIndex: 9000
{	// Fields
	public float distance; // 0x10
	public float raiseTo; // 0x14
	public bool forceStartMusicInSuppressedMusicZones; // 0x18

	// Methods

	// RVA: 0x7B3450 Offset: 0x7B2850 VA: 0x1807B3450
	public void .ctor() { }

}

