public class RainSurfaceAmbience : SingletonComponent<RainSurfaceAmbience>, IClientComponent // TypeDefIndex: 8979
{	// Fields
	public List<RainSurfaceAmbience.SurfaceSound> surfaces; // 0x18
	public GameObjectRef emitterPrefab; // 0x20
	public Dictionary<ParticlePatch, AmbienceEmitter> spawnedEmitters; // 0x28
	private Dictionary<PhysicMaterial, RainSurfaceAmbience.SurfaceSound> surfaceSoundsByMaterial; // 0x30

	// Methods

	// RVA: 0x6A57C0 Offset: 0x6A4BC0 VA: 0x1806A57C0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x6A5BD0 Offset: 0x6A4FD0 VA: 0x1806A5BD0
	public void ReadParticlePatchRaycastHit(bool didHit, RaycastHit raycastHit, ParticlePatch particlePatch) { }

	// RVA: 0x6A5BC0 Offset: 0x6A4FC0 VA: 0x1806A5BC0
	public void ParticlePatchDestroyingInstances(ParticlePatch particlePatch) { }

	// RVA: 0x6A59F0 Offset: 0x6A4DF0 VA: 0x1806A59F0
	private void DespawnEmitter(ParticlePatch particlePatch) { }

	// RVA: 0x6A5B10 Offset: 0x6A4F10 VA: 0x1806A5B10
	private RainSurfaceAmbience.SurfaceSound FindSurfaceSound(PhysicMaterial physicMaterial) { }

	// RVA: 0x6A5FE0 Offset: 0x6A53E0 VA: 0x1806A5FE0
	public void .ctor() { }

}

public class RainSurfaceAmbience.SurfaceSound // TypeDefIndex: 8980
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x10
	public List<PhysicMaterial> materials; // 0x18

	// Methods

	// RVA: 0x6AC360 Offset: 0x6AB760 VA: 0x1806AC360
	public void .ctor() { }

}

