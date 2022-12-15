public enum AntiCheatClientViolationType // TypeDefIndex: 9825
{
	public int value__;
	public const AntiCheatClientViolationType Invalid = 0;
	public const AntiCheatClientViolationType IntegrityCatalogNotFound = 1;
	public const AntiCheatClientViolationType IntegrityCatalogError = 2;
	public const AntiCheatClientViolationType IntegrityCatalogCertificateRevoked = 3;
	public const AntiCheatClientViolationType IntegrityCatalogMissingMainExecutable = 4;
	public const AntiCheatClientViolationType GameFileMismatch = 5;
	public const AntiCheatClientViolationType RequiredGameFileNotFound = 6;
	public const AntiCheatClientViolationType UnknownGameFileForbidden = 7;
	public const AntiCheatClientViolationType SystemFileUntrusted = 8;
	public const AntiCheatClientViolationType ForbiddenModuleLoaded = 9;
	public const AntiCheatClientViolationType CorruptedMemory = 10;
	public const AntiCheatClientViolationType ForbiddenToolDetected = 11;
	public const AntiCheatClientViolationType InternalAntiCheatViolation = 12;
	public const AntiCheatClientViolationType CorruptedNetworkMessageFlow = 13;
	public const AntiCheatClientViolationType VirtualMachineNotAllowed = 14;
	public const AntiCheatClientViolationType ForbiddenSystemConfiguration = 15;

}

