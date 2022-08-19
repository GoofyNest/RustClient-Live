public class SprayCanViewmodel : MonoBehaviour, IAnimationEventReceiver // TypeDefIndex: 8882
{	// Fields
	public ParticleSystem Particles; // 0x18
	public SoundDefinition sprayLoopDef; // 0x20
	private Sound sprayLoop; // 0x28

	// Methods

	// RVA: 0xA7F0A0 Offset: 0xA7E4A0 VA: 0x180A7F0A0
	public void SetSprayColour(Color c) { }

	// RVA: 0xA7F180 Offset: 0xA7E580 VA: 0x180A7F180
	public void ToggleSpray(bool state) { }

	// RVA: 0xA7F000 Offset: 0xA7E400 VA: 0x180A7F000
	private void OnDisable() { }

	// RVA: 0xA7EF70 Offset: 0xA7E370 VA: 0x180A7EF70 Slot: 4
	public void OnAnimationEvent(string eventName) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

