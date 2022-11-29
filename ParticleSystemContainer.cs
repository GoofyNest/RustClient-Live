public class ParticleSystemContainer : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 13105
{
	public bool precached; 
	[HideInInspector] 
	public ParticleSystemContainer.ParticleSystemGroup[] particleGroups; 


	public void Play() { }

	public void Pause() { }

	public void Stop() { }

	public void Clear() { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

public struct ParticleSystemContainer.ParticleSystemGroup // TypeDefIndex: 13106
{
	public ParticleSystem system; 
	public LODComponentParticleSystem[] lodComponents; 

}

