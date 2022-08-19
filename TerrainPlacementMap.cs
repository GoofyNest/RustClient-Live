public class TerrainPlacementMap : TerrainMap<bool> // TypeDefIndex: 10411
{	// Fields
	private bool isEnabled; // 0x48

	// Methods

	// RVA: 0x114BCA0 Offset: 0x114B0A0 VA: 0x18114BCA0 Slot: 4
	public override void Setup() { }

	// RVA: 0x114B710 Offset: 0x114AB10 VA: 0x18114B710 Slot: 5
	public override void PostSetup() { }

	// RVA: 0xA94D70 Offset: 0xA94170 VA: 0x180A94D70
	public void Enable() { }

	// RVA: 0xFD0260 Offset: 0xFCF660 VA: 0x180FD0260
	public void Disable() { }

	// RVA: 0x114B740 Offset: 0x114AB40 VA: 0x18114B740
	public void Reset() { }

	// RVA: 0x114B390 Offset: 0x114A790 VA: 0x18114B390
	public bool GetBlocked(Vector3 worldPos) { }

	// RVA: 0x114B2F0 Offset: 0x114A6F0 VA: 0x18114B2F0
	public bool GetBlocked(float normX, float normZ) { }

	// RVA: 0x114B550 Offset: 0x114A950 VA: 0x18114B550
	public bool GetBlocked(int x, int z) { }

	// RVA: 0x114B930 Offset: 0x114AD30 VA: 0x18114B930
	public void SetBlocked(Vector3 worldPos) { }

	// RVA: 0x114B870 Offset: 0x114AC70 VA: 0x18114B870
	public void SetBlocked(float normX, float normZ) { }

	// RVA: 0x114B8F0 Offset: 0x114ACF0 VA: 0x18114B8F0
	public void SetBlocked(int x, int z) { }

	// RVA: 0x114B5B0 Offset: 0x114A9B0 VA: 0x18114B5B0
	public bool GetBlocked(Vector3 worldPos, float radius) { }

	// RVA: 0x114B180 Offset: 0x114A580 VA: 0x18114B180
	public bool GetBlocked(float normX, float normZ, float radius) { }

	// RVA: 0x114BAD0 Offset: 0x114AED0 VA: 0x18114BAD0
	public void SetBlocked(Vector3 worldPos, float radius, float fade = 0) { }

	// RVA: 0x114B7B0 Offset: 0x114ABB0 VA: 0x18114B7B0
	public void SetBlocked(float normX, float normZ, float radius, float fade = 0) { }

	// RVA: 0x114BD90 Offset: 0x114B190 VA: 0x18114BD90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x114BD40 Offset: 0x114B140 VA: 0x18114BD40
	private void <SetBlocked>b__15_0(int x, int z, float lerp) { }

}

