public class ParticleSystemContainer : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 11321
{	// Fields
	public bool precached; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ParticleSystemContainer.ParticleSystemGroup[] particleGroups; // 0x20

	// Methods

	// RVA: 0x93A940 Offset: 0x939D40 VA: 0x18093A940
	public void Play() { }

	// RVA: 0x93A830 Offset: 0x939C30 VA: 0x18093A830
	public void Pause() { }

	// RVA: 0x93ADB0 Offset: 0x93A1B0 VA: 0x18093ADB0
	public void Stop() { }

	// RVA: 0x93A720 Offset: 0x939B20 VA: 0x18093A720
	public void Clear() { }

	// RVA: 0x93AC20 Offset: 0x93A020 VA: 0x18093AC20 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public struct ParticleSystemContainer.ParticleSystemGroup // TypeDefIndex: 11322
{	// Fields
	public ParticleSystem system; // 0x0
	public LODComponentParticleSystem[] lodComponents; // 0x8

}

