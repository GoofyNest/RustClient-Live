public class MissionManifest : ScriptableObject // TypeDefIndex: 10213
{	public ScriptableObjectRef[] missionList; // 0x18
	public WorldPositionGenerator[] positionGenerators; // 0x20
	public static MissionManifest instance; // 0x0


	public static MissionManifest Get() { }

	public static BaseMission GetFromShortName(string shortname) { }

	public static BaseMission GetFromID(uint id) { }

	public void .ctor() { }

}

