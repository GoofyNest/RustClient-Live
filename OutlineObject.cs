public class OutlineObject : MonoBehaviour, IClientComponent // TypeDefIndex: 10093
{	// Fields
	public Mesh[] meshes; // 0x18
	public Transform[] meshTransforms; // 0x20
	private Collider _col; // 0x28

	// Methods

	// RVA: 0xA4D250 Offset: 0xA4C650 VA: 0x180A4D250 Slot: 4
	public virtual float SampleVisibility() { }

	// RVA: 0xA4D130 Offset: 0xA4C530 VA: 0x180A4D130
	public Collider GetCollider() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public virtual void BecomeVisible() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	public virtual void BecomeInvisible() { }

	// RVA: 0xA4D220 Offset: 0xA4C620 VA: 0x180A4D220 Slot: 7
	public virtual Color GetColor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public virtual void Registered() { }

	// RVA: 0xA4D510 Offset: 0xA4C910 VA: 0x180A4D510 Slot: 9
	public virtual bool ShouldDisplay() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

