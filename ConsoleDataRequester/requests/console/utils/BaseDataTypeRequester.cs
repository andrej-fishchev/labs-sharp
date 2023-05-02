using UserDataRequester.converters.console.utils;
using UserDataRequester.responses;
using UserDataRequester.validators;

namespace UserDataRequester.requests.console.utils;

public static class BaseDataTypeRequester
{
    public static IResponsibleData<object> RequestString(
        string what, 
        IValidatableData? validator = default,
        string? terminateString = "..."
    ) => BaseRequester.While(what, validator: validator, terminateString: terminateString);
    
    public static IResponsibleData<object> RequestInt(
        string what,
        IValidatableData? validator = default,
        string? terminateString = "..."
    ) => BaseRequester.While(what, BaseDataConverterFactory.MakeSimpleIntConverter(), validator, terminateString);

    public static IResponsibleData<object> RequestDouble(
        string what,
        IValidatableData? validator = default,
        string? terminateString = "..."
    ) => BaseRequester.While(what, BaseDataConverterFactory.MakeDoubleConverterList(), validator, terminateString);
}