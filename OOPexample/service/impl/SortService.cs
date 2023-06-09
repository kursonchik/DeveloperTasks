﻿using System.Reflection;
using Task1.entity;
using Task1.service.interfaces;

namespace Task1.service.impl
{
    public class SortService : ISort
    {
        // Task 3.1 Writes every Vehicle type name to the console, sorted alphabetically.
        public List<Vehicle> SortByAlphabet(List<Vehicle> originalList)
        {
            originalList.Sort((x, y) => string.Compare(x.Name, y.Name));
            return originalList;
        }

        // Task 3.2 Search for types by specifying part of the name
        public static Type GetTypeByName(string Name)
        {
            Assembly OurAssembly = Assembly.GetExecutingAssembly();
            foreach (TypeInfo DefinedType in OurAssembly.DefinedTypes)
            {
                if (DefinedType.Name.Contains(Name))
                  
                {
                    return DefinedType;
                    
                }
            }

            return null;
        }
    }
}

