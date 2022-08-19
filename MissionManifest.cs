public class MissionManifest : ScriptableObject // TypeDefIndex: 10213
{	// Fields
	public ScriptableObjectRef[] missionList; // 0x18
	public WorldPositionGenerator[] positionGenerators; // 0x20
	public static MissionManifest instance; // 0x0

	// Methods

	// RVA: 0x765E00 Offset: 0x765200 VA: 0x180765E00
	public static MissionManifest Get() { }

	// RVA: 0x765CE0 Offset: 0x7650E0 VA: 0x180765CE0
	public static BaseMission GetFromShortName(string shortname) { }

	// RVA: 0x765BD0 Offset: 0x764FD0 VA: 0x180765BD0
	public static BaseMission GetFromID(uint id) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

