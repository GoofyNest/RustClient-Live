public class ImageEffectBase : MonoBehaviour // TypeDefIndex: 8191
{	// Fields
	public Shader shader; // 0x18
	private Material m_Material; // 0x20

	// Properties
	protected Material material { get; }

	// Methods

	// RVA: 0x21DB980 Offset: 0x21DAD80 VA: 0x1821DB980 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x21DBA20 Offset: 0x21DAE20 VA: 0x1821DBA20
	protected Material get_material() { }

	// RVA: 0x21DB8F0 Offset: 0x21DACF0 VA: 0x1821DB8F0 Slot: 5
	protected virtual void OnDisable() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

