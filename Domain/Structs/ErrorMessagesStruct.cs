using System.Numerics;

namespace BHDSeguros.Domain.Structs
{
    public struct ErrorMessagesStruct
    {
        public const string INVALIDAGE = "El Cliente no tiene una edad valida para el plan. ";
        public const string CLIENTALREADYGOTTHISPLAN = "El Cliente ya tiene este plan. ";
        public const string INVALIDPRODUCTTYPE = "El tipo de producto no es valido";
        public const string INVALIDPRODUCTTYPEFORPLAN = "El tipo de producto no es valido para el plan. ";

        public const string INVALIDSECURETYPE = "Tipo de seguro no existe.";
    }
}
