using System.Collections.Generic;

namespace UnitySpec.Bindings.Discovery
{
    public interface IBindingSourceProcessor
    {
        bool CanProcessTypeAttribute(string attributeTypeName);
        bool CanProcessMethodAttribute(string attributeTypeName);

        bool PreFilterType(IEnumerable<string> attributeTypeNames);

        bool ProcessType(BindingSourceType bindingSourceType);
        void ProcessMethod(BindingSourceMethod bindingSourceMethod);
        void ProcessTypeDone();
    }
}