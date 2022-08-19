public class ParticleSystemIK : MonoBehaviour, IClientComponent // TypeDefIndex: 11323
{	// Fields
	private ParticleSystem system; // 0x18
	private ParticleSystemIK.ParticleSystemIKJob job; // 0x20

	// Methods

	// RVA: 0x93B570 Offset: 0x93A970 VA: 0x18093B570
	private void Awake() { }

	// RVA: 0x93B6D0 Offset: 0x93AAD0 VA: 0x18093B6D0
	private void Update() { }

	// RVA: 0x93B5C0 Offset: 0x93A9C0 VA: 0x18093B5C0
	private void OnParticleUpdateJobScheduled() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public struct ParticleSystemIK.ParticleSystemIKJob : IJobParticleSystem // TypeDefIndex: 11324
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public Vector3 position; // 0x0
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public Vector3 forward; // 0xC
	[ReadOnlyAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public float deltaTime; // 0x18

	// Methods

	// RVA: 0xFA2F0 Offset: 0xF96F0 VA: 0x1800FA2F0 Slot: 4
	public void Execute(ParticleSystemJobData particles) { }

}

