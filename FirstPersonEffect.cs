public class FirstPersonEffect : MonoBehaviour, IEffect, IPrefabPreProcess // TypeDefIndex: 9347
{	// Fields
	public bool isGunShot; // 0x18
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public EffectParentToWeaponBone parentToWeaponComponent; // 0x20

	// Methods

	// RVA: 0x7889F0 Offset: 0x787DF0 VA: 0x1807889F0
	private BaseViewModel GetViewModel(Effect effect) { }

	// RVA: 0x7893E0 Offset: 0x7887E0 VA: 0x1807893E0 Slot: 6
	public virtual void SetupEffect(Effect effect) { }

	// RVA: 0x789080 Offset: 0x788480 VA: 0x180789080
	private void MakeThirdPerson() { }

	// RVA: 0x788E30 Offset: 0x788230 VA: 0x180788E30
	private void MakeFirstPerson() { }

	// RVA: 0x789380 Offset: 0x788780 VA: 0x180789380 Slot: 5
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

