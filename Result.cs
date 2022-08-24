public enum Result // TypeDefIndex: 5135
{
	public int value__; 
public const Result None = 0;
public const Result OK = 1;
public const Result Fail = 2;
public const Result NoConnection = 3;
public const Result InvalidPassword = 5;
public const Result LoggedInElsewhere = 6;
public const Result InvalidProtocolVer = 7;
public const Result InvalidParam = 8;
public const Result FileNotFound = 9;
public const Result Busy = 10;
public const Result InvalidState = 11;
public const Result InvalidName = 12;
public const Result InvalidEmail = 13;
public const Result DuplicateName = 14;
public const Result AccessDenied = 15;
public const Result Timeout = 16;
public const Result Banned = 17;
public const Result AccountNotFound = 18;
public const Result InvalidSteamID = 19;
public const Result ServiceUnavailable = 20;
public const Result NotLoggedOn = 21;
public const Result Pending = 22;
public const Result EncryptionFailure = 23;
public const Result InsufficientPrivilege = 24;
public const Result LimitExceeded = 25;
public const Result Revoked = 26;
public const Result Expired = 27;
public const Result AlreadyRedeemed = 28;
public const Result DuplicateRequest = 29;
public const Result AlreadyOwned = 30;
public const Result IPNotFound = 31;
public const Result PersistFailed = 32;
public const Result LockingFailed = 33;
public const Result LogonSessionReplaced = 34;
public const Result ConnectFailed = 35;
public const Result HandshakeFailed = 36;
public const Result IOFailure = 37;
public const Result RemoteDisconnect = 38;
public const Result ShoppingCartNotFound = 39;
public const Result Blocked = 40;
public const Result Ignored = 41;
public const Result NoMatch = 42;
public const Result AccountDisabled = 43;
public const Result ServiceReadOnly = 44;
public const Result AccountNotFeatured = 45;
public const Result AdministratorOK = 46;
public const Result ContentVersion = 47;
public const Result TryAnotherCM = 48;
public const Result PasswordRequiredToKickSession = 49;
public const Result AlreadyLoggedInElsewhere = 50;
public const Result Suspended = 51;
public const Result Cancelled = 52;
public const Result DataCorruption = 53;
public const Result DiskFull = 54;
public const Result RemoteCallFailed = 55;
public const Result PasswordUnset = 56;
public const Result ExternalAccountUnlinked = 57;
public const Result PSNTicketInvalid = 58;
public const Result ExternalAccountAlreadyLinked = 59;
public const Result RemoteFileConflict = 60;
public const Result IllegalPassword = 61;
public const Result SameAsPreviousValue = 62;
public const Result AccountLogonDenied = 63;
public const Result CannotUseOldPassword = 64;
public const Result InvalidLoginAuthCode = 65;
public const Result AccountLogonDeniedNoMail = 66;
public const Result HardwareNotCapableOfIPT = 67;
public const Result IPTInitError = 68;
public const Result ParentalControlRestricted = 69;
public const Result FacebookQueryError = 70;
public const Result ExpiredLoginAuthCode = 71;
public const Result IPLoginRestrictionFailed = 72;
public const Result AccountLockedDown = 73;
public const Result AccountLogonDeniedVerifiedEmailRequired = 74;
public const Result NoMatchingURL = 75;
public const Result BadResponse = 76;
public const Result RequirePasswordReEntry = 77;
public const Result ValueOutOfRange = 78;
public const Result UnexpectedError = 79;
public const Result Disabled = 80;
public const Result InvalidCEGSubmission = 81;
public const Result RestrictedDevice = 82;
public const Result RegionLocked = 83;
public const Result RateLimitExceeded = 84;
public const Result AccountLoginDeniedNeedTwoFactor = 85;
public const Result ItemDeleted = 86;
public const Result AccountLoginDeniedThrottle = 87;
public const Result TwoFactorCodeMismatch = 88;
public const Result TwoFactorActivationCodeMismatch = 89;
public const Result AccountAssociatedToMultiplePartners = 90;
public const Result NotModified = 91;
public const Result NoMobileDevice = 92;
public const Result TimeNotSynced = 93;
public const Result SmsCodeFailed = 94;
public const Result AccountLimitExceeded = 95;
public const Result AccountActivityLimitExceeded = 96;
public const Result PhoneActivityLimitExceeded = 97;
public const Result RefundToWallet = 98;
public const Result EmailSendFailure = 99;
public const Result NotSettled = 100;
public const Result NeedCaptcha = 101;
public const Result GSLTDenied = 102;
public const Result GSOwnerDenied = 103;
public const Result InvalidItemType = 104;
public const Result IPBanned = 105;
public const Result GSLTExpired = 106;
public const Result InsufficientFunds = 107;
public const Result TooManyPending = 108;
public const Result NoSiteLicensesFound = 109;
public const Result WGNetworkSendExceeded = 110;
public const Result AccountNotFriends = 111;
public const Result LimitedUserAccount = 112;
public const Result CantRemoveItem = 113;
public const Result AccountDeleted = 114;
public const Result ExistingUserCancelledLicense = 115;
public const Result CommunityCooldown = 116;
public const Result NoLauncherSpecified = 117;
public const Result MustAgreeToSSA = 118;
public const Result LauncherMigrated = 119;
public const Result SteamRealmMismatch = 120;
public const Result InvalidSignature = 121;
public const Result ParseFailure = 122;
public const Result NoVerifiedPhone = 123;

}

public class Result.Entry<T> // TypeDefIndex: 6261
{
	public T Content; 
	public string Id; 
	public DateTime Created; 
	public DateTime Updated; 
	public string AuthorId; 
	public string AuthorName; 
	public string AuthType; 


public void .ctor() { }
/* GenericInstMethod :
|
|-Result.Entry<object>..ctor
*/

}

