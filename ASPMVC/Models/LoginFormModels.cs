using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ASPMVC.Models
{
	public class LoginFormModels 
	{
		[Required(ErrorMessage = "Nom requis")]
		public string nom { get; set; }
		[Required(ErrorMessage = "Prénom requis")]
        public string prenom { get; set; }

		[Required(ErrorMessage = "Email requis")]
		[EmailAddress(ErrorMessage = "Mauvais format de mail")]
        public string email { get; set; }
		[Required(ErrorMessage = "Mot de passe requis")]
        public string mdp { get; set; }

		//public static void ValidateLoginForm(LoginFormModels form, ModelStateDictionary modelState)
		//{
		//	modelState.Clear();
		//	if (string.IsNullOrEmpty(form.nom))
		//	{
		//		modelState.AddModelError(nameof(form.nom), "Nom obligatoire");
		//	}

		//	if (string.IsNullOrEmpty(form.prenom))
		//	{
		//		modelState.AddModelError(nameof(form.prenom), "Prénom obligatoire");
		//	}

		//	if (string.IsNullOrWhiteSpace(form.email))
		//	{
		//		modelState.AddModelError(nameof(form.email), "Email obligatoire");
		//	}
		//	if (string.IsNullOrWhiteSpace(form.mdp))
		//	{
		//		modelState.AddModelError(nameof(form.mdp), "Mot de passe obligatoire");
		//	}
		//}

	}
}

    
