using StellarSync.API.Data;
using StellarSync.API.Data.Enum;
using MessagePack;

namespace StellarSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserIndividualPairStatusDto(UserData User, IndividualPairStatus IndividualPairStatus) : UserDto(User);