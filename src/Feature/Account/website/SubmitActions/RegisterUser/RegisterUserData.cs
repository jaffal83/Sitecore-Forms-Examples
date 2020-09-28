using System;

namespace SitecoreForms.Feature.Account.SubmitActions.RegisterUser
{
    public class RegisterUserData
	{
		public Guid EmailFieldId { get; set; }

		public Guid PasswordFieldId { get; set; }

		public Guid FullNameFieldId { get; set; }

		public string ProfileId { get; set; }
	}
}
