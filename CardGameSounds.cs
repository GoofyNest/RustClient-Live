public class CardGameSounds : PrefabAttribute // TypeDefIndex: 11323
{
	public SoundDefinition ChipsSfx;
	public SoundDefinition DrawSfx;
	public SoundDefinition PlaySfx;
	public SoundDefinition ShuffleSfx;
	public SoundDefinition WinSfx;
	public SoundDefinition LoseSfx;
	public SoundDefinition YourTurnSfx;
	public SoundDefinition CheckSfx;
	public SoundDefinition HitSfx;
	public SoundDefinition StandSfx;
	public SoundDefinition BetSfx;
	public SoundDefinition IncreaseBetSfx;
	public SoundDefinition DecreaseBetSfx;
	public SoundDefinition AllInSfx;
	public SoundDefinition UIInteractSfx;
	[HeaderAttribute]
	public SoundDefinition DealerCoolSfx;
	public SoundDefinition DealerHappySfx;
	public SoundDefinition DealerLoveSfx;
	public SoundDefinition DealerSadSfx;
	public SoundDefinition DealerShockedSfx;


	protected override Type GetIndexedType() { }

	public void PlaySound(CardGameSounds.SoundType sound, GameObject forGameObject) { }

	public void .ctor() { }

}

public enum CardGameSounds.SoundType // TypeDefIndex: 11324
{
	public int value__;
	public const CardGameSounds.SoundType Chips = 0;
	public const CardGameSounds.SoundType Draw = 1;
	public const CardGameSounds.SoundType Play = 2;
	public const CardGameSounds.SoundType Shuffle = 3;
	public const CardGameSounds.SoundType Win = 4;
	public const CardGameSounds.SoundType YourTurn = 5;
	public const CardGameSounds.SoundType Check = 6;
	public const CardGameSounds.SoundType Hit = 7;
	public const CardGameSounds.SoundType Stand = 8;
	public const CardGameSounds.SoundType Bet = 9;
	public const CardGameSounds.SoundType IncreaseBet = 10;
	public const CardGameSounds.SoundType DecreaseBet = 11;
	public const CardGameSounds.SoundType AllIn = 12;
	public const CardGameSounds.SoundType UIInteract = 13;
	public const CardGameSounds.SoundType DealerCool = 14;
	public const CardGameSounds.SoundType DealerHappy = 15;
	public const CardGameSounds.SoundType DealerLove = 16;
	public const CardGameSounds.SoundType DealerSad = 17;
	public const CardGameSounds.SoundType DealerShocked = 18;

}

