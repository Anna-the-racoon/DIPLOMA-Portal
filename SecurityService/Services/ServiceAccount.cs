using Logic.Security.Types;
using SecurityService.Model;
using SecurityService.Password;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SecurityService.Services
{
    internal class ServiceAccount 
    {

        //public async Task<RegisterResult> RegisterAsync(RegisterVm view, IEncryptor encryptor)
        //{

        //    await using var context = new DbContextSecurityService();

        //    await using var transaction = context.Database.BeginTransaction(IsolationLevel.Serializable);

        //    try
        //    {
        //        var model = await context.Users.SingleOrDefaultAsync(p => p.Email == view.Email);


        //        if (model != null && model.IsLockedOut) return RegisterResult.UserIsLockedOut;

        //        if (model != null && model.IsEmailConfirmed) return RegisterResult.UserExistAndIsEmailConfirmed;

        //        if (model != null && !model.IsEmailConfirmed) return RegisterResult.UserExistAndIsEmailNotConfirmed;

        //        var user = await context.Users.AddAsync(new User()
        //        {
        //            FirstName = view.FirstName,
        //            LastName = view.LastName,
        //            Email = view.Email,
        //            Password = encryptor.Execute(view.Password),
        //            IsLockedOut = false,
        //            IsEmailConfirmed = false,
        //            Token = Guid.NewGuid(),
        //        });

        //        await context.SaveChangesAsync();

        //        var role = await context.Roles.SingleOrDefaultAsync(p => p.Name == RoleType.Visitor.ToString());

        //        if (role == null)
        //        {
        //            var models = await context.Roles
        //                .Include(p => p.Permissions)
        //                .ThenInclude(p => p.User)
        //                .Where(p => p.Name == RoleType.Administrator.ToString())
        //                .SelectMany(p => p.Permissions.Select(e => new { e.User.FirstName, e.User.LastName, e.User.Email }))
        //                .ToListAsync();

        //            var admins = models.Aggregate<dynamic, string>(null, (current, value) => (current == null ? $": {value.FirstName} {value.LastName} ({value.Email})" : current + $",{value.FirstName} {value.FirstName} ({value.Email})"));

        //            var message = $"The Visitor role is not present in the database. Please contact your administrator{admins}.";
        //            throw new ArgumentNullException(nameof(role), message);
        //        }

        //        await context.Permissions.AddAsync(new Permission()
        //        {
        //            UserId = user.Entity.Id,
        //            RoleId = role.Id,
        //        });

        //        await context.SaveChangesAsync();

        //        await transaction.CommitAsync();

        //        return RegisterResult.Succeeded;

        //    }
        //    catch (Exception)
        //    {
        //        await transaction.RollbackAsync();
        //        throw;
        //    }
        //}
        //public async Task<RegisterConfirmationVm> RegisterConfirmationSendAsync(IMessageSender message, string to, string confirmationLink)
        //{
        //    const string from = "portal@internalmail.hmmr.ru";
        //    const string password = "d23dad32SDf324r3fs";
        //    const string subject = "[action required] confirm your e-mail on the portal.hmmr.ru";
        //    var body = new StringBuilder();
        //    body.AppendLine("День добрый, <br/>");
        //    body.AppendLine($"Уважаемый пользователь, Вы получили это письмо потому что зарегистрировались на сайте <a href='portal.hmmr.ru'>portal.hmmr.ru</a> <br/>");
        //    body.AppendLine($"Для того, чтобы завершить регистрацию и подтвердит правильность указанной вами почты, пожалуйста пройтиде по ссылке <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>confirm email</a>. <br/>");
        //    body.AppendLine("Если вы не регистрировались на сайте, пожалуйста игнорируйте это письмо. <br/>");
        //    body.AppendLine("<br/>");
        //    body.AppendLine("С уважением, <br/>");
        //    body.AppendLine("portal.hmmr.ru");

        //    await message.SendAsync(from, password, to, subject, body.ToString());

        //    return new RegisterConfirmationVm() { Email = to };
        //}
        //public async Task<string> ConfirmEmail(Guid? token)
        //{
        //    await using var context = new DbContextPortal();
        //    var model = await context.Users.SingleOrDefaultAsync(p => p.Token == token);
        //    if (model == null) throw new Exception($"The user does not exist.");
        //    model.IsEmailConfirmed = true;
        //    await context.SaveChangesAsync();
        //    return model.Email;
        //}
        //public async Task<ForgotPasswordResult> ForgotPassword(ForgotPasswordVm view)
        //{
        //    await using var context = new DbContextPortal();

        //    var model = await context.Users.SingleOrDefaultAsync(p => p.Email == view.Email);

        //    if (model == null) return ForgotPasswordResult.UserNotFound;

        //    if (!model.IsEmailConfirmed) return ForgotPasswordResult.EmailNotConfirmed;

        //    if (model.IsLockedOut) return ForgotPasswordResult.UserIsLockedOut;

        //    // отказался от идеи блокировать аккаунт
        //    // иначе любой сможет указывать чужой ящик и блокировать чужие аккаунты
        //    //model.IsLockedOut = true;

        //    model.Token = Guid.NewGuid();

        //    await context.SaveChangesAsync();

        //    return ForgotPasswordResult.Succeeded;
        //}
        //public async Task<RegisterConfirmationVm> ForgotPasswordConfirmationSendAsync(IMessageSender message, string to, string confirmationLink)
        //{
        //    const string from = "portal@internalmail.hmmr.ru";
        //    const string password = "d23dad32SDf324r3fs";
        //    const string subject = "[action required] reset your password on the portal.hmmr.ru";
        //    var body = new StringBuilder();
        //    body.AppendLine("День добрый, <br/>");
        //    body.AppendLine($"Уважаемый пользователь, Вы получили это письмо потому что запросили сброс пароля для сайта <a href='portal.hmmr.ru'>portal.hmmr.ru</a> <br/>");
        //    body.AppendLine($"Для того, чтобы завершить сброс пароля, пожалуйста пройтиде по ссылке <a href='{HtmlEncoder.Default.Encode(confirmationLink)}'>reset password</a>. <br/>");
        //    body.AppendLine("Если вы не сбрасывали пароль на сайте, пожалуйста игнорируйте это письмо. <br/>");
        //    body.AppendLine("<br/>");
        //    body.AppendLine("С уважением, <br/>");
        //    body.AppendLine("portal.hmmr.ru");

        //    await message.SendAsync(from, password, to, subject, body.ToString());

        //    return new RegisterConfirmationVm() { Email = to };
        //}
        //public async Task<ResetPasswordResult> ResetPasswordAsync(ResetPasswordVm view, IEncryptor encryptor)
        //{
        //    await using var context = new DbContextPortal();

        //    var model = await context.Users.SingleOrDefaultAsync(p => p.Token == view.Token);

        //    if (model == null) return ResetPasswordResult.InvalidResetAttempt;

        //    if (!model.IsEmailConfirmed) return ResetPasswordResult.EmailNotConfirmed;

        //    if (model.IsLockedOut) return ResetPasswordResult.UserIsLockedOut;

        //    model.Password = encryptor.Execute(view.Password);

        //    await context.SaveChangesAsync();

        //    return ResetPasswordResult.Succeeded;
        //}
        //public async Task<LoginResult> LoginAsync(IEncryptor encryptor, string email, string password)
        //{
        //    await using var context = new DbContextPortal();

        //    var model = await context.Users.SingleOrDefaultAsync(p => p.Email == email & p.Password == encryptor.Execute(password));

        //    if (model == null) return LoginResult.InvalidLoginAttempt;

        //    if (model.IsLockedOut) return LoginResult.IsLockedOut;

        //    if (!model.IsEmailConfirmed) return LoginResult.EmailNotConfirmed;

        //    return LoginResult.Succeeded;
        //}
        //public async Task<Guid> GetTokenAsync(string email)
        //{
        //    await using var context = new DbContextPortal();
        //    var model = await context.Users.SingleOrDefaultAsync(p => p.Email == email);
        //    return model.Token;
        //}
        //public async Task<string> GetEmailAsync(Guid token)
        //{
        //    await using var context = new DbContextPortal();
        //    var model = await context.Users.SingleOrDefaultAsync(p => p.Token == token);
        //    return model.Email;
        //}

        //public async Task<ClaimAuthentification> GetClaimAuthentificationAsync(string email)
        //{
        //    await using var context = new DbContextPortal();
        //    var model = await context.Users
        //        .Include(p => p.Permissions)
        //        .ThenInclude(e => e.Role)
        //        .SingleOrDefaultAsync(p => p.Email == email);
        //    var view = new ClaimAuthentification()
        //    {
        //        UserId = model.Id,
        //        Name = $"{model.FirstName} {model.LastName}",
        //        Roles = model.Permissions.Select(p => p.Role.Name)
        //    };
        //    return view;
        //}

    }
}
