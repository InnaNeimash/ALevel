using Salad.Models;

namespace Salad.Services.Abstractions
{
    public interface ISaladService
    {
        List<Vegetables> FindVegetable(List<Vegetables> vegetables);
        List<Vegetables> SortByParameter(List<Vegetables> vegetables);
    }
}