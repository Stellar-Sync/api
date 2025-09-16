using StellarSync.API.Data;
using StellarSync.API.Data.Enum;
using MessagePack;

namespace StellarSync.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);