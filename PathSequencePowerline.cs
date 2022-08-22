public class PathSequencePowerline : PathSequence // TypeDefIndex: 10365
{	public PathSequencePowerline.SequenceRule Rule; // 0x98
	private const int RegularPowerlineSpacing = 2;


	public override void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	private Prefab GetPrefabOfType(Prefab[] options, PathSequencePowerline.SequenceRule ruleToFind) { }

	private int GetIndexCountToRule(List<Prefab> sequence, PathSequencePowerline.SequenceRule rule) { }

	public void .ctor() { }

}

public enum PathSequencePowerline.SequenceRule // TypeDefIndex: 10366
{	public int value__; // 0x0
	public const PathSequencePowerline.SequenceRule PowerlinePlatform = 0;
	public const PathSequencePowerline.SequenceRule Powerline = 1;

}

