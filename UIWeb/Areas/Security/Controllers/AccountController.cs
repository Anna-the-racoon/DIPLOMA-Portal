using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UIWeb.Areas.Security.Model;

namespace UIWeb.Areas.Security.Controllers
{
    [Area("Security")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        //#region Registration New Account
        //[HttpGet]
        //public IActionResult Register() => View();

//        [HttpPost]
//        [ValidateAntiForgeryToken()]
//        public async Task<IActionResult> Register(RegisterVm model)
//        {
//            if (!ModelState.IsValid) return View(model);

//            var service = new ServiceAccount();

//            var result = await service.RegisterAsync(model, new Hmacsha1());

//            if (result == RegisterResult.Succeeded)
//                return RedirectToAction("RegisterConfirmation", "Account", new { Area = "Security", email = model.Email });

//            if (result == RegisterResult.UserIsLockedOut)
//            {
//                ModelState.AddModelError("UserIsLockedOut", "User is locked out.");
//                return View(model);
//            }

//            if (result == RegisterResult.UserExistAndIsEmailNotConfirmed)
//            {
//                ModelState.AddModelError("UserExistAndIsEmailNotConfirmed", "User already exists and email hasn't been confirmed.");
//                return View(model);
//            }

//            if (result == RegisterResult.UserExistAndIsEmailConfirmed)
//            {
//                ModelState.AddModelError("UserExistAndIsEmailNotConfirmed", "User already exists and email has been confirmed.");
//                return View(model);
//            }

//            ModelState.AddModelError("SomethingWrong", "Something went wrong.");
//            return View(model);
//        }
//        [HttpGet]
//        public async Task<IActionResult> RegisterConfirmation(string email)
//        {
//            if (email == null) return new StatusCodeResult(StatusCodes.Status400BadRequest);

//            var service = new ServiceAccount();

//            var token = await service.GetTokenAsync(email);

//#if DEBUG
//            var confirmationLink = $"http://localhost:5000{Url.Action("RegisterConfirmEmail", "Account", new { Area = "Security", token })}";
//#else
//#endif
//#if TESTING
//            var confirmationLink = $"http://localhost:5010{Url.Action("RegisterConfirmEmail", "Account", new { Area = "Security", token })}";
//#endif
//#if RELEASE
//            var confirmationLink = $"http://portal.hmmr.ru{Url.Action("RegisterConfirmEmail", "Account", new { Area = "Security", token })}";
//#endif
//            var model = await service.RegisterConfirmationSendAsync(new MailMessageSender(), email, confirmationLink);

//            return View(model);
//        }
//        [HttpGet]
//        public async Task<IActionResult> RegisterConfirmEmail(Guid? token)
//        {
//            if (token == null) return new StatusCodeResult(StatusCodes.Status400BadRequest);
//            try
//            {
//                var service = new ServiceAccount();
//                var email = await service.ConfirmEmail(token);
//                return View(new RegisterConfirmEmailVm() { StatusMessage = $"The email {email} has been successfully confirmed!" });
//            }
//            catch (Exception exception)
//            {
//                var message = new StringBuilder();
//                message.AppendLine("Error. Sorry, the email has not been confirmed!");
//                message.AppendLine($"token : {token}");
//                message.AppendLine(exception.Message);
//                return View(new RegisterConfirmEmailVm() { StatusMessage = message.ToString() });
//            }
//        }
//        #endregion

//        #region Forgot Password        
//        [HttpGet]
//        public IActionResult ForgotPassword()
//        {
//            return View(new ForgotPasswordVm());
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken()]
//        public async Task<IActionResult> ForgotPassword(ForgotPasswordVm model)
//        {
//            if (!ModelState.IsValid) return View(model);

//            var service = new ServiceAccount();

//            var result = await service.ForgotPassword(model);

//            if (result == ForgotPasswordResult.Succeeded)
//            {
//                return RedirectToAction("ForgotPasswordConfirmation", "Account", new { Area = "Security", email = model.Email });
//            }

//            if (result == ForgotPasswordResult.UserNotFound)
//            {
//                ModelState.AddModelError("UserNotFound", "User has not been found.");
//                return View(model);
//            }

//            if (result == ForgotPasswordResult.EmailNotConfirmed)
//            {
//                ModelState.AddModelError("EmailNotConfirmed", "Email not confirmed.");
//                return View(model);
//            }

//            if (result == ForgotPasswordResult.UserIsLockedOut)
//            {
//                ModelState.AddModelError("UserIsLockedOut", "User is locked out.");
//                return View(model);
//            }

//            ModelState.AddModelError("SomethingWrong", "Something went wrong.");
//            return View(model);
//        }
//        [HttpGet]
//        public async Task<IActionResult> ForgotPasswordConfirmation(string email)
//        {
//            if (email == null) return new StatusCodeResult(StatusCodes.Status400BadRequest);

//            var service = new ServiceAccount();

//            var token = await service.GetTokenAsync(email);

//#if DEBUG
//            var confirmationLink = $"http://localhost:5000{Url.Action("ResetPassword", "Account", new { Area = "Security", token })}";
//#endif
//#if TESTING
//            var confirmationLink = $"http://localhost:5010{Url.Action("ResetPassword", "Account", new { Area = "Security", token })}";
//#endif
//#if RELEASE
//            var confirmationLink = $"http://portal.hmmr.ru{Url.Action("ResetPassword", "Account", new { Area = "Security", token })}";
//#endif


//            var model = await service.ForgotPasswordConfirmationSendAsync(new MailMessageSender(), email, confirmationLink);

//            return View(model);
//        }
//        [HttpGet]
//        public IActionResult ResetPassword(Guid token)
//        {
//            return View(new ResetPasswordVm() { Token = token });
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken()]
//        public async Task<IActionResult> ResetPassword(ResetPasswordVm model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(model);
//            }
//            var service = new ServiceAccount();

//            var result = await service.ResetPasswordAsync(model, new Hmacsha1());

//            if (result == ResetPasswordResult.Succeeded)
//            {
//                var email = await service.GetEmailAsync(model.Token);

//                return RedirectToAction("ResetPasswordConfirmation", "Account", new { Area = "Security", email });
//            }

//            if (result == ResetPasswordResult.UserNotFound)
//            {
//                ModelState.AddModelError("UserNotFound", "User has not been found.");
//                return View(model);
//            }

//            if (result == ResetPasswordResult.EmailNotConfirmed)
//            {
//                ModelState.AddModelError("EmailNotConfirmed", "Email not confirmed.");
//                return View(model);
//            }

//            if (result == ResetPasswordResult.UserIsLockedOut)
//            {
//                ModelState.AddModelError("UserIsLockedOut", "User is locked out.");
//                return View(model);
//            }

//            ModelState.AddModelError("SomethingWrong", "Something went wrong.");
//            return View(model);
//        }
//        [HttpGet]
//        public IActionResult ResetPasswordConfirmation(string email)
//        {
//            if (email == null) return new StatusCodeResult(StatusCodes.Status400BadRequest);
//            try
//            {
//                return View(new ResetPasswordConfirmEmailVm() { StatusMessage = $"The password has successfully been reset for the e-mail {email}." });
//            }
//            catch (Exception exception)
//            {
//                var message = new StringBuilder();
//                message.AppendLine("$Error. Sorry, the {email} has not been confirmed!");
//                message.AppendLine(exception.Message);
//                return View(new ResetPasswordConfirmEmailVm() { StatusMessage = message.ToString() });
//            }
//        }
//        #endregion

//        [HttpGet]
//        public IActionResult Login(string returnUrl)
//        {
//            ViewBag.ReturnUrl = returnUrl; // returnUrl - работает только для страниц где требуется авторизация.
//            return View(new LoginVm() { RememberMe = true });
//        }
//        [HttpPost]
//        [ValidateAntiForgeryToken()]
//        public async Task<IActionResult> Login(string email, string password, bool rememberMe, string returnUrl)
//        {
//            if (email == null || password == null) return new StatusCodeResult(StatusCodes.Status400BadRequest);

//            returnUrl ??= Url.Content("~/");

//            var service = new ServiceAccount();

//            var result = await service.LoginAsync(new Hmacsha1(), email, password);

//            if (result == LoginResult.Succeeded)
//            {
//                var claim = await service.GetClaimAuthentificationAsync(email);

//                var claims = new List<Claim>
//                {
//                    new Claim(ClaimsIdentity.DefaultNameClaimType, claim.Name),
//                    new Claim(ClaimTypes.NameIdentifier, claim.UserId.ToString()),
//                };

//                foreach (var role in claim.Roles)
//                {
//                    claims.Add(new Claim(ClaimTypes.Role, role));
//                }

//                var identity = new ClaimsIdentity(claims, ClaimsIdentity.DefaultNameClaimType);

//                var principal = new ClaimsPrincipal(identity);

//                var properties = new AuthenticationProperties { IsPersistent = rememberMe };

//                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, properties);

//                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
//                    return Redirect(returnUrl);
//                else
//                    return RedirectToAction("Index", "Home", new { Area = "" });
//                //return LocalRedirect(returnUrl);
//            }
//            if (result == LoginResult.InvalidLoginAttempt)
//            {
//                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
//                return View();
//            }
//            if (result == LoginResult.IsLockedOut)
//            {
//                ModelState.AddModelError(string.Empty, "Account is locked.");
//                return View();
//            }
//            if (result == LoginResult.EmailNotConfirmed)
//            {
//                ModelState.AddModelError(string.Empty, "E-mail is not confirmed.");
//                return View();
//            }

//            ModelState.AddModelError(string.Empty, "Something went wrong.");
//            return View();
//        }
//        public async Task<IActionResult> Logout(string returnUrl = null)
//        {
//            await HttpContext.SignOutAsync();

//            if (returnUrl != null)
//            {
//                return LocalRedirect(returnUrl);
//            }

//            return View();
//        }
//        public IActionResult AccessDenied()
//        {
//            return View();
//        }
//        public IActionResult Lockout()
//        {
//            return View();
//        }
//        public IActionResult ConfirmEmailChange()
//        {
//            //public async Task<IActionResult> OnGetAsync(string userId, string email, string code)
//            //{
//            //    if (userId == null || email == null || code == null)
//            //    {
//            //        return RedirectToPage("/Index");
//            //    }

//            //    var user = await _userManager.FindByIdAsync(userId);
//            //    if (user == null)
//            //    {
//            //        return NotFound($"Unable to load user with ID '{userId}'.");
//            //    }

//            //    code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
//            //    var result = await _userManager.ChangeEmailAsync(user, email, code);
//            //    if (!result.Succeeded)
//            //    {
//            //        StatusMessage = "Error changing email.";
//            //        return Page();
//            //    }

//            //    // In our UI email and user name are one and the same, so when we update the email
//            //    // we need to update the user name.
//            //    var setUserNameResult = await _userManager.SetUserNameAsync(user, email);
//            //    if (!setUserNameResult.Succeeded)
//            //    {
//            //        StatusMessage = "Error changing user name.";
//            //        return Page();
//            //    }

//            //    await _signInManager.RefreshSignInAsync(user);
//            //    StatusMessage = "Thank you for confirming your email change.";
//            //    return Page();
//            //}

//            return View();
//        }
    }
}
