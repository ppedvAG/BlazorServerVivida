using Microsoft.AspNetCore.Components.Forms;

namespace BlazorServerVivida.Pages.Modul5
{
    public class FieldClassBootstrapFix : FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isinvalid = editContext.GetValidationMessages(fieldIdentifier).Any();

            return isinvalid ? "is-invalid":"is-valid";
           

        }
    }
}
