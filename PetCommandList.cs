public class PetCommandList : PrefabAttribute // TypeDefIndex: 11183
{
	public List<PetCommandList.PetCommandDesc> Commands;


	protected override Type GetIndexedType() { }

	public List<PetCommandList.PetCommandDesc> GetCommandDescriptions() { }

	public void .ctor() { }

}

public struct PetCommandList.PetCommandDesc // TypeDefIndex: 11184
{
	public PetCommandType CommandType;
	public Translate.Phrase Title;
	public Translate.Phrase Description;
	public Sprite Icon;
	public int CommandIndex;
	public bool Raycast;
	public int CommandWheelOrder;

}

