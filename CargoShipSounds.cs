public class CargoShipSounds : MonoBehaviour, IClientComponent // TypeDefIndex: 8289
{	public SoundDefinition waveSoundDef; // 0x18
	public AnimationCurve waveSoundYGainCurve; // 0x20
	public AnimationCurve waveSoundEdgeDistanceGainCurve; // 0x28
	private Sound waveSoundL; // 0x30
	private Sound waveSoundR; // 0x38
	private SoundModulation.Modulator waveSoundLGainMod; // 0x40
	private SoundModulation.Modulator waveSoundRGainMod; // 0x48
	public SoundDefinition sternWakeSoundDef; // 0x50
	private Sound sternWakeSound; // 0x58
	private SoundModulation.Modulator sternWakeSoundGainMod; // 0x60
	public SoundDefinition engineHumSoundDef; // 0x68
	private Sound engineHumSound; // 0x70
	public GameObject engineHumTarget; // 0x78
	public SoundDefinition hugeRumbleSoundDef; // 0x80
	public AnimationCurve hugeRumbleYDiffCurve; // 0x88
	public AnimationCurve hugeRumbleRelativeSpeedCurve; // 0x90
	private Sound hugeRumbleSound; // 0x98
	private SoundModulation.Modulator hugeRumbleGainMod; // 0xA0
	private Vector3 lastCameraPos; // 0xA8
	private Vector3 lastRumblePos; // 0xB4
	private Vector3 lastRumbleLocalPos; // 0xC0
	public Collider soundFollowCollider; // 0xD0
	public Collider soundFollowColliderL; // 0xD8
	public Collider soundFollowColliderR; // 0xE0
	public Collider sternSoundFollowCollider; // 0xE8
	private HashSet<CargoShipInteriorSoundTrigger> interiorSoundTriggers; // 0xF0


	public void UpdateSounds() { }

	public void InitSounds() { }

	public void InteriorTriggerEntered(CargoShipInteriorSoundTrigger trigger) { }

	public void InteriorTriggerExited(CargoShipInteriorSoundTrigger trigger) { }

	public void .ctor() { }

}

