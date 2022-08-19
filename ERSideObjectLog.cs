public class ERSideObjectLog : MonoBehaviour // TypeDefIndex: 7226
{	// Fields
	public List<SideObjectLog> QOQDQOOQDDQOOQ; // 0x18
	public List<int> ints; // 0x20
	public List<QDQDOOQQDQODD> roadPresets; // 0x28
	public List<CrossingCornerClass> crossingCornerPresets; // 0x30
	public List<ERSideWalk> sidewalkPresets; // 0x38
	public List<ERTexture> textureData; // 0x40
	public List<string> presetAssets; // 0x48
	public int logIndex; // 0x50
	public int updateInt; // 0x54

	// Methods

	// RVA: 0xA56560 Offset: 0xA55960 VA: 0x180A56560
	public void AddRoadPreset(List<SideObject> sceneSideObjects, List<SideObjectLog> projectSideObjects, QDQDOOQQDQODD sourcePreset) { }

	// RVA: 0xA56630 Offset: 0xA55A30 VA: 0x180A56630
	public void UpdateRoadPreset(QDQDOOQQDQODD sourcePreset, int element, List<SideObject> sceneSideObjects, List<SideObjectLog> projectSideObjects, bool copyShapeData) { }

	// RVA: 0xA58050 Offset: 0xA57450 VA: 0x180A58050
	public void UpdateTextureList(int element, Texture2D _texture, float _roadWidth, float _leftOffset, float _rightOffset, float _leftInnerOffset, float _rightInnerOffset) { }

	// RVA: 0xA581F0 Offset: 0xA575F0 VA: 0x180A581F0
	public void .ctor() { }

}

