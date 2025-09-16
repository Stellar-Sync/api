using StellarSync.API.Data;
using StellarSync.API.Data.Enum;
using MessagePack;

namespace StellarSync.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
