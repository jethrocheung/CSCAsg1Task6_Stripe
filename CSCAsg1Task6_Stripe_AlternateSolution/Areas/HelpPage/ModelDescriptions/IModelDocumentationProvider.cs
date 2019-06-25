using System;
using System.Reflection;

namespace CSCAsg1Task6_Stripe_AlternateSolution.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}