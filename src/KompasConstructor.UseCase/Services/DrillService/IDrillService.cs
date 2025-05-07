using KompasConstructor.Core.Entities;

namespace KompasConstructor.UseCase.Services.DrillService
{
    public interface IDrillService
    {
        Task<ToolConstructResult> ConstructDrill();
    }
}
