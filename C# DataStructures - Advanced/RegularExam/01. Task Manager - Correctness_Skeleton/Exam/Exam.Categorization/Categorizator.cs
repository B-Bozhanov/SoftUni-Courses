using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.Categorization
{
    public class Categorizator : ICategorizator
    {
        private Dictionary<string, Category> categories = new Dictionary<string, Category>();
        private Dictionary<string, SortedSet<Category>> parrents = new Dictionary<string, SortedSet<Category>>();


        public void AddCategory(Category category)
        {
            if (this.categories.ContainsKey(category.Id))
            {
                throw new ArgumentException();
            }

            this.categories.Add(category.Id, category);
        }

        public void AssignParent(string childCategoryId, string parentCategoryId)
        {
            if (!this.categories.ContainsKey(childCategoryId) || !this.categories.ContainsKey(parentCategoryId))
            {
                throw new ArgumentException();
            }

            if (this.categories[parentCategoryId].children.ContainsKey(childCategoryId))
            {
                throw new ArgumentException();
            }
            this.categories[parentCategoryId].children.Add(childCategoryId, this.categories[childCategoryId]);
            //if (!this.parrents.ContainsKey(parentCategoryId))
            //{
            //    this.parrents.Add(parentCategoryId, new SortedSet<Category>());
            //}

            //if (this.parrents[parentCategoryId].Contains(this.categories[childCategoryId]))
            //{
            //    throw new ArgumentException();
            //}

            //this.parrents[parentCategoryId].Add(this.categories[childCategoryId]);
        }

        public bool Contains(Category category)
        {
            return this.categories.ContainsKey(category.Id);
        }

        public IEnumerable<Category> GetChildren(string categoryId)
        {
            if (!this.categories.ContainsKey(categoryId))
            {
                throw new ArgumentException();
            }

            return this.categories[categoryId].children.Values;
        }

        public IEnumerable<Category> GetHierarchy(string categoryId)
        {
            if (!this.categories.ContainsKey(categoryId))
            {
                throw new ArgumentException();
            }

            return this.categories[categoryId].children.Values;
        }

        public IEnumerable<Category> GetTop3CategoriesOrderedByDepthOfChildrenThenByName()
        {
            return null;
        }

        public void RemoveCategory(string categoryId)
        {
            if (!this.categories.ContainsKey(categoryId))
            {
                throw new ArgumentException();
            }

            this.categories.Remove(categoryId);
        }

        public int Size()
        {
            return this.categories.Count;
        }
    }
}
