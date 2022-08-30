using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityService.Services
{
    internal class ServiceRole
    {
        //public async Task CreateAsync(RoleCreateVm view)
        //{
        //    // validation 

        //    // mapping

        //    var model = new Role()
        //    {
        //        Name = view.Name,
        //    };

        //    // database

        //    await using var context = new DbContextPortal();
        //    await context.Roles.AddAsync(model);
        //    await context.SaveChangesAsync();
        //}
        //public async Task UpdateAsync(RoleUpdateVm view)
        //{
        //    // database

        //    await using var context = new DbContextPortal();
        //    var model = await context.Roles.FindAsync(view.Id);

        //    // validation 

        //    if (model == null)
        //        throw new ArgumentNullException(nameof(model),
        //            $"The role {view.Id} has not been found.");

        //    // mapping

        //    model.Name = view.Name;

        //    // database

        //    context.Entry(model).State = EntityState.Modified;
        //    await context.SaveChangesAsync();
        //}
        //public async Task DeleteAsync(RoleDeleteVm view)
        //{
        //    // database
        //    await using var context = new DbContextPortal();
        //    var model = await context.Roles.FindAsync(view.Id);
        //    context.Roles.Remove(model);
        //    await context.SaveChangesAsync();
        //}

        //public async Task<RoleCreateVm> GetCreateAsync()
        //{
        //    // mapping

        //    var model = await Task.Run(() => new RoleCreateVm());

        //    return model;
        //}
        //public async Task<RoleUpdateVm> GetUpdateAsync(int? id)
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var model = await context.Roles
        //        .SingleOrDefaultAsync(p => p.Id == id);

        //    if (model == null) throw new ArgumentNullException(nameof(model));

        //    // mapping

        //    var view = new RoleUpdateVm
        //    {
        //        Name = model.Name,
        //    };

        //    return view;
        //}
        //public async Task<RoleDeleteVm> GetDeleteAsync(int? id)
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var model = await context.Roles
        //        .SingleOrDefaultAsync(p => p.Id == id);

        //    if (model == null) throw new ArgumentNullException(nameof(model));

        //    // mapping

        //    var view = new RoleDeleteVm
        //    {
        //        Id = model.Id,
        //        Name = model.Name,
        //    };

        //    return view;
        //}

        //public async Task<RoleListVm> GetListAsync()
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var models = await context.Roles
        //        .AsNoTracking()
        //        .ToListAsync();

        //    // mapping

        //    var roles = models.Select(model => new RoleListEntryVm()
        //    {
        //        Id = model.Id,
        //        Name = model.Name,
        //    })
        //        .ToList();

        //    var view = new RoleListVm() { Roles = roles };

        //    return view;
        //}
        //public async Task<RoleDetailsVm> GetDetailsAsync(int? id)
        //{
        //    // database

        //    await using var context = new DbContextPortal();

        //    var model = await context.Roles
        //        .Include(p => p.Permissions)
        //        .ThenInclude(p => p.User)
        //        .SingleOrDefaultAsync(p => p.Id == id);

        //    if (model == null) throw new ArgumentNullException(nameof(model));

        //    // mapping

        //    var users = model.Permissions.Select(entry => new RoleDetailsUserVm()
        //    {
        //        Id = entry.User.Id,
        //        Name = $"{entry.User.FirstName} {entry.User.LastName}",
        //    })
        //        .ToList();

        //    var view = new RoleDetailsVm
        //    {
        //        Id = model.Id,
        //        Name = model.Name,
        //        Users = users,
        //    };

        //    return view;
        //}
    }
}
