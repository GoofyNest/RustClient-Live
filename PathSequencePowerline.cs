public class PathSequencePowerline : PathSequence // TypeDefIndex: 10365
{	// Fields
	public PathSequencePowerline.SequenceRule Rule; // 0x98
	private const int RegularPowerlineSpacing = 2;

	// Methods

	// RVA: 0x946440 Offset: 0x945840 VA: 0x180946440 Slot: 8
	public override void ApplySequenceReplacement(List<Prefab> sequence, ref Prefab replacement, Prefab[] possibleReplacements, int pathLength, int pathIndex) { }

	// RVA: 0x9467F0 Offset: 0x945BF0 VA: 0x1809467F0
	private Prefab GetPrefabOfType(Prefab[] options, PathSequencePowerline.SequenceRule ruleToFind) { }

	// RVA: 0x946680 Offset: 0x945A80 VA: 0x180946680
	private int GetIndexCountToRule(List<Prefab> sequence, PathSequencePowerline.SequenceRule rule) { }

	// RVA: 0x946960 Offset: 0x945D60 VA: 0x180946960
	public void .ctor() { }

}

public enum PathSequencePowerline.SequenceRule // TypeDefIndex: 10366
{	// Fields
	public int value__; // 0x0
	public const PathSequencePowerline.SequenceRule PowerlinePlatform = 0;
	public const PathSequencePowerline.SequenceRule Powerline = 1;

}

