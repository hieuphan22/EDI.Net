using Edi.Domain.Shared.Enums;
using Scm.Edi.Domain.Shared.Attributes;

namespace Edi.Domain.Shared.Attributes
{
    public class EdiExtensionAttribute : BaseAttribute
    {
        public EdiExtensionAttribute() {

        }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public bool Mandatory { get; set; }

        public EdiType EdiType { get; set; }

        public bool ExtendedValidCharacters { get; set; } = true;

    }

    public class EdiAllowValueAttribute : BaseAttribute
    {
        public EdiAllowValueAttribute() {

        }

        public string[] AllowedValues { get; set; }
    }
}