public class SoundPlayerCull : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9040
{	// Fields
	public SoundPlayer soundPlayer; // 0x18
	public float cullDistance; // 0x20
	private LODCell cell; // 0x28

	// Methods

	// RVA: 0xA76240 Offset: 0xA75640 VA: 0x180A76240
	protected void OnEnable() { }

	// RVA: 0xA76190 Offset: 0xA75590 VA: 0x180A76190
	protected void OnDisable() { }

	// RVA: 0xA762C0 Offset: 0xA756C0 VA: 0x180A762C0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0xA76040 Offset: 0xA75440 VA: 0x180A76040 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0xA76340 Offset: 0xA75740 VA: 0x180A76340
	public void .ctor() { }

}

