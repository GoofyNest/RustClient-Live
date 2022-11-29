public class SceneToPrefabTag : MonoBehaviour, IEditorComponent // TypeDefIndex: 11732
{
	public SceneToPrefabTag.TagType Type; 
	public int SpecificLOD; 


	public void .ctor() { }

}

public enum SceneToPrefabTag.TagType // TypeDefIndex: 11733
{
	public int value__; 
	public const SceneToPrefabTag.TagType ForceInclude = 0;
	public const SceneToPrefabTag.TagType ForceExclude = 1;
	public const SceneToPrefabTag.TagType SingleMaterial = 2;
	public const SceneToPrefabTag.TagType UseSpecificLOD = 3;

}

