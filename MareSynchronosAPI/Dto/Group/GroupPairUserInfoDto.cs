using StellarSync.API.Data;
using StellarSync.API.Data.Enum;
using MessagePack;

namespace StellarSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserInfoDto(GroupData Group, UserData User, GroupPairUserInfo GroupUserInfo) : GroupPairDto(Group, User);