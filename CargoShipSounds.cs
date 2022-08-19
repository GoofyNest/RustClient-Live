public class CargoShipSounds : MonoBehaviour, IClientComponent // TypeDefIndex: 8289
{	// Fields
	public SoundDefinition waveSoundDef; // 0x18
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

	// Methods

	// RVA: 0x544010 Offset: 0x543410 VA: 0x180544010
	public void UpdateSounds() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void InitSounds() { }

	// RVA: 0x543F50 Offset: 0x543350 VA: 0x180543F50
	public void InteriorTriggerEntered(CargoShipInteriorSoundTrigger trigger) { }

	// RVA: 0x543FB0 Offset: 0x5433B0 VA: 0x180543FB0
	public void InteriorTriggerExited(CargoShipInteriorSoundTrigger trigger) { }

	// RVA: 0x545520 Offset: 0x544920 VA: 0x180545520
	public void .ctor() { }

}

