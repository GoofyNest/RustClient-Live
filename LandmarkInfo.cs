public class LandmarkInfo : MonoBehaviour // TypeDefIndex: 9960
{	// Fields
	[HeaderAttribute] // RVA: 0xAA570 Offset: 0xA9970 VA: 0x1800AA570
	public bool shouldDisplayOnMap; // 0x18
	public bool isLayerSpecific; // 0x19
	public Translate.Phrase displayPhrase; // 0x20
	public Sprite mapIcon; // 0x28

	// Properties
	public virtual MapLayer MapLayer { get; }

	// Methods

	// RVA: 0x513D90 Offset: 0x513190 VA: 0x180513D90 Slot: 4
	public virtual MapLayer get_MapLayer() { }

	// RVA: 0x6BC020 Offset: 0x6BB420 VA: 0x1806BC020 Slot: 5
	protected virtual void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

