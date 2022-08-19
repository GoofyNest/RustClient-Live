internal abstract class PrimeGeneratorBase // TypeDefIndex: 87
{	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x16432E0 Offset: 0x16426E0 VA: 0x1816432E0 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1643340 Offset: 0x1642740 VA: 0x181643340 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

public abstract class PrimeGeneratorBase // TypeDefIndex: 1770
{	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1ABC910 Offset: 0x1ABBD10 VA: 0x181ABC910 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1643340 Offset: 0x1642740 VA: 0x181643340 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

