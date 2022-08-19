public class CardGameSounds : PrefabAttribute // TypeDefIndex: 9579
{	// Fields
	public SoundDefinition ChipsSfx; // 0x98
	public SoundDefinition DrawSfx; // 0xA0
	public SoundDefinition PlaySfx; // 0xA8
	public SoundDefinition ShuffleSfx; // 0xB0
	public SoundDefinition WinSfx; // 0xB8
	public SoundDefinition YourTurnSfx; // 0xC0
	public SoundDefinition CheckSfx; // 0xC8

	// Methods

	// RVA: 0x7179D0 Offset: 0x716DD0 VA: 0x1807179D0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x717A30 Offset: 0x716E30 VA: 0x180717A30
	public void PlaySound(CardGameSounds.SoundType sound, GameObject forGameObject) { }

	// RVA: 0x717B60 Offset: 0x716F60 VA: 0x180717B60
	public void .ctor() { }

}

public enum CardGameSounds.SoundType // TypeDefIndex: 9580
{	// Fields
	public int value__; // 0x0
	public const CardGameSounds.SoundType Chips = 0;
	public const CardGameSounds.SoundType Draw = 1;
	public const CardGameSounds.SoundType Play = 2;
	public const CardGameSounds.SoundType Shuffle = 3;
	public const CardGameSounds.SoundType Win = 4;
	public const CardGameSounds.SoundType YourTurn = 5;
	public const CardGameSounds.SoundType Check = 6;

}

