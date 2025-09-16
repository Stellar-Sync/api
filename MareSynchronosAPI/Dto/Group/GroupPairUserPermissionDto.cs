using StellarSync.API.Data;
using StellarSync.API.Data.Enum;
using MessagePack;

namespace StellarSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);