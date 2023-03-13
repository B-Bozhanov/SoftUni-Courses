using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Exam.Categorization
{
    public class Category : IComparable<Category>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public SortedDictionary<string, Category> children = new SortedDictionary<string, Category>();

        public Category(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int CompareTo(Category other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
