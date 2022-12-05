public class RainSurfaceAmbience : SingletonComponent<RainSurfaceAmbience>, IClientComponent // TypeDefIndex: 10711
{
	public List<RainSurfaceAmbience.SurfaceSound> surfaces;
	public GameObjectRef emitterPrefab;
	public Dictionary<ParticlePatch, AmbienceEmitter> spawnedEmitters;
	private Dictionary<PhysicMaterial, RainSurfaceAmbience.SurfaceSound> surfaceSoundsByMaterial;


	protected override void Awake() { }

	public void ReadParticlePatchRaycastHit(bool didHit, RaycastHit raycastHit, ParticlePatch particlePatch) { }

	public void ParticlePatchDestroyingInstances(ParticlePatch particlePatch) { }

	private void DespawnEmitter(ParticlePatch particlePatch) { }

	private RainSurfaceAmbience.SurfaceSound FindSurfaceSound(PhysicMaterial physicMaterial) { }

	public void .ctor() { }

}

public class RainSurfaceAmbience.SurfaceSound // TypeDefIndex: 10712
{
	public AmbienceDefinitionList baseAmbience;
	public List<PhysicMaterial> materials;


	public void .ctor() { }

}

