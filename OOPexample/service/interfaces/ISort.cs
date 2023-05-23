using Task1.entity;

namespace Task1.service.interfaces
{
    public interface ISort
    {
        List<Vehicle> SortByAlphabet(List<Vehicle> originalList);

    }
}

