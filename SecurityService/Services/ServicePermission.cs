using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService.Services
{
    internal class ServicePermission
    {
        //public async Task CreateAsync(PermissionCreateVm view)
        //{
        //    // mapping

        //    var model = new Permission()
        //    {
        //        UserId = view.UserId,
        //        RoleId = view.RoleId,
        //    };

        //    // database

        //    await using var context = new DbContextPortal();
        //    await context.Permissions.AddAsync(model);
        //    await context.SaveChangesAsync();
        //}
        //public async Task DeleteAsync(PermissionDeleteVm view)
        //{
        //    // database
        //    await using var context = new DbContextPortal();
        //    var model = await context.Permissions
        //        .SingleOrDefaultAsync(p => p.UserId == view.UserId & p.RoleId == view.RoleId);
        //    // validation
        //    if (model == null) throw new ArgumentNullException(nameof(model));
        //    context.Permissions.Remove(model);
        //    await context.SaveChangesAsync();
        //}

        //public async Task<PermissionCreateVm> GetCreateAsync()
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var users = await context.Users
        //        .ToDictionaryAsync(
        //            p => p.Id.ToString(),
        //            p => $"{p.FirstName} {p.LastName}");

        //    var roles = await context.Roles
        //        .ToDictionaryAsync(
        //            p => p.Id.ToString(),
        //            p => p.Name);

        //    // mapping

        //    var model = await Task.Run(() => new PermissionCreateVm()
        //    {
        //        Users = users,
        //        Roles = roles,
        //    });

        //    return model;
        //}
        //public async Task<PermissionDeleteVm> GetDeleteAsync(int? userId, int? roleId)
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var model = await context.Permissions
        //        .Include(p => p.User)
        //        .Include(p => p.Role)
        //        .SingleOrDefaultAsync(p => p.UserId == userId & p.RoleId == roleId);

        //    if (model == null)
        //        throw new ArgumentNullException(nameof(model), "Permission has not found.");

        //    // mapping

        //    var view = new PermissionDeleteVm
        //    {
        //        UserId = model.UserId,
        //        RoleId = model.RoleId,
        //        UserName = $"{model.User.FirstName} {model.User.LastName}",
        //        RoleName = model.Role.Name,
        //    };

        //    return view;
        //}

        //public async Task<PermissionListVm> GetListAsync()
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var models = await context.Permissions
        //        .Include(p => p.User)
        //        .Include(p => p.Role)
        //        .AsNoTracking()
        //        .ToListAsync();

        //    // mapping

        //    var permissions = models.Select(model => new PermissionListEntryVm()
        //    {
        //        UserId = model.UserId,
        //        RoleId = model.RoleId,
        //        UserName = $"{model.User.FirstName} {model.User.LastName}",
        //        RoleName = model.Role.Name,
        //    })
        //        .ToList();

        //    var view = new PermissionListVm() { Permissions = permissions };

        //    return view;
        //}



        //public async Task<PermissionAddRoleVm> GetAddRoles(int? userId)
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var user = await context.Users
        //        .SingleOrDefaultAsync(p => p.Id == userId);

        //    var existroles = await context.Roles
        //        .Where(p => p.Permissions.Any(t => t.UserId == userId))
        //        .ToListAsync();

        //    var roles = await context.Roles
        //        .Where(p => !existroles.Contains(p))
        //        .ToDictionaryAsync(
        //            p => p.Id.ToString(),
        //            p => p.Name);

        //    // mapping

        //    var model = await Task.Run(() => new PermissionAddRoleVm()
        //    {
        //        UserId = userId,
        //        UserName = $"{user.FirstName} {user.LastName}",
        //        Roles = roles,
        //    });

        //    return model;
        //}

        //public async Task AddRoles(PermissionAddRoleVm view)
        //{
        //    // mapping

        //    var models = view.RoleIds.Select(roleId => new Permission()
        //    {
        //        UserId = view.UserId,
        //        RoleId = roleId,
        //    });

        //    // database

        //    await using var context = new DbContextPortal();
        //    await context.Permissions.AddRangeAsync(models);
        //    await context.SaveChangesAsync();
        //}
    }
}
