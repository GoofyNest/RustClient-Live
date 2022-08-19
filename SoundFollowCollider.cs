public class SoundFollowCollider : MonoBehaviour, IClientComponent // TypeDefIndex: 9031
{	// Fields
	public SoundDefinition soundDefinition; // 0x18
	public Sound sound; // 0x20
	public Bounds soundFollowBounds; // 0x28
	public bool startImmediately; // 0x40
	private bool soundPlaying; // 0x41

	// Methods

	// RVA: 0xA71190 Offset: 0xA70590 VA: 0x180A71190
	private void Awake() { }

	// RVA: 0xA71240 Offset: 0xA70640 VA: 0x180A71240
	public void StartSound() { }

	// RVA: 0xA71250 Offset: 0xA70650 VA: 0x180A71250
	public void StopSound() { }

	// RVA: 0xA71260 Offset: 0xA70660 VA: 0x180A71260
	private void Update() { }

	// RVA: 0xA711A0 Offset: 0xA705A0 VA: 0x180A711A0
	private void FadeOutSound() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

