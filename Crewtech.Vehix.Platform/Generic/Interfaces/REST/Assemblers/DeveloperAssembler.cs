using Crewtech.Vehix.Platform.Generic.Domain.Model.Entities;
using Crewtech.Vehix.Platform.Generic.Interfaces.REST.Resources;

namespace Crewtech.Vehix.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// This class is responsible for convert from REST resources to domain entities
/// </summary>
public static class DeveloperAssembler
{
    /// <summary>
    /// Convert from REST resource to domain entity
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public static Developer? ToEntityFromRequest(GreetDeveloperRequest? request)
    {
        if(request == null || 
           string.IsNullOrWhiteSpace(request.FirstName) || 
           string.IsNullOrWhiteSpace(request.LastName))
        {
            return null;
        }
        return new Developer(request.FirstName, request.LastName);
    }
}