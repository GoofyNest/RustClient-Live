public class MusicChangeIntensity : MonoBehaviour // TypeDefIndex: 8999
{	public float raiseTo; // 0x18
	public List<MusicChangeIntensity.DistanceIntensity> distanceIntensities; // 0x20
	public float tickInterval; // 0x28
	private float lastTick; // 0x2C


	private void OnEnable() { }

	private void Update() { }

	private void Tick() { }

	public void .ctor() { }

}

public class MusicChangeIntensity.DistanceIntensity // TypeDefIndex: 9000
{	public float distance; // 0x10
	public float raiseTo; // 0x14
	public bool forceStartMusicInSuppressedMusicZones; // 0x18


	public void .ctor() { }

}

