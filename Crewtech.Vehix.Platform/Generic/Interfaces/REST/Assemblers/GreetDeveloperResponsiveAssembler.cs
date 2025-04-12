using Crewtech.Vehix.Platform.Generic.Domain.Model.Entities;
using Crewtech.Vehix.Platform.Generic.Interfaces.REST.Resources;

namespace Crewtech.Vehix.Platform.Generic.Interfaces.REST.Assemblers;

/// <summary>
/// This class is responsible for converting a Developer entity to a GreetDeveloperResponse.
/// </summary>
public static class GreetDeveloperResponseAssembler
{
    /// <summary>
    /// Converts a develope entit to a GreetDeveloperResponse
    /// </summary>
    /// <param name="developer">The Developer entity to convert</param>
    /// <returns>A GreetDeveloperResponse object</returns>
    public static GreetDeveloperResponse ToResponseFromEntity(Developer? developer)
    {
        if(developer == null || developer.IsAnyNameEmpty())
            return new GreetDeveloperResponse("Welcome Anonymous ASP.NET Developer");
        return new GreetDeveloperResponse(developer.Id, developer.GetFullName(),
            $"Congrats {developer.GetFullName()}! You are an ASP.NET Developer");
    }
}