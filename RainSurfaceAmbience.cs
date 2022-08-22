public class RainSurfaceAmbience : SingletonComponent<RainSurfaceAmbience>, IClientComponent // TypeDefIndex: 8979
{	public List<RainSurfaceAmbience.SurfaceSound> surfaces; // 0x18
	public GameObjectRef emitterPrefab; // 0x20
	public Dictionary<ParticlePatch, AmbienceEmitter> spawnedEmitters; // 0x28
	private Dictionary<PhysicMaterial, RainSurfaceAmbience.SurfaceSound> surfaceSoundsByMaterial; // 0x30


	protected override void Awake() { }

	public void ReadParticlePatchRaycastHit(bool didHit, RaycastHit raycastHit, ParticlePatch particlePatch) { }

	public void ParticlePatchDestroyingInstances(ParticlePatch particlePatch) { }

	private void DespawnEmitter(ParticlePatch particlePatch) { }

	private RainSurfaceAmbience.SurfaceSound FindSurfaceSound(PhysicMaterial physicMaterial) { }

	public void .ctor() { }

}

public class RainSurfaceAmbience.SurfaceSound // TypeDefIndex: 8980
{	public AmbienceDefinitionList baseAmbience; // 0x10
	public List<PhysicMaterial> materials; // 0x18


	public void .ctor() { }

}

