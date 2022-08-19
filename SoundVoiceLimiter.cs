public class SoundVoiceLimiter : MonoBehaviour, IClientComponent // TypeDefIndex: 9045
{	// Fields
	public int maxSimultaneousSounds; // 0x18
	private List<Sound> sounds; // 0x20

	// Methods

	// RVA: 0xA78960 Offset: 0xA77D60 VA: 0x180A78960
	public void EnforceSoundLimit() { }

	// RVA: 0xA78900 Offset: 0xA77D00 VA: 0x180A78900
	public void AddSound(Sound sound) { }

	// RVA: 0xA78B60 Offset: 0xA77F60 VA: 0x180A78B60
	public void RemoveSound(Sound sound) { }

	// RVA: 0xA78BC0 Offset: 0xA77FC0 VA: 0x180A78BC0
	public void .ctor() { }

}

